﻿using System;

using System.Collections.Generic;
using System.Data;

using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Controllers
{
    public class ControllerGastoCategorias
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerGastoCategorias instance;
        public static ControllerGastoCategorias Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerGastoCategorias();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerGastoCategorias()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public List<EntitieGastoCategoria> GetCategorias()
        {
            List<EntitieGastoCategoria> categorias = new List<EntitieGastoCategoria>();
            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Gasto_Categorias");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                categorias.Add(new EntitieGastoCategoria(
                    Convert.ToInt32(dt.Rows[i][0]),
                    dt.Rows[i][1].ToString()));
            }

            return categorias;
        }

        public EntitieGastoCategoria GetCategoriaById(int idCategoria)
        {
            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Gasto_Categorias WHERE ID_Gasto_Categoria = " + idCategoria);
            EntitieGastoCategoria categoria = null;

            if (dt.Rows.Count > 0)
                categoria = new EntitieGastoCategoria(
                    Convert.ToInt32(dt.Rows[0][0]),
                    dt.Rows[0][1].ToString());

            return categoria;
        }

        public void PopulateComboboxCategorias(ref MetroFramework.Controls.MetroComboBox combo, ref List<int> idCategoriasCombobox)
        {
            List<EntitieGastoCategoria> categorias = GetCategorias();
            idCategoriasCombobox = new List<int>();
            combo.Items.Clear();

            combo.Items.Add("-");
            idCategoriasCombobox.Add(0);

            for (int i = 0; i < categorias.Count; i++)
            {
                combo.Items.Add(categorias[i].GetNombre());
                idCategoriasCombobox.Add(categorias[i].GetIdCuenta());
            }

            if (combo.Items.Count > 0)
                combo.SelectedIndex = 0;
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

    }
}