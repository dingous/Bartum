namespace BarTum.Windows.Modulos.Lancamento
{
    partial class frmLancamentoCadastro
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
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ContasDestDescontoID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vlLancamento = new System.Windows.Forms.TextBox();
            this.comboBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.eBFormaPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioTipo2 = new System.Windows.Forms.RadioButton();
            this.radioTipo1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDtLancto = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.Location = new System.Drawing.Point(6, 44);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(564, 20);
            this.textBoxDescricao.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ContasDestDescontoID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.vlLancamento);
            this.groupBox1.Controls.Add(this.comboBoxFormaPagamento);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDtLancto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDescricao);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do lançamento";
            // 
            // ContasDestDescontoID
            // 
            this.ContasDestDescontoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContasDestDescontoID.Location = new System.Drawing.Point(547, 18);
            this.ContasDestDescontoID.Name = "ContasDestDescontoID";
            this.ContasDestDescontoID.ReadOnly = true;
            this.ContasDestDescontoID.Size = new System.Drawing.Size(24, 20);
            this.ContasDestDescontoID.TabIndex = 28;
            this.ContasDestDescontoID.Tag = "1";
            this.ContasDestDescontoID.Text = "1";
            this.ContasDestDescontoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ContasDestDescontoID.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Valor";
            // 
            // vlLancamento
            // 
            this.vlLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlLancamento.Location = new System.Drawing.Point(439, 155);
            this.vlLancamento.Name = "vlLancamento";
            this.vlLancamento.Size = new System.Drawing.Size(131, 20);
            this.vlLancamento.TabIndex = 26;
            this.vlLancamento.Text = "R$ 0,00";
            this.vlLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vlLancamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mask_KeyDown);
            this.vlLancamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_KeyPress);
            this.vlLancamento.Leave += new System.EventHandler(this.vlLancamento_Leave);
            // 
            // comboBoxFormaPagamento
            // 
            this.comboBoxFormaPagamento.DataSource = this.eBFormaPagamentoBindingSource;
            this.comboBoxFormaPagamento.DisplayMember = "dsForma";
            this.comboBoxFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormaPagamento.FormattingEnabled = true;
            this.comboBoxFormaPagamento.Location = new System.Drawing.Point(9, 155);
            this.comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            this.comboBoxFormaPagamento.Size = new System.Drawing.Size(409, 21);
            this.comboBoxFormaPagamento.TabIndex = 25;
            this.comboBoxFormaPagamento.ValueMember = "FormaPagamentoID";
            // 
            // eBFormaPagamentoBindingSource
            // 
            this.eBFormaPagamentoBindingSource.DataSource = typeof(BarTum.Entities.EB_FormaPagamento);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioTipo2);
            this.groupBox2.Controls.Add(this.radioTipo1);
            this.groupBox2.Location = new System.Drawing.Point(207, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 36);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de lançamento";
            // 
            // radioTipo2
            // 
            this.radioTipo2.AutoSize = true;
            this.radioTipo2.Location = new System.Drawing.Point(209, 13);
            this.radioTipo2.Name = "radioTipo2";
            this.radioTipo2.Size = new System.Drawing.Size(67, 17);
            this.radioTipo2.TabIndex = 1;
            this.radioTipo2.Text = "Despesa";
            this.radioTipo2.UseVisualStyleBackColor = true;
            // 
            // radioTipo1
            // 
            this.radioTipo1.AutoSize = true;
            this.radioTipo1.Checked = true;
            this.radioTipo1.Location = new System.Drawing.Point(101, 13);
            this.radioTipo1.Name = "radioTipo1";
            this.radioTipo1.Size = new System.Drawing.Size(62, 17);
            this.radioTipo1.TabIndex = 0;
            this.radioTipo1.TabStop = true;
            this.radioTipo1.Text = "Receita";
            this.radioTipo1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Forma de pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de lançamento";
            // 
            // textBoxDtLancto
            // 
            this.textBoxDtLancto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDtLancto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textBoxDtLancto.Location = new System.Drawing.Point(9, 93);
            this.textBoxDtLancto.Name = "textBoxDtLancto";
            this.textBoxDtLancto.Size = new System.Drawing.Size(99, 20);
            this.textBoxDtLancto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 232);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(601, 39);
            this.toolStrip1.TabIndex = 4;
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
            this.botaoSalvar.Image = global::BarTum.Windows.Properties.Resources._1298494929_add1_;
            this.botaoSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(76, 36);
            this.botaoSalvar.Text = "Incluir";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // frmLancamentoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 271);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLancamentoCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Créditos ou Débito";
            this.Load += new System.EventHandler(this.frmLancamentoCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker textBoxDtLancto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioTipo2;
        private System.Windows.Forms.RadioButton radioTipo1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        public System.Windows.Forms.ComboBox comboBoxFormaPagamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vlLancamento;
        private System.Windows.Forms.BindingSource eBFormaPagamentoBindingSource;
        private System.Windows.Forms.TextBox ContasDestDescontoID;
    }
}