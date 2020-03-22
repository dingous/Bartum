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
    public partial class frmGrupoProdutoList : Form
    {

        public frmProdutoCadastro frmProdutoCadastro;

        public frmGrupoProdutoList()
        {
            InitializeComponent();
        }



        public void populaGridview(string criterio)
        {

            BarTumEntities _context = new BarTumEntities();

            try
            {
                var query = (from grupo in _context.EB_GrupoProduto.AsEnumerable()
                             where grupo.flExcluido == false
                             orderby grupo.GrupoID descending
                             select new
                             {
                                 GrupoID = grupo.GrupoID.ToString(),
                                 grupo.dsGrupo
                             });

                if (criterio != null)
                {
                    query = query.Where(
                                            a => a.GrupoID.Equals(criterio) ||
                                            a.dsGrupo.Contains(criterio) 
                                        );
                }


                query = query.ToList();
                eB_GrupoProdutoBindingSource.DataSource = query;


            }
            catch (Exception error)
            {
                throw;
            }




        }


        private void frmGrupoProdutoList_Load(object sender, EventArgs e)
        {
            populaGridview(null);
        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmGrupoProdutoCadastro frm = new frmGrupoProdutoCadastro();
            frm.pai = this;
            frm.ShowDialog();
        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            int idGrupo = Convert.ToInt32(eB_GrupoProdutoDataGridView.Rows[eB_GrupoProdutoDataGridView.CurrentRow.Index].Cells[0].Value);
            frmGrupoProdutoCadastro frm = new frmGrupoProdutoCadastro();
            frm.pai = this;
            frm.id = idGrupo;
            frm.ShowDialog();
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            int idGrupo = Convert.ToInt32(eB_GrupoProdutoDataGridView.Rows[eB_GrupoProdutoDataGridView.CurrentRow.Index].Cells[0].Value);
            frmGrupoProdutoCadastro frm = new frmGrupoProdutoCadastro();
            frm.pai = this;
            frm.consulta = true;
            frm.id = idGrupo;
            frm.ShowDialog();
        }

        private void eB_GrupoProdutoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal id = Convert.ToDecimal(eB_GrupoProdutoDataGridView.Rows[eB_GrupoProdutoDataGridView.CurrentRow.Index].Cells[0].Value);

            if(frmProdutoCadastro != null)
            {
                frmProdutoCadastro.GrupoID.Value = id;
                frmProdutoCadastro.GrupoID_TextChanged(null, null);
                this.Close();
            }
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            int id = Convert.ToInt32(eB_GrupoProdutoDataGridView.Rows[eB_GrupoProdutoDataGridView.CurrentRow.Index].Cells[0].Value);

            string message = "Você tem certeza que deseja excluir este registro?";
            string caption = "EasyBar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                var item = _context.EB_GrupoProduto.Single(a => a.GrupoID == id);
                item.flExcluido = true;
                _context.SaveChanges();

                this.populaGridview("");
            }
        }
    }
}
