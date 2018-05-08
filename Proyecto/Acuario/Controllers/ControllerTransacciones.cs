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

        public void NuevaTransaccion(EntitieTransaccion transaccion)
        {
            ManagerDB.Instance.Execute("INSERT INTO Transacciones " +
                "VALUES(" + transaccion.GetIdCuenta() + ", " + transaccion.GetIdTipoTransaccion() + ", " +
                transaccion.GetMonto().ToString().Replace(",", ".") + ", '" + transaccion.GetFechaHora().ToString() + "')");
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

    }
}