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

        public const String SYSTEM_NAME = "Acuario";
        public const String SYSTEM_ROOT_FOLDER = @"C:\Program Files (x86)\" + SYSTEM_NAME + @"\";
        public const String ERROR_LOGS_FILEPATH = SYSTEM_ROOT_FOLDER + "error_logs.txt";
        public const String CONFIG_FILEPATH = SYSTEM_ROOT_FOLDER + "config.txt";
        public String DESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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
            Directory.CreateDirectory(SYSTEM_ROOT_FOLDER);
        }

        private void CreateErrorLogsFile()
        {
            File.Create(ERROR_LOGS_FILEPATH);
        }

        private void CreateConfigFile()
        {
            File.Create(CONFIG_FILEPATH);
        }
    }
}