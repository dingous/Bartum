namespace BarTum.Windows.Modulos.Atendimento
{
    partial class frmSelecionaImpressoraPadraoFechamento
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
            this.eB_OrigemProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eB_OrigemProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoCancelar = new System.Windows.Forms.ToolStripButton();
            this.OrigemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eB_OrigemProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_OrigemProdutoDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eB_OrigemProdutoBindingSource
            // 
            this.eB_OrigemProdutoBindingSource.DataSource = typeof(BarTum.Entities.EB_OrigemProduto);
            // 
            // eB_OrigemProdutoDataGridView
            // 
            this.eB_OrigemProdutoDataGridView.AllowUserToAddRows = false;
            this.eB_OrigemProdutoDataGridView.AllowUserToDeleteRows = false;
            this.eB_OrigemProdutoDataGridView.AutoGenerateColumns = false;
            this.eB_OrigemProdutoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.eB_OrigemProdutoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eB_OrigemProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eB_OrigemProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrigemID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.eB_OrigemProdutoDataGridView.DataSource = this.eB_OrigemProdutoBindingSource;
            this.eB_OrigemProdutoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eB_OrigemProdutoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.eB_OrigemProdutoDataGridView.Name = "eB_OrigemProdutoDataGridView";
            this.eB_OrigemProdutoDataGridView.ReadOnly = true;
            this.eB_OrigemProdutoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eB_OrigemProdutoDataGridView.Size = new System.Drawing.Size(372, 174);
            this.eB_OrigemProdutoDataGridView.TabIndex = 1;
            this.eB_OrigemProdutoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eB_OrigemProdutoDataGridView_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 135);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(372, 39);
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
            // OrigemID
            // 
            this.OrigemID.DataPropertyName = "OrigemID";
            this.OrigemID.HeaderText = "Cód.";
            this.OrigemID.Name = "OrigemID";
            this.OrigemID.ReadOnly = true;
            this.OrigemID.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dsOrigem";
            this.dataGridViewTextBoxColumn2.HeaderText = "Origem";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dsImpressora";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome da impressora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 117;
            // 
            // frmSelecionaImpressoraPadraoFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(372, 174);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.eB_OrigemProdutoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSelecionaImpressoraPadraoFechamento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione uma impressora ";
            this.Load += new System.EventHandler(this.frmSelecionaImpressoraPadraoFechamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eB_OrigemProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_OrigemProdutoDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eB_OrigemProdutoBindingSource;
        private System.Windows.Forms.DataGridView eB_OrigemProdutoDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrigemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}