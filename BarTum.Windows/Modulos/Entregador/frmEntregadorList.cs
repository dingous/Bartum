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



namespace BarTum.Windows.Modulos.Entregador
{
    public partial class frmEntregadorList : Form
    {



        BarTumEntities _context = new BarTumEntities();

        public frmEntregadorList()
        {
            InitializeComponent();
            populaGridview();
        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmEntregadorCadastro frm = new frmEntregadorCadastro();
            frm.pai = this;
            frm.ShowDialog();
        }

        public void populaGridview()
        {
            BarTumEntities context = new BarTumEntities();

            var query = (from item in context.EB_Entregador
                         select item).OrderBy(item => item.dsNome).ToList();

            eB_EntregadorBindingSource.DataSource = query;

        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            int idEntregador = Convert.ToInt32(eB_EntregadorDataGridView.Rows[eB_EntregadorDataGridView.CurrentRow.Index].Cells[0].Value);
            frmEntregadorCadastro frm = new frmEntregadorCadastro();
            frm.pai = this;
            frm.id = idEntregador;
            frm.ShowDialog();
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            int idEntregador = Convert.ToInt32(eB_EntregadorDataGridView.Rows[eB_EntregadorDataGridView.CurrentRow.Index].Cells[0].Value);
            frmEntregadorCadastro frm = new frmEntregadorCadastro();
            frm.pai = this;
            frm.id = idEntregador;
            frm.consulta = true;
            frm.ShowDialog();
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            int idEntregador = Convert.ToInt32(eB_EntregadorDataGridView.Rows[eB_EntregadorDataGridView.CurrentRow.Index].Cells[0].Value);

            string message = "Você tem certeza que deseja excluir este registro?";
            string caption = "EasyBar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {

                var item = _context.EB_Entregador.Single(a => a.EntregadorID == idEntregador);
                _context.DeleteObject(item);
                _context.SaveChanges();
                this.populaGridview();
            }
        }

        private void frmEntregadorList_Load(object sender, EventArgs e)
        {

        }
    }
}
