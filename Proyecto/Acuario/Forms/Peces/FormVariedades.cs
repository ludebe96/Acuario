using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Forms
{
    public partial class FormVariedades : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        private List<int> idEspeciesCombobox;

        // |==============================CONSTRUCTOR==============================|

        public FormVariedades()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {
            gridVariedades.Rows.Clear();

            List<EntitiePezVariedad> variedades = new List<EntitiePezVariedad>();

            if (textboxVariedad.Text.Trim().Equals("") && comboboxEspecies.SelectedIndex == 0)
                variedades = ControllerPeces.Instance.GetVariedades();
            else
                variedades = ControllerPeces.Instance.GetVariedades(
                    textboxVariedad.Text.Trim(),
                    idEspeciesCombobox[comboboxEspecies.SelectedIndex]);

            for (int i = 0; i < variedades.Count; i++)
            {
                // Si es una variedad default, al saltea para no mostrarla
                if (variedades[i].GetNombre().Equals("-"))
                    continue;

                EntitiePezEspecie especie = null;
                if (variedades[i].GetIdPezEspecie() > 0)
                    especie = variedades[i].GetEspecie();

                gridVariedades.Rows.Add(variedades[i].GetIdPezEspecie(),
                    variedades[i].GetIdPezVariedad(),
                    especie == null ? "" : especie.GetNombre(),
                    variedades[i].GetNombre());
            }
        }

        private void ModificarVariedad()
        {
            int colIdVariedad = ManagerGrids.Instance.GetColumnIndexByName(gridVariedades, "IDVARIEDAD");
            int idVariedad = Convert.ToInt32(gridVariedades.Rows[gridVariedades.SelectedRows[0].Index].Cells[colIdVariedad].Value);

            using (var form = new FormNuevaVariedad(idVariedad))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    RefreshGrid();
            }
        }

        private void EliminarVariedad()
        {
            int indexColId = ManagerGrids.Instance.GetColumnIndexByName(gridVariedades, "IDVARIEDAD");
            int idVariedad = Convert.ToInt32(gridVariedades.Rows[gridVariedades.SelectedRows[0].Index].Cells[indexColId].Value);

            ControllerPeces.Instance.EliminarVariedad(idVariedad);

            ManagerMessages.Instance.NewInformationMessage(this, "Variedad eliminada");
            RefreshGrid();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        // |==============================EVENTOS==============================|
        private void FormVariedades_Load(object sender, EventArgs e)
        {
            ControllerPeces.Instance.PopulateComboboxEspecies(ref comboboxEspecies, ref idEspeciesCombobox);

            RefreshGrid();

            WindowState = FormWindowState.Maximized;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridVariedades.SelectedRows.Count > 0)
                ModificarVariedad();
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione una especie a modificar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridVariedades.SelectedRows.Count > 0)
            {
                int colIndex = ManagerGrids.Instance.GetColumnIndexByName(gridVariedades, "IDVARIEDAD");
                int colNombre = ManagerGrids.Instance.GetColumnIndexByName(gridVariedades, "VARIEDAD");
                String nombreVariedad = gridVariedades.Rows[gridVariedades.SelectedRows[0].Index].Cells[colNombre].Value.ToString();

                if (ManagerMessages.Instance.NewConfirmMessage(this, "¿Desea eliminar la variedad '" + nombreVariedad + "'?\n" +
                    "Los peces de esta variedad quedarán sin variedad asignada."))
                    EliminarVariedad();
            }
            else
                ManagerMessages.Instance.NewInformationMessage(this, "Seleccione una variedad a eliminar");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (var form = new FormNuevaVariedad())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    RefreshGrid();
            }
        }

        private void comboboxEspecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void textboxVariedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RefreshGrid();
        }

        private void FormVariedades_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerForms.Instance.PrevForm();
        }
    }
}
