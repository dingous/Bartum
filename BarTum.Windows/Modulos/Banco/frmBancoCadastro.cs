using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using BarTum.Entities;
using BarTum.Utilities;
using System.ComponentModel.DataAnnotations;

namespace BarTum.Windows.Modulos.Banco
{
    public partial class frmBancoCadastro : Form
    {

        private decimal? id_;
        public decimal? id { get { return id_; } set { id_ = value; } }

        public frmBancoList frmBancoList;


        private bool consulta_ = false;
        public bool consulta { get { return consulta_; } set { consulta_ = value; } }

        public frmBancoCadastro()
        {
            InitializeComponent();
        }

        
        


        public void preencheFormularioEdit()
        {
            BarTumEntities _context = new BarTumEntities();
            var item = (from a in _context.EB_ContaCorrente select a).Single(a => a.ContaID == this.id);

            txtContaID.Text = item.ContaID.ToString();
            txtDsDescricao.Text = item.dsDescricao;
            txtNrContaNumero.Text = item.nrContaNumero.ToString();
            txtdtReferencia.Text = item.dtReferencia.ToString();
            txtSaldoInicial.Text = Convert.ToDecimal(item.mnSaldoInicial).ToString("C");
            txtLimite.Text = Convert.ToDecimal(item.mnLimite).ToString("C");
            txtAgencia.Text = item.dsAgencia;
            txtNomeGerente.Text = item.dsNomeGerente;
            txtNrTelefone.Text = item.nrTelefone;
        }


        private void frmBairroCadastro_Load(object sender, EventArgs e)
        {
            txtDtCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtdtReferencia.Text = DateTime.Now.ToString("dd/MM/yyyy");

            if (this.id != null)
            {
                preencheFormularioEdit();
                botaoSalvar.Text = "Salvar alterações";
            }


            if (this.consulta == true)
            {
                botaoSalvar.Visible = false;
            }

            if (this.frmBancoList != null)
            {
             
            }

        }

        public void fill(ref EB_ContaCorrente ContaEnt)
        {
            ContaEnt.dsDescricao = txtDsDescricao.Text;
            ContaEnt.nrContaNumero = txtNrContaNumero.Text != "" ? (decimal?)Convert.ToDecimal(txtNrContaNumero.Text) : null;
            ContaEnt.dtReferencia = Convert.ToDateTime(txtdtReferencia.Text);
            ContaEnt.mnSaldoInicial = Convert.ToDecimal(txtSaldoInicial.Text.Replace("R$ ", "").Replace(".", ""));
            ContaEnt.dsAgencia = txtAgencia.Text;
            ContaEnt.mnLimite = Convert.ToDecimal(txtLimite.Text.Replace("R$ ", "").Replace(".", ""));
            ContaEnt.dsNomeGerente = txtNomeGerente.Text;
            ContaEnt.nrTelefone = txtNrTelefone.Text;
            
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                EB_ContaCorrente ContaEnt = new EB_ContaCorrente();



                if (txtContaID.Text == "")
                {


                    fill(ref ContaEnt);


                    if (ContaEnt.Valida(ContaEnt))
                    {

                        this.frmBancoList.context.AddToEB_ContaCorrente(ContaEnt);
                        this.frmBancoList.context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Conta corrente inserida com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmBancoList.populaGridview();
                        this.Close();

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(txtContaID.Text);

                    ContaEnt = this.frmBancoList.context.EB_ContaCorrente.Single(cl => cl.ContaID == id);

                    fill(ref ContaEnt);

                    if (ContaEnt.Valida(ContaEnt))
                    {
                        this.frmBancoList.context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Conta corrente atualizada com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmBancoList.populaGridview();
                        this.Close();


                    }
                }


            }
            catch (Exception error)
            {

            }
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

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSaldoInicial_Leave(object sender, EventArgs e)
        {
            str = "";
        }

        private void txtLimite_Leave(object sender, EventArgs e)
        {
            str = "";
        }

        private void frmBancoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    botaoCancelar_Click(sender, e);
                    break;
                case Keys.Enter:
                    botaoSalvar_Click(sender, e);
                    break;
            }
        }
    }
}
