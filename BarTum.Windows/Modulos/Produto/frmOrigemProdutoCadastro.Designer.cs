namespace BarTum.Windows.Modulos.Produto
{
    partial class frmOrigemProdutoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrigemProdutoCadastro));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.OrigemID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dsOrigem = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioimpressao2 = new System.Windows.Forms.RadioButton();
            this.radioimpressao1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioinclusao2 = new System.Windows.Forms.RadioButton();
            this.radioinclusao1 = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoCancelar,
            this.botaoSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 250);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(500, 39);
            this.toolStrip1.TabIndex = 13;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(89, 36);
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(76, 36);
            this.botaoSalvar.Text = "Incluir";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // OrigemID
            // 
            this.OrigemID.BackColor = System.Drawing.Color.AntiqueWhite;
            this.OrigemID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.OrigemID.Location = new System.Drawing.Point(6, 35);
            this.OrigemID.Name = "OrigemID";
            this.OrigemID.ReadOnly = true;
            this.OrigemID.Size = new System.Drawing.Size(60, 20);
            this.OrigemID.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição da origem";
            // 
            // dsOrigem
            // 
            this.dsOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dsOrigem.Location = new System.Drawing.Point(9, 84);
            this.dsOrigem.Name = "dsOrigem";
            this.dsOrigem.Size = new System.Drawing.Size(457, 20);
            this.dsOrigem.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Por padrão imprimir na inclusão do produto na venda?";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.dsOrigem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OrigemID);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 241);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da origem";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioimpressao2);
            this.panel2.Controls.Add(this.radioimpressao1);
            this.panel2.Location = new System.Drawing.Point(6, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 28);
            this.panel2.TabIndex = 24;
            // 
            // radioimpressao2
            // 
            this.radioimpressao2.AutoSize = true;
            this.radioimpressao2.Checked = true;
            this.radioimpressao2.Location = new System.Drawing.Point(53, 5);
            this.radioimpressao2.Name = "radioimpressao2";
            this.radioimpressao2.Size = new System.Drawing.Size(48, 17);
            this.radioimpressao2.TabIndex = 1;
            this.radioimpressao2.TabStop = true;
            this.radioimpressao2.Text = "Não";
            this.radioimpressao2.UseVisualStyleBackColor = true;
            // 
            // radioimpressao1
            // 
            this.radioimpressao1.AutoSize = true;
            this.radioimpressao1.Location = new System.Drawing.Point(4, 5);
            this.radioimpressao1.Name = "radioimpressao1";
            this.radioimpressao1.Size = new System.Drawing.Size(45, 17);
            this.radioimpressao1.TabIndex = 0;
            this.radioimpressao1.Text = "Sim";
            this.radioimpressao1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "A impressora ligado a esta origem é padrão de impressão de ítens da venda?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioinclusao2);
            this.panel1.Controls.Add(this.radioinclusao1);
            this.panel1.Location = new System.Drawing.Point(6, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 28);
            this.panel1.TabIndex = 22;
            // 
            // radioinclusao2
            // 
            this.radioinclusao2.AutoSize = true;
            this.radioinclusao2.Location = new System.Drawing.Point(53, 5);
            this.radioinclusao2.Name = "radioinclusao2";
            this.radioinclusao2.Size = new System.Drawing.Size(48, 17);
            this.radioinclusao2.TabIndex = 1;
            this.radioinclusao2.Text = "Não";
            this.radioinclusao2.UseVisualStyleBackColor = true;
            // 
            // radioinclusao1
            // 
            this.radioinclusao1.AutoSize = true;
            this.radioinclusao1.Checked = true;
            this.radioinclusao1.Location = new System.Drawing.Point(4, 5);
            this.radioinclusao1.Name = "radioinclusao1";
            this.radioinclusao1.Size = new System.Drawing.Size(45, 17);
            this.radioinclusao1.TabIndex = 0;
            this.radioinclusao1.TabStop = true;
            this.radioinclusao1.Text = "Sim";
            this.radioinclusao1.UseVisualStyleBackColor = true;
            // 
            // frmOrigemProdutoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 289);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrigemProdutoCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar/Editar origem de produtos";
            this.Load += new System.EventHandler(this.frmOrigemProdutoCadastro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.TextBox OrigemID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dsOrigem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioinclusao2;
        private System.Windows.Forms.RadioButton radioinclusao1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioimpressao2;
        private System.Windows.Forms.RadioButton radioimpressao1;
        private System.Windows.Forms.Label label2;
    }
}