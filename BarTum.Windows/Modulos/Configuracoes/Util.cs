using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using BarTum.Entities;
using System.Collections.Specialized;
using System.Deployment.Application;
using System.Web;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Data.Sql;
using System.IO;

namespace BarTum.Windows.Modulos.Configuracoes
{
    public class Util
    {

    //    public string tipo = "servidor";
    //    public string DirRoot = AppDomain.CurrentDomain.BaseDirectory;
    //    public IList<string> LocalhostInstancias = GetLocalSqlServerInstanceNames();
    //    public NameValueCollection UrlParametros = Util.GetQueryStringParameters(); //Localhost Instâncias
    //    public SqlDataSourceEnumerator RemoteInstancias = SqlDataSourceEnumerator.Instance;
    //    public string FileName = null;
    //    public string Arquitetura = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
    //    public string UrlDownloadSQLServer = "http://go.microsoft.com/fwlink/?LinkID=230857&amp;clcid=0x409";
    //    public string FileDownloaded = "SQLEXPR_x64_PTB.exe";


        public static int converteMMparaPixels(int MM)
        {
            //1 mm = 3,938095238095238

            decimal w = 3.938095238095238M;
            decimal total = (MM * w);

            return Convert.ToInt32(total);
        }

        public static void getIPs()
        {


            /*Management _mc = new ManagementClass("Win32_NetworkAdapterConfiguration");

            ManagementObjectCollection _moc = _mc.GetInstances();



            foreach (ManagementObject moc_ in _moc)
            {

                if (!(bool)moc_["ipEnabled"])
                {

                    continue;

                }



                string[] enderecoIP = (string[])moc_["IPAddress"];



                foreach (string sIP in enderecoIP)
                {

                    Console.WriteLine(sIP);

                }

            }*/
        }

    //    public void verificaConfiguracoesIniciais()
    //    {
    //        NameValueCollection UrlParametros = Util.GetQueryStringParameters();

    //        if (this.tipo == "servidor")
    //        {
    //            if (!SqlServerInstalled())
    //            {

    //            }
    //        }


    //    }

    //    public static NameValueCollection GetQueryStringParameters()
    //    {
    //        NameValueCollection col = new NameValueCollection();
    //        if (ApplicationDeployment.IsNetworkDeployed)
    //        {
    //            string queryString = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;
    //            col = HttpUtility.ParseQueryString(queryString);

    //            MessageBox.Show("Parametros: " + queryString);
    //        }


    //        return col;
    //    }



    //    public bool SqlServerInstalled()
    //    {
    //        if (GetLocalSqlServerInstanceNames().Count > 0)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return true;
    //        }

    //    }


    //    public void InstalarInstancia()
    //    {
    //        //if (this.InvokeRequired)
    //        //    this.BeginInvoke((MethodInvoker)delegate
    //        //    {


    //        LocalhostInstancias = Util.GetLocalSqlServerInstanceNames();
    //        bool InstanciaExiste = LocalhostInstancias.Where(a => a == "BARTUM").ToList().Count > 0;

    //        using (Process proc = new Process())
    //        {
    //            if (!InstanciaExiste)
    //            {

    //                if (File.Exists(DirRoot + @"\Arquivos\" + this.FileDownloaded))
    //                {



    //                    proc.StartInfo.FileName = DirRoot + @"\Arquivos\" + this.FileDownloaded;
    //                    proc.EnableRaisingEvents = true;
    //                    proc.StartInfo.UseShellExecute = false;
    //                    proc.StartInfo.CreateNoWindow = true;
    //                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
    //                    if (System.Environment.OSVersion.Version.Major >= 6)
    //                    {
    //                        proc.StartInfo.Verb = "runas";
    //                        //proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(proc.StartInfo.FileName);
    //                    }

    //                    if (InstalaInstacia)
    //                    {
    //                        if (this.InvokeRequired)
    //                            this.BeginInvoke((MethodInvoker)delegate
    //                            {
    //                                //txtAndamento.AppendText("Iniciando a instalação de uma nova instância... \n");
    //                            });


    //                        //proc.StartInfo.Arguments = @"/ConfigurationFile=" + DirRoot + @"\Arquivos\ConfigurationFile.txt /Action=Install /QS /INDICATEPROGRESS=0";
    //                        proc.StartInfo.Arguments = @"/q /ConfigurationFile=" + DirRoot + @"\Arquivos\ConfigurationFile.txt /hideconsole /features=SQL /Action=Install /enableranu=1 /skiprules=RebootRequiredCheck";
    //                        proc.Start();

    //                        //proc.BeginErrorReadLine();
    //                        //proc.BeginOutputReadLine();

    //                        do
    //                        {

    //                            proc.Refresh();


    //                            if (this.InvokeRequired)
    //                                this.BeginInvoke((MethodInvoker)delegate
    //                                {
    //                                    txtAndamento.AppendText("Instalando Instância - Physical Memory Usage: " + proc.WorkingSet64.ToString() + " - Tempo: " + proc.TotalProcessorTime + "\n");
    //                                });


    //                        } while (!proc.WaitForExit(1000));




    //                        if (proc.ExitCode == 0)
    //                        {
    //                            if (this.InvokeRequired)
    //                                this.BeginInvoke((MethodInvoker)delegate
    //                                {
    //                                    txtAndamento.AppendText("Instância instalada com sucesso... \n");
    //                                });

