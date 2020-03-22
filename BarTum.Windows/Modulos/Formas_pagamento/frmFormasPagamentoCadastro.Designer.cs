namespace BarTum.Windows.Modulos.Formas_pagamento
{
    partial class frmFormasPagamentoCadastro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCondicaoID = new System.Windows.Forms.ComboBox();
            this.eBFormaPagamentoCondicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioFlMostrarnoContas2 = new System.Windows.Forms.RadioButton();
            this.radioFlMostrarnoContas1 = new System.Windows.Forms.RadioButton();
            this.txtOrdem = new System.Windows.Forms.NumericUpDown();
            this.txtDtCadastro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdsForma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFormaPagamentoID = new System.Windows.Forms.TextBox();
            this.eBFormaPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoCondicaoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.TxtCondicaoID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtOrdem);
            this.groupBox1.Controls.Add(this.txtDtCadastro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdsForma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFormaPagamentoID);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da  forma de pagamento";
            // 
            // TxtCondicaoID
            // 
            this.TxtCondicaoID.DataSource = this.eBFormaPagamentoCondicaoBindingSource;
            this.TxtCondicaoID.DisplayMember = "dsCondicaoPagamento";
            this.TxtCondicaoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCondicaoID.FormattingEnabled = true;
            this.TxtCondicaoID.Location = new System.Drawing.Point(11, 84);
            this.TxtCondicaoID.Name = "TxtCondicaoID";
            this.TxtCondicaoID.Size = new System.Drawing.Size(175, 21);
            this.TxtCondicaoID.TabIndex = 10;
            this.TxtCondicaoID.ValueMember = "CondicaoID";
            // 
            // eBFormaPagamentoCondicaoBindingSource
            // 
            this.eBFormaPagamentoCondicaoBindingSource.DataSource = typeof(BarTum.Entities.EB_FormaPagamentoCondicao);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioFlMostrarnoContas2);
            this.groupBox2.Controls.Add(this.radioFlMostrarnoContas1);
            this.groupBox2.Location = new System.Drawing.Point(329, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 37);
            this.groupBox2.TabIndex = 1000000003;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar no contas?";
            // 
            // radioFlMostrarnoContas2
            // 
            this.radioFlMostrarnoContas2.AutoSize = true;
            this.radioFlMostrarnoContas2.Location = new System.Drawing.Point(170, 14);
            this.radioFlMostrarnoContas2.Name = "radioFlMostrarnoContas2";
            this.radioFlMostrarnoContas2.Size = new System.Drawing.Size(48, 17);
            this.radioFlMostrarnoContas2.TabIndex = 1;
            this.radioFlMostrarnoContas2.Text = "Não";
            this.radioFlMostrarnoContas2.UseVisualStyleBackColor = true;
            // 
            // radioFlMostrarnoContas1
            // 
            this.radioFlMostrarnoContas1.AutoSize = true;
            this.radioFlMostrarnoContas1.Checked = true;
            this.radioFlMostrarnoContas1.Location = new System.Drawing.Point(67, 14);
            this.radioFlMostrarnoContas1.Name = "radioFlMostrarnoContas1";
            this.radioFlMostrarnoContas1.Size = new System.Drawing.Size(45, 17);
            this.radioFlMostrarnoContas1.TabIndex = 0;
            this.radioFlMostrarnoContas1.TabStop = true;
            this.radioFlMostrarnoContas1.Text = "Sim";
            this.radioFlMostrarnoContas1.UseVisualStyleBackColor = true;
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(201, 84);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(100, 20);
            this.txtOrdem.TabIndex = 1000000002;
            this.txtOrdem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDtCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDtCadastro.Location = new System.Drawing.Point(517, 36);
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.ReadOnly = true;
            this.txtDtCadastro.Size = new System.Drawing.Size(103, 20);
            this.txtDtCadastro.TabIndex = 1000000000;
            this.txtDtCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(514, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Data Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ordem";
            // 
            // txtdsForma
            // 
            this.txtdsForma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdsForma.Location = new System.Drawing.Point(80, 36);
            this.txtdsForma.Name = "txtdsForma";
            this.txtdsForma.Size = new System.Drawing.Size(422, 20);
            this.txtdsForma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Descrição";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Condição de pagamento";
            // 
            // txtFormaPagamentoID
            // 
            this.txtFormaPagamentoID.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtFormaPagamentoID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamentoID.Location = new System.Drawing.Point(6, 35);
            this.txtFormaPagamentoID.Name = "txtFormaPagamentoID";
            this.txtFormaPagamentoID.ReadOnly = true;
            this.txtFormaPagamentoID.Size = new System.Drawing.Size(60, 20);
            this.txtFormaPagamentoID.TabIndex = 100000;
            this.txtFormaPagamentoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eBFormaPagamentoBindingSource
            // 
            this.eBFormaPagamentoBindingSource.DataSource = typeof(BarTum.Entities.EB_FormaPagamento);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoCancelar,
            this.botaoSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 128);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(651, 39);
            this.toolStrip1.TabIndex = 8;
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
            // frmFormasPagamentoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 167);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormasPagamentoCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de formas de pagamento";
            this.Load += new System.EventHandler(this.frmBairroCadastro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBancoCadastro_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoCondicaoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBFormaPagamentoBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFormaPagamentoID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.TextBox txtdsForma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDtCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtOrdem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioFlMostrarnoContas2;
        private System.Windows.Forms.RadioButton radioFlMostrarnoContas1;
        private System.Windows.Forms.ComboBox TxtCondicaoID;
        private System.Windows.Forms.BindingSource eBFormaPagamentoBindingSource;
        private System.Windows.Forms.BindingSource eBFormaPagamentoCondicaoBindingSource;
    }
}