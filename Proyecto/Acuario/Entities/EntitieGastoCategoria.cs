using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acuario.Entities
{
    public class EntitieGastoCategoria
    {
        // |==============================ATRIBUTOS==============================|

        private int idGastoCategoria;
        private String nombre;

        // |==============================CONSTRUCTORES==============================|

        public EntitieGastoCategoria(int idGastoCategoria, String nombre)
        {
            this.idGastoCategoria = idGastoCategoria;
            this.nombre = nombre;
        }

        public EntitieGastoCategoria(String nombre)
        {
            this.nombre = nombre;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdCuenta()
        {
            return idGastoCategoria;
        }

        public void SetIdCuenta(int idGastoCategoria)
        {
            this.idGastoCategoria = idGastoCategoria;
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
