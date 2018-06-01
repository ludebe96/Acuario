using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Acuario.Managers;

namespace Acuario.Utilities
{
    public class ControllerBase
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerBase instance;
        public static ControllerBase Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerBase();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerBase()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public List<EntitieBase> GetBase()
        {
            List<EntitieBase> _base = new List<EntitieBase>();

            DataTable dt = ManagerDB.Instance.ExecuteQuery("SELECT * FROM base");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieBase b = new EntitieBase();

                _base.Add(b);
            }

            return _base;
        }

        public EntitieBase GetBaseById(int idBase)
        {
            EntitieBase _base = null;

            DataTable dt = ManagerDB.Instance.ExecuteQuery("SELECT * FROM base WHERE ID_Base = " + idBase);

            if (dt.Rows.Count > 0)
                _base = new EntitieBase();

            return _base;
        }

        public Boolean BaseExistente(String nombre)
        {
            return ManagerDB.Instance.ExecuteQuery("SELECT * FROM Base WHERE Nombre = '" + nombre + "'").Rows.Count > 0;
        }

        public void CrearBase(EntitieBase _base)
        {
            ManagerDB.Instance.Execute("INSERT INTO Base(Nombre) VALUES('" + _base + "')");
        }

        public void ModificarBase(int idBase, EntitieBase _base)
        {
            ManagerDB.Instance.Execute("UPDATE Base SET Nombre = '" + _base + "' " +
               "WHERE ID_Base= " + idBase);
        }

        public void EliminarBase(int idBase)
        {
            ManagerDB.Instance.Execute("UPDATE Base SET Base = 0 WHERE ID_Base = " + idBase);
            ManagerDB.Instance.Execute("DELETE FROM Base WHERE ID_Base = " + idBase);
        }

        public void PopulateComboboxBase(ref MetroFramework.Controls.MetroComboBox combo, ref List<int> idBaseCombobox)
        {
            List<EntitieBase> bases = null;
            idBaseCombobox = new List<int>();
            combo.Items.Clear();

            combo.Items.Add("-");
            idBaseCombobox.Add(0);

            for (int i = 0; i < bases.Count; i++)
            {
                combo.Items.Add(bases[i]);
                idBaseCombobox.Add(Convert.ToInt32(bases[i]));
            }

            if (combo.Items.Count > 0)
                combo.SelectedIndex = 0;
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
