using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acuario.Entities
{
    public class EntitiePrecio
    {
        // |==============================ATRIBUTOS==============================|

        private int idPrecio;
        private Decimal precioMinorista;
        private Decimal precioMayorista;
        private Decimal precioOferta;
        private Decimal precioDistribuidor;

        // |==============================CONSTRUCTORES==============================|

        public EntitiePrecio(int idPrecio, Decimal precioMinorista, Decimal precioMayorista,
            Decimal precioOferta, Decimal precioDistribuidor)
        {
            this.idPrecio = idPrecio;
            this.precioMinorista = precioMinorista;
            this.precioMayorista = precioMayorista;
            this.precioOferta = precioOferta;
            this.precioDistribuidor = precioDistribuidor;
        }

        public EntitiePrecio(Decimal precioMinorista, Decimal precioMayorista,
            Decimal precioOferta, Decimal precioDistribuidor)
        {
            this.precioMinorista = precioMinorista;
            this.precioMayorista = precioMayorista;
            this.precioOferta = precioOferta;
            this.precioDistribuidor = precioDistribuidor;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdPrecio()
        {
            return idPrecio;
        }

        public void SetIdPrecio(int idPrecio)
        {
            this.idPrecio = idPrecio;
        }

        public Decimal GetPrecioMinorista()
        {
            return precioMinorista;
        }

        public void SetPrecioMinorista(Decimal precioMinorista)
        {
            this.precioMinorista = precioMinorista;
        }

        public Decimal GetPrecioMayorista()
        {
            return precioMayorista;
        }

        public void SetPrecioMayorista(Decimal precioMayorista)
        {
            this.precioMayorista = precioMayorista;
        }

        public Decimal GetPrecioOferta()
        {
            return precioOferta;
        }

        public void SetPrecioOferta(Decimal precioOferta)
        {
            this.precioOferta = precioOferta;
        }

        public Decimal GetPrecioDistribuidor()
        {
            return precioDistribuidor;
        }

        public void SetPrecioDistribuidor(Decimal precioDistribuidor)
        {
            this.precioDistribuidor = precioDistribuidor;
        }
    }
}
