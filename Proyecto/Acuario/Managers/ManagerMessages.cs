using System;
using System.Windows.Forms;

using MetroFramework;

namespace Acuario.Managers
{
    public class ManagerMessages
    {
        // |==============================ATRIBUTOS==============================|
        private static ManagerMessages instance;
        public static ManagerMessages Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerMessages();

                return instance;
            }
        }
        private String[] titulos;

        // |==============================CONSTRUCTORES==============================|
        private ManagerMessages()
        {
            titulos = new String[] { "Información", "Confirmación", "ADVERTENCIA" };
        }

        // |==============================METODOS Y FUNCIONES==============================|
        public void NewInformationMessage(Form form, String message)
        {
            MetroMessageBox.Show(form, message, titulos[1], MessageBoxButtons.OK);
        }

        public Boolean NewConfirmMessage(Form form, String message)
        {
            if (MetroFramework.MetroMessageBox.Show(form, message, titulos[1], MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public void NewErrorMessage(Form form, String message)
        {
            MetroFramework.MetroMessageBox.Show(form, message + "\n\nPorfavor, contacte al Programador.", titulos[2]);
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
