using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using BarTum.Entities;
using BarTum.Utilities;
using BarTum.Utilities.Impressoes;
using System.Drawing.Printing;
using BarTum.Windows.Modulos.Produto;
using BarTum.Windows.Modulos.Configuracoes;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Collections;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmIncluirProduto : Form
    {


        frmAtendimento formpai;
        string impressora;
        int larguraPapel;
        EB_LancamentoItens itensImpressao;
        private int tipoUnidade;


        public frmIncluirProduto(frmAtendimento formpai)
        {
            InitializeComponent();
            this.formpai = formpai;
            ProdutoID.Focus();
        }



        private void frmIncluirProduto_Load(object sender, EventArgs e)
        {
            ProdutoID.Focus();
            checkBoxImprimirProduto.Checked = true;
           
        }



        public ImpressoesPedido pedido = new ImpressoesPedido();
        public EB_OrigemProduto origem = new EB_OrigemProduto();
        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            using (BarTumEntities _context = new BarTumEntities())
            {

                if (dgvProdutos.Rows.Count > 0)
                {

                    try
                    {
                        frmMain frmMain = (frmMain)this.formpai.MdiParent;
                        frmMain.VerificaCaixaSemConfirmacao();
                        var Caixacontexto = frmMain.Caixa.caixaContexto;




                        decimal idLancto = Convert.ToDecimal(this.formpai.LanctoID.Text);
                        var query = _context.EB_Lancamento.Single(a => a.LanctoID == idLancto);



                        if (query.StatusID == 2)
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Esta venda já está sendo fechada por algum terminal, não é possível adicionar mais ítens a ela.", "BarTum", buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3); return;
                        }
                        else if (query.StatusID == 3)
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Esta venda já foi fechada, não é possível adicionar mais ítens a ela.", "BarTum", buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                            return;
                        }


                        string texto = "";
                        PrintDialog dialog = new PrintDialog();
                        dialog.PrinterSettings.PrinterName = this.impressora;


                        int indice = 0;
                        foreach (var row in DtListaProdutos)
                        {
                            EB_LancamentoItens LancaVendaItens = new EB_LancamentoItens();
                            LancaVendaItens.LanctoID = Convert.ToDecimal(this.formpai.LanctoID.Text);
                            LancaVendaItens.ProdutoID = Convert.ToDecimal(row.IDProduto);
                            LancaVendaItens.Quantidade = Convert.ToDecimal(row.Quantidade);
                            string strPrecoVenda = row.VlVenda.ToString().Replace("R$ ", "").Replace(".", "");
                            LancaVendaItens.nrPrecoVenda = Convert.ToDecimal(row.VlVenda);
                            LancaVendaItens.Total = row.Total;
                            LancaVendaItens.dsObservacao = row.Observacao;
                            LancaVendaItens.dtDataHora = DateTime.Now;
                            LancaVendaItens.flParaViagem = false;
                            LancaVendaItens.flFoiImpresso = false;
                            _context.AddToEB_LancamentoItens(LancaVendaItens);
                            _context.SaveChanges();

                            if (ArrayAdicional[indice] != null && ArrayAdicional[indice].Count() > 0)
                            {
                                foreach (var adicional in ArrayAdicional[indice])
                                {
                                    EB_LancamentoItens LancaVendaItensAdicionais = new EB_LancamentoItens();
                                    LancaVendaItensAdicionais.PaiID = LancaVendaItens.LanctoItemID;
                                    LancaVendaItensAdicionais.LanctoID = Convert.ToDecimal(this.formpai.LanctoID.Text);
                                    LancaVendaItensAdicionais.ProdutoID = Convert.ToDecimal(adicional.IDProduto);
                                    LancaVendaItensAdicionais.Quantidade = Convert.ToDecimal(adicional.Quantidade);
                                    string strPrecoVendaAdicional = adicional.VlVenda.ToString().Replace("R$ ", "").Replace(".", "");
                                    LancaVendaItensAdicionais.nrPrecoVenda = Convert.ToDecimal(adicional.VlVenda);
                                    LancaVendaItensAdicionais.Total = adicional.Total;
                                    LancaVendaItensAdicionais.dtDataHora = DateTime.Now;
                                    LancaVendaItensAdicionais.flParaViagem = false;
                                    LancaVendaItensAdicionais.flFoiImpresso = false;
                                    _context.AddToEB_LancamentoItens(LancaVendaItensAdicionais);
                                    _context.SaveChanges();
                                }

                            }

                            indice++;
                        }

                        texto = "";
                        StringBuilder font = new StringBuilder();
                        font.Append((char)27);
                        font.Append((char)33);
                        font.Append((char)0);
                        texto += font;


                        var printProdutos = _context.EB_Lancamento.Single(a => a.LanctoID == idLancto);


                        /*verifica impressoas*/
                        List<EB_OrigemProduto> printers = new List<EB_OrigemProduto>();
                        foreach (var printer in printProdutos.EB_LancamentoItens.Where(a => a.flFoiImpresso == false))
                        {
                            if (printer.EB_Produto.EB_OrigemProduto.dsImpressora != "" && printer.EB_Produto.EB_OrigemProduto.dsImpressora != null)
                            {
                                if (!printers.Contains(printer.EB_Produto.EB_OrigemProduto))
                                {
                                    printers.Add(printer.EB_Produto.EB_OrigemProduto);
                                }
                            }
                        }


                        if (printers.Count == 0)
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Não foi possível imprimir o pedido, pois nenhuma impressora está configurada no sistema, para configurá-la vá no menu Sistema / Configurações Gerais", "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                            return;
                        }

                        /**/


                        string DadosTipo = "";
                        decimal idMesa = 0;

                        switch (this.formpai.tipoVenda)
                        {
                            case "mesa":
                                idMesa = Convert.ToDecimal(this.formpai.VendaMesa.textBoxMesa.Text);
                                DadosTipo = "MESA : " + Convert.ToInt32(idMesa).ToString("D2");
                                break;
                            case "balcao":
                                DadosTipo = "BALCÃO : " + printProdutos.BalcaoID.ToString() + " - CLIENTE: " + printProdutos.dsNomeClienteBalcao;
                                break;
                            case "pedido":
                                DadosTipo = "ENTREGA";
                                break;
                        }




                        int index = 0;
                        var produtosParaImpressao = printProdutos.EB_LancamentoItens.Where(a => a.PaiID == 0 && a.flFoiImpresso == false);
                        var origens = produtosParaImpressao.Where(a => a.EB_Produto.EB_OrigemProduto.impressaoObrigatoria == true).GroupBy(a => new { a.EB_Produto.OrigemID, a.EB_Produto.EB_OrigemProduto.dsOrigem, a.EB_Produto.EB_OrigemProduto.dsImpressora }).Select(a => new { a.Key.dsOrigem, a.Key.OrigemID, a.Key.dsImpressora });

                        foreach (var orig in origens)
                        {
                            index = 0;

                            var infoPrinter = _context.EB_OrigemProduto.Single(a => a.OrigemID == orig.OrigemID);

                            pedido.totalcolunas = Convert.ToInt32(infoPrinter.tamanhoPapelImpressoraMilimetros);
                            pedido.aceitaAcentuacao = infoPrinter.flPossuiAcentuacao;
                            this.origem = infoPrinter;



                            texto = "";
                            texto += pedido.geraLinha(_context.EB_ConfiguracoesSistema.SingleOrDefault().impressaoCabecalho, "center");
                            texto += "\n";
                            texto += pedido.geraLinha("PEDIDO " + orig.dsOrigem + "    " + "Nr. Venda " + Convert.ToInt32(printProdutos.LanctoID).ToString("D6"), "center");
                            texto += "\n";
                            texto += pedido.geraSeparador("-");
                            texto += "\n";
                            if (this.formpai.tipoVenda == "mesa" || this.formpai.tipoVenda == "balcao")
                            {
                                texto += pedido.geraLinha(printProdutos.EB_Garcon.GarconID + " - " + printProdutos.EB_Garcon.dsNome + "       " + DateTime.Now.ToString("dd/MM/yyyy - H:mm"));
                            }
                            else
                            {
                                texto += pedido.geraLinha(DateTime.Now.ToString("dd/MM/yyyy - H:mm"));
                            }
                            texto += "\n";
                            texto += pedido.geraLinha(DadosTipo);
                            texto += "\n";
                            texto += pedido.geraSeparador("-");
                            texto += "\n";

                            foreach (var item in produtosParaImpressao.Where(a => a.EB_Produto.OrigemID == orig.OrigemID))
                            {

                                itensImpressao = item;

                                int codVenda = Convert.ToInt32(itensImpressao.LanctoID);
                                int codItem = Convert.ToInt32(itensImpressao.LanctoItemID);
                                int codigo = Convert.ToInt32(itensImpressao.EB_Produto.ProdutoID);
                                string descricao = itensImpressao.EB_Produto.dsProduto;
                                int quantidade = Convert.ToInt32(itensImpressao.Quantidade);
                                double preco = Convert.ToDouble(itensImpressao.EB_Produto.nrPrecoVenda);
                                string observacao = itensImpressao.dsObservacao;


                                texto += pedido.geraPedido(codigo, descricao, quantidade, preco, index);
                                foreach (var adicionais in printProdutos.EB_LancamentoItens.Where(a => a.PaiID == item.LanctoItemID && a.flFoiImpresso == false))
                                {
                                    var itensImpressaoAdd = adicionais;
                                    int codVendaAdd = Convert.ToInt32(itensImpressaoAdd.LanctoID);
                                    int codItemAdd = Convert.ToInt32(itensImpressaoAdd.LanctoItemID);
                                    int codigoAdd = Convert.ToInt32(itensImpressaoAdd.EB_Produto.ProdutoID);
                                    string descricaoAdd = itensImpressaoAdd.EB_Produto.dsProduto;
                                    int quantidadeAdd = Convert.ToInt32(itensImpressaoAdd.Quantidade);
                                    double precoAdd = Convert.ToDouble(itensImpressaoAdd.EB_Produto.nrPrecoVenda);
                                    string observacaoAdd = itensImpressaoAdd.dsObservacao;

                                    texto += "\n";
                                    texto += pedido.geraPedido(codigoAdd, descricaoAdd, quantidadeAdd, precoAdd, 1);
                                }


                                texto += "\n";
                                if (observacao != "")
                                {
                                    texto += pedido.geraLinha("Obs.: " + observacao);
                                    texto += "\n";
                                }
                                texto += pedido.geraSeparador("-");
                                texto += "\n";

                                index++;
                            }




                            switch (this.formpai.tipoVenda)
                            {
                                case "mesa":
                                    this.formpai.populaGridItens(idMesa);
                                    break;
                                case "balcao":
                                    this.formpai.populaGridItensPorIDVenda(Convert.ToDecimal(this.formpai.LanctoID.Text));
                                    break;
                                case "pedido":
                                    this.formpai.populaGridItensPorIDVenda(Convert.ToDecimal(this.formpai.LanctoID.Text));
                                    break;
                            }




                            if (this.formpai.tipoVenda == "pedido")
                            {
                                texto += pedido.geraLinha(query.EB_Cliente.dsNome + " - ENDEREÇO: " + query.EB_Cliente.EB_Endereco.dsLogradouro + ", " + query.EB_Cliente.EB_Endereco.nrNumero.ToString() + " - " + query.EB_Cliente.EB_Endereco.EB_Bairro.dsNome) + " " + query.EB_Cliente.EB_Endereco.dsReferencias + " - " + retornaTelefone(query.EB_Cliente.EB_Contato);
                            }


                            texto += "\n\n\n\n\n\n\n\n\n";


                            if (pedido.aceitaAcentuacao == false)
                            {
                                texto = pedido.TirarAcentos(texto);
                            }



                            //texto += pedido.FeedPaper(4);
                            texto += pedido.CutPaper();
                            if (checkBoxImprimirProduto.Checked == true)
                            {
                                RawPrinterHelper.SendStringToPrinter(orig.dsImpressora, texto);
                            }

                            indice = 0;
                        }

                        texto = "";




                        foreach (var impresso in printProdutos.EB_LancamentoItens)
                        {
                            impresso.flFoiImpresso = true;
                        }

                        _context.SaveChanges();




                        this.formpai.verificaStatusdaTaxaServico();




                        this.formpai.botaoFecharConta.Enabled = true;
                        this.formpai.toolStripSplitPagamentoParcial.Enabled = true;
                        this.formpai.toolStripBotaoImprimirConta.Enabled = true;
                        this.formpai.botaoCancelar.Enabled = true;





                        switch (this.formpai.tipoVenda)
                        {
                            case "mesa":
                                this.formpai.carregaInformacoes(idMesa);
                                break;
                            case "balcao":
                                this.formpai.carregaInformacoespeloIdVenda(Convert.ToDecimal(this.formpai.LanctoID.Text));
                                break;
                            case "pedido":
                                this.formpai.carregaInformacoespeloIdVenda(Convert.ToDecimal(this.formpai.LanctoID.Text));
                                break;
                            case "comanda":
                                this.formpai.carregaInformacoespeloIdVenda(Convert.ToDecimal(this.formpai.LanctoID.Text));
                                break;
                        }


                        this.formpai.eB_LancamentoItensDataGridView.SelectedRows[0].Selected = true;
                        this.Close();




                    }
                    catch (Exception error)
                    {
                        string mensagem = this.impressora + "\n";

                        if ((error.Message != ""))
                        {
                            mensagem += error.Message;
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(mensagem, "EasyBar - erro ocorrido", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                        }
                        else if (error.InnerException.Message != "")
                        {
                            mensagem += error.InnerException.Message;
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(mensagem, "EasyBar - erro ocorrido", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                        }
                    }
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Nenhum ítem foi adicionado à lista.", "BarTum", buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
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

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void ProdutoID_TextChanged(object sender, EventArgs e)
        {

            BarTumEntities _context = new BarTumEntities();
            _context.Refresh(System.Data.Objects.RefreshMode.ClientWins, _context.EB_Produto);

            decimal idProdutotxt;
            try { idProdutotxt = ProdutoID.Text == "" ? 0 : Convert.ToDecimal(ProdutoID.Text); }
            catch { idProdutotxt = 0; ProdutoID.Text = ""; dsProduto.Text = ""; nrUnidade.Text = ""; nrPrecoVenda.Text = ""; }



            var Prod = _context
                .EB_Produto
                .FirstOrDefault(cl => cl.ProdutoID == idProdutotxt && cl.flExcluido == false && cl.TipoProdutoID != 3);


            if (Prod != null)
            {
                //se produto é por unidade
                if(Prod.nrUnidade == 0)
                {
                    label3.Text = "Quantidade";
                    label8.Text = "Preço Unitário";
                    nrQuantidade.DecimalPlaces = 0;
                    lblValorKg.Visible = false;
                    this.tipoUnidade = 0;
                    nrQuantidade.ValueChanged += new EventHandler(nrQuantidade_ValueChanged);
                    nrQuantidade.Value = 1;
                }
                //se produto é por kg
                else if (Prod.nrUnidade == 1)
                {
                    nrQuantidade.Value = 0;
                    label3.Text = "Peso em (g)";
                    label8.Text = "Preço Kg";
                    lblValorKg.Visible = true;
                    lblValorKg.Text = Convert.ToDecimal(Prod.nrPrecoVenda).ToString("C2") + " o Kg";
                    nrQuantidade.ValueChanged += new EventHandler(nrQuantidade_ValueChanged);
                    nrQuantidade.DecimalPlaces = 3;
                    nrQuantidade.Value = 0;
                    this.tipoUnidade = 1;
                }

                dsProduto.Text = Prod.dsProduto;
                nrUnidade.Text = Prod.nrUnidade.ToString();
                nrPrecoVenda.Text = Convert.ToDecimal(Prod.nrPrecoVenda).ToString("C");

                impressora = Prod.EB_OrigemProduto.dsImpressora;
                larguraPapel = Convert.ToInt32(Prod.EB_OrigemProduto.tamanhoPapelImpressoraMilimetros);

               

            }
            else
            {
                dsProduto.Text = "";
                //ProdutoID.Text = "";
                nrUnidade.Text = "";
                nrPrecoVenda.Text = "";
            }
        }

        void nrQuantidade_ValueChanged(object sender, EventArgs e)
        {
            if (this.tipoUnidade == 1)
            {
            decimal vlKg = Convert.ToDecimal(lblValorKg.Text.Replace("R$ ", "").Replace(" o Kg", ""));
            decimal vlQtd = Convert.ToDecimal(nrQuantidade.Value);
            decimal gtoKg = (vlQtd / 1000);
            nrPrecoVenda.Text = (vlKg * gtoKg).ToString("C2");            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdutoList frm = new frmProdutoList();
            frm.frmIncluirProduto = this;
            frm.ShowDialog();
        }

        private void nrQuantidade_TextChanged(object sender, EventArgs e)
        {
            int quantidade;
            try { quantidade = Convert.ToInt32(nrQuantidade.Text); }
            catch { quantidade = 0; nrQuantidade.Text = ""; }
        }

        private void frmIncluirProduto_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {

                case Keys.Enter:
                    //botaoSalvar_Click(sender, e);
                    btnAddLista_Click(sender, e);
                    break;
                case Keys.F1:
                    botaoSalvar_Click(sender, e);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }




        #region mascaras
        //máscaras
        string str = "";
        private void nrPrecoVenda_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {



            TextBox txtBox = (TextBox)sender;
            Control controle = txtBox;


            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                //char teste = Convert.ToChar(Keys);

                string chave = e.KeyCode.ToString();

                switch (chave)
                {
                    case "NumPad0":
                        str = str + Convert.ToChar(Keys.D0);
                        break;
                    case "NumPad1":
                        str = str + Convert.ToChar(Keys.D1);
                        break;
                    case "NumPad2":
                        str = str + Convert.ToChar(Keys.D2);
                        break;
                    case "NumPad3":
                        str = str + Convert.ToChar(Keys.D3);
                        break;
                    case "NumPad4":
                        str = str + Convert.ToChar(Keys.D4);
                        break;
                    case "NumPad5":
                        str = str + Convert.ToChar(Keys.D5);
                        break;
                    case "NumPad6":
                        str = str + Convert.ToChar(Keys.D6);
                        break;
                    case "NumPad7":
                        str = str + Convert.ToChar(Keys.D7);
                        break;
                    case "NumPad8":
                        str = str + Convert.ToChar(Keys.D8);
                        break;
                    case "NumPad9":
                        str = str + Convert.ToChar(Keys.D9);
                        break;
                    default: str = str + Convert.ToChar(KeyCode); break;
                }


            }
            if (str.Length == 0)
            {
                controle.Text = "";
            }
            if (str.Length == 1)
            {



                controle.Text = Convert.ToDecimal("0,0" + str).ToString("C");
            }
            else if (str.Length == 2)
            {
                controle.Text = Convert.ToDecimal("0," + str).ToString("C");
            }
            else if (str.Length > 2)
            {
                controle.Text = Convert.ToDecimal(str.Substring(0, str.Length - 2) + "," + str.Substring(str.Length - 2)).ToString("C");
            }
        }
        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val >= 96 && Val <= 105) || (Val == 8) || (Val == 46));
        }
        private void nrPrecoVenda_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion mascaras


  
        public void populaListaProdutos()
        {
            listaProdutosBindingSource.DataSource = null;
            dgvProdutos.DataSource = null;

            listaProdutosBindingSource.DataSource = DtListaProdutos;
            dgvProdutos.DataSource = listaProdutosBindingSource;
        }


        public void populaListaAdicionais()
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int selecionado = dgvProdutos.SelectedRows[0].Index;

                listaAdicionaisBindingSource.DataSource = null;
                dgvOpcionais.DataSource = null;

                listaAdicionaisBindingSource.DataSource = ArrayAdicional[selecionado];
                dgvOpcionais.DataSource = listaAdicionaisBindingSource;

                contabilizaTotal();
            }
        }



        public class ListaProdutos : EntityObject
        {
            public decimal IDProduto { get; set; }
            public string Descricao { get; set; }
            public decimal Quantidade { get; set; }
            public decimal VlVenda { get; set; }
            public decimal Total { get; set; }
            public string Observacao { get; set; }
        }

        public class ListaAdicionais : EntityObject
        {
            public decimal IDProduto { get; set; }
            public string Descricao { get; set; }
            public decimal Quantidade { get; set; }
            public decimal VlVenda { get; set; }
            public decimal Total { get; set; }
        }

        public List<ListaProdutos> DtListaProdutos = new List<ListaProdutos>();
        public List<ListaAdicionais> DtListaAdicional = new List<ListaAdicionais>();


        public List<ListaAdicionais>[] ArrayAdicional = new List<ListaAdicionais>[50];
        //public int[] ArrayAdicional = new int[50];



        public void contabilizaTotal()
        {
            decimal total = 0;

            if (formpai.tipoVenda == "pedido")
            {
                total += Convert.ToDecimal(formpai.VendaPedido.txtValorEntrega.Text.Replace("R$ ", ""));
                label4.Text = "Total + taxa de entrega";
            }

            foreach (ListaProdutos item in DtListaProdutos)
            {
                total += item.Total;
            }

            foreach (ListaAdicionais item in DtListaAdicional)
            {
                total += item.Total;
            }

            txtTotal.Text = total.ToString("C2");

        }

        private void btnAddLista_Click(object sender, EventArgs e)
        {
            if (ProdutoID.Text != "" && nrPrecoVenda.Text != "")
            {
                decimal IDProduto = Convert.ToDecimal(ProdutoID.Text);
                string Descricao = dsProduto.Text;
                decimal Quant = Convert.ToDecimal(nrQuantidade.Value);
                decimal vlVenda = Convert.ToDecimal(nrPrecoVenda.Text.Replace("R$ ", ""));
                string observ = dsObservacao.Text;
                decimal total = 0;

                if (this.tipoUnidade == 0)
                {
                    total =  (Quant * vlVenda);
                }
                else if (this.tipoUnidade == 1)
                {
                    total = (vlVenda);
                }

                DtListaProdutos.Add(new ListaProdutos { IDProduto = IDProduto, Descricao = Descricao, Quantidade = Quant, VlVenda = vlVenda, Total = total, Observacao = observ });

                populaListaProdutos();
                populaListaAdicionais();



                contabilizaTotal();

                //int selecionado = dgvProdutos.SelectedRows[0].Index;

                ProdutoID.Text = "";
                dsProduto.Text = "";
                nrQuantidade.Value = 1;
                nrPrecoVenda.Text = "";
                dsObservacao.Text = "";
                nrUnidade.Text = "";



                ProdutoID.Focus();
            }
           

        }


        private void btnNovoAdicional_Click(object sender, EventArgs e)
        {
            frmIncluirAdicional frm = new frmIncluirAdicional();
            frm.frmIncluirProduto = this;
            frm.ShowDialog();
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            populaListaAdicionais();
        }

        private void dgvProdutos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            ArrayAdicional[e.Row.Index] = null;
            populaListaAdicionais();
        }





    }


}