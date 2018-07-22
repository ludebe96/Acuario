using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormGastos : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        private List<int> idCategoriasCombobox;

        // |==============================CONSTRUCTORES==============================|

        public FormGastos()
        {
            InitializeComponent();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void RefreshGrid()
        {
            gridGastos.Rows.Clear();
            List<EntitieGasto> gastos = ControllerGastos.Instance.GetGastos(GetIdCategoriaSeleccionada(),
                dateTimeDesde.Value, dateTimeHasta.Value);

            String nombreCategoria = "-";

            for (int i = 0; i < gastos.Count; i++)
            {
                if (gastos[i].GetIdCategoria() > 0)
                    nombreCategoria = ControllerGastoCategorias.Instance.GetCategoriaById(gastos[i].GetIdCategoria()).GetNombre();

                gridGastos.Rows.Add(gastos[i].GetIdGasto(),
                    gastos[i].GetIdCategoria(),
                    gastos[i].GetIdCuenta(),
                    nombreCategoria,
                    gastos[i].GetDescripcion(),
                    ManagerFormats.Instance.DecimalToMoney(gastos[i].GetMonto(), true),
                    gastos[i].GetFechaHora().ToString());

                nombreCategoria = "-";
            }

            CalcularSubtotal();
        }

        private int GetIdCategoriaSeleccionada()
        {
            return comboBoxCategorias.SelectedIndex >= 0 ? idCategoriasCombobox[comboBoxCategorias.SelectedIndex] : 0;
        }

        private void CalcularSubtotal()
        {
            decimal subtotal = 0;
            int indexColMonto = ManagerGrids.Instance.GetColumnIndexByName(gridGastos, "MONTO");

            for (int i = 0; i < gridGastos.Rows.Count; i++)
                subtotal += ManagerFormats.Instance.MoneyToDecimal(gridGastos.Rows[i].Cells[indexColMonto].Value.ToString());

            labelSubtotal.Text = ManagerFormats.Instance.DecimalToMoney(subtotal, true);
        }

        private void EliminarGastoSeleccionado()
        {
            int indexColIdGasto = ManagerGrids.Instance.GetColumnIndexByName(gridGastos, "IDGASTO");
            int idGasto = Convert.ToInt32(gridGastos.Rows[gridGastos.SelectedRows[0].Index].Cells[indexColIdGasto].Value);

            ControllerGastos.Instance.EliminarGastoById(idGasto);
            ManagerMessages.Instance.NewInformationMessage(this, "Gasto eliminado");
            RefreshGrid();
        }

        // |==============================EVENTOS==============================|

        private void FormGastos_Load(object sender, EventArgs e)
        {
            ControllerGastoCategorias.Instance.PopulateComboboxCategorias(ref comboBoxCategorias, ref idCategoriasCombobox);

            dateTimeDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            RefreshGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnNuevoGasto_Click(object sender, EventArgs e)
        {
            using (var form = new FormNuevoGasto())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    RefreshGrid();
            }
        }

        private void FormGastos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerForms.Instance.PrevForm();
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            if (gridGastos.SelectedRows.Count > 0 &&
                ManagerMessages.Instance.NewConfirmMessage(this, "¿Está seguro que desea eliminar el gasto seleccionado?"))
                EliminarGastoSeleccionado();
        }
    }
}
