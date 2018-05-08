using System;

using System.Collections.Generic;
using System.Data;

using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Controllers
{
    public class ControllerTipoTransacciones
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerTipoTransacciones instance;
        public static ControllerTipoTransacciones Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerTipoTransacciones();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerTipoTransacciones()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public EntitieTipoTransaccion GetTipoTransaccionByNombre(String nombre)
        {
            DataTable dt = ManagerDB.Instance.ExecuteQuery("SELECT * FROM Tipo_Transacciones WHERE Nombre = '" + nombre.ToUpper() + "'");


            return new EntitieTipoTransaccion(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString());
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

    }
}