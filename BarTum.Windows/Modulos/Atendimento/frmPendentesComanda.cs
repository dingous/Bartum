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
    public partial class frmPendentesComanda : Form
    {
        public frmAtendimento frmAtendimento;
        public frmBuscar frmBuscar;
        public string tipoVisualizacao = "ABERTO";
        private object pai_;
        public object pai { get { return pai_; } set { pai_ = value; } }



        public frmPendentesComanda()
        {
            InitializeComponent();
        }

        public void somaLinhas()
        {
            TotalPendentes.Text = "R$ 0,00";

            int totalLinhas = eB_LancamentoDataGridView.Rows.Count;


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


        private void frmPendentesComanda_Load(object sender, EventArgs e)
        {
            toolStripButtonemAberto.BackColor = Color.LightSkyBlue;
            toolStripFechadas.BackColor = Color.FromName("Control");

            populaGridItens();

            somaLinhas();

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


        public IEnumerable<GridcomandaClass> query;
        public void populaGridItens()
        {
            using (BarTumEntities cont = new BarTumEntities())
            {

                frmMain frmMain = Program.main;
                var Caixacontexto = frmMain.Caixa.caixaContexto;

                try
                {
                    /*query = (from a in cont.EB_Lancamento.AsEnumerable().DefaultIfEmpty()
                             where a.TipoVendaID == 5 && a.flVendaCancelada == false
                             && a.CaixaID == Caixacontexto
                             select new GridBalcaoClass
                             {
                                 LanctoID = a.LanctoID.ToString(),
                                 ComandaID = Convert.ToInt32(a.ComandaID).ToString("D4"),
                                 TotalPagar = a.EB_LancamentoItens.Sum(item => (decimal?)item.Total == null ? 0 : (decimal?)item.Total),
                                 totalItens = a.EB_LancamentoItens.Sum(item => (decimal?)item.Quantidade == null ? 0 : (decimal?)item.Quantidade),
                                 StatusID = (a.StatusID == 1 ? "ABERTO" : (a.StatusID == 2 ? "FECHANDO" : "FECHADO")),
                                 dtLancto = a.dtLancto,
                                 dtFechamento = a.dtFimLancto
                             }
                             );*/


                    query = cont.EB_Lancamento
                             .Where( a =>  a.TipoVendaID == 5 && a.flVendaCancelada == false
                             && a.CaixaID == Caixacontexto)
                             .Select(a => new GridcomandaClass
                             {
                                 LanctoID = a.LanctoID,
                                 ComandaID = a.ComandaID,
                                 TotalPagar = a.EB_LancamentoItens.Sum(item => (decimal?)item.Total == null ? 0 : (decimal?)item.Total),
                                 totalItens = a.EB_LancamentoItens.Sum(item => (decimal?)item.Quantidade == null ? 0 : (decimal?)item.Quantidade),
                                 StatusID = (a.StatusID == 1 ? "ABERTO" : (a.StatusID == 2 ? "FECHANDO" : "FECHADO")),
                                 dtLancto = a.dtLancto,
                                 dtFechamento = a.dtFimLancto
                             }
                                                 );



                    if (query.Count() > 0)
                    {

                        if (this.tipoVisualizacao == "ABERTO" || this.tipoVisualizacao == "FECHANDO")
                        {
                            query = query.Where(a => a.StatusID == "ABERTO" || a.StatusID == "FECHANDO").OrderBy(a => a.dtLancto);
                        }
                        else if (this.tipoVisualizacao == "FECHADO")
                        {
                            query = query.Where(item => item.StatusID == "FECHADO").OrderByDescending(a => a.dtFechamento);
                        }

                        eBLancamentoBindingSource.DataSource = null;
                        eBLancamentoBindingSource.DataSource = query;
                        eB_LancamentoDataGridView.DataSource = eBLancamentoBindingSource;
                    }
                    else
                    {

                        eBLancamentoBindingSource.DataSource = null;
                        eB_LancamentoDataGridView.DataSource = eBLancamentoBindingSource;


                    }
                }
                catch (Exception error)
                {

                }
            }
           
        }

        private void toolStripButtonemAberto_Click(object sender, EventArgs e)
        {
            toolStripButtonemAberto.BackColor = Color.LightSkyBlue;
            toolStripFechadas.BackColor = Color.FromName("Control");

            this.tipoVisualizacao = "ABERTO";

            populaGridItens();
            somaLinhas();
        }

        private void toolStripFechadas_Click(object sender, EventArgs e)
        {

            toolStripButtonemAberto.BackColor = Color.FromName("Control");
            toolStripFechadas.BackColor = Color.LightSkyBlue;

            this.tipoVisualizacao = "FECHADO";

            populaGridItens();
            somaLinhas();
           
        }


        private void eB_LancamentoDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.tipoVisualizacao != "FECHADO")
            {
                executaEvento();
            }
        }


        public void executaEvento()
        {
            if (frmBuscar != null)
            {
                this.frmBuscar.Close();
            }

            Form teste = this.ParentForm;

            this.frmAtendimento.ChamaVendaComanda();

            decimal idVenda = Convert.ToDecimal(eB_LancamentoDataGridView.Rows[eB_LancamentoDataGridView.CurrentRow.Index].Cells[1].Value);
            this.frmAtendimento.carregaInformacoespeloIdVenda(idVenda);

            this.Close();
        }
    }
}
