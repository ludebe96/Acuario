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
            try
            {
                streamWriter = new StreamWriter(ManagerNames.ERROR_LOGS_FILEPATH, true);
                streamWriter.WriteLine("[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "]" + log);
                streamWriter.Close();
            }
            catch (IOException)
            {
                streamWriter = new StreamWriter(ManagerNames.Instance.DESKTOP_PATH + "\\error_logs.txt", true);
                streamWriter.Write(log);
                streamWriter.Close();
                ManagerMessages.Instance.NewErrorMessage("No se pudo escribir el log correctamente.\nSe generó el error_log en el escritorio.");
            }
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
