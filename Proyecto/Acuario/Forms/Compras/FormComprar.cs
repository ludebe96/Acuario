using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormComprar : MetroFramework.Forms.MetroForm
    {

        // |==============================ATRIBUTOS==============================|

        private EntitieCuenta cuenta;
        private EntitiePez pezAComprar;
        /* Este atributo contendrá, en orden, los subtotales
         * ingresados para cada pez comprado.
         */
        private List<Decimal> subtotalesItems;

        // |==============================CONSTRUCTORES==============================|

        public FormComprar()
        {
            InitializeComponent();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private Boolean ValidCompra()
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

        private Boolean ValidItem()
        {
            if (pezAComprar == null)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione un pez");
                return false;
            }

            if (textboxCantidad.Text.Equals(String.Empty))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Ingrese la cantidad a vender");
                return false;
            }
            else if (!ManagerFormats.Instance.MontoValido(textboxCantidad.Text) || Convert.ToInt32(textboxCantidad.Text) <= 0)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "La cantidad ingresada es inválida");
                return false;
            }

            if (textboxCantidad.Text.Equals(String.Empty))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Ingrese la cantidad a vender");
                return false;
            }

            if (textboxSubtotal.Text.Equals(String.Empty))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Ingrese el subtotal");
                return false;
            }
            else if (!ManagerFormats.Instance.MontoValido(textboxSubtotal.Text) || Convert.ToDecimal(textboxSubtotal.Text) <= 0)
            {
                ManagerMessages.Instance.NewInformationMessage(this, "El subtotal ingresada es inválida");
                return false;
            }

            if (ItemYaEnCompra(pezAComprar.GetIdPez()))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "El pez que desea agregar ya se encuentra agregado");
                return false;
            }

            return true;

        }

        private Boolean ItemYaEnCompra(int idPezAAgregar)
        {
            int idPezColId = ManagerGrids.Instance.GetColumnIndexByName(gridItems, "IDPEZ");

            for (int i = 0; i < gridItems.Rows.Count; i++)
            {
                if (idPezAAgregar == Convert.ToInt32(gridItems.Rows[i].Cells[idPezColId].Value))
                    return true;
            }

            return false;
        }

        private void AgregarItem()
        {
            gridItems.Rows.Add(
                            pezAComprar.GetIdPez(),
                            pezAComprar.GetNombre(),
                            Convert.ToInt32(textboxCantidad.Text),
                            ManagerFormats.Instance.DecimalToMoney(Convert.ToDecimal(textboxSubtotal.Text), true));

            subtotalesItems.Add(Convert.ToDecimal(textboxSubtotal.Text));
        }

        private void RemoverItem()
        {
            gridItems.Rows.RemoveAt(gridItems.SelectedRows[0].Index);
        }

        private void LimpiarCamposItem()
        {
            pezAComprar= null;
            textboxPez.Text = "";
            textboxCantidad.Text = "";
            textboxSubtotal.Text = "";
        }

        private void LimpiarCamposNuevaCompra()
        {
            LimpiarCamposItem();

            gridItems.Rows.Clear();
        }

        private Boolean GenerarCompra()
        {
            EntitiePez pez = null;
            Decimal total = 0;

            List<EntitieCompraItem> items = new List<EntitieCompraItem>();
            int indexColIdPez = ManagerGrids.Instance.GetColumnIndexByName(gridItems, "IDPEZ");
            int indexColCantidad = ManagerGrids.Instance.GetColumnIndexByName(gridItems, "CANTIDAD");

            for (int i = 0; i < gridItems.Rows.Count; i++)
            {
                int idPez = 0;
                int cantidad = 0;

                idPez = Convert.ToInt32(gridItems.Rows[i].Cells[indexColIdPez].Value);
                pez = ControllerPeces.Instance.GetPezById(idPez);
                cantidad = ManagerFormats.Instance.NumberToInt(gridItems.Rows[i].Cells[indexColCantidad].Value.ToString());
                total += subtotalesItems[i];
                items.Add(new EntitieCompraItem(0, pez.GetIdPez(), pez.GetNombre(), cantidad, subtotalesItems[i]));
            }

            if (ControllerCompras.Instance.GenerarCompra(new EntitieCompra(cuenta.GetIdCuenta(),
                cuenta.GetNombre(), total, DateTime.Today, items)))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Compra generada");
                return true;
            }
            else
            {
                ManagerMessages.Instance.NewErrorMessage(this, "No se pudo generar la compra");
                return false;
            }
        }

        // |==============================EVENTOS==============================|

        private void FormComprar_Load(object sender, EventArgs e)
        {
            subtotalesItems = new List<Decimal>();
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

        private void btnSeleccionarPez_Click(object sender, EventArgs e)
        {
            using (var form = new FormPeces(true))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pezAComprar = ControllerPeces.Instance.GetPezById(form.IdPezSeleccionado);
                    textboxPez.Text = pezAComprar.GetNombre();
                }
            }
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (ValidItem())
            {
                AgregarItem();
                LimpiarCamposItem();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarCompra_Click(object sender, EventArgs e)
        {
            if (ValidCompra())
            {
                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea generar la compra?"))
                    if (GenerarCompra())
                        LimpiarCamposNuevaCompra();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormComprar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gridItems.Rows.Count > 0 && !ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea cancelar la compra?"))
                e.Cancel = true;
        }

        private void FormComprar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}
