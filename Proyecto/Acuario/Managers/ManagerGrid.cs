﻿using System;
using System.Windows.Forms;

using MetroFramework;

namespace Acuario.Managers
{
    public class ManagerGrid
    {
        // |==============================ATRIBUTOS==============================|
        private static ManagerGrid instance;
        public static ManagerGrid Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerGrid();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|
        private ManagerGrid()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public int GetColumnIndexByText(DataGridView dgv, String columnText)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].HeaderText.ToUpper().Equals(columnText.ToUpper()))
                    return i;
            }

            return -1;
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}