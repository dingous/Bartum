using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BarTum.Entities;
using System.Windows.Forms;
 

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmBuscar : Form
    {
       
        frmAtendimento frmAtendimento;

        private object pai_;
        public object pai { get { return pai_; } set { pai_ = value; } }

        public frmBuscar()
        {
            InitializeComponent();
        }

        private void tsbBalcao_Click(object sender, EventArgs e)
        {
            frmPendentesBalcao form = new frmPendentesBalcao();
            form.pai = this.frmAtendimento;
            form.frmBuscar = this;
            form.ShowDialog();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            if (this.pai != null)
            {
                var tipo = this.pai.GetType();

                switch (tipo.Name)
                {
                    case "frmAtendimento":

                        this.frmAtendimento = (frmAtendimento)this.pai;

                        break;
                }

            }

            toolStripTextBox1.Focus();
        }

        private void tsbMesa_Click(object sender, EventArgs e)
        {
            frmPendentesMesa form = new frmPendentesMesa();
            form.pai = this.frmAtendimento;
            form.frmBuscar = this;
            form.ShowDialog();
        }



        private void executaBusca(decimal valor)
        {



            BarTumEntities _context = new BarTumEntities();
            decimal idVenda = valor;
            var result = (from item in _context.EB_Lancamento orderby item.dtLancto ascending select item).Where(item => item.LanctoID == idVenda).FirstOrDefault();

            
            if (result != null && result.StatusID != 3)
            {

                if (result.flVendaCancelada == true)
                {
                    MessageBox.Show("Esta venda foi cancelada!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                this.Close();
                this.frmAtendimento.verificarTipodaVenda(result);

                switch (this.frmAtendimento.tipoVenda)
                {
                    case "mesa":
                        this.frmAtendimento.ChamaVendaMesa();
                        this.frmAtendimento.carregaInformacoes(Convert.ToDecimal(result.MesaID));
                        break;
                    case "balcao":
                        this.frmAtendimento.ChamaVendaBalcao();
                        this.frmAtendimento.carregaInformacoespeloIdVenda(result.LanctoID);
                        break;
                    case "pedido":
                        this.frmAtendimento.ChamaVendaEntrega();
                        this.frmAtendimento.carregaInformacoespeloIdVenda(result.LanctoID);
                        var query = _context.EB_LanctoPedidos.Single(a => a.LanctoID == idVenda);
                        this.frmAtendimento.carregaInformacoespeloIdVenda(query.LanctoID);
                        this.frmAtendimento.VendaPedido.populaCamposCliente2(query.EnderecoID);
                        break;
                    case "comanda":
                        this.frmAtendimento.ChamaVendaComanda();
                        this.frmAtendimento.carregaInformacoespeloIdVenda(result.LanctoID);
                        break;
                }


                if (this.frmAtendimento.Visible == false)
                {
                    this.frmAtendimento.Visible = true;
                    this.frmAtendimento.Show();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            ToolStripTextBox txtBox = (ToolStripTextBox)sender;
            decimal valor = 0;
            try
            {
                valor = Convert.ToDecimal(txtBox.Text);
            }
            catch { txtBox.Text = ""; }
            

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    executaBusca(valor);
                    break;
              
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPendentesPedido form = new frmPendentesPedido();
            form.pai = this.frmAtendimento;
            form.frmBuscar = this;
            form.ShowDialog();
        }

        private void frmBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPendentesComanda form = new frmPendentesComanda();
            form.pai = this.frmAtendimento;
            form.frmBuscar = this;
            form.ShowDialog();
        }
        
    }
}
