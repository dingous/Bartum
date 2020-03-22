using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Utilities;


namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class VendaBalcao : UserControl
    {

        frmAtendimento pai;

        public VendaBalcao(frmAtendimento pai)
        {
            InitializeComponent();
            this.pai = pai;
            populaGarcons();
            populaBalcoes();


            
        }

        public void populaGarcons()
        {
            BarTumEntities _context = new BarTumEntities();
            var result = (from item in _context.EB_Garcon orderby item.dsNome ascending select new { item.GarconID, item.dsNome }).ToList();
            eBGarconBindingSource.DataSource = result;
        }

        public void populaBalcoes()
        {
            BarTumEntities _context = new BarTumEntities();
            var result = (from item in _context.EB_Balcao orderby item.dsBalcao ascending select new { item.BalcaoID, item.dsBalcao }).ToList();
            eBBalcaoBindingSource.DataSource = result;
        }

        public void botaoEfetuarVenda_Click(object sender, EventArgs e)
        {

            frmMain frmMain = (frmMain)this.pai.MdiParent;
            var Caixacontexto = frmMain.Caixa.caixaContexto;
            frmMain.VerificaCaixaSemConfirmacao();

            if (!(this.pai.frmMain.Caixa.CaixaAtivo))
            {
                MessageBox.Show("Não é possível efetuar nenhuma venda, pois o caixa ainda não foi aberto.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res;
                res = MessageBox.Show(this, "Criar nova venda no balcão?", "BarTum", buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (res == DialogResult.No)
                {

                }
                else
                {

                    BarTumEntities _context = new BarTumEntities();

                    try
                    {

                        EB_Lancamento LancaVenda = new EB_Lancamento();

                        



                        LancaVenda.CaixaID = frmMain.Caixa.caixaContexto;
                        LancaVenda.TipoVendaID = 2;
                        LancaVenda.TipoLanctoID = 1;
                        LancaVenda.GarconID = Convert.ToDecimal(GarconID.SelectedValue);
                        LancaVenda.UsuarioID = frmMain.UsuarioLogado;
                        LancaVenda.nrOcupantes = (textBoxOcupantes.Text == "") ? 0 : Convert.ToDecimal(textBoxOcupantes.Text);
                        LancaVenda.dtLancto = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                        LancaVenda.StatusID = 1;
                        LancaVenda.BalcaoID = Convert.ToDecimal(BalcaoID.SelectedValue);
                        LancaVenda.flComissaoGarconFoiPaga = false;

                        dsNomeClienteBalcao.Text = "";
                        dsNomeClienteBalcao.Focus();



                        this.pai.botaoIncluirProduto.Enabled = true;

                        _context.AddToEB_Lancamento(LancaVenda);
                        _context.SaveChanges();



                        this.pai.LanctoID.Text = LancaVenda.LanctoID.ToString();
                        this.pai.dtLancto.Text = Convert.ToDateTime(LancaVenda.dtLancto).ToString("dd/M/yyyy H:mm");
                        this.pai.TxtprocentagemGarcon.Text = LancaVenda.EB_Garcon.nrComissao.ToString();
                        pai.populaGridItensPorIDVenda(Convert.ToDecimal(pai.LanctoID.Text));

                        this.pai.TotalVenda();
                        this.pai.calculaCamposFinanceiros();





                    }
                    catch (Exception error)
                    {
                        MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                        MessageBox.Show(error.InnerException.Message, "BarTum", buttons2, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    }
                }
        }

        private void botaoBuscarPendentes_Click(object sender, EventArgs e)
        {

            frmPendentesBalcao form = new frmPendentesBalcao();
            form.pai = this.pai;
            form.ShowDialog();
            
        }

        private void dsNomeClienteBalcao_Leave(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            if(this.pai.LanctoID.Text != "")
            {
               decimal id = Convert.ToDecimal(this.pai.LanctoID.Text);
               var Venda = _context.EB_Lancamento.Single(cl => cl.LanctoID == id);
               Venda.dsNomeClienteBalcao = dsNomeClienteBalcao.Text;
               _context.SaveChanges();
            }
        }

        private void textBoxOcupantes_Leave(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            if (this.pai.LanctoID.Text != "")
            {
                decimal id = Convert.ToDecimal(this.pai.LanctoID.Text);
                var Venda = _context.EB_Lancamento.Single(cl => cl.LanctoID == id);
                Venda.nrOcupantes = Convert.ToDecimal(textBoxOcupantes.Text);
                _context.SaveChanges();
            }
        }











 

        private void btnEtiquetaComanda_Click(object sender, EventArgs e)
        {
            if(pai.LanctoID.Text == "")
            {
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                MessageBox.Show("Selecione uma venda.", "BarTum", buttons2, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            }
        }

        private void GarconID_Leave(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            if (this.pai.LanctoID.Text != "")
            {
                try
                {

                    decimal id = Convert.ToDecimal(this.pai.LanctoID.Text);
                    var Venda = _context.EB_Lancamento.Single(cl => cl.LanctoID == id);
                    Venda.GarconID = Convert.ToDecimal(GarconID.SelectedValue);
                    _context.SaveChanges();

                    this.pai.TxtprocentagemGarcon.Text = Venda.EB_Garcon.nrComissao.ToString();
                    this.pai.calculaCamposFinanceiros();
                }
                catch (Exception error)
                {

                }
            }
        }

        private void BalcaoID_Leave(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            if (this.pai.LanctoID.Text != "")
            {
                decimal id = Convert.ToDecimal(this.pai.LanctoID.Text);
                var Venda = _context.EB_Lancamento.Single(cl => cl.LanctoID == id);
                Venda.BalcaoID = Convert.ToDecimal(BalcaoID.SelectedValue);
                _context.SaveChanges();
            }
        }

        private void VendaBalcao_Load(object sender, EventArgs e)
        {
            
        }
    }
}
