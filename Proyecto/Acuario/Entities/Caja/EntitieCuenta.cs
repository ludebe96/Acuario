using System;

namespace Acuario.Entities
{
    public class EntitieCuenta
    {
        // |==============================ATRIBUTOS==============================|

        private int idCuenta;
        private String nombre;
        private Decimal balance;

        // |==============================CONSTRUCTORES==============================|

        public EntitieCuenta(int idCuenta, String nombre, Decimal balance)
        {
            this.idCuenta = idCuenta;
            this.nombre = nombre;
            this.balance = balance;
        }

        public EntitieCuenta(String nombre, Decimal balance)
        {
            this.nombre = nombre;
            this.balance = balance;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdCuenta()
        {
            return idCuenta;
        }

        public void SetIdCuenta(int idCuenta)
        {
            this.idCuenta = idCuenta;
        }

        public String GetNombre()
        {
            return nombre;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public Decimal GetBalance()
        {
            return balance;
        }

        public void SetBalance(Decimal balance)
        {
            this.balance = balance;
        }
    }
}
