
using System.Diagnostics;

namespace Acuario.Managers
{
    public class ManagerProcesos
    {
        // |==============================ATRIBUTOS==============================|
        private static ManagerProcesos instance;
        public static ManagerProcesos Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerProcesos();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|
        private ManagerProcesos()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public void IniciarCalculadora()
        {
            Process.Start("calc.exe");
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
