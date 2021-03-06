﻿using System;

using Acuario.Controllers;

namespace Acuario.Entities
{
    public class EntitiePez
    {
        // |==============================ATRIBUTOS==============================|

        private int idPez;
        private int idVariedad;
        private int idTamaño;
        private int idPrecio;
        private String nombre;
        private int stock;
        private Boolean proveedor;


        // |==============================CONSTRUCTORES==============================|

        public EntitiePez(int idPez, int idVariedad, int idTamaño, int idPrecio, String nombre, int stock, Boolean proveedor)
        {
            this.idPez = idPez;
            this.idVariedad = idVariedad;
            this.idTamaño = idTamaño;
            this.idPrecio = idPrecio;
            this.nombre = nombre;
            this.stock = stock;
            this.proveedor = proveedor;
        }

        public EntitiePez(int idVariedad, int idTamaño, int idPrecio, String nombre, int stock, Boolean proveedor)
        {
            this.idVariedad = idVariedad;
            this.idTamaño = idTamaño;
            this.idPrecio = idPrecio;
            this.nombre = nombre;
            this.stock = stock;
            this.proveedor = proveedor;
        }

        // |==============================GETTERS & SETTERS==============================|

        public int GetIdPez()
        {
            return idPez;
        }

        public void SetIdPez(int idPez)
        {
            this.idPez = idPez;
        }

        public int GetIdVariedad()
        {
            return idVariedad;
        }

        public void SetIdVariedad(int idVariedad)
        {
            this.idVariedad = idVariedad;
        }

        public int GetIdTamaño()
        {
            return idTamaño;
        }

        public void SetIdTamaño(int idTamaño)
        {
            this.idTamaño = idTamaño;
        }

        public int GetIdPrecio()
        {
            return idPrecio;
        }

        public void SetIdPrecio(int idPrecio)
        {
            this.idPrecio = idPrecio;
        }

        public String GetNombre()
        {
            return nombre;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public int GetStock()
        {
            return stock;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
        }

        public Boolean EsProveedor()
        {
            return proveedor;
        }

        public void SetProvedor(Boolean proveedor)
        {
            this.proveedor = proveedor;
        }

        // |==============================MÉTODOS==============================|

        public EntitiePezVariedad GetVariedad()
        {
            return ControllerPeces.Instance.GetVariedadById(idVariedad);
        }

        public EntitiePrecio GetPrecio()
        {
            return ControllerPrecios.Instance.GetPrecioById(idPrecio);
        }
    }
}
