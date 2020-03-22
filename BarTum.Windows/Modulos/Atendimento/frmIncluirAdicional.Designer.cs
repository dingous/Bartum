namespace BarTum.Windows.Modulos.Atendimento
{
    partial class frmIncluirAdicional
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nrQuantidade = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.nrPrecoVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ProdutoID = new System.Windows.Forms.TextBox();
            this.dsProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantidade)).BeginInit();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 129);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(603, 39);
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
            this.botaoSalvar.Image = global::BarTum.Windows.Properties.Resources._1298494929_add1_;
            this.botaoSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(76, 36);
            this.botaoSalvar.Text = "Incluir";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.nrQuantidade);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nrPrecoVenda);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.ProdutoID);
            this.groupBox1.Controls.Add(this.dsProduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Produto";
            // 
            // nrQuantidade
            // 
            this.nrQuantidade.Location = new System.Drawing.Point(133, 74);
            this.nrQuantidade.Name = "nrQuantidade";
            this.nrQuantidade.Size = new System.Drawing.Size(84, 20);
            this.nrQuantidade.TabIndex = 2;
            this.nrQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Image = global::BarTum.Windows.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(83, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nrPrecoVenda
            // 
            this.nrPrecoVenda.Location = new System.Drawing.Point(234, 74);
            this.nrPrecoVenda.Name = "nrPrecoVenda";
            this.nrPrecoVenda.Size = new System.Drawing.Size(92, 20);
            this.nrPrecoVenda.TabIndex = 3;
            this.nrPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nrPrecoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nrPrecoVenda_KeyDown);
            this.nrPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nrPrecoVenda_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(231, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Preço Unitário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Quantidade";
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
            // ProdutoID
            // 
            this.ProdutoID.BackColor = System.Drawing.SystemColors.Window;
            this.ProdutoID.Location = new System.Drawing.Point(6, 35);
            this.ProdutoID.Name = "ProdutoID";
            this.ProdutoID.Size = new System.Drawing.Size(76, 20);
            this.ProdutoID.TabIndex = 1;
            this.ProdutoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ProdutoID.TextChanged += new System.EventHandler(this.ProdutoID_TextChanged);
            // 
            // dsProduto
            // 
            this.dsProduto.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dsProduto.Location = new System.Drawing.Point(132, 35);
            this.dsProduto.Name = "dsProduto";
            this.dsProduto.ReadOnly = true;
            this.dsProduto.Size = new System.Drawing.Size(451, 20);
            this.dsProduto.TabIndex = 9999;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // frmIncluirAdicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 168);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frmIncluirAdicional";
            this.Text = "Incluir adicional";
            this.Load += new System.EventHandler(this.frmIncluirAdicional_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIncluirAdicional_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.NumericUpDown nrQuantidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nrPrecoVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox ProdutoID;
        private System.Windows.Forms.TextBox dsProduto;
        private System.Windows.Forms.Label label1;

    }
}