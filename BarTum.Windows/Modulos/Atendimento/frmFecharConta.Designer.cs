namespace BarTum.Windows.Modulos.Atendimento
{
    partial class frmFecharConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFecharConta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalStatico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalaPagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescontos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdiantamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.vlrecebido = new System.Windows.Forms.TextBox();
            this.FormaPagamento = new System.Windows.Forms.ComboBox();
            this.eBFormaPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCodCliente = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValoraReceber = new System.Windows.Forms.TextBox();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.BuscarClientes = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.groupBoxEntregador = new System.Windows.Forms.GroupBox();
            this.radioFlPagarEntregador2 = new System.Windows.Forms.RadioButton();
            this.radioFlPagarEntregador = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCliente)).BeginInit();
            this.groupBoxEntregador.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoCancelar,
            this.toolStripSeparator5,
            this.botaoSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 356);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(666, 39);
            this.toolStrip1.TabIndex = 7;
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(122, 36);
            this.botaoSalvar.Text = "Finalizar Venda";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fechando";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 9;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalStatico);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTotalaPagar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDescontos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAdiantamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAcrescimo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTotalVenda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 194);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores da conta";
            // 
            // totalStatico
            // 
            this.totalStatico.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.totalStatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStatico.Location = new System.Drawing.Point(72, 132);
            this.totalStatico.Name = "totalStatico";
            this.totalStatico.ReadOnly = true;
            this.totalStatico.Size = new System.Drawing.Size(10, 26);
            this.totalStatico.TabIndex = 10;
            this.totalStatico.Text = "0,00";
            this.totalStatico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalStatico.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total da conta:";
            // 
            // txtTotalaPagar
            // 
            this.txtTotalaPagar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTotalaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalaPagar.Location = new System.Drawing.Point(133, 159);
            this.txtTotalaPagar.Name = "txtTotalaPagar";
            this.txtTotalaPagar.ReadOnly = true;
            this.txtTotalaPagar.Size = new System.Drawing.Size(110, 26);
            this.txtTotalaPagar.TabIndex = 8;
            this.txtTotalaPagar.Text = "0,00";
            this.txtTotalaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Desconto:";
            // 
            // txtDescontos
            // 
            this.txtDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontos.Location = new System.Drawing.Point(133, 101);
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.Size = new System.Drawing.Size(110, 21);
            this.txtDescontos.TabIndex = 6;
            this.txtDescontos.Text = "0,00";
            this.txtDescontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mask_KeyDown);
            this.txtDescontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_KeyPress);
            this.txtDescontos.Leave += new System.EventHandler(this.DynButton_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adiantamentos:";
            // 
            // txtAdiantamento
            // 
            this.txtAdiantamento.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtAdiantamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdiantamento.Location = new System.Drawing.Point(133, 75);
            this.txtAdiantamento.Name = "txtAdiantamento";
            this.txtAdiantamento.ReadOnly = true;
            this.txtAdiantamento.Size = new System.Drawing.Size(110, 21);
            this.txtAdiantamento.TabIndex = 4;
            this.txtAdiantamento.Text = "0,00";
            this.txtAdiantamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total do serviço:";
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtAcrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcrescimo.Location = new System.Drawing.Point(133, 49);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.ReadOnly = true;
            this.txtAcrescimo.Size = new System.Drawing.Size(110, 21);
            this.txtAcrescimo.TabIndex = 2;
            this.txtAcrescimo.Text = "0,00";
            this.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total consumido:";
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(133, 23);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.ReadOnly = true;
            this.txtTotalVenda.Size = new System.Drawing.Size(110, 21);
            this.txtTotalVenda.TabIndex = 0;
            this.txtTotalVenda.Text = "0,00";
            this.txtTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(285, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 194);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor Recebido (Forma de pagamento)";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.vlrecebido);
            this.panel1.Controls.Add(this.FormaPagamento);
            this.panel1.Location = new System.Drawing.Point(5, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 171);
            this.panel1.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Valor recebido:";
            // 
            // vlrecebido
            // 
            this.vlrecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlrecebido.Location = new System.Drawing.Point(29, 119);
            this.vlrecebido.Name = "vlrecebido";
            this.vlrecebido.Size = new System.Drawing.Size(186, 35);
            this.vlrecebido.TabIndex = 11;
            this.vlrecebido.Text = "0,00";
            this.vlrecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vlrecebido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mask_KeyDown);
            this.vlrecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_KeyPress);
            this.vlrecebido.Leave += new System.EventHandler(this.DynButton_Leave);
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.DataSource = this.eBFormaPagamentoBindingSource;
            this.FormaPagamento.DisplayMember = "dsForma";
            this.FormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaPagamento.FormattingEnabled = true;
            this.FormaPagamento.Location = new System.Drawing.Point(6, 12);
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.Size = new System.Drawing.Size(233, 21);
            this.FormaPagamento.TabIndex = 42;
            this.FormaPagamento.ValueMember = "FormaPagamentoID";
            this.FormaPagamento.SelectedIndexChanged += new System.EventHandler(this.FormaPagamento_SelectedIndexChanged);
            // 
            // eBFormaPagamentoBindingSource
            // 
            this.eBFormaPagamentoBindingSource.DataSource = typeof(BarTum.Entities.EB_FormaPagamento);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCodCliente);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtValoraReceber);
            this.groupBox3.Controls.Add(this.dtVencimento);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtNomeCliente);
            this.groupBox3.Controls.Add(this.BuscarClientes);
            this.groupBox3.Location = new System.Drawing.Point(12, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lançamento no contas a receber";
            this.groupBox3.Visible = false;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(7, 37);
            this.txtCodCliente.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(63, 20);
            this.txtCodCliente.TabIndex = 38;
            this.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCliente.ValueChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Valor a receber:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Data de vencimento:";
            // 
            // txtValoraReceber
            // 
            this.txtValoraReceber.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtValoraReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValoraReceber.Location = new System.Drawing.Point(510, 70);
            this.txtValoraReceber.Name = "txtValoraReceber";
            this.txtValoraReceber.ReadOnly = true;
            this.txtValoraReceber.Size = new System.Drawing.Size(110, 20);
            this.txtValoraReceber.TabIndex = 10;
            this.txtValoraReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtVencimento
            // 
            this.dtVencimento.CustomFormat = "dd/MM/yyyy";
            this.dtVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(113, 70);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(100, 20);
            this.dtVencimento.TabIndex = 13;
            this.dtVencimento.Value = new System.DateTime(2010, 12, 28, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Nome do cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cód.:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(122, 37);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(498, 20);
            this.txtNomeCliente.TabIndex = 35;
            // 
            // BuscarClientes
            // 
            this.BuscarClientes.Image = global::BarTum.Windows.Properties.Resources.search;
            this.BuscarClientes.Location = new System.Drawing.Point(72, 31);
            this.BuscarClientes.Name = "BuscarClientes";
            this.BuscarClientes.Size = new System.Drawing.Size(32, 31);
            this.BuscarClientes.TabIndex = 34;
            this.BuscarClientes.UseVisualStyleBackColor = true;
            this.BuscarClientes.Click += new System.EventHandler(this.BuscarClientes_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(544, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Troco";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(547, 212);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(110, 26);
            this.txtTroco.TabIndex = 10;
            this.txtTroco.Text = "0,00";
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxEntregador
            // 
            this.groupBoxEntregador.Controls.Add(this.radioFlPagarEntregador2);
            this.groupBoxEntregador.Controls.Add(this.radioFlPagarEntregador);
            this.groupBoxEntregador.Enabled = false;
            this.groupBoxEntregador.Location = new System.Drawing.Point(547, 6);
            this.groupBoxEntregador.Name = "groupBoxEntregador";
            this.groupBoxEntregador.Size = new System.Drawing.Size(116, 99);
            this.groupBoxEntregador.TabIndex = 13;
            this.groupBoxEntregador.TabStop = false;
            this.groupBoxEntregador.Text = "Pagamento Entregador";
            this.groupBoxEntregador.Visible = false;
            // 
            // radioFlPagarEntregador2
            // 
            this.radioFlPagarEntregador2.AutoSize = true;
            this.radioFlPagarEntregador2.Checked = true;
            this.radioFlPagarEntregador2.Location = new System.Drawing.Point(11, 63);
            this.radioFlPagarEntregador2.Name = "radioFlPagarEntregador2";
            this.radioFlPagarEntregador2.Size = new System.Drawing.Size(89, 17);
            this.radioFlPagarEntregador2.TabIndex = 1;
            this.radioFlPagarEntregador2.TabStop = true;
            this.radioFlPagarEntregador2.Text = "Pagar Depois";
            this.radioFlPagarEntregador2.UseVisualStyleBackColor = true;
            // 
            // radioFlPagarEntregador
            // 
            this.radioFlPagarEntregador.AutoSize = true;
            this.radioFlPagarEntregador.Location = new System.Drawing.Point(11, 40);
            this.radioFlPagarEntregador.Name = "radioFlPagarEntregador";
            this.radioFlPagarEntregador.Size = new System.Drawing.Size(84, 17);
            this.radioFlPagarEntregador.TabIndex = 0;
            this.radioFlPagarEntregador.Text = "Pagar Agora";
            this.radioFlPagarEntregador.UseVisualStyleBackColor = true;
            // 
            // frmFecharConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 395);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxEntregador);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFecharConta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar Venda";
            this.Load += new System.EventHandler(this.frmFecharConta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFecharConta_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCliente)).EndInit();
            this.groupBoxEntregador.ResumeLayout(false);
            this.groupBoxEntregador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescontos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdiantamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalaPagar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BuscarClientes;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValoraReceber;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox totalStatico;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown txtCodCliente;
        private System.Windows.Forms.GroupBox groupBoxEntregador;
        private System.Windows.Forms.RadioButton radioFlPagarEntregador2;
        private System.Windows.Forms.RadioButton radioFlPagarEntregador;
        private System.Windows.Forms.ComboBox FormaPagamento;
        private System.Windows.Forms.BindingSource eBFormaPagamentoBindingSource;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox vlrecebido;
    }
}