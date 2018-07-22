using System;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormNuevoCliente : MetroFramework.Forms.MetroForm
    {

        // |==============================ATRIBUTOS==============================|

        private EntitieCliente clienteAModificar;
        private Boolean modificando;

        // |==============================CONSTRUCTORES==============================|

        public FormNuevoCliente()
        {
            InitializeComponent();

            modificando = false;
        }

        public FormNuevoCliente(int idClienteAModificar)
        {
            InitializeComponent();

            clienteAModificar = ControllerClientes.Instance.GetClienteById(idClienteAModificar);
            modificando = true;

            PrepararModoModificacion();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private Boolean ValidInput()
        {
            if ((textboxNombre.Text.Equals(String.Empty) &&
                textboxCuit.Text.Equals(String.Empty) &&
                textboxMail.Text.Equals(String.Empty) &&
                textboxTelefono1.Text.Equals(String.Empty) &&
                textboxTelefono2.Text.Equals(String.Empty) &&
                textboxTelefono3.Text.Equals(String.Empty)))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Debe completar al menos un campo");
                return false;
            }

            if (!textboxMail.Text.Equals(String.Empty) &&
                !ManagerFormats.Instance.MailValido(textboxMail.Text))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "El mail es inválido");
                return false;
            }

            return true;
        }

        private void CrearCliente()
        {
            EntitieCliente cliente = new EntitieCliente(
                textboxNombre.Text,
                textboxCuit.Text,
                textboxMail.Text,
                textboxTelefono1.Text,
                textboxTelefono2.Text,
                textboxTelefono3.Text);

            ControllerClientes.Instance.CrearCliente(cliente);

            ManagerMessages.Instance.NewInformationMessage(this, "Cliente creado");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void PrepararModoModificacion()
        {
            btnCrear.Text = "Modificar";
        }

        private void FillCampos()
        {
            textboxNombre.Text = clienteAModificar.GetNombre();
            textboxCuit.Text = clienteAModificar.GetCuit();
            textboxMail.Text = clienteAModificar.GetMail();
            textboxTelefono1.Text = clienteAModificar.GetTelefono1();
            textboxTelefono2.Text = clienteAModificar.GetTelefono2();
            textboxTelefono3.Text = clienteAModificar.GetTelefono3();
        }


        private void ModificarCliente()
        {
            EntitieCliente cliente = new EntitieCliente(
                textboxNombre.Text,
                textboxCuit.Text,
                textboxMail.Text,
                textboxTelefono1.Text,
                textboxTelefono2.Text,
                textboxTelefono3.Text);

            ControllerClientes.Instance.ModificarCliente(clienteAModificar.GetIdCliente(), cliente);

            ManagerMessages.Instance.NewInformationMessage(this, "Cliente modificado");
            DialogResult = DialogResult.OK;
            Close();
        }


        // |==============================EVENTOS==============================|

        private void FormNuevoCliente_Load(object sender, EventArgs e)
        {
            if (modificando)
                FillCampos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                if (!modificando)
                    CrearCliente();
                else
                    ModificarCliente();
            }
        }

        private void FormNuevoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}
