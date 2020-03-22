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
using BarTum.Windows.Modulos.Contas;


namespace BarTum.Windows.Modulos.Formas_pagamento
{

    public partial class frmFormasPagamentoList : Form
    {


        public BarTumEntities context = new BarTumEntities();
        public frmContasPagarCadastro frmContasPagarCadastro;
        public frmContasReceberCadastro frmContasReceberCadastro;


        public frmFormasPagamentoList()
        {
            InitializeComponent();
        }


        public void populaGridview()
        {

            var query = (from item in context.EB_FormaPagamento.AsEnumerable()
                         where item.Flexcluido == false
                         select new
                         {
                             item.FormaPagamentoID,
                             item.dsForma,
                             item.EB_FormaPagamentoCondicao.dsCondicaoPagamento,
                             item.ordem
                         }).OrderBy(item => item.ordem).ToList();

            eB_FormaPagamentoBindingSource.DataSource = null;
            eB_FormaPagamentoBindingSource.DataSource = query;

        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmFormasPagamentoCadastro frm = new frmFormasPagamentoCadastro();
            frm.frmFormasPagamentoList = this;
            frm.ShowDialog();
        }

        private void frmBancoList_Load(object sender, EventArgs e)
        {
            populaGridview();
            eB_FormaPagamentoDataGridView.CellDoubleClick += delegate { CellDoubleClick(); };

        }


        public void CellDoubleClick()
        {
            decimal id = Convert.ToDecimal(eB_FormaPagamentoDataGridView.Rows[eB_FormaPagamentoDataGridView.CurrentRow.Index].Cells[0].Value);

            if (this.frmContasPagarCadastro != null)
            {
                this.frmContasPagarCadastro.populaFormasPagamento();
                this.frmContasPagarCadastro.comboBoxFormaPagamento.SelectedValue = id;
                this.Close();
            }
            else
            {
                toolStripConsultar_Click(null, null);
            }
        }


      



        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eB_FormaPagamentoDataGridView.Rows[eB_FormaPagamentoDataGridView.CurrentRow.Index].Cells[0].Value);
            List<int> lista = new List<int> {1, 2, 3, 4, 5, 6, 7};

            if (lista.Contains(id))
            {
                MessageBox.Show("Esta forma de pagamento é padrão do sistema ela não pode ser alterada ou removida.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            frmFormasPagamentoCadastro frm = new frmFormasPagamentoCadastro();
            frm.frmFormasPagamentoList = this;
            frm.id = id;
            frm.ShowDialog();
        }

      

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(eB_FormaPagamentoDataGridView.Rows[eB_FormaPagamentoDataGridView.CurrentRow.Index].Cells[0].Value);
            List<int> lista = new List<int> {1, 2, 3, 4, 5, 6, 7};

            if (lista.Contains(id))
            {
                MessageBox.Show("Esta forma de pagamento é padrão do sistema ela não pode ser alterada ou removida.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BarTumEntities _context = new BarTumEntities();
            

            string message = "Você tem certeza que deseja excluir este registro?";
            string caption = "EasyBar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                    var item = _context.EB_FormaPagamento.Single(a => a.FormaPagamentoID == id);

                    item.Flexcluido = true;
                    _context.SaveChanges();
                    this.populaGridview();
            }
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(eB_FormaPagamentoDataGridView.Rows[eB_FormaPagamentoDataGridView.CurrentRow.Index].Cells[0].Value);
            frmFormasPagamentoCadastro frm = new frmFormasPagamentoCadastro();
            frm.frmFormasPagamentoList = this;
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
