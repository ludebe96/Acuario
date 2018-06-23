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
            ManagerDB.Instance.Execute("INSERT INTO Transacciones " +
                "VALUES(" + transaccion.GetIdCuenta() + ", " + transaccion.GetIdTipoTransaccion() + ", " +
                transaccion.GetMonto().ToString().Replace(",", ".") + ", '" + transaccion.GetFechaHora().ToString() + "')");

            String signo = "";
            if (transaccion.GetMonto() >= 0)
                signo = "+";

            ManagerDB.Instance.Execute("UPDATE Cuentas SET Balance = Balance " + signo + " " + transaccion.GetMonto().ToString().Replace(",", ".") + " " + 
                "WHERE ID_Cuenta = " + transaccion.GetIdCuenta());

            return Convert.ToInt32(ManagerDB.Instance.ExecuteQuery("SELECT MAX(ID_Transaccion) FROM Transacciones").Rows[0][0]);
        }

        public void RollBackTransaccion(int idTransaccion)
        {
            EntitieTransaccion transaccion = GetTransaccionById(idTransaccion);

            ManagerDB.Instance.Execute("DELETE FROM Transacciones WHERE ID_Transaccion = " + transaccion.GetIdTransaccion());

            String signo = "+";
            String stringMonto = transaccion.GetMonto().ToString().Replace(",", ".");
            if (stringMonto.Substring(0, 1) == "-")
                stringMonto = stringMonto.Substring(1);
            // Inversa
            if (transaccion.GetMonto() >= 0)
                signo = "-";

            ManagerDB.Instance.Execute("UPDATE Cuentas SET Balance = Balance " + signo + " " + stringMonto + " " +
                "WHERE ID_Cuenta = " + transaccion.GetIdCuenta());
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private EntitieTransaccion GetTransaccionById(int idTransaccion)
        {
            DataTable dt = ManagerDB.Instance.ExecuteQuery("SELECT * FROM Transacciones WHERE ID_Transaccion = " + idTransaccion);

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

    }
}