namespace BarTum.Windows.Modulos.Garcon
{
    partial class frmGarconList
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.eB_GarconDataGridView = new System.Windows.Forms.DataGridView();
            this.garconIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eBGarconBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBClienteOcorrenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_GarconDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBGarconBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBClienteOcorrenciasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIncluir,
            this.toolStripAlterar,
            this.toolStripConsultar,
            this.toolStripExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripIncluir
            // 
            this.toolStripIncluir.Image = global::BarTum.Windows.Properties.Resources.clients;
            this.toolStripIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripIncluir.Name = "toolStripIncluir";
            this.toolStripIncluir.Size = new System.Drawing.Size(76, 36);
            this.toolStripIncluir.Text = "Incluir";
            this.toolStripIncluir.Click += new System.EventHandler(this.toolStripIncluir_Click);
            // 
            // toolStripAlterar
            // 
            this.toolStripAlterar.Image = global::BarTum.Windows.Properties.Resources.note;
            this.toolStripAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAlterar.Name = "toolStripAlterar";
            this.toolStripAlterar.Size = new System.Drawing.Size(78, 36);
            this.toolStripAlterar.Text = "Alterar";
            this.toolStripAlterar.Click += new System.EventHandler(this.toolStripAlterar_Click);
            // 
            // toolStripConsultar
            // 
            this.toolStripConsultar.Image = global::BarTum.Windows.Properties.Resources.search;
            this.toolStripConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConsultar.Name = "toolStripConsultar";
            this.toolStripConsultar.Size = new System.Drawing.Size(94, 36);
            this.toolStripConsultar.Text = "Consultar";
            this.toolStripConsultar.Click += new System.EventHandler(this.toolStripConsultar_Click);
            // 
            // toolStripExcluir
            // 
            this.toolStripExcluir.Image = global::BarTum.Windows.Properties.Resources.exit;
            this.toolStripExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExcluir.Name = "toolStripExcluir";
            this.toolStripExcluir.Size = new System.Drawing.Size(77, 36);
            this.toolStripExcluir.Text = "Excluir";
            // 
            // eB_GarconDataGridView
            // 
            this.eB_GarconDataGridView.AllowUserToAddRows = false;
            this.eB_GarconDataGridView.AllowUserToDeleteRows = false;
            this.eB_GarconDataGridView.AllowUserToOrderColumns = true;
            this.eB_GarconDataGridView.AllowUserToResizeRows = false;
            this.eB_GarconDataGridView.AutoGenerateColumns = false;
            this.eB_GarconDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eB_GarconDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eB_GarconDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.garconIDDataGridViewTextBoxColumn,
            this.dsNomeDataGridViewTextBoxColumn,
            this.dsEnderecoDataGridViewTextBoxColumn,
            this.nrTelefoneDataGridViewTextBoxColumn,
            this.nrCelularDataGridViewTextBoxColumn});
            this.eB_GarconDataGridView.DataSource = this.eBGarconBindingSource;
            this.eB_GarconDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eB_GarconDataGridView.Location = new System.Drawing.Point(0, 39);
            this.eB_GarconDataGridView.MultiSelect = false;
            this.eB_GarconDataGridView.Name = "eB_GarconDataGridView";
            this.eB_GarconDataGridView.ReadOnly = true;
            this.eB_GarconDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eB_GarconDataGridView.Size = new System.Drawing.Size(685, 371);
            this.eB_GarconDataGridView.TabIndex = 3;
            this.eB_GarconDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eB_GarconDataGridView_CellDoubleClick);
            // 
            // garconIDDataGridViewTextBoxColumn
            // 
            this.garconIDDataGridViewTextBoxColumn.DataPropertyName = "GarconID";
            this.garconIDDataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.garconIDDataGridViewTextBoxColumn.Name = "garconIDDataGridViewTextBoxColumn";
            this.garconIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsNomeDataGridViewTextBoxColumn
            // 
            this.dsNomeDataGridViewTextBoxColumn.DataPropertyName = "dsNome";
            this.dsNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.dsNomeDataGridViewTextBoxColumn.Name = "dsNomeDataGridViewTextBoxColumn";
            this.dsNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsEnderecoDataGridViewTextBoxColumn
            // 
            this.dsEnderecoDataGridViewTextBoxColumn.DataPropertyName = "dsEndereco";
            this.dsEnderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.dsEnderecoDataGridViewTextBoxColumn.Name = "dsEnderecoDataGridViewTextBoxColumn";
            this.dsEnderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrTelefoneDataGridViewTextBoxColumn
            // 
            this.nrTelefoneDataGridViewTextBoxColumn.DataPropertyName = "nrTelefone";
            this.nrTelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone Fixo";
            this.nrTelefoneDataGridViewTextBoxColumn.Name = "nrTelefoneDataGridViewTextBoxColumn";
            this.nrTelefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrCelularDataGridViewTextBoxColumn
            // 
            this.nrCelularDataGridViewTextBoxColumn.DataPropertyName = "nrCelular";
            this.nrCelularDataGridViewTextBoxColumn.HeaderText = "Telefone Celular";
            this.nrCelularDataGridViewTextBoxColumn.Name = "nrCelularDataGridViewTextBoxColumn";
            this.nrCelularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eBGarconBindingSource
            // 
            this.eBGarconBindingSource.DataSource = typeof(BarTum.Entities.EB_Garcon);
            // 
            // eBClienteOcorrenciasBindingSource
            // 
            this.eBClienteOcorrenciasBindingSource.DataSource = typeof(BarTum.Entities.EB_ClienteOcorrencias);
            // 
            // frmGarconList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 410);
            this.Controls.Add(this.eB_GarconDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGarconList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de garçons cadastrados";
            this.Load += new System.EventHandler(this.frmGarconList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGarconList_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_GarconDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBGarconBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBClienteOcorrenciasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripButton toolStripAlterar;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        public System.Windows.Forms.DataGridView eB_GarconDataGridView;
        private System.Windows.Forms.BindingSource eBGarconBindingSource;
        private System.Windows.Forms.BindingSource eBClienteOcorrenciasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn garconIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCelularDataGridViewTextBoxColumn;
    }
}