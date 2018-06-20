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
    public partial class FormVender : MetroFramework.Forms.MetroForm
    {

        private EntitiePez pezAVender;
        private EntitieCliente cliente;
        private EntitieCuenta cuenta;

        public FormVender()
        {
            InitializeComponent();
        }

        // |==============================ATRIBUTOS==============================|

        // |==============================CONSTRUCTORES==============================|

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void SeleccionarPrecioMinorista()
        {
            textboxMinorista.Enabled = true;

            textboxMayorista.Enabled = false;
            textboxOferta.Enabled = false;
            textboxDistribuidor.Enabled = false;
        }

        private void SeleccionarPrecioMayorista()
        {
            textboxMayorista.Enabled = true;

            textboxMinorista.Enabled = false;
            textboxOferta.Enabled = false;
            textboxDistribuidor.Enabled = false;
        }

        private void SeleccionarPrecioOferta()
        {
            textboxOferta.Enabled = true;

            textboxMinorista.Enabled = false;
            textboxMayorista.Enabled = false;
            textboxDistribuidor.Enabled = false;
        }

        private void SeleccionarPrecioDistribuidor()
        {
            textboxDistribuidor.Enabled = true;

            textboxMinorista.Enabled = false;
            textboxMayorista.Enabled = false;
            textboxOferta.Enabled = false;
        }

        private void LimpiarCamposItem()
        {
            pezAVender = null;
            textboxPez.Text = "";

            textboxCantidad.Text = "";

            textboxMinorista.Text = "";
            textboxMayorista.Text = "";
            textboxOferta.Text = "";
            textboxDistribuidor.Text = "";
        }

        private void LimpiarCamposNuevaVenta()
        {
            LimpiarCamposItem();

            rBtnMinorista.Checked = false;
            textboxMinorista.Enabled = false;

            rBtnMayorista.Checked = false;
            textboxMayorista.Enabled = false;

            rBtnOferta.Checked = false;
            textboxOferta.Enabled = false;

            rBtnDistribuidor.Checked = false;
            textboxDistribuidor.Enabled = false;

            textboxCliente.Text = "";
            cliente = null;

            gridItems.Rows.Clear();
        }

        private Boolean ValidItem()
        {
            if (pezAVender == null)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione un pez");
                return false;
            }

            if (textboxCantidad.Text.Equals(String.Empty))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Ingrese la cantidad a vender");
                return false;
            }
            else if (Convert.ToInt32(textboxCantidad.Text) <= 0)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "La cantidad ingresada es inválida");
                return false;
            }

            if (!ManagerFormats.Instance.MontoValido(textboxCantidad.Text))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Cantidad inválida");
                return false;
            }

            if (!rBtnMinorista.Checked && !rBtnMayorista.Checked &&
                !rBtnOferta.Checked && !rBtnDistribuidor.Checked)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione un precio");
                return false;
            }

            if (ItemYaEnVenta(pezAVender.GetIdPez()))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "El pez que desea agregar ya se encuentra agregado");
                return false;
            }



            if (pezAVender != null &&
                pezAVender.GetStock() - Convert.ToInt32(textboxCantidad.Text) < 0)
                ManagerMessages.Instance.NewInformationMessage(this, "El stock del pez se volverá negativo, pero puede continuar con la venta.");

            return true;

        }

        private Boolean ValidVenta()
        {
            if (cuenta == null)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione una cuenta");
                return false;
            }

            if (gridItems.Rows.Count == 0)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "No hay items en la venta.");
                return false;
            }

            return true;

        }

        /*
         * Devuelve true si el pez ya está 
         * agregado como item en la venta
         * */
        private Boolean ItemYaEnVenta(int idPezAAgregar)
        {
            int idPezColId = ManagerGrids.Instance.GetColumnIndexByText(gridItems, "ID PEZ");

            for (int i = 0; i < gridItems.Rows.Count; i++)
            {
                if (idPezAAgregar == Convert.ToInt32(gridItems.Rows[gridItems.SelectedRows[0].Index].Cells[idPezColId].Value))
                    return true;
            }

            return false;
        }

        private void AgregarItem()
        {
            Decimal precioSeleccionado = 0;
            String descPrecio = "";
            if (rBtnMinorista.Checked)
            {
                precioSeleccionado = pezAVender.GetPrecio().GetPrecioMinorista();
                descPrecio = "MINORISTA";
            }
            else if (rBtnMayorista.Checked)
            {
                precioSeleccionado = pezAVender.GetPrecio().GetPrecioMayorista();
                descPrecio = "MAYORISTA";
            }
            else if (rBtnOferta.Checked)
            {
                precioSeleccionado = pezAVender.GetPrecio().GetPrecioOferta();
                descPrecio = "OFERTA";
            }
            else
            {
                precioSeleccionado = pezAVender.GetPrecio().GetPrecioDistribuidor();
                descPrecio = "DISTRIBUIDOR";
            }

            gridItems.Rows.Add(
                            pezAVender.GetIdPez(),
                            ManagerFormats.Instance.DecimalToMoney(pezAVender.GetPrecio().GetIdPrecio(), true),
                            pezAVender.GetNombre(),
                            precioSeleccionado,
                            descPrecio,
                            Convert.ToInt32(textboxCantidad.Text),
                            ManagerFormats.Instance.DecimalToMoney(
                                precioSeleccionado * Convert.ToInt32(textboxCantidad.Text), true));
        }

        private void RemoverItem()
        {
            gridItems.Rows.RemoveAt(gridItems.SelectedRows[0].Index);
        }

        private Boolean GenerarVenta()
        {
            Decimal total = 0;

            List<EntitieVentaItem> items = new List<EntitieVentaItem>();
            int indexColIdPez = ManagerGrids.Instance.GetColumnIndexByText(gridItems, "ID PEZ");
            int indexColPrecio = ManagerGrids.Instance.GetColumnIndexByText(gridItems, "PRECIO");
            int indexColCantidad = ManagerGrids.Instance.GetColumnIndexByText(gridItems, "CANTIDAD");

            for (int i = 0; i < gridItems.Rows.Count; i++)
            {
                int idPez = Convert.ToInt32(gridItems.Rows[i].Cells[indexColIdPez].Value);
                Decimal precio = ManagerFormats.Instance.MoneyToDecimal(gridItems.Rows[i].Cells[indexColPrecio].Value.ToString());
                int cantidad = ManagerFormats.Instance.NumberToInt(gridItems.Rows[i].Cells[indexColCantidad].Value.ToString());
                total += cantidad * precio;

                EntitiePez pez = ControllerPeces.Instance.GetPezById(idPez);
                items.Add(new EntitieVentaItem(0, pez.GetIdPez(), pez.GetNombre(), precio, cantidad));
            }

            if (ControllerVentas.Instance.GenerarVenta(new EntitieVenta(cuenta.GetIdCuenta(), cliente.GetIdCliente(),
                cuenta.GetNombre(), cliente.GetNombre(), total, DateTime.Today, items)))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Venta generada");
                return true;
            }
            else
            {
                ManagerMessages.Instance.NewErrorMessage(this, "No se pudo generar la venta");
                return false;
            }
        }

        // |==============================EVENTOS==============================|
        private void FormVender_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            if (ValidVenta())
            {
                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea generar la venta?"))
                    if (GenerarVenta())
                        LimpiarCamposNuevaVenta();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionarCuenta_Click(object sender, EventArgs e)
        {
            using (var form = new FormCaja(true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cuenta = ControllerCuentas.Instance.GetCuentaById(form.IdCuentaSeleccionada);
                    textboxCuenta.Text = cuenta.GetNombre();
                }
            }
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            using (var form = new FormClientes(true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cliente = ControllerClientes.Instance.GetClienteById(form.IdClienteSeleccionado);
                    textboxCliente.Text = cliente.GetNombre();
                }
            }
        }

        private void btnSeleccionarPez_Click(object sender, EventArgs e)
        {
            using (var form = new FormPeces(true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pezAVender = ControllerPeces.Instance.GetPezById(form.IdPezSeleccionado);
                    textboxPez.Text = pezAVender.GetNombre();

                    textboxMinorista.Text =
                        ManagerFormats.Instance.DecimalToMoney(pezAVender.GetPrecio().GetPrecioMinorista(), true);
                    textboxMayorista.Text =
                        ManagerFormats.Instance.DecimalToMoney(pezAVender.GetPrecio().GetPrecioMayorista(), true);
                    textboxOferta.Text =
                        ManagerFormats.Instance.DecimalToMoney(pezAVender.GetPrecio().GetPrecioOferta(), true);
                    textboxDistribuidor.Text =
                        ManagerFormats.Instance.DecimalToMoney(pezAVender.GetPrecio().GetPrecioDistribuidor(), true);
                }
            }
        }

        private void rBtnMinorista_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMinorista.Checked)
                SeleccionarPrecioMinorista();
        }

        private void rBtnMayorista_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMayorista.Checked)
                SeleccionarPrecioMayorista();
        }

        private void rBtnOferta_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnOferta.Checked)
                SeleccionarPrecioOferta();
        }

        private void rBtnDistribuidor_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDistribuidor.Checked)
                SeleccionarPrecioDistribuidor();
        }


        private void FormVender_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (ValidItem())
            {
                AgregarItem();
                LimpiarCamposItem();
            }
        }

        private void FormVender_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gridItems.Rows.Count > 0 && !ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea cancelar la venta?"))
                e.Cancel = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (gridItems.SelectedRows.Count > 0)
            {
                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea remover de la venta el item seleccionado?"))
                    RemoverItem();
            }
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione un item a remover");
        }
    }
}
