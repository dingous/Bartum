namespace BarTum.Windows.Modulos.Atendimento
{
    partial class frmHistoricoCliente
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
            this.eB_LancamentoItensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gdvItensVendidos = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxAnos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelDatas = new System.Windows.Forms.FlowLayoutPanel();
            this.lblVisualizandoData = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblshowdata = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eB_LancamentoItensBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItensVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // eB_LancamentoItensBindingSource
            // 
            this.eB_LancamentoItensBindingSource.DataSource = typeof(BarTum.Entities.EB_LancamentoItens);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoCancelar,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 430);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(844, 39);
            this.toolStrip1.TabIndex = 8;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Image = global::BarTum.Windows.Properties.Resources._1298549431_exit;
            this.botaoCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(78, 36);
            this.botaoCancelar.Text = "Fechar";
            this.botaoCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 405);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblshowdata);
            this.tabPage1.Controls.Add(this.lblVisualizandoData);
            this.tabPage1.Controls.Add(this.flowLayoutPanelDatas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxAnos);
            this.tabPage1.Controls.Add(this.gdvItensVendidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Histórico de Pedidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ítens mais pedidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gdvItensVendidos
            // 
            this.gdvItensVendidos.AutoGenerateColumns = false;
            this.gdvItensVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvItensVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gdvItensVendidos.DataSource = this.eB_LancamentoItensBindingSource;
            this.gdvItensVendidos.Location = new System.Drawing.Point(300, 27);
            this.gdvItensVendidos.Name = "gdvItensVendidos";
            this.gdvItensVendidos.Size = new System.Drawing.Size(506, 346);
            this.gdvItensVendidos.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(812, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Último Pedido";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxAnos
            // 
            this.comboBoxAnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnos.FormattingEnabled = true;
            this.comboBoxAnos.Location = new System.Drawing.Point(37, 8);
            this.comboBoxAnos.Name = "comboBoxAnos";
            this.comboBoxAnos.Size = new System.Drawing.Size(87, 21);
            this.comboBoxAnos.TabIndex = 5;
            this.comboBoxAnos.SelectedValueChanged += new System.EventHandler(this.comboBoxAnos_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ano:";
            // 
            // flowLayoutPanelDatas
            // 
            this.flowLayoutPanelDatas.AutoScroll = true;
            this.flowLayoutPanelDatas.Location = new System.Drawing.Point(10, 35);
            this.flowLayoutPanelDatas.Name = "flowLayoutPanelDatas";
            this.flowLayoutPanelDatas.Size = new System.Drawing.Size(284, 338);
            this.flowLayoutPanelDatas.TabIndex = 7;
            // 
            // lblVisualizandoData
            // 
            this.lblVisualizandoData.AutoSize = true;
            this.lblVisualizandoData.Location = new System.Drawing.Point(297, 8);
            this.lblVisualizandoData.Name = "lblVisualizandoData";
            this.lblVisualizandoData.Size = new System.Drawing.Size(95, 13);
            this.lblVisualizandoData.TabIndex = 8;
            this.lblVisualizandoData.Text = "Visualizando Data:";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProdutoID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProdutoID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dsObservacao";
            this.dataGridViewTextBoxColumn8.HeaderText = "dsObservacao";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // lblshowdata
            // 
            this.lblshowdata.AutoSize = true;
            this.lblshowdata.Location = new System.Drawing.Point(389, 8);
            this.lblshowdata.Name = "lblshowdata";
            this.lblshowdata.Size = new System.Drawing.Size(0, 13);
            this.lblshowdata.TabIndex = 9;
            // 
            // frmHistoricoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 469);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmHistoricoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistoricoCliente";
            this.Load += new System.EventHandler(this.frmHistoricoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eB_LancamentoItensBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItensVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eB_LancamentoItensBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gdvItensVendidos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAnos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDatas;
        private System.Windows.Forms.Label lblVisualizandoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblshowdata;
    }
}