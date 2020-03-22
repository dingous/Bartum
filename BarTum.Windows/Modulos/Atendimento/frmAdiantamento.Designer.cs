namespace BarTum.Windows.Modulos.Atendimento
{
    partial class frmAdiantamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdiantamento));
            this.label1 = new System.Windows.Forms.Label();
            this.valorTotalVenda = new System.Windows.Forms.TextBox();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.FormaPagamento = new System.Windows.Forms.ComboBox();
            this.eBFormaPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vlPagamento = new System.Windows.Forms.TextBox();
            this.vlrecebido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vlTroco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.observacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCliente)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor total a pagar:";
            // 
            // valorTotalVenda
            // 
            this.valorTotalVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.valorTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalVenda.Location = new System.Drawing.Point(112, 4);
            this.valorTotalVenda.Name = "valorTotalVenda";
            this.valorTotalVenda.ReadOnly = true;
            this.valorTotalVenda.Size = new System.Drawing.Size(170, 30);
            this.valorTotalVenda.TabIndex = 1;
            this.valorTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.groupBox3.Location = new System.Drawing.Point(8, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lançamento no contas a receber";
            this.groupBox3.Visible = false;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(7, 37);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(69, 20);
            this.txtCodCliente.TabIndex = 51;
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
            this.txtValoraReceber.Size = new System.Drawing.Size(84, 20);
            this.txtValoraReceber.TabIndex = 10;
            this.txtValoraReceber.Text = "0,00";
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
            this.dtVencimento.Value = new System.DateTime(2011, 2, 24, 0, 0, 0, 0);
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
            this.txtNomeCliente.Size = new System.Drawing.Size(472, 20);
            this.txtNomeCliente.TabIndex = 35;
            // 
            // BuscarClientes
            // 
            this.BuscarClientes.Image = global::BarTum.Windows.Properties.Resources.search;
            this.BuscarClientes.Location = new System.Drawing.Point(79, 31);
            this.BuscarClientes.Name = "BuscarClientes";
            this.BuscarClientes.Size = new System.Drawing.Size(32, 31);
            this.BuscarClientes.TabIndex = 34;
            this.BuscarClientes.UseVisualStyleBackColor = true;
            this.BuscarClientes.Click += new System.EventHandler(this.BuscarClientes_Click);
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 302);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(608, 39);
            this.toolStrip1.TabIndex = 39;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Image = global::BarTum.Windows.Properties.Resources._1298495035_close1;
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
            this.botaoSalvar.Size = new System.Drawing.Size(157, 36);
            this.botaoSalvar.Text = "Confirma Pagamento";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.DataSource = this.eBFormaPagamentoBindingSource;
            this.FormaPagamento.DisplayMember = "dsForma";
            this.FormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaPagamento.FormattingEnabled = true;
            this.FormaPagamento.Location = new System.Drawing.Point(15, 68);
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.Size = new System.Drawing.Size(219, 21);
            this.FormaPagamento.TabIndex = 40;
            this.FormaPagamento.ValueMember = "FormaPagamentoID";
            this.FormaPagamento.SelectedIndexChanged += new System.EventHandler(this.FormaPagamento_SelectedIndexChanged);
            // 
            // eBFormaPagamentoBindingSource
            // 
            this.eBFormaPagamentoBindingSource.DataSource = typeof(BarTum.Entities.EB_FormaPagamento);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Forma de pagamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Valor pagamento";
            // 
            // vlPagamento
            // 
            this.vlPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlPagamento.Location = new System.Drawing.Point(280, 68);
            this.vlPagamento.Name = "vlPagamento";
            this.vlPagamento.Size = new System.Drawing.Size(122, 20);
            this.vlPagamento.TabIndex = 43;
            this.vlPagamento.Text = "0,00";
            this.vlPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vlPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mask_KeyDown);
            this.vlPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_KeyPress);
            this.vlPagamento.Leave += new System.EventHandler(this.DynButton_Leave);
            // 
            // vlrecebido
            // 
            this.vlrecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlrecebido.Location = new System.Drawing.Point(280, 121);
            this.vlrecebido.Name = "vlrecebido";
            this.vlrecebido.Size = new System.Drawing.Size(122, 20);
            this.vlrecebido.TabIndex = 45;
            this.vlrecebido.Text = "0,00";
            this.vlrecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vlrecebido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mask_KeyDown);
            this.vlrecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_KeyPress);
            this.vlrecebido.Leave += new System.EventHandler(this.DynButton_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Valor recebido";
            // 
            // vlTroco
            // 
            this.vlTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlTroco.Location = new System.Drawing.Point(280, 173);
            this.vlTroco.Name = "vlTroco";
            this.vlTroco.ReadOnly = true;
            this.vlTroco.Size = new System.Drawing.Size(122, 20);
            this.vlTroco.TabIndex = 47;
            this.vlTroco.Text = "0,00";
            this.vlTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vlTroco.Leave += new System.EventHandler(this.DynButton_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Troco";
            // 
            // observacao
            // 
            this.observacao.Location = new System.Drawing.Point(15, 133);
            this.observacao.Multiline = true;
            this.observacao.Name = "observacao";
            this.observacao.Size = new System.Drawing.Size(219, 60);
            this.observacao.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Observação (Opcional)";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(407, 66);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 50;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(466, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 106);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Divisão por pessoa";
            this.groupBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Nr. Ocupantes";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(8, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 55;
            this.textBox2.Text = "R$ 0,00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Valor dividido";
            // 
            // frmAdiantamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 341);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.observacao);
            this.Controls.Add(this.vlTroco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vlrecebido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vlPagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FormaPagamento);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.valorTotalVenda);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "frmAdiantamento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento Parcial";
            this.Load += new System.EventHandler(this.frmAdiantamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdiantamento_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCliente)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valorTotalVenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValoraReceber;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button BuscarClientes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.ComboBox FormaPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vlPagamento;
        private System.Windows.Forms.TextBox vlrecebido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vlTroco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox observacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource eBFormaPagamentoBindingSource;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.NumericUpDown txtCodCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}