namespace BarTum.Windows.Modulos.Atendimento
{
    partial class VendaBalcao
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
            this.BalcaoID = new System.Windows.Forms.ComboBox();
            this.eBBalcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.botaoBuscarPendentes = new System.Windows.Forms.Button();
            this.botaoEfetuarVenda = new System.Windows.Forms.Button();
            this.GarconID = new System.Windows.Forms.ComboBox();
            this.eBGarconBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dsNomeClienteBalcao = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxVendaMesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOcupantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBBalcaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBGarconBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVendaMesa
            // 
            this.groupBoxVendaMesa.Controls.Add(this.textBoxOcupantes);
            this.groupBoxVendaMesa.Controls.Add(this.BalcaoID);
            this.groupBoxVendaMesa.Controls.Add(this.label4);
            this.groupBoxVendaMesa.Controls.Add(this.botaoBuscarPendentes);
            this.groupBoxVendaMesa.Controls.Add(this.botaoEfetuarVenda);
            this.groupBoxVendaMesa.Controls.Add(this.GarconID);
            this.groupBoxVendaMesa.Controls.Add(this.label3);
            this.groupBoxVendaMesa.Controls.Add(this.label2);
            this.groupBoxVendaMesa.Controls.Add(this.label1);
            this.groupBoxVendaMesa.Controls.Add(this.dsNomeClienteBalcao);
            this.groupBoxVendaMesa.Location = new System.Drawing.Point(3, 3);
            this.groupBoxVendaMesa.Name = "groupBoxVendaMesa";
            this.groupBoxVendaMesa.Size = new System.Drawing.Size(1004, 109);
            this.groupBoxVendaMesa.TabIndex = 7;
            this.groupBoxVendaMesa.TabStop = false;
            this.groupBoxVendaMesa.Text = "Venda Balcão";
            // 
            // textBoxOcupantes
            // 
            this.textBoxOcupantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOcupantes.Location = new System.Drawing.Point(299, 32);
            this.textBoxOcupantes.Name = "textBoxOcupantes";
            this.textBoxOcupantes.Size = new System.Drawing.Size(104, 20);
            this.textBoxOcupantes.TabIndex = 38;
            this.textBoxOcupantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOcupantes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxOcupantes.Leave += new System.EventHandler(this.textBoxOcupantes_Leave);
            // 
            // BalcaoID
            // 
            this.BalcaoID.DataSource = this.eBBalcaoBindingSource;
            this.BalcaoID.DisplayMember = "dsBalcao";
            this.BalcaoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BalcaoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalcaoID.FormattingEnabled = true;
            this.BalcaoID.Location = new System.Drawing.Point(17, 81);
            this.BalcaoID.Name = "BalcaoID";
            this.BalcaoID.Size = new System.Drawing.Size(262, 21);
            this.BalcaoID.TabIndex = 37;
            this.BalcaoID.ValueMember = "BalcaoID";
            this.BalcaoID.Leave += new System.EventHandler(this.BalcaoID_Leave);
            // 
            // eBBalcaoBindingSource
            // 
            this.eBBalcaoBindingSource.DataSource = typeof(BarTum.Entities.EB_Balcao);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Balcão";
            // 
            // botaoBuscarPendentes
            // 
            this.botaoBuscarPendentes.Image = global::BarTum.Windows.Properties.Resources.search;
            this.botaoBuscarPendentes.Location = new System.Drawing.Point(249, 26);
            this.botaoBuscarPendentes.Name = "botaoBuscarPendentes";
            this.botaoBuscarPendentes.Size = new System.Drawing.Size(32, 30);
            this.botaoBuscarPendentes.TabIndex = 34;
            this.toolTip1.SetToolTip(this.botaoBuscarPendentes, "Buscar  vendas pendentes no balcão");
            this.botaoBuscarPendentes.UseVisualStyleBackColor = true;
            this.botaoBuscarPendentes.Click += new System.EventHandler(this.botaoBuscarPendentes_Click);
            // 
            // botaoEfetuarVenda
            // 
            this.botaoEfetuarVenda.Image = global::BarTum.Windows.Properties.Resources.clients;
            this.botaoEfetuarVenda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.botaoEfetuarVenda.Location = new System.Drawing.Point(794, 20);
            this.botaoEfetuarVenda.Name = "botaoEfetuarVenda";
            this.botaoEfetuarVenda.Size = new System.Drawing.Size(158, 33);
            this.botaoEfetuarVenda.TabIndex = 7;
            this.botaoEfetuarVenda.Text = "Nova venda";
            this.botaoEfetuarVenda.UseVisualStyleBackColor = true;
            this.botaoEfetuarVenda.Click += new System.EventHandler(this.botaoEfetuarVenda_Click);
            // 
            // GarconID
            // 
            this.GarconID.DataSource = this.eBGarconBindingSource;
            this.GarconID.DisplayMember = "dsNome";
            this.GarconID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GarconID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GarconID.FormattingEnabled = true;
            this.GarconID.Location = new System.Drawing.Point(423, 32);
            this.GarconID.Name = "GarconID";
            this.GarconID.Size = new System.Drawing.Size(303, 21);
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
            this.label3.Location = new System.Drawing.Point(420, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Garçom / Atendente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ocupantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do cliente";
            // 
            // dsNomeClienteBalcao
            // 
            this.dsNomeClienteBalcao.BackColor = System.Drawing.SystemColors.Window;
            this.dsNomeClienteBalcao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dsNomeClienteBalcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsNomeClienteBalcao.Location = new System.Drawing.Point(17, 32);
            this.dsNomeClienteBalcao.Name = "dsNomeClienteBalcao";
            this.dsNomeClienteBalcao.Size = new System.Drawing.Size(230, 20);
            this.dsNomeClienteBalcao.TabIndex = 0;
            this.dsNomeClienteBalcao.Leave += new System.EventHandler(this.dsNomeClienteBalcao_Leave);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // VendaBalcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxVendaMesa);
            this.Name = "VendaBalcao";
            this.Size = new System.Drawing.Size(1011, 183);
            this.Load += new System.EventHandler(this.VendaBalcao_Load);
            this.groupBoxVendaMesa.ResumeLayout(false);
            this.groupBoxVendaMesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOcupantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBBalcaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBGarconBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVendaMesa;
        private System.Windows.Forms.Button botaoEfetuarVenda;
        public System.Windows.Forms.ComboBox GarconID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox dsNomeClienteBalcao;
        private System.Windows.Forms.BindingSource eBGarconBindingSource;
        private System.Windows.Forms.Button botaoBuscarPendentes;
        public System.Windows.Forms.ComboBox BalcaoID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource eBBalcaoBindingSource;
        public System.Windows.Forms.NumericUpDown textBoxOcupantes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
