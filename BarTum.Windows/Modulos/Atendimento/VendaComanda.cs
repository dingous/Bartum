using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class VendaComanda : UserControl
    {
         frmAtendimento pai;

        public int totalMesas = 0;

        public VendaComanda(frmAtendimento pai)
        {
            InitializeComponent();
            textBoxComanda.Focus();
            this.pai = pai;
            ShowComandas();
        }

        private void textBoxComanda_KeyDown(object sender, KeyEventArgs e)
        {
            try { textBoxComanda.Text = Convert.ToInt32(textBoxComanda.Text).ToString(); }
            catch { textBoxComanda.Text = "";  }

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnNovaVenda_Click(null, null);
                    break;
            }
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            BarTumEntities contexto = new BarTumEntities();
            

            if (textBoxComanda.Text == "")
            {
                MessageBox.Show("Informe o número da comanda", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxComanda.Focus();
                return;
            }


            decimal comanda = Convert.ToDecimal(textBoxComanda.Text);
            var verify = contexto.EB_Lancamento
                        .FirstOrDefault(
                                        cl => cl.ComandaID == comanda && cl.ComandaID != null && cl.StatusID != 3 && cl.flVendaCancelada == false 
                                        );


            

            if (verify != null)
            {
                decimal idVenda = verify.LanctoID;
                this.pai.carregaInformacoespeloIdVenda(idVenda);
            }
            else
            {
                this.pai.limpaInformacoes();

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
                res = MessageBox.Show(this, "Criar nova venda para a comanda " + textBoxComanda.Text + "?", "BarTum", buttons,
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
                        LancaVenda.TipoVendaID = 5;
                        LancaVenda.TipoLanctoID = 1;
                        LancaVenda.UsuarioID = frmMain.UsuarioLogado;
                        LancaVenda.dtLancto = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                        LancaVenda.StatusID = 1;
                        LancaVenda.ComandaID = Convert.ToDecimal(textBoxComanda.Text);
                        LancaVenda.flComissaoGarconFoiPaga = false;





                        this.pai.botaoIncluirProduto.Enabled = true;

                        _context.AddToEB_Lancamento(LancaVenda);
                        _context.SaveChanges();



                        this.pai.LanctoID.Text = LancaVenda.LanctoID.ToString();
                        this.pai.dtLancto.Text = Convert.ToDateTime(LancaVenda.dtLancto).ToString("dd/M/yyyy H:mm");
                        pai.populaGridItensPorIDVenda(Convert.ToDecimal(pai.LanctoID.Text));

                        this.pai.TotalVenda();
                        this.pai.calculaCamposFinanceiros();

                        ShowComandas();



                    }
                    catch (Exception error)
                    {
                        MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                        MessageBox.Show(error.InnerException.Message, "BarTum", buttons2, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    }
                }
            }
        }

        public void ShowComandas()
        {


            flowpanelComandas.Controls.Clear();

            BarTumEntities context = new BarTumEntities();

            //status
            //1 = Aberto
            //2 = fechando
            //3 = fechado

         
            int cont = 0;
         

  
            var item = context.EB_Lancamento.Where(
                                        cl => cl.ComandaID != null &&
                                            cl.StatusID != 3 &&
                                            cl.flVendaCancelada == false
                                            && cl.TipoVendaID == 5
                                        ).OrderBy(o => o.ComandaID);


            this.totalMesas = item.Count();

            foreach (var comandas in item)
            {


                Button DynButton;
                Control ControlObject;

                string ControlType = "System.Windows.Forms.Button";
                string ControlName = "mesa" + Convert.ToInt32(comandas.ComandaID).ToString("D4");

                System.Reflection.Assembly asm;
                asm = typeof(Form).Assembly;
                ControlObject = (System.Windows.Forms.Control)asm.CreateInstance(ControlType);
                ControlObject.Name = ControlName;
                flowpanelComandas.Controls.Add(ControlObject);
                

                DynButton = (System.Windows.Forms.Button)ControlObject;
                //DynButton.Width = 44;
                DynButton.AutoSize = true;
                DynButton.Height = 30;
                var padding = new System.Windows.Forms.Padding();
                padding.Left = 1;

                DynButton.Margin = padding;
                
                DynButton.Padding = padding;


                //DynButton.AutoSize = true;
                DynButton.BackColor = Color.Aquamarine;
                DynButton.Text = Convert.ToInt32(comandas.ComandaID).ToString("D4");
                DynButton.Click += new System.EventHandler(DynCtrl_Click);
                DynButton.ContextMenuStrip = contextMenuMesas;
                DynButton.Padding = new Padding(0);
                DynButton.TabIndex = cont;
                DynButton.GotFocus += new EventHandler(DynButton_GotFocus);
                DynButton.LostFocus += new EventHandler(DynButton_LostFocus);

                if (comandas.LanctoID != null)
                {
                    switch (comandas.StatusID.ToString())
                    {
                        case "1":
                            DynButton.BackColor = Color.OrangeRed;
                            break;
                        case "2":
                            DynButton.BackColor = Color.Yellow;
                            break;
                        default:
                            DynButton.BackColor = Color.FromName("#cccccc");
                            break;
                    }
                }


                cont = cont + 1;
               

            }


        }

        private void DynCtrl_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxComanda.Text = btn.Text;
            decimal nrMesa = Convert.ToDecimal(btn.Text);
            btnNovaVenda_Click(null, null);
        }

        void DynButton_LostFocus(object sender, EventArgs e)
        {
            Button tb = (Button)sender;
            tb.Font = new Font(tb.Font, FontStyle.Regular);
            //tb.ForeColor = Color.Black;
            //ControlPaint.DrawBorder(tb.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);

        }

        void DynButton_GotFocus(object sender, EventArgs e)
        {
            Button tb = (Button)sender;
            tb.Font = new Font(tb.Font, FontStyle.Bold);
            //tb.ForeColor = Color.Brown;
        }

        private void botaoBuscarPendentes_Click(object sender, EventArgs e)
        {
            frmPendentesComanda form = new frmPendentesComanda();
            form.pai = this.pai;
            form.ShowDialog();
        }

        private void toolStripMenuFecharConta_Click(object sender, EventArgs e)
        {
            Control c = contextMenuMesas.SourceControl as Control;
            if (c != null)
            {

                textBoxComanda.Text = c.Text;
                decimal nrComanda = Convert.ToDecimal(textBoxComanda.Text);
                btnNovaVenda_Click(null, null);
                pai.funcaoFechaConta();

            }
        }
    }
}
