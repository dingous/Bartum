using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Utilities;

namespace BarTum.Windows.Modulos.Caixa
{
    public partial class frmPrimeiroAcessoCaixa : Form
    {

        public Caixa Caixa;

        public frmPrimeiroAcessoCaixa()
        {
            InitializeComponent();
        }

        private void frmPrimeiroAcessoCaixa_Load(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            TxtBoxDataAbertura.Value = DateTime.Now;

            var ultimoCaixa = _context.EB_Caixa.OrderByDescending(a => a.dtCaixa).Take(1).ToList();
            EB_Caixa dados;

            if (ultimoCaixa.Count > 0)
            {
                dados = ultimoCaixa[0];
                //textBoxSaldoInicial.Text = Convert.ToDecimal(dados.fechamentoFundoCaixaDiaPosterior).ToString("C2");
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

        private void botaoSalvar_Click(object sender, EventArgs e)
        {


            if (TxtBoxDataAbertura.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("A data de abertura não pode ser menor que a data atual.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BarTumEntities _context = new BarTumEntities();
            DateTime inicio = new DateTime(TxtBoxDataAbertura.Value.Year, TxtBoxDataAbertura.Value.Month, TxtBoxDataAbertura.Value.Day, 0, 0, 0);
            DateTime fim = new DateTime(TxtBoxDataAbertura.Value.Year, TxtBoxDataAbertura.Value.Month, TxtBoxDataAbertura.Value.Day, 23, 59, 59);

            frmMain frmMain = (frmMain)this.MdiParent;
            
            var queryEstaAberto = (from item in _context.EB_Caixa
                                       orderby item.dtCaixa descending
                                       where item.dtCaixa >= inicio && item.dtCaixa <= fim
                                       select new
                                       {
                                           item
                                       }
                                    ).ToList();

            if (queryEstaAberto.Count > 0)
            {
                //MessageBox.Show("O caixa já foi aberto nesta data");
                //return;
            }
         

                var box = MessageBox.Show("Confirmar abertura do caixa?", "Abertura do caixa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (box == DialogResult.Yes)
                {

                    try
                    {
                        EB_Caixa caixa = new EB_Caixa();
                        caixa.dtCaixa = DateTime.Now;


                        EB_CaixaHistoricoFechamento hist = new EB_CaixaHistoricoFechamento();
                        hist.EB_Caixa = caixa;
                        hist.dsStatus = "aberto";
                        hist.UsuarioIDAbertura = frmMain.UsuarioLogado;
                        hist.vlAberturaCaixa = Convert.ToDecimal(textBoxSaldoInicial.Text.Replace("R$ ", ""));
                        hist.dtCaixaAbertura = DateTime.Now;

                        _context.AddToEB_Caixa(caixa);
                        _context.SaveChanges();

                        frmMain.Caixa.caixaObjContexto = caixa;
                        frmMain.Caixa.caixaContexto = caixa.CaixaID;
                        frmMain.Caixa.caixaDataAberturaContexto = DateTime.Now;


                        MessageBox.Show("O caixa foi aberto com sucesso!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Program.main.VerificaCaixaSemConfirmacao();

                        this.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Houve um erro na abertura do caixa, tente novamente!");
                    }
                    
                }
               
            

          
        }
    }
}
