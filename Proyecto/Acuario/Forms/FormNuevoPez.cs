using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormNuevoPez : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        private List<int> idEspeciesCombobox;
        private List<int> idVariedadesCombobox;
        private List<int> idTamañosCombobox;

        private EntitiePez pezAModificar;
        private Boolean modificando;

        // |==============================CONSTRUCTORES==============================|
        public FormNuevoPez()
        {
            InitializeComponent();

            modificando = false;
        }

        public FormNuevoPez(int idPezAModificar)
        {
            InitializeComponent();

            this.pezAModificar = ControllerPeces.Instance.GetPezById(idPezAModificar);
            modificando = true;

            PrepararModoModificacion();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void PopulateComboboxes()
        {
            ControllerPeces.Instance.PopulateComboboxEspecies(ref comboboxEspecies, ref idEspeciesCombobox);

            ControllerPeces.Instance.PopulateComboboxVariedades(ref comboboxVariedades,
                        ref idVariedadesCombobox, idEspeciesCombobox[comboboxEspecies.SelectedIndex], true);

            ControllerPeces.Instance.PopulateComboboxTamaños(ref comboboxTamaños, ref idTamañosCombobox);
        }

        private Boolean ValidInput()
        {
            if (textboxNombre.Text.Equals(String.Empty))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Debe compeltar el nombre");
                return false;
            }

            if (
                !(
                (textboxPrecioMinorista.Text.Equals("") ||
                (!textboxPrecioMinorista.Text.Equals("") && ManagerFormats.Instance.MontoValido(textboxPrecioMinorista.Text))) &&

                (textboxPrecioMayorista.Text.Equals("") ||
                (!textboxPrecioMayorista.Text.Equals("") && ManagerFormats.Instance.MontoValido(textboxPrecioMayorista.Text))) &&

                (textboxPrecioOferta.Text.Equals("") ||
                (!textboxPrecioOferta.Text.Equals("") && ManagerFormats.Instance.MontoValido(textboxPrecioOferta.Text))) &&

                (textboxPrecioDistribuidor.Text.Equals("") ||
                (!textboxPrecioDistribuidor.Text.Equals("") && ManagerFormats.Instance.MontoValido(textboxPrecioDistribuidor.Text)))
                )
                )
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Alguno de los montos es inválido");
                return false;
            }

            return true;
        }

        private Boolean PezExistente()
        {
            if (ControllerPeces.Instance.PezExistente(idEspeciesCombobox[comboboxEspecies.SelectedIndex],
                idEspeciesCombobox[comboboxEspecies.SelectedIndex]))
            {
                String especie = comboboxEspecies.Items[comboboxEspecies.SelectedIndex].ToString();
                String variedad = comboboxVariedades.Items[comboboxVariedades.SelectedIndex].ToString();

                ManagerMessages.Instance.NewInformationMessage(this, "El pez de especie '" + especie + "' " +
                    "y variedad '" + variedad + "' ya existe");
                return true;
            }

            return false;
        }

        private int CrearPrecio()
        {
            Decimal precioMinorista = 0;
            Decimal precioMayorista = 0;
            Decimal precioOferta = 0;
            Decimal precioDistribuidor = 0;

            if (!textboxPrecioMinorista.Text.Trim().Equals(String.Empty))
                precioMinorista = ManagerFormats.Instance.MoneyToDecimal(textboxPrecioMinorista.Text);

            if (!textboxPrecioMinorista.Text.Trim().Equals(String.Empty))
                precioMayorista = ManagerFormats.Instance.MoneyToDecimal(textboxPrecioMayorista.Text);

            if (!textboxPrecioMinorista.Text.Trim().Equals(String.Empty))
                precioOferta = ManagerFormats.Instance.MoneyToDecimal(textboxPrecioOferta.Text);

            if (!textboxPrecioMinorista.Text.Trim().Equals(String.Empty))
                precioDistribuidor = ManagerFormats.Instance.MoneyToDecimal(textboxPrecioDistribuidor.Text);

            return ControllerPrecios.Instance.CrearPrecio(
                new EntitiePrecio(precioMinorista, precioMayorista, precioOferta, precioDistribuidor));
        }

        private void CrearPez()
        {
            int idPrecio = CrearPrecio();

            int stock = 0;

            if (!textboxPrecioMinorista.Text.Trim().Equals(String.Empty))
                stock = Convert.ToInt32(textboxStock.Text);

            ControllerPeces.Instance.CrearPez(new EntitiePez(idVariedadesCombobox[comboboxVariedades.SelectedIndex],
                idTamañosCombobox[comboboxTamaños.SelectedIndex], idPrecio, textboxNombre.Text, stock));
            ManagerMessages.Instance.NewInformationMessage(this, "Pez creado");
        }

        private void ModificarPez()
        {
            int idPrecio = CrearPrecio();

            int stock = 0;

            if (!textboxPrecioMinorista.Text.Trim().Equals(String.Empty))
                stock = Convert.ToInt32(textboxStock.Text);

            ControllerPeces.Instance.ModificarPez(pezAModificar.GetIdPez(), new EntitiePez(idVariedadesCombobox[comboboxVariedades.SelectedIndex],
                idTamañosCombobox[comboboxTamaños.SelectedIndex], idPrecio, textboxNombre.Text, stock));

            ManagerMessages.Instance.NewInformationMessage(this, "Pez modificado");
        }

        private void PrepararModoModificacion()
        {
            btnCrearPez.Text = "Modificar";
            btnNuevaEspecie.Visible = false;
            btnNuevaVariedad.Visible = false;
        }

        private void FillCampos()
        {
            textboxNombre.Text = pezAModificar.GetNombre();
            EntitiePezVariedad variedad = pezAModificar.GetVariedad();
            EntitiePrecio precio = pezAModificar.GetPrecio();

            // Combo especies
            if (variedad != null && variedad.GetIdPezEspecie() > 0)
            {
                for (int i = 0; i < idEspeciesCombobox.Count; i++)
                {
                    if (idEspeciesCombobox[i] == variedad.GetIdPezEspecie())
                        comboboxEspecies.SelectedIndex = i;
                }
            }

            // Combo variedades
            if (variedad != null)
            {
                for (int i = 0; i < idVariedadesCombobox.Count; i++)
                {
                    if (idVariedadesCombobox[i] == pezAModificar.GetIdVariedad())
                        comboboxVariedades.SelectedIndex = i;
                }
            }

            // Combo tamaños
            for (int i = 0; i < idTamañosCombobox.Count; i++)
            {
                if (idTamañosCombobox[i] == pezAModificar.GetIdTamaño())
                    comboboxTamaños.SelectedIndex = i;
            }

            textboxStock.Text = pezAModificar.GetStock().ToString();
            textboxPrecioMinorista.Text = ManagerFormats.Instance.DecimalToMoney(precio.GetPrecioMinorista(), false);
            textboxPrecioMayorista.Text = ManagerFormats.Instance.DecimalToMoney(precio.GetPrecioMayorista(), false);
            textboxPrecioOferta.Text = ManagerFormats.Instance.DecimalToMoney(precio.GetPrecioOferta(), false);
            textboxPrecioDistribuidor.Text = ManagerFormats.Instance.DecimalToMoney(precio.GetPrecioDistribuidor(), false);
        }

        // |==============================EVENTOS==============================|

        private void FormNuevoPez_Load(object sender, EventArgs e)
        {
            PopulateComboboxes();

            if (modificando)
                FillCampos();
        }

        private void btnCrearPez_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                if (!modificando && !PezExistente())
                {
                    CrearPez();
                    DialogResult = DialogResult.OK;
                    Close();
                }

                else if (modificando)
                {
                    ModificarPez();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnNuevaEspecie_Click(object sender, EventArgs e)
        {
            using (var form = new FormNuevaEspecie())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    ControllerPeces.Instance.PopulateComboboxEspecies(ref comboboxEspecies, ref idEspeciesCombobox);
            }
        }

        private void btnNuevaVariedad_Click(object sender, EventArgs e)
        {
            using (var form = new FormNuevaVariedad())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    ControllerPeces.Instance.PopulateComboboxVariedades(ref comboboxVariedades,
                        ref idVariedadesCombobox, idEspeciesCombobox[comboboxEspecies.SelectedIndex], true);
            }
        }

        private void comboboxEspecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControllerPeces.Instance.PopulateComboboxVariedades(ref comboboxVariedades,
                ref idVariedadesCombobox, idEspeciesCombobox[comboboxEspecies.SelectedIndex], true);
        }

        private void FormNuevoPez_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}
