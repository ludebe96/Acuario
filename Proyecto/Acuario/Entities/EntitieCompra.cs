using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acuario.Entities
{
    public class EntitieCompra
    {
        // |==============================ATRIBUTOS==============================|

        private int idCompra;
        private int idTransaccion;
        private int idCuenta;
        private String cuenta;
        private Decimal total;
        private DateTime fechaHora;
        private List<EntitieCompraItem> items;

        // |==============================CONSTRUCTORES==============================|

        public EntitieCompra(int idCompra, int idTransaccion, int idCuenta,
            String cuenta, Decimal total, DateTime fechaHora, List<EntitieCompraItem> items)
        {
            this.idCompra = idCompra;
            this.idTransaccion = idTransaccion;
            this.idCuenta = idCuenta;
            this.cuenta = cuenta;
            this.total = total;
            this.fechaHora = fechaHora;
            this.items = items;
        }

        public EntitieCompra(int idCuenta, String cuenta, Decimal total,
            DateTime fechaHora, List<EntitieCompraItem> items)
        {
            this.idCuenta = idCuenta;
            this.cuenta = cuenta;
            this.total = total;
            this.fechaHora = fechaHora;
            this.items = items;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdCompra()
        {
            return idCompra;
        }

        public void SetIdCompra(int idCompra)
        {
            this.idCompra = idCompra;
        }

        public int GetIdTransaccion()
        {
            return idTransaccion;
        }

        public void GetIdTransaccion(int idTransaccion)
        {
            this.idTransaccion = idTransaccion;
        }

        public int GetIdCuenta()
        {
            return idCuenta;
        }

        public void SetIdCuenta(int idCuenta)
        {
            this.idCuenta = idCuenta;
        }

        public String GetCuenta()
        {
            return cuenta;
        }

        public void SetCuenta(String cuenta)
        {
            this.cuenta = cuenta;
        }

        public Decimal GetTotal()
        {
            return total;
        }

        public void SetTotal(Decimal total)
        {
            this.total = total;
        }

        public DateTime GetFechaHora()
        {
            return fechaHora;
        }

        public void SetFechaHora(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
        }

        public List<EntitieCompraItem> GetItems()
        {
            return items;
        }

        public void SetItems(List<EntitieCompraItem> items)
        {
            this.items = items;
        }

    }
}
