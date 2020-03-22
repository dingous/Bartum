namespace BarTum.Windows.Modulos.Cliente
{
    partial class frmClienteListNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteListNovo));
            this.eB_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eB_ClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eB_ClienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRCONSULTACLIENTEResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsLogradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefone3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCpfCpnjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convenioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flExcluidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.enderecoID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsComplementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsRegiaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsReferenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flEnderecoPrincipalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contatoID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefone4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsNomeContatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsNome1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsSenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrStatus1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteBindingNavigator)).BeginInit();
            this.eB_ClienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCONSULTACLIENTEResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eB_ClienteBindingSource
            // 
            this.eB_ClienteBindingSource.DataSource = typeof(BarTum.Entities.EB_Cliente);
            // 
            // eB_ClienteBindingNavigator
            // 
            this.eB_ClienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eB_ClienteBindingNavigator.BindingSource = this.eB_ClienteBindingSource;
            this.eB_ClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eB_ClienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eB_ClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eB_ClienteBindingNavigatorSaveItem});
            this.eB_ClienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eB_ClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eB_ClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eB_ClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eB_ClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eB_ClienteBindingNavigator.Name = "eB_ClienteBindingNavigator";
            this.eB_ClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eB_ClienteBindingNavigator.Size = new System.Drawing.Size(856, 25);
            this.eB_ClienteBindingNavigator.TabIndex = 0;
            this.eB_ClienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // eB_ClienteBindingNavigatorSaveItem
            // 
            this.eB_ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eB_ClienteBindingNavigatorSaveItem.Enabled = false;
            this.eB_ClienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eB_ClienteBindingNavigatorSaveItem.Image")));
            this.eB_ClienteBindingNavigatorSaveItem.Name = "eB_ClienteBindingNavigatorSaveItem";
            this.eB_ClienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eB_ClienteBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteIDDataGridViewTextBoxColumn,
            this.dsNomeDataGridViewTextBoxColumn,
            this.dsLogradouroDataGridViewTextBoxColumn,
            this.nrTelefone1DataGridViewTextBoxColumn,
            this.nrTelefone2DataGridViewTextBoxColumn,
            this.nrTelefone3DataGridViewTextBoxColumn,
            this.nrCelularDataGridViewTextBoxColumn,
            this.dtCadastroDataGridViewTextBoxColumn,
            this.dtNascimentoDataGridViewTextBoxColumn,
            this.enderecoIDDataGridViewTextBoxColumn,
            this.contatoIDDataGridViewTextBoxColumn,
            this.usuarioIDDataGridViewTextBoxColumn,
            this.nrCpfCpnjDataGridViewTextBoxColumn,
            this.dsEmailDataGridViewTextBoxColumn,
            this.nrStatusDataGridViewTextBoxColumn,
            this.convenioDataGridViewTextBoxColumn,
            this.flExcluidoDataGridViewCheckBoxColumn,
            this.enderecoID1DataGridViewTextBoxColumn,
            this.cidadeIDDataGridViewTextBoxColumn,
            this.bairroIDDataGridViewTextBoxColumn,
            this.clienteID1DataGridViewTextBoxColumn,
            this.dsComplementoDataGridViewTextBoxColumn,
            this.nrNumeroDataGridViewTextBoxColumn,
            this.nrCEPDataGridViewTextBoxColumn,
            this.dsRegiaoDataGridViewTextBoxColumn,
            this.dsReferenciasDataGridViewTextBoxColumn,
            this.flEnderecoPrincipalDataGridViewCheckBoxColumn,
            this.contatoID1DataGridViewTextBoxColumn,
            this.nrTelefone4DataGridViewTextBoxColumn,
            this.dsNomeContatoDataGridViewTextBoxColumn,
            this.usuarioID1DataGridViewTextBoxColumn,
            this.empresaIDDataGridViewTextBoxColumn,
            this.dsNome1DataGridViewTextBoxColumn,
            this.dsLoginDataGridViewTextBoxColumn,
            this.dsSenhaDataGridViewTextBoxColumn,
            this.nrStatus1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRCONSULTACLIENTEResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // pRCONSULTACLIENTEResultBindingSource
            // 
            this.pRCONSULTACLIENTEResultBindingSource.DataSource = typeof(BarTum.Entities.PR_CONSULTA_CLIENTE_Result);
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            // 
            // dsNomeDataGridViewTextBoxColumn
            // 
            this.dsNomeDataGridViewTextBoxColumn.DataPropertyName = "dsNome";
            this.dsNomeDataGridViewTextBoxColumn.HeaderText = "dsNome";
            this.dsNomeDataGridViewTextBoxColumn.Name = "dsNomeDataGridViewTextBoxColumn";
            // 
            // dsLogradouroDataGridViewTextBoxColumn
            // 
            this.dsLogradouroDataGridViewTextBoxColumn.DataPropertyName = "dsLogradouro";
            this.dsLogradouroDataGridViewTextBoxColumn.HeaderText = "dsLogradouro";
            this.dsLogradouroDataGridViewTextBoxColumn.Name = "dsLogradouroDataGridViewTextBoxColumn";
            // 
            // nrTelefone1DataGridViewTextBoxColumn
            // 
            this.nrTelefone1DataGridViewTextBoxColumn.DataPropertyName = "nrTelefone1";
            this.nrTelefone1DataGridViewTextBoxColumn.HeaderText = "nrTelefone1";
            this.nrTelefone1DataGridViewTextBoxColumn.Name = "nrTelefone1DataGridViewTextBoxColumn";
            // 
            // nrTelefone2DataGridViewTextBoxColumn
            // 
            this.nrTelefone2DataGridViewTextBoxColumn.DataPropertyName = "nrTelefone2";
            this.nrTelefone2DataGridViewTextBoxColumn.HeaderText = "nrTelefone2";
            this.nrTelefone2DataGridViewTextBoxColumn.Name = "nrTelefone2DataGridViewTextBoxColumn";
            // 
            // nrTelefone3DataGridViewTextBoxColumn
            // 
            this.nrTelefone3DataGridViewTextBoxColumn.DataPropertyName = "nrTelefone3";
            this.nrTelefone3DataGridViewTextBoxColumn.HeaderText = "nrTelefone3";
            this.nrTelefone3DataGridViewTextBoxColumn.Name = "nrTelefone3DataGridViewTextBoxColumn";
            // 
            // nrCelularDataGridViewTextBoxColumn
            // 
            this.nrCelularDataGridViewTextBoxColumn.DataPropertyName = "nrCelular";
            this.nrCelularDataGridViewTextBoxColumn.HeaderText = "nrCelular";
            this.nrCelularDataGridViewTextBoxColumn.Name = "nrCelularDataGridViewTextBoxColumn";
            // 
            // dtCadastroDataGridViewTextBoxColumn
            // 
            this.dtCadastroDataGridViewTextBoxColumn.DataPropertyName = "dtCadastro";
            this.dtCadastroDataGridViewTextBoxColumn.HeaderText = "dtCadastro";
            this.dtCadastroDataGridViewTextBoxColumn.Name = "dtCadastroDataGridViewTextBoxColumn";
            // 
            // dtNascimentoDataGridViewTextBoxColumn
            // 
            this.dtNascimentoDataGridViewTextBoxColumn.DataPropertyName = "dtNascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.HeaderText = "dtNascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.Name = "dtNascimentoDataGridViewTextBoxColumn";
            // 
            // enderecoIDDataGridViewTextBoxColumn
            // 
            this.enderecoIDDataGridViewTextBoxColumn.DataPropertyName = "EnderecoID";
            this.enderecoIDDataGridViewTextBoxColumn.HeaderText = "EnderecoID";
            this.enderecoIDDataGridViewTextBoxColumn.Name = "enderecoIDDataGridViewTextBoxColumn";
            // 
            // contatoIDDataGridViewTextBoxColumn
            // 
            this.contatoIDDataGridViewTextBoxColumn.DataPropertyName = "ContatoID";
            this.contatoIDDataGridViewTextBoxColumn.HeaderText = "ContatoID";
            this.contatoIDDataGridViewTextBoxColumn.Name = "contatoIDDataGridViewTextBoxColumn";
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            this.usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.HeaderText = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            // 
            // nrCpfCpnjDataGridViewTextBoxColumn
            // 
            this.nrCpfCpnjDataGridViewTextBoxColumn.DataPropertyName = "nrCpfCpnj";
            this.nrCpfCpnjDataGridViewTextBoxColumn.HeaderText = "nrCpfCpnj";
            this.nrCpfCpnjDataGridViewTextBoxColumn.Name = "nrCpfCpnjDataGridViewTextBoxColumn";
            // 
            // dsEmailDataGridViewTextBoxColumn
            // 
            this.dsEmailDataGridViewTextBoxColumn.DataPropertyName = "dsEmail";
            this.dsEmailDataGridViewTextBoxColumn.HeaderText = "dsEmail";
            this.dsEmailDataGridViewTextBoxColumn.Name = "dsEmailDataGridViewTextBoxColumn";
            // 
            // nrStatusDataGridViewTextBoxColumn
            // 
            this.nrStatusDataGridViewTextBoxColumn.DataPropertyName = "nrStatus";
            this.nrStatusDataGridViewTextBoxColumn.HeaderText = "nrStatus";
            this.nrStatusDataGridViewTextBoxColumn.Name = "nrStatusDataGridViewTextBoxColumn";
            // 
            // convenioDataGridViewTextBoxColumn
            // 
            this.convenioDataGridViewTextBoxColumn.DataPropertyName = "convenio";
            this.convenioDataGridViewTextBoxColumn.HeaderText = "convenio";
            this.convenioDataGridViewTextBoxColumn.Name = "convenioDataGridViewTextBoxColumn";
            // 
            // flExcluidoDataGridViewCheckBoxColumn
            // 
            this.flExcluidoDataGridViewCheckBoxColumn.DataPropertyName = "flExcluido";
            this.flExcluidoDataGridViewCheckBoxColumn.HeaderText = "flExcluido";
            this.flExcluidoDataGridViewCheckBoxColumn.Name = "flExcluidoDataGridViewCheckBoxColumn";
            // 
            // enderecoID1DataGridViewTextBoxColumn
            // 
            this.enderecoID1DataGridViewTextBoxColumn.DataPropertyName = "EnderecoID1";
            this.enderecoID1DataGridViewTextBoxColumn.HeaderText = "EnderecoID1";
            this.enderecoID1DataGridViewTextBoxColumn.Name = "enderecoID1DataGridViewTextBoxColumn";
            // 
            // cidadeIDDataGridViewTextBoxColumn
            // 
            this.cidadeIDDataGridViewTextBoxColumn.DataPropertyName = "CidadeID";
            this.cidadeIDDataGridViewTextBoxColumn.HeaderText = "CidadeID";
            this.cidadeIDDataGridViewTextBoxColumn.Name = "cidadeIDDataGridViewTextBoxColumn";
            // 
            // bairroIDDataGridViewTextBoxColumn
            // 
            this.bairroIDDataGridViewTextBoxColumn.DataPropertyName = "BairroID";
            this.bairroIDDataGridViewTextBoxColumn.HeaderText = "BairroID";
            this.bairroIDDataGridViewTextBoxColumn.Name = "bairroIDDataGridViewTextBoxColumn";
            // 
            // clienteID1DataGridViewTextBoxColumn
            // 
            this.clienteID1DataGridViewTextBoxColumn.DataPropertyName = "ClienteID1";
            this.clienteID1DataGridViewTextBoxColumn.HeaderText = "ClienteID1";
            this.clienteID1DataGridViewTextBoxColumn.Name = "clienteID1DataGridViewTextBoxColumn";
            // 
            // dsComplementoDataGridViewTextBoxColumn
            // 
            this.dsComplementoDataGridViewTextBoxColumn.DataPropertyName = "dsComplemento";
            this.dsComplementoDataGridViewTextBoxColumn.HeaderText = "dsComplemento";
            this.dsComplementoDataGridViewTextBoxColumn.Name = "dsComplementoDataGridViewTextBoxColumn";
            // 
            // nrNumeroDataGridViewTextBoxColumn
            // 
            this.nrNumeroDataGridViewTextBoxColumn.DataPropertyName = "nrNumero";
            this.nrNumeroDataGridViewTextBoxColumn.HeaderText = "nrNumero";
            this.nrNumeroDataGridViewTextBoxColumn.Name = "nrNumeroDataGridViewTextBoxColumn";
            // 
            // nrCEPDataGridViewTextBoxColumn
            // 
            this.nrCEPDataGridViewTextBoxColumn.DataPropertyName = "nrCEP";
            this.nrCEPDataGridViewTextBoxColumn.HeaderText = "nrCEP";
            this.nrCEPDataGridViewTextBoxColumn.Name = "nrCEPDataGridViewTextBoxColumn";
            // 
            // dsRegiaoDataGridViewTextBoxColumn
            // 
            this.dsRegiaoDataGridViewTextBoxColumn.DataPropertyName = "dsRegiao";
            this.dsRegiaoDataGridViewTextBoxColumn.HeaderText = "dsRegiao";
            this.dsRegiaoDataGridViewTextBoxColumn.Name = "dsRegiaoDataGridViewTextBoxColumn";
            // 
            // dsReferenciasDataGridViewTextBoxColumn
            // 
            this.dsReferenciasDataGridViewTextBoxColumn.DataPropertyName = "dsReferencias";
            this.dsReferenciasDataGridViewTextBoxColumn.HeaderText = "dsReferencias";
            this.dsReferenciasDataGridViewTextBoxColumn.Name = "dsReferenciasDataGridViewTextBoxColumn";
            // 
            // flEnderecoPrincipalDataGridViewCheckBoxColumn
            // 
            this.flEnderecoPrincipalDataGridViewCheckBoxColumn.DataPropertyName = "flEnderecoPrincipal";
            this.flEnderecoPrincipalDataGridViewCheckBoxColumn.HeaderText = "flEnderecoPrincipal";
            this.flEnderecoPrincipalDataGridViewCheckBoxColumn.Name = "flEnderecoPrincipalDataGridViewCheckBoxColumn";
            // 
            // contatoID1DataGridViewTextBoxColumn
            // 
            this.contatoID1DataGridViewTextBoxColumn.DataPropertyName = "ContatoID1";
            this.contatoID1DataGridViewTextBoxColumn.HeaderText = "ContatoID1";
            this.contatoID1DataGridViewTextBoxColumn.Name = "contatoID1DataGridViewTextBoxColumn";
            // 
            // nrTelefone4DataGridViewTextBoxColumn
            // 
            this.nrTelefone4DataGridViewTextBoxColumn.DataPropertyName = "nrTelefone4";
            this.nrTelefone4DataGridViewTextBoxColumn.HeaderText = "nrTelefone4";
            this.nrTelefone4DataGridViewTextBoxColumn.Name = "nrTelefone4DataGridViewTextBoxColumn";
            // 
            // dsNomeContatoDataGridViewTextBoxColumn
            // 
            this.dsNomeContatoDataGridViewTextBoxColumn.DataPropertyName = "dsNomeContato";
            this.dsNomeContatoDataGridViewTextBoxColumn.HeaderText = "dsNomeContato";
            this.dsNomeContatoDataGridViewTextBoxColumn.Name = "dsNomeContatoDataGridViewTextBoxColumn";
            // 
            // usuarioID1DataGridViewTextBoxColumn
            // 
            this.usuarioID1DataGridViewTextBoxColumn.DataPropertyName = "UsuarioID1";
            this.usuarioID1DataGridViewTextBoxColumn.HeaderText = "UsuarioID1";
            this.usuarioID1DataGridViewTextBoxColumn.Name = "usuarioID1DataGridViewTextBoxColumn";
            // 
            // empresaIDDataGridViewTextBoxColumn
            // 
            this.empresaIDDataGridViewTextBoxColumn.DataPropertyName = "EmpresaID";
            this.empresaIDDataGridViewTextBoxColumn.HeaderText = "EmpresaID";
            this.empresaIDDataGridViewTextBoxColumn.Name = "empresaIDDataGridViewTextBoxColumn";
            // 
            // dsNome1DataGridViewTextBoxColumn
            // 
            this.dsNome1DataGridViewTextBoxColumn.DataPropertyName = "dsNome1";
            this.dsNome1DataGridViewTextBoxColumn.HeaderText = "dsNome1";
            this.dsNome1DataGridViewTextBoxColumn.Name = "dsNome1DataGridViewTextBoxColumn";
            // 
            // dsLoginDataGridViewTextBoxColumn
            // 
            this.dsLoginDataGridViewTextBoxColumn.DataPropertyName = "dsLogin";
            this.dsLoginDataGridViewTextBoxColumn.HeaderText = "dsLogin";
            this.dsLoginDataGridViewTextBoxColumn.Name = "dsLoginDataGridViewTextBoxColumn";
            // 
            // dsSenhaDataGridViewTextBoxColumn
            // 
            this.dsSenhaDataGridViewTextBoxColumn.DataPropertyName = "dsSenha";
            this.dsSenhaDataGridViewTextBoxColumn.HeaderText = "dsSenha";
            this.dsSenhaDataGridViewTextBoxColumn.Name = "dsSenhaDataGridViewTextBoxColumn";
            // 
            // nrStatus1DataGridViewTextBoxColumn
            // 
            this.nrStatus1DataGridViewTextBoxColumn.DataPropertyName = "nrStatus1";
            this.nrStatus1DataGridViewTextBoxColumn.HeaderText = "nrStatus1";
            this.nrStatus1DataGridViewTextBoxColumn.Name = "nrStatus1DataGridViewTextBoxColumn";
            // 
            // frmClienteListNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.eB_ClienteBindingNavigator);
            this.Name = "frmClienteListNovo";
            this.Text = "frmClienteListNovo";
            this.Load += new System.EventHandler(this.frmClienteListNovo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eB_ClienteBindingNavigator)).EndInit();
            this.eB_ClienteBindingNavigator.ResumeLayout(false);
            this.eB_ClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCONSULTACLIENTEResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eB_ClienteBindingSource;
        private System.Windows.Forms.BindingNavigator eB_ClienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eB_ClienteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsLogradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefone3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCpfCpnjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn convenioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flExcluidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsComplementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsRegiaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsReferenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flEnderecoPrincipalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefone4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsNomeContatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsNome1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsSenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrStatus1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRCONSULTACLIENTEResultBindingSource;
    }
}