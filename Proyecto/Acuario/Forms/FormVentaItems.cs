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

                items = ControllerVentas.Instance.GetItems(idVenta, textboxCliente.Text,
                    dateTimeDesde.Value, dateTimeHasta.Value);
            }

            for (int i = 0; i < items.Count; i++)
            {
                EntitiePez pez = ControllerPeces.Instance.GetPezById(items[i].GetIdPez());

                gridVentaItems.Rows.Add(items[i].GetIdVentaItem(),
                    pez.GetIdPez(),
                    items[i].GetIdVenta(),
                    items[i].GetIdVenta(),
                    pez.GetNombre(),
                    ManagerFormats.Instance.DecimalToMoney(items[i].GetMontoUnitario(), true),
                    ManagerFormats.Instance.IntToNumber(items[i].GetCantidad()),
                    ManagerFormats.Instance.DecimalToMoney(items[i].GetSubtotal(), true));
            }

        }

        // |==============================EVENTOS==============================|

        private void FormVentaItems_Load(object sender, EventArgs e)
        {
            dateTimeDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        private void FormVentaItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid(null);
        }
    }
}