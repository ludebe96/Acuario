using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Acuario.Managers
{
    public class ManagerForms
    {
        // |==============================ATRIBUTOS==============================|
        static ManagerForms instance;
        public static ManagerForms Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerForms();

                return instance;
            }
        }
        public List<Form> Forms;

        private delegate int FormDelegate();


        // |==============================CONSTRUCTORES==============================|

        ManagerForms()
        {
            Forms = new List<Form>();
        }

        // |==============================METODOS Y FUNCIONES==============================|

        public Boolean Init(Form form)
        {
            Forms.Add(form);
            return true;
        }

        /* Es llamado al momento de necesitar mostrar
         * un nuevo form.
         * Crea con Activator, agrega a la lista de forms 
         * y bloquea/oculta/nada el form anterior.
         * */
        public Form NewForm(String FormName, Boolean disabled, Boolean invisible, params object[] parameters)
        {
            int indexOfFormAlreadyShowing = -1;

            if ((indexOfFormAlreadyShowing = CheckIfFormAlreadyShowing(FormName)) == -1)
            {
                try
                {
                    Form form = (Form)Activator.CreateInstance(Type.GetType("Acuario.Forms." + FormName), parameters);
                    Forms.Add(form);

                    if (Forms.Count >= 2)
                    {
                        Forms[Forms.Count - 2].Enabled = !disabled;
                        Forms[Forms.Count - 2].Visible = !invisible;
                    }

                    Forms[Forms.Count - 1].Show();
                    Forms[Forms.Count - 1].BringToFront();

                    return form;
                }
                catch (Exception e)
                {
                    ManagerExceptions.Instance.CatchException(e, "Error al mostrar una nueva ventana.");
                    return null;
                }
            }

            // El form ya existe, traerlo para adelante
            else
            {
                Forms[indexOfFormAlreadyShowing].BringToFront();
                return null;
            }
        }

        /* Quita de la lista el form removido
         * y desbloquea el último form para su uso.
         * */
        public void PrevForm()
        {
            Forms.RemoveAt(Forms.Count - 1);
            Forms[Forms.Count - 1].Enabled = true;
            Forms[Forms.Count - 1].Visible = true;
            Forms[Forms.Count - 1].BringToFront();
        }

        public Form ActualForm()
        {
            return Forms[Forms.Count - 1];
        }

        public void ActualizarResumenHome()
        {
            ((Forms.FormHome)(Forms[0])).UpdateResumenGeneral();
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private int CheckIfFormAlreadyShowing(String FormName)
        {
            for (int i = 0; i < Forms.Count; i++)
            {
                if (Forms[i].Name.Equals(FormName))
                    return i;
            }

            return -1;
        }
        private dynamic GetActiveFormByName(String formTypeName)
        {
            for (int i = 0; i < Forms.Count; i++)
            {
                if (Forms[i].GetType().ToString().ToUpper().Equals(("Acuario.Forms." + formTypeName).ToUpper()))
                    return Forms[i];
            }

            return null;
        }
    }
}
