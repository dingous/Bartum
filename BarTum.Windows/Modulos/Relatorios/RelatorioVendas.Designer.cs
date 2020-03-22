namespace BarTum.Windows.Modulos.Relatorios
{
    partial class RelatorioVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EB_LancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EB_LancamentoItensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EB_LancamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EB_LancamentoItensBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EB_LancamentoBindingSource
            // 
            this.EB_LancamentoBindingSource.DataMember = "EB_LancamentoItens";
            this.EB_LancamentoBindingSource.DataSource = typeof(BarTum.Entities.EB_Lancamento);
            // 
            // EB_LancamentoItensBindingSource
            // 
            this.EB_LancamentoItensBindingSource.DataSource = typeof(BarTum.Entities.EB_LancamentoItens);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(866, 25);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsVendaProd";
            reportDataSource1.Value = this.EB_LancamentoItensBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BarTum.Windows.Modulos.Relatorios.VendaProd.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(866, 539);
            this.reportViewer1.TabIndex = 10;
            // 
            // RelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 564);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "RelatorioVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de vendas por produtos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EB_LancamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EB_LancamentoItensBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Diagnostics.Process process1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.BindingSource EB_LancamentoItensBindingSource;
        private System.Windows.Forms.BindingSource EB_LancamentoBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}