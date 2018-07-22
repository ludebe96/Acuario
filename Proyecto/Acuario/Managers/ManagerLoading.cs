using System;
using System.ComponentModel;
using System.Reflection;

namespace Acuario.Managers
{
    public class ManagerLoading // Singleton
    {
        // |===============ATRIBUTOS===============|
        private static ManagerLoading instance;
        public static ManagerLoading Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerLoading();

                return instance;
            }
        }
        private BackgroundWorker bgWorker;

        private Type methodTypeOwner;
        private Object methodObjectOwner;
        private String methodNameOnBegin;
        private String methodNameOnEnd;
        private object[] parameters;

        // |===============CONSTRUCTORES===============|
        private ManagerLoading()
        {

        }

        // |===============MÉTODOS PÚBLICOS===============|

        public void EjecutarEnSegundoPlano(Object obj, String methodNameOnBegin, String methodNameOnEnd,
            Boolean mostrarCarga, params object[] parameters)
        {
            this.methodTypeOwner = obj.GetType();
            this.methodObjectOwner = obj;
            this.methodNameOnBegin = methodNameOnBegin;
            this.methodNameOnEnd = methodNameOnEnd;
            this.parameters = parameters;

            bgWorker = new BackgroundWorker();
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.WorkerSupportsCancellation = false;
            bgWorker.RunWorkerAsync();
        }

        // |===============MÉTODOS PRIVADOS===============|

        // |===============EVENTOS===============|

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Leído por el thread bgWorker
            MethodInfo methodInfo = this.methodTypeOwner.GetMethod(methodNameOnBegin);
            methodInfo.Invoke(methodObjectOwner, parameters);

            System.Threading.Thread.Sleep(2000);
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Leído por el thread UI
            ManagerMessages.Instance.NewInformationMessage(new System.Windows.Forms.Form(), "bgWorker ended!");

            // Ejecuta el método de retorno con el thread principal
            MethodInfo methodInfo = this.methodTypeOwner.GetMethod(methodNameOnEnd);
            methodInfo.Invoke(methodObjectOwner, parameters);
        }
    }
}
