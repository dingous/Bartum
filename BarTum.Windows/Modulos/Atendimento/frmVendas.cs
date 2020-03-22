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
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }


        public void populaGridMesas()
        {
            BarTumEntities _context = new BarTumEntities();

            var result = (from a in _context.EB_Lancamento.DefaultIfEmpty()
                          where a.StatusID != 3 && a.TipoVendaID == 1
                          orderby a.dtLancto descending
                              select new
                              {
                                  LanctoID = a.LanctoID,
                                  MesaID = a.MesaID,
                                  Ocupantes = a.nrOcupantes,
                                  NomeGarcon = a.EB_Garcon.dsNome,
                                  Adiantamento = a.FechaAdiantamento,
                                  TotalPagar = a.EB_LancamentoItens.Sum(item => (decimal?)item.Total == null ? 0 : (decimal?)item.Total),
                                  totalItens = a.EB_LancamentoItens.Sum(item => (decimal?)item.Quantidade == null ? 0 : (decimal?)item.Quantidade),
                                  StatusID = (a.StatusID == 1 ? "ABERTO" : "FECHANDO"),
                                  dtLancto = a.dtLancto,
                                  dsNomeClienteBalcao = a.dsNomeClienteBalcao
                              }
                        );


            eB_LancamentoBindingSource.DataSource = result.ToList();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            populaGridMesas();
        }
    }
}
