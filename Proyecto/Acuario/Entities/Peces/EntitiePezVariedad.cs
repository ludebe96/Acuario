using System;

using Acuario.Controllers;

namespace Acuario.Entities
{
    public class EntitiePezVariedad
    {
        // |==============================ATRIBUTOS==============================|

        private int idPezVariedad;
        private int idPezEspecie;
        private String nombre;
        private Boolean esDefault;


        // |==============================CONSTRUCTORES==============================|

        public EntitiePezVariedad(int idPezVariedad, int idPezEspecie, String nombre, Boolean esDefault)
        {
            this.idPezVariedad = idPezVariedad;
            this.idPezEspecie = idPezEspecie;
            this.nombre = nombre;
            this.esDefault = esDefault;
        }

        public EntitiePezVariedad(int idPezEspecie, String nombre, Boolean esDefault)
        {
            this.idPezEspecie = idPezEspecie;
            this.nombre = nombre;
            this.esDefault = esDefault;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdPezVariedad()
        {
            return idPezVariedad;
        }

        public void SetIdPezVariedad(int idPezVariedad)
        {
            this.idPezVariedad = idPezVariedad;
        }

        public int GetIdPezEspecie()
        {
            return idPezEspecie;
        }

        public void SdPezEspecie(int idPezEspecie)
        {
            this.idPezEspecie = idPezEspecie;
        }

        public String GetNombre()
        {
            return nombre;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public Boolean EsDefault()
        {
            return esDefault;
        }

        public void SetEsDefault(Boolean esDefault)
        {
            this.esDefault = esDefault;
        }

        // |==============================METODOS==============================|

        public EntitiePezEspecie GetEspecie()
        {
            return ControllerPeces.Instance.GetEspecieById(idPezEspecie);
        }
    }
}
