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
    public partial class VendaMesa : UserControl
    {
        
        frmAtendimento pai;

        public int totalMesas = 0;

        public VendaMesa(frmAtendimento pai)
        {
            InitializeComponent();
            this.pai = pai;
        }


        private void VendaMesa_Load(object sender, EventArgs e)
        {
            populaGarcons();
            ShowMesas();
        }

        private void DynCtrl_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxMesa.Text = btn.Text;
            decimal nrMesa = Convert.ToDecimal(btn.Text);
            this.pai.carregaInformacoes(nrMesa);
        }



      
        public void populaGarcons()
        {
            BarTumEntities _context = new BarTumEntities();
            var result = (from item in _context.EB_Garcon
                        orderby item.dsNome ascending
                        select new 
                        {
                            GarconID = item.GarconID, 
                            dsNome = item.dsNome

                        }).ToList();

            eBGarconBindingSource.DataSource = result;
        }

        public void ShowMesas()
        {

            BarTumEntities context = new BarTumEntities();

            //status
            //1 = Aberto
            //2 = fechando
            //3 = fechado

            int x = 6;
            int y = 13;
            int cont = 0;
            int codmesa = 1;

            var item = (from eb_cadastromesa in context.EB_CadastroMesa
                        from eb_lancamento in context.EB_Lancamento
                        .Where(
                            a => a.MesaID == eb_cadastromesa.MesaID &&
                            a.StatusID != 3 &&
                            (Decimal)a.MesaID != null && a.flVendaCancelada == false &&
                            a.TipoVendaID == 1
                            )
                        .DefaultIfEmpty()
                        select new
                        {
                            MesaID = eb_cadastromesa.MesaID,
                            LanctoID = (decimal?)eb_lancamento.LanctoID,
                            StatusID = eb_lancamento.StatusID
                        }).OrderBy(o => o.MesaID);


            this.totalMesas = item.Count();

            foreach (var mesas in item)
            {


                Button DynButton;
                Control ControlObject;

                string ControlType = "System.Windows.Forms.Button";
                string ControlName = "mesa" + Convert.ToInt32(mesas.MesaID).ToString("D2");

                System.Reflection.Assembly asm;
                asm = typeof(Form).Assembly;
                ControlObject = (System.Windows.Forms.Control)asm.CreateInstance(ControlType);
                ControlObject.Name = ControlName;
                ControlObject.Location = new System.Drawing.Point(x, y);
                groupBox1.Controls.Add(ControlObject);
                groupBox1.FlatStyle = FlatStyle.Flat;

                DynButton = (System.Windows.Forms.Button)ControlObject;
                DynButton.Width = 30;
                DynButton.Height = 30;
                DynButton.BackColor = Color.FromName("#cccccc");
                DynButton.Text = Convert.ToInt32(mesas.MesaID).ToString("D2");
                DynButton.Click += new System.EventHandler(DynCtrl_Click);              
                DynButton.ContextMenuStrip = contextMenuMesas;
                DynButton.Padding = new Padding(0);
                DynButton.TabIndex = cont;
                DynButton.GotFocus += new EventHandler(DynButton_GotFocus);
                DynButton.LostFocus += new EventHandler(DynButton_LostFocus);

                if (mesas.LanctoID != null)
                {
                    switch (mesas.StatusID.ToString())
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
                codmesa = codmesa + 1;

                if (cont % 33 == 0) { x = 6; y = y + 30; } else { x = x + 30; }
                
            }


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



        public void OcuparMesa()
        {
            try
            {

                frmMain frmMain = (frmMain)this.pai.MdiParent;
                var Caixacontexto = frmMain.Caixa.caixaContexto;
                frmMain.VerificaCaixaSemConfirmacao();


                if (!(this.pai.frmMain.Caixa.CaixaAtivo))
                {
                    MessageBox.Show("Não é possível efetuar nenhuma venda, pois o caixa ainda não foi aberto.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (GarconID.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um garçon ou atendente.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }


                BarTumEntities _context = new BarTumEntities();

                EB_Lancamento LancaVenda = new EB_Lancamento();

              

                LancaVenda.CaixaID = frmMain.Caixa.caixaContexto;
                if (textBoxMesa.Text == "") { LancaVenda.MesaID = null; } else { LancaVenda.MesaID = Convert.ToDecimal(textBoxMesa.Text); }
                LancaVenda.TipoVendaID = 1;
                LancaVenda.TipoLanctoID = 1;
                LancaVenda.GarconID = Convert.ToDecimal(GarconID.SelectedValue);
                LancaVenda.UsuarioID = frmMain.UsuarioLogado;
                LancaVenda.nrOcupantes = (textBoxOcupantes.Text == "") ? 0 : Convert.ToDecimal(textBoxOcupantes.Text);
                LancaVenda.dtLancto = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                LancaVenda.StatusID = 1;
                LancaVenda.flComissaoGarconFoiPaga = false;


                if (LancaVenda.Valida(LancaVenda))
                {



                    _context.AddToEB_Lancamento(LancaVenda);
                    _context.SaveChanges();

                    groupBox1.Controls["mesa" + textBoxMesa.Text].BackColor = Color.OrangeRed;
                    this.pai.botaoIncluirProduto.Enabled = true;

                    this.pai.LanctoID.Text = LancaVenda.LanctoID.ToString();
                    this.pai.dtLancto.Text = Convert.ToDateTime(LancaVenda.dtLancto).ToString("dd/M/yyyy H:mm");
                    this.pai.TxtprocentagemGarcon.Text = LancaVenda.EB_Garcon.nrComissao.ToString();
                    this.pai.toolStripBotaoImprimirConta.Enabled = true;
                    this.pai.botaoFecharConta.Enabled = true;
                    pai.populaGridItensPorIDVenda(Convert.ToDecimal(pai.LanctoID.Text));

                    this.pai.TotalVenda();
                    this.pai.calculaCamposFinanceiros();



                    //notifica ao servidor
                    string jsoncliente = "{'acao':'ServidorInserirMesa',";
                    jsoncliente += "'MesaID' : '" + textBoxMesa.Text + "',";
                    jsoncliente += "'tipo' : 'ocupa'";
                    jsoncliente += "}";
                    frmMain.strigComando = jsoncliente;
                    frmMain.Atualiza();

                    GarconID.Focus();

                }

            }
            catch (Exception error)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(error.InnerException.Message, "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }
        }

        public void botaoOcuparMesa_Click(object sender, EventArgs e)
        {

         

            OcuparMesa();
        }



       


        private void toolStripMenuFecharConta_Click(object sender, EventArgs e)
        {
            Control c = contextMenuMesas.SourceControl as Control;
            if (c != null)
            {

                textBoxMesa.Text = c.Text;
                decimal nrMesa = Convert.ToDecimal(textBoxMesa.Text);
                pai.carregaInformacoes(nrMesa);
                pai.funcaoFechaConta();

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

        private void ocuparMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Control c = contextMenuMesas.SourceControl as Control;
            if (c != null)
            {

                textBoxMesa.Text = c.Text;
                decimal nrMesa = Convert.ToDecimal(textBoxMesa.Text);
                pai.carregaInformacoes(nrMesa);
                OcuparMesa();
                GarconID.Focus();

            }
           
        }

        public void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Control c = contextMenuMesas.SourceControl as Control;
            if (c != null)
            {
                textBoxMesa.Text = c.Text;
                decimal nrMesa = Convert.ToDecimal(textBoxMesa.Text);
                pai.carregaInformacoes(nrMesa);

                frmTransferenciaMesa frm = new frmTransferenciaMesa();
                frm.frmAtendimento = this.pai;
                frm.ShowDialog();
            }
        }

        private void botaoBuscarPendentes_Click(object sender, EventArgs e)
        {
            frmPendentesMesa form = new frmPendentesMesa();
            form.pai = this.pai;
            form.ShowDialog();
        }

    
    }
}
