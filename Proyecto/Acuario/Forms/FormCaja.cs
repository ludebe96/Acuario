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
    public partial class FormCaja : MetroFramework.Forms.MetroForm
    {
        // |==============================CONSTRUCTORES==============================|
        public FormCaja()
        {
            InitializeComponent();
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
            int indexColIdCuenta = ManagerGrid.Instance.GetColumnIndexByText(gridCuentas, "id cuenta");
            int indexColCuenta = ManagerGrid.Instance.GetColumnIndexByText(gridCuentas, "cuenta");
            int indexColBalance = ManagerGrid.Instance.GetColumnIndexByText(gridCuentas, "balance actual");

            EntitieCuenta cuenta = new EntitieCuenta(
                Convert.ToInt32(gridCuentas.Rows[rowIndex].Cells[indexColIdCuenta].Value),
                gridCuentas.Rows[rowIndex].Cells[indexColCuenta].Value.ToString(),
                ManagerFormats.Instance.MoneyToDecimal(gridCuentas.Rows[rowIndex].Cells[indexColBalance].Value.ToString()));

            return cuenta;
        }

        private void AjustarBalance(int idCuenta, decimal balanceNuevo)
        {
            ControllerCuentas.Instance.AjustarBalance(idCuenta, balanceNuevo);
            RefreshGrid();
        }

        private int GetIDCuentaSeleccionada()
        {
            return Convert.ToInt32(gridCuentas.Rows[gridCuentas.SelectedRows[0].Index].Cells["columnIdCuenta"].Value);
        }

        private void RefreshGrid()
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
            int indexColBalance = ManagerGrid.Instance.GetColumnIndexByText(gridCuentas, "balance actual");
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

        // |==============================EVENTOS==============================|
        private void buttonAjustarBalanceCuentas_Click(object sender, EventArgs e)
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

        private void buttonAjustarBalanceAhorros_Click(object sender, EventArgs e)
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

        private void FormCaja_Load(object sender, EventArgs e)
        {
            InitGrid();

            RefreshGrid();
        }

        private void FormCaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerForms.Instance.PrevForm();
        }
    }
}
