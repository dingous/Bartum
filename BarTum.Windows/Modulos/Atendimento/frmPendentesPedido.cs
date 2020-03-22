using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Utilities;
using System.Data.Common;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmPendentesPedido : Form
    {

        private BarTumEntities _context = new BarTumEntities();
        public frmAtendimento frmAtendimento;
        public frmBuscar frmBuscar;


        private object pai_;
        public object pai { get { return pai_; } set { pai_ = value; } }


        public string tipoVisualizacao = "ABERTO";

        public frmPendentesPedido()
        {
            InitializeComponent();
            
        }


        public void somaLinhas()
        {
            TotalPendentes.Text = "R$ 0,00";

            int totalLinhas = eB_LancamentoDataGridView.Rows.Count;

            txtQuantidade.Text = totalLinhas.ToString();

            if (totalLinhas > 0)
            {
                decimal soma = 0;
                for (int i = 0; i < totalLinhas; i++)
                {
                    if (eB_LancamentoDataGridView.Rows[i].Cells["TotalPagar"].Value != null)
                    {
                        soma += Convert.ToDecimal(eB_LancamentoDataGridView.Rows[i].Cells["TotalPagar"].Value);
                    }

                }

                TotalPendentes.Text = soma.ToString("C2");
            }
        }


        public void somaLinhasTaxaEntrega()
        {
            TotalTaxaEntrega.Text = "R$ 0,00";

            int totalLinhas = eB_LancamentoDataGridView.Rows.Count;


            if (totalLinhas > 0)
            {
                decimal soma = 0;
                for (int i = 0; i < totalLinhas; i++)
                {
                    if (eB_LancamentoDataGridView.Rows[i].Cells["vlTaxaEntrega"].Value != null)
                    {
                        soma += Convert.ToDecimal(eB_LancamentoDataGridView.Rows[i].Cells["vlTaxaEntrega"].Value);
                    }

                }

                TotalTaxaEntrega.Text = soma.ToString("C2");
            }
        }

        private void frmPendentesBalcao_Load(object sender, EventArgs e)
        {

            toolStripButtonemAberto.BackColor = Color.LightSkyBlue;
            toolStripFechadas.BackColor = Color.FromName("Control");

            populaGridItens();

            somaLinhas();
            somaLinhasTaxaEntrega();

            txtBuscar.Focus();

            if (this.pai != null)
            {
                var tipo = this.pai.GetType();

                switch (tipo.Name)
                {
                    case "frmAtendimento":

                        this.frmAtendimento = (frmAtendimento)this.pai;

                        eB_LancamentoDataGridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(eB_LancamentoDataGridView_CellMouseDoubleClick); 

                        break;
                }

            }
        }




        public IEnumerable<GridEntregaClass> query;
        public void populaGridItens()
        {

      
            try
            {
                using (BarTumEntities contexto = new BarTumEntities())
                {

                    frmMain frmMain = Program.main;
                    var Caixacontexto = frmMain.Caixa.caixaContexto;
                    
                    /*query = (from eb_lanctopedidos in contexto.EB_LanctoPedidos.AsEnumerable()
                             join eb_cliente in contexto.EB_Cliente.AsEnumerable().DefaultIfEmpty() on eb_lanctopedidos.ClienteID equals eb_cliente.ClienteID
                             join eb_endereco in contexto.EB_Endereco.AsEnumerable().DefaultIfEmpty() on eb_lanctopedidos.EnderecoID equals eb_endereco.EnderecoID
                             join a in contexto.EB_Lancamento.AsEnumerable().DefaultIfEmpty() on eb_lanctopedidos.LanctoID equals a.LanctoID
                             where a.TipoVendaID == 3 && a.flVendaCancelada == false
                              && a.CaixaID == Caixacontexto

                             select new GridBalcaoClass
                                 {
                                     LanctoID = a.LanctoID.ToString(),
                                     TotalPagar = a.EB_LancamentoItens.Sum(item => (decimal?)item.Total == null ? 0 : (decimal?)item.Total),
                                     totalItens = a.EB_LancamentoItens.Sum(item => (decimal?)item.Quantidade == null ? 0 : (decimal?)item.Quantidade),
                                     StatusID = (a.StatusID == 1 ? "ABERTO" : (a.StatusID == 2 ? "FECHANDO" : "FECHADO")),
                                     dtLancto = a.dtLancto,
                                     dtFechamento = a.dtFimLancto,
                                     dsNomeClienteBalcao = a.dsNomeClienteBalcao,
                                     endereco = eb_endereco.dsLogradouro != "" ? String.Format("{0}, {1} - {2} - {3}-{4}", eb_endereco.dsLogradouro, eb_endereco.nrNumero, eb_endereco.EB_Bairro.dsNome, eb_endereco.EB_Bairro.EB_Cidade.dsNome, eb_endereco.EB_Bairro.EB_Cidade.EB_Estado.dsSigla) : String.Empty,
                                     nomeCLiente = eb_cliente.dsNome,
                                     entregador = eb_lanctopedidos.EB_Lancamento.EB_Entregador.dsNome,
                                     vlTaxaEntrega = eb_endereco.EB_Bairro.nrTaxaEntrega
                                 }
                                 );*/


                  

                    query = contexto.EB_LanctoPedidos.DefaultIfEmpty()
                            .Where(a => a.EB_Lancamento.TipoVendaID == 3 && a.EB_Lancamento.flVendaCancelada == false && a.EB_Lancamento.CaixaID == Caixacontexto)
                            .Select( a =>
                            new GridEntregaClass
                            {
                                LanctoID = a.LanctoID,
                                TotalPagar = a.EB_Lancamento.EB_LancamentoItens.Sum(item => (decimal?)item.Total == null ? 0 : (decimal?)item.Total),
                                totalItens = a.EB_Lancamento.EB_LancamentoItens.Sum(item => (decimal?)item.Quantidade == null ? 0 : (decimal?)item.Quantidade),
                                StatusID = (a.EB_Lancamento.StatusID == 1 ? "ABERTO" : (a.EB_Lancamento.StatusID == 2 ? "FECHANDO" : "FECHADO")),
                                dtLancto = a.EB_Lancamento.dtLancto,
                                dtFechamento = a.EB_Lancamento.dtFimLancto,
                                dsNomeClienteBalcao = a.EB_Lancamento.dsNomeClienteBalcao,
                                endereco = a.EB_Endereco.dsLogradouro != "" ? a.EB_Endereco.dsLogradouro +  ", " + a.EB_Endereco.nrNumero + " - " + a.EB_Endereco.EB_Bairro.dsNome + " - " + a.EB_Endereco.EB_Bairro.EB_Cidade.dsNome + "-" + a.EB_Endereco.EB_Bairro.EB_Cidade.EB_Estado.dsSigla : "",
                                nomeCLiente = a.EB_Lancamento.EB_Cliente.dsNome,
                                entregador = a.EB_Lancamento.EB_Entregador.dsNome,
                                vlTaxaEntrega = a.EB_Lancamento.EB_Cliente.EB_Endereco.EB_Bairro.nrTaxaEntrega
                            })
                            ;
                                




                    if (query.Count() > 0)
                    {
                        if (this.tipoVisualizacao == "ABERTO" || this.tipoVisualizacao == "FECHANDO")
                        {
                            query = query.Where(a => a.StatusID == "ABERTO" || a.StatusID == "FECHANDO").OrderBy(a => a.dtLancto);
                        }
                        else if (this.tipoVisualizacao == "FECHADO")
                        {
                            query = query.Where(a => a.StatusID == "FECHADO").OrderByDescending(a => a.dtFechamento);
                        }

                        eBLancamentoBindingSource.DataSource = query;
                        eB_LancamentoDataGridView.DataSource = eBLancamentoBindingSource;
                    }
                    else
                    {

                        eBLancamentoBindingSource.DataSource = null;
                        eB_LancamentoDataGridView.DataSource = eBLancamentoBindingSource;

                    }
                }
            }
            catch(Exception error)
            {

            }
        }



        private void eB_LancamentoDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (frmBuscar != null)
            {
                this.frmBuscar.Close();
            }

          if (this.tipoVisualizacao != "FECHADO")
          {
                this.frmAtendimento.ChamaVendaEntrega();

                decimal idVenda = Convert.ToDecimal(eB_LancamentoDataGridView.Rows[eB_LancamentoDataGridView.CurrentRow.Index].Cells[0].Value);
                var query = _context.EB_LanctoPedidos.Single(a => a.LanctoID == idVenda);

                this.frmAtendimento.carregaInformacoespeloIdVenda(query.LanctoID);
                this.frmAtendimento.VendaPedido.populaCamposCliente2(query.EnderecoID);
                this.Close();
          }
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text;
             //populaGridItens(criterio);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text;
            //populaGridItens(criterio);
        }

        private void toolStripButtonemAberto_Click(object sender, EventArgs e)
        {

            toolStripButtonemAberto.BackColor = Color.LightSkyBlue;
            toolStripFechadas.BackColor = Color.FromName("Control");
            

            this.tipoVisualizacao = "ABERTO";
            populaGridItens();
            somaLinhas();
            somaLinhasTaxaEntrega();
          
        }

        private void toolStripFechadas_Click(object sender, EventArgs e)
        {
            
            toolStripButtonemAberto.BackColor = Color.FromName("Control");
            toolStripFechadas.BackColor = Color.LightSkyBlue; 
            
            this.tipoVisualizacao = "FECHADO";

            populaGridItens();
            somaLinhas();
            somaLinhasTaxaEntrega();

           
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text;

            var busca = query.Where(a =>
                                    a.LanctoID.Equals(criterio) ||
                                    a.endereco.Contains(criterio) ||
                                    a.nomeCLiente.Contains(criterio) ||
                                    a.entregador.Contains(criterio) ||
                                    a.dtLancto.ToString().Contains(criterio) ||
                                    a.dtFechamento.ToString().Contains(criterio)
                                    );
            if (busca.Count() > 0)
            {
                eBLancamentoBindingSource.DataSource = null;
                eBLancamentoBindingSource.DataSource = busca;
            }
        }


    }


}
