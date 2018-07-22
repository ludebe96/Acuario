using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormNuevaVariedad : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        private EntitiePezVariedad variedadAModificar;
        private Boolean modificando;
        private List<int> idEspeciesCombobox;

        // |==============================CONSTRUCTORES==============================|

        public FormNuevaVariedad()
        {
            InitializeComponent();

            modificando = false;
        }

        public FormNuevaVariedad(int idVariedad)
        {
            InitializeComponent();

            variedadAModificar = ControllerPeces.Instance.GetVariedadById(idVariedad);
            modificando = true;
        }

        // |==============================METODOS Y FUNCIONES==============================|


        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private Boolean ValidInput()
        {
            if (textboxNombre.Text.Equals(String.Empty))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Complete los campos");
                return false;
            }

            if (comboboxEspecies.SelectedIndex == 0)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione una especie");
                return false;
            }

            return true;
        }

        private Boolean VariedadExistente()
        {
            if (ControllerPeces.Instance.VariedadExistente(idEspeciesCombobox[comboboxEspecies.SelectedIndex], textboxNombre.Text))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "La variedad ya existe");
                return true;
            }

            return false;
        }

        private void CrearVariedad()
        {
            ControllerPeces.Instance.CrearVariedad(new EntitiePezVariedad(idEspeciesCombobox[comboboxEspecies.SelectedIndex],
                    textboxNombre.Text, false));
            ManagerMessages.Instance.NewInformationMessage(this, "Variedad creada");
        }

        private void ModificarVariedad()
        {
            ControllerPeces.Instance.ModificarVariedad(variedadAModificar.GetIdPezVariedad(),
                    new EntitiePezVariedad(idEspeciesCombobox[comboboxEspecies.SelectedIndex],
                textboxNombre.Text, false));
            ManagerMessages.Instance.NewInformationMessage(this, "Variedad modificada");
        }

        private void PrepararModoModificacion()
        {
            btnCrearVariedad.Text = "Modificar";

            FillCampos();
        }

        private void FillCampos()
        {
            textboxNombre.Text = variedadAModificar.GetNombre();

            // Combo especies
            if (variedadAModificar != null && variedadAModificar.GetIdPezEspecie() > 0)
            {
                for (int i = 0; i < idEspeciesCombobox.Count; i++)
                {
                    if (idEspeciesCombobox[i] == variedadAModificar.GetIdPezEspecie())
                        comboboxEspecies.SelectedIndex = i;
                }
            }
        }

        // |==============================EVENTOS==============================|

        private void FormNuevaVariedad_Load(object sender, EventArgs e)
        {
            ControllerPeces.Instance.PopulateComboboxEspecies(ref comboboxEspecies, ref idEspeciesCombobox);

            if (modificando)
                PrepararModoModificacion();
        }

        private void btnCrearVariedad_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                if (!modificando && !VariedadExistente())
                {
                    CrearVariedad();
                    DialogResult = DialogResult.OK;
                    Close();
                }

                else if (modificando)
                {
                    ModificarVariedad();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnNuevaEspecie_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormNuevaEspecie", true, false);
        }

        private void FormNuevaVariedad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}
