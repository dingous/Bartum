using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;

namespace BarTum.Windows.Modulos.Atualizacao
{
    public partial class ChecarAtualizacao : Form
    {
        public ChecarAtualizacao()
        {
            InitializeComponent();
        }

        private void ChecarAtualizacao_Load(object sender, EventArgs e)
        {
            try
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                versaoatual.Text = ad.CurrentVersion.ToString();
                versaoatualizar.Text = ad.TimeOfLastUpdateCheck.ToString("dd/MM/yyyy hh:mm");

            }catch(Exception error)
            {
                MessageBox.Show(error.Message + error.InnerException != null ? error.InnerException.Message : "");
            }

        }


        long sizeOfUpdate = 0;

        private void UpdateApplication()
        {

            try
            {
                button1.Enabled = false;

                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                    ad.CheckForUpdateCompleted += new CheckForUpdateCompletedEventHandler(ad_CheckForUpdateCompleted);
                    ad.CheckForUpdateProgressChanged += new DeploymentProgressChangedEventHandler(ad_CheckForUpdateProgressChanged);
               
                    ad.CheckForUpdateAsync();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.InnerException != null ? error.InnerException.Message : "");
            }
        }

        void ad_CheckForUpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            
            

            try
            {
                downloadStatus.Text = String.Format("Baixando: {0}. {1:D}K of {2:D}K baixados.", GetProgressString(e.State), e.BytesCompleted / 1024, e.BytesTotal / 1024);
            }catch(Exception error)
            {
                MessageBox.Show(error.Message + error.InnerException != null ? error.InnerException.Message : "");
            }
        }

        string GetProgressString(DeploymentProgressState state)
        {
            

            if (state == DeploymentProgressState.DownloadingApplicationFiles)
            {
                return "application files";
            }
            else if (state == DeploymentProgressState.DownloadingApplicationInformation)
            {
                return "application manifest";
            }
            else
            {
                return "deployment manifest";
            }
        }

        void ad_CheckForUpdateCompleted(object sender, CheckForUpdateCompletedEventArgs e)
        {

          

            try
            {

            if (e.Error != null)
            {
                MessageBox.Show("ERRO: Não foi possível atualizar a nova versão. Razão: \n" + e.Error.Message + "\nPor favor informe ao desenvolvedor do sistema.");
                return;
            }
            else if (e.Cancelled == true)
            {
                MessageBox.Show("A atualização foi cancelada.");
            }

            // Ask the user if they would like to update the application now.
            if (e.UpdateAvailable)
            {
                sizeOfUpdate = e.UpdateSizeBytes;

                if (!e.IsUpdateRequired)
                {

                    DialogResult dr = MessageBox.Show("Uma nova atualização está disponível!\n\n Nova versão: " + e.AvailableVersion + " \n\n Deseja atualizar o sistema agora?\n\n", "Atualização Disponível", MessageBoxButtons.OKCancel);
                    if (DialogResult.OK == dr)
                    {
                        BeginUpdate();
                    }
                }
                else
                {
                    MessageBox.Show("Uma atualização obrigatória está disponível para o seu sistema. Nós vamos instalar a atualização agora, depois de completá-la o sistema será reiniciado.");
                    BeginUpdate();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma atualização deste software disponível.");
            }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.InnerException != null ? error.InnerException.Message : "");
            }
        }

        private void BeginUpdate()
        {
            try
            {

            ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
            ad.UpdateCompleted += new AsyncCompletedEventHandler(ad_UpdateCompleted);

          
            // Indicate progress in the application's status bar.
            ad.UpdateProgressChanged += new DeploymentProgressChangedEventHandler(ad_UpdateProgressChanged);
            ad.UpdateAsync();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.InnerException != null ? error.InnerException.Message : "");
            }
        }

        void ad_UpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            String progressText = String.Format("{0:D}K de {1:D}K baixados - {2:D}% completados", e.BytesCompleted / 1024, e.BytesTotal / 1024, e.ProgressPercentage);
            downloadStatus.Text = progressText;
        }

        void ad_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {

                if (e.Cancelled)
                {
                    MessageBox.Show("A atualização foi cancelada.");
                    return;
                }
                else if (e.Error != null)
                {
                    MessageBox.Show("ERRO: Não foi possível instalar a última versão do sistema. Razão: \n" + e.Error.Message + "\nPor favor informe ao desenvolvedor do sistema.");
                    return;
                }


                button1.Enabled = true;

                DialogResult dr = MessageBox.Show("O sistema foi atualizado com sucesso. Deseja reiniciar? (Se você reiniciar agora, a nova versão será aplicada ou então aplicará quando você abrir novamente .)", "Reinicar aplicação", MessageBoxButtons.OKCancel);
                if (DialogResult.OK == dr)
                {
                    Application.Restart();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + error.InnerException != null ? error.InnerException.Message : "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateApplication();
        }
    }
}
