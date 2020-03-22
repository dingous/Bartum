namespace BarTum.Windows.Modulos.Relatorios
{
    partial class RelatorioClientesMaisCompram 
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EB_LancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EB_LancamentoItensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.easyBarEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRVENDASCLIENTESResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TotalPendentes = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.eB_ProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.produtoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsObservacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EB_LancamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EB_LancamentoItensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBarEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRVENDASCLIENTESResultBindingSource)).BeginInit();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ProdutoDataGridView)).BeginInit();
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
            // easyBarEntitiesBindingSource
            // 
            this.easyBarEntitiesBindingSource.DataSource = typeof(BarTum.Entities.BarTumEntities);
            // 
            // pRVENDASCLIENTESResultBindingSource
            // 
            this.pRVENDASCLIENTESResultBindingSource.DataSource = typeof(BarTum.Entities.PR_VENDAS_CLIENTES_Result);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.TotalPendentes,
            this.toolStripLabel6});
            this.toolStrip4.Location = new System.Drawing.Point(0, 539);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(866, 25);
            this.toolStrip4.TabIndex = 20;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(30, 25);
            // 
            // TotalPendentes
            // 
            this.TotalPendentes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TotalPendentes.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TotalPendentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPendentes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TotalPendentes.Name = "TotalPendentes";
            this.TotalPendentes.ReadOnly = true;
            this.TotalPendentes.Size = new System.Drawing.Size(130, 25);
            this.TotalPendentes.Text = "R$ 0,00";
            this.TotalPendentes.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel6.Text = "     Total: ";
            // 
            // eB_ProdutoDataGridView
            // 
            this.eB_ProdutoDataGridView.AllowUserToAddRows = false;
            this.eB_ProdutoDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eB_ProdutoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.eB_ProdutoDataGridView.AutoGenerateColumns = false;
            this.eB_ProdutoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.eB_ProdutoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eB_ProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eB_ProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoIDDataGridViewTextBoxColumn,
            this.dsObservacaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.Total});
            this.eB_ProdutoDataGridView.DataSource = this.pRVENDASCLIENTESResultBindingSource;
            this.eB_ProdutoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eB_ProdutoDataGridView.Location = new System.Drawing.Point(0, 25);
            this.eB_ProdutoDataGridView.MultiSelect = false;
            this.eB_ProdutoDataGridView.Name = "eB_ProdutoDataGridView";
            this.eB_ProdutoDataGridView.ReadOnly = true;
            this.eB_ProdutoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eB_ProdutoDataGridView.Size = new System.Drawing.Size(866, 514);
            this.eB_ProdutoDataGridView.TabIndex = 21;
            // 
            // produtoIDDataGridViewTextBoxColumn
            // 
            this.produtoIDDataGridViewTextBoxColumn.DataPropertyName = "ProdutoID";
            this.produtoIDDataGridViewTextBoxColumn.HeaderText = "Cód. Cliente";
            this.produtoIDDataGridViewTextBoxColumn.Name = "produtoIDDataGridViewTextBoxColumn";
            this.produtoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.produtoIDDataGridViewTextBoxColumn.Width = 82;
            // 
            // dsObservacaoDataGridViewTextBoxColumn
            // 
            this.dsObservacaoDataGridViewTextBoxColumn.DataPropertyName = "dsObservacao";
            this.dsObservacaoDataGridViewTextBoxColumn.HeaderText = "Nome Cliente";
            this.dsObservacaoDataGridViewTextBoxColumn.Name = "dsObservacaoDataGridViewTextBoxColumn";
            this.dsObservacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dsObservacaoDataGridViewTextBoxColumn.Width = 87;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Total de Ítens";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 89;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle2.Format = "C2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total da Venda";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 96;
            // 
            // RelatorioClientesMaisCompram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 564);
            this.Controls.Add(this.eB_ProdutoDataGridView);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.toolStrip2);
            this.Name = "RelatorioClientesMaisCompram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de clientes que mais compraram";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EB_LancamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EB_LancamentoItensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBarEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRVENDASCLIENTESResultBindingSource)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ProdutoDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource pRVENDASCLIENTESResultBindingSource;
        private System.Windows.Forms.BindingSource easyBarEntitiesBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox TotalPendentes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        public System.Windows.Forms.DataGridView eB_ProdutoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsObservacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}