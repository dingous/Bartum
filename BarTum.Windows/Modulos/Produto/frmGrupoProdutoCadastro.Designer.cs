namespace BarTum.Windows.Modulos.Produto
{
    partial class frmGrupoProdutoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupoProdutoCadastro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dsGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrupoID = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.botaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.eB_GrupoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dsdescricaoPai = new System.Windows.Forms.TextBox();
            this.codigoPai = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_GrupoProdutoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.dsGrupo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GrupoID);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do grupo";
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
            // dsGrupo
            // 
            this.dsGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dsGrupo.Location = new System.Drawing.Point(9, 84);
            this.dsGrupo.Name = "dsGrupo";
            this.dsGrupo.Size = new System.Drawing.Size(457, 20);
            this.dsGrupo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome do grupo";
            // 
            // GrupoID
            // 
            this.GrupoID.BackColor = System.Drawing.Color.AntiqueWhite;
            this.GrupoID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GrupoID.Location = new System.Drawing.Point(6, 35);
            this.GrupoID.Name = "GrupoID";
            this.GrupoID.ReadOnly = true;
            this.GrupoID.Size = new System.Drawing.Size(60, 20);
            this.GrupoID.TabIndex = 18;
            this.GrupoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoCancelar,
            this.botaoSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 214);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(510, 39);
            this.toolStrip1.TabIndex = 11;
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
            // eB_GrupoProdutoBindingSource
            // 
            this.eB_GrupoProdutoBindingSource.DataSource = typeof(BarTum.Entities.EB_GrupoProduto);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dsdescricaoPai);
            this.groupBox3.Controls.Add(this.codigoPai);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 63);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agrupar pelo grupo";
            // 
            // dsdescricaoPai
            // 
            this.dsdescricaoPai.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dsdescricaoPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dsdescricaoPai.Location = new System.Drawing.Point(97, 34);
            this.dsdescricaoPai.Name = "dsdescricaoPai";
            this.dsdescricaoPai.ReadOnly = true;
            this.dsdescricaoPai.Size = new System.Drawing.Size(366, 20);
            this.dsdescricaoPai.TabIndex = 51;
            // 
            // codigoPai
            // 
            this.codigoPai.Location = new System.Drawing.Point(6, 34);
            this.codigoPai.Name = "codigoPai";
            this.codigoPai.Size = new System.Drawing.Size(56, 20);
            this.codigoPai.TabIndex = 50;
            this.codigoPai.ValueChanged += new System.EventHandler(this.codigoPai_ValueChanged);
            // 
            // button3
            // 
            this.button3.Image = global::BarTum.Windows.Properties.Resources.search;
            this.button3.Location = new System.Drawing.Point(64, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 27);
            this.button3.TabIndex = 41;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrição do grupo";
            // 
            // frmGrupoProdutoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 253);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrupoProdutoCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar/Alterar grupos";
            this.Load += new System.EventHandler(this.frmGrupoProdutoCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eB_GrupoProdutoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox dsGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GrupoID;
        private System.Windows.Forms.BindingSource eB_GrupoProdutoBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripButton botaoSalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.NumericUpDown codigoPai;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dsdescricaoPai;
    }
}