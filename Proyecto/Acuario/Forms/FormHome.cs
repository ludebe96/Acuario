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
    public partial class FormHome : MetroFramework.Forms.MetroForm
    {
        /* |===============CONSTRUCTOR===============|*/
        public FormHome()
        {
            InitializeComponent();
        }

        /* |===============FUNCIONES Y MÉTODOS===============|*/

        /* |===============EVENTOS===============|*/

        private void FormHome_Load(object sender, EventArgs e)
        {
        }

        private void buttonCaja_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormCaja", false, false);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormGastos", false, false);
        }

        private void btnPeces_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormPeces", false, false);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormClientes", false, false);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormVentas", false, false);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormVender", false, false);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormCompras", false, false);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormComprar", false, false);
        }
    }
}
