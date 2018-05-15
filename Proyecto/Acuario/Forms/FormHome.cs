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
        private void buttonCaja_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormCaja", false, false);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormGastos", false, false);
        }
    }
}
