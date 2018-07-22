using System;
using System.Collections.Generic;
using Acuario.Entities;
using Acuario.Managers;

using System.Data;

namespace Acuario.Controllers
{
    public class ControllerCompras
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerCompras instance;
        public static ControllerCompras Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerCompras();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerCompras()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |------------------------------COMPRAS------------------------------|

        public List<EntitieCompra> GetCompras(int idCompra, DateTime desde, DateTime hasta)
        {
            List<EntitieCompra> compras = new List<EntitieCompra>();

            String query = "SELECT * FROM Compras ";

            Boolean whereAdded = false;

            if (idCompra > 0)
            {
                query += "WHERE ID_Compra = " + idCompra + " ";
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
                    query += "AND Fecha_Hora <= '" + hasta.ToShortDateString() + "' ";
                else
                {
                    query += "WHERE Fecha_Hora <= '" + hasta.ToShortDateString() + "' ";
                    whereAdded = true;
                }
            }

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                query = "SELECT * FROM Compra_Items WHERE ID_Compra = " + Convert.ToInt32(dt.Rows[i][0]);
                DataTable subDt = ManagerDatabase.Instance.ExecuteQuery(query);

                List<EntitieCompraItem> items = new List<EntitieCompraItem>();

                for (int j = 0; j < subDt.Rows.Count; j++)
                    items.Add(new EntitieCompraItem(
                                Convert.ToInt32(subDt.Rows[j][0]),
                                Convert.ToInt32(subDt.Rows[j][1]),
                                Convert.ToInt32(subDt.Rows[j][2]),
                                subDt.Rows[j][3].ToString(),
                                Convert.ToInt32(subDt.Rows[j][4]),
                                Convert.ToDecimal(subDt.Rows[j][5])));

                EntitieCompra compra = new EntitieCompra(
                Convert.ToInt32(dt.Rows[i][0]),
                Convert.ToInt32(dt.Rows[i][1]),
                Convert.ToInt32(dt.Rows[i][2]),
                dt.Rows[i][3].ToString(),
                Convert.ToDecimal(dt.Rows[i][4].ToString()),
                Convert.ToDateTime(dt.Rows[i][5]),
                items);

                compras.Add(compra);
            }

