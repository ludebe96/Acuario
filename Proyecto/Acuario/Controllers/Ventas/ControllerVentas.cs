using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;

using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Controllers
{
    public class ControllerVentas
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerVentas instance;
        public static ControllerVentas Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerVentas();

                return instance;
            }
        }

        private static int FACTURA_STARTING_ITEM = 21;
        private static int FACTURA_NEW_LINE_HEIGHT = 30;
        /*{ 51, 83, 114, 141, 178,
          209, 183, 200, 219, 239,
          257, 278, 296, 313, 331,
            350, 379, 398, 427, 450 };*/
        private static int[] FACTURA_POS_X = new int[] { 5, 85, 500, 602 };
        private static int CANTIDAD_MAX_WIDTH = 75;
        private static int DESCRIPCION_MAX_WIDTH = 415;
        private static int PRECIO_UNITARIO_MAX_WIDTH = 110;
        private static int SUBTOTAL_MAX_WIDTH = 150;

        private static Point CLIENTE_POS = new Point(15, 653);
        private static int CLIENTE_MAX_WIDTH = 435;
        private static Point FECHA_POS = new Point(350, 653);
        private static int FECHA_MAX_WIDTH = 170;
        private static Point TOTAL_POS = new Point(635, 653);
        private static int TOTAL_MAX_WIDTH = 95;

        public static int ITEMS_POR_FACTURA = 20;


        // |==============================CONSTRUCTORES==============================|

        private ControllerVentas()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        // |------------------------------VENTAS------------------------------|
        public List<EntitieVenta> GetVentas()
        {
            List<EntitieVenta> ventas = new List<EntitieVenta>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Ventas");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                String query = "SELECT * FROM Venta_Items WHERE ID_Venta = " + Convert.ToInt32(dt.Rows[i][0]);
                DataTable subDt = ManagerDatabase.Instance.ExecuteQuery(query);

                List<EntitieVentaItem> items = new List<EntitieVentaItem>();

                for (int j = 0; j < dt.Rows.Count; j++)
                    items.Add(new EntitieVentaItem(
                                Convert.ToInt32(dt.Rows[i][0]),
                                Convert.ToInt32(dt.Rows[i][1]),
                                Convert.ToInt32(dt.Rows[i][2]),
                                dt.Rows[i][3].ToString(),
                                Convert.ToDecimal(dt.Rows[i][4]),
                                Convert.ToInt32(dt.Rows[i][5]),
                                Convert.ToDecimal(dt.Rows[i][6])));

                EntitieVenta venta = new EntitieVenta(
                Convert.ToInt32(dt.Rows[i][0]),
                Convert.ToInt32(dt.Rows[i][1]),
                Convert.ToInt32(dt.Rows[i][2]),
                Convert.ToInt32(dt.Rows[i][3]),
                dt.Rows[i][4].ToString(),
                dt.Rows[i][5].ToString(),
                Convert.ToDecimal(dt.Rows[i][6]),
                Convert.ToDateTime(dt.Rows[i][7]),
                items);

                ventas.Add(venta);
            }

            return ventas;
        }

        public List<EntitieVenta> GetVentas(int idVenta, String cliente, DateTime desde, DateTime hasta)
        {
            List<EntitieVenta> ventas = new List<EntitieVenta>();

            String query = "SELECT * " +
                "FROM Ventas V " +
                "LEFT JOIN Clientes C ON V.ID_Cliente = C.ID_Cliente ";

            Boolean whereAdded = false;

            if (idVenta > 0)
            {
                query += "WHERE V.ID_Venta = " + idVenta + " ";
                whereAdded = true;
            }

            if (!cliente.Equals(String.Empty))
            {
                if (whereAdded)
                    query += "AND V.Cliente LIKE '%" + cliente + "%' ";
                else
                {
                    query += "WHERE V.Cliente LIKE '%" + cliente + "%' ";
                    whereAdded = true;
                }
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
                query = "SELECT * FROM Venta_Items WHERE ID_Venta = " + Convert.ToInt32(dt.Rows[i][0]);
                DataTable subDt = ManagerDatabase.Instance.ExecuteQuery(query);

                List<EntitieVentaItem> items = new List<EntitieVentaItem>();

                for (int j = 0; j < subDt.Rows.Count; j++)
                    items.Add(new EntitieVentaItem(
                                Convert.ToInt32(subDt.Rows[j][0]),
                                Convert.ToInt32(subDt.Rows[j][1]),
                                Convert.ToInt32(subDt.Rows[j][2]),
                                subDt.Rows[j][3].ToString(),
                                Convert.ToDecimal(subDt.Rows[j][4]),
                                Convert.ToInt32(subDt.Rows[j][5]),
                                Convert.ToDecimal(subDt.Rows[j][6])));

                EntitieVenta venta = new EntitieVenta(
                 Convert.ToInt32(dt.Rows[i][0]),
                 Convert.ToInt32(dt.Rows[i][1]),
                Convert.ToInt32(dt.Rows[i][2]),
                Convert.ToInt32(dt.Rows[i][3]),
                dt.Rows[i][4].ToString(),
                dt.Rows[i][5].ToString(),
                Convert.ToDecimal(dt.Rows[i][6]),
                Convert.ToDateTime(dt.Rows[i][7]),
                items);

                ventas.Add(venta);
            }

            return ventas;
        }

        public EntitieVenta GetVentaById(int idVenta)
        {
            EntitieVenta venta = null;

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Ventas WHERE ID_Venta = " + idVenta);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    String query = "SELECT * FROM Venta_Items WHERE ID_Venta = " + Convert.ToInt32(dt.Rows[i][0]);
                    DataTable subDt = ManagerDatabase.Instance.ExecuteQuery(query);

                    List<EntitieVentaItem> items = new List<EntitieVentaItem>();

                    for (int j = 0; j < subDt.Rows.Count; j++)
                        items.Add(new EntitieVentaItem(
                                    Convert.ToInt32(subDt.Rows[j][0]),
                                    Convert.ToInt32(subDt.Rows[j][1]),
                                    Convert.ToInt32(subDt.Rows[j][2]),
                                    subDt.Rows[j][3].ToString(),
                                    Convert.ToDecimal(subDt.Rows[j][4]),
                                    Convert.ToInt32(subDt.Rows[j][5]),
                                    Convert.ToDecimal(subDt.Rows[j][6])));

                    venta = new EntitieVenta(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    Convert.ToInt32(dt.Rows[i][3]),
                    dt.Rows[i][4].ToString(),
                    dt.Rows[i][5].ToString(),
                    Convert.ToDecimal(dt.Rows[i][6]),
                    Convert.ToDateTime(dt.Rows[i][7]),
                    items);
                }
            }

            return venta;
        }

        public int GenerarVenta(EntitieVenta venta)
        {
            int idTransaccion = ControllerTransacciones.Instance.NuevaTransaccion(
                new EntitieTransaccion(
                    venta.GetIdCuenta(),
                    ControllerTipoTransacciones.Instance.GetTipoTransaccionByNombre("INGRESO").GetIdTipoTransaccion(),
                    venta.GetTotal()));

            String nombreCliente = ControllerClientes.Instance.GetClienteById(venta.GetIdCliente()).GetNombre();
            String nombreCuenta = ControllerCuentas.Instance.GetCuentaById(venta.GetIdCuenta()).GetNombre();
            ManagerDatabase.Instance.Execute("INSERT INTO Ventas(ID_Transaccion, ID_Cuenta, ID_Cliente, Cuenta, Cliente, Total, Fecha_Hora) " +
                "VALUES(" + idTransaccion + ", " + venta.GetIdCuenta() + ", " + venta.GetIdCliente() + ", " +
                "'" + nombreCuenta + "', '" + nombreCliente + "', " +
                venta.GetTotal().ToString().Replace(",", ".") + ", " +
                "'" + venta.GetFechaHora().ToShortDateString() + "')");

            int idVenta = Convert.ToInt32(ManagerDatabase.Instance.ExecuteQuery("SELECT MAX(ID_Venta) from Ventas").Rows[0][0]);

            for (int i = 0; i < venta.GetItems().Count; i++)
                venta.GetItems()[i].SetIdVenta(idVenta);

            GenerarItems(venta.GetItems());
            GenerarFacturaPdf(idVenta);

            return idVenta;
        }

        public Boolean RollbackVenta(int idVenta)
        {
            int idTransaccion = GetVentaById(idVenta).GetIdTransaccion();

            ReestablecerStock(idVenta);

            ManagerDatabase.Instance.Execute("DELETE FROM Venta_Items WHERE ID_Venta = " + idVenta);
            ManagerDatabase.Instance.Execute("DELETE FROM Ventas WHERE ID_Venta = " + idVenta);

            ManagerFiles.Instance.BorrarArchivo(ManagerNames.FACTURAS_PATH + idVenta + ".JPG");

            ControllerTransacciones.Instance.RollBackTransaccion(idTransaccion);
            return false;
        }

        // |------------------------------ITEMS------------------------------|

        public List<EntitieVentaItem> GetItems()
        {
            List<EntitieVentaItem> items = new List<EntitieVentaItem>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Venta_Items");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieVentaItem item = new EntitieVentaItem(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    dt.Rows[i][3].ToString(),
                    Convert.ToDecimal(dt.Rows[i][4]),
                    Convert.ToInt32(dt.Rows[i][5]),
                    Convert.ToDecimal(dt.Rows[i][6]));

                items.Add(item);
            }

            return items;
        }

        public List<EntitieVentaItem> GetItems(int idVenta, String pez)
        {
            List<EntitieVentaItem> items = new List<EntitieVentaItem>();

            String query = "SELECT VI.* " +
               "FROM Venta_Items VI " +
               "JOIN Ventas V " +
               "ON V.ID_Venta = VI.ID_Venta " +
               "LEFT JOIN Peces P " +
               "ON VI.ID_Pez = P.ID_Pez ";

            Boolean whereAdded = false;

            if (idVenta > 0)
            {
                query += "WHERE VI.ID_Venta = " + idVenta + " ";
                whereAdded = true;
            }

            if (!pez.Equals(String.Empty))
            {
                if (whereAdded)
                    query += "AND VI.Nombre_Pez LIKE '%" + pez + "%' ";
                else
                {
                    query += "WHERE VI.Nombre_Pez LIKE '%" + pez + "%' ";
                    whereAdded = true;
                }
            }

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieVentaItem item = new EntitieVentaItem(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    dt.Rows[i][3].ToString(),
                    Convert.ToDecimal(dt.Rows[i][4]),
                    Convert.ToInt32(dt.Rows[i][5]),
                    Convert.ToDecimal(dt.Rows[i][6]));

                items.Add(item);
            }

            return items;
        }

        public List<EntitieVentaItem> GetItemsByIdVenta(int idVenta)
        {
            List<EntitieVentaItem> items = new List<EntitieVentaItem>();

            DataTable dt = ManagerDatabase.Instance.ExecuteQuery("SELECT * FROM Venta_Items WHERE ID_Venta = " + idVenta);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieVentaItem item = new EntitieVentaItem(
                    Convert.ToInt32(dt.Rows[i][0]),
                    Convert.ToInt32(dt.Rows[i][1]),
                    Convert.ToInt32(dt.Rows[i][2]),
                    dt.Rows[i][3].ToString(),
                    Convert.ToDecimal(dt.Rows[i][4]),
                    Convert.ToInt32(dt.Rows[i][5]),
                    Convert.ToDecimal(dt.Rows[i][6]));

                items.Add(item);
            }

            return items;
        }

        public Boolean GenerarItems(List<EntitieVentaItem> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                ControllerPeces.Instance.VariarStock(items[i].GetIdPez(), -items[i].GetCantidad());

                ManagerDatabase.Instance.Execute("INSERT INTO Venta_Items(ID_Venta, ID_Pez, Nombre_Pez, Monto_Unitario, Cantidad, Subtotal) " +
                "VALUES(" + items[i].GetIdVenta() + ", " + items[i].GetIdPez() + ", '" + items[i].GetNombrePez() + "', " +
                items[i].GetMontoUnitario().ToString().Replace(",", ".") + ", " + items[i].GetCantidad() + ", " +
                items[i].GetSubtotal().ToString().Replace(",", ".") + ")");
            }

            return true;
        }

        public void GenerarFacturaPdf(int idVenta)
        {
            EntitieVenta venta = GetVentaById(idVenta);

            Image factura = Properties.Resources.Factura;
            Graphics g = Graphics.FromImage(factura);

            StringFormat formatter = new StringFormat();
            formatter.LineAlignment = StringAlignment.Center;
            formatter.Alignment = StringAlignment.Near;

            //Dibuja en las coordenadas exactas los valores del DGV en la factura
            for (int i = 0; i < venta.GetItems().Count; i++)
            {
                formatter.Alignment = StringAlignment.Center;
                DrawOnGraphics(g,
                    ManagerFormats.Instance.IntToNumber(venta.GetItems()[i].GetCantidad()),
                    new Point(FACTURA_POS_X[0], FACTURA_STARTING_ITEM + (FACTURA_NEW_LINE_HEIGHT * (i+1))), CANTIDAD_MAX_WIDTH, formatter, false);

                formatter.Alignment = StringAlignment.Near;
                DrawOnGraphics(g,
                    (venta.GetItems()[i].GetNombrePez().Length > 35 ?
                    venta.GetItems()[i].GetNombrePez().Substring(0, 35) + "." :
                    venta.GetItems()[i].GetNombrePez()),
                    new Point(FACTURA_POS_X[1], FACTURA_STARTING_ITEM + (FACTURA_NEW_LINE_HEIGHT * (i + 1))), DESCRIPCION_MAX_WIDTH, formatter, false);

                formatter.Alignment = StringAlignment.Center;
                DrawOnGraphics(g,
                    ManagerFormats.Instance.DecimalToMoney(venta.GetItems()[i].GetMontoUnitario(), true),
                    new Point(FACTURA_POS_X[2], FACTURA_STARTING_ITEM + (FACTURA_NEW_LINE_HEIGHT * (i + 1))), PRECIO_UNITARIO_MAX_WIDTH, formatter, false);

                DrawOnGraphics(g,
                    ManagerFormats.Instance.DecimalToMoney(venta.GetItems()[i].GetSubtotal(), true),
                    new Point(FACTURA_POS_X[3], FACTURA_STARTING_ITEM + (FACTURA_NEW_LINE_HEIGHT * (i + 1))), SUBTOTAL_MAX_WIDTH, formatter, false);
            }

            formatter.Alignment = StringAlignment.Far;
            DrawOnGraphics(g, ManagerFormats.Instance.DecimalToMoney(venta.GetTotal(), false),
                TOTAL_POS, TOTAL_MAX_WIDTH, formatter, true);

            //Dibuja el nombre del cliente
            formatter.Alignment = StringAlignment.Near;
            DrawOnGraphics(g, "Cliente: " +
                (venta.GetCliente().Length > 29 ? venta.GetCliente().Substring(0, 29) + "." : venta.GetCliente()),
                CLIENTE_POS, CLIENTE_MAX_WIDTH, formatter, true);

            //Dibuja la fecha actual
            formatter.Alignment = StringAlignment.Far;
            DrawOnGraphics(g, "Fecha: " + DateTime.Today.ToShortDateString(), FECHA_POS, FECHA_MAX_WIDTH, formatter, true);
            factura.Save(ManagerNames.FACTURAS_PATH + idVenta + ".jpg");
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void ReestablecerStock(int idVenta)
        {
            List<EntitieVentaItem> items = GetItemsByIdVenta(idVenta);

            for (int i = 0; i < items.Count; i++)
                ControllerPeces.Instance.VariarStock(items[i].GetIdPez(), items[i].GetCantidad());
        }

        /* Método que escribe el texto en la imagen
         * de la factura
         * */
        private void DrawOnGraphics(Graphics g, String textToDraw, Point point, int maxWidth, StringFormat formatter, Boolean bold)
        {
            //Prepara variables 
            SolidBrush brush = new SolidBrush(Color.Black);
            FontStyle fontStyle = FontStyle.Regular;
            if (bold)
                fontStyle = FontStyle.Bold;

            Font font = new Font(new FontFamily("Microsoft Sans Serif"), 11.0F, fontStyle);
            float textWidth = g.MeasureString(textToDraw, font).Width;
            float textHeight = g.MeasureString(textToDraw, font).Height;
            RectangleF rect = new RectangleF(point.X, point.Y, maxWidth,
                g.MeasureString(textToDraw, font).Height);

            g.DrawString(textToDraw, font, brush, rect, formatter);
        }
    }
}
