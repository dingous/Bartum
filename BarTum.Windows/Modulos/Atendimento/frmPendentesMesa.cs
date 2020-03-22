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
    public partial class frmPendentesMesa : Form
    {

        private BarTumEntities _context = new BarTumEntities();


        public frmAtendimento frmAtendimento;

        public frmBuscar frmBuscar;

        public string tipoVisualizacao = "ABERTO";


        private object pai_;
        public object pai { get { return pai_; } set { pai_ = value; } }

        public frmPendentesMesa()
        {
            InitializeComponent();
           
        }


        private void frmPendentesBalcao_Load(object sender, EventArgs e)
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




        public IEnumerable<GridMesaClass> query;
        public void populaGridItens()
        {

            frmMain frmMain = Program.main;
            var Caixacontexto = frmMain.Caixa.caixaContexto;

            try
            {
                using (BarTumEntities contexto = new BarTumEntities())
                {


                    DateTime inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    DateTime fim = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

                    /*query = (from a in contexto.EB_Lancamento.AsEnumerable().DefaultIfEmpty()
                             where a.TipoVendaID == 1 && a.flVendaCancelada == false
                                 //&& a.dtLancto >= inicio && a.dtLancto <= fim
                             && a.CaixaID == Caixacontexto
                             select new GridBalcaoClass
                                 {
                                     LanctoID = a.LanctoID.ToString(),
                                     MesaID = Convert.ToInt32(a.MesaID).ToString("D2"),
                                     TotalPagar = a.EB_LancamentoItens.Sum(item => (decimal?)item.Total == null ? 0 : (decimal?)item.Total),
                                     totalItens = a.EB_LancamentoItens.Sum(item => (decimal?)item.Quantidade == null ? 0 : (decimal?)item.Quantidade),
                                     StatusID = (a.StatusID == 1 ? "ABERTO" : (a.StatusID == 2 ? "FECHANDO" : "FECHADO")),
                                     dtLancto = a.dtLancto,
                                     dtFechamento = a.dtFimLancto,
                                     dsNomeClienteBalcao = a.dsNomeClienteBalcao,
                                     nrOcupantes = a.nrOcupantes.ToString(),
                                     NomeGarcon = a.EB_Garcon.dsNome
                                 }
                             ).ToList();*/

                        query = contexto.EB_Lancamento.Where(a => a.TipoVendaID == 1 && a.flVendaCancelada == false && a.CaixaID == Caixacontexto)
                        .Select(a => new GridMesaClass
                        {
                            LanctoID = a.LanctoID,
                            MesaID = a.MesaID,
                            TotalPagar = a.EB_LancamentoItens.Sum(item => (decimal?)item.Total == null ? 0 : (decimal?)item.Total),
                            totalItens = a.EB_LancamentoItens.Sum(item => (decimal?)item.Quantidade == null ? 0 : (decimal?)item.Quantidade),
                            StatusID = (a.StatusID == 1 ? "ABERTO" : (a.StatusID == 2 ? "FECHANDO" : "FECHADO")),
                            dtLancto = a.dtLancto,
                            dtFechamento = a.dtFimLancto,
                            dsNomeClienteBalcao = a.dsNomeClienteBalcao,
                            nrOcupantes = a.nrOcupantes,
                            NomeGarcon = a.EB_Garcon.dsNome
                        }
                             ).ToList();


                    if (query.Count() > 0)
                    {


                        if(this.tipoVisualizacao == "ABERTO" || this.tipoVisualizacao == "FECHANDO")
                        {
                            query = query.Where(a => a.StatusID == "ABERTO" || a.StatusID == "FECHANDO").OrderBy(a => a.dtLancto);
                        }
                        else if (this.tipoVisualizacao == "FECHADO")
                        {
                            query = query.Where(a => a.StatusID == "FECHADO").OrderByDescending(a => a.dtFechamento);
                        }


                        eBLancamentoBindingSource.DataSource = null;
                        eBLancamentoBindingSource.DataSource = query;
                        eB_LancamentoDataGridView.DataSource = null;
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
                MessageBox.Show(error.InnerException.Message);
                MessageBox.Show(error.Message);
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

                Form teste = this.ParentForm;

                this.frmAtendimento.ChamaVendaMesa();

                decimal idMesa = Convert.ToDecimal(eB_LancamentoDataGridView.Rows[eB_LancamentoDataGridView.CurrentRow.Index].Cells[0].Value);
                this.frmAtendimento.carregaInformacoes(idMesa);

                this.Close();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text;

            var busca = query.Where(a => 
                                    a.LanctoID.Equals(criterio) ||
                                    //a.MesaID.Contains(Convert.ToDecimal(criterio)) ||
                                    a.NomeGarcon.Contains(criterio) ||
                                    a.dtLancto.ToString().Contains(criterio) ||
                                    a.dtFechamento.ToString().Contains(criterio)
                                    );
            if (busca.Count() > 0)
            {
                eBLancamentoBindingSource.DataSource = null;
                eBLancamentoBindingSource.DataSource = busca;
            }
        }



        public void somaLinhas()
        {
            TotalPendentes.Text = "R$ 0,00";

            int totalLinhas = eB_LancamentoDataGridView.Rows.Count;

            
            if(totalLinhas > 0)
            {
                decimal soma = 0;
                for(int i = 0; i < totalLinhas; i++)
                {
                    if (eB_LancamentoDataGridView.Rows[i].Cells["TotalPagar"].Value != null)
                    {
                        soma += Convert.ToDecimal(eB_LancamentoDataGridView.Rows[i].Cells["TotalPagar"].Value);
                    }
                    
                }

                TotalPendentes.Text = soma.ToString("C2");
            }
        }

    }


}
