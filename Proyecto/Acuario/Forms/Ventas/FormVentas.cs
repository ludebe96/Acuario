using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormVentas: MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        private int INDEX_COL_VER_DETALLE;
        private int INDEX_COL_VER_FACTURA;
        // |==============================CONSTRUCTORES==============================|

        public FormVentas()
        {
            InitializeComponent();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void RefreshGrid()
        {
            gridVentas.Rows.Clear();
            int idVenta = 0;
            if (!textboxNroVenta.Text.Trim().Equals(""))
                idVenta = Convert.ToInt32(textboxNroVenta.Text.Trim());

            List<EntitieVenta> ventas =
                ControllerVentas.Instance.GetVentas(idVenta, textboxNombre.Text,
                dateTimeDesde.Value, dateTimeHasta.Value);

            for (int i = 0; i < ventas.Count; i++)
            {
                gridVentas.Rows.Add(
                    ventas[i].GetIdVenta(),
                    ventas[i].GetIdCuenta(),
                    ventas[i].GetIdCliente(),
                    ventas[i].GetIdVenta(),
                    ventas[i].GetCuenta() != null ? ventas[i].GetCuenta() : "-",
                    ventas[i].GetCliente() != null ? ventas[i].GetCliente() : "-",
                    ManagerFormats.Instance.DecimalToMoney(ventas[i].GetTotal(), true),
                    ventas[i].GetFechaHora().ToShortDateString(),
                    "VER DETALLE", "VER FACTURA");
            }
        }

        private void DeshacerVenta()
        {
            int indexColIdVenta = ManagerGrids.Instance.GetColumnIndexByName(gridVentas, "IDVENTA");
            int idVenta = Convert.ToInt32(gridVentas.Rows[gridVentas.SelectedRows[0].Index].Cells[indexColIdVenta].Value);

            ControllerVentas.Instance.RollbackVenta(idVenta);
            ManagerMessages.Instance.NewInformationMessage(this, "La venta ha sido reestablecida");
            RefreshGrid();
        }

        // |==============================EVENTOS==============================|

        private void FormVentas_Load(object sender, EventArgs e)
        {
            dateTimeDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            for (int i = 0; i < gridVentas.Columns.Count; i++)
            {
                if (gridVentas.Columns[i].Name == "columnVerDetalle")
                    INDEX_COL_VER_DETALLE = i;
                else if (gridVentas.Columns[i].Name == "columnVerFactura")
                    INDEX_COL_VER_FACTURA = i;
            }

            RefreshGrid();

            WindowState = FormWindowState.Maximized;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void gridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == INDEX_COL_VER_DETALLE)
                {
                    int indexColIdVenta = ManagerGrids.Instance.GetColumnIndexByName(gridVentas, "IDVENTA");
                    int idVenta = Convert.ToInt32(gridVentas.Rows[gridVentas.SelectedRows[0].Index].Cells[indexColIdVenta].Value);

                    ManagerForms.Instance.NewForm("FormVentaItems", false, false, idVenta);
                }
                else if (e.ColumnIndex == INDEX_COL_VER_FACTURA)
                {
                    int indexColIdVenta = ManagerGrids.Instance.GetColumnIndexByName(gridVentas, "IDVENTA");
                    int idVenta = Convert.ToInt32(gridVentas.Rows[gridVentas.SelectedRows[0].Index].Cells[indexColIdVenta].Value);

                    if(!ManagerFiles.Instance.AbrirArchivo(ManagerNames.FACTURAS_PATH + idVenta + ".JPG"))
                        ManagerMessages.Instance.NewInformationMessage(this, "La factura asociada a esta venta no existe");

                }
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormVentaItems", false, false);
        }

        private void btnDeshacerVenta_Click(object sender, EventArgs e)
        {
            if (gridVentas.SelectedRows.Count > 0)
            {
                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea deshacer la venta seleccionada?\n" + 
                    "Se restaurará la transacción en la cuenta correspondiente y el stock de peces vendidos se repondrá en el inventario"))
                    DeshacerVenta();
            }
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione una venta a deshacer");
        }

        private void textboxNroVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RefreshGrid();
        }

        private void textboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RefreshGrid();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormVender", false, false);
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dateTimeHasta_ValueChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void FormVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}
