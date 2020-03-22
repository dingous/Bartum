namespace BarTum.Windows.Modulos.Banco
{
    partial class frmBancoCadastro
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
            this.txtNrTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtDtCadastro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeGerente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdtReferencia = new System.Windows.Forms.DateTimePicker();
            this.txtDsDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNrContaNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContaID = new System.Windows.Forms.TextBox();
            this.eBCidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.eBBairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBCidadeBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBBairroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtNrTelefone);
            this.groupBox1.Controls.Add(this.txtDtCadastro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNomeGerente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAgencia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLimite);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSaldoInicial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdtReferencia);
            this.groupBox1.Controls.Add(this.txtDsDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtNrContaNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtContaID);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 217);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da conta corrente";
            // 
            // txtNrTelefone
            // 
            this.txtNrTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtNrTelefone.Location = new System.Drawing.Point(9, 180);
            this.txtNrTelefone.Mask = "(34) 0000-0000";
            this.txtNrTelefone.Name = "txtNrTelefone";
            this.txtNrTelefone.Size = new System.Drawing.Size(95, 20);
            this.txtNrTelefone.TabIndex = 8;
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDtCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDtCadastro.Location = new System.Drawing.Point(517, 36);
            this.txtDtCadastro.Name = "txtDtCadastro";
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
            // txtNomeGerente
            // 
            this.txtNomeGerente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeGerente.Location = new System.Drawing.Point(309, 135);
            this.txtNomeGerente.Name = "txtNomeGerente";
            this.txtNomeGerente.Size = new System.Drawing.Size(311, 20);
            this.txtNomeGerente.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Gerente";
            // 
            // txtAgencia
            // 
            this.txtAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgencia.Location = new System.Drawing.Point(9, 135);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(286, 20);
            this.txtAgencia.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Agência";
            // 
            // txtLimite
            // 
            this.txtLimite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLimite.Location = new System.Drawing.Point(471, 83);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(149, 20);
            this.txtLimite.TabIndex = 5;
            this.txtLimite.Text = "0,00";
            this.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mask_KeyDown);
            this.txtLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_KeyPress);
            this.txtLimite.Leave += new System.EventHandler(this.txtLimite_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Limite";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldoInicial.Location = new System.Drawing.Point(309, 83);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(149, 20);
            this.txtSaldoInicial.TabIndex = 4;
            this.txtSaldoInicial.Text = "0,00";
            this.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaldoInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mask_KeyDown);
            this.txtSaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask_KeyPress);
            this.txtSaldoInicial.Leave += new System.EventHandler(this.txtSaldoInicial_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Saldo Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Data referência";
            // 
            // txtdtReferencia
            // 
            this.txtdtReferencia.CustomFormat = "dd/MM/yyyy";
            this.txtdtReferencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdtReferencia.Location = new System.Drawing.Point(195, 83);
            this.txtdtReferencia.Name = "txtdtReferencia";
            this.txtdtReferencia.Size = new System.Drawing.Size(100, 20);
            this.txtdtReferencia.TabIndex = 3;
            this.txtdtReferencia.Value = new System.DateTime(2010, 12, 28, 0, 0, 0, 0);
            // 
            // txtDsDescricao
            // 
            this.txtDsDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDsDescricao.Location = new System.Drawing.Point(80, 36);
            this.txtDsDescricao.Name = "txtDsDescricao";
            this.txtDsDescricao.Size = new System.Drawing.Size(422, 20);
            this.txtDsDescricao.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefone";
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
            // txtNrContaNumero
            // 
            this.txtNrContaNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNrContaNumero.Location = new System.Drawing.Point(9, 83);
            this.txtNrContaNumero.Name = "txtNrContaNumero";
            this.txtNrContaNumero.Size = new System.Drawing.Size(175, 20);
            this.txtNrContaNumero.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nº Conta";
            // 
            // txtContaID
            // 
            this.txtContaID.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtContaID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContaID.Location = new System.Drawing.Point(6, 35);
            this.txtContaID.Name = "txtContaID";
            this.txtContaID.ReadOnly = true;
            this.txtContaID.Size = new System.Drawing.Size(60, 20);
            this.txtContaID.TabIndex = 100000;
            // 
            // eBCidadeBindingSource
            // 
            this.eBCidadeBindingSource.DataSource = typeof(BarTum.Entities.EB_Cidade);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoCancelar,
            this.botaoSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 230);
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
            // eBBairroBindingSource
            // 
            this.eBBairroBindingSource.DataSource = typeof(BarTum.Entities.EB_Bairro);
            // 
            // frmBancoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 269);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBancoCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de contas";
            this.Load += new System.EventHandler(this.frmBairroCadastro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBancoCadastro_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBCidadeBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBBairroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNrContaNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContaID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.BindingSource eBCidadeBindingSource;
        private System.Windows.Forms.BindingSource eBBairroBindingSource;
        private System.Windows.Forms.TextBox txtDsDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtdtReferencia;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDtCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeGerente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtNrTelefone;
    }
}