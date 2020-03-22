using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmAdiantamentoHistorico : Form
    {
        public frmAtendimento frmAtendimento;
        private BarTumEntities _context = new BarTumEntities();

        public frmAdiantamentoHistorico()
        {
            InitializeComponent();
        }

        private void frmAdiantamentoHistorico_Load(object sender, EventArgs e)
        {
            decimal idLancto = Convert.ToDecimal(this.frmAtendimento.LanctoID.Text);

            var query = (from adiantamentos in _context.EB_LancamentoAdiantamentos orderby adiantamentos.dtDataHora ascending
                         where adiantamentos.LanctoID == idLancto
                         select new
                         {
                             LanctoID = adiantamentos.LanctoID,
                             FormaPagamentoID = adiantamentos.EB_FormaPagamento.dsForma,
                             vlTotalAPagarContaNoMomento = adiantamentos.vlTotalAPagarContaNoMomento,
                             vlPagamentoCliente = adiantamentos.vlPagamentoCliente,
                             vlRecebidoCliente = adiantamentos.vlRecebidoCliente,
                             vlTroco = adiantamentos.vlTroco,
                             dsObservacao = adiantamentos.dsObservacao,
                             dtDataHora = adiantamentos.dtDataHora

                         });


            eB_LancamentoAdiantamentosBindingSource.DataSource = query;


            calculaTotal();
        }


        private void calculaTotal()
        {
            double tot = 0;
            int i = 0;
            try
            {

                for (i = 0; i < eB_LancamentoAdiantamentosDataGridView.Rows.Count; i++)
                {
                    tot = tot + Convert.ToDouble(eB_LancamentoAdiantamentosDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn13"].Value);
                }
            }catch(Exception error)
            {
            }

            txtTotalAdiantamentos.Text = tot.ToString("c2");
        
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdiantamentoHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Escape:
                    this.Close();
                    break;


            }
        }
    }
}