    //                            //InstalaBanco();
    //                            IniciaInstalacao();

    //                        }
    //                        else
    //                        {
    //                            MessageBox.Show(proc.ExitCode.ToString());
    //                        }
    //                    }




    //                }
    //                else
    //                {
    //                    //InstalaBanco();
    //                    //IniciaInstalacao();
    //                    startDownload();
    //                }

    //                proc.Close();
    //            }
    //            else
    //            {
    //                startDownload();
    //            }
    //        }


    //        //});
    //    }





    //    public static IList<string> GetLocalSqlServerInstanceNames()
    //    {
    //        RegistryValueDataReader registryValueDataReader = new RegistryValueDataReader();



    //        string[] instances64Bit = registryValueDataReader.ReadRegistryValueData(RegistryHive.Wow64,
    //                                                                                Microsoft.Win32.Registry.LocalMachine,
    //                                                                                @"SOFTWARE\Microsoft\Microsoft SQL Server",
    //                                                                                "InstalledInstances");

    //        string[] instances32Bit = registryValueDataReader.ReadRegistryValueData(RegistryHive.Wow6432,
    //                                                                                Registry.LocalMachine,
    //                                                                                @"SOFTWARE\Microsoft\Microsoft SQL Server",
    //                                                                                "InstalledInstances");


    //        IList<string> localInstanceNames = new List<string>(instances64Bit);

    //        localInstanceNames = localInstanceNames.Union(instances32Bit).ToList();

    //        return localInstanceNames;
    //    }


    //    public static void SetAllModified<T>(this T entity, ObjectContext context) where T : IEntityWithKey
    //    {
    //        var stateEntry = context.ObjectStateManager.GetObjectStateEntry(entity.EntityKey);
    //        var propertyNameList = stateEntry.CurrentValues.DataRecordInfo.FieldMetadata.Select
    //          (pn => pn.FieldType.Name);
    //        foreach (var propName in propertyNameList)
    //            stateEntry.SetModifiedProperty(propName);
    //    }
    //}

    //public enum RegistryHive
    //{
    //    Wow64,
    //    Wow6432
    //}

    //public class RegistryValueDataReader
    //{
    //    private static readonly int KEY_WOW64_32KEY = 0x200;
    //    private static readonly int KEY_WOW64_64KEY = 0x100;

    //    private static readonly UIntPtr HKEY_LOCAL_MACHINE = (UIntPtr)0x80000002;

    //    private static readonly int KEY_QUERY_VALUE = 0x1;

    //    [DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegOpenKeyEx")]
    //    static extern int RegOpenKeyEx(
    //                UIntPtr hKey,
    //                string subKey,
    //                uint options,
    //                int sam,
    //                out IntPtr phkResult);


    //    [DllImport("advapi32.dll", SetLastError = true)]
    //    static extern int RegQueryValueEx(
    //                IntPtr hKey,
    //                string lpValueName,
    //                int lpReserved,
    //                out uint lpType,
    //                IntPtr lpData,
    //                ref uint lpcbData);

    //    private static int GetRegistryHiveKey(RegistryHive registryHive)
    //    {
    //        return registryHive == RegistryHive.Wow64 ? KEY_WOW64_64KEY : KEY_WOW64_32KEY;
    //    }

    //    private static UIntPtr GetRegistryKeyUIntPtr(RegistryKey registry)
    //    {
    //        if (registry == Registry.LocalMachine)
    //        {
    //            return HKEY_LOCAL_MACHINE;
    //        }

    //        return UIntPtr.Zero;
    //    }

    //    public string[] ReadRegistryValueData(RegistryHive registryHive, RegistryKey registryKey, string subKey, string valueName)
    //    {
    //        string[] instanceNames = new string[0];

    //        int key = GetRegistryHiveKey(registryHive);
    //        UIntPtr registryKeyUIntPtr = GetRegistryKeyUIntPtr(registryKey);

    //        IntPtr hResult;

    //        int res = RegOpenKeyEx(registryKeyUIntPtr, subKey, 0, KEY_QUERY_VALUE | key, out hResult);

    //        if (res == 0)
    //        {
    //            uint type;
    //            uint dataLen = 0;

    //            RegQueryValueEx(hResult, valueName, 0, out type, IntPtr.Zero, ref dataLen);

    //            byte[] databuff = new byte[dataLen];
    //            byte[] temp = new byte[dataLen];

    //            List<String> values = new List<string>();

    //            GCHandle handle = GCHandle.Alloc(databuff, GCHandleType.Pinned);
    //            try
    //            {
    //                RegQueryValueEx(hResult, valueName, 0, out type, handle.AddrOfPinnedObject(), ref dataLen);
    //            }
    //            finally
    //            {
    //                handle.Free();
    //            }

    //            int i = 0;
    //            int j = 0;

    //            while (i < databuff.Length)
    //            {
    //                if (databuff[i] == '\0')
    //                {
    //                    j = 0;
    //                    string str = Encoding.Default.GetString(temp).Trim('\0');

    //                    if (!string.IsNullOrEmpty(str))
    //                    {
    //                        values.Add(str);
    //                    }

    //                    temp = new byte[dataLen];
    //                }
    //                else
    //                {
    //                    temp[j++] = databuff[i];
    //                }

    //                ++i;
    //            }

    //            instanceNames = new string[values.Count];
    //            values.CopyTo(instanceNames);
    //        }

    //        return instanceNames;
    //    }
    }
}
