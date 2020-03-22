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
    public partial class frmPendentesBalcao : Form
    {

        private BarTumEntities _context = new BarTumEntities();


        public frmAtendimento frmAtendimento;

        public frmBuscar frmBuscar;
        public string tipoVisualizacao = "ABERTO";

        private object pai_;
        public object pai { get { return pai_; } set { pai_ = value; } }

        public frmPendentesBalcao()
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

        private void frmPendentesBalcao_Load(object sender, EventArgs e)
        {

            toolStripButtonemAberto.BackColor = Color.LightSkyBlue;
            toolStripFechadas.BackColor = Color.FromName("Control");

            populaGridItens();
            somaLinhas();

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


            txtBuscar.Focus();
        }




        public IEnumerable<GridBalcaoNovoClass> query;
        public void populaGridItens(string situacao = "ABERTO")
        {


            try
            {
                using (BarTumEntities contexto = new BarTumEntities())
                {


                    frmMain frmMain = Program.main;
                    var Caixacontexto = frmMain.Caixa.caixaContexto;

                    /*query = (from a in _context.EB_Lancamento.AsEnumerable().DefaultIfEmpty()
                             where a.TipoVendaID == 2 && a.flVendaCancelada == false
                               && a.CaixaID == Caixacontexto
                             orderby a.dtLancto descending
                             select new GridBalcaoClass
                               {
                                   LanctoID = a.LanctoID.ToString(),
                                   BalcaoID = a.EB_Balcao.dsBalcao,
                                   TotalPagar = a.EB_LancamentoItens.Sum(item => (decimal?)item.Total == null ? 0 : (decimal?)item.Total),
                                   totalItens = a.EB_LancamentoItens.Sum(item => (decimal?)item.Quantidade == null ? 0 : (decimal?)item.Quantidade),
                                   StatusID = (a.StatusID == 1 ? "ABERTO" : (a.StatusID == 2 ? "FECHANDO" : "FECHADO")),
                                   dtLancto = a.dtLancto,
                                   dtFechamento = a.dtFimLancto,
                                   dsNomeClienteBalcao = a.dsNomeClienteBalcao
                               }
                        */


                    query = _context.EB_Lancamento
                             .Where(a => a.TipoVendaID == 2 && a.flVendaCancelada == false && a.CaixaID == Caixacontexto)
                             .OrderByDescending(a => a.dtLancto)
                             .Select(
                             a => new GridBalcaoNovoClass
                             {
                                 LanctoID = a.LanctoID,
                                 BalcaoID = a.EB_Balcao.dsBalcao,
                                 TotalPagar = a.EB_LancamentoItens.Sum(item => (decimal?)item.Total == null ? 0 : (decimal?)item.Total),
                                 totalItens = a.EB_LancamentoItens.Sum(item => (decimal?)item.Quantidade == null ? 0 : (decimal?)item.Quantidade),
                                 StatusID = (a.StatusID == 1 ? "ABERTO" : (a.StatusID == 2 ? "FECHANDO" : "FECHADO")),
                                 dtLancto = a.dtLancto,
                                 dtFechamento = a.dtFimLancto,
                                 dsNomeClienteBalcao = a.dsNomeClienteBalcao
                             }
                            );

                    if (situacao == "ABERTO" || this.tipoVisualizacao == "FECHANDO")
                    {
                        query = query.Where(item => item.StatusID == "ABERTO" || item.StatusID == "FECHANDO");
                    }
                    else if (situacao == "FECHADO")
                    {

                        query = query.Where(item => item.StatusID == "FECHADO");

                    }

                    query = query.ToList();

                    eBLancamentoBindingSource.DataSource = null;
                    eBLancamentoBindingSource.DataSource = query;

                    eB_LancamentoDataGridView.DataSource = eBLancamentoBindingSource;
                }

            }
            catch (Exception error)
            {

            }


        }




        public void executaEvento()
        {
            if (frmBuscar != null)
            {
                this.frmBuscar.Close();
            }

            Form teste = this.ParentForm;

            this.frmAtendimento.ChamaVendaBalcao();

            decimal idVenda = Convert.ToDecimal(eB_LancamentoDataGridView.Rows[eB_LancamentoDataGridView.CurrentRow.Index].Cells[0].Value);
            this.frmAtendimento.carregaInformacoespeloIdVenda(idVenda);

            this.Close();
        }

        private void eB_LancamentoDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.tipoVisualizacao != "FECHADO")
            {
                executaEvento();
            }
        }

        private void eB_LancamentoDataGridView_CellMouseDoubleClick2(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text;
            populaGridItens();
        }


        private void frmPendentesBalcao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Enter:
                    executaEvento();
                    break;

                case Keys.Escape:
                    this.Close();
                    break;


            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            string criterio = txtBuscar.Text;


            if (e.KeyValue == 40)
            {
                eB_LancamentoDataGridView.Focus();
            }


            var busca = query.Where(a =>
                    a.LanctoID.Equals(criterio) ||
                    a.dsNomeClienteBalcao.Contains(criterio)
                    );

            eBLancamentoBindingSource.DataSource = null;
            eBLancamentoBindingSource.DataSource = busca;

        }

        private void toolStripButtonemAberto_Click(object sender, EventArgs e)
        {

            toolStripButtonemAberto.BackColor = Color.LightSkyBlue;
            toolStripFechadas.BackColor = Color.FromName("Control");


            this.tipoVisualizacao = "ABERTO";
            populaGridItens("ABERTO");
            somaLinhas();
        }

        private void toolStripFechadas_Click(object sender, EventArgs e)
        {


            toolStripButtonemAberto.BackColor = Color.FromName("Control");
            toolStripFechadas.BackColor = Color.LightSkyBlue;

            this.tipoVisualizacao = "FECHADO";
            populaGridItens("FECHADO");
            somaLinhas();
            eB_LancamentoDataGridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(eB_LancamentoDataGridView_CellMouseDoubleClick2);
            this.Text = "Vendas fechadas na presente data";
        }


    }


}
