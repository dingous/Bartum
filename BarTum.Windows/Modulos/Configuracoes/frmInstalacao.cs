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
using System.Net;
using System.Diagnostics;
using System.IO;
using BarTum.Entities;
using System.Deployment.Application;
using System.Collections.Specialized;
using System.Web;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Data.EntityClient;
using BarTum.Utilities;
using System.Resources;
using System.Globalization;

namespace BarTum.Windows.Modulos.Configuracoes
{
    public partial class frmInstalacao : Form
    {
        Stopwatch sw = new Stopwatch();
        public string UrlDownloadSQLServer = "http://go.microsoft.com/fwlink/?LinkID=230857&amp;clcid=0x409";
        public static string DirRoot = AppDomain.CurrentDomain.BaseDirectory;
        public string FileDownloaded = "SQLEXPR_x64_PTB.exe";
        //public NameValueCollection UrlParametros = GetQueryStringParameters(); //Localhost Instâncias
        public IList<string> LocalhostInstancias = GetLocalSqlServerInstanceNames();
        bool is64 = System.Environment.Is64BitOperatingSystem;
        string pathProgramFiles;


        public frmInstalacao()
        {
            InitializeComponent();
        }


        public void MataProcessos()
        {
            Process[] foundProcesses = Process.GetProcessesByName(this.FileDownloaded);
            string strMessage = string.Empty;
            foreach (Process p in foundProcesses)
            {
                p.Kill();
            }


            Process[] foundProcesses2 = Process.GetProcessesByName("BarTum.Windows.exe");
            foreach (Process p in foundProcesses)
            {
                //pegar da tela zema

            }

        }

        private void frmInstalacao_Load(object sender, EventArgs e)
        {


            //GetQueryStringParameters();

            VerificaArquiteturaProcessador();

            MataProcessos();


            IniciaInstalacao();
        }




        public void VerificaArquiteturaProcessador()
        {
            if (is64)
            {
                UrlDownloadSQLServer = "http://go.microsoft.com/fwlink/?LinkID=230857&amp;clcid=0x409";
                FileDownloaded = "SQLEXPR_x64_PTB.exe";
                pathProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).Replace("(x86)", "").TrimEnd();
            }
            else
            {
                UrlDownloadSQLServer = "http://go.microsoft.com/fwlink/?LinkID=230856&amp;clcid=0x409";
                FileDownloaded = "SQLEXPR_x86_PTB.exe";
                pathProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            }
        }

        public static IList<string> GetLocalSqlServerInstanceNames()
        {
            RegistryValueDataReader registryValueDataReader = new RegistryValueDataReader();



            string[] instances64Bit = registryValueDataReader.ReadRegistryValueData(RegistryHive.Wow64,
                                                                                    Microsoft.Win32.Registry.LocalMachine,
                                                                                    @"SOFTWARE\Microsoft\Microsoft SQL Server",
                                                                                    "InstalledInstances");

            string[] instances32Bit = registryValueDataReader.ReadRegistryValueData(RegistryHive.Wow6432,
                                                                                    Registry.LocalMachine,
                                                                                    @"SOFTWARE\Microsoft\Microsoft SQL Server",
                                                                                    "InstalledInstances");
            IList<string> localInstanceNames = new List<string>(instances64Bit);

            localInstanceNames = localInstanceNames.Union(instances32Bit).ToList();

            return localInstanceNames;
        }

