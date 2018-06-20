using System;

namespace Acuario.Managers
{
    public class ManagerExceptions
    {
        // |==============================ATRIBUTOS==============================|
        private static ManagerExceptions instance;
        public static ManagerExceptions Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerExceptions();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|
        private ManagerExceptions()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public void CatchException(Exception e)
        {
            ManagerLogs.Instance.EscribirLog(e.ToString());
        }

        public void CatchException(Exception e, String userMessage)
        {
            ManagerLogs.Instance.EscribirLog(e.ToString());
            ManagerMessages.Instance.NewErrorMessage(null, userMessage);
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
