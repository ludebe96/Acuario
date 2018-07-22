using System;
using System.Windows.Forms;

namespace Acuario.Managers
{
    public class ManagerGrids
    {
        // |==============================ATRIBUTOS==============================|
        private static ManagerGrids instance;
        public static ManagerGrids Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerGrids();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|
        private ManagerGrids()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|
        public int GetColumnIndexByName(DataGridView dgv, String columnText)
        {
            columnText = "column" + columnText;

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Name.ToUpper().Equals(columnText.ToUpper()))
                    return i;
            }

            return -1;
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
