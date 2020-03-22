namespace BarTum.Windows.Modulos.Atualizacao
{
    partial class ChecarAtualizacao
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
            this.downloadStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.versaoatual = new System.Windows.Forms.Label();
            this.versaoatualizar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadStatus
            // 
            this.downloadStatus.AutoSize = true;
            this.downloadStatus.Location = new System.Drawing.Point(19, 77);
            this.downloadStatus.Name = "downloadStatus";
            this.downloadStatus.Size = new System.Drawing.Size(0, 13);
            this.downloadStatus.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(60, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Verificar atualização agora!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Versão atual: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data e Hora da última verificação:";
            // 
            // versaoatual
            // 
            this.versaoatual.AutoSize = true;
            this.versaoatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versaoatual.Location = new System.Drawing.Point(97, 9);
            this.versaoatual.Name = "versaoatual";
            this.versaoatual.Size = new System.Drawing.Size(11, 13);
            this.versaoatual.TabIndex = 4;
            this.versaoatual.Text = "-";
            // 
            // versaoatualizar
            // 
            this.versaoatualizar.AutoSize = true;
            this.versaoatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versaoatualizar.Location = new System.Drawing.Point(189, 31);
            this.versaoatualizar.Name = "versaoatualizar";
            this.versaoatualizar.Size = new System.Drawing.Size(11, 13);
            this.versaoatualizar.TabIndex = 5;
            this.versaoatualizar.Text = "-";
            // 
            // ChecarAtualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 162);
            this.Controls.Add(this.versaoatualizar);
            this.Controls.Add(this.versaoatual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChecarAtualizacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização do software";
            this.Load += new System.EventHandler(this.ChecarAtualizacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label downloadStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label versaoatual;
        private System.Windows.Forms.Label versaoatualizar;
    }
}