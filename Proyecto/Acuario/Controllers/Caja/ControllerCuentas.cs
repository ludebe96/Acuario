using System;

using System.Collections.Generic;
using System.Data;

using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Controllers
{
    public class ControllerCuentas
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerCuentas instance;
        public static ControllerCuentas Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerCuentas();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerCuentas()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public List<EntitieCuenta> GetCuentas(Boolean traerAhorros)
        {
            List<EntitieCuenta> cuentas = new List<EntitieCuenta>();
            String query = "";

            if (traerAhorros)
                query += "SELECT * FROM Cuentas";
            else
                query += "SELECT * FROM Cuentas WHERE Nombre != 'AHORROS'";

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieCuenta cuenta = new EntitieCuenta(
                    Convert.ToInt32(dt.Rows[i][0]),
                    dt.Rows[i][1].ToString(),
                    Convert.ToDecimal(dt.Rows[i][2]));

                cuentas.Add(cuenta);
            }

            return cuentas;
        }

        public void AjustarBalance(int idCuenta, decimal balance)
        {
            /* El ajuste se realliza con la misma transacción, sin
               necesidad de hacerlo manualmente */
            EntitieCuenta cuenta = GetCuentaById(idCuenta);
            EntitieTipoTransaccion tipoTransaccion = ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("AJUSTE");
            EntitieTransaccion transaccion = new EntitieTransaccion(idCuenta, tipoTransaccion.GetIdTipoTransaccion(), balance - cuenta.GetBalance());
            ControllerTransacciones.Instance.NuevaTransaccion(transaccion);
        }

        public void Transferir(EntitieCuenta cuentaA, EntitieCuenta cuentaB, decimal monto)
        {
            EntitieTipoTransaccion tipoTransaccion = ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("TRANSFERENCIA");

            // Descuenta el balance de la cuenta A
            EntitieTransaccion transaccion = new EntitieTransaccion(cuentaA.GetIdCuenta(), tipoTransaccion.GetIdTipoTransaccion(), -monto);
            ControllerTransacciones.Instance.NuevaTransaccion(transaccion);

            // Aumenta el balance de la cuenta B
            transaccion = new EntitieTransaccion(cuentaB.GetIdCuenta(), tipoTransaccion.GetIdTipoTransaccion(), monto);
            ControllerTransacciones.Instance.NuevaTransaccion(transaccion);
        }

        public EntitieCuenta GetCuentaById(int idCuenta)
        {
            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Cuentas WHERE ID_Cuenta = " + idCuenta);

            return new EntitieCuenta(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString(), Convert.ToDecimal(dt.Rows[0][2]));
        }

        public EntitieCuenta GetCuentaByNombre(String nombre)
        {
            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Cuentas WHERE Nombre = '" + nombre.ToUpper() + "'");

            return new EntitieCuenta(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString(), Convert.ToDecimal(dt.Rows[0][2]));
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

    }
}