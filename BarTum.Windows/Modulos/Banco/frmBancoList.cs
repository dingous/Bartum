using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using BarTum.Entities;
using BarTum.Utilities;
using System.ComponentModel.DataAnnotations;
using BarTum.Windows.Modulos.Atendimento;
using BarTum.Windows.Modulos.Contas;

namespace BarTum.Windows.Modulos.Banco
{

    public partial class frmBancoList : Form
    {


        public BarTumEntities context = new BarTumEntities();
        public frmContasPagarCadastro frmContasPagarCadastro;
        public frmContasReceberCadastro frmContasReceberCadastro;


        public frmBancoList()
        {
            InitializeComponent();
        }


        public void populaGridview()
        {
           
            var query = (from item in context.EB_ContaCorrente
                         select item).OrderBy(item => item.dtCadastro).ToList();

            eB_ContaCorrenteBindingSource.DataSource = null;
            eB_ContaCorrenteBindingSource.DataSource = query;

        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmBancoCadastro frm = new frmBancoCadastro();
            frm.frmBancoList = this;
            frm.ShowDialog();
        }

        private void frmBancoList_Load(object sender, EventArgs e)
        {
            populaGridview();
            eB_ContaCorrenteDataGridView.CellDoubleClick += delegate { CellDoubleClick(); };

        }


        public void CellDoubleClick()
        {
            decimal id = Convert.ToDecimal(eB_ContaCorrenteDataGridView.Rows[eB_ContaCorrenteDataGridView.CurrentRow.Index].Cells[0].Value);

            if (frmContasPagarCadastro != null)
            {
                this.frmContasPagarCadastro.populaContas();
                this.frmContasPagarCadastro.txtContaCorrente.SelectedValue = id;
                this.Close();

            }
            else if (frmContasReceberCadastro != null)
            {
                this.frmContasReceberCadastro.populaContas();
                this.frmContasReceberCadastro.txtContaCorrente.SelectedValue = id;
                this.Close();
            }
        }


      



        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eB_ContaCorrenteDataGridView.Rows[eB_ContaCorrenteDataGridView.CurrentRow.Index].Cells[0].Value);
            frmBancoCadastro frm = new frmBancoCadastro();
            frm.frmBancoList = this;
            frm.id = id;
            frm.ShowDialog();
        }

      

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();
            int id = Convert.ToInt32(eB_ContaCorrenteDataGridView.Rows[eB_ContaCorrenteDataGridView.CurrentRow.Index].Cells[0].Value);

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

                    var item = _context.EB_ContaCorrente.Single(a => a.ContaID == id);

                    _context.DeleteObject(item);
                    _context.SaveChanges();
                    this.populaGridview();

                }catch(Exception error)
                {
                    MessageBox.Show(this, "Não foi possível excluir este registro, pois existem lançamentos vinculados a ele.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eB_ContaCorrenteDataGridView.Rows[eB_ContaCorrenteDataGridView.CurrentRow.Index].Cells[0].Value);
            frmBancoCadastro frm = new frmBancoCadastro();
            frm.id = id;
            frm.consulta = true;
            frm.ShowDialog();
        }





        private void frmBancoList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

            }
        }

       
    }
}
