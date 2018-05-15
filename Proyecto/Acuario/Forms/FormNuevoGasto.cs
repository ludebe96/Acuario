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
    public partial class FormNuevoGasto : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS===============================|

        private List<int> idCategoriasCombobox;

        // |==============================CONSTRUCTORES==============================|
        public FormNuevoGasto()
        {
            InitializeComponent();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void PopulateComboCategorias()
        {
            List<EntitieGastoCategoria> categorias = ControllerGastoCategorias.Instance.GetCategorias();
            idCategoriasCombobox = new List<int>();

            for (int i = 0; i < categorias.Count; i++)
            {
                comboBoxCategorias.Items.Add(categorias[i].GetNombre());
                idCategoriasCombobox.Add(categorias[i].GetIdCuenta());
            }

            comboBoxCategorias.SelectedIndex = 0;
        }

        private Boolean ValidInputs()
        {
            if (textboxDescripcion.Text.Equals(String.Empty) ||
                textboxMonto.Text.Equals(String.Empty))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Hay campos incompletos");
                return false;
            }

            if (!ManagerFormats.Instance.MontoValido(textboxMonto.Text) ||
                ManagerFormats.Instance.MoneyToDecimal(textboxMonto.Text) <= 0)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Monto inválido");
                return false;
            }

            if (datetimeFecha.Value > DateTime.Now)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "La fecha no puede superar a la actualidad");
                return false;
            }

            return true;
        }

        private void GenerarGasto()
        {
            EntitieGasto gasto = new EntitieGasto(
                idCategoriasCombobox[comboBoxCategorias.SelectedIndex],
                ControllerCuentas.Instance.GetCuentaByNombre("CAJA").GetIdCuenta(),
                textboxDescripcion.Text,
                ManagerFormats.Instance.MoneyToDecimal(textboxMonto.Text),
                datetimeFecha.Value);

            ControllerGastos.Instance.NuevoGasto(gasto);

            DialogResult = DialogResult.OK;
            Close();
        }

        // |==============================EVENTOS==============================|

        private void FormNuevoGasto_Load(object sender, EventArgs e)
        {
            PopulateComboCategorias();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
                GenerarGasto();
        }
    }
}
