using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acuario.Utilities
{
    public partial class FormBase : MetroFramework.Forms.MetroForm
    {
        public FormBase()
        {
            InitializeComponent();
        }

        // |==============================ATRIBUTOS==============================|

        // |==============================CONSTRUCTORES==============================|

        // |==============================METODOS Y FUNCIONES==============================|

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void RefreshGrid()
        {/*
            gridBase.Rows.Clear();
            List<EntitieBase> gastos = ControllerBase.Instance.GetGastos(GetIdCategoriaSeleccionada(),
                dateTimeDesde.Value, dateTimeHasta.Value);

            for (int i = 0; i < gastos.Count; i++)
            {
                gridGastos.Rows.Add(gastos[i].GetIdGasto(),
                    gastos[i].GetIdCategoria(),
                    gastos[i].GetIdCuenta(),
                    ControllerGastoCategorias.Instance.GetCategoriaById(gastos[i].GetIdCategoria()).GetNombre(),
                    gastos[i].GetDescripcion(),
                    ManagerFormats.Instance.DecimalToMoney(gastos[i].GetMonto(), true),
                    gastos[i].GetFechaHora().ToString());
            }
            */
        }

        // |==============================EVENTOS==============================|
    }
}
