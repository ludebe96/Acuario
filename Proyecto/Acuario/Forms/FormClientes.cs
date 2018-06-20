using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Acuario.Entities;
using Acuario.Controllers;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormClientes : MetroFramework.Forms.MetroForm
    {

        private Boolean modoSeleccion;
        public int IdClienteSeleccionado;

        // |==============================ATRIBUTOS==============================|

        // |==============================CONSTRUCTORES==============================|

        public FormClientes()
        {
            InitializeComponent();
        }

        public FormClientes(Boolean modoSeleccion)
        {
            InitializeComponent();

            this.modoSeleccion = true;
        }

        // |==============================METODOS Y FUNCIONES==============================|

        public void RefreshGrid()
        {
            gridClientes.Rows.Clear();
            List<EntitieCliente> clientes = ControllerClientes.Instance.GetClientes(textboxCliente.Text);

            for (int i = 0; i < clientes.Count; i++)
            {
                gridClientes.Rows.Add(
                    Convert.ToInt32(clientes[i].GetIdCliente()),
                    clientes[i].GetNombre(),
                    clientes[i].GetCuit(),
                    clientes[i].GetMail(),
                    clientes[i].GetTelefono1(),
                    clientes[i].GetTelefono2(),
                    clientes[i].GetTelefono3());
            }
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void ModificarCliente()
        {
            int colIdCliente = ManagerGrids.Instance.GetColumnIndexByText(gridClientes, "ID CLIENTE");
            int idCliente = Convert.ToInt32(gridClientes.Rows[gridClientes.SelectedRows[0].Index].Cells[colIdCliente].Value);

            using (var form = new FormNuevoCliente(idCliente))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    RefreshGrid();
            }
        }

        private void EliminarCliente()
        {
            int indexColId = ManagerGrids.Instance.GetColumnIndexByText(gridClientes, "ID CLIENTE");
            int idCliente = Convert.ToInt32(gridClientes.Rows[gridClientes.SelectedRows[0].Index].Cells[indexColId].Value);

            ControllerClientes.Instance.EliminarCliente(idCliente);

            ManagerMessages.Instance.NewInformationMessage(this, "Cliente eliminado");
            RefreshGrid();
        }

        private void PrepararModoSeleccion()
        {
            Text = "Seleccione un Cliente";
            btnNuevo.Text = "Seleccionar";

            btnModificar.Visible = false;
            btnEliminar.Visible = false;
        }

        // |==============================EVENTOS==============================|

        private void FormClientes_Load(object sender, EventArgs e)
        {
            RefreshGrid();

            if (modoSeleccion)
                PrepararModoSeleccion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!modoSeleccion)
            {
                using (var form = new FormNuevoCliente())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                        RefreshGrid();
                }
            }
            else
            {
                int colIdCliente= ManagerGrids.Instance.GetColumnIndexByText(gridClientes, "ID CLIENTE");
                IdClienteSeleccionado = Convert.ToInt32(gridClientes.Rows[gridClientes.SelectedRows[0].Index].Cells[colIdCliente].Value);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count > 0)
                ModificarCliente();
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione un cliente a modificar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridClientes.SelectedRows.Count > 0)
            {
                int indexColNombre = ManagerGrids.Instance.GetColumnIndexByText(gridClientes, "NOMBRE");
                String nombreCliente = gridClientes.Rows[gridClientes.SelectedRows[0].Index].Cells[indexColNombre].Value.ToString();

                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea eliminar el cliente '" + nombreCliente + "'?"))
                    EliminarCliente();
            }
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione un cliente a eliminar");
        }

        private void FormClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}
