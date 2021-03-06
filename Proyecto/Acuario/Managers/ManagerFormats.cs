﻿using System;

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
                // Remuev epara trabajar sólo con números
                stringValue = stringValue.Replace("-", "");
            String returnValue = "";
            String actualesDecimales = "";

            //Chequea decimales
            if (stringValue.Contains(",") || stringValue.Contains("."))
            {
                actualesDecimales = stringValue.Substring(stringValue.IndexOf(",") + 1, stringValue.Length - stringValue.IndexOf(",") - 1);
                if (actualesDecimales.Length > 2)
                    actualesDecimales = actualesDecimales.Substring(0, 2);

                if (stringValue.Contains(","))
                    stringValue = stringValue.Substring(0, stringValue.IndexOf(","));
                else
                    stringValue = stringValue.Substring(0, stringValue.IndexOf("."));

            }
            else
                actualesDecimales = "00";

            if (actualesDecimales.Length == 1)
                actualesDecimales = "," + actualesDecimales + "0";

            else if (actualesDecimales.Length == 2)
                actualesDecimales = "," + actualesDecimales;


            // A esta altura, stringValue contiene solo a los enteros            

            // Setea separador de miles
            int contador = 0;
            for (int i = stringValue.Length; i > 0; i--)
            {
                if (contador == 3)
                {
                    stringValue = stringValue.Insert(i, ".");
                    contador = 0;
                    i++;
                }
                else
                    contador++;
            }

            // Asignaciones finales
            returnValue = stringValue + actualesDecimales;

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
            money = money.Replace("$", "");

            if (money.Contains(".") && !money.Contains(","))
                money = money.Replace(".", ",");

            return Convert.ToDecimal(money);
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

        /* 
         * Convierte un entero a un número
         * String con separador de miles
         */
        public String IntToNumber(int numero)
        {
            String stringValue = numero.ToString();

            int contador = 0;
            for (int i = stringValue.Length; i > 0; i--)
            {
                if (contador == 3)
                {
                    stringValue = stringValue.Insert(i, ".");
                    contador = 0;
                    i++;
                }
                else
                    contador++;
            }

            return stringValue;
        }

        public int NumberToInt(String stringNumber)
        {
            return Convert.ToInt32(stringNumber.Replace(".", ""));
        }

        public Boolean MailValido(String mail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}