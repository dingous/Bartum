namespace BarTum.Windows.Modulos.Atendimento
{
    partial class VendaComanda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoBuscarPendentes = new System.Windows.Forms.Button();
            this.flowpanelComandas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComanda = new System.Windows.Forms.TextBox();
            this.contextMenuMesas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuFecharConta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.contextMenuMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoBuscarPendentes);
            this.groupBox1.Controls.Add(this.flowpanelComandas);
            this.groupBox1.Controls.Add(this.btnNovaVenda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxComanda);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda por comanda";
            // 
            // botaoBuscarPendentes
            // 
            this.botaoBuscarPendentes.Image = global::BarTum.Windows.Properties.Resources.search;
            this.botaoBuscarPendentes.Location = new System.Drawing.Point(186, 27);
            this.botaoBuscarPendentes.Name = "botaoBuscarPendentes";
            this.botaoBuscarPendentes.Size = new System.Drawing.Size(32, 30);
            this.botaoBuscarPendentes.TabIndex = 35;
            this.toolTip1.SetToolTip(this.botaoBuscarPendentes, "Buscar  vendas pendentes nas comandas");
            this.botaoBuscarPendentes.UseVisualStyleBackColor = true;
            this.botaoBuscarPendentes.Click += new System.EventHandler(this.botaoBuscarPendentes_Click);
            // 
            // flowpanelComandas
            // 
            this.flowpanelComandas.AutoScroll = true;
            this.flowpanelComandas.Location = new System.Drawing.Point(12, 63);
            this.flowpanelComandas.Name = "flowpanelComandas";
            this.flowpanelComandas.Size = new System.Drawing.Size(978, 106);
            this.flowpanelComandas.TabIndex = 9;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Image = global::BarTum.Windows.Properties.Resources.clients;
            this.btnNovaVenda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovaVenda.Location = new System.Drawing.Point(223, 27);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(155, 33);
            this.btnNovaVenda.TabIndex = 8;
            this.btnNovaVenda.Text = "Nova venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Visible = false;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nr da Comanda";
            // 
            // textBoxComanda
            // 
            this.textBoxComanda.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComanda.ForeColor = System.Drawing.Color.Firebrick;
            this.textBoxComanda.Location = new System.Drawing.Point(8, 27);
            this.textBoxComanda.Name = "textBoxComanda";
            this.textBoxComanda.Size = new System.Drawing.Size(172, 30);
            this.textBoxComanda.TabIndex = 2;
            this.textBoxComanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxComanda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxComanda_KeyDown);
            // 
            // contextMenuMesas
            // 
            this.contextMenuMesas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFecharConta});
            this.contextMenuMesas.Name = "contextMenuMesas";
            this.contextMenuMesas.Size = new System.Drawing.Size(153, 48);
            // 
            // toolStripMenuFecharConta
            // 
            this.toolStripMenuFecharConta.Name = "toolStripMenuFecharConta";
            this.toolStripMenuFecharConta.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuFecharConta.Text = "Fechar conta";
            this.toolStripMenuFecharConta.Click += new System.EventHandler(this.toolStripMenuFecharConta_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // VendaComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "VendaComanda";
            this.Size = new System.Drawing.Size(1005, 182);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuMesas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxComanda;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.FlowLayoutPanel flowpanelComandas;
        public System.Windows.Forms.ContextMenuStrip contextMenuMesas;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuFecharConta;
        private System.Windows.Forms.Button botaoBuscarPendentes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
