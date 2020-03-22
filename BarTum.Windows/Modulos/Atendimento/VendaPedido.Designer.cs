namespace BarTum.Windows.Modulos.Atendimento
{
    partial class VendaPedido
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
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxObservacao = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButtonNovavenda = new System.Windows.Forms.ToolStripSplitButton();
            this.alterarEndereçoDaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usarOutroEndereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDesteClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarVendasPendentesParaEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receberEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.textReferencias = new System.Windows.Forms.TextBox();
            this.ClienteID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorEntrega = new System.Windows.Forms.TextBox();
            this.GarconID = new System.Windows.Forms.ComboBox();
            this.eBGarconBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.EntregadorID = new System.Windows.Forms.ComboBox();
            this.eBEntregadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.BairroID = new System.Windows.Forms.ComboBox();
            this.eBBairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClienteComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClienteEndereco = new System.Windows.Forms.TextBox();
            this.txtClienteUltimaCompra = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClienteNasc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.nrTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.botaoBuscarPendentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBGarconBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBEntregadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBBairroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBoxObservacao);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textReferencias);
            this.groupBox1.Controls.Add(this.ClienteID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtValorEntrega);
            this.groupBox1.Controls.Add(this.GarconID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.EntregadorID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BairroID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtClienteComplemento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtClienteEndereco);
            this.groupBox1.Controls.Add(this.txtClienteUltimaCompra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtClienteNasc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtClienteNome);
            this.groupBox1.Controls.Add(this.nrTelefone1);
            this.groupBox1.Controls.Add(this.botaoBuscarPendentes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda de Pedido";
            // 
            // button1
            // 
            this.button1.Image = global::BarTum.Windows.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(121, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 67;
            this.toolTip1.SetToolTip(this.button1, "Buscar  vendas pendentes nos pedidos");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(564, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "Observações (Opcional)";
            // 
            // txtBoxObservacao
            // 
            this.txtBoxObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObservacao.Location = new System.Drawing.Point(567, 155);
            this.txtBoxObservacao.Name = "txtBoxObservacao";
            this.txtBoxObservacao.Size = new System.Drawing.Size(432, 20);
            this.txtBoxObservacao.TabIndex = 65;
            this.txtBoxObservacao.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonNovavenda});
            this.toolStrip1.Location = new System.Drawing.Point(780, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(217, 39);
            this.toolStrip1.TabIndex = 64;
            // 
            // toolStripSplitButtonNovavenda
            // 
            this.toolStripSplitButtonNovavenda.AutoSize = false;
            this.toolStripSplitButtonNovavenda.DropDownButtonWidth = 30;
            this.toolStripSplitButtonNovavenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarEndereçoDaVendaToolStripMenuItem,
            this.usarOutroEndereçoToolStripMenuItem,
            this.históricoDesteClienteToolStripMenuItem,
            this.visualizarVendasPendentesParaEntregaToolStripMenuItem,
            this.receberEntregaToolStripMenuItem});
            this.toolStripSplitButtonNovavenda.Image = global::BarTum.Windows.Properties.Resources.clients;
            this.toolStripSplitButtonNovavenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonNovavenda.Name = "toolStripSplitButtonNovavenda";
            this.toolStripSplitButtonNovavenda.Size = new System.Drawing.Size(190, 36);
            this.toolStripSplitButtonNovavenda.Text = "Nova venda   ";
            this.toolStripSplitButtonNovavenda.ButtonClick += new System.EventHandler(this.toolStripSplitButtonNovavenda_ButtonClick);
            // 
            // alterarEndereçoDaVendaToolStripMenuItem
            // 
            this.alterarEndereçoDaVendaToolStripMenuItem.Enabled = false;
            this.alterarEndereçoDaVendaToolStripMenuItem.Name = "alterarEndereçoDaVendaToolStripMenuItem";
            this.alterarEndereçoDaVendaToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.alterarEndereçoDaVendaToolStripMenuItem.Text = "Alterar endereço da venda";
            this.alterarEndereçoDaVendaToolStripMenuItem.Visible = false;
            this.alterarEndereçoDaVendaToolStripMenuItem.Click += new System.EventHandler(this.alterarEndereçoDaVendaToolStripMenuItem_Click);
            // 
            // usarOutroEndereçoToolStripMenuItem
            // 
            this.usarOutroEndereçoToolStripMenuItem.Name = "usarOutroEndereçoToolStripMenuItem";
            this.usarOutroEndereçoToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.usarOutroEndereçoToolStripMenuItem.Text = "Nova venda com outro endereço";
            this.usarOutroEndereçoToolStripMenuItem.Visible = false;
            this.usarOutroEndereçoToolStripMenuItem.Click += new System.EventHandler(this.usarOutroEndereçoToolStripMenuItem_Click);
            // 
            // históricoDesteClienteToolStripMenuItem
            // 
            this.históricoDesteClienteToolStripMenuItem.Name = "históricoDesteClienteToolStripMenuItem";
            this.históricoDesteClienteToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.históricoDesteClienteToolStripMenuItem.Text = "Histórico de pedidos deste cliente";
            this.históricoDesteClienteToolStripMenuItem.Click += new System.EventHandler(this.históricoDesteClienteToolStripMenuItem_Click);
            // 
            // visualizarVendasPendentesParaEntregaToolStripMenuItem
            // 
            this.visualizarVendasPendentesParaEntregaToolStripMenuItem.Name = "visualizarVendasPendentesParaEntregaToolStripMenuItem";
            this.visualizarVendasPendentesParaEntregaToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.visualizarVendasPendentesParaEntregaToolStripMenuItem.Text = "Visualizar Vendas Pendentes para entrega";
            this.visualizarVendasPendentesParaEntregaToolStripMenuItem.Click += new System.EventHandler(this.visualizarVendasPendentesParaEntregaToolStripMenuItem_Click);
            // 
            // receberEntregaToolStripMenuItem
            // 
            this.receberEntregaToolStripMenuItem.Enabled = false;
            this.receberEntregaToolStripMenuItem.Name = "receberEntregaToolStripMenuItem";
            this.receberEntregaToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.receberEntregaToolStripMenuItem.Text = "Receber Entrega";
            this.receberEntregaToolStripMenuItem.Click += new System.EventHandler(this.receberEntregaToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Referências";
            // 
            // textReferencias
            // 
            this.textReferencias.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textReferencias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textReferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReferencias.Location = new System.Drawing.Point(13, 155);
            this.textReferencias.Name = "textReferencias";
            this.textReferencias.ReadOnly = true;
            this.textReferencias.Size = new System.Drawing.Size(543, 20);
            this.textReferencias.TabIndex = 62;
            // 
            // ClienteID
            // 
            this.ClienteID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClienteID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteID.Location = new System.Drawing.Point(237, 9);
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            this.ClienteID.Size = new System.Drawing.Size(13, 20);
            this.ClienteID.TabIndex = 61;
            this.ClienteID.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(856, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Valor da entrega";
            // 
            // txtValorEntrega
            // 
            this.txtValorEntrega.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtValorEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEntrega.Location = new System.Drawing.Point(859, 114);
            this.txtValorEntrega.Name = "txtValorEntrega";
            this.txtValorEntrega.ReadOnly = true;
            this.txtValorEntrega.Size = new System.Drawing.Size(138, 20);
            this.txtValorEntrega.TabIndex = 57;
            this.txtValorEntrega.Text = "0,00";
            this.txtValorEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorEntrega.TextChanged += new System.EventHandler(this.txtValorEntrega_TextChanged);
            // 
            // GarconID
            // 
            this.GarconID.BackColor = System.Drawing.SystemColors.Window;
            this.GarconID.DataSource = this.eBGarconBindingSource;
            this.GarconID.DisplayMember = "dsNome";
            this.GarconID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GarconID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GarconID.FormattingEnabled = true;
            this.GarconID.Location = new System.Drawing.Point(313, 114);
            this.GarconID.Name = "GarconID";
            this.GarconID.Size = new System.Drawing.Size(243, 21);
            this.GarconID.TabIndex = 56;
            this.GarconID.ValueMember = "GarconID";
            this.GarconID.Leave += new System.EventHandler(this.GarconID_Leave);
            // 
            // eBGarconBindingSource
            // 
            this.eBGarconBindingSource.DataSource = typeof(BarTum.Entities.EB_Garcon);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Atendente / Garçon";
            // 
            // EntregadorID
            // 
            this.EntregadorID.DataSource = this.eBEntregadorBindingSource;
            this.EntregadorID.DisplayMember = "dsNome";
            this.EntregadorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntregadorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntregadorID.FormattingEnabled = true;
            this.EntregadorID.Location = new System.Drawing.Point(565, 113);
            this.EntregadorID.Name = "EntregadorID";
            this.EntregadorID.Size = new System.Drawing.Size(288, 21);
            this.EntregadorID.TabIndex = 54;
            this.EntregadorID.ValueMember = "EntregadorID";
            this.EntregadorID.Leave += new System.EventHandler(this.EntregadorID_Leave);
            // 
            // eBEntregadorBindingSource
            // 
            this.eBEntregadorBindingSource.DataSource = typeof(BarTum.Entities.EB_Entregador);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Entregador";
            // 
            // BairroID
            // 
            this.BairroID.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BairroID.DataSource = this.eBBairroBindingSource;
            this.BairroID.DisplayMember = "dsNome";
            this.BairroID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BairroID.Enabled = false;
            this.BairroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BairroID.FormattingEnabled = true;
            this.BairroID.Location = new System.Drawing.Point(13, 114);
            this.BairroID.Name = "BairroID";
            this.BairroID.Size = new System.Drawing.Size(291, 21);
            this.BairroID.TabIndex = 51;
            this.BairroID.ValueMember = "BairroID";
            // 
            // eBBairroBindingSource
            // 
            this.eBBairroBindingSource.DataSource = typeof(BarTum.Entities.EB_Bairro);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Complemento";
            // 
            // txtClienteComplemento
            // 
            this.txtClienteComplemento.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtClienteComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteComplemento.Location = new System.Drawing.Point(780, 75);
            this.txtClienteComplemento.Name = "txtClienteComplemento";
            this.txtClienteComplemento.ReadOnly = true;
            this.txtClienteComplemento.Size = new System.Drawing.Size(217, 20);
            this.txtClienteComplemento.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Endereço";
            // 
            // txtClienteEndereco
            // 
            this.txtClienteEndereco.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtClienteEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEndereco.Location = new System.Drawing.Point(185, 75);
            this.txtClienteEndereco.Name = "txtClienteEndereco";
            this.txtClienteEndereco.ReadOnly = true;
            this.txtClienteEndereco.Size = new System.Drawing.Size(578, 20);
            this.txtClienteEndereco.TabIndex = 46;
            // 
            // txtClienteUltimaCompra
            // 
            this.txtClienteUltimaCompra.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtClienteUltimaCompra.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtClienteUltimaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteUltimaCompra.Location = new System.Drawing.Point(98, 75);
            this.txtClienteUltimaCompra.Mask = "00/00/0000";
            this.txtClienteUltimaCompra.Name = "txtClienteUltimaCompra";
            this.txtClienteUltimaCompra.ReadOnly = true;
            this.txtClienteUltimaCompra.Size = new System.Drawing.Size(75, 20);
            this.txtClienteUltimaCompra.TabIndex = 45;
            this.txtClienteUltimaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClienteUltimaCompra.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Última compra";
            // 
            // txtClienteNasc
            // 
            this.txtClienteNasc.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtClienteNasc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtClienteNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNasc.Location = new System.Drawing.Point(13, 75);
            this.txtClienteNasc.Mask = "00/00/0000";
            this.txtClienteNasc.Name = "txtClienteNasc";
            this.txtClienteNasc.ReadOnly = true;
            this.txtClienteNasc.Size = new System.Drawing.Size(75, 20);
            this.txtClienteNasc.TabIndex = 43;
            this.txtClienteNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtClienteNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Aniversário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nome do cliente";
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtClienteNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNome.Location = new System.Drawing.Point(157, 32);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.ReadOnly = true;
            this.txtClienteNome.Size = new System.Drawing.Size(606, 20);
            this.txtClienteNome.TabIndex = 39;
            this.txtClienteNome.TextChanged += new System.EventHandler(this.txtClienteNome_TextChanged);
            // 
            // nrTelefone1
            // 
            this.nrTelefone1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.nrTelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrTelefone1.Location = new System.Drawing.Point(13, 31);
            this.nrTelefone1.Mask = "0000-0000";
            this.nrTelefone1.Name = "nrTelefone1";
            this.nrTelefone1.Size = new System.Drawing.Size(73, 20);
            this.nrTelefone1.TabIndex = 38;
            this.nrTelefone1.Leave += new System.EventHandler(this.nrTelefone1_Leave);
            // 
            // botaoBuscarPendentes
            // 
            this.botaoBuscarPendentes.Image = global::BarTum.Windows.Properties.Resources._1300365118_customers;
            this.botaoBuscarPendentes.Location = new System.Drawing.Point(88, 25);
            this.botaoBuscarPendentes.Name = "botaoBuscarPendentes";
            this.botaoBuscarPendentes.Size = new System.Drawing.Size(32, 30);
            this.botaoBuscarPendentes.TabIndex = 37;
            this.toolTip1.SetToolTip(this.botaoBuscarPendentes, "Buscar clientes cadastrados");
            this.botaoBuscarPendentes.UseVisualStyleBackColor = true;
            this.botaoBuscarPendentes.Click += new System.EventHandler(this.botaoBuscarPendentes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Telefone";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // VendaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "VendaPedido";
            this.Size = new System.Drawing.Size(1011, 183);
            this.Load += new System.EventHandler(this.VendaPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBGarconBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBEntregadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBBairroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoBuscarPendentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtClienteUltimaCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtClienteNasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClienteComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClienteEndereco;
        public System.Windows.Forms.ComboBox BairroID;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox GarconID;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox EntregadorID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource eBEntregadorBindingSource;
        private System.Windows.Forms.BindingSource eBGarconBindingSource;
        private System.Windows.Forms.BindingSource eBBairroBindingSource;
        public System.Windows.Forms.MaskedTextBox nrTelefone1;
        public System.Windows.Forms.TextBox txtClienteNome;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textReferencias;
        public System.Windows.Forms.TextBox txtValorEntrega;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem usarOutroEndereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDesteClienteToolStripMenuItem;
        public System.Windows.Forms.TextBox ClienteID;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonNovavenda;
        private System.Windows.Forms.ToolStripMenuItem alterarEndereçoDaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarVendasPendentesParaEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receberEntregaToolStripMenuItem;
        public System.Windows.Forms.TextBox txtBoxObservacao;
        private System.Windows.Forms.Button button1;
    }
}
