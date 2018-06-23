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

            List<EntitieCompraItem> items = ControllerCompras.Instance.GetItemsByIdCompra(idCompra);

            RefreshGrid(items);
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

        }

        private void FormCompraItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}
