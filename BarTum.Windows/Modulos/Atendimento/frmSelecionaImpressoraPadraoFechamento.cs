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

    public partial class frmSelecionaImpressoraPadraoFechamento : Form
    {
        public   frmAtendimento frmAtendimento;

        public frmSelecionaImpressoraPadraoFechamento()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelecionaImpressoraPadraoFechamento_Load(object sender, EventArgs e)
        {
            eB_OrigemProdutoBindingSource.DataSource = this.frmAtendimento.FechaVendaimpressoras;
        }

        private void eB_OrigemProdutoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            BarTumEntities _context = new BarTumEntities();
            decimal cod = Convert.ToDecimal(eB_OrigemProdutoDataGridView.Rows[e.RowIndex].Cells[0].Value);
            var itensImpressao = _context.EB_OrigemProduto.Single(cl => cl.OrigemID == cod);

            this.frmAtendimento.FechaVendaImpressoraSelecionada = itensImpressao.dsImpressora;
            this.frmAtendimento.larguraPapel = Convert.ToInt32(itensImpressao.tamanhoPapelImpressoraMilimetros);
            this.Close();
        }
    }
}
