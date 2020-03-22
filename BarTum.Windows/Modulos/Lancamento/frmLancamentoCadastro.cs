using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Windows.Modulos.Caixa;

namespace BarTum.Windows.Modulos.Lancamento
{
    public partial class frmLancamentoCadastro : Form
    {
        public frmCaixaFluxo frmCaixaFluxo;

        public frmLancamentoCadastro()
        {
            InitializeComponent();
        }

        private void frmLancamentoCadastro_Load(object sender, EventArgs e)
        {
            populaFormasPagamento();

            if (frmCaixaFluxo != null)
            {
               textBoxDtLancto.Value = frmCaixaFluxo.dataCaixa.Value;
            }
        }



        public void populaFormasPagamento()
        {
            BarTumEntities context = new BarTumEntities();
            var query = (from a in context.EB_FormaPagamento where a.flMostrarnoContas == true && a.Flexcluido == false orderby a.ordem ascending select new { a.dsForma, a.FormaPagamentoID });
            eBFormaPagamentoBindingSource.DataSource = query;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            string Descricao = textBoxDescricao.Text;
            DateTime DtLancto = textBoxDtLancto.Value;
            decimal TipoLancto = radioTipo1.Checked == true ? 1 : 2;
            decimal formaPagamento = Convert.ToDecimal(comboBoxFormaPagamento.SelectedValue);
            decimal valor = Convert.ToDecimal(vlLancamento.Text.Replace("R$ ", "").Replace(".", ""));
            decimal caixaOuBanco = Convert.ToDecimal(ContasDestDescontoID.Text);

            if (Descricao == "")
            {
                MessageBox.Show("Informe uma descrição para o lançamento", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDescricao.Focus();
                return;
            }
            else if (valor == 0)
            {
                MessageBox.Show("Informe o valor do lançamento", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vlLancamento.Focus();
                return;
            }

            try
            {

                BarTumEntities context = new BarTumEntities();
                EB_LancamentoCaixaBanco ent = new EB_LancamentoCaixaBanco();
                ent.dsDescricao = Descricao;
                ent.dtLancto = DtLancto.Date;
                ent.TipoLanctoID = TipoLancto;
                ent.formaPagamentoID = formaPagamento;
                ent.vlValor = valor;
                ent.ContasDestDescontoID = caixaOuBanco;
                ent.dtInsercao = DateTime.Now;
                frmMain frmMain = (frmMain)this.frmCaixaFluxo.MdiParent;
                ent.CaixaID = frmMain.Caixa.caixaObjContexto.CaixaID;
                context.AddToEB_LancamentoCaixaBanco(ent);

                context.SaveChanges();




                frmCaixaFluxo.frmCaixaFluxo_Load(null, null);
                this.Close();
                MessageBox.Show("Lançamento efetuado com suecesso!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
               

            }catch(Exception error)
            {
                MessageBox.Show("Erro na tentativa: " + error.Message + error.InnerException.Message != null ? error.InnerException.Message : "", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        #endregion mascaras

        private void vlLancamento_Leave(object sender, EventArgs e)
        {
            str = "";
        }
    }
}
