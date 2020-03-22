using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Utilities;
using System.Data.Entity;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Garcon
{
    public partial class frmGarconList : Form
    {

        BarTumEntities _context = new BarTumEntities();

        public frmGarconList()
        {
            InitializeComponent();
        }

        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmGarconCadastro ClienteCadastro = new frmGarconCadastro();
            ClienteCadastro.Show();
        }

        private void frmGarconList_Load(object sender, EventArgs e)
        {
            populaGridview();

            if (eB_GarconDataGridView.RowCount > 0)
            {
                eB_GarconDataGridView.Rows[0].Selected = true;
            }
        }


        public void populaGridview()
        {

            var query = (from item in _context.EB_Garcon
                         select item).OrderByDescending(item=>item.dtCadastro).ToList();

            eB_GarconDataGridView.DataSource = query;

        }

        private void eB_GarconDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(eB_GarconDataGridView.Rows[e.RowIndex].Cells[0].Value);

            frmGarconCadastro frm = new frmGarconCadastro();
            frm.id = id;
            frm.ShowDialog();


        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            decimal id = Convert.ToDecimal(eB_GarconDataGridView.Rows[eB_GarconDataGridView.CurrentRow.Index].Cells[0].Value);
            frmGarconCadastro frm = new frmGarconCadastro();
            frm.id = id;
            frm.ShowDialog();
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            decimal id = Convert.ToDecimal(eB_GarconDataGridView.Rows[eB_GarconDataGridView.CurrentRow.Index].Cells[0].Value);
            frmGarconCadastro frm = new frmGarconCadastro();
            frm.id = id;
            frm.consulta = true;
            frm.ShowDialog();
        }

        private void frmGarconList_KeyDown(object sender, KeyEventArgs e)
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
