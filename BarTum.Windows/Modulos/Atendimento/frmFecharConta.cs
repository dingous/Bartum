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
using System.Data;
using BarTum.Windows.Modulos.Cliente;




namespace BarTum.Windows.Modulos.Atendimento
{
   
    public partial class frmFecharConta : Form
    {
        
        public frmAtendimento pai;
        decimal troco;

        public frmFecharConta(frmAtendimento pai)
        {

          

            InitializeComponent();

            //ShowCampos();

            this.pai = pai;
            switch (this.pai.tipoVenda)
            {
                case "mesa":
                    label2.Text = "  Mesa " + pai.VendaMesa.textBoxMesa.Text;
                    break;
                case "balcao":
                    label2.Text = "  Venda Balcão nº " + pai.LanctoID.Text;
                    break;
                case "pedido":
                    label2.Text = "  Venda de Pedido nº " + pai.LanctoID.Text;
                    break;
                case "comanda":
                    label2.Text = "  Venda por comanda de nº " + pai.VendaComanda.textBoxComanda.Text;
                    break;
            }


            fillCampos();


            calculaCampos();

            txtDescontos.Focus();

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

            
            try
            {
                decimal idVenda = Convert.ToDecimal(pai.LanctoID.Text);
                var Venda = _context.EB_Lancamento.Single(cl => cl.LanctoID == idVenda);

                if (Venda.StatusID == 2)
                {

                    Venda.StatusID = 1;
                    _context.SaveChanges();

                    switch (this.pai.tipoVenda)
                    {
                        case "mesa":
                            pai.VendaMesa.groupBox1.Controls["mesa" + pai.VendaMesa.textBoxMesa.Text].BackColor = Color.OrangeRed;

                            
                        
                            //notifica ao servidor
                            frmMain frmMain = (frmMain)this.pai.MdiParent;
                            string jsoncliente = "{'acao':'ServidorInserirMesa',";
                            jsoncliente += "'MesaID' : '" + pai.VendaMesa.textBoxMesa.Text + "',";
                            jsoncliente += "'tipo' : 'ocupa'";
                            jsoncliente += "}";
                            frmMain.strigComando = jsoncliente;
                            frmMain.Atualiza();

                            break;
                    }

                    
                }


            }
            catch (Exception error)
            {

            }

            this.Close();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            txtTroco.Focus();

            calculaCampos();

            BarTumEntities _context = new BarTumEntities();
            decimal id = Convert.ToDecimal(FormaPagamento.SelectedValue);
            var formas = _context.EB_FormaPagamento.Single(cl => cl.FormaPagamentoID == id);
            try
            {
                decimal contaPagar = Convert.ToDecimal(txtTotalaPagar.Text.Replace("R$ ", "").Replace(".", ""));
                if (!(troco < 0) && !(contaPagar < 0))
                {

                    if (formas.CondicaoID == 2)
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
                        else
                        {
                            var Cliente = _context.EB_Cliente.Single(a => a.ClienteID == txtCodCliente.Value);
                            if(Cliente.nrStatus == 0)
                            {
                                string msg = "Este cliente está bloqueado no vendas a prazo, para maiores informações consulte as suas ocorrências.";
                                MessageBoxButtons buttons2_ = MessageBoxButtons.OK;
                                DialogResult result2_;
                                result2_ = MessageBox.Show(this, msg, "BarTum", buttons2_,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                                return;
                            }
                        }



                    }



                    MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                    DialogResult res;
                    res = MessageBox.Show(this, "Confirmar fechamento desta venda?", "BarTum", buttons2,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (res == DialogResult.No)
                    {
                        return;
                    }







                    decimal idVenda = Convert.ToDecimal(pai.LanctoID.Text);
                    var Venda = _context.EB_Lancamento.Single(cl => cl.LanctoID == idVenda);

                    if (Venda.StatusID == 1 || Venda.StatusID == 2)
                    {

                                               


                        if (!(txtValoraReceber.Text == "") && formas.EB_FormaPagamentoCondicao.CondicaoID == 2)
                        {
                            try
                            {

                                var ContasReceber = new EB_Contas();
                                ContasReceber.TipoLanctoID = 1;
                                ContasReceber.clienteID = Convert.ToDecimal(txtCodCliente.Text);
                                ContasReceber.lanctoID = Venda.LanctoID;
                                ContasReceber.descricao = "REFERENTE A VENDA DE Nº " + Venda.LanctoID;
                                ContasReceber.dtlancto = DateTime.Now;
                                ContasReceber.dtVencimento = Convert.ToDateTime(dtVencimento.Text);
                                ContasReceber.vlConta = Convert.ToDecimal(txtValoraReceber.Text.Replace("R$ ", "").Replace(".", ""));
                                frmMain frmMain = (frmMain)this.pai.MdiParent;
                                ContasReceber.usuarioID = frmMain.UsuarioLogado;
                                

                                //PLANO DE CONTAS PADRÃO DE VENDAS A PRAZO
                                ContasReceber.PlanoContaID = 1;

                                _context.AddToEB_Contas(ContasReceber);


                                //cliente passa a ser conveniado
                                ContasReceber.EB_Cliente.convenio = true;

                            }
                            catch (System.InvalidOperationException error)
                            {
                                MessageBox.Show("Não foi definido um plano de contas padrão para as vendas, defina-o em Sistema/Configurações Gerais.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);                                
                                return;
                            }

                        }


                       


                        Venda.FechaTotalConsumo = Convert.ToDecimal(txtTotalVenda.Text.Replace("R$ ", "").Replace(".", ""));
                        Venda.FechaAcrescimo = Convert.ToDecimal(txtAcrescimo.Text.Replace("R$ ", "").Replace(".", ""));
                        Venda.FechaDescontos = Convert.ToDecimal(txtDescontos.Text.Replace("R$ ", "").Replace(".", ""));
                        Venda.FechaAdiantamento = Convert.ToDecimal(txtAdiantamento.Text.Replace("R$ ", "").Replace(".", ""));
                        Venda.FechaTotalPago = Convert.ToDecimal(txtTotalaPagar.Text.Replace("R$ ", "").Replace(".", ""));
                        Venda.FechaTroco = Convert.ToDecimal(txtTroco.Text.Replace("R$ ", "").Replace(".", ""));


                        decimal? calculoFinal = Venda.FechaTotalPago + Venda.FechaAdiantamento;

                        Venda.FechaTotalVendaFinalizada = calculoFinal;

                       
                        Venda.StatusID = 3;
                        Venda.dtFimLancto = DateTime.Now;





                        if (!(vlrecebido.Text == "0,00"))
                        {
                            decimal? calcula = Venda.FechaTotalPago;
                            decimal idforma = Convert.ToDecimal(FormaPagamento.SelectedValue);
                            var forma = new EB_LancamentoFechamentoFormasPag();
                            forma.FormaPagamentoID = idforma;
                            forma.vlForma = Convert.ToDecimal(calcula);
                            forma.FlOrigemAdiantamento = false;
                            Venda.EB_LancamentoFechamentoFormasPag.Add(forma);
                        }



                        if(this.pai.tipoVenda == "pedido")
                        {
                            Venda.EB_LanctoPedidos.Single().flRecebido = true;

                            if (radioFlPagarEntregador.Checked == true)
                            {
                                Venda.EB_LanctoPedidos.Single().flPagoAoEntregador = true;
                            }
                            else
                            {
                                Venda.EB_LanctoPedidos.Single().flPagoAoEntregador = false;
                            }
                        }


                        //salva todas as alterações
                        _context.SaveChanges();



                        switch (this.pai.tipoVenda)
                        {
                            case "mesa":
                                pai.VendaMesa.groupBox1.Controls["mesa" + pai.VendaMesa.textBoxMesa.Text].BackColor = Color.Aquamarine;
                                pai.carregaInformacoes(Convert.ToDecimal(pai.VendaMesa.textBoxMesa.Text));

                                //notifica ao servidor
                                frmMain frmMain = (frmMain)this.pai.MdiParent;
                                string jsoncliente = "{'acao':'ServidorInserirMesa',";
                                jsoncliente += "'MesaID' : '" + pai.VendaMesa.textBoxMesa.Text + "',";
                                jsoncliente += "'tipo' : 'liberada'";
                                jsoncliente += "}";
                                frmMain.strigComando = jsoncliente;
                                frmMain.Atualiza();

                                break;
                            case "balcao":
                                pai.ChamaVendaBalcao();
                                break;
                            case "pedido":
                                pai.ChamaVendaEntrega();
                                break;
                            case "comanda":
                                pai.ChamaVendaComanda();
                                break;
                        }

                        pai.limpaInformacoes();
                        this.Close();
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        string msg = "";
                        switch (this.pai.tipoVenda)
                        {
                            case "mesa":
                                msg = "Esta mesa já foi fechada!";
                                break;
                            case "balcao":
                                msg = "Esta venda já foi fechada!";
                                break;
                            case "pedido":
                                msg = "Este pedido já foi fechado!";
                                break;
                        }

                        result = MessageBox.Show(this, msg, "BarTum", buttons,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                        return;
                    }

                }
                else
                {
                   
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Valores inconsistentes.", "BarTum", buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                        vlrecebido.Focus();
                        return;
                    
                }


                MessageBoxButtons b = MessageBoxButtons.OK;
                DialogResult j;
                j = MessageBox.Show(this, "Venda finalizada com sucesso!", "EasyBar", b,
                MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                if (this.pai.tipoVenda == "comanda")
                {
                    pai.VendaComanda.ShowComandas();
                }

            }
            catch (Exception error)
            {
                string erro = error.Message != "" ? error.Message : error.InnerException.Message;
                MessageBox.Show(erro);
            }
        }


        
        public void ShowCampos()
        {



            BarTumEntities context = new BarTumEntities();

            

            int x = 133;
            int y = 5;

            int x_ = 10;
            int y_ = 3;

            int cont = 0;
           
            var item = (from a in context.EB_FormaPagamento where a.Flexcluido == false orderby a.ordem ascending select a).ToList();


            foreach (var formas in item)
            {

                //EasyBar.Windows.Modulos.Atendimento.EasyBar.Windows.Modulos.Atendimento.TextBoxCondicao

                Label label;
                TextBox DynButton;
                Control ControlObject;
                Control ControlObject2;
                
                string ControlType = "System.Windows.Forms.TextBox";
                string ControlType2 = "System.Windows.Forms.Label";
                string ControlName = "campo" + formas.FormaPagamentoID;
                string ControlName2 = "label" + formas.FormaPagamentoID;
                
                System.Reflection.Assembly asm;
                asm = typeof(Form).Assembly;
                ControlObject = (System.Windows.Forms.Control)asm.CreateInstance(ControlType);
                ControlObject.Name = ControlName;
                ControlObject.Location = new System.Drawing.Point(x, y);

                System.Reflection.Assembly asm2;
                asm2 = typeof(Form).Assembly;
                ControlObject2 = (System.Windows.Forms.Control)asm2.CreateInstance(ControlType2);
                ControlObject2.Name = ControlName2;
                ControlObject2.Location = new System.Drawing.Point(x_, y_);

               
                panel1.Controls.Add(ControlObject2);
                panel1.Controls.Add(ControlObject);
                


                label = (System.Windows.Forms.Label)ControlObject2;
                label.Text = formas.dsForma + ":";
                label.Width = 120;
                label.TextAlign = ContentAlignment.MiddleRight;

                

                DynButton = (TextBox)ControlObject;
                DynButton.Width = 90;
                DynButton.Height = 21;
                DynButton.Text = "0,00";
                DynButton.TextAlign = HorizontalAlignment.Right;
                DynButton.BackColor = Color.FromName("Window");
                DynButton.KeyDown += new KeyEventHandler(Mask_KeyDown);
                DynButton.KeyPress += new KeyPressEventHandler(Mask_KeyPress);

                

                
             


                if (!(formas.CondicaoID == 2))
                {
                    DynButton.Leave += new EventHandler(DynButton_Leave);
                }
                else
                {
                    DynButton.Leave += new EventHandler(DynButton_Leave2);
                }
                               


                cont = cont + 1;
               

                if (cont % 1 == 0) {
                    
                    x = 133; 
                    y = y + 25; 
                    
                    x_ = 10;
                    y_ = y_ + 25; 
                } 
                


            }


        }







        public void fillCampos()
        {
            txtTotalVenda.Text = pai.txtTotalVenda.Text;
            txtAcrescimo.Text = pai.txtAcrescimo.Text;
            txtAdiantamento.Text = pai.txtAdiantamento.Text;
            txtDescontos.Text = pai.txtDescontos.Text;
            txtTotalaPagar.Text = pai.txtTotalaPagar.Text;
            totalStatico.Text = pai.txtTotalaPagar.Text;
            
        }


       
        public void calculaCampos()
        {
            try
            {
                decimal TotalaPagar = 0;
                decimal Descontos = 0;
                decimal ValorPago = 0;
                troco = 0;
                decimal calcDesconto = 0;

                /*Control.ControlCollection controles = panel1.Controls;
                foreach (Control item in controles)
                {


                    if (item.GetType().Name == "TextBox")
                    {
                        Control con = (TextBox)item;
                        ValorPago += Convert.ToDecimal(con.Text.Replace("R$ ", "").Replace(".", ""));
                    }
                }*/

                ValorPago += Convert.ToDecimal(vlrecebido.Text.Replace("R$ ", "").Replace(".", "")); 

                //seta variaveis
                TotalaPagar = txtDescontos.Text == "" ? 0 : Convert.ToDecimal(totalStatico.Text.Replace("R$ ", "").Replace(".", ""));
                Descontos = txtDescontos.Text == "" ? 0 : Convert.ToDecimal(txtDescontos.Text.Replace("R$ ", "").Replace(".", ""));


                //calcula
                calcDesconto = (TotalaPagar - Descontos);
                troco = (ValorPago - calcDesconto);


                //imprime
                txtTotalaPagar.Text = calcDesconto.ToString("C");
                txtTroco.Text = troco.ToString("C");


               

                if (troco < 0)
                {
                    txtTroco.BackColor = Color.Red;
                }
                else
                {
                    txtTroco.BackColor = Color.White;
                }

                txtValoraReceber.Text = vlrecebido.Text;
                

            }catch(Exception error)
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

        void DynButton_Leave2(object sender, EventArgs e)
        {
            this.str = "";

            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text == "" || txtBox.Text == "0,00")
            {
                txtBox.Text = "0,00";
                groupBox3.Visible = false;
                txtValoraReceber.Text = "";
            }
            else
            {
                calculaCampos();
                groupBox3.Visible = true;
                txtCodCliente.TextChanged +=new EventHandler(txtCodCliente_TextChanged);
                decimal total = 0;

                //Control.ControlCollection controles = panel1.Controls;            
               /* foreach (Control item in controles)
                {
                    if (item.GetType().Name == "TextBoxFormas")
                    {
                        Control con = (TextBoxFormas)item;
                        TextBoxFormas con2 = (TextBoxFormas)con;
                        if (con2.condicao_pagto == 2)
                        {
                            if (!(con.Text == "0,00"))
                            {

                                total += Convert.ToDecimal(con.Text.Replace("R$ ", "").Replace(".", ""));
                                 
                            }
                        }
                    }
                }*/

                txtValoraReceber.Text = txtBox.Text;
            }

        }

        void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            using (BarTumEntities context = new BarTumEntities())
            {
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

        private void BuscarClientes_Click(object sender, EventArgs e)
        {
            frmClienteList _frmCliente = new frmClienteList();
            _frmCliente.frmFecharConta = this;
            _frmCliente.frmMain = (frmMain)pai.frmMain;
            _frmCliente.ShowDialog();
        }


        public void populaFormasPagamento()
        {
            BarTumEntities context = new BarTumEntities();
            var query = (from formas in context.EB_FormaPagamento where formas.Flexcluido == false orderby formas.ordem ascending select new { formas.FormaPagamentoID, formas.dsForma });
            eBFormaPagamentoBindingSource.DataSource = query;
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
                txtCodCliente.Value = 0;
                txtNomeCliente.Text = "";
                groupBox3.Visible = false;
            }
        }


        private void frmFecharConta_Load(object sender, EventArgs e)
        {
            dtVencimento.Text = DateTime.Now.ToString("dd/MM/yyyy");


            populaFormasPagamento();


            if (this.pai.tipoVenda == "pedido")
            {
                groupBoxEntregador.Enabled = true;
                groupBoxEntregador.Visible = true;
            }
        }

       

        private void frmFecharConta_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Enter:
                    botaoSalvar_Click(sender, e);
                    break;
                case Keys.Escape:
                    botaoCancelar_Click(sender, e);
                    break;


            }
        }


    
    }
}
