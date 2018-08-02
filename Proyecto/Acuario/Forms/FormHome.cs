using System;
using System.Drawing;

using Acuario.Controllers;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormHome : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        // |==============================CONSTRUCTORES==============================|

        public FormHome()
        {
            InitializeComponent();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        public void UpdateResumenGeneral()
        {
            int idTipoTransaccionIngreso =
                ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("Ingreso").GetIdTipoTransaccion();
            int idTipoTransaccionEgreso =
                ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("Egreso").GetIdTipoTransaccion();

            Decimal ingresos =
                ControllerTransacciones.Instance.GetTotalTransacciones(idTipoTransaccionIngreso, DateTime.Today, DateTime.Today);
           Decimal egresos =
                ControllerTransacciones.Instance.GetTotalTransacciones(idTipoTransaccionEgreso, DateTime.Today, DateTime.Today);

            labelIngresos.Text = ManagerFormats.Instance.DecimalToMoney(ingresos, true);
            labelGastos.Text = ManagerFormats.Instance.DecimalToMoney(egresos, true);

            Decimal balance = ingresos + egresos;

            labelBalance.Text = ManagerFormats.Instance.DecimalToMoney(balance, true);

            if (balance > 0)
                labelBalance.ForeColor = Color.DarkGreen;
            else if (balance < 0)
                labelBalance.ForeColor = Color.DarkRed;
            else
                labelBalance.ForeColor = Color.DarkGray;
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        // |==============================EVENTOS==============================|

        private void FormHome_Load(object sender, EventArgs e)
        {
            UpdateResumenGeneral();
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }


        private void btnNavegacion_Click(object sender, EventArgs e)
        {
            panelNavegacion.BringToFront();
        }

        private void btnResumenesGenerales_Click(object sender, EventArgs e)
        {
            panelResumenesGenerales.BringToFront();
        }


        private void btnVender_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormVender", false, false);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormComprar", false, false);
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormCaja", false, false);
        }

        private void btnPez_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormPeces", false, false);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormVentas", false, false);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormCompras", false, false);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormGastos", false, false);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormClientes", false, false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea salir del sistema?"))
                Close();
        }
    }
}
