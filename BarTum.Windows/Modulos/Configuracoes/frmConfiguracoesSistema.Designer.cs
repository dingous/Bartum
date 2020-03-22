namespace BarTum.Windows.Modulos.Configuracoes
{
    partial class frmConfiguracoesSistema
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panelImpressoras = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboPlanoEstoque = new System.Windows.Forms.ComboBox();
            this.eBPlanoContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboPlanoContas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radiotaxa1 = new System.Windows.Forms.RadioButton();
            this.Radiotaxa = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCabecalho = new System.Windows.Forms.TextBox();
            this.txtRodape = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtCab = new System.Windows.Forms.TextBox();
            this.txtRod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBPlanoContasBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panelImpressoras);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configurações de impressão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECIONE AS IMPRESSORAS QUE ESTARÃO RELACIONADAS AS ORIGENS DOS PRODUTOS";
            // 
            // panelImpressoras
            // 
            this.panelImpressoras.AutoScroll = true;
            this.panelImpressoras.AutoScrollMinSize = new System.Drawing.Size(0, 300);
            this.panelImpressoras.AutoSize = true;
            this.panelImpressoras.Location = new System.Drawing.Point(6, 20);
            this.panelImpressoras.Name = "panelImpressoras";
            this.panelImpressoras.Size = new System.Drawing.Size(656, 300);
            this.panelImpressoras.TabIndex = 0;
            this.panelImpressoras.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImpressoras_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações de vendas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboPlanoEstoque);
            this.groupBox3.Location = new System.Drawing.Point(164, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 52);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plano de contas padrão para os lançamentos no estoque";
            this.groupBox3.Visible = false;
            // 
            // comboPlanoEstoque
            // 
            this.comboPlanoEstoque.DataSource = this.eBPlanoContasBindingSource;
            this.comboPlanoEstoque.DisplayMember = "dsPlanoConta";
            this.comboPlanoEstoque.FormattingEnabled = true;
            this.comboPlanoEstoque.Location = new System.Drawing.Point(6, 20);
            this.comboPlanoEstoque.Name = "comboPlanoEstoque";
            this.comboPlanoEstoque.Size = new System.Drawing.Size(486, 21);
            this.comboPlanoEstoque.TabIndex = 0;
            this.comboPlanoEstoque.ValueMember = "PlanoContaID";
            // 
            // eBPlanoContasBindingSource
            // 
            this.eBPlanoContasBindingSource.DataSource = typeof(BarTum.Entities.EB_PlanoContas);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboPlanoContas);
            this.groupBox2.Location = new System.Drawing.Point(164, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plano de contas padrão para as vendas a prazo";
            this.groupBox2.Visible = false;
            // 
            // comboPlanoContas
            // 
            this.comboPlanoContas.DataSource = this.eBPlanoContasBindingSource;
            this.comboPlanoContas.DisplayMember = "dsPlanoConta";
            this.comboPlanoContas.FormattingEnabled = true;
            this.comboPlanoContas.Location = new System.Drawing.Point(6, 20);
            this.comboPlanoContas.Name = "comboPlanoContas";
            this.comboPlanoContas.Size = new System.Drawing.Size(486, 21);
            this.comboPlanoContas.TabIndex = 0;
            this.comboPlanoContas.ValueMember = "PlanoContaID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radiotaxa1);
            this.groupBox1.Controls.Add(this.Radiotaxa);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taxa de serviço";
            // 
            // Radiotaxa1
            // 
            this.Radiotaxa1.AutoSize = true;
            this.Radiotaxa1.Location = new System.Drawing.Point(69, 21);
            this.Radiotaxa1.Name = "Radiotaxa1";
            this.Radiotaxa1.Size = new System.Drawing.Size(70, 17);
            this.Radiotaxa1.TabIndex = 1;
            this.Radiotaxa1.Text = "Desativar";
            this.Radiotaxa1.UseVisualStyleBackColor = true;
            // 
            // Radiotaxa
            // 
            this.Radiotaxa.AutoSize = true;
            this.Radiotaxa.Checked = true;
            this.Radiotaxa.Location = new System.Drawing.Point(11, 21);
            this.Radiotaxa.Name = "Radiotaxa";
            this.Radiotaxa.Size = new System.Drawing.Size(52, 17);
            this.Radiotaxa.TabIndex = 0;
            this.Radiotaxa.TabStop = true;
            this.Radiotaxa.Text = "Ativar";
            this.Radiotaxa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Imprimir teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 367);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(680, 39);
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
            this.botaoSalvar.Size = new System.Drawing.Size(130, 36);
            this.botaoSalvar.Text = "Salvar alterações";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument2_PrintPage);
            this.printDocument2.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Imprimir teste texto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCabecalho
            // 
            this.txtCabecalho.Location = new System.Drawing.Point(7, 20);
            this.txtCabecalho.Name = "txtCabecalho";
            this.txtCabecalho.Size = new System.Drawing.Size(641, 20);
            this.txtCabecalho.TabIndex = 0;
            // 
            // txtRodape
            // 
            this.txtRodape.Location = new System.Drawing.Point(6, 19);
            this.txtRodape.Name = "txtRodape";
            this.txtRodape.Size = new System.Drawing.Size(642, 20);
            this.txtRodape.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtRod);
            this.tabPage3.Controls.Add(this.txtCab);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(669, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cabeçalho e rodapé de impressão";
            // 
            // txtCab
            // 
            this.txtCab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCab.Location = new System.Drawing.Point(6, 19);
            this.txtCab.Name = "txtCab";
            this.txtCab.Size = new System.Drawing.Size(642, 20);
            this.txtCab.TabIndex = 9;
            // 
            // txtRod
            // 
            this.txtRod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRod.Location = new System.Drawing.Point(6, 60);
            this.txtRod.Name = "txtRod";
            this.txtRod.Size = new System.Drawing.Size(642, 20);
            this.txtRod.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rodapé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cabeçalho";
            // 
            // frmConfiguracoesSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracoesSistema";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações do Sistema";
            this.Load += new System.EventHandler(this.frmConfiguracoesSistema_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConfiguracoesSistema_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eBPlanoContasBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelImpressoras;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.Button button1;
        public System.Drawing.Printing.PrintDocument printDocument1;
        public System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radiotaxa1;
        private System.Windows.Forms.RadioButton Radiotaxa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboPlanoContas;
        private System.Windows.Forms.BindingSource eBPlanoContasBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboPlanoEstoque;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtCabecalho;
        private System.Windows.Forms.TextBox txtRodape;
        private System.Windows.Forms.TextBox txtRod;
        private System.Windows.Forms.TextBox txtCab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}