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

namespace BarTum.Windows.Modulos.Caixa
{
    public partial class frmCaixaHistoricoFechamento : Form
    {
        BarTumEntities context = new BarTumEntities();
        public frmCaixaFluxo frmCaixaFluxo;

        public frmCaixaHistoricoFechamento()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCaixaHistoricoFechamento_Load(object sender, EventArgs e)
        {
            /*this.Text = "Histórico de fechamento do caixa, da data: " + frmCaixaFluxo.CaixaemContexto[0].dtCaixa.ToString("dd/MM/yyyy");

            var query = (
                            from hist in context.EB_CaixaHistoricoFechamento.AsEnumerable()
                            join cx in context.EB_Caixa on hist.CaixaID equals cx.CaixaID
                            where cx.CaixaID == frmCaixaFluxo.CaixaemContexto[0].CaixaID
                            orderby hist.dtCaixaFechamento descending
                            select new
                            {
                                nomeUsuario = hist.EB_Usuario.dsNome,
                                fechamentoSaldoComputado = hist.fechamentoSaldoComputado,
                                fechamentoTotalFisicoCaixa = hist.fechamentoTotalFisicoCaixa,
                                fechamentoDiferenca = hist.fechamentoDiferenca,
                                dtCaixaFechamento = hist.dtCaixaFechamento,
                                fechamentoFundoCaixaDiaPosterior = hist.fechamentoFundoCaixaDiaPosterior
                            }

                            
                          ).ToList();

            eB_CaixaHistoricoFechamentoBindingSource.DataSource = query;
             */
        }
    }
}
