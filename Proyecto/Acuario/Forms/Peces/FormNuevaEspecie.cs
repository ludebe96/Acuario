using System;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormNuevaEspecie : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        private EntitiePezEspecie especieAModificar;
        private Boolean modificando;

        // |==============================CONSTRUCTOR==============================|

        public FormNuevaEspecie()
        {
            InitializeComponent();

            modificando = false;
        }

        public FormNuevaEspecie(int idEspecieAModificar)
        {
            InitializeComponent();

            this.especieAModificar = ControllerPeces.Instance.GetEspecieById(idEspecieAModificar);
            modificando = true;
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private Boolean ValidInput()
        {
            if (textboxNombre.Text.Equals(String.Empty))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Complete el campo");
                return false;
            }

            return true;
        }

        private Boolean EspecieExistente()
        {
            if (!ControllerPeces.Instance.EspecieExistente(textboxNombre.Text))
                return false;
            else
            {
                ManagerMessages.Instance.NewInformationMessage(this, "La especie ya existe");
                return true;
            }
        }

        private void CrearEspecie()
        {
            ControllerPeces.Instance.CrearEspecie(new EntitiePezEspecie(textboxNombre.Text), true);
            ManagerMessages.Instance.NewInformationMessage(this, "Especie creada");
        }

        private void ModificarEspecie()
        {
            ControllerPeces.Instance.ModificarEspecie(especieAModificar.GetIdPezEspecie(), new EntitiePezEspecie(textboxNombre.Text));
            ManagerMessages.Instance.NewInformationMessage(this, "Especie modificada");
        }

        private void PrepararModoModificacion()
        {
            btnCrearEspecie.Text = "Modificar";
            textboxNombre.Text = especieAModificar.GetNombre();
        }

        // |==============================EVENTOS==============================|

        private void FormNuevaEspecie_Load(object sender, EventArgs e)
        {
            if (modificando)
                PrepararModoModificacion();
        }

        private void btnCrearEspecie_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {

                if (!modificando && !EspecieExistente())
                {
                    CrearEspecie();
                    DialogResult = DialogResult.OK;
                    Close();
                }

                else if (modificando)
                {
                    ModificarEspecie();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void FormNuevaEspecie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }

        private void textboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnCrearEspecie.PerformClick();
        }
    }
}
