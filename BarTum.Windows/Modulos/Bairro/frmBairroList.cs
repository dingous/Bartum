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
using BarTum.Windows.Modulos.Cliente;

namespace BarTum.Windows.Modulos.Bairro
{

    public partial class frmBairroList : Form
    {

        public frmAtendimento frmAtendimento;
        public frmClienteCadastro frmClienteCadastro;
        private object pai_;
        public object pai { get { return pai_; } set { pai_ = value; } }

        public BarTumEntities context = new BarTumEntities();

        public frmBairroList()
        {
            InitializeComponent();
        }


        public void populaGridview()
        {
           
            var query = (from item in context.EB_Bairro
                         select item).OrderBy(item => item.dsNome).ToList();

            eB_BairroBindingSource.DataSource = null;
            eB_BairroBindingSource.DataSource = query;

        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmBairroCadastro frm = new frmBairroCadastro();
            frm.pai = this;
            frm.ShowDialog();
        }

        private void frmBairroList_Load(object sender, EventArgs e)
        {
            populaGridview();


            if (this.pai != null)
            {
                var tipo = this.pai.GetType();

                switch (tipo.Name)
                {
                    case "frmAtendimento":

                        frmAtendimento = (frmAtendimento)this.pai;

                        eB_BairroDataGridView.CellMouseDoubleClick +=new DataGridViewCellMouseEventHandler(eB_BairroDataGridView_CellMouseDoubleClick);

                        break;
                }

            }

            if (frmClienteCadastro != null)
            {
                eB_BairroDataGridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(eB_BairroDataGridView_CellMouseDoubleClickCliente);
            }
        }


        void eB_BairroDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal idBairro = Convert.ToDecimal(eB_BairroDataGridView.Rows[eB_BairroDataGridView.CurrentRow.Index].Cells[0].Value);
            this.frmAtendimento.VendaPedido.populaBairros(idBairro);
            this.Close();
        }

        void eB_BairroDataGridView_CellMouseDoubleClickCliente(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal idBairro = Convert.ToDecimal(eB_BairroDataGridView.Rows[eB_BairroDataGridView.CurrentRow.Index].Cells[0].Value);
            this.frmClienteCadastro.populaBairros();
            this.frmClienteCadastro.BairroID.SelectedValue = idBairro;
            this.Close();
        }


        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            int idBairro = Convert.ToInt32(eB_BairroDataGridView.Rows[eB_BairroDataGridView.CurrentRow.Index].Cells[0].Value);
            frmBairroCadastro frm = new frmBairroCadastro();
            frm.pai = this;
            frm.id = idBairro;
            frm.ShowDialog();
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            int idBairro = Convert.ToInt32(eB_BairroDataGridView.Rows[eB_BairroDataGridView.CurrentRow.Index].Cells[0].Value);
            frmBairroCadastro frm = new frmBairroCadastro();
            frm.pai = this;
            frm.id = idBairro;
            frm.consulta = true;
            frm.ShowDialog();
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();
            int idBairro = Convert.ToInt32(eB_BairroDataGridView.Rows[eB_BairroDataGridView.CurrentRow.Index].Cells[0].Value);

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

                    var item = _context.EB_Bairro.Single(a => a.BairroID == idBairro);

                    _context.DeleteObject(item);
                    _context.SaveChanges();
                    this.populaGridview();

                }catch(Exception error)
                {
                    MessageBox.Show(this, "Não foi possível excluir este registro, pois existem lançamentos vinculados a ele.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void toolStripTaxaUnica_Click(object sender, EventArgs e)
        {
            frmBairroTaxaUnica frm = new frmBairroTaxaUnica();
            frm.frmBairroList = this;
            frm.ShowDialog();
        }
    }
}
