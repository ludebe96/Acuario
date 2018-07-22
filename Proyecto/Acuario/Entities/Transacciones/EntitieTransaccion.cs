using System;

namespace Acuario.Entities
{
    public class EntitieTransaccion
    {
        // |==============================ATRIBUTOS==============================|

        private int idTransaccion;
        private int idCuenta;
        private int idTipoTransaccion;
        private Decimal monto;
        private DateTime fechaHora;

        // |==============================CONSTRUCTORES==============================|

        public EntitieTransaccion(int idCuenta, int idTipoTransaccion,
            Decimal monto, DateTime fechaHora)
        {
            this.idCuenta = idCuenta;
            this.idTipoTransaccion = idTipoTransaccion;
            this.monto = monto;
            this.fechaHora = fechaHora;
        }

        public EntitieTransaccion(int idCuenta, int idTipoTransaccion,
            Decimal monto)
        {
            this.idCuenta = idCuenta;
            this.idTipoTransaccion = idTipoTransaccion;
            this.monto = monto;
            this.fechaHora = DateTime.Now;
        }

        public EntitieTransaccion(int idTransaccion, int idCuenta, int idTipoTransaccion,
            Decimal monto, DateTime fechaHora)
        {
            this.idTransaccion = idTransaccion;
            this.idCuenta = idCuenta;
            this.idTipoTransaccion = idTipoTransaccion;
            this.monto = monto;
            this.fechaHora = fechaHora;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdTransaccion()
        {
            return idTransaccion;
        }

        public void SetIdTransaccion(int idTransaccion)
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

        public int GetIdTipoTransaccion()
        {
            return idTipoTransaccion;
        }

        public void SetIdTipoTransaccion(int idTipoTransaccion)
        {
            this.idTipoTransaccion = idTipoTransaccion;
        }

        public Decimal GetMonto()
        {
            return monto;
        }

        public void SetMonto(Decimal monto)
        {
            this.monto = monto;
        }

        public DateTime GetFechaHora()
        {
            return fechaHora;
        }

        public void GetFechaHora(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
        }
    }
}
