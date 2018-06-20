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

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
