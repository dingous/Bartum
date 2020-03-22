using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Windows.Modulos.Configuracoes;
using System.Threading;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Web;
using System.Deployment.Application;
using System.Collections;
using System.IO;
using System.Reflection;


namespace BarTum.Windows
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }


        public static NameValueCollection GetQueryStringParameters()
        {
            NameValueCollection col = new NameValueCollection();
            try
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    string queryString = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;
                    //col = HttpUtility.ParseQueryString(queryString);

                    MessageBox.Show("Parametros: " + queryString);
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show("Parametros: " + msg.Message);

            }

            return col;
        }

        public void MataInstanciasAbertas()
        {
            var current = Process.GetCurrentProcess();
            foreach (Process processo in Process.GetProcessesByName(current.ProcessName))
            {
                if (processo.Id != current.Id)
                {
                    processo.Kill();
                }

            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            
            MataInstanciasAbertas();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);

            this.BeginInvoke((MethodInvoker)delegate
          {


              frmInstalacao frm = new frmInstalacao();

              frm.BringToFront();
              frm.Visible = false;
              //frm.TopMost = true;
              frm.Show();
              frm.Hide();
              this.Hide();

          });

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Program.main = new frmMain();
            //Program.main.Show();
            //this.Hide();
        }

    }
}
