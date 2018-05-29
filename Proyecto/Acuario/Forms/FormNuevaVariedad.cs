﻿using System;
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
    public partial class FormNuevaVariedad : MetroFramework.Forms.MetroForm
    {
        // |==============================ATRIBUTOS==============================|

        private EntitiePezVariedad variedadAModificar;
        private Boolean modificando;
        private List<int> idEspeciesCombobox;

        // |==============================CONSTRUCTORES==============================|

        public FormNuevaVariedad()
        {
            InitializeComponent();

            modificando = false;
        }

        public FormNuevaVariedad(int idVariedad)
        {
            InitializeComponent();

            variedadAModificar = ControllerPeces.Instance.GetVariedadById(idVariedad);
            modificando = true;
        }

        // |==============================METODOS Y FUNCIONES==============================|


        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private Boolean ValidInput()
        {
            if (textboxNombre.Text.Equals(String.Empty))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "Complete los campos");
                return false;
            }

            return true;
        }

        private Boolean VariedadExistente()
        {
            if (ControllerPeces.Instance.VariedadExistente(textboxNombre.Text))
            {
                ManagerMessages.Instance.NewInformationMessage(this, "La variedad ya existe");
                return true;
            }

            return false;
        }

        private void CrearVariedad()
        {
            if (!modificando)
                ControllerPeces.Instance.CrearVariedad(new EntitiePezVariedad(idEspeciesCombobox[comboboxEspecies.SelectedIndex],
                    textboxNombre.Text, false));
            else
                ControllerPeces.Instance.ModificarVariedad(variedadAModificar.GetIdPezVariedad(),
                    new EntitiePezVariedad(idEspeciesCombobox[comboboxEspecies.SelectedIndex],
                textboxNombre.Text, false));

            ManagerForms.Instance.ActualizarFormPeces();
        }

        private void PrepararModoModificacion()
        {
            btnCrearVariedad.Text = "Modificar";

            FillCampos();
        }

        private void FillCampos()
        {
            textboxNombre.Text = variedadAModificar.GetNombre();

            // Combo especies
            if (variedadAModificar != null && variedadAModificar.GetIdPezEspecie() > 0)
            {
                for (int i = 0; i < idEspeciesCombobox.Count; i++)
                {
                    if (idEspeciesCombobox[i] == variedadAModificar.GetIdPezEspecie())
                        comboboxEspecies.SelectedIndex = i;
                }
            }
        }

        // |==============================EVENTOS==============================|

        private void FormNuevaVariedad_Load(object sender, EventArgs e)
        {
            ControllerPeces.Instance.PopulateComboboxEspecies(ref comboboxEspecies, ref idEspeciesCombobox);

            if (modificando)
                PrepararModoModificacion();
        }

        private void btnCrearVariedad_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                if (modificando || (!modificando && !VariedadExistente()))
                {
                    CrearVariedad();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnNuevaEspecie_Click(object sender, EventArgs e)
        {
            ManagerForms.Instance.NewForm("FormNuevaEspecie", true, false);
        }

        private void FormNuevaVariedad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Modal)
                ManagerForms.Instance.PrevForm();
        }
    }
}