using System;

using System.Collections.Generic;
using System.Data;

using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Controllers
{
    public class ControllerTransacciones
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerTransacciones instance;
        public static ControllerTransacciones Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerTransacciones();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerTransacciones()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public int NuevaTransaccion(EntitieTransaccion transaccion)
        {
            ManagerDatabase.Instance.Execute("INSERT INTO Transacciones " +
                "VALUES(" + transaccion.GetIdCuenta() + ", " + transaccion.GetIdTipoTransaccion() + ", " +
                transaccion.GetMonto().ToString().Replace(",", ".") + ", '" + transaccion.GetFechaHora().ToString() + "')");

            String signo = "";
            if (transaccion.GetMonto() >= 0)
                signo = "+";

            ManagerDatabase.Instance.Execute("UPDATE Cuentas SET Balance = Balance " + signo + " " + transaccion.GetMonto().ToString().Replace(",", ".") + " " + 
                "WHERE ID_Cuenta = " + transaccion.GetIdCuenta());

            ActualizarResumenHome();

            return Convert.ToInt32(ManagerDatabase.Instance.ExecuteQuery("SELECT MAX(ID_Transaccion) FROM Transacciones").Rows[0][0]);
        }

        public void RollBackTransaccion(int idTransaccion)
        {
            EntitieTransaccion transaccion = GetTransaccionById(idTransaccion);

            ManagerDatabase.Instance.Execute("DELETE FROM Transacciones WHERE ID_Transaccion = " + transaccion.GetIdTransaccion());

            String signo = "+";
            String stringMonto = transaccion.GetMonto().ToString().Replace(",", ".");
            if (stringMonto.Substring(0, 1) == "-")
                stringMonto = stringMonto.Substring(1);
            // Inversa
            if (transaccion.GetMonto() >= 0)
                signo = "-";

            ManagerDatabase.Instance.Execute("UPDATE Cuentas SET Balance = Balance " + signo + " " + stringMonto + " " +
                "WHERE ID_Cuenta = " + transaccion.GetIdCuenta());

            ActualizarResumenHome();
        }

        public List<EntitieTransaccion> GetTransacciones(int idTipoTransaccion, DateTime desde, DateTime hasta)
        {
            List<EntitieTransaccion> transacciones = new List<EntitieTransaccion>();
            String query = "SELECT * FROM Transacciones ";
            Boolean whereAdded = false;

            if (idTipoTransaccion > 0)
            {
                query += "WHERE ID_Tipo_Transaccion = " + idTipoTransaccion + " ";
                whereAdded = true;
            }

            if (desde != null)
            {
                if (whereAdded)
                    query += "AND Fecha_Hora >= '" + desde.ToShortDateString() + "' ";
                else
                {
                    query += "WHERE Fecha_Hora >= '" + desde.ToShortDateString() + "' ";
                    whereAdded = true;
                }
            }

            if (hasta != null)
            {
                if (whereAdded)
                    query += "AND Fecha_Hora <= '" + hasta.AddDays(1).ToShortDateString() + "' ";
                else
                {
                    query += "WHERE Fecha_Hora <= '" + hasta.AddDays(1).ToShortDateString() + "' ";
                    whereAdded = true;
                }
            }

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieTransaccion transaccion = new EntitieTransaccion(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    Convert.ToDecimal(dt.Rows[i][3]),
                    Convert.ToDateTime(dt.Rows[i][4]));

                transacciones.Add(transaccion);
            }

            return transacciones;
        }

        public Decimal GetTotalTransacciones(int idTipoTransaccion, DateTime desde, DateTime hasta)
        {
            String query = "SELECT SUM(Monto) FROM Transacciones ";
            Boolean whereAdded = false;

            if (idTipoTransaccion > 0)
            {
                query += "WHERE ID_Tipo_Transaccion = " + idTipoTransaccion + " ";
                whereAdded = true;
            }

            if (desde != null)
            {
                if (whereAdded)
                    query += "AND Fecha_Hora >= '" + desde.ToShortDateString() + "' ";
                else
                {
                    query += "WHERE Fecha_Hora >= '" + desde.ToShortDateString() + "' ";
                    whereAdded = true;
                }
            }

            if (hasta != null)
            {
                if (whereAdded)
                    query += "AND Fecha_Hora <= '" + hasta.AddDays(1).ToShortDateString() + "' ";
                else
                {
                    query += "WHERE Fecha_Hora <= '" + hasta.AddDays(1).ToShortDateString() + "' ";
                    whereAdded = true;
                }
            }

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery(query);

            if (dt.Rows.Count > 0 && !dt.Rows[0][0].ToString().Equals(String.Empty))
                return Convert.ToDecimal(dt.Rows[0][0]);
            else
                return 0;
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private EntitieTransaccion GetTransaccionById(int idTransaccion)
        {
            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Transacciones WHERE ID_Transaccion = " + idTransaccion);

            EntitieTransaccion transaccion = null;

            if (dt.Rows.Count > 0)
                transaccion = new EntitieTransaccion(
                    Convert.ToInt32(dt.Rows[0][0]),
                    Convert.ToInt32(dt.Rows[0][1]),
                    Convert.ToInt32(dt.Rows[0][2]),
                    Convert.ToDecimal(dt.Rows[0][3]),
                    Convert.ToDateTime(dt.Rows[0][4]));

            return transaccion;
        }

        private void ActualizarResumenHome()
        {
            ManagerForms.Instance.ActualizarResumenHome();
        }

    }
}