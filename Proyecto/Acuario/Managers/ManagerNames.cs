using System;
using System.IO;

namespace Acuario.Managers
{
    public class ManagerNames
    {
        // |==============================ATRIBUTOS==============================|
        private static ManagerNames instance;
        public static ManagerNames Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerNames();

                return instance;
            }
        }

        public static String SYSTEM_NAME = "Acuario";
        public static String SYSTEM_ROOT_FOLDER = @"C:\Program Files (x86)\" + SYSTEM_NAME + @"\";
        public static String ERROR_LOGS_FILEPATH = SYSTEM_ROOT_FOLDER + "error_logs.txt";
        public static String CONFIG_FILEPATH = SYSTEM_ROOT_FOLDER + "config.txt";
        public static String DESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static String FACTURAS_PATH = SYSTEM_ROOT_FOLDER + "Facturas/";

        // |==============================CONSTRUCTORES==============================|
        private ManagerNames()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|
        public void Init()
        {
            if (!Directory.Exists(SYSTEM_ROOT_FOLDER))
                CreateDirectoriesAndFiles();
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
        private void CreateDirectoriesAndFiles()
        {
            CreateRootDirectory();

            CreateErrorLogsFile();

            CreateConfigFile();
        }

        private void CreateRootDirectory()
        {
            ManagerFiles.Instance.CrearDirectorio(SYSTEM_ROOT_FOLDER);
        }

        private void CreateErrorLogsFile()
        {
            ManagerFiles.Instance.CrearArchivo(ERROR_LOGS_FILEPATH);
        }

        private void CreateConfigFile()
        {
            ManagerFiles.Instance.CrearArchivo(CONFIG_FILEPATH);
        }
    }
}