            return compras;
        }

        public EntitieCompra GetCompraById(int idCompra)
        {
            EntitieCompra compra = null;

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Compras WHERE ID_Compra = " + idCompra);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    String query = "SELECT * FROM Compra_Items WHERE ID_Compra = " + Convert.ToInt32(dt.Rows[i][0]);
                    DataTable subDt = ManagerDatabase.Instance.ExecuteQuery(query);

                    List<EntitieCompraItem> items = new List<EntitieCompraItem>();

                    for (int j = 0; j < subDt.Rows.Count; j++)
                        items.Add(new EntitieCompraItem(
                                    Convert.ToInt32(subDt.Rows[j][0]),
                                    Convert.ToInt32(subDt.Rows[j][1]),
                                    Convert.ToInt32(subDt.Rows[j][2]),
                                    subDt.Rows[j][3].ToString(),
                                    Convert.ToInt32(subDt.Rows[j][4]),
                                    Convert.ToDecimal(subDt.Rows[j][5])));

                    compra = new EntitieCompra(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    dt.Rows[i][3].ToString(),
                    Convert.ToDecimal(dt.Rows[i][4]),
                    Convert.ToDateTime(dt.Rows[i][5]),
                    items);
                }
            }

            return compra;
        }

        public Boolean GenerarCompra(EntitieCompra compra)
        {
            int idTransaccion = ControllerTransacciones.Instance.NuevaTransaccion(
                new EntitieTransaccion(
                    compra.GetIdCuenta(),
                    ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("EGRESO").GetIdTipoTransaccion(),
                    -compra.GetTotal()));

            String nombreCuenta = ControllerCuentas.Instance.GetCuentaById(compra.GetIdCuenta()).GetNombre();
            ManagerDatabase.Instance.Execute("INSERT INTO Compras(ID_Transaccion, ID_Cuenta, Cuenta, Total, Fecha_Hora) " +
                "VALUES(" + idTransaccion + ", " + compra.GetIdCuenta() + ", " +
                "'" + nombreCuenta + "', " + compra.GetTotal().ToString().Replace(",", ".") + ", " +
                "'" + compra.GetFechaHora().ToShortDateString() + "')");

            int idCompra = Convert.ToInt32(ManagerDatabase.Instance.ExecuteQuery("SELECT MAX(ID_Compra) from Compras").Rows[0][0]);

            for (int i = 0; i < compra.GetItems().Count; i++)
                compra.GetItems()[i].SetIdCompra(idCompra);

            GenerarItems(compra.GetItems());

            return true;
        }

        public Boolean RollbackCompra(int idCompra)
        {
            int idTransaccion = GetCompraById(idCompra).GetIdTransaccion();

            ReestablecerStock(idCompra);

            ManagerDatabase.Instance.Execute("DELETE FROM Compra_Items WHERE ID_Compra = " + idCompra);
            ManagerDatabase.Instance.Execute("DELETE FROM Compras WHERE ID_Compra = " + idCompra);

            ControllerTransacciones.Instance.RollBackTransaccion(idTransaccion);
            return false;
        }

        // |------------------------------ITEMS------------------------------|

        public Boolean GenerarItems(List<EntitieCompraItem> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                ControllerPeces.Instance.VariarStock(items[i].GetIdPez(), items[i].GetCantidad());

                ManagerDatabase.Instance.Execute("INSERT INTO Compra_Items(ID_Compra, ID_Pez, Nombre_Pez, Cantidad, Subtotal) " +
                "VALUES(" + items[i].GetIdCompra() + ", " + items[i].GetIdPez() + ", '" + items[i].GetNombrePez() + "', " +
                items[i].GetCantidad() + ", " + items[i].GetSubtotal().ToString().Replace(",", ".") + ")");
            }

            return true;
        }

        public List<EntitieCompraItem> GetItems()
        {
            List<EntitieCompraItem> items = new List<EntitieCompraItem>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Compra_Items");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieCompraItem item = new EntitieCompraItem(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    dt.Rows[i][3].ToString(),
                    Convert.ToInt32(dt.Rows[i][4]),
                    Convert.ToDecimal(dt.Rows[i][5]));

                items.Add(item);
            }

            return items;
        }

        public List<EntitieCompraItem> GetItems(int idCompra)
        {
            List<EntitieCompraItem> items = new List<EntitieCompraItem>();

            String query = "SELECT CI.* " +
               "FROM Compra_Items CI " +
               "JOIN Compras C " +
               "ON C.ID_Compra = CI.ID_Compra ";

            Boolean whereAdded = false;

            if (idCompra > 0)
            {
                query += "WHERE CI.ID_Compra = " + idCompra + " ";
                whereAdded = true;
            }

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieCompraItem item = new EntitieCompraItem(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    dt.Rows[i][3].ToString(),
                    Convert.ToInt32(dt.Rows[i][4]),
                    Convert.ToDecimal(dt.Rows[i][5]));

                items.Add(item);
            }

            return items;
        }

        public List<EntitieCompraItem> GetItemsByIdCompra(int idCompra)
        {
            List<EntitieCompraItem> items = new List<EntitieCompraItem>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Compra_Items WHERE ID_Compra = " + idCompra);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieCompraItem item = new EntitieCompraItem(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    dt.Rows[i][3].ToString(),
                    Convert.ToInt32(dt.Rows[i][4]),
                    Convert.ToDecimal(dt.Rows[i][5]));

                items.Add(item);
            }

            return items;
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void ReestablecerStock(int idCompra)
        {
            List<EntitieCompraItem> items = GetItemsByIdCompra(idCompra);

            for (int i = 0; i < items.Count; i++)
                ControllerPeces.Instance.VariarStock(items[i].GetIdPez(), -items[i].GetCantidad());
        }
    }
}
