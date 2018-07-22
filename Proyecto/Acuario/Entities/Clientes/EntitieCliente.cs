using System;

namespace Acuario.Entities
{
    public class EntitieCliente
    {
        // |==============================ATRIBUTOS==============================|

        private int idCliente;
        private String nombre;
        private String cuit;
        private String mail;
        private String telefono1;
        private String telefono2;
        private String telefono3;

        // |==============================CONSTRUCTORES==============================|

        public EntitieCliente(int idCliente, String nombre, String cuit,
            String mail, String telefono1, String telefono2, String telefono3)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.cuit = cuit;
            this.mail = mail;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.telefono3 = telefono3;
        }

        public EntitieCliente(String nombre, String cuit,
            String mail, String telefono1, String telefono2, String telefono3)
        {
            this.nombre = nombre;
            this.cuit = cuit;
            this.mail = mail;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.telefono3 = telefono3;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdCliente()
        {
            return idCliente;
        }

        public void SetIdCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }

        public String GetNombre()
        {
            return nombre;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String GetCuit()
        {
            return cuit;
        }

        public void SetCuit(String cuit)
        {
            this.cuit = cuit;
        }

        public String GetMail()
        {
            return mail;
        }

        public void SetMail(String mail)
        {
            this.mail = mail;
        }

        public String GetTelefono1()
        {
            return telefono1;
        }

        public void SetTelefono1(String telefono1)
        {
            this.telefono1 = telefono1;
        }

        public String GetTelefono2()
        {
            return telefono2;
        }

        public void SetTelefono2(String telefono2)
        {
            this.telefono2 = telefono2;
        }

        public String GetTelefono3()
        {
            return telefono3;
        }

        public void SetTelefono3(String telefono3)
        {
            this.telefono3 = telefono3;
        }
    }
}
