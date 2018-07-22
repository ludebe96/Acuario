using System;
using System.IO;
using System.Diagnostics;

namespace Acuario.Managers
{
    public class ManagerFiles
    {
        // |==============================ATRIBUTOS==============================|
        private static ManagerFiles instance;
        public static ManagerFiles Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerFiles();

                return instance;
            }
        }

        private StreamWriter streamWriter;

        // |==============================CONSTRUCTORES==============================|
        private ManagerFiles()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public void Init()
        {
            if (!DirectorioExistente(ManagerNames.SYSTEM_ROOT_FOLDER))
                CrearDirectorio(ManagerNames.SYSTEM_ROOT_FOLDER);

            if (!DirectorioExistente(ManagerNames.FACTURAS_PATH))
                CrearDirectorio(ManagerNames.FACTURAS_PATH);

            if (!DirectorioExistente(ManagerNames.SYSTEM_ROOT_FOLDER))
                CrearDirectorio(ManagerNames.SYSTEM_ROOT_FOLDER);


        }

        public Boolean AbrirArchivo(String fullFilePath)
        {
            try
            {
                Process.Start(fullFilePath);
                return true;
            }
            catch{
                return true;
            }
        }

        public Boolean CrearArchivo(String fullFileName)
        {
            try
            {
                File.Create(fullFileName);
                return true;
            }
            catch (Exception) { return false; }
        }

        public Boolean ArchivoExistente(String fullFileName)
        {
            try
            {
                return File.Exists(fullFileName);
            }
            catch (Exception) { return false; }
        }

        public Boolean DirectorioExistente(String fullDirectoryName)
        {
            try
            {
                return Directory.Exists(fullDirectoryName);
            }
            catch (Exception) { return false; }
        }

        public Boolean CrearDirectorio(String fullDirectoryName)
        {
            try
            {
                Directory.CreateDirectory(fullDirectoryName);
                return true;
            }
            catch (Exception) { return false; }
        }

        public Boolean EscribirArchivo(String texto, String path, Boolean append)
        {
            try
            {
                streamWriter = new StreamWriter(path, append);
                streamWriter.WriteLine(texto);
                streamWriter.Close();

                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public String LeerArchivo(String fullFileName)
        {
            try
            {
                return File.ReadAllText(fullFileName);
            }
            catch (IOException)
            {
                return "error";
            }
        }

        public void BorrarArchivo(String fullFileName)
        {
            try
            {
                File.Delete(fullFileName);
            }
            catch (IOException)
            { }
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
