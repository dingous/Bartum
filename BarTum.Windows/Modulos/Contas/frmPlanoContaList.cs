using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Contas
{
    public partial class frmPlanoContaList : Form
    {
        

        public frmPlanoContasCadastro frmPlanoContasCadastro;
        public frmContasPagarCadastro frmContasPagarCadastro;
        public frmContasReceberCadastro frmContasReceberCadastro;


        public frmPlanoContaList()
        {
            InitializeComponent();
        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmPlanoContasCadastro frm = new frmPlanoContasCadastro();
            frm.frmPlanoContaList = this;
            frm.ShowDialog();
        }

        public void populaGrid()
        {
            BarTumEntities _context = new BarTumEntities();

            var query = (from planos in _context.EB_PlanoContas
                         orderby planos.PlanoContaID ascending
                         select new
                         {
                             planos.PlanoContaID,
                             planos.dsPlanoConta,
                             EB_TipoLancto = planos.EB_TipoLancto.dsTipoLancto

                         }).ToList();

            eB_PlanoContasBindingSource.DataSource = query;

        }

        private void frmPlanoContaList_Load(object sender, EventArgs e)
        {
            populaGrid();
            eB_PlanoContasDataGridView.CellDoubleClick += delegate { CellDoubleClick(); };
        }


        public void CellDoubleClick()
        {
            decimal id = Convert.ToDecimal(eB_PlanoContasDataGridView.Rows[eB_PlanoContasDataGridView.CurrentRow.Index].Cells[0].Value);

            if (frmContasPagarCadastro != null)
            {
                this.frmContasPagarCadastro.populaPlanoContas();
                this.frmContasPagarCadastro.combo.SelectedValue = id;
                this.Close();
            }
            else if (frmContasReceberCadastro != null)
            {
                this.frmContasReceberCadastro.populaPlanoContas();
                this.frmContasReceberCadastro.combo.SelectedValue = id;
                this.Close();
            }
            else if (frmPlanoContasCadastro != null)
            {
                this.frmPlanoContasCadastro.codigoPai.Text = id.ToString();
                this.Close();
                return;
            }
            else
            {
                frmPlanoContasCadastro frm = new frmPlanoContasCadastro();
                frm.frmPlanoContaList = this;
                frm.idPlano = id;
                frm.ShowDialog();
            }
        }

       

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(eB_PlanoContasDataGridView.Rows[eB_PlanoContasDataGridView.CurrentRow.Index].Cells[0].Value);

            List<int> lista = new List<int> { 1, 2};

            if (lista.Contains(id))
            {
                MessageBox.Show("O ítem selecionado é um Plano de Contas padrão do sistema ele não pode ser alterado ou removido.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmPlanoContasCadastro frm = new frmPlanoContasCadastro();
            frm.frmPlanoContaList = this;
            frm.idPlano = id;
            frm.ShowDialog();

        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eB_PlanoContasDataGridView.Rows[eB_PlanoContasDataGridView.CurrentRow.Index].Cells[0].Value);

            frmPlanoContasCadastro frm = new frmPlanoContasCadastro();
            frm.frmPlanoContaList = this;
            frm.idPlano = id;
            frm.consulta = true;
            frm.ShowDialog();
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eB_PlanoContasDataGridView.Rows[eB_PlanoContasDataGridView.CurrentRow.Index].Cells[0].Value);

            List<int> lista = new List<int> { 1, 2 };

            if (lista.Contains(id))
            {
                MessageBox.Show("O ítem selecionado é um Plano de Contas padrão do sistema ele não pode ser alterado ou removido.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
