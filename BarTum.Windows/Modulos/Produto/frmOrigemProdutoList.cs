using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Produto
{
    public partial class frmOrigemProdutoList : Form
    {
        public frmOrigemProdutoList()
        {
            InitializeComponent();
        }


        public void populaGridview(string criterio)
        {

            BarTumEntities _context = new BarTumEntities();

            try
            {
                /*var query = (from origem in _context.EB_OrigemProduto.AsEnumerable()
                             orderby origem.OrigemID descending
                             select new
                             {
                                 OrigemID = origem.OrigemID.ToString(),
                                 dsOrigem = origem.dsOrigem.ToString(),
                                 dsImpressora = origem.dsImpressora.ToString()
                             });*/

                var query = _context.EB_OrigemProduto.OrderBy(a => a.dsOrigem).ToList();

                /*if (criterio != null)
                {
                    query = query.Where(
                                            a => a.OrigemID.Equals(criterio) ||
                                            a.dsOrigem.Contains(criterio) 
                                            
                                        );
                }*/

                eB_OrigemProdutoBindingSource.DataSource = query;


            }
            catch (Exception error)
            {

            }




        }




        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmOrigemProdutoCadastro frm = new frmOrigemProdutoCadastro();
            frm.frmOrigemProdutoList = this;
            frm.ShowDialog();
        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            int idGrupo = Convert.ToInt32(eB_OrigemProdutoDataGridView.Rows[eB_OrigemProdutoDataGridView.CurrentRow.Index].Cells[0].Value);
            frmOrigemProdutoCadastro frm = new frmOrigemProdutoCadastro();
            frm.frmOrigemProdutoList = this;
            frm.id = idGrupo;
            frm.ShowDialog();
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            int idGrupo = Convert.ToInt32(eB_OrigemProdutoDataGridView.Rows[eB_OrigemProdutoDataGridView.CurrentRow.Index].Cells[0].Value);
            frmOrigemProdutoCadastro frm = new frmOrigemProdutoCadastro();
            frm.frmOrigemProdutoList = this;
            frm.consulta = true;
            frm.id = idGrupo;
            frm.ShowDialog();
        }

        private void frmOrigemProdutoList_Load(object sender, EventArgs e)
        {
            populaGridview(null);
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
