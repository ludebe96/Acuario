using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormTransferir : MetroFramework.Forms.MetroForm
    {
        // |==============================CONSTRUCTORES==============================|

        public FormTransferir()
        {
            InitializeComponent();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void RefreshGrids()
        {
            gridDe.Rows.Clear();
            gridA.Rows.Clear();
            List<EntitieCuenta> cuentas = ControllerCuentas.Instance.GetCuentas(true);

            for (int i = 0; i < cuentas.Count; i++)
            {
                gridA.Rows.Add(cuentas[i].GetIdCuenta(),
                    cuentas[i].GetNombre(),
                    ManagerFormats.Instance.DecimalToMoney(cuentas[i].GetBalance(), true));

                gridDe.Rows.Add(cuentas[i].GetIdCuenta(),
                    cuentas[i].GetNombre(),
                    ManagerFormats.Instance.DecimalToMoney(cuentas[i].GetBalance(), true));
            }
        }

        private void RealizarTransferencia()
        {
            ControllerCuentas.Instance.Transferir(GetCuentaSeleccionada(true), GetCuentaSeleccionada(false),
                ManagerFormats.Instance.MoneyToDecimal(textboxMonto.Text));

            RefreshGrids();

            ManagerMessages.Instance.NewInformationMessage(this, "Transferencia realizada");
            DialogResult = DialogResult.OK;
            Close();
        }

        private EntitieCuenta GetCuentaSeleccionada(Boolean grillaDe)
        {
            DataGridView grilla = gridDe;
            String sufijoColumnaGrilla = "DE";
            if (!grillaDe)
            {
                grilla = gridA;
                sufijoColumnaGrilla = "A";
            }

            int rowIndex = grilla.SelectedRows[0].Index;
            int indexColIdCuenta = ManagerGrids.Instance.GetColumnIndexByName(grilla, "idcuenta" + sufijoColumnaGrilla);
            int indexColCuenta = ManagerGrids.Instance.GetColumnIndexByName(grilla, "cuenta" + sufijoColumnaGrilla);
            int indexColBalance = ManagerGrids.Instance.GetColumnIndexByName(grilla, "balanceactual" + sufijoColumnaGrilla);

            return new EntitieCuenta(Convert.ToInt32(grilla.Rows[rowIndex].Cells[indexColIdCuenta].Value),
                grilla.Rows[rowIndex].Cells[indexColCuenta].Value.ToString(),
                ManagerFormats.Instance.MoneyToDecimal(grilla.Rows[rowIndex].Cells[indexColBalance].Value.ToString()));
        }

        private Boolean CuentasValidas()
        {
            if (gridDe.SelectedRows[0].Index != gridA.SelectedRows[0].Index)
                return true;
            else
            {

                ManagerMessages.Instance.NewInformationMessage(this, "No puede transferir a la misma cuenta");
                return false;
            }
        }

        private Boolean MontoValido()
        {
            if (ManagerFormats.Instance.MontoValido(textboxMonto.Text) &&
                ManagerFormats.Instance.MoneyToDecimal(textboxMonto.Text) > 0)
                return true;
            else
            {
                ManagerMessages.Instance.NewInformationMessage(this, "El monto es invalido");
                return false;
            }
        }

        /*
         * Que no exceda el límite de la cuenta
         * */
        private Boolean MontoCuentaValido()
        {
            EntitieCuenta cuentaDe = GetCuentaSeleccionada(true);

            if (ManagerFormats.Instance.MoneyToDecimal(textboxMonto.Text) <= cuentaDe.GetBalance())
                return true;
            else
            {
                ManagerMessages.Instance.NewInformationMessage(this, "El monto supera el límite de la cuenta");
                return false;
            }
        }


        // |==============================EVENTOS==============================|

        private void FormTransferir_Load(object sender, EventArgs e)
        {
            RefreshGrids();
        }

        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            if (CuentasValidas() && MontoValido() && MontoCuentaValido())
                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea transferir  " + ManagerFormats.Instance.StringToMoney(textboxMonto.Text) + " " +
                    "de la cuenta " + GetCuentaSeleccionada(true).GetNombre() + " a la cuenta " +
                    GetCuentaSeleccionada(false).GetNombre() + " ?"))
                    RealizarTransferencia();
        }

        private void FormTransferir_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void textboxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                buttonTransferir.PerformClick();
        }
    }
}
