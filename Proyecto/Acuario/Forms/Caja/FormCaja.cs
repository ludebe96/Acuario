using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormCaja : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        Boolean modoSeleccion;
        public int IdCuentaSeleccionada;

        // |==============================CONSTRUCTORES==============================|
        public FormCaja()
        {
            InitializeComponent();

            this.modoSeleccion = false;
        }

        public FormCaja(Boolean modoSeleccion)
        {
            InitializeComponent();

            this.modoSeleccion = true;
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void InitGrid()
        {
            gridCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private EntitieCuenta GetCuentaSeleccionada()
        {
            int rowIndex = gridCuentas.SelectedRows[0].Index;
            int indexColIdCuenta = ManagerGrids.Instance.GetColumnIndexByName(gridCuentas, "idcuenta");
            int indexColCuenta = ManagerGrids.Instance.GetColumnIndexByName(gridCuentas, "cuenta");
            int indexColBalance = ManagerGrids.Instance.GetColumnIndexByName(gridCuentas, "balanceactual");

            EntitieCuenta cuenta = new EntitieCuenta(
                Convert.ToInt32(gridCuentas.Rows[rowIndex].Cells[indexColIdCuenta].Value),
                gridCuentas.Rows[rowIndex].Cells[indexColCuenta].Value.ToString(),
                ManagerFormats.Instance.MoneyToDecimal(gridCuentas.Rows[rowIndex].Cells[indexColBalance].Value.ToString()));

            return cuenta;
        }

        private void AjustarBalance(int idCuenta, decimal balanceNuevo)
        {
            ControllerCuentas.Instance.AjustarBalance(idCuenta, balanceNuevo);
            RefreshCuentas();
        }

        private int GetIDCuentaSeleccionada()
        {
            return Convert.ToInt32(gridCuentas.Rows[gridCuentas.SelectedRows[0].Index].Cells["columnIdCuenta"].Value);
        }

        private void RefreshCuentas()
        {
            gridCuentas.Rows.Clear();
            List<EntitieCuenta> cuentas = ControllerCuentas.Instance.GetCuentas(false);

            for (int i = 0; i < cuentas.Count; i++)
            {
                gridCuentas.Rows.Add(cuentas[i].GetIdCuenta(),
                    cuentas[i].GetNombre(),
                    ManagerFormats.Instance.DecimalToMoney(cuentas[i].GetBalance(), true));
            }

            CalcularTotal();

            RefreshAhorros();
        }

        /* 
         * Llamada desde RefreshGrid()
         */
        private void CalcularTotal()
        {
            int indexColBalance = ManagerGrids.Instance.GetColumnIndexByName(gridCuentas, "balanceactual");
            Decimal total = 0;

            for (Int16 i = 0; i < gridCuentas.Rows.Count; i++)
                total += Convert.ToDecimal(ManagerFormats.Instance.MoneyToDecimal(
                    gridCuentas.Rows[i].Cells[indexColBalance].Value.ToString()));

            mLabelTotalCuentas.Text = ManagerFormats.Instance.DecimalToMoney(total, true);
        }

        private void RefreshAhorros()
        {
            Decimal totalAhorros = ControllerCuentas.Instance.GetCuentaByNombre("AHORROS").GetBalance();

            labelTotalAhorros.Text = ManagerFormats.Instance.DecimalToMoney(totalAhorros, true);
        }

        private void PrepararModoSeleccion()
        {
            Text = "Seleccione una cuenta";

            btnAjustarBalanceCuentas.Text = "Seleccionar";

            panelAhorros.Visible = false;
            btnTransferencias.Visible = false;
            btnAjustarBalanceAhorros.Visible = false;
            MinimumSize = new Size(Size.Width, 265);
            Size = new Size(Size.Width, 265);
        }

        // |==============================EVENTOS==============================|

        private void FormCaja_Load(object sender, EventArgs e)
        {
            InitGrid();

            RefreshCuentas();

            if (modoSeleccion)
                PrepararModoSeleccion();
        }

        private void btnAjustarBalanceCuentas_Click(object sender, EventArgs e)
        {
            if (!modoSeleccion)
            {
                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea ajustar el balance de " + GetCuentaSeleccionada().GetNombre() + " ?"))
                {
                    using (var form = new FormAjustarBalance(GetCuentaSeleccionada().GetBalance()))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                            AjustarBalance(GetIDCuentaSeleccionada(), form.BalanceNuevo);
                    }
                }
            }
            else
            {
                int colIdCuenta = ManagerGrids.Instance.GetColumnIndexByName(gridCuentas, "IDCUENTA");
                IdCuentaSeleccionada = Convert.ToInt32(gridCuentas.Rows[gridCuentas.SelectedRows[0].Index].Cells[colIdCuenta].Value);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnAjustarBalanceAhorros_Click(object sender, EventArgs e)
        {
            if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea ajustar el balance de los AHORROS?"))
            {
                using (var form = new FormAjustarBalance(ManagerFormats.Instance.MoneyToDecimal(labelTotalAhorros.Text)))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                        AjustarBalance(ControllerCuentas.Instance.GetCuentaByNombre("AHORROS").GetIdCuenta(), form.BalanceNuevo);
                }
            }
        }

        private void btnTransferencias_Click(object sender, EventArgs e)
        {
            using (var form = new FormTransferir())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshCuentas();
                    RefreshAhorros();
                }
            }
        }

        private void FormCaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}
