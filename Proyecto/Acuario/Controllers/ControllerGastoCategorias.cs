using System;

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
            DataTable dt = ManagerDB.Instance.ExecuteQuery("SELECT * FROM Gasto_Categorias");

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
            DataTable dt = ManagerDB.Instance.ExecuteQuery("SELECT * FROM Gasto_Categorias WHERE ID_Gasto_Categoria = " + idCategoria);
            EntitieGastoCategoria categoria = null;

            if (dt.Rows.Count > 0)
                categoria = new EntitieGastoCategoria(
                    Convert.ToInt32(dt.Rows[0][0]),
                    dt.Rows[0][1].ToString());

            return categoria;
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

    }
}