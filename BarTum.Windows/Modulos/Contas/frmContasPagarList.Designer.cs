namespace BarTum.Windows.Modulos.Contas
{
    partial class frmContasPagarList
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ComboExibir = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ComboTipoBusca = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DtInicial = new System.Windows.Forms.DateTimePicker();
            this.DtFinal = new System.Windows.Forms.DateTimePicker();
            this.eB_ContasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.eB_ContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxPaginacao = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.eB_ContasDataGridView = new System.Windows.Forms.DataGridView();
            this.contasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsNomeFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPlanoContas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlancto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPagamentoOuRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TotalPagos = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.totalAPagar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ContasBindingNavigator)).BeginInit();
            this.eB_ContasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ContasBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ContasDataGridView)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ComboExibir,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.ComboTipoBusca,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 39);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Exibir: ";
            // 
            // ComboExibir
            // 
            this.ComboExibir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.ComboExibir.AutoSize = false;
            this.ComboExibir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboExibir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ComboExibir.Items.AddRange(new object[] {
            "EM ABERTO",
            "PAGO",
            "TODAS"});
            this.ComboExibir.Name = "ComboExibir";
            this.ComboExibir.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(20, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel2.Text = "Buscar por: ";
            // 
            // ComboTipoBusca
            // 
            this.ComboTipoBusca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.ComboTipoBusca.AutoSize = false;
            this.ComboTipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoBusca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ComboTipoBusca.Items.AddRange(new object[] {
            "DT. VENCIMENTO",
            "DT. LANÇAMENTO",
            "DT. PAGAMENTO",
            "TODOS OS CAMPOS"});
            this.ComboTipoBusca.Name = "ComboTipoBusca";
            this.ComboTipoBusca.Size = new System.Drawing.Size(135, 23);
            this.ComboTipoBusca.SelectedIndexChanged += new System.EventHandler(this.ComboTipoBusca_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(20, 25);
            // 
            // DtInicial
            // 
            this.DtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtInicial.Location = new System.Drawing.Point(605, 7);
            this.DtInicial.Name = "DtInicial";
            this.DtInicial.Size = new System.Drawing.Size(95, 20);
            this.DtInicial.TabIndex = 2;
            // 
            // DtFinal
            // 
            this.DtFinal.CustomFormat = "dd/MM/yyyy";
            this.DtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFinal.Location = new System.Drawing.Point(605, 7);
            this.DtFinal.Name = "DtFinal";
            this.DtFinal.Size = new System.Drawing.Size(95, 20);
            this.DtFinal.TabIndex = 3;
            // 
            // eB_ContasBindingNavigator
            // 
            this.eB_ContasBindingNavigator.AddNewItem = null;
            this.eB_ContasBindingNavigator.BindingSource = this.eB_ContasBindingSource;
            this.eB_ContasBindingNavigator.CountItem = null;
            this.eB_ContasBindingNavigator.DeleteItem = null;
            this.eB_ContasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.eB_ContasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.ComboBoxPaginacao});
            this.eB_ContasBindingNavigator.Location = new System.Drawing.Point(0, 64);
            this.eB_ContasBindingNavigator.MoveFirstItem = null;
            this.eB_ContasBindingNavigator.MoveLastItem = null;
            this.eB_ContasBindingNavigator.MoveNextItem = null;
            this.eB_ContasBindingNavigator.MovePreviousItem = null;
            this.eB_ContasBindingNavigator.Name = "eB_ContasBindingNavigator";
            this.eB_ContasBindingNavigator.PositionItem = null;
            this.eB_ContasBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.eB_ContasBindingNavigator.TabIndex = 9;
            this.eB_ContasBindingNavigator.Text = "bindingNavigator1";
            // 
            // eB_ContasBindingSource
            // 
            this.eB_ContasBindingSource.DataSource = typeof(BarTum.Entities.EB_Contas);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel3.Text = "Paginação:   ";
            // 
            // ComboBoxPaginacao
            // 
            this.ComboBoxPaginacao.AutoSize = false;
            this.ComboBoxPaginacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPaginacao.Name = "ComboBoxPaginacao";
            this.ComboBoxPaginacao.Size = new System.Drawing.Size(35, 23);
            this.ComboBoxPaginacao.ToolTipText = "Paginação";
            this.ComboBoxPaginacao.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPaginacao_SelectedIndexChanged);
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
            this.toolStrip1.Size = new System.Drawing.Size(784, 39);
            this.toolStrip1.TabIndex = 5;
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
            this.toolStripExcluir.Click += new System.EventHandler(this.toolStripExcluir_Click);
            // 
            // eB_ContasDataGridView
            // 
            this.eB_ContasDataGridView.AllowUserToAddRows = false;
            this.eB_ContasDataGridView.AllowUserToDeleteRows = false;
            this.eB_ContasDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eB_ContasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.eB_ContasDataGridView.AutoGenerateColumns = false;
            this.eB_ContasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.eB_ContasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.eB_ContasDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eB_ContasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eB_ContasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contasID,
            this.descricao,
            this.vlConta,
            this.vlPago,
            this.dsNomeFornecedor,
            this.dsPlanoContas,
            this.Situacao,
            this.dtlancto,
            this.dtVencimento,
            this.dtPagamentoOuRecebimento});
            this.eB_ContasDataGridView.DataSource = this.eB_ContasBindingSource;
            this.eB_ContasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eB_ContasDataGridView.Location = new System.Drawing.Point(0, 89);
            this.eB_ContasDataGridView.MultiSelect = false;
            this.eB_ContasDataGridView.Name = "eB_ContasDataGridView";
            this.eB_ContasDataGridView.ReadOnly = true;
            this.eB_ContasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eB_ContasDataGridView.Size = new System.Drawing.Size(784, 434);
            this.eB_ContasDataGridView.StandardTab = true;
            this.eB_ContasDataGridView.TabIndex = 17;
            // 
            // contasID
            // 
            this.contasID.DataPropertyName = "contasID";
            this.contasID.HeaderText = "Cód.";
            this.contasID.Name = "contasID";
            this.contasID.ReadOnly = true;
            this.contasID.Width = 54;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 80;
            // 
            // vlConta
            // 
            this.vlConta.DataPropertyName = "vlConta";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.vlConta.DefaultCellStyle = dataGridViewCellStyle2;
            this.vlConta.HeaderText = "Valor da Conta";
            this.vlConta.Name = "vlConta";
            this.vlConta.ReadOnly = true;
            this.vlConta.Width = 94;
            // 
            // vlPago
            // 
            this.vlPago.DataPropertyName = "vlPago";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "R$ 0,00";
            this.vlPago.DefaultCellStyle = dataGridViewCellStyle3;
            this.vlPago.HeaderText = "Valor Pago";
            this.vlPago.Name = "vlPago";
            this.vlPago.ReadOnly = true;
            this.vlPago.Width = 78;
            // 
            // dsNomeFornecedor
            // 
            this.dsNomeFornecedor.DataPropertyName = "dsNomeFornecedor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dsNomeFornecedor.DefaultCellStyle = dataGridViewCellStyle4;
            this.dsNomeFornecedor.HeaderText = "Fornecedor";
            this.dsNomeFornecedor.Name = "dsNomeFornecedor";
            this.dsNomeFornecedor.ReadOnly = true;
            this.dsNomeFornecedor.Width = 86;
            // 
            // dsPlanoContas
            // 
            this.dsPlanoContas.DataPropertyName = "dsPlanoContas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dsPlanoContas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dsPlanoContas.HeaderText = "Plano de Contas";
            this.dsPlanoContas.Name = "dsPlanoContas";
            this.dsPlanoContas.ReadOnly = true;
            this.dsPlanoContas.Width = 101;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "situacao";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Situacao.DefaultCellStyle = dataGridViewCellStyle6;
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 74;
            // 
            // dtlancto
            // 
            this.dtlancto.DataPropertyName = "dtlancto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = "-";
            this.dtlancto.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtlancto.HeaderText = "Dt Lançamento";
            this.dtlancto.Name = "dtlancto";
            this.dtlancto.ReadOnly = true;
            this.dtlancto.Width = 97;
            // 
            // dtVencimento
            // 
            this.dtVencimento.DataPropertyName = "dtVencimento";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = "-";
            this.dtVencimento.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtVencimento.HeaderText = "Dt Vencimento";
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.ReadOnly = true;
            this.dtVencimento.Width = 94;
            // 
            // dtPagamentoOuRecebimento
            // 
            this.dtPagamentoOuRecebimento.DataPropertyName = "dtPagamentoOuRecebimento";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = "-";
            this.dtPagamentoOuRecebimento.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtPagamentoOuRecebimento.HeaderText = "Dt Pagamento";
            this.dtPagamentoOuRecebimento.Name = "dtPagamentoOuRecebimento";
            this.dtPagamentoOuRecebimento.ReadOnly = true;
            this.dtPagamentoOuRecebimento.Width = 92;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.botaoCancelar,
            this.toolStripSeparator3,
            this.TotalPagos,
            this.toolStripLabel6,
            this.totalAPagar,
            this.toolStripLabel5});
            this.toolStrip4.Location = new System.Drawing.Point(0, 523);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(784, 39);
            this.toolStrip4.TabIndex = 16;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::BarTum.Windows.Properties.Resources._1300190987_application_x_kgetlist;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(107, 36);
            this.toolStripButton7.Text = "Baixar conta";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.botaoCancelar.Image = global::BarTum.Windows.Properties.Resources._1298495035_close;
            this.botaoCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.botaoCancelar.Size = new System.Drawing.Size(62, 36);
            this.botaoCancelar.Text = "Sair";
            this.botaoCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(30, 25);
            // 
            // TotalPagos
            // 
            this.TotalPagos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TotalPagos.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TotalPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPagos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TotalPagos.Name = "TotalPagos";
            this.TotalPagos.ReadOnly = true;
            this.TotalPagos.Size = new System.Drawing.Size(100, 39);
            this.TotalPagos.Text = "R$ 0,00";
            this.TotalPagos.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(85, 36);
            this.toolStripLabel6.Text = "     Total Pago: ";
            // 
            // totalAPagar
            // 
            this.totalAPagar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.totalAPagar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.totalAPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAPagar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.totalAPagar.Name = "totalAPagar";
            this.totalAPagar.ReadOnly = true;
            this.totalAPagar.Size = new System.Drawing.Size(100, 39);
            this.totalAPagar.Text = "R$ 0,00";
            this.totalAPagar.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(82, 36);
            this.toolStripLabel5.Text = "Total a Pagar: ";
            // 
            // frmContasPagarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.eB_ContasDataGridView);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.eB_ContasBindingNavigator);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContasPagarList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Contas a Pagar";
            this.Load += new System.EventHandler(this.frmContasPagarList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContasPagarList_KeyDown);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ContasBindingNavigator)).EndInit();
            this.eB_ContasBindingNavigator.ResumeLayout(false);
            this.eB_ContasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ContasBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ContasDataGridView)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eB_ContasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.BindingNavigator eB_ContasBindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ComboExibir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox ComboTipoBusca;
        private System.Windows.Forms.ToolStripButton toolStripIncluir;
        private System.Windows.Forms.ToolStripButton toolStripAlterar;
        private System.Windows.Forms.ToolStripButton toolStripConsultar;
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView eB_ContasDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripTextBox TotalPagos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripTextBox totalAPagar;
        private System.Windows.Forms.DateTimePicker DtInicial;
        private System.Windows.Forms.DateTimePicker DtFinal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox ComboBoxPaginacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn contasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsNomeFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsPlanoContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlancto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPagamentoOuRecebimento;

    }
}