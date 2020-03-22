using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Windows.Modulos.Fornecedor;
using BarTum.Windows.Modulos.Banco;
using BarTum.Windows.Modulos.Formas_pagamento;


namespace BarTum.Windows.Modulos.Contas
{
    public partial class frmContasPagarCadastro : Form
    {
        BarTumEntities _context = new BarTumEntities();


        public frmContasPagarList frmContasPagarList;
        public decimal id;
        public bool consulta = false;
        public bool baixar = false;

        public frmContasPagarCadastro()
        {
            InitializeComponent();
            AutoCompleteComboBoxTest();
        }


        public AutoCompleteComboBox combo = new AutoCompleteComboBox();
        public void AutoCompleteComboBoxTest()
        {   
            combo.Location = new Point(280, 193);
            combo.Size = new Size(345, 21);
            combo.Name = "txtPlanoContasID";
            combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(combo);

            populaPlanoContas();
        }

        public void populaPlanoContas()
        {
            BarTumEntities context = new BarTumEntities();
            var query = (from plano in _context.EB_PlanoContas where plano.TipoLanctoID == 2  select new { plano.dsPlanoConta, plano.PlanoContaID });
            eBPlanoContasBindingSource.DataSource = query;
            combo.DataSource = eBPlanoContasBindingSource;
            combo.ValueMember = "PlanoContaID";
            combo.DisplayMember = "dsPlanoConta";
        }

        public void populaFornecedores(decimal? idFornededor)
        {

            BarTumEntities context = new BarTumEntities();
            var query = (from a in context.EB_Fornecedor where a.FornecedorID == idFornededor orderby a.dsNomeFantasia ascending select new { a.dsNomeFantasia, a.FornecedorID });
            eBFornecedorBindingSource.DataSource = query;
           
        }

        public void populaContas()
        {
            BarTumEntities context = new BarTumEntities();
            var query = (from a in context.EB_ContaCorrente orderby a.dsDescricao ascending select new { a.dsDescricao, a.ContaID });
            eBContaCorrenteBindingSource.DataSource = query;
           
        }

        public void populaFormasPagamento()
        {
            BarTumEntities context = new BarTumEntities();
            var query = (from a in context.EB_FormaPagamento where a.flMostrarnoContas == true && a.Flexcluido == false orderby a.ordem ascending select new { a.dsForma, a.FormaPagamentoID });
            eBFormaPagamentoBindingSource.DataSource = query;
        }


        public void preencheFormularioEdit()
        {

            //Dias atraso
            DateTime dataAtual;
            DateTime dataVencimento;
            TimeSpan subDatas;

            try
            {



                var ContasEnt = this.frmContasPagarList._context.EB_Contas.Single(cl => cl.contasID == this.id);



                dataAtual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                dataVencimento = Convert.ToDateTime(ContasEnt.dtVencimento);
                subDatas = dataAtual - dataVencimento;
                txtDiasAtrasados.Text = subDatas.TotalDays.ToString();


                
                txtContasID.Text = ContasEnt.contasID.ToString();

                populaFornecedores(ContasEnt.FornecedorID); 

                if (ContasEnt.FornecedorID != null)
                {
                    txtFornecedorID.SelectedValue = ContasEnt.FornecedorID;
                }
                else
                {
                    txtFornecedorID.Enabled = false;
                    botaoBuscarPendentes.Enabled = false;
                    eBFornecedorBindingSource.DataSource = null;
                }
                combo.SelectedValue = ContasEnt.PlanoContaID;
                txtDescricao.Text = ContasEnt.descricao;
                txtvlConta.Text = Convert.ToDecimal(ContasEnt.vlConta).ToString("C");
                txtDtVencimento.Value = Convert.ToDateTime(ContasEnt.dtVencimento);
                txtObservacoes.Text = ContasEnt.observacoes;

                if (ContasEnt.flBaixada == true)
                {

                    dataAtual = Convert.ToDateTime(ContasEnt.dtPagamentoOuRecebimento);
                    dataVencimento = Convert.ToDateTime(ContasEnt.dtVencimento);
                    subDatas = dataAtual - dataVencimento;
                    txtDiasAtrasados.Text = subDatas.TotalDays.ToString() + (subDatas.TotalDays < 0 ? " antecipado" : " atrasado");

                    groupBox1.Visible = true;
                    situacaoRadio1.Checked = false;
                    situacaoRadio2.Checked = true;

                    txtFechaData.Value = Convert.ToDateTime(ContasEnt.dtPagamentoOuRecebimento);
                    if (ContasEnt.DestDescontoID == 1 ? Radiodescontar1.Checked = true : Radiodescontar2.Checked = true) ;
                    txtContaCorrente.SelectedValue = ContasEnt.DestOuOrigDescontoContaCorrenteID;
                    comboBoxFormaPagamento.SelectedValue = ContasEnt.FormaPagamentoID;
                    vlaPagar.Text = Convert.ToDecimal(ContasEnt.fechaValorPago).ToString("C");

                    botaoSalvar.Enabled = false;
                }
                else
                {
                    situacaoRadio2.Checked = false;
                    situacaoRadio1.Checked = true;
                }
            }catch(Exception error)
            {

            }
        }

