using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using BarTum.Entities;
using BarTum.Utilities;
using BarTum.Utilities.Impressoes;
using System.Globalization;
using System.Threading;
using System.Data.Objects;
using System.Drawing.Printing;
using BarTum.Windows.Modulos.Configuracoes;
using System.Data.Objects.DataClasses;




namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmAtendimento : Form
    {
        private BarTumEntities _context = new BarTumEntities();
        public string tipoVenda;
        public frmMain frmMain;




        //componentes
        public VendaMesa VendaMesa;
        public VendaBalcao VendaBalcao;
        public VendaPedido VendaPedido;
        public VendaComanda VendaComanda;

        bool taxaAtiva;

        public frmAtendimento()
        {
            InitializeComponent();

        }

        private void frmAtendimento_Load(object sender, EventArgs e)
        {


            frmMain = (frmMain)this.MdiParent;
            NomeUsuario.Text = frmMain.UsuarioLogadoNome;

            toolStripBotaoImprimirConta.Enabled = false;
            botaoIncluirProduto.Enabled = false;
            botaoFecharConta.Enabled = false;
            toolStripSplitPagamentoParcial.Enabled = false;
            botaoCancelar.Enabled = false;

            eB_LancamentoItensBindingSource.DataSourceChanged += new EventHandler(eB_LancamentoItensBindingSource_DataSourceChanged);


            verificaStatusdaTaxaServico();


        }

        void eB_LancamentoItensBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }



        public void calculaCamposFinanceiros()
        {
            decimal perGarcon = Convert.ToDecimal(TxtprocentagemGarcon.Text);
            decimal totalconsumo = Convert.ToDecimal(txtTotalVenda.Text.Replace("R$ ", "").Replace(".", ""));
            decimal adiantamento = Convert.ToDecimal(txtAdiantamento.Text.Replace("R$ ", "").Replace(".", ""));
            decimal taxaEntrega = 0;
            decimal acrescimo = 0;
            decimal totalPagar = 0;


            switch (this.tipoVenda)
            {
                case "mesa":
                    if (taxaAtiva == true)
                    {
                        acrescimo = ((totalconsumo / 100) * perGarcon);
                        VendaMesa.textBoxVlServico.Text = acrescimo.ToString("c2");
                        VendaMesa.textBoxVlServico.TextAlign = HorizontalAlignment.Right;
                        VendaMesa.textBoxVlServico.ForeColor = Color.Black;
                        VendaMesa.textBoxVlServico.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);

                    }
                    else
                    {
                        VendaMesa.textBoxVlServico.Text = "desativado";
                        VendaMesa.textBoxVlServico.TextAlign = HorizontalAlignment.Center;
                        VendaMesa.textBoxVlServico.ForeColor = Color.OrangeRed;
                        VendaMesa.textBoxVlServico.Font = new Font("Arial", 10, FontStyle.Bold);

                    }

                    break;
                case "balcao":
                    //acrescimo = ((totalconsumo / 100) * perGarcon);
                    break;
                case "pedido":
                    taxaEntrega = Convert.ToDecimal(VendaPedido.txtValorEntrega.Text.Replace("R$ ", ""));
                    acrescimo = taxaEntrega;
                    break;
            }

            totalPagar = (totalconsumo + acrescimo) - adiantamento;

            txtAcrescimo.Text = acrescimo.ToString("c2");
            txtTotalaPagar.Text = totalPagar.ToString("c2");

        }



        public void carregaInformacoes(decimal nrMesa)
        {


            using (BarTumEntities context = new BarTumEntities())
            {



                //var result = (from item in context.EB_Lancamento orderby item.dtLancto ascending select item)
                //            .Where(item => item.MesaID == nrMesa)
                //            .Where(item => (item.StatusID == 1) || (item.StatusID == 2))
                //            .Where(item => item.flVendaCancelada == false)
                //            .FirstOrDefault();


                var result = context.EB_Lancamento
                                    .Where(item =>
                                            item.MesaID == nrMesa
                                            && ((item.StatusID == 1) || (item.StatusID == 2))
                                            && item.flVendaCancelada == false
                                            ).FirstOrDefault();

                if (result != null)
                {
                    verificaStatusdaTaxaServico();

                    limpaCamposFinanceiros();
                    VendaMesa.textBoxMesa.Text = Convert.ToInt32(nrMesa).ToString("D2");
                    LanctoID.Text = result.LanctoID.ToString();
                    VendaMesa.textBoxOcupantes.Text = result.nrOcupantes.ToString();
                    VendaMesa.GarconID.SelectedValue = result.GarconID;
                    TxtprocentagemGarcon.Text = result.EB_Garcon.nrComissao.ToString();
                    dtLancto.Text = Convert.ToDateTime(result.dtLancto).ToString("dd/M/yyyy H:mm");
                    populaGridItens(nrMesa);
                    txtAdiantamento.Text = Convert.ToDecimal(result.FechaAdiantamento).ToString("C");
                    botaoIncluirProduto.Enabled = true;
                    toolStripSplitPagamentoParcial.Enabled = true;
                    botaoFecharConta.Enabled = true;
                    toolStripBotaoImprimirConta.Enabled = true;
                    botaoCancelar.Enabled = true;
                }
                else
                {
                    LanctoID.Text = "";
                    eB_LancamentoItensBindingSource.DataSource = null;
                    eB_LancamentoItensDataGridView.DataSource = eB_LancamentoItensBindingSource;
                    botaoIncluirProduto.Enabled = false;
                    toolStripSplitPagamentoParcial.Enabled = false;
                    botaoFecharConta.Enabled = false;
                    toolStripBotaoImprimirConta.Enabled = false;
                    botaoCancelar.Enabled = false;
                    dtLancto.Text = "";
                    dtFimLancto.Text = "";
                    txtAdiantamento.Text = "0,00";
                    limpaCamposFinanceiros();
                    switch (this.tipoVenda)
                    {
                        case "mesa":
                            VendaMesa.textBoxOcupantes.Text = "1";
                            break;
                    }
                }
            }
        }




        public void carregaInformacoespeloIdVenda(decimal nrVenda)
        {



            using (BarTumEntities context = new BarTumEntities())
            {


                EB_Lancamento result =
                        context.EB_Lancamento.Where(item => item.LanctoID == nrVenda && item.flVendaCancelada == false)
                        .OrderBy(item => item.dtLancto)
                        .FirstOrDefault();


                if (result.StatusID != 3)
                {

                    limpaCamposFinanceiros();



                    switch (this.tipoVenda)
                    {
                        case "mesa":
                            verificaStatusdaTaxaServico();
                            this.VendaMesa.textBoxMesa.Text = nrVenda.ToString();
                            this.VendaMesa.textBoxOcupantes.Text = result.nrOcupantes.ToString();
                            this.VendaMesa.GarconID.SelectedValue = result.GarconID;
                            TxtprocentagemGarcon.Text = result.EB_Garcon.nrComissao.ToString();
                            break;
                        case "balcao":
                            this.VendaBalcao.dsNomeClienteBalcao.Text = result.dsNomeClienteBalcao;
                            this.VendaBalcao.GarconID.SelectedValue = result.GarconID;
                            this.VendaBalcao.textBoxOcupantes.Text = result.nrOcupantes.ToString();
                            break;
                        case "pedido":
                            this.VendaPedido.txtBoxObservacao.Text = result.dsObservacao;
                            break;
                        case "comanda":
                            this.VendaComanda.textBoxComanda.Text = Convert.ToInt32(result.ComandaID).ToString("D4");
                            break;
                    }


                    LanctoID.Text = result.LanctoID.ToString();
                    dtLancto.Text = Convert.ToDateTime(result.dtLancto).ToString("dd/M/yyyy H:mm");
                    populaGridItensPorIDVenda(nrVenda);
                    txtAdiantamento.Text = Convert.ToDecimal(result.FechaAdiantamento).ToString("C");
                    botaoIncluirProduto.Enabled = true;
                    botaoFecharConta.Enabled = true;
                    toolStripBotaoImprimirConta.Enabled = true;
                    toolStripSplitPagamentoParcial.Enabled = true;
                    botaoCancelar.Enabled = true;
                }
                else
                {
                    LanctoID.Text = "";
                    switch (tipoVenda)
                    {
                        case "mesa":

                            break;
                        case "balcao":
                            VendaBalcao.textBoxOcupantes.Text = "";
                            VendaBalcao.dsNomeClienteBalcao.Text = "";

                            break;
                    }
                    eB_LancamentoItensBindingSource.DataSource = null;
                    eB_LancamentoItensDataGridView.DataSource = eB_LancamentoItensBindingSource;
                    botaoIncluirProduto.Enabled = false;
                    toolStripSplitPagamentoParcial.Enabled = false;
                    botaoFecharConta.Enabled = false;
                    toolStripBotaoImprimirConta.Enabled = false;
                    botaoCancelar.Enabled = false;
                    dtLancto.Text = "";
                    dtFimLancto.Text = "";
                    txtAdiantamento.Text = "";
                    limpaCamposFinanceiros();
                    limpaInformacoes();

                }
            }
        }



        public void verificarTipodaVenda(EB_Lancamento result)
        {
            if (result.MesaID != null)
            {
                this.tipoVenda = "mesa";
            }
            else if (result.BalcaoID != null)
            {
                this.tipoVenda = "balcao";
            }
            else if (result.ClienteID != null)
            {
                this.tipoVenda = "pedido";
            }
            else if (result.ComandaID != null)
            {
                this.tipoVenda = "comanda";
            }
        }


        public void limpaCamposFinanceiros()
        {
            TxtprocentagemGarcon.Text = "0,00";
            txtTotalVenda.Text = "0,00";
            txtAcrescimo.Text = "0,00";
            txtTotalaPagar.Text = "0,00";



            switch (this.tipoVenda)
            {
                case "mesa":
                    VendaMesa.textBoxVlServico.Text = "0,00";
                    break;
            }

        }


        public void populaGridItens(decimal nrMesa)
        {

            using (BarTumEntities context = new BarTumEntities())
            {

                //context.Refresh(System.Data.Objects.RefreshMode.ClientWins, context.EB_Produto);
                //context.Refresh(System.Data.Objects.RefreshMode.ClientWins, context.EB_Lancamento);


                //var result = (
                //            from item in context.EB_LancamentoItens
                //            orderby item.LanctoItemID descending
                //            select new { item.EB_Produto.ProdutoID, item.EB_Produto.dsProduto, item.nrPrecoVenda, item.Quantidade, item.dsObservacao, item.Total, item.LanctoItemID, item.dtDataHora, item })
                //            .Where(item => item.item.EB_Lancamento.MesaID == nrMesa)
                //            .Where(item => (item.item.EB_Lancamento.StatusID == 1) || (item.item.EB_Lancamento.StatusID == 2))
                //            .Where(item => item.item.EB_Lancamento.flVendaCancelada == false).ToList();


                var result = context.EB_Lancamento
                    //.Select(item => new { item.EB_Produto.ProdutoID, item.EB_Produto.dsProduto, item.nrPrecoVenda, item.Quantidade, item.dsObservacao, item.Total, item.LanctoItemID, item.dtDataHora, item })
                               .Select(item => new { item.MesaID, item.StatusID, item.flVendaCancelada, EB_LancamentoItens = item.EB_LancamentoItens })
                               .FirstOrDefault(item => item.MesaID == nrMesa
                                               && ((item.StatusID == 1) || (item.StatusID == 2))
                                               && item.flVendaCancelada == false
                                               );



                if (result.EB_LancamentoItens.Count > 0)
                {
                    eB_LancamentoItensBindingSource.DataSource = result.EB_LancamentoItens.Select(item => new { item.EB_Produto.ProdutoID, item.EB_Produto.dsProduto, item.nrPrecoVenda, item.Quantidade, item.dsObservacao, item.LanctoItemID, item.dtDataHora, item.Total });
                    eB_LancamentoItensDataGridView.DataSource = eB_LancamentoItensBindingSource;
                }
                else
                {
                    eB_LancamentoItensBindingSource.DataSource = null;
                    eB_LancamentoItensDataGridView.DataSource = eB_LancamentoItensBindingSource;
                }

            }

        }

        public void populaGridItensPorIDVenda(decimal nrVenda)
        {
            using (BarTumEntities context = new BarTumEntities())
            {

                var result = (from item in context.EB_LancamentoItens orderby item.LanctoItemID descending select new { item.EB_Produto.ProdutoID, item.EB_Produto.dsProduto, item.nrPrecoVenda, item.Quantidade, item.dsObservacao, item.Total, item.LanctoItemID, item.dtDataHora, item }).Where(item => item.item.EB_Lancamento.LanctoID == nrVenda).ToList();
                if (result.Count > 0)
                {
                    eB_LancamentoItensBindingSource.DataSource = result;
                    eB_LancamentoItensDataGridView.DataSource = eB_LancamentoItensBindingSource;
                }
                else
                {
                    eB_LancamentoItensBindingSource.DataSource = null;
                    eB_LancamentoItensDataGridView.DataSource = eB_LancamentoItensBindingSource;
                }
            }
        }


        public void limpaPainel()
        {
            Control.ControlCollection controles = panel1.Controls;
            foreach (Control item in controles)
            {
                controles.Remove(item);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            chamaBuscaVendas();
        }



        private void tsbMesa_Click(object sender, EventArgs e)
        {
            ChamaVendaMesa();
        }


        private void tsbBalcao_Click(object sender, EventArgs e)
        {
            ChamaVendaBalcao();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChamaVendaEntrega();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChamaVendaComanda();


        }

        private void botaoFecharConta_Click(object sender, EventArgs e)
        {

            verificaStatusdaTaxaServico();
            funcaoFechaConta();
        }







        public decimal pegaLanctoID()
        {
            decimal id = Convert.ToDecimal(LanctoID.Text);
            return id;
        }



        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            using (BarTumEntities context = new BarTumEntities())
            {
                decimal ID = Convert.ToDecimal(LanctoID.Text);

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res;
                res = MessageBox.Show(this, "Deseja realmente cancelar esta venda?", "BarTum", buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (res == DialogResult.No)
                {
                    return;

                }
                else
                {
                    try
                    {
                        var Lancto = context.EB_Lancamento.Single(cl => cl.LanctoID == ID);
                        Lancto.flVendaCancelada = true;
                        context.SaveChanges();

                        if (this.tipoVenda == "mesa")
                        {
                            VendaMesa.groupBox1.Controls["mesa" + VendaMesa.textBoxMesa.Text].BackColor = Color.Aquamarine;
                            carregaInformacoes(Convert.ToDecimal(VendaMesa.textBoxMesa.Text));


                            //notifica ao servidor
                            frmMain frmMain = (frmMain)this.MdiParent;
                            string jsoncliente = "{'acao':'ServidorInserirMesa',";
                            jsoncliente += "'MesaID' : '" + VendaMesa.textBoxMesa.Text + "',";
                            jsoncliente += "'tipo' : 'liberada'";
                            jsoncliente += "}";
                            frmMain.strigComando = jsoncliente;
                            frmMain.Atualiza();
                        }
                        else if (this.tipoVenda == "comanda")
                        {
                            VendaComanda.ShowComandas();
                        }

                        limpaInformacoes();

                    }
                    catch (Exception error)
                    {

                    }
                }
            }
        }

        private void botaoIncluirProduto_Click(object sender, EventArgs e)
        {
            frmIncluirProduto form = new frmIncluirProduto(this);

            form.ShowDialog();
        }



        private void eB_LancamentoItensDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (!e.Row.IsNewRow)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res;
                res = MessageBox.Show(this, "Deseja excluir o ítem selecionado?", "BarTum", buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (res == DialogResult.No)
                {
                    e.Cancel = true;

                }
                else
                {
                    try
                    {

                        decimal idItem = Convert.ToDecimal(e.Row.Cells["LanctoItemID"].Value);
                        var item = _context.EB_LancamentoItens.FirstOrDefault(a => a.LanctoItemID == idItem);
                        _context.DeleteObject(item);
                        _context.SaveChanges();


                    }
                    catch (Exception error)
                    {

                    }
                }


            }
        }




        public void eB_LancamentoItensDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TotalVenda();
            calculaCamposFinanceiros();
        }



        public void TotalVenda()
        {

            double tot = 0;
            int i = 0;
            for (i = 0; i < eB_LancamentoItensDataGridView.Rows.Count; i++)
            {
                tot = tot + Convert.ToDouble(eB_LancamentoItensDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn11"].Value);
            }

            txtTotalVenda.Text = tot.ToString("c2");
        }

        private void eB_LancamentoItensDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            populaGridItensPorIDVenda(Convert.ToDecimal(LanctoID.Text));

            TotalVenda();
            calculaCamposFinanceiros();

        }



        public void limpaInformacoes()
        {
            LanctoID.Text = "";
            eB_LancamentoItensBindingSource.DataSource = null;
            eB_LancamentoItensDataGridView.DataSource = eB_LancamentoItensBindingSource;
            botaoIncluirProduto.Enabled = false;
            toolStripSplitPagamentoParcial.Enabled = false;
            botaoFecharConta.Enabled = false;
            toolStripBotaoImprimirConta.Enabled = false;
            botaoCancelar.Enabled = false;
            dtLancto.Text = "";
            dtFimLancto.Text = "";
            txtTotalVenda.Text = "0,00";
            txtAcrescimo.Text = "0,00";
            txtDescontos.Text = "0,00";
            txtAdiantamento.Text = "0,00";
            txtTotalaPagar.Text = "0,00";


        }




        public void funcaoFechaConta()
        {
            using (BarTumEntities context = new BarTumEntities())
            {
                try
                {


                    if (LanctoID.Text != "")
                    {
                        decimal idVenda = Convert.ToDecimal(LanctoID.Text);
                        var Venda = context.EB_Lancamento.Single(cl => cl.LanctoID == idVenda);

                        if (Venda.StatusID == 1)
                        {

                            Venda.StatusID = 2;
                            context.SaveChanges();


                            switch (this.tipoVenda)
                            {
                                case "mesa":
                                    VendaMesa.groupBox1.Controls["mesa" + VendaMesa.textBoxMesa.Text].BackColor = Color.Yellow;

                                    //notifica ao servidor
                                    frmMain frmMain = (frmMain)this.MdiParent;
                                    string jsoncliente = "{'acao':'ServidorInserirMesa',";
                                    jsoncliente += "'MesaID' : '" + VendaMesa.textBoxMesa.Text + "',";
                                    jsoncliente += "'tipo' : 'fechando'";
                                    jsoncliente += "}";
                                    frmMain.strigComando = jsoncliente;
                                    frmMain.Atualiza();
                                    break;
                            }

                        }

                        frmFecharConta _frmCliente = new frmFecharConta(this);
                        _frmCliente.ShowDialog();

                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult res;
                        res = MessageBox.Show(this, "Não há ocupantes nesta mesa.", "BarTum", buttons,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }


                }
                catch (Exception error)
                {

                }
            }
        }

        private void toolStrip1_KeyDown(object sender, KeyEventArgs e)
        {

        }



        private void frmAtendimento_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {

                case Keys.F1:
                    if (botaoIncluirProduto.Enabled == true)
                    {
                        botaoIncluirProduto_Click(sender, e);
                    }
                    break;
                case Keys.F2:
                    if (toolStripSplitPagamentoParcial.Enabled == true)
                    {
                        toolStripSplitPagamentoParcial_ButtonClick(sender, e);
                    }
                    break;
                case Keys.F3:
                    if (toolStripBotaoImprimirConta.Enabled == true)
                    {
                        toolStripBotaoImprimirConta_Click(sender, e);
                    }
                    break;
                case Keys.F4:
                    if (botaoFecharConta.Enabled == true)
                    {
                        botaoFecharConta_Click(sender, e);
                    }
                    break;
                case Keys.F5:
                    if (botaoCancelar.Enabled == true)
                    {
                        botaoCancelar_Click(sender, e);
                    }
                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Enter:

                    switch (this.tipoVenda)
                    {
                        case "mesa":
                            this.VendaMesa.botaoOcuparMesa_Click(sender, e);
                            break;
                        case "balcao":
                            this.VendaBalcao.botaoEfetuarVenda_Click(sender, e);
                            break;
                        case "pedido":
                            this.VendaPedido.toolStripSplitButtonNovavenda_ButtonClick(sender, e);
                            break;
                    }

                    break;


            }

        }




        public List<EB_OrigemProduto> FechaVendaimpressoras;
        public string FechaVendaImpressoraSelecionada;
        public int larguraPapel;
        public string impresaoOrVisualizacao = "impressao";


        public void imprimeItensdaConta()
        {
            using (BarTumEntities context = new BarTumEntities())
            {

                string impressora = null;
                var result = (from origens in context.EB_OrigemProduto where origens.impressoraPedidos == true orderby origens.dsOrigem ascending select origens).ToList();

                if (result.Count == 0)
                {
                    MessageBox.Show("Nenhuma impressora padrão para fechamento de vendas foi definida.");
                    return;
                }

                if (result.Count > 1)
                {
                    this.FechaVendaimpressoras = result;
                    frmSelecionaImpressoraPadraoFechamento frm = new frmSelecionaImpressoraPadraoFechamento();
                    frm.frmAtendimento = this;
                    frm.ShowDialog();
                }
                else
                {
                    impressora = result[0].dsImpressora;
                    this.FechaVendaImpressoraSelecionada = impressora;
                    this.larguraPapel = Convert.ToInt32(result[0].tamanhoPapelImpressoraMilimetros);
                }



                //continua a impressão do fechamento de conta

                PrintDialog printDialog1;
                printDialog1 = new PrintDialog();
                printDialog1.Document = this.printDocumentItens;
                printDialog1.PrinterSettings.PrinterName = impressora;
                //printDialog1.ShowDialog();


                if (impresaoOrVisualizacao == "visualizacao")
                {
                    PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                    printPreviewDialog1.Document = this.printDocumentItens;
                    printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                    printPreviewDialog1.ShowDialog();
                }
                else if (impresaoOrVisualizacao == "impressao")
                {

                    var nrVenda = Convert.ToDecimal(LanctoID.Text);
                    var venda = context.EB_Lancamento.Single(a => a.LanctoID == nrVenda);
                    var itens = venda.EB_LancamentoItens.OrderByDescending(a => a.LanctoItemID).ToList();


                    if (itens.Count == 0)
                    {
                        MessageBox.Show("Nenhum ítem foi adicionado a esta venda, não será possível efetuar a impressão.");
                        return;
                    }

                    double total = 0;

                    string strFechamento = "";
                    switch (this.tipoVenda)
                    {
                        case "mesa":
                            strFechamento = "MESA : " + Convert.ToInt32(venda.MesaID).ToString("D2");
                            break;
                        case "balcao":
                            strFechamento = "BALCÃO : " + venda.BalcaoID.ToString() + " - " + venda.dsNomeClienteBalcao;
                            break;
                        case "pedido":
                            strFechamento = "ENTREGA";
                            break;

                        case "comanda":
                            strFechamento = "COMANDA : " + Convert.ToInt32(venda.ComandaID).ToString("D2");
                            break;
                    }

                    strFechamento += " - Nr. Venda " + Convert.ToInt32(venda.LanctoID).ToString("D6");

                    ImpressoesConta pedido = new ImpressoesConta();
                    pedido.totalcolunas = Convert.ToInt32(result[0].tamanhoPapelImpressoraMilimetros);
                    pedido.aceitaAcentuacao = result[0].flPossuiAcentuacao;

                    string texto = "";

                    texto += pedido.InitializePrinter();

                    StringBuilder font = new StringBuilder();
                    font.Append((char)27);
                    font.Append((char)33);
                    font.Append((char)0);
                    texto += font;


                    texto += pedido.geraLinha(context.EB_ConfiguracoesSistema.SingleOrDefault().impressaoCabecalho, "center");
                    texto += "\n";
                    texto += pedido.geraLinha(strFechamento + " " + DateTime.Now.ToString("dd/MM/yyyy - H:mm"), "left");
                    texto += "\n";
                    texto += pedido.geraSeparador("-");
                    texto += "\n";
                    texto += pedido.geraConta(itens);
                    texto += "\n";
                    texto += pedido.geraSeparador("-");

                    if (itens[0].EB_Lancamento.TipoVendaID == 3)
                    {
                        texto += "\n";
                        texto += pedido.geraLinha(itens[0].EB_Lancamento.EB_Cliente.dsNome + " - ENDEREÇO: " + itens[0].EB_Lancamento.EB_Cliente.EB_Endereco.dsLogradouro + ", " + itens[0].EB_Lancamento.EB_Cliente.EB_Endereco.nrNumero.ToString() + itens[0].EB_Lancamento.EB_Cliente.EB_Endereco.dsComplemento.ToString() + " - " + itens[0].EB_Lancamento.EB_Cliente.EB_Endereco.EB_Bairro.dsNome + " " + itens[0].EB_Lancamento.EB_Cliente.EB_Endereco.dsReferencias + " - " + retornaTelefone(itens[0].EB_Lancamento.EB_Cliente.EB_Contato));
                        texto += "\n";
                        texto += pedido.geraSeparador("-");
                        if (this.VendaPedido.txtBoxObservacao.Text != "")
                        {
                            texto += "\n";
                            texto += pedido.geraLinha("Obs.: " + this.VendaPedido.txtBoxObservacao.Text);
                            texto += "\n";
                            texto += pedido.geraSeparador("-");
                        }

                    }

                    texto += "\n";
                    texto += pedido.geraLinha(context.EB_ConfiguracoesSistema.SingleOrDefault().impressaoRodape, "center");

                    texto += "\n\n\n\n\n\n\n\n\n";



                    if (pedido.aceitaAcentuacao == false)
                    {
                        texto = pedido.TirarAcentos(texto);
                    }

                    /*Envia o texto a ser impresso para a impressora*/
                    //texto += pedido.FeedPaper(3);
                    texto += pedido.CutPaper();


                    RawPrinterHelper.SendStringToPrinter(impressora, texto);


                    texto = "";

                }
            }
        }


        public string retornaTelefone(EB_Contato contato)
        {
            if (contato.nrTelefone1 != "")
            {
                return contato.nrTelefone1;
            }
            else if (contato.nrTelefone2 != "")
            {
                return contato.nrTelefone2;
            }
            else if (contato.nrTelefone3 != "")
            {
                return contato.nrTelefone3;
            }
            else if (contato.nrTelefone4 != "")
            {
                return contato.nrTelefone4;
            }
            else if (contato.nrCelular != "")
            {
                return contato.nrCelular;
            }

            return "";
        }

        private void toolStripBotaoImprimirConta_Click(object sender, EventArgs e)
        {

            verificaStatusdaTaxaServico();
            calculaCamposFinanceiros();

            impresaoOrVisualizacao = "impressao";
            imprimeItensdaConta();

        }

        private void toolStripSplitPagamentoParcial_ButtonClick(object sender, EventArgs e)
        {
            verificaStatusdaTaxaServico();
            calculaCamposFinanceiros();

            frmAdiantamento frm = new frmAdiantamento();
            frm.frmAtendimento = this;
            frm.ShowDialog();
        }

        private void toolStripButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdiantamento_TextChanged(object sender, EventArgs e)
        {
            TotalVenda();
            calculaCamposFinanceiros();
        }

        private void históricoDePagamentoParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdiantamentoHistorico frm = new frmAdiantamentoHistorico();
            frm.frmAtendimento = this;
            frm.ShowDialog();
        }








        #region impressao

        /*IMPRESSÃO DO PEDIDO*/

        float gridAltura = 0;


        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



            /*StringBuilder sb = new StringBuilder();
            sb.AppendLine("N");
            sb.AppendLine("q609");
            sb.AppendLine("Q203,26");
            //set printer character set to win-1250
            sb.AppendLine("I8,B,001");
            sb.AppendLine("A50,50,0,2,1,1,N,\"zażółć gęślą jaźń\"");
            sb.AppendLine("P1");

            printDocumentItens.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            //printPreviewDialog1.ShowDialog();

            //if (printPreviewDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           // {
                byte[] bytes = Encoding.Unicode.GetBytes(sb.ToString());
                bytes = Encoding.Convert(Encoding.Unicode, Encoding.GetEncoding(250), bytes);
                int bCount = bytes.Length;
                IntPtr ptr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(bCount);
                System.Runtime.InteropServices.Marshal.Copy(bytes, 0, ptr, bytes.Length);
                RawPrinterHelper.SendBytesToPrinter(printDocumentItens.PrinterSettings.PrinterName, ptr, bCount);
           // }


            return;*/


            EncodingInfo[] encodings = Encoding.GetEncodings();

            foreach (var item in encodings)
            {

            }


            BarTumEntities context = new BarTumEntities();
            decimal idVenda = Convert.ToDecimal(LanctoID.Text);
            var itensImpressao = _context.EB_Lancamento.FirstOrDefault(cl => cl.LanctoID == idVenda);

            Single margemEsq = e.MarginBounds.Left;
            Single margemSup = e.MarginBounds.Top;
            Single margemDir = e.MarginBounds.Right;
            Single margemInf = e.MarginBounds.Bottom;


            Font fonteTitulo;
            Font fonteTituloB;
            Font fonteTituloTopo;

            fonteTituloB = new Font("Arial", 6, GraphicsUnit.Point);
            fonteTitulo = new Font("Arial", 6, GraphicsUnit.Point);
            fonteTituloTopo = new Font("Arial", 6, GraphicsUnit.Point);
            //fonteTituloTopo = new Font("OCR-B 10 BT", 12, FontStyle.Bold, GraphicsUnit.Point);

            StringFormat stringFormat = new StringFormat();
            stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;


            int charactersOnPage = 0;
            var linesPerPage = e.MarginBounds.Height / fonteTituloB.GetHeight(e.Graphics);

            Pen caneta = new Pen(Color.Black);

            this.gridAltura = 0;


            //System.Text.Encoding.GetEncoding("ISO-8859-1");


            /*LINHA 1*/
            byte[] titulo = Encoding.Unicode.GetBytes("PONTO DO MACARRAO");
            titulo = Encoding.Convert(Encoding.Unicode, Encoding.GetEncoding("x-cp20936"), titulo);
            string tituloStr = Encoding.GetEncoding("UTF-8").GetString(titulo);


            //           string tituloStr = "PONTO DO MACARRAO";


            /*LINHA 1*/
            //string data = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
            //byte[] bdata = Encoding.Unicode.GetBytes(data);
            ////bdata = Encoding.Convert(Encoding.Unicode, Encoding.GetEncoding("iso-8859-1"), titulo);
            //string dataStr = Encoding.GetEncoding("UTF-8").GetString(bdata);

            //string linha = "--------------------------------";
            //byte[] linhab = Encoding.Unicode.GetBytes(linha);
            //linhab = Encoding.Convert(Encoding.Unicode, Encoding.GetEncoding("x-cp20936"), linhab);
            //string linhaStr = Encoding.GetEncoding("UTF-8").GetString(linhab);

            string linha2 = "-------------------------------------------------------------------------------------------";
            byte[] linha2b = Encoding.Unicode.GetBytes(linha2);
            linha2b = Encoding.Convert(Encoding.Unicode, Encoding.GetEncoding("x-cp20936"), linha2b);
            string linhaStr2 = Encoding.GetEncoding("UTF-8").GetString(linha2b);



            //e.Graphics.DrawString(linhaStr, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat); gridAltura = gridAltura + 15;
            //e.Graphics.DrawString(tituloStr, fonteTituloTopo, Brushes.Black, margemEsq, gridAltura, new StringFormat());
            ////e.Graphics.DrawString(dataStr, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat); gridAltura = gridAltura + 15;
            //e.Graphics.DrawString(linhaStr2, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat); gridAltura = gridAltura + 15;


            /*LINHA 2*/
            string hora = "";
            string DadosTipo = "";
            switch (this.tipoVenda)
            {
                case "mesa":
                    DadosTipo = "MESA : " + Convert.ToInt32(itensImpressao.MesaID).ToString("D2");
                    break;
                case "balcao":
                    DadosTipo = "BALCAO : " + itensImpressao.BalcaoID.ToString();
                    break;
                case "tipoPedido":
                    DadosTipo = "PEDIDO : " + itensImpressao.LanctoID;
                    break;
            }

            byte[] CodLanctoItem = Encoding.GetEncoding("iso-8859-1").GetBytes("Nº VENDA: " + Convert.ToInt32(itensImpressao.LanctoID).ToString("D6"));
            string CodLanctoItemStr = Encoding.GetEncoding("iso-8859-1").GetString(CodLanctoItem);




            e.Graphics.DrawString(CodLanctoItemStr, fonteTitulo, Brushes.Black, margemEsq, gridAltura, new StringFormat());
            e.Graphics.DrawString(DadosTipo, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat); gridAltura = gridAltura + 15;
            e.Graphics.DrawString(linha2, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat); gridAltura = gridAltura + 15;


            /*LINHA 3*/


            /*LINHA 4*/

            byte[] cabecalhoGridItem = Encoding.GetEncoding("iso-8859-1").GetBytes("Ítem...............................................................................");
            string cabecalhoGridItemStr = Encoding.GetEncoding("iso-8859-1").GetString(cabecalhoGridItem);

            e.Graphics.DrawString(cabecalhoGridItemStr, fonteTitulo, Brushes.Black, new PointF(margemEsq, gridAltura));

            byte[] qtd = Encoding.GetEncoding("iso-8859-1").GetBytes("Qtd...Total");
            string qtdStr = Encoding.GetEncoding("iso-8859-1").GetString(qtd);
            e.Graphics.DrawString(qtdStr, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat);
            gridAltura = gridAltura + 15;

            e.Graphics.DrawString(linha2, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat);



            //início do grid

            gridAltura = gridAltura + 15;
            decimal total = 0;
            string codigo = "";
            byte[] descricao;
            string descricaoStr;
            decimal tProduto = 0;
            string quantidade = "";

            foreach (var produto in itensImpressao.EB_LancamentoItens.OrderByDescending(a => a.dtDataHora))
            {





                codigo = Convert.ToInt32(produto.EB_Produto.ProdutoID).ToString("D3");

                descricao = Encoding.GetEncoding("iso-8859-1").GetBytes(codigo + " " + produto.EB_Produto.dsProduto);
                descricaoStr = Encoding.GetEncoding("iso-8859-1").GetString(descricao);

                tProduto = produto.Total;
                quantidade = tProduto.ToString() + "   " + Convert.ToInt32(produto.Quantidade).ToString("D2");


                e.Graphics.DrawString(descricaoStr.Substring(0, (descricaoStr.Length > 38 ? 38 : descricaoStr.Length)), fonteTitulo, Brushes.Black, new PointF(margemEsq, gridAltura));
                e.Graphics.DrawString(quantidade, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat);

                total += produto.Total;

                gridAltura = gridAltura + 15;
            }



            descricao = Encoding.GetEncoding("iso-8859-1").GetBytes("TAXA SERVIÇO");
            descricaoStr = Encoding.GetEncoding("iso-8859-1").GetString(descricao);
            decimal taxaServico = Convert.ToDecimal(txtAcrescimo.Text.Replace("R$ ", "").Replace(".", ""));
            quantidade = taxaServico.ToString();


            e.Graphics.DrawString(descricaoStr, fonteTitulo, Brushes.Black, new PointF(margemEsq, gridAltura));
            e.Graphics.DrawString(quantidade, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat);

            total += taxaServico;


            gridAltura = gridAltura + 15;

            //fim do grid



            e.Graphics.DrawString(linha2, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat);

            gridAltura = gridAltura + 15;


            /*LINHA 5*/


            e.Graphics.DrawString("TOTAL....................  " + total.ToString("C"), fonteTituloTopo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat);

            gridAltura = gridAltura + 15;


            e.Graphics.DrawString(linha2, fonteTitulo, Brushes.Black, new PointF(margemDir, gridAltura), stringFormat);

            gridAltura = gridAltura + 15;


            e.HasMorePages = false;




        }



        private void printDocumentItens_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {


            int width = Util.converteMMparaPixels(larguraPapel);

            //int width = 384;

            int height = Convert.ToInt32(1200);
            PaperSize custom = new PaperSize("Custom", width, height);



            //PrinterResolution resolucao = new PrinterResolution();
            //resolucao.X = 200;
            //resolucao.Y = 200;
            Margins margens = new Margins(10, 10, 10, 10);
            e.PageSettings.PrinterResolution = new PrinterResolution();
            //e.PageSettings.PrinterResolution = resolucao;

            e.PageSettings.Margins = margens;
            e.PageSettings.PaperSize = custom;

        }

        private void printDocumentItens_BeginPrint(object sender, PrintEventArgs e)
        {
            //inicio da impressão
        }

        private void printDocumentItens_EndPrint(object sender, PrintEventArgs e)
        {
            //fim da impressão
        }

        #endregion

        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.impresaoOrVisualizacao = "visualizacao";
            imprimeItensdaConta();

        }



        public void ChamaVendaMesa()
        {
            this.VendaMesa = new VendaMesa(this);
            this.Text = "Controle de Atendimento de Mesas";
            this.tipoVenda = "mesa";
            this.limpaPainel();
            this.VendaMesa = new VendaMesa(this);
            this.panel1.Controls.Add(this.VendaMesa);
            this.limpaInformacoes();
        }


        public void ChamaVendaBalcao()
        {
            this.Text = "Controle de Atendimento do Balcão";
            this.tipoVenda = "balcao";
            this.limpaPainel();
            this.VendaBalcao = new VendaBalcao(this);
            this.panel1.Controls.Add(this.VendaBalcao);
            this.limpaInformacoes();
        }


        public void ChamaVendaEntrega()
        {
            this.Text = "Controle de Atendimento de Entregas";
            this.tipoVenda = "pedido";
            this.limpaPainel();
            this.VendaPedido = new VendaPedido(this);
            this.panel1.Controls.Add(this.VendaPedido);
            this.limpaInformacoes();
        }

        public void ChamaVendaComanda()
        {
            this.Text = "Controle de Atendimento por Comandas";
            this.tipoVenda = "comanda";
            this.limpaPainel();
            this.VendaComanda = new VendaComanda(this);
            this.panel1.Controls.Add(this.VendaComanda);
            this.limpaInformacoes();
            this.VendaComanda.textBoxComanda.Focus();
        }

        public void chamaBuscaVendas()
        {
            frmBuscar frm = new frmBuscar();
            frm.pai = this;
            //frm.MdiParent = this.MdiParent;
            frm.ShowDialog();

        }



        public void verificaStatusdaTaxaServico()
        {
            _context.Refresh(System.Data.Objects.RefreshMode.ClientWins, this._context.EB_ConfiguracoesSistema);
            taxaAtiva = Convert.ToBoolean(_context.EB_ConfiguracoesSistema.FirstOrDefault(get => get.ConfID == 1).flTaxaServicoAtiva);

        }


        private void button1_Click(object sender, EventArgs e)
        {

            var atual = _context.EB_ConfiguracoesSistema.FirstOrDefault(a => a.ConfID == 1);
            _context.ApplyCurrentValues("EB_ConfiguracoesSistema", atual);


            var addes = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added);
            var Deleted = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted);
            var Modified = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified);
            var Unchanged = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Unchanged);



            _context.Refresh(System.Data.Objects.RefreshMode.ClientWins, this._context.EB_ConfiguracoesSistema);

            MessageBox.Show(_context.EB_ConfiguracoesSistema.Single(a => a.ConfID == 1).flTaxaServicoAtiva.ToString());
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            ChamaVendaMesa();
        }

        private void transferirMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string c = "";
            if (this.VendaMesa != null)
            {
                c = this.VendaMesa.textBoxMesa.Text;
            }

            if (c != "")
            {
                decimal nrMesa = Convert.ToDecimal(this.VendaMesa.textBoxMesa.Text);
                carregaInformacoes(nrMesa);

                frmTransferenciaMesa frm = new frmTransferenciaMesa();
                frm.frmAtendimento = this;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma mesa", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void eB_LancamentoItensDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var coluna = this.eB_LancamentoItensDataGridView.Columns[e.ColumnIndex].Name;
        }

        private void eB_LancamentoItensBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
           
        }



    }


}
