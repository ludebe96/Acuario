using System;
using System.Windows.Forms;

using Acuario.Forms;
using Acuario.Managers;

namespace Acuario
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // |==============================PREVIO==============================|

            ManagerFiles.Instance.Init();
            ManagerDatabase.Instance.Init();

            // |==============================COMIENZA==============================|

            FormHome form = new FormHome();
            ManagerForms.Instance.Init(form);
            Application.Run(form);
        }
    }
}
