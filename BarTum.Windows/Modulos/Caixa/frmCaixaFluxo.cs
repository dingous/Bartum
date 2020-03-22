using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Windows.Modulos.Lancamento;

namespace BarTum.Windows.Modulos.Caixa
{
    public partial class frmCaixaFluxo : Form
    {

        public DateTime dataContexto;
        public EB_Caixa CaixaContexto;
        public frmMain frmMain;



        public EB_Caixa CaixaemContexto;


        public frmCaixaFluxo()
        {
            InitializeComponent();
        }

        public void frmCaixaFluxo_Load(object sender, EventArgs e)
        {
            try
            {

                frmMain = (frmMain)this.MdiParent;
                if (frmMain.Caixa.caixaContexto != 0)
                {
                    dataCaixa.Value = frmMain.Caixa.caixaDataAberturaContexto;
                    carregaInformacoesDoCaixa(frmMain.Caixa.caixaDataAberturaContexto);
                    toolStripButton2.Enabled = false;
                }
                else
                {
                    dataCaixa.Value = DateTime.Now;
                    toolStripButton2.Enabled = true;
                }

               

            }catch(Exception error)
            {

            }
        }

        private void botaoMostrarCaixa_Click(object sender, EventArgs e)
        {
            carregaInformacoesDoCaixa(dataCaixa.Value);
        }


        public void LimpaInformacoes()
        {
            txtFechamentoSaldoComputado.Text = "R$ 0,00";
            txtValorAbertura.Text = "R$ 0,00";
            label23.Text = " - ";
            label26.Text = " - ";
            label25.Text = " - ";
            label30.Text = " - ";
            label31.Text = " - ";
        }

