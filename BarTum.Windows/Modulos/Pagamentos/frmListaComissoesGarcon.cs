using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Pagamentos
{
    public partial class frmListaComissoesGarcon : Form
    {
        BarTumEntities context = new BarTumEntities();
        public frmPagamentoComissaoGarcon frmPagamentoComissaoGarcon;
        public frmMain frmMain;


        private DateTime inicio;
        private DateTime fim;
        private decimal garcon;

        public frmListaComissoesGarcon()
        {
            InitializeComponent();
        }

        private void frmListaComissoesGarcon_Load(object sender, EventArgs e)
        {
            //identificar se a comissão foi paga ou não pela flag: flComissaoGarconFoiPaga
            
            populaGridView(false);
            
        }


        

        public void populaGridView(bool pagas)
        {
            this.inicio = frmPagamentoComissaoGarcon.dateTimeInicial.Value;
            this.fim = frmPagamentoComissaoGarcon.dateTimeFinal.Value;


            DateTime _inicio = new DateTime(this.inicio.Year, this.inicio.Month, this.inicio.Day, 0, 0, 0);
            DateTime _fim = new DateTime(this.fim.Year, this.fim.Month, this.fim.Day, 23, 59, 59);

            this.garcon = Convert.ToDecimal(frmPagamentoComissaoGarcon.comboBoxGarcons.SelectedValue);

            var query = context.EB_Lancamento.AsEnumerable()
                .Where(a => a.GarconID == this.garcon)
                .Where(a => a.dtFimLancto >= _inicio && a.dtFimLancto <= _fim)
                .Where(a => a.flVendaCancelada == false)
                .Where(a => a.TipoVendaID == 1)
                .Select(s => new
                {
                    data = s.dtLancto,
                    comissao = ((decimal)s.FechaTotalVendaFinalizada * ((decimal)s.EB_Garcon.nrComissao / 100)),
                    valor = s.FechaTotalVendaFinalizada,
                    porcentagem = s.EB_Garcon.nrComissao.ToString() + " %",
                    garcon = s.EB_Garcon.dsNome,
                    LanctoID = s.LanctoID,
                    situacao = s.flComissaoGarconFoiPaga == true ? "Pago" : "Não pago",
                    flComissaoGarconFoiPaga = s.flComissaoGarconFoiPaga
                }
                );
                //.OrderByDescending(o => o.data);
                if(pagas == false)
                {
                    query = query.Where(a => a.flComissaoGarconFoiPaga == false);
                }
                else if (pagas == true)
                {
                    query = query.Where(a => a.flComissaoGarconFoiPaga == true);
                }
        

                query = query.OrderByDescending(o => o.data);
                
                var query2 = query.ToList();     
                
            

            eB_LancamentoBindingSource.DataSource = query;
            eB_LancamentoDataGridView.DataSource = eB_LancamentoBindingSource;

            if (pagas == false && query2.Count > 0)
            {
                toolStripButton1.Enabled = true;
            }else
            {
                toolStripButton1.Enabled = false;
            }


            if (query2.Count > 0)
            {
                this.Text = "Comissão do garçon: " + query2[0].garcon + " do período de " + inicio.ToString("dd/MM/yyyy") + " até " + fim.ToString("dd/MM/yyyy");
            }

            TotalVenda();
            TotalComissao();
        }



        public void TotalVenda()
        {

            double tot = 0;
            int i = 0;
            for (i = 0; i < eB_LancamentoDataGridView.Rows.Count; i++)
            {
                tot = tot + Convert.ToDouble(eB_LancamentoDataGridView.Rows[i].Cells[2].Value);
            }

            TextBoxVendas.Text = tot.ToString("c2");
        }

        public void TotalComissao()
        {

            double tot = 0;
            int i = 0;
            for (i = 0; i < eB_LancamentoDataGridView.Rows.Count; i++)
            {
                tot = tot + Convert.ToDouble(eB_LancamentoDataGridView.Rows[i].Cells[3].Value);
            }

            TextBoxtotalComissoes.Text = tot.ToString("c2");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Confirmar pagamento de comissão do garçon?", "EasyBar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < eB_LancamentoDataGridView.Rows.Count; i++)
                    {
                        int idLancto = Convert.ToInt32(eB_LancamentoDataGridView.Rows[i].Cells[0].Value);
                        var query = context.EB_Lancamento.Single(a => a.LanctoID == idLancto);
                        query.flComissaoGarconFoiPaga = true;
                    }

                    var dadosGarcon = context.EB_Garcon.Single(a => a.GarconID == this.garcon);
                    
                    EB_Contas contas = new EB_Contas();
                    /**/
                    contas.pai = 0;
                    contas.FornecedorID = null;
                    contas.PlanoContaID = 5;
                    contas.TipoLanctoID = 2; //despesa
                    contas.descricao = "PAGAMENTO COMISSÃO DO GARÇON: " + dadosGarcon.dsNome;
                    contas.observacoes = "PAGAMENTO COMISSÃO DO GARÇON: " + dadosGarcon.dsNome + " - PERÍODO: de " + this.inicio + " até " + this.fim + " - TOTAL VENDAS: " + TextBoxVendas.Text.ToString() + " - TOTAL COMISSÃO: " + TextBoxtotalComissoes.Text;
                    contas.vlConta = Convert.ToDecimal(TextBoxtotalComissoes.Text.Replace("R$ ", "").Replace(".", ""));
                    contas.dtlancto = DateTime.Now;
                    contas.dtVencimento = DateTime.Now;
                    contas.flBaixada = true;
                    contas.dtPagamentoOuRecebimento = DateTime.Now;
                    contas.DestDescontoID = 1;
                    contas.FormaPagamentoID = 1;
                    contas.fechaValorPago = Convert.ToDecimal(TextBoxtotalComissoes.Text.Replace("R$ ", "").Replace(".", ""));

                    context.AddToEB_Contas(contas);

                    context.SaveChanges();

                    MessageBox.Show("Pagamento efetuado com sucesso!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


                }catch(Exception error)
                {


                }

                
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            populaGridView(true);
            toolStripButton1.Enabled = false;
            toolStripButton3.BackColor = Color.LightSkyBlue;
            toolStripButton2.BackColor = Color.FromName("Control");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            populaGridView(false);
            //toolStripButton1.Enabled = true;
            toolStripButton2.BackColor = Color.LightSkyBlue;
            toolStripButton3.BackColor = Color.FromName("Control");
        }
    }
}
