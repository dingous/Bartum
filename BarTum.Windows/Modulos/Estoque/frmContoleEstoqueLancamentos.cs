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

namespace BarTum.Windows.Modulos.Estoque
{
    public partial class frmContoleEstoqueLancamentos : Form
    {
        public BarTumEntities _context = new BarTumEntities();
        public frmControleEstoque frmControleEstoque;

        public frmContoleEstoqueLancamentos()
        {
            InitializeComponent();
        }

        private void frmContoleEstoqueLancamentos_Load(object sender, EventArgs e)
        {
            populaGridView("ENTRADA");
        }

        public void populaGridView(string tipo)
        {
            try
            {
                if (tipo == "ENTRADA")
                {
                    eB_EstoqueLanctoBindingSource.DataSource = _context.EB_EstoqueLancto.Where(a => a.TipoMovID == 1).OrderByDescending(a => a.dtLancto);
                    
                }
                else if (tipo == "SAIDA")
                {
                    eB_EstoqueLanctoBindingSource.DataSource = _context.EB_EstoqueLancto.Where(a => a.TipoMovID == 2).OrderByDescending(a => a.dtLancto);
                }
            }catch(Exception error)
            {

            }
        }

        private void toolStripButtonemAberto_Click(object sender, EventArgs e)
        {
            populaGridView("ENTRADA");
        }

        private void toolStripFechadas_Click(object sender, EventArgs e)
        {
            populaGridView("SAIDA");
        }

        private void eB_EstoqueLanctoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmControleEstoque != null)
            {
                decimal id = Convert.ToDecimal(eB_EstoqueLanctoDataGridView.Rows[eB_EstoqueLanctoDataGridView.CurrentRow.Index].Cells[0].Value);
                frmControleEstoque.id = id;
                frmControleEstoque.FrmControleEstoque_Load(null, null);
                frmControleEstoque.cancelaMudancas();
                this.Close();
            }
        }
    }
}
