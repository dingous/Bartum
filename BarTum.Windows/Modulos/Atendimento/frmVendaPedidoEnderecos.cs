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
    public partial class frmVendaPedidoEnderecos : Form
    {
        public BarTumEntities context = new BarTumEntities();

        public frmAtendimento frmAtendimento;


        public frmVendaPedidoEnderecos()
        {
            InitializeComponent();
        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmVendaPedidoCadastroEndereco frm = new frmVendaPedidoCadastroEndereco();
            frm.frmAtendimento = this.frmAtendimento;
            frm.idEndereco = 0; 
            frm.frmVendaPedidoEnderecos = this;
            frm.ShowDialog();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


        public void populaGridView()
        {
            decimal idCliente = Convert.ToDecimal(frmAtendimento.VendaPedido.ClienteID.Text);


            var query = (from eb_lanctopedidos in context.EB_LanctoPedidos.AsEnumerable()
                         join eb_cliente in context.EB_Cliente.AsEnumerable() on eb_lanctopedidos.ClienteID equals eb_cliente.ClienteID
                         join eb_endereco in context.EB_Endereco.AsEnumerable() on eb_lanctopedidos.EnderecoID equals eb_endereco.EnderecoID
                         join eb_lancamento in context.EB_Lancamento.AsEnumerable() on eb_lanctopedidos.LanctoID equals eb_lancamento.LanctoID
                         where
                           eb_cliente.ClienteID == idCliente &&
                           eb_lancamento.LanctoID != null
                         group new {  eb_cliente, eb_endereco, eb_lanctopedidos } by new
                         {
                             eb_cliente.dsNome,
                             eb_endereco.dsLogradouro,
                             eb_endereco.nrNumero,
                             eb_lanctopedidos.EnderecoID,
                             eb_cliente.ClienteID,
                             Nomebairro = eb_endereco.EB_Bairro.dsNome,
                             NomeCidade = eb_endereco.EB_Bairro.EB_Cidade.dsNome,
                             SiglaEstado = eb_endereco.EB_Bairro.EB_Cidade.EB_Estado.dsSigla
                         } into g
                         orderby  (Int64?)g.Count() descending
                         select new
                         {
                             EnderecoID = (Decimal?)g.Key.EnderecoID,
                             g.Key.dsNome,
                             ClienteID = (Decimal?)g.Key.ClienteID,
                             dsLogradouro = g.Key.dsLogradouro != "" ? String.Format("{0}, {1} - {2} - {3}-{4}", g.Key.dsLogradouro, g.Key.nrNumero, g.Key.Nomebairro, g.Key.NomeCidade, g.Key.SiglaEstado) : String.Empty,
                             totalVendas = (Int64?)g.Count()
                         });
            
        

            eB_EnderecoBindingSource.DataSource = null;
            eB_EnderecoBindingSource.DataSource = query;

        }

        private void frmVendaPedidoEnderecos_Load(object sender, EventArgs e)
        {
            populaGridView();
        }

        private void eB_EnderecoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            decimal idEndereco = Convert.ToDecimal(eB_EnderecoDataGridView.Rows[eB_EnderecoDataGridView.CurrentRow.Index].Cells[0].Value);
            decimal idLancto = Convert.ToDecimal(this.frmAtendimento.LanctoID.Text);

            var lancto = _context.EB_LanctoPedidos.Single(cl => cl.LanctoID == idLancto);
            lancto.EnderecoID = idEndereco;
            _context.SaveChanges();

            this.frmAtendimento.VendaPedido.populaCamposCliente2(idEndereco);
            this.Close();
        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            decimal idEndereco = Convert.ToDecimal(eB_EnderecoDataGridView.Rows[eB_EnderecoDataGridView.CurrentRow.Index].Cells[0].Value);

            frmVendaPedidoCadastroEndereco frm = new frmVendaPedidoCadastroEndereco();
            frm.frmAtendimento = this.frmAtendimento;
            frm.frmVendaPedidoEnderecos = this;
            frm.idEndereco = idEndereco;
            frm.ShowDialog();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            eB_EnderecoDataGridView_CellDoubleClick(null, null);
        }
    }
}
