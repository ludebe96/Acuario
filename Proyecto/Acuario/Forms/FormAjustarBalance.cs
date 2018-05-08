using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormAjustarBalance : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS===============================|
        public decimal BalanceNuevo;
        private decimal balancePrevio;
        private FormAjustarBalance formAjustarBalance;

        // |==============================CONSTRUCTORES==============================|

        public FormAjustarBalance()
        {
            InitializeComponent();
        }

        public FormAjustarBalance(decimal balancePrevio)
        {
            InitializeComponent();

            this.balancePrevio = balancePrevio;
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private Boolean nuevoBalanceValido()
        {
            decimal num;
            return decimal.TryParse(textBoxBalanceNuevo.Text, out num);
        }

        // |==============================EVENTOS==============================|

        private void FormAjustarBalance_Load(object sender, EventArgs e)
        {
            textBoxBalancePrevio.Text = ManagerFormats.Instance.DecimalToMoney(balancePrevio, true);
            ActiveControl = textBoxBalanceNuevo;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (nuevoBalanceValido())
            {
                BalanceNuevo = Convert.ToDecimal(textBoxBalanceNuevo.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Monto ingresado inválido");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCalculadora_Click(object sender, EventArgs e)
        {
            ManagerProcesos.Instance.IniciarCalculadora();
        }

        private void textBoxBalanceNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                buttonOk.PerformClick();
        }
    }
}
