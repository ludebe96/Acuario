using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acuario.Entities
{
    public class EntitiePezTamaño
    {
        // |==============================ATRIBUTOS==============================|

        private int idTamaño;
        private String descripcion;

        // |==============================CONSTRUCTORES==============================|

        public EntitiePezTamaño(int idTamaño, String descripcion)
        {
            this.idTamaño = idTamaño;
            this.descripcion = descripcion;
        }

        public EntitiePezTamaño(String descripcion)
        {
            this.descripcion = descripcion;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdTamaño()
        {
            return idTamaño;
        }

        public void SetIdTamaño(int idTamaño)
        {
            this.idTamaño = idTamaño;
        }

        public String GetDescripcion()
        {
            return descripcion;
        }

        public void SetDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}
