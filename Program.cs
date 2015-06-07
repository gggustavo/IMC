using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IMC
{
    static class Program
    {
       
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            container.CreateInstance();
            Application.Run(container.GetContainer().GetInstance<Principal>());
        }



    }
}
