using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acuario.Entities
{
    public class EntitieVenta
    {
        // |==============================ATRIBUTOS==============================|

        public int idVenta;
        public int idTransaccion;
        public int idCuenta;
        public int idCliente;
        public String cuenta;
        public String cliente;
        public Decimal total;
        public DateTime fechaHora;
        public List<EntitieVentaItem> items;

        // |==============================CONSTRUCTORES==============================|

        public EntitieVenta(int idVenta, int idTransaccion, int idCuenta, int idCliente, String cuenta,
            String cliente, Decimal total, DateTime fechaHora, List<EntitieVentaItem> items)
        {
            this.idVenta = idVenta;
            this.idTransaccion = idTransaccion;
            this.idCuenta = idCuenta;
            this.idCliente = idCliente;
            this.cuenta = cuenta;
            this.cliente = cliente;
            this.total = total;
            this.fechaHora = fechaHora;
            this.items = items;
        }

        public EntitieVenta(int idCuenta, int idCliente, String cuenta,
            String cliente, Decimal total, DateTime fechaHora, List<EntitieVentaItem> items)
        {
            this.idCuenta = idCuenta;
            this.idCliente = idCliente;
            this.cuenta = cuenta;
            this.cliente = cliente;
            this.total = total;
            this.fechaHora = fechaHora;
            this.items = items;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdVenta()
        {
            return idVenta;
        }

        public void SetIdVenta(int idVenta)
        {
            this.idVenta = idVenta;
        }

        public int GetIdTransaccion()
        {
            return idTransaccion;
        }

        public void SetIdTransaccion(int idTransaccion)
        {
            this.idTransaccion = idTransaccion;
        }

        public int GetIdCliente()
        {
            return idCliente;
        }

        public void SetIdCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }

        public int GetIdCuenta()
        {
            return idCuenta;
        }

        public void SetIdCuenta(int idCuenta)
        {
            this.idCuenta = idCuenta;
        }

        public Decimal GetTotal()
        {
            return total;
        }

        public void SetTotal(Decimal total)
        {
            this.total = total;
        }

        public String GetCuenta()
        {
            return cuenta;
        }

        public void SetCuenta(String cuenta)
        {
            this.cuenta = cuenta;
        }

        public String GetCliente()
        {
            return cliente;
        }

        public void SetCliente(String cliente)
        {
            this.cliente = cliente;
        }

        public DateTime GetFechaHora()
        {
            return fechaHora;
        }

        public void SetFechaHora(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
        }

        public List<EntitieVentaItem> GetItems()
        {
            return items;
        }

        public void SetItems(List<EntitieVentaItem> items)
        {
            this.items = items;
        }
    }
}
