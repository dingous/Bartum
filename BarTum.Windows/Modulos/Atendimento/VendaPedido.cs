using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using BarTum.Entities;
using BarTum.Utilities;
using System.ComponentModel.DataAnnotations;
using BarTum.Windows.Modulos.Cliente;
using BarTum.Windows.Modulos.Bairro;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class VendaPedido : UserControl
    {
        frmAtendimento pai;

        public VendaPedido(frmAtendimento pai)
        {
            InitializeComponent();
            this.pai = pai;
        }



        private void VendaPedido_Load(object sender, EventArgs e)
        {
            populaBairros(null); populaEntregador(); populaGarcon();

            nrTelefone1.Focus();


        }





        public void populaBairros(decimal? idBairro)
        {
            BarTumEntities _context = new BarTumEntities();
            var result = (from item in _context.EB_Bairro.AsEnumerable()
                          orderby item.dsNome ascending
                          select new
                          {
                              item.BairroID,
                              dsNome = String.Format("{0} - {1}", item.dsNome, item.nrTaxaEntrega.ToString("C")),
                          }).ToList();
            eBBairroBindingSource.DataSource = result;

            if (idBairro != null)
            {
                BairroID.SelectedValue = idBairro;
            }
        }

        public void populaEntregador()
        {
            BarTumEntities _context = new BarTumEntities();
            var result = (from item in _context.EB_Entregador orderby item.dsNome ascending select new { item.EntregadorID, item.dsNome }).ToList();
            eBEntregadorBindingSource.DataSource = result;
        }

        public void populaGarcon()
        {
            BarTumEntities _context = new BarTumEntities();
            var result = (from item in _context.EB_Garcon orderby item.dsNome ascending select new { item.GarconID, item.dsNome }).ToList();
            eBGarconBindingSource.DataSource = result;
        }

        private void botaoBuscarPendentes_Click(object sender, EventArgs e)
        {
            frmClienteList frm = new frmClienteList();
            frm.frmAtendimento = this.pai;
            frm.frmMain = (frmMain)this.pai.MdiParent;
            frm.ShowDialog();
        }







        public void populaCamposCliente(decimal idCliente)
        {


            BarTumEntities _context = new BarTumEntities();

            EB_Cliente ClienteEnt;




            ClienteEnt = _context.EB_Cliente.Single(cl => cl.ClienteID == idCliente);


            ClienteID.Text = ClienteEnt.ClienteID.ToString();
            this.txtClienteNome.Text = ClienteEnt.dsNome;


            var ultimaCompra = ClienteEnt.EB_Lancamento.OrderByDescending(a => a.dtFimLancto).Take(1).ToList();


            string hoje = DateTime.Now.ToString("dd/M");
            string niver = Convert.ToDateTime(ClienteEnt.dtNascimento).ToString("dd/M");

            if (hoje == niver)
            {
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult res2;
                res2 = MessageBox.Show(this, "Hoje é o aniversário deste cliente!", "BarTum", buttons2,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            txtClienteNasc.Text = ClienteEnt.dtNascimento.ToString();
            txtClienteEndereco.Text = ClienteEnt.EB_Endereco.dsLogradouro != "" ? String.Format("{0}, {1}", ClienteEnt.EB_Endereco.dsLogradouro, ClienteEnt.EB_Endereco.nrNumero) : String.Empty;
            txtClienteComplemento.Text = ClienteEnt.EB_Endereco.dsComplemento;
            BairroID.SelectedValue = ClienteEnt.EB_Endereco.EB_Bairro.BairroID;
            if (ClienteEnt.EB_Contato.nrTelefone1 != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Contato.nrTelefone1.Remove(0, 5);
            }
            else if (ClienteEnt.EB_Contato.nrTelefone2 != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Contato.nrTelefone2.Remove(0, 5);
            }
            else if (ClienteEnt.EB_Contato.nrTelefone3 != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Contato.nrTelefone3.Remove(0, 5);
            }
            else if (ClienteEnt.EB_Contato.nrTelefone4 != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Contato.nrTelefone4.Remove(0, 5);
            }
            else if (ClienteEnt.EB_Contato.nrCelular != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Contato.nrCelular.Remove(0, 5);
            }
            else
            {
                nrTelefone1.Text = "";
            }

            textReferencias.Text = ClienteEnt.EB_Endereco.dsReferencias;
            txtValorEntrega.Text = ClienteEnt.EB_Endereco.EB_Bairro.nrTaxaEntrega.ToString("C");

            if (ultimaCompra.Count > 0)
            {
                txtClienteUltimaCompra.Text = Convert.ToDateTime(ultimaCompra[0].dtFimLancto).ToString("dd/MM/yyyy");
            }




        }


        public void populaCamposCliente2(decimal idEndereco)
        {



            BarTumEntities _context = new BarTumEntities();


            EB_LanctoPedidos ClienteEnt;




            decimal LanctoID = Convert.ToDecimal(this.pai.LanctoID.Text);
            ClienteEnt = _context.EB_LanctoPedidos.Single(cl => cl.EnderecoID == idEndereco && cl.LanctoID == LanctoID);



            ClienteID.Text = ClienteEnt.ClienteID.ToString();
            this.txtClienteNome.Text = ClienteEnt.EB_Cliente.dsNome;



            alterarEndereçoDaVendaToolStripMenuItem.Enabled = true;
            históricoDesteClienteToolStripMenuItem.Enabled = true;
            receberEntregaToolStripMenuItem.Enabled = true;

            string hoje = DateTime.Now.ToString("dd/M");
            string niver = Convert.ToDateTime(ClienteEnt.EB_Cliente.dtNascimento).ToString("dd/M");



            txtClienteNasc.Text = ClienteEnt.EB_Cliente.dtNascimento.ToString();
            txtClienteEndereco.Text = ClienteEnt.EB_Endereco.dsLogradouro != "" ? String.Format("{0}, {1}", ClienteEnt.EB_Endereco.dsLogradouro, ClienteEnt.EB_Endereco.nrNumero) : String.Empty;
            txtClienteComplemento.Text = ClienteEnt.EB_Endereco.dsComplemento;
            BairroID.SelectedValue = ClienteEnt.EB_Endereco.EB_Bairro.BairroID;
            if (ClienteEnt.EB_Cliente.EB_Contato.nrTelefone1 != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Cliente.EB_Contato.nrTelefone1.Remove(0, 5);
            }
            else if (ClienteEnt.EB_Cliente.EB_Contato.nrTelefone2 != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Cliente.EB_Contato.nrTelefone2.Remove(0, 5);
            }
            else if (ClienteEnt.EB_Cliente.EB_Contato.nrTelefone3 != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Cliente.EB_Contato.nrTelefone3.Remove(0, 5);
            }
            else if (ClienteEnt.EB_Cliente.EB_Contato.nrTelefone4 != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Cliente.EB_Contato.nrTelefone4.Remove(0, 5);
            }
            else if (ClienteEnt.EB_Cliente.EB_Contato.nrCelular != "")
            {
                nrTelefone1.Text = ClienteEnt.EB_Cliente.EB_Contato.nrCelular.Remove(0, 5);
            }

            textReferencias.Text = ClienteEnt.EB_Endereco.dsReferencias;
            txtValorEntrega.Text = ClienteEnt.EB_Endereco.EB_Bairro.nrTaxaEntrega.ToString("C");


            GarconID.SelectedValue = ClienteEnt.EB_Lancamento.GarconID;
            EntregadorID.SelectedValue = ClienteEnt.EB_Lancamento.EntregadorID;
            txtBoxObservacao.Text = ClienteEnt.EB_Lancamento.dsObservacao;

        }

        public void limpaCamposCliente()
        {

            ClienteID.Text = "";
            txtClienteNome.Text = "";
            txtClienteNasc.Text = "";
            txtClienteEndereco.Text = "";
            txtClienteComplemento.Text = "";
            BairroID.SelectedValue = "";


        }

        private void botaoBairros_Click(object sender, EventArgs e)
        {
            frmBairroList frm = new frmBairroList();
            frm.pai = this.pai;
            frm.ShowDialog();
        }


        private void botaoEfetuarVenda_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res;
            res = MessageBox.Show(this, "Criar nova venda de pedido?", "BarTum", buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (ClienteID.Text == "")
            {
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult res2;
                res2 = MessageBox.Show(this, "É necessário selecionar um cliente", "BarTum", buttons2,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (res == DialogResult.No)
            {
                return;
            }
            else
            {

                BarTumEntities _context = new BarTumEntities();

                try
                {

                    EB_Lancamento LancaVenda = new EB_Lancamento();


                    frmMain frmMain = (frmMain)this.ParentForm.ParentForm;
                    LancaVenda.CaixaID = frmMain.Caixa.caixaContexto;
                    LancaVenda.TipoVendaID = 3;
                    LancaVenda.TipoLanctoID = 1;
                    LancaVenda.GarconID = Convert.ToDecimal(GarconID.SelectedValue);
                    LancaVenda.EntregadorID = Convert.ToDecimal(EntregadorID.SelectedValue);
                    LancaVenda.ClienteID = Convert.ToDecimal(ClienteID.Text);
                    LancaVenda.UsuarioID = frmMain.UsuarioLogado;
                    LancaVenda.dtLancto = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                    LancaVenda.StatusID = 1;




                    this.pai.botaoIncluirProduto.Enabled = true;

                    _context.AddToEB_Lancamento(LancaVenda);
                    _context.SaveChanges();



                    this.pai.LanctoID.Text = LancaVenda.LanctoID.ToString();
                    this.pai.dtLancto.Text = Convert.ToDateTime(LancaVenda.dtLancto).ToString("dd/M/yyyy H:mm");
                    this.pai.TxtprocentagemGarcon.Text = LancaVenda.EB_Garcon.nrComissao.ToString();
                    this.pai.populaGridItensPorIDVenda(Convert.ToDecimal(pai.LanctoID.Text));

                    this.pai.TotalVenda();
                    this.pai.calculaCamposFinanceiros();





                }
                catch (Exception error)
                {
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    MessageBox.Show(error.InnerException.Message, "BarTum", buttons2, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                }
            }
        }



        public Object consulta;

        private void nrTelefone1_Leave(object sender, EventArgs e)
        {

            BarTumEntities _context = new BarTumEntities();

            string tel = nrTelefone1.Text.Trim();

            if (tel != "-" && tel.Length == 9)
            {

                var query = (

                                    from eb_cliente in _context.EB_Cliente
                                    join eb_contato in _context.EB_Contato on new { ContatoID = (Decimal)eb_cliente.ContatoID } equals new { ContatoID = eb_contato.ContatoID }
                                    where
                                      eb_contato.nrTelefone1.EndsWith(tel) && eb_cliente.flExcluido == false ||
                                      eb_contato.nrTelefone2.EndsWith(tel) && eb_cliente.flExcluido == false ||
                                      eb_contato.nrTelefone3.EndsWith(tel) && eb_cliente.flExcluido == false ||
                                      eb_contato.nrTelefone4.EndsWith(tel) && eb_cliente.flExcluido == false

                                    select new
                                    {
                                        eb_cliente.convenio,
                                        eb_cliente.nrStatus,
                                        eb_cliente.dtCadastro,
                                        eb_cliente.dsEmail,
                                        eb_cliente.nrCpfCpnj,
                                        eb_cliente.dtNascimento,
                                        eb_cliente.dsNome,
                                        eb_cliente.UsuarioID,
                                        eb_cliente.ContatoID,
                                        eb_cliente.EnderecoID,
                                        eb_cliente.ClienteID,
                                        eb_contato.dsNomeContato,
                                        tel5 = eb_contato.nrCelular,
                                        tel4 = eb_contato.nrTelefone4,
                                        tel3 = eb_contato.nrTelefone3,
                                        tel2 = eb_contato.nrTelefone2,
                                        tel1 = eb_contato.nrTelefone1,
                                        Column1 = eb_contato.ContatoID
                                    }

                            ).ToList();

                int nr = query.Count;

                if (nr > 0)
                {

                    if (nr == 1)
                    {
                        populaCamposCliente(query[0].ClienteID);
                    }
                    else
                    {
                        this.consulta = query;
                        frmVendaPedidoTels frm = new frmVendaPedidoTels();
                        frm.frmAtendimento = this.pai;
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult res;
                    res = MessageBox.Show(this, "Este número não está cadastrado deseja cadastrá-lo?", "BarTum", buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            limpaCamposCliente();
                            frmClienteList frmList = new frmClienteList();
                            frmClienteCadastro frm = new frmClienteCadastro();
                            frmList.frmMain = (frmMain)this.pai.MdiParent;
                            frm.frmClienteList = frmList;
                            frm.frmAtendimento = this.pai;
                            frm.ShowDialog();
                        }
                        catch (Exception error)
                        {

                        }
                    }


                }
            }
        }

        private void txtClienteNome_TextChanged(object sender, EventArgs e)
        {

        }


        public bool SelecionouCliente()
        {
            if (ClienteID.Text == "")
            {
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult res2;
                res2 = MessageBox.Show(this, "É necessário selecionar um cliente primeiro", "BarTum", buttons2,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        public void toolStripSplitButtonNovavenda_ButtonClick(object sender, EventArgs e)
        {
            frmMain frmMain = (frmMain)this.pai.MdiParent;
            var Caixacontexto = frmMain.Caixa.caixaContexto;
            frmMain.VerificaCaixaSemConfirmacao();

            if (!(this.pai.frmMain.Caixa.CaixaAtivo))
            {
                MessageBox.Show("Não é possível efetuar nenhuma venda, pois o caixa ainda não foi aberto.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (!SelecionouCliente())
            {
                return;
            }


            if (EntregadorID.SelectedValue == null)
            {
                MessageBox.Show("Selecione um entregador.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EntregadorID.Focus();
                return;
            }

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res;
            res = MessageBox.Show(this, "Criar nova venda para entrega?", "BarTum", buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


            if (res == DialogResult.No)
            {
                return;
            }

            geraNovaVenda();
        }


        public void geraNovaVenda()
        {



            BarTumEntities _context = new BarTumEntities();

            try
            {

                EB_Lancamento LancaVenda = new EB_Lancamento();


                frmMain frmMain = (frmMain)this.ParentForm.ParentForm;
                LancaVenda.CaixaID = frmMain.Caixa.caixaContexto;
                LancaVenda.TipoVendaID = 3;
                LancaVenda.TipoLanctoID = 1;
                LancaVenda.GarconID = Convert.ToDecimal(GarconID.SelectedValue);
                LancaVenda.EntregadorID = Convert.ToDecimal(EntregadorID.SelectedValue);
                LancaVenda.ClienteID = Convert.ToDecimal(ClienteID.Text);
                LancaVenda.UsuarioID = frmMain.UsuarioLogado;
                LancaVenda.dtLancto = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                LancaVenda.StatusID = 1;
                LancaVenda.flComissaoGarconFoiPaga = false;


                this.pai.botaoIncluirProduto.Enabled = true;

                _context.AddToEB_Lancamento(LancaVenda);

                EB_LanctoPedidos pedido = new EB_LanctoPedidos();
                pedido.ClienteID = Convert.ToDecimal(LancaVenda.ClienteID);
                pedido.EnderecoID = LancaVenda.EB_Cliente.EB_Endereco.EnderecoID;
                pedido.LanctoID = LancaVenda.LanctoID;
                pedido.flRecebido = false;

                _context.AddToEB_LanctoPedidos(pedido);
                _context.SaveChanges();



                this.pai.LanctoID.Text = LancaVenda.LanctoID.ToString();
                this.pai.dtLancto.Text = Convert.ToDateTime(LancaVenda.dtLancto).ToString("dd/M/yyyy H:mm");
                this.pai.TxtprocentagemGarcon.Text = LancaVenda.EB_Garcon.nrComissao.ToString();
                this.pai.populaGridItensPorIDVenda(Convert.ToDecimal(pai.LanctoID.Text));

                this.pai.TotalVenda();
                this.pai.calculaCamposFinanceiros();


                alterarEndereçoDaVendaToolStripMenuItem.Enabled = true;


            }
            catch (Exception error)
            {
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                MessageBox.Show(error.InnerException.Message, "BarTum", buttons2, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }

        }

        private void usarOutroEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!(this.pai.frmMain.Caixa.CaixaAtivo))
            {
                MessageBox.Show("Não é possível efetuar nenhuma venda, pois o caixa ainda não foi aberto.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!SelecionouCliente())
            {
                return;
            }


            //if(this.pai.LanctoID.Text == "")
            //{


            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult res;
            res = MessageBox.Show(this, "Criar nova venda de pedido?", "BarTum", buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


            if (res == DialogResult.No)
            {
                return;
            }

            geraNovaVenda();

            // }


            frmVendaPedidoEnderecos frm = new frmVendaPedidoEnderecos();
            frm.frmAtendimento = this.pai;
            frm.ShowDialog();
        }

        private void txtValorEntrega_TextChanged(object sender, EventArgs e)
        {
            pai.calculaCamposFinanceiros();
        }

        private void GarconID_Leave(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            if (this.pai.LanctoID.Text != "")
            {
                decimal id = Convert.ToDecimal(this.pai.LanctoID.Text);
                var Venda = _context.EB_Lancamento.Single(cl => cl.LanctoID == id);
                Venda.GarconID = Convert.ToDecimal(GarconID.SelectedValue);
                _context.SaveChanges();
            }
        }

        private void EntregadorID_Leave(object sender, EventArgs e)
        {

            BarTumEntities _context = new BarTumEntities();

            if (this.pai.LanctoID.Text != "")
            {
                decimal id = Convert.ToDecimal(this.pai.LanctoID.Text);
                var Venda = _context.EB_Lancamento.Single(cl => cl.LanctoID == id);
                Venda.EntregadorID = Convert.ToDecimal(EntregadorID.SelectedValue);
                _context.SaveChanges();
            }
        }

        private void alterarEndereçoDaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaPedidoEnderecos frm = new frmVendaPedidoEnderecos();
            frm.frmAtendimento = this.pai;
            frm.ShowDialog();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            if (this.pai.LanctoID.Text != "")
            {
                decimal id = Convert.ToDecimal(this.pai.LanctoID.Text);
                var Venda = _context.EB_Lancamento.Single(cl => cl.LanctoID == id);
                Venda.dsObservacao = txtBoxObservacao.Text;
                _context.SaveChanges();
            }
        }

        private void visualizarVendasPendentesParaEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPendentesPedido form = new frmPendentesPedido();
            form.pai = this.pai;
            form.ShowDialog();
        }

        private void receberEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pai.verificaStatusdaTaxaServico();
            this.pai.funcaoFechaConta();
        }

        private void históricoDesteClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SelecionouCliente())
            {
                return;
            }

            frmHistoricoCliente form = new frmHistoricoCliente();
            form.frmAtendimento = this.pai;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPendentesPedido form = new frmPendentesPedido();
            form.pai = this.pai;
            form.ShowDialog();
        }




    }
}
