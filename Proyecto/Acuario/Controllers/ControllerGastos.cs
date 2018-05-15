using System;

using System.Collections.Generic;
using System.Data;

using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Controllers
{
    public class ControllerGastos
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerGastos instance;
        public static ControllerGastos Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerGastos();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerGastos()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public List<EntitieGasto> GetGastos(int idCategoria, DateTime desde, DateTime hasta)
        {
            List<EntitieGasto> gastos = new List<EntitieGasto>();
            String query = "SELECT * FROM Gastos ";
            Boolean whereAdded = false;

            if (idCategoria > 0)
            {
                query += "WHERE ID_Gasto_Categoria = " + idCategoria + " ";
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

            DataTable dt = ManagerDB.Instance.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieGasto gasto = new EntitieGasto(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    Convert.ToInt32(dt.Rows[i][3]),
                    dt.Rows[i][4].ToString(),
                    Convert.ToDecimal(dt.Rows[i][5]),
                    Convert.ToDateTime(dt.Rows[i][6]));

                gastos.Add(gasto);
            }

            return gastos;
        }

        public void NuevoGasto(EntitieGasto gasto)
        {
            int idTransaccion = ControllerTransacciones.Instance.NuevaTransaccion(
                new EntitieTransaccion(
                    gasto.GetIdCuenta(),
                    ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("EGRESO").GetIdTipoTransaccion(),
                    gasto.GetMonto(),
                    gasto.GetFechaHora()));

            ManagerDB.Instance.Execute("INSERT INTO GASTOS(ID_Gasto_Categoria, ID_Transaccion, ID_Cuenta, Descripcion, Monto, Fecha_Hora) " +
                "VALUES(" + gasto.GetIdCategoria() + ", " + idTransaccion + ", " + gasto.GetIdCuenta() + ", " +
                "'" + gasto.GetDescripcion() + "', " + gasto.GetMonto().ToString().Replace(",", ".") + ", '" + gasto.GetFechaHora().ToString() + "')");
        }

        public void EliminarGastoById(int idGasto)
        {
            EntitieGasto gasto = GetGastoById(idGasto);
            ManagerDB.Instance.Execute("DELETE FROM Gastos WHERE ID_Gasto = " + idGasto);
            ControllerTransacciones.Instance.RollBackTransaccion(gasto.GetIdTransaccion());
        }


        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private EntitieGasto GetGastoById(int idGasto)
        {
            DataTable dt = ManagerDB.Instance.ExecuteQuery("SELECT * FROM Gastos WHERE ID_Gasto = " + idGasto);

            EntitieGasto gasto = null;

            if (dt.Rows.Count > 0)
                gasto = new EntitieGasto(
                    Convert.ToInt32(dt.Rows[0][0]),
                    Convert.ToInt32(dt.Rows[0][1]),
                    Convert.ToInt32(dt.Rows[0][2]),
                    Convert.ToInt32(dt.Rows[0][3]),
                    dt.Rows[0][4].ToString(),
                    Convert.ToDecimal(dt.Rows[0][5]),
                    Convert.ToDateTime(dt.Rows[0][6]));

            return gasto;
        }
    }
}