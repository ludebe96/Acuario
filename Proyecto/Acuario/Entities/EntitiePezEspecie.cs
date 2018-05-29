using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acuario.Entities
{
    public class EntitiePezEspecie
    {
        // |==============================ATRIBUTOS==============================|

        private int idPezEspecie;
        private String nombre;


        // |==============================CONSTRUCTORES==============================|

        public EntitiePezEspecie(int idPezVariedad, String nombre)
        {
            this.idPezEspecie = idPezVariedad;
            this.nombre = nombre;
        }

        public EntitiePezEspecie(String nombre)
        {
            this.nombre = nombre;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdPezEspecie()
        {
            return idPezEspecie;
        }

        public void SetIdPezEspecie(int idPezVariedad)
        {
            this.idPezEspecie = idPezVariedad;
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
