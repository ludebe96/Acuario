using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Acuario.Managers
{
    public class ManagerFormats
    {
        // |==============================ATRIBUTOS==============================|
        static ManagerFormats instance;
        public static ManagerFormats Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerFormats();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        ManagerFormats()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public String DecimalToMoney(Decimal value, Boolean moneySign)
        {
            String stringValue = value.ToString();
            Boolean esNegativo = value < 0;
            if (esNegativo)
                stringValue = stringValue.Replace("-", "");
            String returnValue = "";
            String actualesDecimales = "";


            int cantDecimales = -1;

            // Chequea decimales
            if (stringValue.Contains(","))
                actualesDecimales = stringValue.Substring(stringValue.IndexOf(",") + 1, stringValue.Length - stringValue.IndexOf(",") - 1);
            else
                actualesDecimales = ",00";

            if (actualesDecimales.Length == 1)
            {
                cantDecimales = 2;
                actualesDecimales = "," + actualesDecimales + "0";
            }
            else if (actualesDecimales.Length == 2)
            {
                actualesDecimales = "," + actualesDecimales;
                cantDecimales = 3;
            }
            else
                cantDecimales = 0;

            // Prepara enteros según cantidad de decimales
            String enterosActuales = stringValue.Substring(0, stringValue.Length - cantDecimales);

            // Setea separador de miles
            int contador = 0;
            for (int i = enterosActuales.Length; i > 0; i--)
            {
                if (contador == 3)
                {
                    enterosActuales = enterosActuales.Insert(i, ".");
                    contador = 0;
                    i++;
                }
                else
                    contador++;
            }

            // Asignaciones finales
            returnValue = enterosActuales + actualesDecimales;

            if (moneySign)
            {
                if (value < 0)
                    returnValue = "-$" + returnValue;
                else
                    returnValue = "$" + returnValue;
            }


            return returnValue;
        }

        public Decimal MoneyToDecimal(String money)
        {
            return Convert.ToDecimal(money.Replace("$", ""));
        }

        public String StringToMoney(String monto)
        {
            return DecimalToMoney(MoneyToDecimal(monto), true);
        }
        
        public Boolean MontoValido(String monto)
        {
            decimal num;
            return decimal.TryParse(monto, out num);
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
