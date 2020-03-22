namespace BarTum.Windows.Modulos.Caixa
{
    partial class frmBoxEscolherCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoxEscolherCaixa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.eB_CaixaHistoricoFechamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eB_CaixaHistoricoFechamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_CaixaHistoricoFechamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_CaixaHistoricoFechamentoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // eB_CaixaHistoricoFechamentoBindingSource
            // 
            this.eB_CaixaHistoricoFechamentoBindingSource.DataSource = typeof(BarTum.Entities.EB_CaixaHistoricoFechamento);
            // 
            // eB_CaixaHistoricoFechamentoDataGridView
            // 
            this.eB_CaixaHistoricoFechamentoDataGridView.AllowUserToAddRows = false;
            this.eB_CaixaHistoricoFechamentoDataGridView.AllowUserToDeleteRows = false;
            this.eB_CaixaHistoricoFechamentoDataGridView.AutoGenerateColumns = false;
            this.eB_CaixaHistoricoFechamentoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.eB_CaixaHistoricoFechamentoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eB_CaixaHistoricoFechamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eB_CaixaHistoricoFechamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.eB_CaixaHistoricoFechamentoDataGridView.DataSource = this.eB_CaixaHistoricoFechamentoBindingSource;
            resources.ApplyResources(this.eB_CaixaHistoricoFechamentoDataGridView, "eB_CaixaHistoricoFechamentoDataGridView");
            this.eB_CaixaHistoricoFechamentoDataGridView.Name = "eB_CaixaHistoricoFechamentoDataGridView";
            this.eB_CaixaHistoricoFechamentoDataGridView.ReadOnly = true;
            this.eB_CaixaHistoricoFechamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CaixaID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dtCaixaAbertura";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dtCaixaFechamento";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // frmBoxEscolherCaixa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.eB_CaixaHistoricoFechamentoDataGridView);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBoxEscolherCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmBoxEscolherCaixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_CaixaHistoricoFechamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_CaixaHistoricoFechamentoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource eB_CaixaHistoricoFechamentoBindingSource;
        private System.Windows.Forms.DataGridView eB_CaixaHistoricoFechamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;


    }
}