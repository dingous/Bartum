using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Windows.Modulos.Contas;
using BarTum.Windows.Modulos.Produto;
using BarTum.Windows.Modulos.Estoque;

namespace BarTum.Windows.Modulos.Fornecedor
{
    public partial class frmFornecedorList : Form
    {
        public frmContasPagarCadastro frmContasPagarCadastro;
        public frmProdutoCadastro frmProdutoCadastro;
        public frmControleEstoque frmControleEstoque;

        public BarTumEntities _context = new BarTumEntities();

        public frmFornecedorList()
        {
            InitializeComponent();
        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmFornecedorCadastro frm = new frmFornecedorCadastro();
            frm.frmFornecedorList = this;
            frm.ShowDialog();
        }



        public IEnumerable<GridClass> query;
        //public IEnumerable<EB_Fornecedor> query;
        public void populaGridview(string criterio)
        {


            query = null;
            //query  = _context.EB_Fornecedor.AsEnumerable();

            

         
                

                try
                {


                    query =
                       (from fornecedor in _context.EB_Fornecedor.AsEnumerable()
                        select new GridClass
                        {
                                FornecedorID = fornecedor.FornecedorID.ToString(),
                                dsNomeFantasia = fornecedor.dsNomeFantasia,
                                dsRazaoSocial = fornecedor.dsRazaoSocial
                        });

                    query = query.ToList();

                    eB_FornecedorBindingSource.DataSource = query;


                }
                catch (Exception erro)
                {

                }



                eB_FornecedorBindingSource.DataSource = null;
                eB_FornecedorBindingSource.DataSource = query;

            
        }

        private void frmFornecedorList_Load(object sender, EventArgs e)
        {
            populaGridview("");
            eB_FornecedorDataGridView.CellDoubleClick += delegate { CellDoubleClick(); };

        }


        public void CellDoubleClick()
        {
            decimal id = Convert.ToDecimal(eB_FornecedorDataGridView.Rows[eB_FornecedorDataGridView.CurrentRow.Index].Cells[0].Value);

            if(frmContasPagarCadastro != null)
            {
                
                this.frmContasPagarCadastro.txtFornecedorID.SelectedValue = id;
                this.frmContasPagarCadastro.populaFornecedores(id);
                this.Close();
            }
            else if (frmControleEstoque != null)
            {
                this.frmControleEstoque.FornecedorID.Value = id;
                this.frmControleEstoque.FornecedorID_ValueChanged(null, null);
                this.Close();
            }
            else if (frmProdutoCadastro != null)
            {
                this.frmProdutoCadastro.FornecedorID.Value = id;
                this.frmProdutoCadastro.FornecedorID_ValueChanged(null, null);
                this.Close();
            }
            else
            {
                toolStripAlterar_Click(null, null);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

    
           
            //var comando =  aa.CommandText;

            string criterio = txtBuscar.Text;

            try
            {
                var busca = query
                    .Where(a =>
                        a.FornecedorID.Equals(criterio) ||
                        a.dsNomeFantasia.Contains(criterio) ||
                        a.dsRazaoSocial.Contains(criterio) 

                        );

                eB_FornecedorBindingSource.DataSource = busca;


            }
            catch (Exception error)
            {
            }
        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {

            int idFornecedor = Convert.ToInt32(eB_FornecedorDataGridView.Rows[eB_FornecedorDataGridView.CurrentRow.Index].Cells[0].Value);


            frmFornecedorCadastro FornecedorCadastro = new frmFornecedorCadastro();
            FornecedorCadastro.frmFornecedorList = this;
            FornecedorCadastro.id = idFornecedor;
            FornecedorCadastro.ShowDialog();

      
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();
            int id = Convert.ToInt32(eB_FornecedorDataGridView.Rows[eB_FornecedorDataGridView.CurrentRow.Index].Cells[0].Value);

            string message = "Você tem certeza que deseja excluir este registro?";
            string caption = "EasyBar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                try
                {

                    var item = _context.EB_Fornecedor.Single(a => a.FornecedorID == id);

                    _context.DeleteObject(item);
                    _context.SaveChanges();
                    this.populaGridview("");

                }
                catch (Exception error)
                {
                    MessageBox.Show(this, "Não foi possível excluir este registro, pois existem registros dependentes a ele.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void eB_FornecedorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(eB_FornecedorDataGridView.Rows[eB_FornecedorDataGridView.CurrentRow.Index].Cells[0].Value);

            if (frmProdutoCadastro != null)
            {
                this.frmProdutoCadastro.FornecedorID.Value = id;
                this.frmProdutoCadastro.FornecedorID_ValueChanged(null, null);
                this.Close();
            }
        }
    }
}
