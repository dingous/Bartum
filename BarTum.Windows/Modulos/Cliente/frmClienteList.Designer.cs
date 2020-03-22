namespace BarTum.Windows.Modulos.Cliente
{
    partial class frmClienteList 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripBuscar = new System.Windows.Forms.ToolStripButton();
            this.eB_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eB_ClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eB_ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefone4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.backgroundWorkerCliente = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorkerBusca = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteBindingNavigator)).BeginInit();
            this.eB_ClienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIncluir,
            this.toolStripButton1,
            this.txtBuscar,
            this.toolStripAlterar,
            this.toolStripConsultar,
            this.toolStripExcluir,
            this.toolStripBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(894, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripIncluir
            // 
            this.toolStripIncluir.Image = global::BarTum.Windows.Properties.Resources.clients;
            this.toolStripIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripIncluir.Name = "toolStripIncluir";
            this.toolStripIncluir.Size = new System.Drawing.Size(76, 36);
            this.toolStripIncluir.Text = "Incluir";
            this.toolStripIncluir.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BarTum.Windows.Properties.Resources.search;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripBuscar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
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
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // toolStripAlterar
            // 
            this.toolStripAlterar.Image = global::BarTum.Windows.Properties.Resources.note;
            this.toolStripAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAlterar.Name = "toolStripAlterar";
            this.toolStripAlterar.Size = new System.Drawing.Size(78, 36);
            this.toolStripAlterar.Text = "Alterar";
            this.toolStripAlterar.Click += new System.EventHandler(this.toolStripButton3_Click);
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
            this.toolStripExcluir.Click += new System.EventHandler(this.toolStripExcluir_Click);
            // 
            // toolStripBuscar
            // 
            this.toolStripBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBuscar.Name = "toolStripBuscar";
            this.toolStripBuscar.Size = new System.Drawing.Size(52, 36);
            this.toolStripBuscar.Text = "Buscar: ";
            // 
            // eB_ClienteBindingNavigator
            // 
            this.eB_ClienteBindingNavigator.AddNewItem = null;
            this.eB_ClienteBindingNavigator.BindingSource = this.eB_ClienteBindingSource;
            this.eB_ClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eB_ClienteBindingNavigator.DeleteItem = null;
            this.eB_ClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.eB_ClienteBindingNavigator.Location = new System.Drawing.Point(0, 39);
            this.eB_ClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eB_ClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eB_ClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eB_ClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eB_ClienteBindingNavigator.Name = "eB_ClienteBindingNavigator";
            this.eB_ClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eB_ClienteBindingNavigator.Size = new System.Drawing.Size(894, 25);
            this.eB_ClienteBindingNavigator.TabIndex = 2;
            this.eB_ClienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // eB_ClienteDataGridView
            // 
            this.eB_ClienteDataGridView.AllowUserToAddRows = false;
            this.eB_ClienteDataGridView.AllowUserToDeleteRows = false;
            this.eB_ClienteDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eB_ClienteDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.eB_ClienteDataGridView.AutoGenerateColumns = false;
            this.eB_ClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.eB_ClienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eB_ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eB_ClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteID,
            this.dsNome,
            this.dsLogradouro,
            this.nrTelefone1,
            this.nrTelefone2,
            this.nrTelefone3,
            this.nrTelefone4,
            this.nrCelular,
            this.dtCadastro,
            this.dtNascimento});
            this.eB_ClienteDataGridView.DataSource = this.eB_ClienteBindingSource;
            this.eB_ClienteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eB_ClienteDataGridView.Location = new System.Drawing.Point(0, 64);
            this.eB_ClienteDataGridView.MultiSelect = false;
            this.eB_ClienteDataGridView.Name = "eB_ClienteDataGridView";
            this.eB_ClienteDataGridView.ReadOnly = true;
            this.eB_ClienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eB_ClienteDataGridView.Size = new System.Drawing.Size(894, 483);
            this.eB_ClienteDataGridView.TabIndex = 3;
            // 
            // ClienteID
            // 
            this.ClienteID.DataPropertyName = "ClienteID";
            this.ClienteID.HeaderText = "Cód";
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            this.ClienteID.Width = 51;
            // 
            // dsNome
            // 
            this.dsNome.DataPropertyName = "dsNome";
            this.dsNome.HeaderText = "Nome ";
            this.dsNome.Name = "dsNome";
            this.dsNome.ReadOnly = true;
            this.dsNome.Width = 63;
            // 
            // dsLogradouro
            // 
            this.dsLogradouro.DataPropertyName = "dsLogradouro";
            this.dsLogradouro.HeaderText = "Endereço";
            this.dsLogradouro.Name = "dsLogradouro";
            this.dsLogradouro.ReadOnly = true;
            this.dsLogradouro.Width = 78;
            // 
            // nrTelefone1
            // 
            this.nrTelefone1.DataPropertyName = "nrTelefone1";
            this.nrTelefone1.HeaderText = "Tel.  1";
            this.nrTelefone1.Name = "nrTelefone1";
            this.nrTelefone1.ReadOnly = true;
            this.nrTelefone1.Width = 62;
            // 
            // nrTelefone2
            // 
            this.nrTelefone2.DataPropertyName = "nrTelefone2";
            this.nrTelefone2.HeaderText = "Tel.  2";
            this.nrTelefone2.Name = "nrTelefone2";
            this.nrTelefone2.ReadOnly = true;
            this.nrTelefone2.Width = 62;
            // 
            // nrTelefone3
            // 
            this.nrTelefone3.DataPropertyName = "nrTelefone3";
            this.nrTelefone3.HeaderText = "Tel.  3";
            this.nrTelefone3.Name = "nrTelefone3";
            this.nrTelefone3.ReadOnly = true;
            this.nrTelefone3.Width = 62;
            // 
            // nrTelefone4
            // 
            this.nrTelefone4.DataPropertyName = "nrTelefone4";
            this.nrTelefone4.HeaderText = "Tel.  4";
            this.nrTelefone4.Name = "nrTelefone4";
            this.nrTelefone4.ReadOnly = true;
            this.nrTelefone4.Width = 62;
            // 
            // nrCelular
            // 
            this.nrCelular.DataPropertyName = "nrCelular";
            this.nrCelular.HeaderText = "Celular";
            this.nrCelular.Name = "nrCelular";
            this.nrCelular.ReadOnly = true;
            this.nrCelular.Width = 64;
            // 
            // dtCadastro
            // 
            this.dtCadastro.DataPropertyName = "dtCadastro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtCadastro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtCadastro.HeaderText = "Dt. Cadastro";
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.ReadOnly = true;
            this.dtCadastro.Width = 91;
            // 
            // dtNascimento
            // 
            this.dtNascimento.DataPropertyName = "dtNascimento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtNascimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtNascimento.HeaderText = "Dt. Nasc";
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.ReadOnly = true;
            this.dtNascimento.Width = 74;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(894, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // backgroundWorkerCliente
            // 
            this.backgroundWorkerCliente.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCliente_DoWork);
            this.backgroundWorkerCliente.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerCliente_ProgressChanged);
            this.backgroundWorkerCliente.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCliente_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 4;
            // 
            // backgroundWorkerBusca
            // 
            this.backgroundWorkerBusca.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerBusca_DoWork);
            // 
            // frmClienteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eB_ClienteDataGridView);
            this.Controls.Add(this.eB_ClienteBindingNavigator);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "frmClienteList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Clientes cadastrados";
            this.TopMost = false;
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClienteList_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteBindingNavigator)).EndInit();
            this.eB_ClienteBindingNavigator.ResumeLayout(false);
            this.eB_ClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.ToolStripButton toolStripAlterar;
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.BindingSource eB_ClienteBindingSource;
        private System.Windows.Forms.BindingNavigator eB_ClienteBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.DataGridView eB_ClienteDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefone3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefone4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascimento;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCliente;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBusca;
    }
}