        public static NameValueCollection GetQueryStringParameters()
        {
            NameValueCollection col = new NameValueCollection();
            try
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    string queryString = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;
                    col = HttpUtility.ParseQueryString(queryString);

                    MessageBox.Show("Parametros: " + queryString);
                }
            }
            catch (Exception)
            {


            }

            return col;
        }

        public void IniciaInstalacao()
        {


            this.BeginInvoke((MethodInvoker)delegate
            {

                this.Hide();

                LocalhostInstancias = GetLocalSqlServerInstanceNames();


                if (LocalhostInstancias.Count == 0)
                {
                    this.Show();

                    lblMensagens.Text = "Banco de dados não instalado, por favor aguarde enquanto é feito o download do arquivo...";
                    Thread thread = new Thread(() =>
                    {
                        InstalarInstancia();
                    });

                    thread.Start();
                }
                else
                {


                    if (LocalhostInstancias.Where(a => a == "BARTUM").ToList().Count == 0)
                    {
                        this.Show();

                        lblMensagens.Text = "Base de dados do BARTUM não instalada, o sistema instalará automaticamente.";
                        Thread thread = new Thread(() =>
                        {
                            InstalarInstancia();
                        });

                        thread.Start();
                    }
                    else
                    {
                        this.Show();

                        try
                        {
                            using (BarTumEntities contexto = new BarTumEntities())
                            {
                                EntityConnection ec = (EntityConnection)contexto.Connection;
                                SqlConnection sc = (SqlConnection)ec.StoreConnection;
                                string db = sc.Database;
                                string adoConnStr = sc.ConnectionString.Replace("Initial Catalog=" + db + ";", "");


                                SqlConnection conn2 = new SqlConnection(adoConnStr);
                                SqlCommand cmd2 = new SqlCommand("", conn2);
                                cmd2.CommandText = "select physical_name from sys.database_files;";
                                conn2.Open();
                                DataTable oTable = new DataTable();
                                oTable.Load(cmd2.ExecuteReader());
                                cmd2.Dispose();
                                conn2.Dispose();




                                if (!contexto.DatabaseExists())
                                {

                                    lblMensagens.Text = "Servidor de banco de dados existe, mas o arquivo de banco não foi encontrado.";
                                    try
                                    {
                                        //contexto.CreateDatabase();

                                        SqlConnection conn3 = new SqlConnection(adoConnStr);
                                        SqlCommand cmd3 = new SqlCommand("", conn3);
                                        cmd3.CommandText = "CREATE DATABASE " + db + "";
                                        conn3.Open();
                                        cmd3.ExecuteNonQuery();
                                        cmd3.Dispose();
                                        conn3.Dispose();


                                        string sql = null;
                                        using (Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("BarTum.Windows.Arquivos.BARTUM_OBJETOS.sql"))
                                        using (StreamReader reader = new StreamReader(stream))
                                        {
                                            sql = reader.ReadToEnd();
                                        }

                                        Encoding isoLatin1 = Encoding.GetEncoding(28591);
                                        byte[] utfBytes = isoLatin1.GetBytes(sql);
                                        sql = isoLatin1.GetString(utfBytes, 0, utfBytes.Length);

                                        contexto.ExecuteStoreCommand(sql);


                                        sql = null;
                                        using (Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("BarTum.Windows.Arquivos.BARTUM_CARGAS.sql"))


                                        using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
                                        {
                                            sql = reader.ReadToEnd();
                                        }

                                        contexto.ExecuteStoreCommand(sql);


                                        lblMensagens.Text = "Banco instalado com sucesso, aguarde o aplicativo será reiniciado!";



                                        Application.Restart();
                                        Application.Exit();


                                    }
                                    catch (SqlException msg)
                                    {
                                        if (msg.ErrorCode == -2146232060)
                                        {
                                            lblMensagens.Text = "Banco já existente na máquina do cliente ele será anexado.";

                                            try
                                            {


                                                SqlConnection conn = new SqlConnection(adoConnStr);
                                                SqlCommand cmd = new SqlCommand("", conn);



                                                cmd.CommandText =
                                                    "CREATE DATABASE BARTUM ON " +
                                                    "PRIMARY ( FILENAME =  '" + pathProgramFiles + "\\Microsoft SQL Server\\MSSQL10_50.BARTUM\\MSSQL\\DATA\\BARTUM.mdf' ) " +
                                                    "FOR ATTACH";

                                                conn.Open();

                                                cmd.ExecuteNonQuery();

                                                cmd.Dispose();
                                                conn.Dispose();

                                                try
                                                {

                                                    string sql = null;
                                                    using (Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("BarTum.Windows.Arquivos.BARTUM_CARGAS.sql"))
                                                    using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
                                                    {
                                                        sql = reader.ReadToEnd();
                                                    }

                                                    contexto.ExecuteStoreCommand(sql);
                                                }
                                                catch (Exception)
                                                {
                                                }

                                                lblMensagens.Text = "Banco anexado com sucesso, aguarde o aplicativo será reiniciado!";


                                                Application.Restart();
                                                Application.Exit();


                                            }
                                            catch (Exception msgErr)
                                            {

                                                lblMensagens.Text = msgErr.Message;
                                            }
                                        }
                                    }
                                    catch (Exception msg)
                                    {
                                        MessageBox.Show(msg.Message, "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }


                                }
                                else
                                {


                                    //inicia o sistema normalmente

                                    this.Hide();

                                    lblMensagens.Text = "O aplicativo está pronto para ser inicializado.";

                                    Program.main = new frmMain();
                                    Program.main.Show();
                                    this.Hide();
                                    this.Close();

                                }

                            }
                        }
                        catch (Exception msg)
                        {

                            MessageBox.Show("Ocorreu um erro inesperado: " + msg.Message);
                        }
                    }
                }
            });
        }

        public void InstalarInstancia()
        {

            if (this.InvokeRequired)
                this.BeginInvoke((MethodInvoker)delegate
                {
                    this.Show();
                    this.Cursor = Cursors.WaitCursor;
                });

            LocalhostInstancias = GetLocalSqlServerInstanceNames();
            bool InstanciaExiste = LocalhostInstancias.Where(a => a == "BARTUM").ToList().Count > 0;

            using (Process proc = new Process())
            {
                if (!InstanciaExiste)
                {

                    if (File.Exists(DirRoot + @"\Arquivos\" + this.FileDownloaded))
                    {



                        proc.StartInfo.FileName = DirRoot + @"\Arquivos\" + this.FileDownloaded;
                        proc.EnableRaisingEvents = true;
                        proc.StartInfo.UseShellExecute = false;
                        proc.StartInfo.CreateNoWindow = true;
                        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        if (System.Environment.OSVersion.Version.Major >= 6)
                        {
                            proc.StartInfo.Verb = "runas";
                        }


                        if (this.InvokeRequired)
                            this.BeginInvoke((MethodInvoker)delegate
                            {
                                lblMensagens.Text = ("Iniciando a instalação da base de dados... \n");
                                pictureBoxLoading.Visible = true;
                                pictureBoxLoading.BringToFront();
                            });

                        //proc.StartInfo.Arguments = @"/ConfigurationFile=" + DirRoot + @"\Arquivos\ConfigurationFile.txt /hideconsole /features=SQL /Action=Install /enableranu=1 /skiprules=RebootRequiredCheck  /SAPWD=123";
                        proc.StartInfo.Arguments = @"/QS /ConfigurationFile=" + DirRoot + @"\Arquivos\ConfigurationFile.txt /hideconsole /features=SQL /Action=Install /enableranu=1 /IAcceptSqlServerLicenseTerms /skiprules=RebootRequiredCheck  /SAPWD=123";
                        //proc.StartInfo.Arguments = @"/Q /ConfigurationFile=" + DirRoot + @"\Arquivos\ConfigurationFile.txt /hideconsole /features=SQL /Action=Install /enableranu=1 /IAcceptSqlServerLicenseTerms /skiprules=RebootRequiredCheck  /SAPWD=123";

                        try
                        {
                            proc.Start();
                        }
                        catch (System.ComponentModel.Win32Exception msg)
                        {
                            if (msg.ErrorCode == -2147467259)
                            {
                                proc.Kill();

                                if (this.InvokeRequired)
                                    this.BeginInvoke((MethodInvoker)delegate
                                    {
                                        File.Delete(DirRoot + @"\Arquivos\" + this.FileDownloaded);
                                        lblMensagens.Text = "O Arquivo se encontra corrompido, ele será baixado novamente!";
                                        Thread.Sleep(5000);
                                        IniciaInstalacao();
                                    });

                                return;
                            }



                        }

                        if (this.InvokeRequired)
                            this.BeginInvoke((MethodInvoker)delegate
                            {
                                lblMensagens.Text = "Efetuando a instalação da base de dados, isto poderá demorar alguns minutos...";
                                pictureBoxLoading.Visible = true;
                                pictureBoxLoading.BringToFront();
                                panel1.Visible = false;
                            });

                        do
                        {

                            proc.Refresh();


                            if (this.InvokeRequired)
                                this.BeginInvoke((MethodInvoker)delegate
                                {
                                   
                                    //lblMensagens.Text = "Instalando Instância - Uso da Memória Física: " + proc.WorkingSet64.ToString() + " - Tempo: " + proc.TotalProcessorTime;
                                    //lblMensagens.Text = "Efetuando a instalação " + proc.TotalProcessorTime;
                                    lblMensagens.Text = "Por favor aguarde a instalação, isto poderá demorar alguns minutos.";
                                });


                        } while (!proc.WaitForExit(1000));




                        if (proc.ExitCode == 0)
                        {
                            //lblMensagens.Text = ("Base de dados instalado com sucesso... \n");

                            if (this.InvokeRequired)
                                this.BeginInvoke((MethodInvoker)delegate
                                {
                                    lblMensagens.Text = ("Base de dados instalado com sucesso... \n");
                                });

                            IniciaInstalacao();

                        }
                        else
                        {

                            int retorno = proc.ExitCode;

                            MessageBox.Show("Houve um erro na instalação do banco de dados, erro retornado: " + retorno);

                            if (this.InvokeRequired)
                                this.BeginInvoke((MethodInvoker)delegate
                                {
                                    //MessageBox.Show("Houve um erro na instalação do banco de dados, erro retornado: " + proc.ExitCode.ToString());
                                    this.Close();
                                });


                        }

                    }
                    else
                    {
                        startDownload();
                    }

                    proc.Close();
                }
                else
                {
                    startDownload();
                }
            }
        }

        static string ProgramFilesx86()
        {
            if (8 == IntPtr.Size
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
        }


        private void startDownload()
        {
            if (this.InvokeRequired)
                this.BeginInvoke((MethodInvoker)delegate
                {
                    pictureBoxLoading.Visible = false;
                    panel1.Visible = true;
                });

            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                sw.Start();
                client.DownloadFileAsync(new Uri(UrlDownloadSQLServer), DirRoot + "Arquivos\\" + this.FileDownloaded);
            });

            thread.Start();
        }

        void client_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((MethodInvoker)delegate
                {
                    labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

                    // Update the progressbar percentage only when the value is not the same.
                    progressBar.Value = e.ProgressPercentage;

                    // Show the percentage on our label.
                    labelPerc.Text = e.ProgressPercentage.ToString() + "%";

                    // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
                    labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
                        (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                        (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
                });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (this.InvokeRequired)
                this.BeginInvoke((MethodInvoker)delegate
                {
                    sw.Reset();

                    progressBar.Value = 100;
                    labelPerc.Text = "100%";
                    labelSpeed.Text = "";
                    labelDownloaded.Text = "Completado!";

                    lblMensagens.Text = "Download finalizado, aguarde o sistema efetuará a instalação.";
                    Thread.Sleep(5000);

                    Thread thread = new Thread(() =>
                    {
                        IniciaInstalacao();
                    });

                    thread.Start();
                });
        }

        private void RemoveInstancias()
        {

            using (Process proc = new Process())
            {

                if (File.Exists(DirRoot + @"\Arquivos\" + this.FileDownloaded))
                {



                    proc.StartInfo.FileName = DirRoot + @"\Arquivos\" + this.FileDownloaded;
                    proc.EnableRaisingEvents = true;
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.RedirectStandardError = true;
                    proc.StartInfo.RedirectStandardInput = true;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.OutputDataReceived += proc_OutputDataReceived;

                    if (System.Environment.OSVersion.Version.Major >= 6)
                    {
                        proc.StartInfo.Verb = "runas";
                    }



                    try
                    {
                        LocalhostInstancias = GetLocalSqlServerInstanceNames();


                        if (LocalhostInstancias.Count > 0)
                        {

                            foreach (var item in LocalhostInstancias)
                            {

                                if (this.InvokeRequired)
                                    this.BeginInvoke((MethodInvoker)delegate
                                    {
                                        lblMensagens.Text = ("Removendo a Instância '" + item + "'... \n");
                                    });

                                //Utilize o argumento /INDICATEPROGRESS=1 para exibir o progresso na tela do DOS
                                proc.StartInfo.Arguments = @"/Action=Uninstall /INDICATEPROGRESS=0 /FEATURES=SQL,AS,RS,IS,Tools /INSTANCENAME=" + item + " /Q";
                                //proc.StartInfo.Arguments = @"/Action=Uninstall /INDICATEPROGRESS=0 /FEATURES=SQL,AS,RS,IS,Tools /INSTANCENAME=" + item + " /Q";
                                proc.Start();

                                StreamWriter sortStreamWriter = proc.StandardInput;

                                proc.BeginErrorReadLine();
                                proc.BeginOutputReadLine();




                                do
                                {

                                    proc.Refresh();


                                    if (this.InvokeRequired)
                                        this.BeginInvoke((MethodInvoker)delegate
                                        {
                                            lblMensagens.Text = ("Removendo Instância - Physical Memory Usage: " + proc.WorkingSet64.ToString() + " - Tempo: " + proc.TotalProcessorTime + "\n");
                                        });


                                } while (!proc.WaitForExit(1000));


                                if (proc.ExitCode == 0)
                                {
                                    if (this.InvokeRequired)
                                        this.BeginInvoke((MethodInvoker)delegate
                                        {
                                            lblMensagens.Text = ("Instância '" + item + "' removida com sucesso... \n");

                                            Thread thread = new Thread(() =>
                                            {
                                                InstalarInstancia();
                                            });

                                            thread.Start();
                                        });

                                }
                            }
                        }
                        else
                        {
                            Thread thread = new Thread(() =>
                            {
                                InstalarInstancia();
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        if (this.InvokeRequired)
                            this.BeginInvoke((MethodInvoker)delegate
                            {
                                lblMensagens.Text = ("Erro: '" + ex.Message + "\n");
                            });

                        else
                        {
                            lblMensagens.Text = ("Erro: '" + ex.Message + "\n");
                        }
                    }


                    proc.Close();
                }
                else
                {
                    startDownload();
                }
            }
            //});

        }

        private void proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

        }


    }

    public enum RegistryHive
    {
        Wow64,
        Wow6432
    }

    public class RegistryValueDataReader
    {
        private static readonly int KEY_WOW64_32KEY = 0x200;
        private static readonly int KEY_WOW64_64KEY = 0x100;

        private static readonly UIntPtr HKEY_LOCAL_MACHINE = (UIntPtr)0x80000002;

        private static readonly int KEY_QUERY_VALUE = 0x1;

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegOpenKeyEx")]
        static extern int RegOpenKeyEx(
                    UIntPtr hKey,
                    string subKey,
                    uint options,
                    int sam,
                    out IntPtr phkResult);


        [DllImport("advapi32.dll", SetLastError = true)]
        static extern int RegQueryValueEx(
                    IntPtr hKey,
                    string lpValueName,
                    int lpReserved,
                    out uint lpType,
                    IntPtr lpData,
                    ref uint lpcbData);

        private static int GetRegistryHiveKey(RegistryHive registryHive)
        {
            return registryHive == RegistryHive.Wow64 ? KEY_WOW64_64KEY : KEY_WOW64_32KEY;
        }

        private static UIntPtr GetRegistryKeyUIntPtr(RegistryKey registry)
        {
            if (registry == Registry.LocalMachine)
            {
                return HKEY_LOCAL_MACHINE;
            }

            return UIntPtr.Zero;
        }

        public string[] ReadRegistryValueData(RegistryHive registryHive, RegistryKey registryKey, string subKey, string valueName)
        {
            string[] instanceNames = new string[0];

            int key = GetRegistryHiveKey(registryHive);
            UIntPtr registryKeyUIntPtr = GetRegistryKeyUIntPtr(registryKey);

            IntPtr hResult;

            int res = RegOpenKeyEx(registryKeyUIntPtr, subKey, 0, KEY_QUERY_VALUE | key, out hResult);

            if (res == 0)
            {
                uint type;
                uint dataLen = 0;

                RegQueryValueEx(hResult, valueName, 0, out type, IntPtr.Zero, ref dataLen);

                byte[] databuff = new byte[dataLen];
                byte[] temp = new byte[dataLen];

                List<String> values = new List<string>();

                GCHandle handle = GCHandle.Alloc(databuff, GCHandleType.Pinned);
                try
                {
                    RegQueryValueEx(hResult, valueName, 0, out type, handle.AddrOfPinnedObject(), ref dataLen);
                }
                finally
                {
                    handle.Free();
                }

                int i = 0;
                int j = 0;

                while (i < databuff.Length)
                {
                    if (databuff[i] == '\0')
                    {
                        j = 0;
                        string str = Encoding.Default.GetString(temp).Trim('\0');

                        if (!string.IsNullOrEmpty(str))
                        {
                            values.Add(str);
                        }

                        temp = new byte[dataLen];
                    }
                    else
                    {
                        temp[j++] = databuff[i];
                    }

                    ++i;
                }

                instanceNames = new string[values.Count];
                values.CopyTo(instanceNames);
            }

            return instanceNames;
        }
    }

}
