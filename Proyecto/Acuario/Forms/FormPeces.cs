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
    public partial class FormPeces : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        private List<int> idEspeciesCombobox;
        private List<int> idVariedadesCombobox;

        // |==============================CONSTRUCTORES==============================|

        public FormPeces()
        {
            InitializeComponent();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        public void RefreshGrid()
        {
            gridPeces.Rows.Clear();
            List<EntitiePez> peces = ControllerPeces.Instance.GetPeces(textboxNombre.Text,
                idEspeciesCombobox[comboboxEspecies.SelectedIndex], idVariedadesCombobox[comboboxVariedades.SelectedIndex]);

            for (int i = 0; i < peces.Count; i++)
            {
                EntitiePezVariedad variedad = peces[i].GetVariedad();
                EntitiePezEspecie especie = null;
                if (variedad != null)
                    especie = variedad.GetEspecie();

                EntitiePezTamaño tamaño = ControllerPeces.Instance.GetTamañoById(peces[i].GetIdTamaño());
                EntitiePrecio precio = peces[i].GetPrecio();

                int idEspecie = 0;
                int idVariedad = 0;
                int idTamaño = 0;
                String especieDesc = "-";
                String variedadDesc = "-";
                String tamañoDesc = "-";

                if (especie != null)
                {
                    especieDesc = especie.GetNombre();
                    idEspecie = especie.GetIdPezEspecie();
                }

                if (variedad != null)
                {
                    variedadDesc = variedad.GetNombre();
                    idVariedad = variedad.GetIdPezVariedad();
                }

                if (tamaño != null)
                {
                    tamañoDesc = tamaño.GetDescripcion();
                    idTamaño = tamaño.GetIdTamaño();
                }

                gridPeces.Rows.Add(peces[i].GetIdPez(),
                    idEspecie,
                    idVariedad,
                    idTamaño,
                    peces[i].GetIdPrecio(),
                    peces[i].GetNombre(),
                    especieDesc,
                    variedadDesc,
                    tamañoDesc,
                    ManagerFormats.Instance.IntToNumber(peces[i].GetStock()),
                    ManagerFormats.Instance.DecimalToMoney(precio.GetPrecioMinorista(), true),
                    ManagerFormats.Instance.DecimalToMoney(precio.GetPrecioMayorista(), true),
                    ManagerFormats.Instance.DecimalToMoney(precio.GetPrecioOferta(), true),
                    ManagerFormats.Instance.DecimalToMoney(precio.GetPrecioDistribuidor(), true));
            }
        }

        public void PopulateComboboxes()
        {
            ControllerPeces.Instance.PopulateComboboxEspecies(ref comboboxEspecies, ref idEspeciesCombobox);

            ControllerPeces.Instance.PopulateComboboxVariedades(ref comboboxVariedades,
                        ref idVariedadesCombobox, idEspeciesCombobox[comboboxEspecies.SelectedIndex], false);
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void ModificarPez()
        {
            int colIdPez = ManagerGrids.Instance.GetColumnIndexByText(gridPeces, "ID PEZ");
            int idPez = Convert.ToInt32(gridPeces.Rows[gridPeces.SelectedRows[0].Index].Cells[colIdPez].Value);

            using (var form = new FormNuevoPez(idPez))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ManagerMessages.Instance.NewInformationMessage(this, "Pez modificado");
                    RefreshGrid();
                }
            }
        }

        private void EliminarPez()
        {
            int indexColId = ManagerGrids.Instance.GetColumnIndexByText(gridPeces, "ID PEZ");
            int idPez = Convert.ToInt32(gridPeces.Rows[gridPeces.SelectedRows[0].Index].Cells[indexColId].Value);

            ControllerPeces.Instance.EliminarPez(idPez);

            ManagerMessages.Instance.NewInformationMessage(this, "Pez eliminado");
            RefreshGrid();
        }

        // |==============================EVENTOS==============================|
        private void FormPeces_Load(object sender, EventArgs e)
        {
            PopulateComboboxes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnNuevoPez_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormNuevoPez", false, false);
        }

        private void comboboxEspecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControllerPeces.Instance.PopulateComboboxVariedades(ref comboboxVariedades,
                ref idVariedadesCombobox, idEspeciesCombobox[comboboxEspecies.SelectedIndex], false);
        }

        private void FormPeces_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerForms.Instance.PrevForm();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridPeces.SelectedRows.Count > 0)
                ModificarPez();
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione un pez a modificar");
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            if (gridPeces.SelectedRows.Count > 0)
            {
                int indexColNombre = ManagerGrids.Instance.GetColumnIndexByText(gridPeces, "NOMBRE");
                String nombrePez = gridPeces.Rows[gridPeces.SelectedRows[0].Index].Cells[indexColNombre].Value.ToString();

                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea eliminar el pez '" + nombrePez + "'?"))
                    EliminarPez();
            }
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione un pez a eliminar");
        }

        private void btnVerEspecies_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormEspecies", false, false);
        }

        private void btnVerVariedades_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormVariedades", false, false);
        }

        private void comboboxVariedades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxVariedades.Items.Count > 1)
                RefreshGrid();
        }
    }
}
