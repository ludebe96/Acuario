using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormCompraItems: MetroFramework.Forms.MetroForm
    {
        public FormCompraItems()
        {
            InitializeComponent();
        }

        public FormCompraItems(int idCompra)
        {
            InitializeComponent();

            textboxNroCompra.Text = idCompra.ToString();

            RefreshGrid(ControllerCompras.Instance.GetItemsByIdCompra(idCompra));
        }

        // |==============================ATRIBUTOS==============================|

        // |==============================CONSTRUCTORES==============================|

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void RefreshGrid(List<EntitieCompraItem> items)
        {
            gridCompraItems.Rows.Clear();
            if (items == null)
            {
                int idCompra = 0;
                if (!textboxNroCompra.Text.Trim().Equals(""))
                    idCompra = Convert.ToInt32(textboxNroCompra.Text);

                items = ControllerCompras.Instance.GetItems(idCompra);
            }

            for (int i = 0; i < items.Count; i++)
            {
                EntitiePez pez = ControllerPeces.Instance.GetPezById(items[i].GetIdPez());

                gridCompraItems.Rows.Add(items[i].GetIdCompraItem(),
                    pez.GetIdPez(),
                    items[i].GetIdCompra(),
                    items[i].GetIdCompra(),
                    pez.GetNombre(),
                    ManagerFormats.Instance.IntToNumber(items[i].GetCantidad()),
                    ManagerFormats.Instance.DecimalToMoney(items[i].GetSubtotal(), true));
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid(null);
        }

        // |==============================EVENTOS==============================|

        private void FormCompraItems_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void FormCompraItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }

        private void textboxNroCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RefreshGrid(ControllerCompras.Instance.GetItemsByIdCompra(Convert.ToInt32(textboxNroCompra.Text)));
        }
    }
}
