using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Pagamentos
{
    public partial class frmPagamentoComissaoGarcon : Form
    {
        BarTumEntities context = new BarTumEntities();
        public frmMain frmMain;

        public frmPagamentoComissaoGarcon()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            frmListaComissoesGarcon frm = new frmListaComissoesGarcon();
            frm.frmPagamentoComissaoGarcon = this;
            frm.frmMain = this.frmMain;
            frm.ShowDialog();
        }

        private void frmPagamentoComissaoGarcon_Load(object sender, EventArgs e)
        {
            populaGarcons();
        }


        public void populaGarcons()
        {
           
            var query = context.EB_Garcon.Select(a =>  new { a.GarconID, a.dsNome });
            eBGarconBindingSource.DataSource = query;
            comboBoxGarcons.DataSource = eBGarconBindingSource;
        }
    }
}
