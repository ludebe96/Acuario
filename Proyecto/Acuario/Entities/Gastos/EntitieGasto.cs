using System;

namespace Acuario.Entities
{
    public class EntitieGasto
    {
        // |==============================ATRIBUTOS==============================|

        private int idGasto;
        private int idTransaccion;
        private int idCategoria;
        private int idCuenta;
        private String descripcion;
        private Decimal monto;
        private DateTime fechaHora;

        // |==============================CONSTRUCTORES==============================|

        public EntitieGasto(int idGasto, int idTransaccion, int idCategoria, int idCuenta,
            String descripcion, Decimal monto, DateTime fechaHora)
        {
            this.idGasto = idGasto;
            this.idTransaccion = idTransaccion;
            this.idCategoria = idCategoria;
            this.idCuenta = idCuenta;
            this.descripcion = descripcion;
            this.monto = monto;
            this.fechaHora = fechaHora;
        }

        public EntitieGasto(int idCategoria, int idCuenta,
            String descripcion, Decimal monto, DateTime fechaHora)
        {
            this.idCategoria = idCategoria;
            this.idCuenta = idCuenta;
            this.descripcion = descripcion;
            this.monto = monto;
            this.fechaHora = fechaHora;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdGasto()
        {
            return idGasto;
        }

        public void SetIdGasto(int idGasto)
        {
            this.idGasto = idGasto;
        }

        public int GetIdTransaccion()
        {
            return idTransaccion;
        }

        public void SetIdTransaccion(int idTransaccion)
        {
            this.idTransaccion = idTransaccion;
        }

        public int GetIdCategoria()
        {
            return idCategoria;
        }

        public void GetIdCategoria(int idCategoria)
        {
            this.idCategoria = idCategoria;
        }

        public int GetIdCuenta()
        {
            return idCuenta;
        }

        public void SetIdCuenta(int idCuenta)
        {
            this.idCuenta = idCuenta;
        }

        public String GetDescripcion()
        {
            return descripcion;
        }

        public void SetDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }

        public decimal GetMonto()
        {
            return monto;
        }

        public void SetMonto(decimal monto)
        {
            this.monto = monto;
        }

        public DateTime GetFechaHora()
        {
            return fechaHora;
        }

        public void SetFechaHora(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
        }
    }
}
