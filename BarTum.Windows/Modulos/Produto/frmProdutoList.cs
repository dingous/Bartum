using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Windows.Modulos.Atendimento;
using BarTum.Windows.Modulos.Estoque;

namespace BarTum.Windows.Modulos.Produto
{
    public partial class frmProdutoList : Form
    {
        BarTumEntities _context = new BarTumEntities();

        public frmIncluirProduto frmIncluirProduto {get; set;}
        public frmProdutoCadastro frmProdutoCadastro { get; set; }
        public frmControleEstoque frmControleEstoque { get; set; }
        public frmIncluirAdicional frmIncluirAdicional { get; set; }

        public frmProdutoList()
        {
            InitializeComponent();
        }

        private void frmProdutoList_Load(object sender, EventArgs e)
        {
            populaGridview(null);

                        
            eB_ProdutoDataGridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(eB_ProdutoDataGridView_CellMouseDoubleClick);
                        
            
            if (eB_ProdutoDataGridView.RowCount > 0)
            {
                eB_ProdutoDataGridView.Rows[0].Selected = true;
            }


            this.eB_ProdutoDataGridView.Columns["dataGridViewTextBoxColumn10"].DefaultCellStyle.Format = "c2";
        }

        public void populaGridview(string criterio)
        {

            try
            {
                var query = (from produto in _context.EB_Produto.AsEnumerable()
                             where 
                             1 == 1
                             //produto.flExcluido == false
                             orderby produto.ProdutoID descending
                             select new
                             {
                                 ProdutoID = produto.ProdutoID.ToString(),
                                 produto.dsProduto,
                                 produto.nrPrecoVenda,
                                 Grupo = produto.EB_GrupoProduto.dsGrupo,
                                 tipoProduto = produto.EB_TipoProduto.dsTipoProduto,
                                 nrEstoqueAtual = produto.nrEstoqueAtual,
                                 flExcluido = produto.flExcluido == true ? "Excluído" : "Ativo"
                             });

                if (criterio != null)
                {
                    query = query.Where(
                                            a => a.ProdutoID.Equals(criterio) ||
                                            a.dsProduto.Contains(criterio) ||
                                            a.Grupo.Contains(criterio)

                                        );
                }


                query = query.ToList();
                eB_ProdutoBindingSource.DataSource = query;


            }catch(Exception error)
            {

            }


           

        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmProdutoCadastro ProdutoCadastro = new frmProdutoCadastro();
            ProdutoCadastro.frmProdutoList = this;
            ProdutoCadastro.ShowDialog();
        }

       

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eB_ProdutoDataGridView.Rows[eB_ProdutoDataGridView.CurrentRow.Index].Cells[0].Value);
            frmProdutoCadastro ProdutoCadastro = new frmProdutoCadastro();
            ProdutoCadastro._id = id;
            ProdutoCadastro.frmProdutoList = this;
            ProdutoCadastro.ShowDialog();
        }

        private void eB_ProdutoDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            decimal idProduto = Convert.ToDecimal(eB_ProdutoDataGridView.Rows[eB_ProdutoDataGridView.CurrentRow.Index].Cells[0].Value);
            if (frmIncluirProduto != null)
            {
                BarTumEntities _context = new BarTumEntities();
                _context.Refresh(System.Data.Objects.RefreshMode.ClientWins, _context.EB_Produto);
                this.frmIncluirProduto.ProdutoID.Text = idProduto.ToString();
                this.frmIncluirProduto.nrQuantidade.Focus();
                this.Close();
            }
            else if (frmProdutoCadastro != null)
            {
                this.frmProdutoCadastro.prodCompostoCod.Value = idProduto;
                this.frmProdutoCadastro.prodCompostoCod_ValueChanged(null, null);
                this.Close();
            }
            else if (frmControleEstoque != null)
            {
                this.frmControleEstoque.prodCompostoCod.Value = idProduto;
                this.frmControleEstoque.prodCompostoCod_ValueChanged(null, null);
                this.Close();
            }
            else if (frmIncluirAdicional != null)
            {
                BarTumEntities _context = new BarTumEntities();
                _context.Refresh(System.Data.Objects.RefreshMode.ClientWins, _context.EB_Produto);
                this.frmIncluirAdicional.ProdutoID.Text = idProduto.ToString();
                this.frmIncluirAdicional.nrQuantidade.Focus();
                this.Close();
            }
            else
            {
                toolStripAlterar_Click(null, null);
            }


        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eB_ProdutoDataGridView.Rows[eB_ProdutoDataGridView.CurrentRow.Index].Cells[0].Value);
            frmProdutoCadastro ProdutoCadastro = new frmProdutoCadastro();
            ProdutoCadastro.frmProdutoList = this;
            ProdutoCadastro._id = id;
            ProdutoCadastro.consulta = true;
            ProdutoCadastro.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text;
            populaGridview(criterio);
        }

        private void frmProdutoList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eB_ProdutoDataGridView.Rows[eB_ProdutoDataGridView.CurrentRow.Index].Cells[0].Value);

            string message = "Você tem certeza que deseja excluir este registro?";
            string caption = "EasyBar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {

                var item = _context.EB_Produto.Single(a => a.ProdutoID == id);
                item.flExcluido = true;
                _context.SaveChanges();


                this.populaGridview("");
            }
        }

       
    }
}
