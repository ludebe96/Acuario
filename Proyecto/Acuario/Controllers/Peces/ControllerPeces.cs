using System;

using System.Collections.Generic;
using System.Data;

using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Controllers
{
    public class ControllerPeces
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerPeces instance;
        public static ControllerPeces Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerPeces();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerPeces()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |------------------------------ESPECIES------------------------------|

        public List<EntitiePezEspecie> GetEspecies()
        {
            List<EntitiePezEspecie> especies = new List<EntitiePezEspecie>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Especies ORDER BY Nombre ASC");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitiePezEspecie especie = new EntitiePezEspecie(
                    Convert.ToInt32(dt.Rows[i][0]),
                    dt.Rows[i][1].ToString());

                especies.Add(especie);
            }

            return especies;
        }

        public List<EntitiePezEspecie> GetEspecies(String nombre)
        {
            List<EntitiePezEspecie> especies = new List<EntitiePezEspecie>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Especies WHERE Nombre LIKE '%" + nombre + "%' ORDER BY Nombre ASC");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitiePezEspecie especie = new EntitiePezEspecie(
                    Convert.ToInt32(dt.Rows[i][0]),
                    dt.Rows[i][1].ToString());

                especies.Add(especie);
            }

            return especies;
        }

        public EntitiePezEspecie GetEspecieById(int idEspecie)
        {
            EntitiePezEspecie especie = null;

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Especies WHERE ID_Pez_Especie = " + idEspecie);

            if (dt.Rows.Count > 0)
                especie = new EntitiePezEspecie(
                    Convert.ToInt32(dt.Rows[0][0]),
                    dt.Rows[0][1].ToString());

            return especie;
        }

        public Boolean EspecieExistente(String nombre)
        {
            return ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Especies WHERE Nombre = '" + nombre + "'").Rows.Count > 0;
        }

        public void CrearEspecie(EntitiePezEspecie especie, Boolean crearVariedadDefault)
        {
            ManagerDatabase.Instance.Execute("INSERT INTO Pez_Especies(Nombre) VALUES('" + especie.GetNombre() + "')");

            if (crearVariedadDefault)
            {
                int idEspecie = Convert.ToInt32(ManagerDatabase.Instance.ExecuteQuery("SELECT MAX(ID_Pez_Especie) FROM Pez_Especies").Rows[0][0]);

                // Crea variedad default
                CrearVariedad(new EntitiePezVariedad(idEspecie, "-", true));
            }
        }

        public void ModificarEspecie(int idEspecie, EntitiePezEspecie especie)
        {
            ManagerDatabase.Instance.Execute("UPDATE Pez_Especies SET Nombre = '" + especie.GetNombre() + "' " +
               "WHERE ID_Pez_Especie= " + idEspecie);
        }

        public void EliminarEspecie(int idEspecie)
        {
            EliminarVariedadesByIdEspecie(idEspecie);

            ManagerDatabase.Instance.Execute("DELETE FROM Pez_Especies WHERE ID_Pez_Especie = " + idEspecie);
        }

        public void PopulateComboboxEspecies(ref MetroFramework.Controls.MetroComboBox combo, ref List<int> idEspeciesCombobox)
        {
            List<EntitiePezEspecie> especies = GetEspecies();
            idEspeciesCombobox = new List<int>();
            combo.Items.Clear();

            combo.Items.Add("-");
            idEspeciesCombobox.Add(0);

            for (int i = 0; i < especies.Count; i++)
            {
                combo.Items.Add(especies[i].GetNombre());
                idEspeciesCombobox.Add(especies[i].GetIdPezEspecie());
            }

            if (combo.Items.Count > 0)
                combo.SelectedIndex = 0;
        }

        // |------------------------------VARIEDADES------------------------------|

        public List<EntitiePezVariedad> GetVariedades()
        {
            List<EntitiePezVariedad> variedades = new List<EntitiePezVariedad>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Variedades ORDER BY Nombre ASC");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitiePezVariedad variedad = new EntitiePezVariedad(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    dt.Rows[i][2].ToString(),
                    Convert.ToBoolean(dt.Rows[i][3]));

                variedades.Add(variedad);
            }

            return variedades;
        }

        public List<EntitiePezVariedad> GetVariedades(String nombre, int idEspecie)
        {
            List<EntitiePezVariedad> variedades = new List<EntitiePezVariedad>();

            String query = "SELECT * FROM Pez_Variedades ";
            Boolean whereAdded = false;

            if (!nombre.Equals(String.Empty))
            {
                query += "WHERE Nombre LIKE '%" + nombre + "%' ";
                whereAdded = true;
            }

            if (idEspecie > 0)
            {
                if (whereAdded)
                    query += "AND ID_Pez_Especie = " + idEspecie + " ";
                else
                {
                    query += "WHERE ID_Pez_Especie = " + idEspecie + " ";
                    whereAdded = true;
                }
            }

            query += "ORDER BY Nombre ASC";

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitiePezVariedad variedad = new EntitiePezVariedad(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    dt.Rows[i][2].ToString(),
                    Convert.ToBoolean(dt.Rows[i][3]));

                variedades.Add(variedad);
            }

            return variedades;
        }

        public List<EntitiePezVariedad> GetVariedadesByIdEspecie(int idEspecie)
        {
            List<EntitiePezVariedad> variedades = new List<EntitiePezVariedad>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Variedades WHERE ID_Pez_Especie = " + idEspecie + " ORDER BY Nombre ASC");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitiePezVariedad variedad = new EntitiePezVariedad(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    dt.Rows[i][2].ToString(),
                    Convert.ToBoolean(dt.Rows[i][3]));

                variedades.Add(variedad);
            }

            return variedades;
        }

        public EntitiePezVariedad GetVariedadById(int idVariedad)
        {
            EntitiePezVariedad variedad = null;

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Variedades WHERE ID_Pez_Variedad = " + idVariedad);

            if (dt.Rows.Count > 0)
                variedad = new EntitiePezVariedad(
                    Convert.ToInt32(dt.Rows[0][0]),
                    Convert.ToInt32(dt.Rows[0][1]),
                    dt.Rows[0][2].ToString(),
                    Convert.ToBoolean(dt.Rows[0][3]));

            return variedad;
        }

        public Boolean VariedadExistente(int idEspecie, String nombre)
        {
            return ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Variedades WHERE ID_Pez_Especie = " + idEspecie + " AND " +
                "Nombre = '" + nombre + "'").Rows.Count > 0;
        }

        public void CrearVariedad(EntitiePezVariedad variedad)
        {
            ManagerDatabase.Instance.ExecuteQuery("INSERT INTO Pez_Variedades(ID_Pez_Especie, Nombre, Es_Default) " +
                "VALUES(" + variedad.GetIdPezEspecie() + ", '" + variedad.GetNombre() + "', " + Convert.ToInt16(variedad.EsDefault()) + ")");
        }

        public void ModificarVariedad(int idVariedad, EntitiePezVariedad variedad)
        {
            ManagerDatabase.Instance.Execute("UPDATE Pez_Variedades SET ID_Pez_Especie = " + variedad.GetIdPezEspecie() + ", " +
                "Nombre = '" + variedad.GetNombre() + "' " +
                "WHERE ID_Pez_Variedad = " + idVariedad);
        }

        public void EliminarVariedad(int idVariedad)
        {
            // Se asigna a los pecies la variedad default de esa especie
            int idVariedadDefault = 0;
            EntitiePezVariedad variedad = GetVariedadById(idVariedad);
            idVariedadDefault = GetVariedadesByIdEspecie(variedad.GetIdPezEspecie())[0].GetIdPezVariedad();


            ManagerDatabase.Instance.Execute("UPDATE Peces SET ID_Pez_Variedad = " + idVariedadDefault + " WHERE ID_Pez_Variedad = " + idVariedad);
            ManagerDatabase.Instance.Execute("DELETE FROM Pez_Variedades WHERE ID_Pez_Variedad = " + idVariedad);
        }

        public void EliminarVariedadesByIdEspecie(int idEspecie)
        {
            List<EntitiePezVariedad> variedades = GetVariedadesByIdEspecie(idEspecie);

            // Borra todos los peces de estas diferentes variedades
            foreach (EntitiePezVariedad v in variedades)
                EliminarPecesByIdVariedad(v.GetIdPezVariedad());

            // Borra las variedades
            ManagerDatabase.Instance.Execute("DELETE FROM Pez_Variedades WHERE ID_Pez_Especie = " + idEspecie);
        }

        public void PopulateComboboxVariedades(ref MetroFramework.Controls.MetroComboBox combo,
            ref List<int> idVariedadesCombobox, int idEspecie, Boolean traerVariedadDefault)
        {
            int i = 0;

            List<EntitiePezVariedad> variedades = new List<EntitiePezVariedad>();
            combo.Items.Clear();
            idVariedadesCombobox = new List<int>();

            if (idEspecie == 0 || !traerVariedadDefault)
            {
                combo.Items.Add("-");
                idVariedadesCombobox.Add(0);

                i = 1;
            }

            variedades = GetVariedadesByIdEspecie(idEspecie);
            for (i = i; i < variedades.Count; i++)
            {
                combo.Items.Add(variedades[i].GetNombre());
                idVariedadesCombobox.Add(variedades[i].GetIdPezVariedad());
            }

            if (combo.Items.Count > 0)
                combo.SelectedIndex = 0;
        }


        // |------------------------------TAMAÑOS------------------------------|

        public List<EntitiePezTamaño> GetTamaños()
        {
            List<EntitiePezTamaño> tamaños = new List<EntitiePezTamaño>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Tamaños");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitiePezTamaño tamaño = new EntitiePezTamaño(
                    Convert.ToInt32(dt.Rows[i][0]),
                    dt.Rows[i][1].ToString());

                tamaños.Add(tamaño);
            }

            return tamaños;
        }

        public EntitiePezTamaño GetTamañoById(int idTamaño)
        {
            EntitiePezTamaño tamaño = null;

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Pez_Tamaños WHERE ID_Pez_Tamaño = " + idTamaño);

            if (dt.Rows.Count > 0)
                tamaño = new EntitiePezTamaño(
                    Convert.ToInt32(dt.Rows[0][0]),
                    dt.Rows[0][1].ToString());

            return tamaño;
        }

        public void PopulateComboboxTamaños(ref MetroFramework.Controls.MetroComboBox combo, ref List<int> idTamañosCombobox)
        {
            List<EntitiePezTamaño> tamaños = ControllerPeces.Instance.GetTamaños();
            idTamañosCombobox = new List<int>();
            combo.Items.Clear();

            for (int i = 0; i < tamaños.Count; i++)
            {
                combo.Items.Add(tamaños[i].GetDescripcion());
                idTamañosCombobox.Add(tamaños[i].GetIdTamaño());
            }

            combo.SelectedIndex = 0;
        }

        // |------------------------------PECES------------------------------|

        public List<EntitiePez> GetPeces(String nombre, int idEspecie, int idVariedad)
        {

            List<EntitiePez> peces = new List<EntitiePez>();
            String query = "SELECT " +
                "DISTINCT(P.ID_Pez), P.ID_Pez_Variedad, P.ID_Pez_Tamaño, P.ID_Precio, P.Nombre, P.Stock, PE.Nombre, PV.Nombre, PT.Nombre " +
                "FROM Peces P " +
                "LEFT JOIN Pez_Variedades PV " +
                "ON P.ID_Pez_Variedad = PV.ID_Pez_Variedad " +
                "LEFT JOIN Pez_Especies PE " +
                "ON PE.ID_Pez_Especie = PV.ID_Pez_Especie " +
                "LEFT JOIN Pez_Tamaños PT " +
                "ON P.ID_Pez_Tamaño = PT.ID_Pez_Tamaño ";

            Boolean whereAdded = false;

            if (!nombre.Equals(String.Empty))
            {
                query += "WHERE P.Nombre LIKE '%" + nombre + "%' ";
                whereAdded = true;
            }

            if (idEspecie > 0)
            {
                if (whereAdded)
                    query += "AND PV.ID_Pez_Especie = " + idEspecie + " ";
                else
                {
                    query += "WHERE PV.ID_Pez_Especie = " + idEspecie + " ";
                    whereAdded = true;
                }
            }

            if (idVariedad > 0)
            {
                if (whereAdded)
                    query += "AND PV.ID_Pez_Variedad = " + idVariedad + " ";
                else
                {
                    query += "WHERE PV.ID_Pez_Variedad = " + idVariedad + " ";
                    whereAdded = true;
                }
            }

            query += "ORDER BY PE.Nombre, PV.Nombre, PT.Nombre ASC";

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitiePez pez = new EntitiePez(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    Convert.ToInt32(dt.Rows[i][3]),
                    dt.Rows[i][4].ToString(),
                    Convert.ToInt32(dt.Rows[i][5]));

                peces.Add(pez);
            }

            return peces;
        }

        public EntitiePez GetPezById(int idPez)
        {
            EntitiePez pez = null;

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Peces WHERE ID_Pez = " + idPez);

            if (dt.Rows.Count > 0)
                pez = new EntitiePez(
                    Convert.ToInt32(dt.Rows[0][0]),
                    Convert.ToInt32(dt.Rows[0][1]),
                    Convert.ToInt32(dt.Rows[0][2]),
                    Convert.ToInt32(dt.Rows[0][3]),
                    dt.Rows[0][4].ToString(),
                    Convert.ToInt32(dt.Rows[0][5]));

            return pez;
        }

        public Boolean PezExistente(int idEspecie, int idVariedad)
        {
            return ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Peces WHERE ID_Pez_Especie = " + idEspecie + " AND " +
                "ID_Pez_Variedad = " + idVariedad).Rows.Count > 0;
        }

        public void CrearPez(EntitiePez pez)
        {
            ManagerDatabase.Instance.Execute("INSERT INTO Peces(ID_Pez_Variedad, ID_Pez_Tamaño, ID_Precio, Nombre, Stock) " +
                "VALUES(" + pez.GetIdVariedad() + ", " + pez.GetIdTamaño() + ", " + pez.GetIdPrecio() + ", '" + pez.GetNombre() + "', " + pez.GetStock() + ")");
        }

        public void ModificarPez(int idPezAModificar, EntitiePez pez)
        {
            ManagerDatabase.Instance.Execute("UPDATE Peces SET ID_Pez_Variedad = " + pez.GetIdVariedad() + ", " +
                "ID_Pez_Tamaño = " + pez.GetIdTamaño() + ", " +
                "ID_Precio = " + pez.GetIdPrecio() + ", " +
                "Nombre = '" + pez.GetNombre() + "', " +
                "Stock = " + pez.GetStock() + " " +
                "WHERE ID_Pez = " + idPezAModificar);
        }

        public void EliminarPez(int idPez)
        {
            ManagerDatabase.Instance.Execute("DELETE FROM Peces WHERE ID_Pez = " + idPez);
        }

        public void EliminarPecesByIdVariedad(int idVariedad)
        {
            ManagerDatabase.Instance.Execute("DELETE FROM Peces WHERE ID_Pez_Variedad = " + idVariedad);
        }

        public void VariarStock(int idPez, int cantidad)
        {
            String signo = "";

            if (cantidad >= 0)
                signo = "+";

            ManagerDatabase.Instance.Execute("UPDATE Peces SET Stock = Stock " + signo + " " + cantidad + " WHERE ID_Pez = " + idPez);
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        // |------------------------------ESPECIES------------------------------|

        // |------------------------------VARIEDADES------------------------------|


        // |------------------------------TAMAÑOS------------------------------|

        // |------------------------------PECES------------------------------|

    }
}