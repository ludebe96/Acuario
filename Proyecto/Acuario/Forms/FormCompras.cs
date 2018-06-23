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
    public partial class FormCompras : MetroFramework.Forms.MetroForm
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        // |==============================ATRIBUTOS==============================|

        private int INDEX_COL_VER_DETALLE;

        // |==============================CONSTRUCTORES==============================|

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void RefreshGrid()
        {
            gridCompras.Rows.Clear();
            int idCompra = 0;
            List<EntitieCompra> compras = ControllerCompras.Instance.GetCompras(idCompra, dateTimeDesde.Value, dateTimeHasta.Value);

            for (int i = 0; i < compras.Count; i++)
            {
                gridCompras.Rows.Add(
                    compras[i].GetIdCompra(),
                    compras[i].GetIdCuenta(),
                    compras[i].GetCuenta() != null ? compras[i].GetCuenta() : "-",
                    ManagerFormats.Instance.DecimalToMoney(compras[i].GetTotal(), true),
                    compras[i].GetFechaHora().ToShortDateString(), "VER DETALLE");
            }
        }

        private void DeshacerCompra()
        {
            int indexColIdCompra = ManagerGrids.Instance.GetColumnIndexByText(gridCompras, "ID COMPRA");
            int idCompra = Convert.ToInt32(gridCompras.Rows[gridCompras.SelectedRows[0].Index].Cells[indexColIdCompra].Value);

            ControllerCompras.Instance.RollbackCompra(idCompra);
            ManagerMessages.Instance.NewInformationMessage(this, "La compra ha sido reestablecida");
            RefreshGrid();
        }

        // |==============================EVENTOS==============================|

        private void FormCompras_Load(object sender, EventArgs e)
        {
            dateTimeDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // TODO: ACA!
            for (int i = 0; i < gridCompras.Columns.Count; i++)
            {
                if (gridCompras.Columns[i].Name == "columnVerDetalle")
                {
                    INDEX_COL_VER_DETALLE = i;
                    break;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormCompraItems", false, false);
        }

        private void gridCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == INDEX_COL_VER_DETALLE)
                {
                    int indexColIdVenta = ManagerGrids.Instance.GetColumnIndexByText(gridCompras, "ID COMPRA");
                    int idCompra = Convert.ToInt32(gridCompras.Rows[gridCompras.SelectedRows[0].Index].Cells[indexColIdVenta].Value);

                    ManagerForms.Instance.NewForm("FormCompraItems", false, false, idCompra);
                }
            }
        }

        private void btnDeshacerCompra_Click(object sender, EventArgs e)
        {
            if (gridCompras.SelectedRows.Count > 0)
            {
                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea deshacer la compra seleccionada?\n" +
                    "Se restaurará la transacción en la cuenta correspondiente y el stock de peces comprados se repondrá en el inventario"))
                    DeshacerCompra();
            }
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione una compra a deshacer");
        }


        private void FormCompras_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}