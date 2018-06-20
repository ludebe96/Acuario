using System;
using System.IO;

namespace Acuario.Managers
{
    public class ManagerLogs
    {
        // |==============================ATRIBUTOS==============================|
        private static ManagerLogs instance;
        public static ManagerLogs Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerLogs();

                return instance;
            }
        }

        private StreamWriter streamWriter;

        // |==============================CONSTRUCTORES==============================|
        private ManagerLogs()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public void EscribirLog(String log)
        {
            String texto = "[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "]" + log;
            if (!ManagerFiles.Instance.EscribirArchivo(texto, ManagerNames.ERROR_LOGS_FILEPATH, true))
            {
                ManagerFiles.Instance.EscribirArchivo(texto, ManagerNames.DESKTOP_PATH + "\\error_logs.txt", true);
                ManagerMessages.Instance.NewErrorMessage(null, "No se pudo escribir el log correctamente.\nSe generó el error_log en el escritorio.");
            }
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
