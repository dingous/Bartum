using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BarTum.Windows.Modulos.Login;
using System.Globalization;

namespace BarTum.Windows
{

   
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static frmMain main;
        public static frmSplashScreen frmSplashScreen;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.CurrentCulture = new CultureInfo("pt-BR");
   




            //main = new frmMain();
            frmSplashScreen = new frmSplashScreen();
            Application.Run(frmSplashScreen);
            //Application.Run(new frmLogin());


            
            //hanlde os erros da aplicação
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);


            

        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception.Message != "")
            {
                MessageBox.Show(e.Exception.Message);
            }

            if(e.Exception.InnerException.Message != "")
            {
                MessageBox.Show(e.Exception.InnerException.Message);
            }

        }
    }
}
