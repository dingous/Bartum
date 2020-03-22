using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Windows.Modulos.Cliente;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmAdiantamento : Form
    {
        public frmAtendimento frmAtendimento;

        public frmAdiantamento()
        {
            InitializeComponent();
        }


        

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdiantamento_Load(object sender, EventArgs e)
        {
            valorTotalVenda.Text = frmAtendimento.txtTotalaPagar.Text.ToString();
            populaFormasPagamento();
            dtVencimento.Text = DateTime.Now.ToString("dd/MM/yyyy");



            if (frmAtendimento.tipoVenda == "mesa")
            {
                groupBox1.Visible = true;
                textBox1.Text = frmAtendimento.VendaMesa.textBoxOcupantes.Text;
                decimal vlTotal = Convert.ToDecimal(frmAtendimento.txtTotalaPagar.Text.Replace("R$ ", "").Replace(".", "")) / Convert.ToDecimal(textBox1.Text);
                textBox2.Text = vlTotal.ToString("C3");
            }
        }


        public void populaFormasPagamento()
        {
            BarTumEntities context = new BarTumEntities();
            var query = (from formas in context.EB_FormaPagamento where formas.Flexcluido == false orderby formas.ordem ascending select new { formas.FormaPagamentoID, formas.dsForma });
            eBFormaPagamentoBindingSource.DataSource = query;
        }


        #region mascaras
        //máscaras
        string str = "";
        private void Mask_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {



            TextBox txtBox = (TextBox)sender;
            Control controle = txtBox;


            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                //char teste = Convert.ToChar(Keys);

                string chave = e.KeyCode.ToString();

                switch (chave)
                {
                    case "NumPad0":
                        str = str + Convert.ToChar(Keys.D0);
                        break;
                    case "NumPad1":
                        str = str + Convert.ToChar(Keys.D1);
                        break;
                    case "NumPad2":
                        str = str + Convert.ToChar(Keys.D2);
                        break;
                    case "NumPad3":
                        str = str + Convert.ToChar(Keys.D3);
                        break;
                    case "NumPad4":
                        str = str + Convert.ToChar(Keys.D4);
                        break;
                    case "NumPad5":
                        str = str + Convert.ToChar(Keys.D5);
                        break;
                    case "NumPad6":
                        str = str + Convert.ToChar(Keys.D6);
                        break;
                    case "NumPad7":
                        str = str + Convert.ToChar(Keys.D7);
                        break;
                    case "NumPad8":
                        str = str + Convert.ToChar(Keys.D8);
                        break;
                    case "NumPad9":
                        str = str + Convert.ToChar(Keys.D9);
                        break;
                    default: str = str + Convert.ToChar(KeyCode); break;
                }


            }
            if (str.Length == 0)
            {
                controle.Text = "";
            }
            if (str.Length == 1)
            {



                controle.Text = Convert.ToDecimal("0,0" + str).ToString("C");
            }
            else if (str.Length == 2)
            {
                controle.Text = Convert.ToDecimal("0," + str).ToString("C");
            }
            else if (str.Length > 2)
            {
                controle.Text = Convert.ToDecimal(str.Substring(0, str.Length - 2) + "," + str.Substring(str.Length - 2)).ToString("C");
            }
        }
        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val >= 96 && Val <= 105) || (Val == 8) || (Val == 46));
        }
        private void Mask_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        void DynButton_Leave(object sender, EventArgs e)
        {
            this.str = "";

            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text == "")
            {
                txtBox.Text = "0,00";
            }
            else
            {
                calculaCampos();
            }

        }

        #endregion mascaras



        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                
                calculaCampos();






                BarTumEntities context = new BarTumEntities();
                decimal id = Convert.ToDecimal(FormaPagamento.SelectedValue);
                decimal LanctoID = Convert.ToDecimal(this.frmAtendimento.LanctoID.Text);
                var forma = context.EB_FormaPagamento.Single(cl => cl.FormaPagamentoID == id);
                var Lancto = context.EB_Lancamento.Single(cl => cl.LanctoID == LanctoID);
                decimal TotalaPagar = Convert.ToDecimal(valorTotalVenda.Text.Replace("R$ ", "").Replace(".", ""));
                decimal valorPagamento = Convert.ToDecimal(vlPagamento.Text.Replace("R$ ", "").Replace(".", ""));
                decimal valorRecebido = Convert.ToDecimal(vlrecebido.Text.Replace("R$ ", "").Replace(".", ""));
                decimal valorTroco = Convert.ToDecimal(vlTroco.Text.Replace("R$ ", "").Replace(".", ""));

                if (valorPagamento == 0 || valorPagamento > TotalaPagar)
                {
                    vlPagamento.Focus();
                    return;
                }


                decimal troco = Convert.ToDecimal(vlTroco.Text.Replace("R$ ", ""));
                if (troco < 0)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Valores inconsistentes, troco não pode ser negativo.", "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    return;
                }

                //se a forma de pagamento é a prazo vai para o contas a receber
                if (forma.CondicaoID == 2)
                {
                    groupBox3.Visible = true;

                    if (txtCodCliente.Text == "" || txtNomeCliente.Text == "")
                    {

                        MessageBoxButtons buttons_ = MessageBoxButtons.OK;
                        DialogResult result_;
                        string msg = "É necessário selecionar um cliente";
                        result_ = MessageBox.Show(this, msg, "BarTum", buttons_,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                        return;
                    }


                    MessageBoxButtons _buttons = MessageBoxButtons.YesNo;
                    DialogResult _res;
                    _res = MessageBox.Show(this, "Confirmar pagamento?", "EasyBar", _buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (_res == DialogResult.No)
                    {
                        return;

                    }

                    try
                    {

                    var ContasReceber = new EB_Contas();
                    ContasReceber.TipoLanctoID = 1;
                    ContasReceber.clienteID = Convert.ToDecimal(txtCodCliente.Text);
                    ContasReceber.lanctoID = Lancto.LanctoID;
                    ContasReceber.descricao = "PG. PARCIAL REFERENTE A VENDA DE Nº " + Lancto.LanctoID;
                    ContasReceber.dtlancto = DateTime.Now;
                    ContasReceber.dtVencimento = Convert.ToDateTime(dtVencimento.Text);
                    ContasReceber.vlConta = Convert.ToDecimal(txtValoraReceber.Text.Replace("R$ ", "").Replace(".", ""));
                    frmMain frmMain = (frmMain)this.MdiParent;
                    ContasReceber.usuarioID = frmMain.UsuarioLogado;
                    context.AddToEB_Contas(ContasReceber);

                    ContasReceber.PlanoContaID = 1;

                    //cliente passa a ser conveniado
                    ContasReceber.EB_Cliente.convenio = true;
                 
                    }
                    catch (System.InvalidOperationException error)
                    {
                          MessageBox.Show("Não foi definido um plano de contas padrão para as vendas, defina-o em Sistema/Configurações Gerais.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          return;
                    }

                    Lancto.FechaAdiantamento = (Convert.ToDecimal(Lancto.FechaAdiantamento) + valorPagamento);
                }
                else
                {
                    groupBox3.Visible = false;
                    


                    MessageBoxButtons _buttons = MessageBoxButtons.YesNo;
                    DialogResult _res;
                    _res = MessageBox.Show(this, "Confirmar pagamento?", "EasyBar", _buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (_res == DialogResult.No)
                    {
                        return;

                    }


                    EB_LancamentoAdiantamentos adiantamento = new EB_LancamentoAdiantamentos();
                    adiantamento.vlTotalAPagarContaNoMomento = TotalaPagar;
                    adiantamento.vlPagamentoCliente = valorPagamento;
                    adiantamento.vlRecebidoCliente = valorRecebido;
                    adiantamento.vlTroco = valorTroco;
                    adiantamento.dsObservacao = observacao.Text;
                    adiantamento.dtDataHora = DateTime.Now;
                    adiantamento.LanctoID = Lancto.LanctoID;
                    adiantamento.FormaPagamentoID = forma.FormaPagamentoID;
                    context.AddToEB_LancamentoAdiantamentos(adiantamento);


                    var formaPaga = new EB_LancamentoFechamentoFormasPag();
                    formaPaga.FormaPagamentoID = forma.FormaPagamentoID;
                    formaPaga.LanctoID = Lancto.LanctoID;
                    formaPaga.vlForma = (Convert.ToDecimal(valorRecebido) - Convert.ToDecimal(valorTroco));
                    formaPaga.FlOrigemAdiantamento = true;
                    context.AddToEB_LancamentoFechamentoFormasPag(formaPaga);

                    Lancto.FechaAdiantamento = (Convert.ToDecimal(Lancto.FechaAdiantamento) + valorPagamento);
                }


                context.SaveChanges();

                this.frmAtendimento.txtAdiantamento.Text = Convert.ToDecimal(Lancto.FechaAdiantamento).ToString("C");


                MessageBoxButtons b = MessageBoxButtons.OK;
                DialogResult j;
                j = MessageBox.Show(this, "Adiantamento efetuado com sucesso!", "EasyBar", b,
                MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                this.Close();

            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

       

        private void frmAdiantamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Enter:
                    botaoSalvar_Click(sender, e);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;


            }
        }


        private void calculaCampos()
        {
            decimal TotalaPagar = Convert.ToDecimal(valorTotalVenda.Text.Replace("R$ ", "").Replace(".", ""));
            decimal valorPagamento = Convert.ToDecimal(vlPagamento.Text.Replace("R$ ", "").Replace(".", ""));
            decimal valorRecebido = Convert.ToDecimal(vlrecebido.Text.Replace("R$ ", "").Replace(".", ""));


            if (valorPagamento > TotalaPagar)
            {
                vlPagamento.Focus();
                //labelError.Text = "* valor pagamento não pode ser maior \n que o valor total a pagar.";
                errorProvider1.SetError(vlPagamento, "* valor pagamento não pode ser maior \n que o valor total a pagar.");
                return;
            }
            else
            {
                //labelError.Text = "";
                errorProvider1.SetError(vlPagamento, "");
                
            }

            decimal troco = valorRecebido - valorPagamento;

            if (troco < 0)
            {
                vlTroco.BackColor = Color.Red;
            }
            else
            {
                vlTroco.BackColor = Color.White;
            }


            txtValoraReceber.Text = valorPagamento.ToString("C");
            vlTroco.Text = troco.ToString("C");

        }

        private void FormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            BarTumEntities context = new BarTumEntities();
            decimal id = Convert.ToDecimal(FormaPagamento.SelectedValue);
            var forma = context.EB_FormaPagamento.Single(cl => cl.FormaPagamentoID == id);
            if (forma.CondicaoID == 2)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        private void BuscarClientes_Click(object sender, EventArgs e)
        {
            frmClienteList _frmCliente = new frmClienteList();
            _frmCliente.frmAdiantamento = this;
            _frmCliente.frmMain = (frmMain)frmAtendimento.frmMain;
            _frmCliente.ShowDialog();
        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            BarTumEntities context = new BarTumEntities();
            decimal idCliente = txtCodCliente.Value;
            var query = context.EB_Cliente.Where(cl => cl.ClienteID == idCliente && cl.flExcluido == false).ToList();
            if (query.Count > 0)
            {
                txtNomeCliente.Text = query[0].dsNome;
            }
            else
            {
                txtNomeCliente.Text = "";
                //txtCodCliente.Text = "";

            }
        }
    }
}
