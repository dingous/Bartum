namespace BarTum.Windows.Modulos.Atendimento
{
    partial class VendaMesa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxVendaMesa = new System.Windows.Forms.GroupBox();
            this.textBoxOcupantes = new System.Windows.Forms.NumericUpDown();
            this.botaoOcuparMesa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVlServico = new System.Windows.Forms.TextBox();
            this.GarconID = new System.Windows.Forms.ComboBox();
            this.eBGarconBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMesa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuMesas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ocuparMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFecharConta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.botaoBuscarPendentes = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxVendaMesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOcupantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBGarconBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVendaMesa
            // 
            this.groupBoxVendaMesa.Controls.Add(this.botaoBuscarPendentes);
            this.groupBoxVendaMesa.Controls.Add(this.textBoxOcupantes);
            this.groupBoxVendaMesa.Controls.Add(this.botaoOcuparMesa);
            this.groupBoxVendaMesa.Controls.Add(this.label4);
            this.groupBoxVendaMesa.Controls.Add(this.textBoxVlServico);
            this.groupBoxVendaMesa.Controls.Add(this.GarconID);
            this.groupBoxVendaMesa.Controls.Add(this.label3);
            this.groupBoxVendaMesa.Controls.Add(this.label2);
            this.groupBoxVendaMesa.Controls.Add(this.label1);
            this.groupBoxVendaMesa.Controls.Add(this.textBoxMesa);
            this.groupBoxVendaMesa.Location = new System.Drawing.Point(4, 0);
            this.groupBoxVendaMesa.Name = "groupBoxVendaMesa";
            this.groupBoxVendaMesa.Size = new System.Drawing.Size(1004, 58);
            this.groupBoxVendaMesa.TabIndex = 6;
            this.groupBoxVendaMesa.TabStop = false;
            this.groupBoxVendaMesa.Text = "Venda Mesa";
            // 
            // textBoxOcupantes
            // 
            this.textBoxOcupantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOcupantes.Location = new System.Drawing.Point(138, 32);
            this.textBoxOcupantes.Name = "textBoxOcupantes";
            this.textBoxOcupantes.Size = new System.Drawing.Size(75, 20);
            this.textBoxOcupantes.TabIndex = 9;
            this.textBoxOcupantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOcupantes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxOcupantes.Leave += new System.EventHandler(this.textBoxOcupantes_Leave);
            // 
            // botaoOcuparMesa
            // 
            this.botaoOcuparMesa.Image = global::BarTum.Windows.Properties.Resources.clients;
            this.botaoOcuparMesa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botaoOcuparMesa.Location = new System.Drawing.Point(825, 16);
            this.botaoOcuparMesa.Name = "botaoOcuparMesa";
            this.botaoOcuparMesa.Size = new System.Drawing.Size(161, 33);
            this.botaoOcuparMesa.TabIndex = 7;
            this.botaoOcuparMesa.Text = "Ocupar mesa";
            this.botaoOcuparMesa.UseVisualStyleBackColor = true;
            this.botaoOcuparMesa.Click += new System.EventHandler(this.botaoOcuparMesa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor do serviço";
            // 
            // textBoxVlServico
            // 
            this.textBoxVlServico.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxVlServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVlServico.Location = new System.Drawing.Point(639, 32);
            this.textBoxVlServico.Name = "textBoxVlServico";
            this.textBoxVlServico.ReadOnly = true;
            this.textBoxVlServico.Size = new System.Drawing.Size(118, 20);
            this.textBoxVlServico.TabIndex = 6;
            this.textBoxVlServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GarconID
            // 
            this.GarconID.DataSource = this.eBGarconBindingSource;
            this.GarconID.DisplayMember = "dsNome";
            this.GarconID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GarconID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GarconID.FormattingEnabled = true;
            this.GarconID.Location = new System.Drawing.Point(262, 32);
            this.GarconID.Name = "GarconID";
            this.GarconID.Size = new System.Drawing.Size(322, 21);
            this.GarconID.TabIndex = 5;
            this.GarconID.ValueMember = "GarconID";
            this.GarconID.Leave += new System.EventHandler(this.GarconID_Leave);
            // 
            // eBGarconBindingSource
            // 
            this.eBGarconBindingSource.DataSource = typeof(BarTum.Entities.EB_Garcon);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Garçom / Atendente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ocupantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesa ativa";
            // 
            // textBoxMesa
            // 
            this.textBoxMesa.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMesa.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxMesa.Location = new System.Drawing.Point(16, 24);
            this.textBoxMesa.Name = "textBoxMesa";
            this.textBoxMesa.ReadOnly = true;
            this.textBoxMesa.Size = new System.Drawing.Size(75, 30);
            this.textBoxMesa.TabIndex = 0;
            this.textBoxMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(4, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(896, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "   [ ] Fechando   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(798, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "   [ ] Ocupado   ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromName("#cccccc");
            this.label5.Location = new System.Drawing.Point(723, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "   [ ] Livre   ";
            // 
            // contextMenuMesas
            // 
            this.contextMenuMesas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocuparMesaToolStripMenuItem,
            this.toolStripMenuFecharConta,
            this.toolStripMenuItem2});
            this.contextMenuMesas.Name = "contextMenuMesas";
            this.contextMenuMesas.Size = new System.Drawing.Size(156, 70);
            // 
            // ocuparMesaToolStripMenuItem
            // 
            this.ocuparMesaToolStripMenuItem.Name = "ocuparMesaToolStripMenuItem";
            this.ocuparMesaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ocuparMesaToolStripMenuItem.Text = "Ocupar Mesa";
            this.ocuparMesaToolStripMenuItem.Click += new System.EventHandler(this.ocuparMesaToolStripMenuItem_Click);
            // 
            // toolStripMenuFecharConta
            // 
            this.toolStripMenuFecharConta.Name = "toolStripMenuFecharConta";
            this.toolStripMenuFecharConta.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuFecharConta.Text = "Fechar conta";
            this.toolStripMenuFecharConta.Click += new System.EventHandler(this.toolStripMenuFecharConta_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem2.Text = "Transferir Mesa";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // botaoBuscarPendentes
            // 
            this.botaoBuscarPendentes.Image = global::BarTum.Windows.Properties.Resources.search;
            this.botaoBuscarPendentes.Location = new System.Drawing.Point(92, 24);
            this.botaoBuscarPendentes.Name = "botaoBuscarPendentes";
            this.botaoBuscarPendentes.Size = new System.Drawing.Size(32, 30);
            this.botaoBuscarPendentes.TabIndex = 35;
            this.toolTip1.SetToolTip(this.botaoBuscarPendentes, "Buscar  vendas pendentes nas mesas");
            this.botaoBuscarPendentes.UseVisualStyleBackColor = true;
            this.botaoBuscarPendentes.Click += new System.EventHandler(this.botaoBuscarPendentes_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // VendaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxVendaMesa);
            this.Name = "VendaMesa";
            this.Size = new System.Drawing.Size(1011, 183);
            this.Load += new System.EventHandler(this.VendaMesa_Load);
            this.groupBoxVendaMesa.ResumeLayout(false);
            this.groupBoxVendaMesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOcupantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBGarconBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuMesas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVendaMesa;
        private System.Windows.Forms.Button botaoOcuparMesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxMesa;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ContextMenuStrip contextMenuMesas;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuFecharConta;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.BindingSource eBGarconBindingSource;
        public System.Windows.Forms.ComboBox GarconID;
        public System.Windows.Forms.TextBox textBoxVlServico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem ocuparMesaToolStripMenuItem;
        public System.Windows.Forms.NumericUpDown textBoxOcupantes;
        private System.Windows.Forms.Button botaoBuscarPendentes;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
