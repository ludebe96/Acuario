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

        public void UpdateBalances()
        {
            // Inicializa rows si o las tiene
            if (gridBalanceDia.Rows.Count == 0)
            {
                gridBalanceDia.Rows.Add();
                gridBalanceDia.Rows[0].Cells[0].Style.ForeColor = Color.DarkGreen;
                gridBalanceDia.Rows[0].Cells[1].Style.ForeColor = Color.DarkRed;
                gridBalanceDia.Columns[0].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                gridBalanceDia.Columns[1].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                gridBalanceDia.Columns[2].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                gridBalanceDia.Columns[0].HeaderCell.Style.Font = new Font("Micorosft Sans Serif", 12F);
                gridBalanceDia.Columns[1].HeaderCell.Style.Font = new Font("Micorosft Sans Serif", 12F);
                gridBalanceDia.Columns[2].HeaderCell.Style.Font = new Font("Micorosft Sans Serif", 12F);
                gridBalanceDia.ClearSelection();

                gridBalanceMes.Rows.Add();
                gridBalanceMes.Rows[0].Cells[0].Style.ForeColor = Color.DarkGreen;
                gridBalanceMes.Rows[0].Cells[1].Style.ForeColor = Color.DarkRed;
                gridBalanceMes.Columns[0].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                gridBalanceMes.Columns[1].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                gridBalanceMes.Columns[2].HeaderCell.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                gridBalanceMes.Columns[0].HeaderCell.Style.Font = new Font("Micorosft Sans Serif", 12F);
                gridBalanceMes.Columns[1].HeaderCell.Style.Font = new Font("Micorosft Sans Serif", 12F);
                gridBalanceMes.Columns[2].HeaderCell.Style.Font = new Font("Micorosft Sans Serif", 12F);
                gridBalanceMes.ClearSelection();
            }

            UpdateBalanceDia();
            UpdateBalanceMes();
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void UpdateBalanceDia()
        {
            int idTipoTransaccionIngreso =
                ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("Ingreso").GetIdTipoTransaccion();
            int idTipoTransaccionEgreso =
                ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("Egreso").GetIdTipoTransaccion();

            Decimal ingresos =
                ControllerTransacciones.Instance.GetTotalTransacciones(idTipoTransaccionIngreso, DateTime.Today, DateTime.Today);
            Decimal egresos =
                 ControllerTransacciones.Instance.GetTotalTransacciones(idTipoTransaccionEgreso, DateTime.Today, DateTime.Today);

            gridBalanceDia.Rows[0].Cells[0].Value = ManagerFormats.Instance.DecimalToMoney(ingresos, true);
            gridBalanceDia.Rows[0].Cells[1].Value = ManagerFormats.Instance.DecimalToMoney(egresos, true);

            Decimal balance = ingresos + egresos;

            gridBalanceDia.Rows[0].Cells[2].Value = ManagerFormats.Instance.DecimalToMoney(balance, true);

            if (balance > 0)
                gridBalanceDia.Rows[0].Cells[2].Style.ForeColor = Color.DarkGreen;
            else if (balance < 0)
                gridBalanceDia.Rows[0].Cells[2].Style.ForeColor = Color.DarkRed;
            else
                gridBalanceDia.Rows[0].Cells[2].Style.ForeColor = Color.DarkGray;
        }

        private void UpdateBalanceMes()
        {
            int idTipoTransaccionIngreso =
                ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("Ingreso").GetIdTipoTransaccion();
            int idTipoTransaccionEgreso =
                ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("Egreso").GetIdTipoTransaccion();

            Decimal ingresos =
                ControllerTransacciones.Instance.GetTotalTransacciones(idTipoTransaccionIngreso, new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), DateTime.Today);
            Decimal egresos =
                 ControllerTransacciones.Instance.GetTotalTransacciones(idTipoTransaccionEgreso, new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), DateTime.Today);

            gridBalanceMes.Rows[0].Cells[0].Value = ManagerFormats.Instance.DecimalToMoney(ingresos, true);
            gridBalanceMes.Rows[0].Cells[1].Value = ManagerFormats.Instance.DecimalToMoney(egresos, true);

            Decimal balance = ingresos + egresos;

            gridBalanceMes.Rows[0].Cells[2].Value = ManagerFormats.Instance.DecimalToMoney(balance, true);

            if (balance > 0)
                gridBalanceMes.Rows[0].Cells[2].Style.ForeColor = Color.DarkGreen;
            else if (balance < 0)
                gridBalanceMes.Rows[0].Cells[2].Style.ForeColor = Color.DarkRed;
            else
                gridBalanceMes.Rows[0].Cells[2].Style.ForeColor = Color.DarkGray;
        }

        // |==============================EVENTOS==============================|

        private void FormHome_Load(object sender, EventArgs e)
        {
            UpdateBalances();
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }


        private void btnNavegacion_Click(object sender, EventArgs e)
        {
            panelNavegacion.BringToFront();
        }

        private void btnBalances_Click(object sender, EventArgs e)
        {
            panelBalances.BringToFront();
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

        private void gridBalanceDia_SelectionChanged(object sender, EventArgs e)
        {
            gridBalanceDia.ClearSelection();
        }

        private void gridBalanceMes_SelectionChanged(object sender, EventArgs e)
        {
            gridBalanceMes.ClearSelection();
        }
    }
}
