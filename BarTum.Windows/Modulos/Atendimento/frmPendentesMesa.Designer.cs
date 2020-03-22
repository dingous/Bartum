namespace BarTum.Windows.Modulos.Atendimento
{
    partial class frmPendentesMesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eBLancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eB_LancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonemAberto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFechadas = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TotalPendentes = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.eB_LancamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.MesaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGarcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalItens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrOcupantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eBLancamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_LancamentoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_LancamentoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eB_LancamentoBindingSource
            // 
            this.eB_LancamentoBindingSource.DataSource = typeof(BarTum.Entities.EB_Lancamento);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 39);
            this.txtBuscar.ToolTipText = "Buscar...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // toolStripBuscar
            // 
            this.toolStripBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBuscar.Image = global::BarTum.Windows.Properties.Resources.search;
            this.toolStripBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBuscar.Name = "toolStripBuscar";
            this.toolStripBuscar.Size = new System.Drawing.Size(84, 36);
            this.toolStripBuscar.Text = "Buscar: ";
            // 
            // toolStripButtonemAberto
            // 
            this.toolStripButtonemAberto.Image = global::BarTum.Windows.Properties.Resources.package;
            this.toolStripButtonemAberto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonemAberto.Name = "toolStripButtonemAberto";
            this.toolStripButtonemAberto.Size = new System.Drawing.Size(138, 36);
            this.toolStripButtonemAberto.Text = "Vendas em aberto";
            this.toolStripButtonemAberto.Click += new System.EventHandler(this.toolStripButtonemAberto_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(30, 39);
            // 
            // toolStripFechadas
            // 
            this.toolStripFechadas.Image = global::BarTum.Windows.Properties.Resources.note;
            this.toolStripFechadas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFechadas.Name = "toolStripFechadas";
            this.toolStripFechadas.Size = new System.Drawing.Size(131, 36);
            this.toolStripFechadas.Text = "Vendas fechadas";
            this.toolStripFechadas.Click += new System.EventHandler(this.toolStripFechadas_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBuscar,
            this.toolStripBuscar,
            this.toolStripButtonemAberto,
            this.toolStripSeparator1,
            this.toolStripFechadas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolStrip4.Size = new System.Drawing.Size(736, 25);
            this.toolStrip4.TabIndex = 17;
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
            // eB_LancamentoDataGridView
            // 
            this.eB_LancamentoDataGridView.AllowUserToAddRows = false;
            this.eB_LancamentoDataGridView.AllowUserToDeleteRows = false;
            this.eB_LancamentoDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eB_LancamentoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.eB_LancamentoDataGridView.AutoGenerateColumns = false;
            this.eB_LancamentoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.eB_LancamentoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eB_LancamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eB_LancamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MesaID,
            this.NomeGarcon,
            this.dataGridViewTextBoxColumn1,
            this.TotalPagar,
            this.totalItens,
            this.nrOcupantes,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn15,
            this.Column1});
            this.eB_LancamentoDataGridView.DataSource = this.eB_LancamentoBindingSource;
            this.eB_LancamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eB_LancamentoDataGridView.Location = new System.Drawing.Point(0, 39);
            this.eB_LancamentoDataGridView.Name = "eB_LancamentoDataGridView";
            this.eB_LancamentoDataGridView.ReadOnly = true;
            this.eB_LancamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eB_LancamentoDataGridView.Size = new System.Drawing.Size(736, 500);
            this.eB_LancamentoDataGridView.TabIndex = 18;
            // 
            // MesaID
            // 
            this.MesaID.DataPropertyName = "MesaID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MesaID.DefaultCellStyle = dataGridViewCellStyle2;
            this.MesaID.HeaderText = "Nº Mesa";
            this.MesaID.Name = "MesaID";
            this.MesaID.ReadOnly = true;
            this.MesaID.Width = 68;
            // 
            // NomeGarcon
            // 
            this.NomeGarcon.DataPropertyName = "NomeGarcon";
            this.NomeGarcon.HeaderText = "Garçon";
            this.NomeGarcon.Name = "NomeGarcon";
            this.NomeGarcon.ReadOnly = true;
            this.NomeGarcon.Width = 67;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LanctoID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº Venda";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // TotalPagar
            // 
            this.TotalPagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TotalPagar.DataPropertyName = "TotalPagar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "R$ 0,00";
            this.TotalPagar.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalPagar.HeaderText = "Total de consumo";
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.ReadOnly = true;
            this.TotalPagar.Width = 107;
            // 
            // totalItens
            // 
            this.totalItens.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalItens.DataPropertyName = "totalItens";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "0";
            this.totalItens.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalItens.HeaderText = "Total de ítens";
            this.totalItens.Name = "totalItens";
            this.totalItens.ReadOnly = true;
            this.totalItens.Width = 90;
            // 
            // nrOcupantes
            // 
            this.nrOcupantes.DataPropertyName = "nrOcupantes";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nrOcupantes.DefaultCellStyle = dataGridViewCellStyle6;
            this.nrOcupantes.HeaderText = "Nº de ocupantes";
            this.nrOcupantes.Name = "nrOcupantes";
            this.nrOcupantes.ReadOnly = true;
            this.nrOcupantes.Width = 103;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "StatusID";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn12.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 74;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "dtLancto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn15.HeaderText = "Data/Hora início";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 103;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dtFechamento";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = "-";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.HeaderText = "Data/Hora fim";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 91;
            // 
            // frmPendentesMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 564);
            this.Controls.Add(this.eB_LancamentoDataGridView);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmPendentesMesa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas pendentes nas mesas";
            this.Load += new System.EventHandler(this.frmPendentesBalcao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBLancamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_LancamentoBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_LancamentoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn lanctoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caixaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVendaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLanctoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garconIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balcaoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregadorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoContaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrOcupantesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtLanctoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFimLanctoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsNomeClienteBalcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTotalConsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAcrescimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDescontosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAdiantamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTotalPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBBalcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBCadastroMesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBCaixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBEntregadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBFormaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBGarconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBLancamentoItensDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBPlanoContasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBTipoLanctoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBTipoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBLancamentoStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eBLancamentoBindingSource;
        private System.Windows.Forms.BindingSource eB_LancamentoBindingSource;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton toolStripBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButtonemAberto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripFechadas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripTextBox TotalPendentes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView eB_LancamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGarcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrOcupantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}