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

    public partial class frmSelecionaImpressoraPedido : Form
    {
        public frmIncluirProduto frmIncluirProduto;
        public List<EB_OrigemProduto> printers;

        public frmSelecionaImpressoraPedido()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelecionaImpressoraPadraoFechamento_Load(object sender, EventArgs e)
        {
            eB_OrigemProdutoBindingSource.DataSource = this.printers;
        }

        private void eB_OrigemProdutoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cod = Convert.ToInt32(eB_OrigemProdutoDataGridView.Rows[e.RowIndex].Cells[0].Value);
            frmIncluirProduto.pedido.totalcolunas = Convert.ToInt32(printers.Single(a => a.OrigemID == cod).tamanhoPapelImpressoraMilimetros);
            frmIncluirProduto.pedido.aceitaAcentuacao = printers.Single(a => a.OrigemID == cod).flPossuiAcentuacao;
            frmIncluirProduto.origem = printers.Single(a => a.OrigemID == cod);
            this.Close();
        }
    }
}
