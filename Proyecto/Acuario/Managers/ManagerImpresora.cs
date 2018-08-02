using System;
using System.Drawing;
using System.Drawing.Printing;

namespace Acuario.Managers
{
    public class ManagerImpresora
    {
        // |==============================ATRIBUTOS==============================|
        private static ManagerImpresora instance;
        public static ManagerImpresora Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerImpresora();

                return instance;
            }
        }

        private String fullFilePath;

        // |==============================CONSTRUCTORES==============================|
        private ManagerImpresora()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public void Init()
        {
        }

        public void ImprimirArchivo(String fullFilePath)
        {
            this.fullFilePath = fullFilePath;
            PageSettings ps = new PageSettings();

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings = ps;
            pd.PrintPage += PrintPage;
            pd.Print();
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        // |==============================EVENTOS==============================|

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            Image img = Image.FromFile(fullFilePath);
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(img, loc);

            fullFilePath = "";
        }

    }
}
