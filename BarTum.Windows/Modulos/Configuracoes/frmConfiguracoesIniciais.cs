using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Sql;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Collections.Specialized;
using System.Deployment.Application;
using System.Web;
using System.Threading;
using System.Globalization;
using System.Net;
using System.Configuration;
using TClientSocket;
using BarTum.Entities;
using System.Data.SqlClient;

namespace BarTum.Windows.Modulos.Configuracoes
{
    public partial class frmConfiguracoesIniciais : Form
    {
        public frmMain frmMain;
        public bool InstalaInstacia = true;
        public bool RemoveIntancias = true;
        public static string DirRoot = AppDomain.CurrentDomain.BaseDirectory;
        //public SqlDataSourceEnumerator RemoteInstancias = SqlDataSourceEnumerator.Instance;  System.Data.DataTable table = instance.GetDataSources(); DisplayData(table); //Remote Instâncias
        public static string FileName = null;
       
       
        public string FileDownloaded = "SQLEXPR_x64_PTB.exe";
        WebClient webClient;               // Our WebClient that will be doing the downloading for us
        Stopwatch sw = new Stopwatch();



        


       


        void proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

            Process proc = (Process)sender;
            //proc.Kill();
            //throw new NotImplementedException();
        }

        



        public frmConfiguracoesIniciais()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {

            try
            {



                Properties.Clienteconfig.Default.tipo = (tipo1Radio.Checked == true) ? "servidor" : "cliente";
                Properties.Clienteconfig.Default.ServidorIP = textIPServidor.Text;
                Properties.Clienteconfig.Default.ServidorPorta = Convert.ToInt32(textPortaServidor.Text);
                Properties.Clienteconfig.Default.primeiro_acesso = false;
                Properties.Clienteconfig.Default.Save();









                string bancoHost = textBoxBancoHost.Text.Trim();
                string bancoUsuario = textBoxBancoUsuario.Text.Trim();
                string bancoSenha = textBoxBancoSenha.Text.Trim();
                string banco = txtBanco.Text;




                string conectionString = "metadata=res://*/BarTum.csdl|res://*/BarTum.ssdl|res://*/BarTum.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source=" + bancoHost + ";Initial Catalog=" + banco + ";User ID=" + bancoUsuario + ";Password=" + bancoSenha + ";MultipleActiveResultSets=True\"";


                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string ConnectionStrings = config.ConnectionStrings.ConnectionStrings["BarTumEntities"].ConnectionString = conectionString;
                config.Save(System.Configuration.ConfigurationSaveMode.Modified);
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");


                frmMain parent = Program.main;

                parent.IpServidor = Properties.Clienteconfig.Default.ServidorIP;
                parent.ServerPort = Properties.Clienteconfig.Default.ServidorPorta;
                parent.TipoTerminal = Properties.Clienteconfig.Default.tipo;

                MessageBox.Show("Configurações salvas com sucesso, o sistema será reiniciado!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.Close();


                /* if (this.frmMain != null)
                 {

                     if (this.frmMain.TipoTerminal == "servidor")
                     {
                         this.frmMain.servidor.Deactive();
                     }
                     else
                     {
                         this.frmMain.cliente.Disconnect();
                     }

                     this.frmMain.Dispose();
                     this.frmMain.Close();
                     Application.Exit();
                 }*/



                if (Properties.Clienteconfig.Default.tipo == "servidor")
                {
                    //instala sql server!
                }


                Application.Exit();
                Application.Restart();
                //Application.ExitThread();
                //this.frmMain.Dispose();
                //this.frmMain.Close();
                // Application.Exit();



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        

        private void frmConfiguracoesIniciais_Load(object sender, EventArgs e)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string ConnectionStrings = config.ConnectionStrings.ConnectionStrings["BarTumEntities"].ConnectionString;


            ConnectionStrings = ConnectionStrings.Replace("\"", "&quot;");

            string[] str = ConnectionStrings.Split('|');
            str = str[2].Split(';');

            string host = str[3].Replace("Data Source=", "");
            string user = str[5].Replace("User ID=", "");
            string senha = str[6].Replace("Password=", "");
            string banco = str[4].Replace("Initial Catalog=", "");



            string tipoTerminal = Properties.Clienteconfig.Default.tipo;
            string ipserver = Properties.Clienteconfig.Default.ServidorIP;
            string portaserver = Properties.Clienteconfig.Default.ServidorPorta.ToString();

            if (tipoTerminal == "servidor")
            {
                tipo1Radio.Checked = true;
                tipo2Radio.Checked = false;
            }
            else
            {
                tipo1Radio.Checked = false;
                tipo2Radio.Checked = true;
            }

            textBoxBancoHost.Text = host;
            textBoxBancoUsuario.Text = user;
            textBoxBancoSenha.Text = senha;
            txtBanco.Text = banco;
            textIPServidor.Text = ipserver;
            textPortaServidor.Text = portaserver;
        }

        void cliente_OnError(string ErroMessage, System.Net.Sockets.Socket soc, int ErroCode)
        {
            MessageBox.Show(ErroMessage);
        }


        void cliente_OnConnect(System.Net.Sockets.Socket soc)
        {

        }

        ClientSocket cliente = null;
        public void conectaCliente(string IpServidor, int ServerPort)
        {

            if (this.cliente == null || (this.cliente != null && this.cliente.Connected == false))
            {

                try
                {
                    this.cliente = new ClientSocket(IpServidor, ServerPort);
                    this.cliente.OnConnect += new ClientSocket.ConnectionDelegate(cliente_OnConnect);
                    this.cliente.Connect();


                    cliente.Disconnect();

                }
                catch (Exception error)
                {
                    throw new Exception("Erro: " + error.Message);
                }

            }


        }



        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                conectaCliente(textIPServidor.Text, Convert.ToInt32(textPortaServidor.Text));
                MessageBox.Show("Conexão com o servidor realizado com sucesso!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Houve um erro na tentativo de conectar ao servidor, possíveis causas: \n\n 1 - Verifique se o servidor está ligado. \n2 - Verifique o IP do servidor e a porta se estão corretas \n3 - Verifique se a porta está liberada no firewall do servidor.\nMensagem do servidor: \n\n" + error.Message, "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipo1Radio_Click(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked == true)
            {




                textIPServidor.ReadOnly = true;
                button1.Visible = false;
            }

        }

        private void tipo2Radio_Click(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked == true)
            {
                textIPServidor.ReadOnly = false;
                button1.Visible = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BarTumEntities context = new BarTumEntities();
            try
            {
                System.Data.EntityClient.EntityConnectionStringBuilder connStrBuild = new System.Data.EntityClient.EntityConnectionStringBuilder();
                connStrBuild.Metadata = @"res://*/BarTum.csdl|res://*/BarTum.ssdl|res://*/BarTum.msl";
                connStrBuild.Provider = @"System.Data.SqlClient";
                connStrBuild.ProviderConnectionString = @"Data Source=" + textBoxBancoHost.Text + ";Initial Catalog=" + txtBanco.Text + ";User ID=" + textBoxBancoUsuario.Text + ";Password=" + textBoxBancoSenha.Text + ";MultipleActiveResultSets=True";
                BarTumEntities contexto = new BarTumEntities(connStrBuild.ToString());
                contexto.Connection.Open();
                MessageBox.Show("Conexão com o banco de dados realizada com sucesso!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Houve um erro na tentativo de conectar ao banco de dados, verifique o host do servidor, usuário e senha. Detalhes do erro: " + error.Message, "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void button3_Click(object sender, EventArgs e)
        {

            try
            {



            }
            catch (Exception)
            {

                throw;
            }

        }


        


        

        private void button4_Click(object sender, EventArgs e)
        {

            //IniciaInstalacao();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                //RemoveInstancias();
            });

            thread.Start();

        }
    }



}