        private void frmContasPagarCadastro_Load(object sender, EventArgs e)
        {

            if(this.id != 0)
            {
                if (_context.EB_Contas.Single(a => a.contasID == this.id).flBaixada == true)
                {
                    botaoSalvar.Enabled = false;
                }
            }
            
            populaContas(); populaFormasPagamento();

            txtdtlancto.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDtVencimento.Text = DateTime.Now.AddMonths(1).ToString("dd/MM/yyyy");
            txtFechaData.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtContaCorrente.Enabled = false;
            button2.Enabled = false;


            if (this.id != null)
            {
                preencheFormularioEdit();
                botaoSalvar.Text = "Salvar alterações";
            }


           

            if (this.consulta == true)
            {
                botaoSalvar.Visible = false;
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


        public bool validaFormaPagamento()
        {
            if (comboBoxFormaPagamento.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, "Selecione uma forma de pagamento", "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                comboBoxFormaPagamento.Focus();
                return false;
            }

            return true;
        }


        public bool validaBaixar()
        {
          
            string message = "Baixar registro?";
            string caption = "EasyBar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void fill(ref EB_Contas ContasEnt)
        {

            ContasEnt.pai = 0;
            ContasEnt.FornecedorID = Convert.ToDecimal(txtFornecedorID.SelectedValue);
            ContasEnt.PlanoContaID = Convert.ToDecimal(combo.SelectedValue);
            ContasEnt.TipoLanctoID = 2; //despesa
            ContasEnt.descricao = txtDescricao.Text;
            ContasEnt.vlConta = Convert.ToDecimal(txtvlConta.Text.Replace("R$ ", "").Replace(".", ""));
            ContasEnt.dtVencimento = Convert.ToDateTime(txtDtVencimento.Value);
            ContasEnt.observacoes = txtObservacoes.Text;
            ContasEnt.flBaixada = false;
           

            if (situacaoRadio2.Checked == true)
            {

                ContasEnt.CaixaID = this.idCaixa;
                ContasEnt.flBaixada = true;
                ContasEnt.dtPagamentoOuRecebimento = Convert.ToDateTime(txtFechaData.Value);
                ContasEnt.DestDescontoID = Convert.ToDecimal(Radiodescontar1.Checked == true ? 1 : 2);
                ContasEnt.DestOuOrigDescontoContaCorrenteID = Radiodescontar2.Checked == true ? (decimal?)txtContaCorrente.SelectedValue : null;
                ContasEnt.FormaPagamentoID = Convert.ToDecimal(comboBoxFormaPagamento.SelectedValue);
                ContasEnt.fechaValorPago = Convert.ToDecimal(txtvlConta.Text.Replace("R$ ", "").Replace(".", ""));

            }

        }

        private decimal idCaixa;
        public bool validaCaixa(DateTime data)
        {
            var query = (from item in _context.EB_Caixa
                          orderby item.dtCaixa ascending
                          where item.dtCaixa == data
                          select new
                          {
                              item
                          }
                      ).ToList();

            

            if(query.Count == 0)
            {
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult result2;
                result2 = MessageBox.Show(this, "O caixa não foi aberto nesta data.", "BarTum", buttons2,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return false;
            }
            else if (query.Count > 0)
            {
                this.idCaixa = query[0].item.CaixaID;

                if (query[0].item.EB_CaixaHistoricoFechamento.SingleOrDefault().dsStatus == "fechado")
                {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        result = MessageBox.Show(this, "O caixa nesta data já foi fechado deseja descontar o valor assim mesmo?", "BarTum", buttons,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            return true;
                           
                        }
                        else
                        {
                            return false;
                        }
                }
            }
            return true;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtDescricao.Text == "")
                {
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    DialogResult result2;
                    result2 = MessageBox.Show(this, "Informe uma descrição", "BarTum", buttons2,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    txtDescricao.Focus();
                    return;
                }
                else if (combo.SelectedValue == null)
                {
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    DialogResult result2;
                    result2 = MessageBox.Show(this, "Selecione um plano de contas", "BarTum", buttons2,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    combo.Focus();
                    return;
                }

                EB_Contas ContasEnt = new EB_Contas();


                if (situacaoRadio2.Checked == true)
                {
                   

                    if (!validaFormaPagamento())
                    {
                        return;
                    }

                    if (this.baixar == true)
                    {
                        if (!validaBaixar())
                        {
                            return;
                        }
                    }



                    if (!validaCaixa(txtFechaData.Value))
                    {
                        return;
                    }


                }



                if (txtContasID.Text == "")
                {



                    fill(ref ContasEnt);




                    frmMain frmMain = (frmMain)this.frmContasPagarList.MdiParent;
                    ContasEnt.usuarioID = frmMain.UsuarioLogado;
                    ContasEnt.dtlancto = DateTime.Now;




                  if (ContasEnt.Valida(ContasEnt))
                    {
                  

                        this.frmContasPagarList._context.AddToEB_Contas(ContasEnt);
                        this.frmContasPagarList._context.SaveChanges();
                        


                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Lançamento inserido com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);

                        if (this.frmContasPagarList != null)
                        {
                            this.frmContasPagarList.ComboExibir_SelectedIndexChanged(null, null);
                        }


                        this.Close();

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(txtContasID.Text);

                    ContasEnt = this.frmContasPagarList._context.EB_Contas.Single(cl => cl.contasID == id);

                    fill(ref ContasEnt);

                    if (ContasEnt.Valida(ContasEnt))
                    {

                        this.frmContasPagarList._context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Lançamento atualizado com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);


                        if (this.frmContasPagarList != null)
                        {
                           this.frmContasPagarList.ComboExibir_SelectedIndexChanged(null, null);
                        }

                        this.Close();


                    }
                }


            }
            catch (Exception error)
            {

            }
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            if (situacaoRadio1.Checked == true)
            {
                groupBox1.Visible = false;
            }
        }

        private void situacaoRadio2_Click(object sender, EventArgs e)
        {
            if (situacaoRadio2.Checked == true)
            {
                groupBox1.Visible = true;
            }
        }

        private void botaoBuscarPendentes_Click(object sender, EventArgs e)
        {
            frmFornecedorList frm = new frmFornecedorList();
            frm.frmContasPagarCadastro = this;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPlanoContaList frm = new frmPlanoContaList();
            frm.frmContasPagarCadastro = this;
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBancoList frm = new frmBancoList();
            frm.frmContasPagarCadastro = this;
            frm.ShowDialog();
        }

        private void Radiodescontar1_Click(object sender, EventArgs e)
        {
            txtContaCorrente.Enabled = false;
            button2.Enabled = false;
        }

        private void Radiodescontar2_CheckedChanged(object sender, EventArgs e)
        {
            txtContaCorrente.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFormasPagamentoList frm = new frmFormasPagamentoList();
            frm.frmContasPagarCadastro = this;
            frm.ShowDialog();
        }

        private void frmContasPagarCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    if (botaoSalvar.Enabled)
                    {
                        botaoSalvar_Click(null, null);
                    }
                    break;
            }
        }

        private void txtvlConta_Leave(object sender, EventArgs e)
        {
            this.str = "";
        }

    }










    public class AutoCompleteComboBox : ComboBox
    {
        private bool controlKey = false;

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (int)Keys.Escape)
            {
                this.SelectedIndex = -1;
                this.Text = "";
                controlKey = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                controlKey = true;
            }
            else
            {
                controlKey = false;
            }
        }

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.Text != "" && !controlKey)
            {
                string matchText = this.Text;
                int match = this.FindString(matchText);
                if (match != -1)
                {
                    this.SelectedIndex = match;
                    this.SelectionStart = matchText.Length;
                    this.SelectionLength = this.Text.Length - this.SelectionStart;
                }
            }
        }
    }
}
