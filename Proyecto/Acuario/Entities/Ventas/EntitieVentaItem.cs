using System;

namespace Acuario.Entities
{
    public class EntitieVentaItem
    {
        // |==============================ATRIBUTOS==============================|
        private int idVentaItem;
        private int idVenta;
        private int idPez;
        private String nombrePez;
        private Decimal montoUnitario;
        private int cantidad;
        private Decimal subtotal;

        // |==============================CONSTRUCTORES==============================|

        public EntitieVentaItem(int idVentaItem, int idVenta, int idPez,
            String nombrePez, Decimal montoUnitario, int cantidad, Decimal total)
        {
            this.idVentaItem = idVentaItem;
            this.idVenta = idVenta;
            this.idPez = idPez;
            this.nombrePez = nombrePez;
            this.montoUnitario = montoUnitario;
            this.cantidad = cantidad;
            this.subtotal = total;
        }

        public EntitieVentaItem(int idVenta, int idPez,
            String nombrePez, Decimal montoUnitario, int cantidad)
        {
            this.idVenta = idVenta;
            this.idPez = idPez;
            this.nombrePez = nombrePez;
            this.montoUnitario = montoUnitario;
            this.cantidad = cantidad;
            this.subtotal = montoUnitario * cantidad;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdVentaItem()
        {
            return idVentaItem;
        }

        public void SetIdVentaItem(int idVentaItem)
        {
            this.idVentaItem = idVentaItem;
        }

        public int GetIdVenta()
        {
            return idVenta;
        }

        public void SetIdVenta(int idVenta)
        {
            this.idVenta = idVenta;
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

        public Decimal GetMontoUnitario()
        {
            return montoUnitario;
        }

        public void SetMontoUnitario(Decimal montoUnitario)
        {
            this.montoUnitario = montoUnitario;
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