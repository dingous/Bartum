using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmVendaPedidoTels : Form
    {
        public frmAtendimento frmAtendimento;

        public frmVendaPedidoTels()
        {
            InitializeComponent();
        }

        private void eB_ClienteDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal idCliente = Convert.ToDecimal(eB_ClienteDataGridView.Rows[eB_ClienteDataGridView.CurrentRow.Index].Cells[0].Value);
            frmAtendimento.VendaPedido.populaCamposCliente(idCliente);
            this.Close();

            
        }

        private void frmVendaPedidoTels_Load(object sender, EventArgs e)
        {
            eB_ClienteBindingSource.DataSource = frmAtendimento.VendaPedido.consulta;
        }
    }
}
