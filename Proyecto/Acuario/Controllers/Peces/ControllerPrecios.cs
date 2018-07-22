using System;
using System.Data;

using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Controllers
{
    public class ControllerPrecios
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerPrecios instance;
        public static ControllerPrecios Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerPrecios();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerPrecios()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public int CrearPrecio(EntitiePrecio precio)
        {
            ManagerDatabase.Instance.Execute("INSERT INTO Precios(Precio_Minorista, Precio_Mayorista, Precio_Oferta, Precio_Distribuidor) " +
                "VALUES(" + precio.GetPrecioMinorista().ToString().Replace(",", ".") + ", " +
                precio.GetPrecioMayorista().ToString().Replace(",", ".") + ", " +
                precio.GetPrecioOferta().ToString().Replace(",", ".") + ", " +
                precio.GetPrecioDistribuidor().ToString().Replace(",", ".") + ")");

            return Convert.ToInt32(ManagerDatabase.Instance.ExecuteQuery("SELECT MAX(ID_Precio) FROM Precios").Rows[0][0]);
        }

        public EntitiePrecio GetPrecioById(int idPrecio)
        {
            EntitiePrecio precio = null;

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Precios WHERE ID_Precio = " + idPrecio);

            if (dt.Rows.Count > 0)
                precio = new EntitiePrecio(
                    Convert.ToInt32(dt.Rows[0][0]),
                    Convert.ToDecimal(dt.Rows[0][1]),
                    Convert.ToDecimal(dt.Rows[0][2]),
                    Convert.ToDecimal(dt.Rows[0][3]),
                    Convert.ToDecimal(dt.Rows[0][4]));

            return precio;
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

    }
}