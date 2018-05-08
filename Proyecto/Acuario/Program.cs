using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            ManagerDB.Instance.Init();

            FormHome form = new FormHome();
            ManagerForms.Instance.Init(form);

            Application.Run(form);
        }
    }
}
