namespace BarTum.Windows.Modulos.Atendimento
{
    partial class frmPendentesComanda
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonemAberto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripFechadas = new System.Windows.Forms.ToolStripButton();
            this.eBLancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TotalPendentes = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.eB_LancamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBLancamentoBindingSource)).BeginInit();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_LancamentoDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(726, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
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
            // eBLancamentoBindingSource
            // 
            this.eBLancamentoBindingSource.DataSource = typeof(BarTum.Entities.EB_Lancamento);
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
            this.toolStrip4.Location = new System.Drawing.Point(0, 529);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(726, 25);
            this.toolStrip4.TabIndex = 18;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.TotalPagar,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.eB_LancamentoDataGridView.DataSource = this.eBLancamentoBindingSource;
            this.eB_LancamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eB_LancamentoDataGridView.Location = new System.Drawing.Point(0, 39);
            this.eB_LancamentoDataGridView.Name = "eB_LancamentoDataGridView";
            this.eB_LancamentoDataGridView.ReadOnly = true;
            this.eB_LancamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eB_LancamentoDataGridView.Size = new System.Drawing.Size(726, 490);
            this.eB_LancamentoDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ComandaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nº Comanda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 85;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LanctoID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nº Venda";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 72;
            // 
            // TotalPagar
            // 
            this.TotalPagar.DataPropertyName = "TotalPagar";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "R$ 0,00";
            this.TotalPagar.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotalPagar.HeaderText = "Total de consumo";
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.ReadOnly = true;
            this.TotalPagar.Width = 107;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StatusID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 74;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dtLancto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data/Hora início";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 103;
            // 
            // frmPendentesComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 554);
            this.Controls.Add(this.eB_LancamentoDataGridView);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPendentesComanda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas pendentes na comanda";
            this.Load += new System.EventHandler(this.frmPendentesComanda_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBLancamentoBindingSource)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_LancamentoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton toolStripBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButtonemAberto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripFechadas;
        private System.Windows.Forms.BindingSource eBLancamentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox TotalPendentes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView eB_LancamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}