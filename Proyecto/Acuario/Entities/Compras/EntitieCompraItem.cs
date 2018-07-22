using System;

namespace Acuario.Entities
{
    public class EntitieCompraItem
    {
        // |==============================ATRIBUTOS==============================|

        private int idCompraItem;
        private int idCompra;
        private int idPez;
        private String nombrePez;
        private int cantidad;
        private Decimal subtotal;

        // |==============================CONSTRUCTORES==============================|

        public EntitieCompraItem(int idCompraItem, int idCompra, int idPez, String nombrePez, int cantidad, Decimal subtotal)
        {
            this.idCompraItem = idCompraItem;
            this.idCompra = idCompra;
            this.idPez = idPez;
            this.nombrePez = nombrePez;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        public EntitieCompraItem(int idCompra, int idPez, String nombrePez, int cantidad, Decimal subtotal)
        {
            this.idCompra = idCompra;
            this.idPez = idPez;
            this.nombrePez = nombrePez;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdCompraItem()
        {
            return idCompraItem;
        }

        public void SetIdCompraItem(int idCompraItem)
        {
            this.idCompraItem = idCompraItem;
        }

        public int GetIdCompra()
        {
            return idCompra;
        }

        public void SetIdCompra(int idCompra)
        {
            this.idCompra = idCompra;
        }

        public int GetIdPez()
        {
            return idPez;
        }

        public void SetIdPez(int idPez)
        {
            this.idPez = idPez;
        }

        public String GetNombrePez()
        {
            return nombrePez;
        }

        public void SetNombrePez(String nombrePez)
        {
            this.nombrePez = nombrePez;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public Decimal GetSubtotal()
        {
            return subtotal;
        }

        public void SetSubtotal(Decimal subtotal)
        {
            this.subtotal = subtotal;
        }
    }
}
