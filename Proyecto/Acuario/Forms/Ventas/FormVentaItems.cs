using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormVentaItems : MetroFramework.Forms.MetroForm
    {
        public FormVentaItems()
        {
            InitializeComponent();
        }

        public FormVentaItems(int idVenta)
        {
            InitializeComponent();

            textboxNroVenta.Text = idVenta.ToString();

            List<EntitieVentaItem> items = ControllerVentas.Instance.GetItemsByIdVenta(idVenta);

            RefreshGrid(items);
        }

        // |==============================ATRIBUTOS==============================|

        // |==============================CONSTRUCTORES==============================|

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void RefreshGrid(List<EntitieVentaItem> items)
        {
            gridVentaItems.Rows.Clear();
            if (items == null)
            {
                int idVenta = 0;
                if (!textboxNroVenta.Text.Trim().Equals(""))
                    idVenta = Convert.ToInt32(textboxNroVenta.Text);

                items = ControllerVentas.Instance.GetItems(idVenta, textboxPez.Text);
            }

            for (int i = 0; i < items.Count; i++)
            {
                gridVentaItems.Rows.Add(items[i].GetIdVentaItem(),
                    items[i].GetIdPez(),
                    items[i].GetIdVenta(),
                    items[i].GetIdVenta(),
                    items[i].GetNombrePez(),
                    ManagerFormats.Instance.DecimalToMoney(items[i].GetMontoUnitario(), true),
                    ManagerFormats.Instance.IntToNumber(items[i].GetCantidad()),
                    ManagerFormats.Instance.DecimalToMoney(items[i].GetSubtotal(), true));
            }
        }

        // |==============================EVENTOS==============================|

        private void FormVentaItems_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid(null);
        }

        private void FormVentaItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }

        private void textboxNroVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RefreshGrid(null);
        }

        private void textboxPez_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RefreshGrid(null);
        }
    }
}