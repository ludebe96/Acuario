using System;

namespace Acuario.Entities
{
    public class EntitieTipoTransaccion
    {
        // |==============================ATRIBUTOS==============================|

        private int idTipoTransaccion;
        private String nombre;

        // |==============================CONSTRUCTORES==============================|

        public EntitieTipoTransaccion(int idTipoTransaccion, String nombre)
        {
            this.idTipoTransaccion = idTipoTransaccion;
            this.nombre = nombre;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdTipoTransaccion()
        {
            return idTipoTransaccion;
        }

        public void SetIdTipoTransaccion(int idTipoTransaccion)
        {
            this.idTipoTransaccion = idTipoTransaccion;
        }

        public String GetNombre()
        {
            return nombre;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }
    }
}
