using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;


namespace BarTum.Windows.Modulos.Caixa
{
    public partial class frmBoxEscolherCaixa : Form
    {
        public List<EB_Caixa> caixas;
        public frmCaixaFluxo frmCaixaFluxo;

        public frmBoxEscolherCaixa()
        {
            InitializeComponent();

            eB_CaixaHistoricoFechamentoDataGridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(eB_CaixaHistoricoFechamentoDataGridView_CellMouseDoubleClick);
            
        }

        private void frmBoxEscolherCaixa_Load(object sender, EventArgs e)
        {

            this.Text = "Caixas da data: " + caixas[0].dtCaixa.ToString("dd/MM/yyyy");

            var result =  caixas.Select(
                s => new
                {
                    CaixaID = s.CaixaID,
                    dtCaixaAbertura = s.EB_CaixaHistoricoFechamento.SingleOrDefault().dtCaixaAbertura,
                    dtCaixaFechamento = s.EB_CaixaHistoricoFechamento.SingleOrDefault().dtCaixaFechamento,
                }
                );

            
            eB_CaixaHistoricoFechamentoBindingSource.DataSource = result;

            
            
            
            
            
        }

        void eB_CaixaHistoricoFechamentoDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                decimal id = Convert.ToDecimal(eB_CaixaHistoricoFechamentoDataGridView.Rows[eB_CaixaHistoricoFechamentoDataGridView.CurrentRow.Index].Cells[0].Value);
                EB_Caixa caixa = this.caixas.Single(a => a.CaixaID == id);
                this.frmCaixaFluxo.CaixaContexto = caixa;
                this.frmCaixaFluxo.CaixaemContexto = caixa;
                this.frmCaixaFluxo.dataContexto = caixa.dtCaixa;
                this.Close();
            }

        

        
    }
}
