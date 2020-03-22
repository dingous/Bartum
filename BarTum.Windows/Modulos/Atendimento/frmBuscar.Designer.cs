namespace BarTum.Windows.Modulos.Atendimento
{
    partial class frmBuscar
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
            this.toolStripAtendimento = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMesa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBalcao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAtendimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripAtendimento
            // 
            this.toolStripAtendimento.AutoSize = false;
            this.toolStripAtendimento.CanOverflow = false;
            this.toolStripAtendimento.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAtendimento.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAtendimento.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripAtendimento.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStripAtendimento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripTextBox1,
            this.toolStripSeparator5,
            this.tsbMesa,
            this.toolStripSeparator3,
            this.tsbBalcao,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolStripAtendimento.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripAtendimento.Location = new System.Drawing.Point(0, 0);
            this.toolStripAtendimento.Name = "toolStripAtendimento";
            this.toolStripAtendimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripAtendimento.Size = new System.Drawing.Size(182, 257);
            this.toolStripAtendimento.TabIndex = 4;
            this.toolStripAtendimento.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(180, 15);
            this.toolStripLabel2.Text = "Número da venda";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox1.Size = new System.Drawing.Size(120, 23);
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(180, 6);
            // 
            // tsbMesa
            // 
            this.tsbMesa.Image = global::BarTum.Windows.Properties.Resources.atendimento;
            this.tsbMesa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMesa.Name = "tsbMesa";
            this.tsbMesa.Size = new System.Drawing.Size(180, 36);
            this.tsbMesa.Text = "Vendas Mesa";
            this.tsbMesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbMesa.Click += new System.EventHandler(this.tsbMesa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // tsbBalcao
            // 
            this.tsbBalcao.Image = global::BarTum.Windows.Properties.Resources._1409723253_icontexto_drink_web20_magnolia1;
            this.tsbBalcao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBalcao.Name = "tsbBalcao";
            this.tsbBalcao.Size = new System.Drawing.Size(180, 36);
            this.tsbBalcao.Text = "Vendas no Balcão";
            this.tsbBalcao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbBalcao.Click += new System.EventHandler(this.tsbBalcao_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::BarTum.Windows.Properties.Resources._1409722833_telephone_blue;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(180, 36);
            this.toolStripButton1.Text = "Vendas Entrega";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::BarTum.Windows.Properties.Resources._1409802292_food1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(180, 36);
            this.toolStripButton2.Text = "Vendas Comanda";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 225);
            this.Controls.Add(this.toolStripAtendimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar vendas";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscar_KeyDown);
            this.toolStripAtendimento.ResumeLayout(false);
            this.toolStripAtendimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbMesa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbBalcao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStrip toolStripAtendimento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}