        public void carregaInformacoesDoCaixa(DateTime data)
        {

            LimpaInformacoes();

            dataContexto = data;
            DateTime inicio = new DateTime(dataContexto.Year, dataContexto.Month, dataContexto.Day, 0, 0, 0);
            DateTime fim = new DateTime(dataContexto.Year, dataContexto.Month, dataContexto.Day, 23, 59, 59);


            BarTumEntities _context = new BarTumEntities();

            var query = (from item in _context.EB_Caixa
                         where item.dtCaixa >= inicio && item.dtCaixa <= fim
                         
                         select item
                         ).OrderByDescending(a => a.CaixaID).ToList();

            if (query.Count > 0)
            {

                if (query.Count > 1)
                {
                    frmBoxEscolherCaixa frmBoxEscolherCaixa = new frmBoxEscolherCaixa();
                    frmBoxEscolherCaixa.caixas = query;
                    frmBoxEscolherCaixa.frmCaixaFluxo = this;
                    frmBoxEscolherCaixa.ShowDialog();
                }
                else
                {
                    CaixaemContexto = (EB_Caixa)query[0];
                    CaixaContexto = (EB_Caixa)query[0];
                    dataContexto = query[0].dtCaixa;
                }

                tabControl1.Visible = true;

                var historico = CaixaemContexto.EB_CaixaHistoricoFechamento.OrderByDescending(a => a.dtCaixaAbertura).SingleOrDefault();

                
                
                

                if (historico.dsStatus.Trim() == "fechado")
                {
                    txtFechamentoFundoCaixaPosterior.ReadOnly = true;
                    txtFechamentoFundoCaixaPosterior.Enabled = false;
                }
                else
                {
                    txtFechamentoFundoCaixaPosterior.ReadOnly = false;
                    txtFechamentoFundoCaixaPosterior.Enabled = true;
                }

                string status = historico.dsStatus.Trim();

                label23.Text = Convert.ToDateTime(historico.dtCaixaAbertura).ToString("dd/MM/yyyy HH:mm");
                label26.Text = status.Trim() == "aberto" ? " - " : Convert.ToDateTime(historico.dtCaixaFechamento).ToString("dd/MM/yyyy HH:mm");
                label25.Text = status.ToUpper();
                label30.Text = historico.EB_Usuario.dsNome.ToUpper();
                label31.Text = historico.EB_Usuario1 != null ? historico.EB_Usuario1.dsNome.ToUpper() : " - ";


                txtValorAbertura.Text = Convert.ToDecimal(historico.vlAberturaCaixa).ToString("C2");
                txtFechamentoTotalEmCaixa.Text = Convert.ToDecimal(historico.fechamentoTotalFisicoCaixa).ToString("C2");
                txtFechamentoFundoCaixaPosterior.Text = Convert.ToDecimal(historico.fechamentoFundoCaixa).ToString("C2");
                txtFechamentoDiferenca.Text = Convert.ToDecimal(historico.fechamentoDiferenca).ToString("C2");
                
            }
            else
            {
                MessageBox.Show("O Caixa não foi aberto na data: " + data .ToString("dd/MM/yyyy")+ ".", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

               
                
                tabControl1.Visible = false;
                return;
            }


            Consultas();
            ShowCampos();
            txtFechamentoTotalEmCaixa_Leave(null, null);
            tabControl1.Visible = true;
        }












        protected void Consultas()
        {
            BarTumEntities _context = new BarTumEntities();
            DateTime inicio = new DateTime(dataContexto.Year, dataContexto.Month, dataContexto.Day, 0, 0, 0);
            DateTime fim = new DateTime(dataContexto.Year, dataContexto.Month, dataContexto.Day, 23, 59, 59);

            /*CONSUMO INTERNO*/

            decimal? query_consumoInterno = (
                                          from pags in _context.EB_LancamentoFechamentoFormasPag
                                          join lanc in _context.EB_Lancamento on pags.LanctoID equals lanc.LanctoID
                                          //where lanc.dtLancto >= inicio && lanc.dtLancto <= fim && lanc.flVendaCancelada == false
                                          where lanc.CaixaID == CaixaContexto.CaixaID && lanc.flVendaCancelada == false
                                          && pags.FormaPagamentoID == 6
                                          select new
                                          {
                                              soma = (decimal?)pags.vlForma == null ? 0 : (decimal?)pags.vlForma
                                          }
                                          ).Sum(a => (decimal?)a.soma == null ? 0 : (decimal?)a.soma);

            txtBoxConsumoInterno.Text = Convert.ToDecimal(query_consumoInterno).ToString("C2");

            /**/



            #region ENTRADAS


            /*VALORES INICIAIS DO CAIXA*/
            decimal valorAbertura = Convert.ToDecimal(txtValorAbertura.Text.Replace("R$ ", "").Replace(".", ""));


            /*VARIÁVEIS DAS ENTRADAS*/
            decimal vendasnadata = 0;
            decimal rebimentosnaData = 0;
            decimal outraentradas = 0;
            decimal totalEntradas = 0;
            decimal vendasaprazo = 0;


            /*CONSULTAS ENTRADAS*/


            var query_vednasaprazo = _context.EB_Contas.Where(a =>
                                    /*a.dtlancto >= inicio
                                    && a.dtlancto <= fim*/
                                    a.EB_Lancamento.CaixaID == CaixaContexto.CaixaID
                                    && a.lanctoID != null
                                    && a.flBaixada == false
                                    && a.TipoLanctoID == 1
                                    ).Sum(a => a.vlConta);


            decimal? query_outrasentradas = _context.EB_LancamentoCaixaBanco.Where(a =>
                                   /*a.dtLancto >= inicio
                                   && a.dtLancto <= fim*/
                                   a.CaixaID == CaixaContexto.CaixaID
                                   && a.EB_ContasDestDesconto.DestDescontoID == 1
                                   && a.TipoLanctoID == 1
                                   ).Sum(a => (decimal?)a.vlValor);


            decimal? query_vendasnadata = 
                                      (
                                      from pags in _context.EB_LancamentoFechamentoFormasPag
                                      join lanc in _context.EB_Lancamento on pags.LanctoID equals lanc.LanctoID
                                      where /*lanc.dtLancto >= inicio && lanc.dtLancto <= fim*/   
                                      lanc.CaixaID == CaixaContexto.CaixaID && lanc.flVendaCancelada == false
                                      && pags.FormaPagamentoID != 6
                                      select new
                                      {
                                          soma = (decimal?)pags.vlForma == null ? 0 : (decimal?)pags.vlForma
                                      }
                                      ).Sum(a => (decimal?)a.soma == null ? 0 : (decimal?)a.soma);

            

            var query_recebimentosnaData = _context.EB_Contas.Where(
                                      a => a.flBaixada == true
                                      //&& a.CaixaID == CaixaContexto.CaixaID
                                      /*&& a.dtPagamentoOuRecebimento >= inicio 
                                      && a.dtPagamentoOuRecebimento <= fim*/
                                      && a.CaixaID == CaixaContexto.CaixaID
                                      && a.EB_ContasDestDesconto.DestDescontoID == 1
                                      && a.TipoLanctoID == 1
                                      ).Sum(a => a.fechaValorPago);

            
            
            /*ATRIBUI VARIÁVEIS*/
            if (query_vendasnadata != null)
            {
                vendasnadata = Convert.ToDecimal(query_vendasnadata);
            }
            if (query_recebimentosnaData != null)
            {
                rebimentosnaData = query_recebimentosnaData.Value;
            }
            
            if (query_vednasaprazo != null)
            {
                vendasaprazo = query_vednasaprazo.Value;
            }

            if (query_outrasentradas != null)
            {
                outraentradas = Convert.ToDecimal(query_outrasentradas);
            }




            totalEntradas = (rebimentosnaData + vendasnadata +  outraentradas);





            /*POPULA FORMULÁRIOS*/
            txtEntradasVendas.Text = vendasnadata.ToString("C2");
            txtEntradasRecebimentos.Text = rebimentosnaData.ToString("C2");
            txtEntradasTotal.Text = totalEntradas.ToString("C2");
            txtSaidasVendasPrazo.Text = vendasaprazo.ToString("C2");
            txtEntradasOutras.Text = outraentradas.ToString("C2");
            #endregion



            #region SAÍDAS


            /*VARIÁVEIS DAS SAÍDAS*/
           
            decimal entregasPagas = 0;
            decimal totalSaidas = 0;
            decimal pagamentoContas = 0;
            decimal outrassaidass = 0;
           

            /*CONSULTAS SAÍDAS*/
    

            System.Linq.Expressions.Expression<Func<EB_LanctoPedidos, decimal?>> teste = c => c.EB_Endereco.EB_Bairro.nrTaxaEntrega == null ? 0 : c.EB_Endereco.EB_Bairro.nrTaxaEntrega;
            var query_entregaspagas = _context.EB_LanctoPedidos.Where(a =>
                                     /*a.EB_Lancamento.dtLancto >= inicio
                                     && a.EB_Lancamento.dtLancto <= fim*/
                                     a.EB_Lancamento.CaixaID == CaixaContexto.CaixaID
                                     && a.EB_Lancamento.flVendaCancelada == false
                                     && a.flPagoAoEntregador == true
                                     ).Sum(teste);




            var query_pagamentosdecontasnaData = _context.EB_Contas.Where(
                                     a => a.flBaixada == true
                                     /*&& a.dtPagamentoOuRecebimento >= inicio
                                     && a.dtPagamentoOuRecebimento <= fim*/
                                     && a.CaixaID == CaixaContexto.CaixaID
                                     && a.EB_ContasDestDesconto.DestDescontoID == 1
                                     && a.TipoLanctoID == 2
                                     ).Sum(a => a.fechaValorPago);


            decimal? query_outrassaidas = _context.EB_LancamentoCaixaBanco.Where(a =>
                                  /*a.dtLancto >= inicio
                                  && a.dtLancto <= fim*/
                                  a.CaixaID == CaixaContexto.CaixaID
                                  && a.EB_ContasDestDesconto.DestDescontoID == 1
                                  && a.TipoLanctoID == 2
                                  ).Sum(a => (decimal?)a.vlValor);


            /*ATRIBUI VARIÁVEIS*/
           

            if (query_entregaspagas != null)
            {
                entregasPagas = Convert.ToDecimal(query_entregaspagas);
            }
            if (query_pagamentosdecontasnaData != null)
            {
                pagamentoContas = query_pagamentosdecontasnaData.Value;
            }

            if (query_outrassaidas != null)
            {
                outrassaidass = Convert.ToDecimal(query_outrassaidas);
            }


            totalSaidas = (entregasPagas + pagamentoContas + Convert.ToDecimal(query_outrassaidas));


            
            
            /*POPULA FORMULÁRIOS*/
            txtSaidasEntregasPagas.Text = entregasPagas.ToString("C2");
            txtPagamentoContas.Text = pagamentoContas.ToString("C2");
            txtSaidasTotal.Text = totalSaidas.ToString("C2");
            txtOutrassaidas.Text = outrassaidass.ToString("C2");
            
            
        


            #endregion



            /*VARIAVEIS FECHAMENTO*/
            decimal SaldoComputado = 0;

            SaldoComputado = (totalEntradas - totalSaidas + valorAbertura);

            txtFechamentoSaldoComputado.Text = SaldoComputado.ToString("C2");
            








            /*POR TIPO DE VENDA*/

            decimal mesa = 0;
            decimal balcao = 0;
            decimal entrega = 0;
            decimal vendaRapida = 0;
            decimal totalPorTipoVenda = 0;

            decimal? query_mesa = (
                                          from pags in _context.EB_LancamentoFechamentoFormasPag
                                          join lanc in _context.EB_Lancamento on pags.LanctoID equals lanc.LanctoID
                                          //where lanc.dtLancto >= inicio && lanc.dtLancto <= fim 
                                          where lanc.CaixaID == CaixaContexto.CaixaID
                                          && lanc.flVendaCancelada == false
                                          && lanc.TipoVendaID == 1
                                          && lanc.StatusID == 3
                                          && pags.FormaPagamentoID != 6
                                          select new
                                          {
                                              soma = (decimal?)pags.vlForma == null ? 0 : (decimal?)pags.vlForma
                                          }
                                          ).Sum(a => (decimal?)a.soma == null ? 0 : (decimal?)a.soma);

            decimal? query_balcao = (
                                       from pags in _context.EB_LancamentoFechamentoFormasPag
                                       join lanc in _context.EB_Lancamento on pags.LanctoID equals lanc.LanctoID
                                       //where lanc.dtLancto >= inicio && lanc.dtLancto <= fim 
                                       where lanc.CaixaID == CaixaContexto.CaixaID
                                       && lanc.flVendaCancelada == false
                                       && lanc.TipoVendaID == 2
                                       && lanc.StatusID == 3
                                       && pags.FormaPagamentoID != 6
                                       select new
                                       {
                                           soma = (decimal?)pags.vlForma == null ? 0 : (decimal?)pags.vlForma
                                       }
                                       ).Sum(a => (decimal?)a.soma == null ? 0 : (decimal?)a.soma);


            decimal? query_entrega = (
                                       from pags in _context.EB_LancamentoFechamentoFormasPag
                                       join lanc in _context.EB_Lancamento on pags.LanctoID equals lanc.LanctoID
                                       //where lanc.dtLancto >= inicio && lanc.dtLancto <= fim &&
                                       where lanc.CaixaID == CaixaContexto.CaixaID &&
                                       lanc.flVendaCancelada == false
                                       && lanc.TipoVendaID == 3
                                       && lanc.StatusID == 3
                                       && pags.FormaPagamentoID != 6
                                       select new
                                       {
                                           soma = (decimal?)pags.vlForma == null ? 0 : (decimal?)pags.vlForma
                                       }
                                       ).Sum(a => (decimal?)a.soma == null ? 0 : (decimal?)a.soma);

            decimal? query_vendacomanda = (
                                                from pags in _context.EB_LancamentoFechamentoFormasPag
                                                join lanc in _context.EB_Lancamento on pags.LanctoID equals lanc.LanctoID
                                                //where lanc.dtLancto >= inicio && lanc.dtLancto <= fim && 
                                                where lanc.CaixaID == CaixaContexto.CaixaID &&
                                                lanc.flVendaCancelada == false
                                                && lanc.TipoVendaID == 5
                                                select new
                                                {
                                                    soma = (decimal?)pags.vlForma == null ? 0 : (decimal?)pags.vlForma
                                                }
                                                ).Sum(a => (decimal?)a.soma == null ? 0 : (decimal?)a.soma);


            mesa = Convert.ToDecimal(query_mesa != null ? query_mesa : 0);
            balcao = Convert.ToDecimal(query_balcao != null ? query_balcao : 0);
            entrega = Convert.ToDecimal(query_entrega != null ? query_entrega : 0);
            vendaRapida = Convert.ToDecimal(query_vendacomanda != null ? query_vendacomanda : 0);

            totalPorTipoVenda = (mesa + balcao + entrega + vendaRapida);

            VendaMesa.Text = mesa.ToString("C2");
            VendaBalcao.Text = balcao.ToString("C2");
            VendaEntrega.Text = entrega.ToString("C2");
            VendaRapida.Text = vendaRapida.ToString("C2");


            TotalPorVenda.Text = totalPorTipoVenda.ToString("C2");

        }




        decimal vendass;
        decimal contasrecebidas;
        decimal contaspagas;

        public decimal vendasPorFormas(decimal formaID)
        {
            BarTumEntities _context = new BarTumEntities();


            DateTime inicio = new DateTime(dataCaixa.Value.Year, dataCaixa.Value.Month, dataCaixa.Value.Day, 0, 0, 0);
            DateTime fim = new DateTime(dataCaixa.Value.Year, dataCaixa.Value.Month, dataCaixa.Value.Day, 23, 59, 59);


            var vendas =
                        (from pags in _context.EB_LancamentoFechamentoFormasPag
                             join lanc in _context.EB_Lancamento on pags.LanctoID equals lanc.LanctoID
                             join formas in _context.EB_FormaPagamento on pags.FormaPagamentoID equals formas.FormaPagamentoID
                             //where lanc.dtLancto >= inicio && lanc.dtLancto <= fim &&
                             where lanc.CaixaID == CaixaContexto.CaixaID 
                             && lanc.flVendaCancelada == false
                             && pags.FormaPagamentoID != 6
                             && lanc.StatusID == 3
                             group new { pags.FormaPagamentoID, pags.vlForma, pags.LanctoID} by new
                             {
                                 pags.FormaPagamentoID

                             } into g
                             select new
                             {
                                 soma = g.Sum( a => a.vlForma ),
                                 FormaPagamentoID = g.Key.FormaPagamentoID
                             }
                        ).Where(a => a.FormaPagamentoID == formaID).ToList();


            var recebimentos = (from contas in _context.EB_Contas
                          where contas.flBaixada == true && contas.FormaPagamentoID == formaID
                          //&& contas.dtPagamentoOuRecebimento >= inicio && contas.dtPagamentoOuRecebimento <= fim
                          && contas.CaixaID == CaixaContexto.CaixaID 
                          && contas.TipoLanctoID == 1
                          group new { contas.fechaValorPago } by new
                          {
                              contas.FormaPagamentoID

                          } into g
                          select new
                          {
                              soma = g.Sum(a => (decimal)a.fechaValorPago),
                              FormaPagamentoID = (decimal)(g.Key.FormaPagamentoID)
                          }
                           ).ToList();



            var pagamentos = (from contas in _context.EB_Contas
                          where contas.flBaixada == true && contas.FormaPagamentoID == formaID
                          //&& contas.dtPagamentoOuRecebimento >= inicio && contas.dtPagamentoOuRecebimento <= fim
                          && contas.CaixaID == CaixaContexto.CaixaID 
                          && contas.TipoLanctoID == 2
                          group new { contas.fechaValorPago } by new
                          {
                              contas.FormaPagamentoID

                          } into g
                          select new
                          {
                              soma = g.Sum(a => (decimal)a.fechaValorPago),
                              FormaPagamentoID = (decimal)(g.Key.FormaPagamentoID)
                          }
                           ).ToList();




            //lançamentos no caixa entradas
            decimal? query_lancamentoentradas = _context.EB_LancamentoCaixaBanco.Where(a =>
                                 /*a.dtLancto >= inicio
                                 && a.dtLancto <= fim*/
                                 a.CaixaID == CaixaContexto.CaixaID
                                 && a.EB_ContasDestDesconto.DestDescontoID == 1
                                 && a.TipoLanctoID == 1
                                 && a.formaPagamentoID == formaID
                                 ).Sum(a => (decimal?)a.vlValor);

            
            
            //lançamentos no caixa saidas
            decimal? query_lancamentosaidas = _context.EB_LancamentoCaixaBanco.Where(a =>
                                 /*a.dtLancto >= inicio
                                 && a.dtLancto <= fim*/
                                 a.CaixaID == CaixaContexto.CaixaID
                                 && a.EB_ContasDestDesconto.DestDescontoID == 1
                                 && a.TipoLanctoID == 2
                                 && a.formaPagamentoID == formaID
                                 ).Sum(a => (decimal?)a.vlValor);



            decimal lanctoentradas = Convert.ToDecimal(query_lancamentoentradas == null ? 0 : query_lancamentoentradas);
            decimal lantosaidas = Convert.ToDecimal(query_lancamentosaidas == null ? 0 : query_lancamentosaidas);
            decimal sublanctoentradassaida = (lanctoentradas - lantosaidas);

            decimal sub = pagamentos.Count > 0 ? pagamentos[0].soma : 0;
            var union = vendas.Union(recebimentos).Sum(a => a.soma);

            var result = union - sub + sublanctoentradassaida;

            if (vendas.Count > 0) { vendass += vendas[0].soma; }
            if (recebimentos.Count > 0) { contasrecebidas += recebimentos[0].soma; }
            if (pagamentos.Count > 0) { contaspagas += pagamentos[0].soma; }
            

            /*if (union != null)
            {
                return result;
            }*/

            if (vendas.Count > 0) { return vendas[0].soma; }

            



           

            return 0;
 

        }


        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        

        public void ShowCampos()
        {

            BarTumEntities context = new BarTumEntities();



            int x = 160;
            int y = 18;

            int x_ = 35;
            int y_ = 16;

            int cont = 0;

            var item = (from a in context.EB_FormaPagamento where a.Flexcluido == false && a.CondicaoID != 3  orderby a.ordem ascending select a).ToList();

            decimal total  = 0;
            foreach (var formas in item)
            {


               

                Label label;
                TextBox DynButton;
                Control ControlObject;
                Control ControlObject2;



                string ControlType = "System.Windows.Forms.TextBox";
                string ControlType2 = "System.Windows.Forms.Label";
                string ControlName = "campo" + formas.FormaPagamentoID;
                string ControlName2 = "label" + formas.FormaPagamentoID;


                System.Reflection.Assembly asm;
                asm = typeof(Form).Assembly;
                ControlObject = (System.Windows.Forms.Control)asm.CreateInstance(ControlType);
                ControlObject.Name = ControlName;
                ControlObject.Location = new System.Drawing.Point(x, y);

                System.Reflection.Assembly asm2;
                asm2 = typeof(Form).Assembly;
                ControlObject2 = (System.Windows.Forms.Control)asm2.CreateInstance(ControlType2);
                ControlObject2.Name = ControlName2;
                ControlObject2.Location = new System.Drawing.Point(x_, y_);

                panel1.Controls.Add(ControlObject2);
                panel1.Controls.Add(ControlObject);



                

                label = (System.Windows.Forms.Label)ControlObject2;
                label.Text = formas.dsForma + " : ";
                //label.AutoSize = true;
                label.Width = 120;
                label.TextAlign = ContentAlignment.MiddleRight;


                                        
               


                DynButton = (System.Windows.Forms.TextBox)ControlObject;
                DynButton.Width = 200;
                DynButton.Height = 21;
                DynButton.TextAlign = HorizontalAlignment.Right;
                DynButton.ReadOnly = true;
                DynButton.Font = new System.Drawing.Font("Arial",10, FontStyle.Bold);
                DynButton.Text = "R$ 0,00";


                panel1.Controls["campo" + formas.FormaPagamentoID].Text = "R$ 0,00";

                decimal tot = vendasPorFormas(formas.FormaPagamentoID);

                if (tot != 0)
                {
                    //SE FOR DINHEIRO CONTABILIZA O SALDO INCICIAL DO CAIXA
                    if (formas.FormaPagamentoID == 1)
                    {
                        /*decimal valorAbertura = Convert.ToDecimal(txtValorAbertura.Text.Replace("R$ ", "").Replace(".", ""));
                        panel1.Controls["campo" + formas.FormaPagamentoID].Text = (tot + valorAbertura).ToString("C2");
                        total += tot + valorAbertura;*/
                        panel1.Controls["campo" + formas.FormaPagamentoID].Text = tot.ToString("C2");
                        total += tot;
                    }
                    else
                    {
                        panel1.Controls["campo" + formas.FormaPagamentoID].Text = tot.ToString("C2");
                        total += tot;
                    }
                }
               
               


                cont = cont + 1;


                if (cont % 1 == 0)
                {

                    x = 160;
                    y = y + 25;

                    x_ = 35;
                    y_ = y_ + 25;
                }

            }


            /*
            MessageBox.Show("Vendas: " + vendass.ToString()); 
            MessageBox.Show("Recebi.: " + contasrecebidas.ToString());
            MessageBox.Show("Paga: " + contaspagas.ToString());
            */

            vendass = 0; contasrecebidas = 0; contaspagas = 0;

            textBox1.Text = total.ToString("C2");
        }

    

        private void txtFechamentoSaldoComputado_TextChanged(object sender, EventArgs e)
        {

        }




        #region mascaras
        //máscaras
        string str = "";
        private void Mask_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
        private void Mask_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion mascaras

        private void txtFechamentoTotalEmCaixa_Leave(object sender, EventArgs e)
        {
            str = "";

            decimal diferenca = 0;
            decimal saldoComputado = 0;
            decimal totalNoCaixa = 0;

       
            saldoComputado = Convert.ToDecimal(txtFechamentoSaldoComputado.Text.Replace("R$ ", "").Replace(".", ""));
            if (txtFechamentoTotalEmCaixa.Text != "")
            {
                totalNoCaixa = Convert.ToDecimal(txtFechamentoTotalEmCaixa.Text.Replace("R$ ", "").Replace(".", ""));
            }
            else
            {
                txtFechamentoTotalEmCaixa.Text = "R$ 0,00";
                totalNoCaixa = 0;
            }
            diferenca = (totalNoCaixa - saldoComputado);


            if (diferenca < 0)
            {
                txtFechamentoDiferenca.BackColor = Color.Red;
                txtFechamentoDiferenca.ForeColor = Color.White;
            }
            else
            {
                txtFechamentoDiferenca.BackColor = Color.FromArgb(192, 255, 192);
                txtFechamentoDiferenca.ForeColor = Color.Black;
            }

            txtFechamentoDiferenca.Text = diferenca.ToString("C2");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls["campo11"].Text = "merda";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFechamentoFundoCaixaPosterior_Leave(object sender, EventArgs e)
        {
            str = "";
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFechamentoTotalEmCaixa.Text == "" || txtFechamentoTotalEmCaixa.Text == "R$ 0,00")
                {
                    MessageBox.Show("É necessário informar o total contabilizado no caixa", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFechamentoTotalEmCaixa.Focus();
                    return;
                }


                BarTumEntities context = new BarTumEntities();

                decimal id = CaixaemContexto.CaixaID;
                decimal saldoComputado = Convert.ToDecimal(txtFechamentoSaldoComputado.Text.Replace("R$ ", "").Replace(".", ""));
                decimal totalEmCaixa = Convert.ToDecimal(txtFechamentoTotalEmCaixa.Text.Replace("R$ ", "").Replace(".", ""));
                decimal diferenca = Convert.ToDecimal(txtFechamentoDiferenca.Text.Replace("R$ ", "").Replace(".", ""));
                decimal fundoDiaPosterior = Convert.ToDecimal(txtFechamentoFundoCaixaPosterior.Text.Replace("R$ ", "").Replace(".", ""));

                DateTime inicio = new DateTime(dataContexto.Year, dataContexto.Month, dataContexto.Day, 0, 0, 0);
                DateTime fim = new DateTime(dataContexto.Year, dataContexto.Month, dataContexto.Day, 23, 59, 59);

                var query_vendasAbertasnadata = context.EB_Lancamento.Where(a => a.dtLancto >= inicio && a.dtLancto <= fim && a.StatusID != 3).ToList();
                if (query_vendasAbertasnadata.Count > 0)
                {
                    MessageBox.Show("Não foi possível fechar o caixa, existem vendas em aberto.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res;
                res = MessageBox.Show(this, "Confirmar fechamento do caixa?", "BarTum", buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (res == DialogResult.No)
                {
                    return;
                }

                /*EB_Caixa caixa = context.EB_Caixa.Single(a => a.CaixaID == id);
                caixa.fechamentoSaldoComputado = saldoComputado;
                caixa.fechamentoTotalFisicoCaixa = totalEmCaixa;
                caixa.fechamentoDiferenca = diferenca;
                caixa.fechamentoFundoCaixaDiaPosterior = fundoDiaPosterior;
                caixa.dtCaixaFechamento = DateTime.Now;
                caixa.UsuarioIDFechamento = frmMain.UsuarioLogado;
                caixa.dsStatus = "fechado";


                EB_CaixaHistoricoFechamento historico = new EB_CaixaHistoricoFechamento();
                historico.UsuarioID = Convert.ToDecimal(caixa.UsuarioIDFechamento);
                historico.CaixaID = caixa.CaixaID;
                historico.fechamentoSaldoComputado = caixa.fechamentoSaldoComputado;
                historico.fechamentoTotalFisicoCaixa = caixa.fechamentoTotalFisicoCaixa;
                historico.fechamentoDiferenca = caixa.fechamentoDiferenca;
                historico.fechamentoFundoCaixaDiaPosterior = caixa.fechamentoFundoCaixaDiaPosterior;
                historico.dtCaixaFechamento =  caixa.dtCaixaFechamento;
                caixa.EB_CaixaHistoricoFechamento.Add(historico);

                context.SaveChanges();*/

                MessageBox.Show("Caixa fechado com sucesso!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception error)
            {
                MessageBox.Show("Houve um erro na tentativa de fechar o caixa: " + error.Message, "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmLancamentoCadastro frm = new frmLancamentoCadastro();
            frm.frmCaixaFluxo = this;
            frm.ShowDialog();
        }

        

        private void históricoDeFechamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaixaHistoricoFechamento frm = new frmCaixaHistoricoFechamento();
            frm.frmCaixaFluxo = this;
            frm.ShowDialog();

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            using (BarTumEntities cont = new BarTumEntities())
            {
                try
                {
                    if (CaixaemContexto == null)
                    {
                        MessageBox.Show("O caixa não foi aberto na data " + dataCaixa.Value.ToString("dd/MM/yyyy") + ".", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }



                    //atualiza campo "diferença"
                    txtFechamentoTotalEmCaixa_Leave(null, null);

                    if (txtFechamentoTotalEmCaixa.Text == "" || txtFechamentoTotalEmCaixa.Text == "R$ 0,00")
                    {
                        MessageBox.Show("É necessário informar o total contabilizado no caixa", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFechamentoTotalEmCaixa.Focus();
                        return;
                    }





                    BarTumEntities context = new BarTumEntities();



                    decimal id = CaixaemContexto.CaixaID;
                    decimal saldoComputado = Convert.ToDecimal(txtFechamentoSaldoComputado.Text.Replace("R$ ", "").Replace(".", ""));
                    decimal totalEmCaixa = Convert.ToDecimal(txtFechamentoTotalEmCaixa.Text.Replace("R$ ", "").Replace(".", ""));
                    decimal diferenca = Convert.ToDecimal(txtFechamentoDiferenca.Text.Replace("R$ ", "").Replace(".", "").Replace("(", "").Replace(")", ""));
                    decimal fundoDiaPosterior = Convert.ToDecimal(txtFechamentoFundoCaixaPosterior.Text.Replace("R$ ", "").Replace(".", ""));

                    DateTime inicio = new DateTime(dataContexto.Year, dataContexto.Month, dataContexto.Day, 0, 0, 0);
                    DateTime fim = new DateTime(dataContexto.Year, dataContexto.Month, dataContexto.Day, 23, 59, 59);

                    //var query_vendasAbertasnadata = context.EB_Lancamento.Where(a => a.dtLancto >= inicio && a.dtLancto <= fim && a.StatusID != 3 && a.flVendaCancelada == false).ToList();
                    var query_vendasAbertasnadata = cont.EB_Lancamento.Where(a => a.CaixaID == id && a.StatusID != 3 && a.flVendaCancelada == false).ToList();
                    if (query_vendasAbertasnadata.Count > 0)
                    {
                        MessageBox.Show("Não foi possível fechar o caixa, existem (" + query_vendasAbertasnadata.Count.ToString()+ ") vendas em aberto.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }



                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult res;
                    res = MessageBox.Show(this, "Confirmar fechamento do caixa?", "BarTum", buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (res == DialogResult.No)
                    {
                        return;
                    }





                    EB_Caixa caixa = cont.EB_Caixa.Single(a => a.CaixaID == id);
                    /*caixa.fechamentoSaldoComputado = saldoComputado;
                    caixa.fechamentoTotalFisicoCaixa = totalEmCaixa;
                    caixa.fechamentoDiferenca = diferenca;
                    caixa.fechamentoFundoCaixaDiaPosterior = fundoDiaPosterior;
                    caixa.dtCaixaFechamento = DateTime.Now;
                    caixa.UsuarioIDFechamento = frmMain.UsuarioLogado;
                    caixa.dsStatus = "fechado";*/


                    EB_CaixaHistoricoFechamento historico = caixa.EB_CaixaHistoricoFechamento.First(a => a.CaixaID == id);
                    historico.UsuarioIDFechamento = Convert.ToDecimal(frmMain.UsuarioLogado);
                    historico.fechamentoSaldoComputado = saldoComputado;
                    historico.fechamentoTotalFisicoCaixa = totalEmCaixa;
                    historico.fechamentoDiferenca = diferenca;
                    //historico.fechamentoFundoCaixaDiaPosterior = fundoDiaPosterior;
                    historico.dtCaixaFechamento = DateTime.Now;
                    historico.dsStatus = "fechado";
                    cont.SaveChanges();

                    MessageBox.Show("Caixa fechado com sucesso!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMain = (frmMain)this.MdiParent;
                    frmMain.frmMain_Load(null, null);

                }
                catch (Exception error)
                {
                    MessageBox.Show("Houve um erro na tentativa de fechar o caixa: " + error.Message, "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmMain = (frmMain)this.MdiParent;

            frmPrimeiroAcessoCaixa frm = new frmPrimeiroAcessoCaixa();
            frm.Caixa = frmMain.Caixa;
            frm.MdiParent = frmMain;
            frm.Show();
            frm.Focus();
        }

    }
}
