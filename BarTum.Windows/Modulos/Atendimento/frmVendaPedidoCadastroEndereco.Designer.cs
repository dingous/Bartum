namespace BarTum.Windows.Modulos.Atendimento
{
    partial class frmVendaPedidoCadastroEndereco
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
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxPrincipal = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dsReferencias = new System.Windows.Forms.TextBox();
            this.nrCEP = new System.Windows.Forms.MaskedTextBox();
            this.nrNumero = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.BairroID = new System.Windows.Forms.ComboBox();
            this.eBBairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CidadeID = new System.Windows.Forms.ComboBox();
            this.eBCidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EstadoID = new System.Windows.Forms.ComboBox();
            this.eBEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRegiao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dsComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dsLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBBairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBCidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBEstadoBindingSource)).BeginInit();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 191);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(660, 39);
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
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.checkBoxPrincipal);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dsReferencias);
            this.groupBox2.Controls.Add(this.nrCEP);
            this.groupBox2.Controls.Add(this.nrNumero);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.BairroID);
            this.groupBox2.Controls.Add(this.CidadeID);
            this.groupBox2.Controls.Add(this.EstadoID);
            this.groupBox2.Controls.Add(this.dsRegiao);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dsComplemento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dsLogradouro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 184);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Endereço";
            // 
            // checkBoxPrincipal
            // 
            this.checkBoxPrincipal.AutoSize = true;
            this.checkBoxPrincipal.Location = new System.Drawing.Point(9, 151);
            this.checkBoxPrincipal.Name = "checkBoxPrincipal";
            this.checkBoxPrincipal.Size = new System.Drawing.Size(312, 17);
            this.checkBoxPrincipal.TabIndex = 41;
            this.checkBoxPrincipal.Text = "Definir este endereço como o principal do cliente?";
            this.checkBoxPrincipal.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::BarTum.Windows.Properties.Resources.search;
            this.button2.Location = new System.Drawing.Point(198, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 27);
            this.button2.TabIndex = 40;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dsReferencias
            // 
            this.dsReferencias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dsReferencias.Location = new System.Drawing.Point(283, 116);
            this.dsReferencias.Name = "dsReferencias";
            this.dsReferencias.Size = new System.Drawing.Size(345, 20);
            this.dsReferencias.TabIndex = 9;
            // 
            // nrCEP
            // 
            this.nrCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.nrCEP.Location = new System.Drawing.Point(549, 74);
            this.nrCEP.Mask = "00000-000";
            this.nrCEP.Name = "nrCEP";
            this.nrCEP.Size = new System.Drawing.Size(79, 20);
            this.nrCEP.TabIndex = 6;
            this.nrCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // nrNumero
            // 
            this.nrNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nrNumero.Location = new System.Drawing.Point(310, 34);
            this.nrNumero.Name = "nrNumero";
            this.nrNumero.Size = new System.Drawing.Size(86, 20);
            this.nrNumero.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(280, 100);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "Referências";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(307, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Número";
            // 
            // BairroID
            // 
            this.BairroID.DataSource = this.eBBairroBindingSource;
            this.BairroID.DisplayMember = "dsNome";
            this.BairroID.FormattingEnabled = true;
            this.BairroID.Location = new System.Drawing.Point(9, 74);
            this.BairroID.Name = "BairroID";
            this.BairroID.Size = new System.Drawing.Size(189, 21);
            this.BairroID.TabIndex = 4;
            this.BairroID.ValueMember = "BairroID";
            // 
            // eBBairroBindingSource
            // 
            this.eBBairroBindingSource.DataSource = typeof(BarTum.Entities.EB_Bairro);
            // 
            // CidadeID
            // 
            this.CidadeID.DataSource = this.eBCidadeBindingSource;
            this.CidadeID.DisplayMember = "dsNome";
            this.CidadeID.FormattingEnabled = true;
            this.CidadeID.Location = new System.Drawing.Point(150, 116);
            this.CidadeID.Name = "CidadeID";
            this.CidadeID.Size = new System.Drawing.Size(121, 21);
            this.CidadeID.TabIndex = 8;
            this.CidadeID.ValueMember = "CidadeID";
            // 
            // eBCidadeBindingSource
            // 
            this.eBCidadeBindingSource.DataSource = typeof(BarTum.Entities.EB_Cidade);
            // 
            // EstadoID
            // 
            this.EstadoID.DataSource = this.eBEstadoBindingSource;
            this.EstadoID.DisplayMember = "dsSigla";
            this.EstadoID.FormattingEnabled = true;
            this.EstadoID.Location = new System.Drawing.Point(9, 114);
            this.EstadoID.Name = "EstadoID";
            this.EstadoID.Size = new System.Drawing.Size(121, 21);
            this.EstadoID.TabIndex = 7;
            this.EstadoID.ValueMember = "EstadoID";
            // 
            // eBEstadoBindingSource
            // 
            this.eBEstadoBindingSource.DataSource = typeof(BarTum.Entities.EB_Estado);
            // 
            // dsRegiao
            // 
            this.dsRegiao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dsRegiao.Location = new System.Drawing.Point(239, 73);
            this.dsRegiao.Name = "dsRegiao";
            this.dsRegiao.Size = new System.Drawing.Size(301, 20);
            this.dsRegiao.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Região";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(147, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado";
            // 
            // dsComplemento
            // 
            this.dsComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dsComplemento.Location = new System.Drawing.Point(414, 34);
            this.dsComplemento.Name = "dsComplemento";
            this.dsComplemento.Size = new System.Drawing.Size(212, 20);
            this.dsComplemento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Complemento";
            // 
            // dsLogradouro
            // 
            this.dsLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dsLogradouro.Location = new System.Drawing.Point(9, 34);
            this.dsLogradouro.Name = "dsLogradouro";
            this.dsLogradouro.Size = new System.Drawing.Size(281, 20);
            this.dsLogradouro.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Logradouro";
            // 
            // frmVendaPedidoCadastroEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 230);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendaPedidoCadastroEndereco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de endereços para entrega";
            this.Load += new System.EventHandler(this.frmVendaPedidoCadastroEndereco_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBBairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBCidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBEstadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dsReferencias;
        private System.Windows.Forms.MaskedTextBox nrCEP;
        private System.Windows.Forms.TextBox nrNumero;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox BairroID;
        private System.Windows.Forms.ComboBox CidadeID;
        private System.Windows.Forms.ComboBox EstadoID;
        private System.Windows.Forms.TextBox dsRegiao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dsComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dsLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource eBBairroBindingSource;
        private System.Windows.Forms.BindingSource eBCidadeBindingSource;
        private System.Windows.Forms.BindingSource eBEstadoBindingSource;
        private System.Windows.Forms.CheckBox checkBoxPrincipal;
    }
}