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
using BarTum.Utilities.Impressoes;
using System.Drawing.Printing;
using BarTum.Windows.Modulos.Produto;
using BarTum.Windows.Modulos.Configuracoes;


namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmIncluirAdicional : Form
    {

        public frmIncluirProduto frmIncluirProduto;
        

        public frmIncluirAdicional()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdutoList frm = new frmProdutoList();
            frm.frmIncluirAdicional = this;
            frm.ShowDialog();
        }

        private void ProdutoID_TextChanged(object sender, EventArgs e)
        {

            BarTumEntities _context = new BarTumEntities();
            _context.Refresh(System.Data.Objects.RefreshMode.ClientWins, _context.EB_Produto);

            decimal idProdutotxt;
            try { idProdutotxt = ProdutoID.Text == "" ? 0 : Convert.ToDecimal(ProdutoID.Text); }
            catch { idProdutotxt = 0; ProdutoID.Text = ""; dsProduto.Text = "";  nrPrecoVenda.Text = ""; }



            var Prod = _context.EB_Produto.FirstOrDefault(cl => cl.ProdutoID == idProdutotxt && cl.flExcluido == false && cl.TipoProdutoID != 3);
            if (Prod != null)
            {
                dsProduto.Text = Prod.dsProduto;
                nrPrecoVenda.Text = Convert.ToDecimal(Prod.nrPrecoVenda).ToString("C");
            }
            else
            {
                dsProduto.Text = "";
                nrPrecoVenda.Text = "";
            }
        }


        #region mascaras
        //máscaras
        string str = "";
        private void nrPrecoVenda_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
        private void nrPrecoVenda_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion mascaras


      

        private void botaoSalvar_Click(object sender, EventArgs e)
        {

            if (ProdutoID.Text != "")
            {
                int selecionado = this.frmIncluirProduto.dgvProdutos.SelectedRows[0].Index;
                decimal IDProduto = Convert.ToDecimal(ProdutoID.Text);
                string Descricao = dsProduto.Text;
                decimal Quant = Convert.ToDecimal(nrQuantidade.Value);
                decimal vlVenda = Convert.ToDecimal(nrPrecoVenda.Text.Replace("R$ ", ""));
                decimal total = (Quant * vlVenda);


                var obj = new BarTum.Windows.Modulos.Atendimento.frmIncluirProduto.ListaAdicionais { IDProduto = IDProduto, Descricao = Descricao, Quantidade = Quant, VlVenda = vlVenda, Total = total };

                var dados = (List<BarTum.Windows.Modulos.Atendimento.frmIncluirProduto.ListaAdicionais>)this.frmIncluirProduto.ArrayAdicional[selecionado];

                if (dados == null)
                {
                    this.frmIncluirProduto.DtListaAdicional = new List<Atendimento.frmIncluirProduto.ListaAdicionais>();
                    this.frmIncluirProduto.DtListaAdicional.Add(obj);
                    this.frmIncluirProduto.ArrayAdicional[selecionado] = this.frmIncluirProduto.DtListaAdicional;
                }
                else
                {
                    dados.Add(obj);
                }


                this.frmIncluirProduto.populaListaAdicionais();

                this.Close();
            }

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIncluirAdicional_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void frmIncluirAdicional_Load(object sender, EventArgs e)
        {

        }

        private void frmIncluirAdicional_KeyDown(object sender, KeyEventArgs e)
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


    }
}
