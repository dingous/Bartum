namespace BarTum.Windows.Modulos.Contas
{
    partial class frmContasPagarCadastro
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
            this.txtContasID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFornecedorID = new System.Windows.Forms.ComboBox();
            this.eBFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtvlConta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiasAtrasados = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vlaPagar = new System.Windows.Forms.TextBox();
            this.comboBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.eBFormaPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtContaCorrente = new System.Windows.Forms.ComboBox();
            this.eBContaCorrenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Radiodescontar2 = new System.Windows.Forms.RadioButton();
            this.Radiodescontar1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaData = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDtVencimento = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.txtdtlancto = new System.Windows.Forms.DateTimePicker();
            this.eBPlanoContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.situacaoRadio2 = new System.Windows.Forms.RadioButton();
            this.situacaoRadio1 = new System.Windows.Forms.RadioButton();
            this.botaoBuscarPendentes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Radiocondicao2 = new System.Windows.Forms.RadioButton();
            this.Radiocondicao1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.eBFornecedorBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBContaCorrenteBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBPlanoContasBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContasID
            // 
            this.txtContasID.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtContasID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContasID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContasID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContasID.Location = new System.Drawing.Point(13, 36);
            this.txtContasID.Name = "txtContasID";
            this.txtContasID.ReadOnly = true;
            this.txtContasID.Size = new System.Drawing.Size(100, 20);
            this.txtContasID.TabIndex = 0;
            this.txtContasID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Duplicata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Lançamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(13, 89);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(646, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fornecedor";
            // 
            // txtFornecedorID
            // 
            this.txtFornecedorID.DataSource = this.eBFornecedorBindingSource;
            this.txtFornecedorID.DisplayMember = "dsNomeFantasia";
            this.txtFornecedorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFornecedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedorID.FormattingEnabled = true;
            this.txtFornecedorID.Location = new System.Drawing.Point(13, 139);
            this.txtFornecedorID.Name = "txtFornecedorID";
            this.txtFornecedorID.Size = new System.Drawing.Size(612, 21);
            this.txtFornecedorID.TabIndex = 8;
            this.txtFornecedorID.ValueMember = "FornecedorID";
            // 
            // eBFornecedorBindingSource
            // 
            this.eBFornecedorBindingSource.DataSource = typeof(BarTum.Entities.EB_Fornecedor);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor da conta";
            // 
            // txtvlConta
            // 
            this.txtvlConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvlConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvlConta.Location = new System.Drawing.Point(13, 193);
            this.txtvlConta.Name = "txtvlConta";
            this.txtvlConta.Size = new System.Drawing.Size(100, 20);
            this.txtvlConta.TabIndex = 9;
            this.txtvlConta.Text = "0,00";
            this.txtvlConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtvlConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mask_KeyDown);
            this.txtvlConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_KeyPress);
            this.txtvlConta.Leave += new System.EventHandler(this.txtvlConta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Vencimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Plano de contas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacoes.Location = new System.Drawing.Point(13, 243);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(646, 72);
            this.txtObservacoes.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDiasAtrasados);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.vlaPagar);
            this.groupBox1.Controls.Add(this.comboBoxFormaPagamento);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtContaCorrente);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFechaData);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(16, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 132);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Pagamento";
            this.groupBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.Image = global::BarTum.Windows.Properties.Resources.search;
            this.button3.Location = new System.Drawing.Point(367, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 29);
            this.button3.TabIndex = 41;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::BarTum.Windows.Properties.Resources.search;
            this.button2.Location = new System.Drawing.Point(611, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 29);
            this.button2.TabIndex = 40;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(537, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Dias de atraso";
            // 
            // txtDiasAtrasados
            // 
            this.txtDiasAtrasados.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDiasAtrasados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasAtrasados.Location = new System.Drawing.Point(537, 97);
            this.txtDiasAtrasados.Name = "txtDiasAtrasados";
            this.txtDiasAtrasados.ReadOnly = true;
            this.txtDiasAtrasados.Size = new System.Drawing.Size(100, 20);
            this.txtDiasAtrasados.TabIndex = 24;
            this.txtDiasAtrasados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(420, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Valor a pagar";
            // 
            // vlaPagar
            // 
            this.vlaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlaPagar.Location = new System.Drawing.Point(420, 97);
            this.vlaPagar.Name = "vlaPagar";
            this.vlaPagar.Size = new System.Drawing.Size(100, 20);
            this.vlaPagar.TabIndex = 19;
            this.vlaPagar.Text = "0,00";
            this.vlaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vlaPagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mask_KeyDown);
            this.vlaPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_KeyPress);
            // 
            // comboBoxFormaPagamento
            // 
            this.comboBoxFormaPagamento.DataSource = this.eBFormaPagamentoBindingSource;
            this.comboBoxFormaPagamento.DisplayMember = "dsForma";
            this.comboBoxFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormaPagamento.FormattingEnabled = true;
            this.comboBoxFormaPagamento.Location = new System.Drawing.Point(11, 96);
            this.comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            this.comboBoxFormaPagamento.Size = new System.Drawing.Size(350, 21);
            this.comboBoxFormaPagamento.TabIndex = 23;
            this.comboBoxFormaPagamento.ValueMember = "FormaPagamentoID";
            // 
            // eBFormaPagamentoBindingSource
            // 
            this.eBFormaPagamentoBindingSource.DataSource = typeof(BarTum.Entities.EB_FormaPagamento);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Forma de pagamento";
            // 
            // txtContaCorrente
            // 
            this.txtContaCorrente.DataSource = this.eBContaCorrenteBindingSource;
            this.txtContaCorrente.DisplayMember = "dsDescricao";
            this.txtContaCorrente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtContaCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaCorrente.FormattingEnabled = true;
            this.txtContaCorrente.Location = new System.Drawing.Point(353, 41);
            this.txtContaCorrente.Name = "txtContaCorrente";
            this.txtContaCorrente.Size = new System.Drawing.Size(255, 21);
            this.txtContaCorrente.TabIndex = 20;
            this.txtContaCorrente.ValueMember = "ContaID";
            // 
            // eBContaCorrenteBindingSource
            // 
            this.eBContaCorrenteBindingSource.DataSource = typeof(BarTum.Entities.EB_ContaCorrente);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Radiodescontar2);
            this.groupBox2.Controls.Add(this.Radiodescontar1);
            this.groupBox2.Location = new System.Drawing.Point(134, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 39);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descontar no";
            // 
            // Radiodescontar2
            // 
            this.Radiodescontar2.AutoSize = true;
            this.Radiodescontar2.Location = new System.Drawing.Point(109, 16);
            this.Radiodescontar2.Name = "Radiodescontar2";
            this.Radiodescontar2.Size = new System.Drawing.Size(56, 17);
            this.Radiodescontar2.TabIndex = 1;
            this.Radiodescontar2.TabStop = true;
            this.Radiodescontar2.Text = "Banco";
            this.Radiodescontar2.UseVisualStyleBackColor = true;
            this.Radiodescontar2.CheckedChanged += new System.EventHandler(this.Radiodescontar2_CheckedChanged);
            // 
            // Radiodescontar1
            // 
            this.Radiodescontar1.AutoSize = true;
            this.Radiodescontar1.Checked = true;
            this.Radiodescontar1.Location = new System.Drawing.Point(41, 16);
            this.Radiodescontar1.Name = "Radiodescontar1";
            this.Radiodescontar1.Size = new System.Drawing.Size(51, 17);
            this.Radiodescontar1.TabIndex = 0;
            this.Radiodescontar1.TabStop = true;
            this.Radiodescontar1.Text = "Caixa";
            this.Radiodescontar1.UseVisualStyleBackColor = true;
            this.Radiodescontar1.Click += new System.EventHandler(this.Radiodescontar1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Selecione uma conta corrente";
            // 
            // txtFechaData
            // 
            this.txtFechaData.CustomFormat = "dd/MM/yyyy";
            this.txtFechaData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtFechaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaData.Location = new System.Drawing.Point(11, 44);
            this.txtFechaData.Name = "txtFechaData";
            this.txtFechaData.Size = new System.Drawing.Size(100, 20);
            this.txtFechaData.TabIndex = 20;
            this.txtFechaData.Value = new System.DateTime(2011, 2, 22, 22, 29, 59, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data Pagamento";
            // 
            // txtDtVencimento
            // 
            this.txtDtVencimento.CustomFormat = "dd/MM/yyyy";
            this.txtDtVencimento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtVencimento.Location = new System.Drawing.Point(150, 193);
            this.txtDtVencimento.Name = "txtDtVencimento";
            this.txtDtVencimento.Size = new System.Drawing.Size(100, 20);
            this.txtDtVencimento.TabIndex = 13;
            this.txtDtVencimento.Value = new System.DateTime(2011, 2, 22, 22, 29, 59, 0);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoCancelar,
            this.botaoSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 506);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(672, 39);
            this.toolStrip1.TabIndex = 32;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Image = global::BarTum.Windows.Properties.Resources._1298495035_close;
            this.botaoCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(89, 36);
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Image = global::BarTum.Windows.Properties.Resources._1298494929_add1_;
            this.botaoSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(76, 36);
            this.botaoSalvar.Text = "Incluir";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // txtdtlancto
            // 
            this.txtdtlancto.CustomFormat = "dd/MM/yyyy";
            this.txtdtlancto.Enabled = false;
            this.txtdtlancto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtdtlancto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdtlancto.Location = new System.Drawing.Point(153, 36);
            this.txtdtlancto.Name = "txtdtlancto";
            this.txtdtlancto.Size = new System.Drawing.Size(100, 20);
            this.txtdtlancto.TabIndex = 33;
            this.txtdtlancto.Value = new System.DateTime(2011, 2, 22, 22, 29, 59, 0);
            // 
            // eBPlanoContasBindingSource
            // 
            this.eBPlanoContasBindingSource.DataSource = typeof(BarTum.Entities.EB_PlanoContas);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.situacaoRadio2);
            this.groupBox3.Controls.Add(this.situacaoRadio1);
            this.groupBox3.Location = new System.Drawing.Point(13, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 39);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação desta conta";
            // 
            // situacaoRadio2
            // 
            this.situacaoRadio2.AutoSize = true;
            this.situacaoRadio2.Location = new System.Drawing.Point(109, 16);
            this.situacaoRadio2.Name = "situacaoRadio2";
            this.situacaoRadio2.Size = new System.Drawing.Size(50, 17);
            this.situacaoRadio2.TabIndex = 1;
            this.situacaoRadio2.TabStop = true;
            this.situacaoRadio2.Text = "Pago";
            this.situacaoRadio2.UseVisualStyleBackColor = true;
            this.situacaoRadio2.Click += new System.EventHandler(this.situacaoRadio2_Click);
            // 
            // situacaoRadio1
            // 
            this.situacaoRadio1.AutoSize = true;
            this.situacaoRadio1.Checked = true;
            this.situacaoRadio1.Location = new System.Drawing.Point(41, 16);
            this.situacaoRadio1.Name = "situacaoRadio1";
            this.situacaoRadio1.Size = new System.Drawing.Size(62, 17);
            this.situacaoRadio1.TabIndex = 0;
            this.situacaoRadio1.TabStop = true;
            this.situacaoRadio1.Text = "A pagar";
            this.situacaoRadio1.UseVisualStyleBackColor = true;
            this.situacaoRadio1.Click += new System.EventHandler(this.radioButton8_Click);
            // 
            // botaoBuscarPendentes
            // 
            this.botaoBuscarPendentes.Image = global::BarTum.Windows.Properties.Resources.search;
            this.botaoBuscarPendentes.Location = new System.Drawing.Point(627, 135);
            this.botaoBuscarPendentes.Name = "botaoBuscarPendentes";
            this.botaoBuscarPendentes.Size = new System.Drawing.Size(31, 29);
            this.botaoBuscarPendentes.TabIndex = 38;
            this.botaoBuscarPendentes.UseVisualStyleBackColor = true;
            this.botaoBuscarPendentes.Click += new System.EventHandler(this.botaoBuscarPendentes_Click);
            // 
            // button1
            // 
            this.button1.Image = global::BarTum.Windows.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(627, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Radiocondicao2);
            this.groupBox4.Controls.Add(this.Radiocondicao1);
            this.groupBox4.Location = new System.Drawing.Point(231, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 39);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Condição de pagamento";
            this.groupBox4.Visible = false;
            // 
            // Radiocondicao2
            // 
            this.Radiocondicao2.AutoSize = true;
            this.Radiocondicao2.Location = new System.Drawing.Point(109, 16);
            this.Radiocondicao2.Name = "Radiocondicao2";
            this.Radiocondicao2.Size = new System.Drawing.Size(73, 17);
            this.Radiocondicao2.TabIndex = 1;
            this.Radiocondicao2.TabStop = true;
            this.Radiocondicao2.Text = "Parcelado";
            this.Radiocondicao2.UseVisualStyleBackColor = true;
            // 
            // Radiocondicao1
            // 
            this.Radiocondicao1.AutoSize = true;
            this.Radiocondicao1.Checked = true;
            this.Radiocondicao1.Location = new System.Drawing.Point(41, 16);
            this.Radiocondicao1.Name = "Radiocondicao1";
            this.Radiocondicao1.Size = new System.Drawing.Size(57, 17);
            this.Radiocondicao1.TabIndex = 0;
            this.Radiocondicao1.TabStop = true;
            this.Radiocondicao1.Text = "A vista";
            this.Radiocondicao1.UseVisualStyleBackColor = true;
            // 
            // frmContasPagarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 545);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoBuscarPendentes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtdtlancto);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDtVencimento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtvlConta);
            this.Controls.Add(this.txtFornecedorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContasID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContasPagarCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar/editar contas a pagar";
            this.Load += new System.EventHandler(this.frmContasPagarCadastro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContasPagarCadastro_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.eBFornecedorBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBContaCorrenteBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBPlanoContasBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContasID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvlConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtFechaData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtDtVencimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Radiodescontar2;
        private System.Windows.Forms.RadioButton Radiodescontar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiasAtrasados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vlaPagar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.DateTimePicker txtdtlancto;
        private System.Windows.Forms.BindingSource eBPlanoContasBindingSource;
        private System.Windows.Forms.BindingSource eBFornecedorBindingSource;
        private System.Windows.Forms.BindingSource eBContaCorrenteBindingSource;
        private System.Windows.Forms.BindingSource eBFormaPagamentoBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton situacaoRadio2;
        private System.Windows.Forms.RadioButton situacaoRadio1;
        private System.Windows.Forms.Button botaoBuscarPendentes;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox txtFornecedorID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Radiocondicao2;
        private System.Windows.Forms.RadioButton Radiocondicao1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox txtContaCorrente;
        public System.Windows.Forms.ComboBox comboBoxFormaPagamento;
        private System.Windows.Forms.Button button3;
    }
}