using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormEspecies : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|
        
        public FormEspecies()
        {
            InitializeComponent();
        }

        // |==============================CONSTRUCTORES==============================|

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void RefreshGrid()
        {
            gridEspecies.Rows.Clear();

            List<EntitiePezEspecie> especies = new List<EntitiePezEspecie>();

            if (textboxEspecie.Text.Trim().Equals(""))
                especies = ControllerPeces.Instance.GetEspecies();
            else
                especies = ControllerPeces.Instance.GetEspecies(textboxEspecie.Text.Trim());

            for (int i = 0; i < especies.Count; i++)
            {
                gridEspecies.Rows.Add(especies[i].GetIdPezEspecie(),
                    especies[i].GetNombre());
            }
        }

        private void ModificarEspecie()
        {
            int colIdEspecie = ManagerGrids.Instance.GetColumnIndexByName(gridEspecies, "IDESPECIE");
            int idEspecie = Convert.ToInt32(gridEspecies.Rows[gridEspecies.SelectedRows[0].Index].Cells[colIdEspecie].Value);

            using (var form = new FormNuevaEspecie(idEspecie))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    RefreshGrid();
            }
        }

        private void EliminarEspecie()
        {
            int indexColId = ManagerGrids.Instance.GetColumnIndexByName(gridEspecies, "IDESPECIE");
            int idEspecie = Convert.ToInt32(gridEspecies.Rows[gridEspecies.SelectedRows[0].Index].Cells[indexColId].Value);

            ControllerPeces.Instance.EliminarEspecie(idEspecie);

            ManagerMessages.Instance.NewInformationMessage(this, "Especie eliminada");
            RefreshGrid();
        }

        // |==============================EVENTOS==============================|

        private void FormEspecies_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (var form = new FormNuevaEspecie())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    RefreshGrid();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridEspecies.SelectedRows.Count > 0)
                ModificarEspecie();
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione una especie a modificar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridEspecies.SelectedRows.Count > 0)
            {
                int colIndex = ManagerGrids.Instance.GetColumnIndexByName(gridEspecies, "IDESPECIE");
                int colNombre = ManagerGrids.Instance.GetColumnIndexByName(gridEspecies, "ESPECIE");
                String nombreEspecie = gridEspecies.Rows[gridEspecies.SelectedRows[0].Index].Cells[colNombre].Value.ToString();

                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea eliminar la especie '" + nombreEspecie + "'?\n" + 
                    "Las variedades de esta especie quedarán sin especie asignada."))
                    EliminarEspecie();
            }
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione una especie a eliminar");
        }

        private void FormEspecies_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerForms.Instance.PrevForm();
        }

        private void textboxEspecie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RefreshGrid();
        }
    }
}
