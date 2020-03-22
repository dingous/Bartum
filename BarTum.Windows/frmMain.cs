using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TServerSocket;
using TClientSocket;
using System.Xml;
using BarTum.Utilities;
using BarTum.Entities;
using System.IO;
using System.Reflection;
using System.Threading;
using BarTum.Windows.Modulos.Atualizacao;
using BarTum.Windows.Modulos.Cliente;
using BarTum.Windows.Modulos.Atendimento;
using BarTum.Windows.Modulos.Garcon;
using BarTum.Windows.Modulos.Produto;
using BarTum.Windows.Modulos.Entregador;
using BarTum.Windows.Modulos.Bairro;
using BarTum.Windows.Modulos.Configuracoes;
using BarTum.Windows.Modulos.Caixa;
using BarTum.Windows.Modulos.Contas;
using BarTum.Windows.Modulos.Fornecedor;
using BarTum.Windows.Modulos.Banco;
using BarTum.Windows.Modulos.Formas_pagamento;
using BarTum.Windows.Modulos.Estoque;
using BarTum.Windows.Modulos.Empresa;
using BarTum.Windows.Modulos.Login;
using BarTum.Windows.Modulos.Pagamentos;
using BarTum.Windows.Modulos.Impressao;
using BarTum.Windows.Modulos.Relatorios;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace BarTum.Windows
{
    public partial class frmMain : Form
    {

        public string nomeSistema = "EasyBar";
        public Caixa Caixa;
        public frmAtendimento frmAtendimento = null;
        public decimal UsuarioLogado;
        public string UsuarioLogadoNome;
        public bool estaLogado = false;

        public frmMain()
        {
            InitializeComponent();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            //try
            //{
            if (estaLogado == false)
            {
                //verificaUsuario();

                BarTumEntities contexto = new BarTumEntities();
                var query = contexto.EB_Usuario.FirstOrDefault();
                if (query == null)
                {
                    MessageBox.Show("Usuário não cadastrado.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    EB_Usuario usuario = query;
                    this.UsuarioLogado = usuario.UsuarioID;
                    this.UsuarioLogadoNome = usuario.dsNome;
                    this.estaLogado = true;
                }

            }

            RunThread();

            VerificaCaixa();

            this.Visible = true;
            this.Enabled = true;
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.Message);
            //    if (this != null)
            //    {

            //        frmConfiguracoesIniciais frm = new frmConfiguracoesIniciais();
            //        frm.frmMain = this;
            //        frm.ShowDialog();
            //        frm.Focus();
            //        frm.TopMost = true;
            //        this.Enabled = false;
            //        return;
            //    }
            //}

        }


        public void verificaUsuario()
        {
            try
            {

                if (estaLogado == false)
                {
                    this.Enabled = false;
                    this.Visible = false;

                    frmLogin frm = new frmLogin();
                    frm.frmMain = this;
                    frm.TopMost = true;
                    frm.ShowDialog();
                    return;
                }

                estaLogado = true;

            }
            catch (Exception error)
            {

            }

        }

        public void VerificaCaixa()
        {
            try
            {

                Caixa = new Caixa();
                Caixa.frmMain = this;
                Caixa.verificaAbertos();

                if (Caixa.primeiroAcessoAoCaixa == true)
                {
                    CaixaConfirmacao();
                }

                if (Caixa.caixaObjContexto != null)
                {
                    toolStripStatusLabelCaixaInfo.Text = "Data/Hora abertura do Caixa: " + Caixa.caixaDataAberturaContexto.ToString("dd/MM/yyyy H:mm");
                }
                else
                {
                    toolStripStatusLabelCaixaInfo.Text = "O caixa ainda não foi aberto";
                }
            }
            catch (Exception error)
            {

            }
        }


        public void VerificaCaixaSemConfirmacao()
        {
            try
            {

                Caixa = new Caixa();
                Caixa.frmMain = this;
                Caixa.verificaAbertos(false);

                if (Caixa.primeiroAcessoAoCaixa == true)
                {
                    CaixaConfirmacao();
                }

                if (Caixa.caixaObjContexto != null)
                {
                    toolStripStatusLabelCaixaInfo.Text = "Data/Hora abertura do Caixa: " + Caixa.caixaDataAberturaContexto.ToString("dd/MM/yyyy H:mm");
                }
                else
                {
                    toolStripStatusLabelCaixaInfo.Text = "O caixa ainda não foi aberto";
                }
            }
            catch (Exception error)
            {

            }
        }


        public void CaixaConfirmacao()
        {
            frmPrimeiroAcessoCaixa frm = new frmPrimeiroAcessoCaixa();
            frm.Caixa = Caixa;
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }


        private void tsbCliente_Click(object sender, EventArgs e)
        {
            frmClienteList _frmCliente = new frmClienteList();
            _frmCliente.MdiParent = this;
            _frmCliente.frmMain = this;
            _frmCliente.Show();
        }

        public bool confirmaSaida = true;
        public void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirmaSaida == true)
            {
                /*var box = MessageBox.Show("Deseja realmente sair?", "Sair...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (!(box == DialogResult.Yes))
                {
                    e.Cancel = true;

                }*/
            }

            confirmaSaida = true;
        }

        private void tsbFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorList frm = new frmFornecedorList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbControle_Click(object sender, EventArgs e)
        {
            frmAtendimento form = SingleForm.GetInstance<frmAtendimento>(this);
            form.MdiParent = this;
            this.frmAtendimento = form;
            form.Show();



        }

        private void garçonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGarconList _frmCliente = SingleForm.GetInstance<frmGarconList>(this);
            _frmCliente.MdiParent = this;
            _frmCliente.Show();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormasPagamentoList frm = new frmFormasPagamentoList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbProduto_Click(object sender, EventArgs e)
        {
            frmProdutoList _frmCliente = new frmProdutoList();
            _frmCliente.MdiParent = this;
            _frmCliente.Show();
        }

        private void tsbVenda_Click(object sender, EventArgs e)
        {
            frmAtendimento = new frmAtendimento();
            frmAtendimento.MdiParent = this;
            frmAtendimento.ChamaVendaMesa();
            frmAtendimento.Show();
        }

        private void tsbEntrega_Click(object sender, EventArgs e)
        {
            frmAtendimento frm = new frmAtendimento();
            frm.MdiParent = this;
            frm.ChamaVendaBalcao();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmVendas frm = new frmVendas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntregadorList frm = new frmEntregadorList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bairrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBairroList frm = new frmBairroList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracoesSistema frm = new frmConfiguracoesSistema();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gerenciarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoList _frmCliente = new frmProdutoList();
            _frmCliente.MdiParent = this;
            _frmCliente.Show();
        }

        private void dadosDaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEmpresa frm = new frmCadEmpresa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void grupoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupoProdutoList frm = new frmGrupoProdutoList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbPedido_Click(object sender, EventArgs e)
        {
            frmAtendimento frm = SingleForm.GetInstance<frmAtendimento>(this);
            frm.MdiParent = this;
            frm.ChamaVendaEntrega();
            frm.Show();
        }



        private void origemDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrigemProdutoList frm = new frmOrigemProdutoList();
            frm.MdiParent = this;
            frm.Show();
        }

        public void fecharCaixa()
        {
            frmCaixaFluxo frm = new frmCaixaFluxo();
            frm.MdiParent = this;
            frm.Show();
        }


        public void tsbCaixa_Click(object sender, EventArgs e)
        {
            fecharCaixa();
        }

        private void tsbContas_Click(object sender, EventArgs e)
        {
            frmContasPagarCadastro frm = new frmContasPagarCadastro();
            frm.ShowDialog();
        }

        private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanoContaList frm = new frmPlanoContaList();
            frm.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasPagarList frm = new frmContasPagarList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmAtendimento form = SingleForm.GetInstance<frmAtendimento>(this);
            form.MdiParent = this;
            form.Show();
            form.chamaBuscaVendas();

        }

        private void contasBancáriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBancoList form = SingleForm.GetInstance<frmBancoList>(this);
            form.MdiParent = this;
            form.Show();

        }

        private void configuraçõesIniciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracoesIniciais frm = new frmConfiguracoesIniciais();
            frm.frmMain = this;
            frm.MdiParent = this;
            frm.Show();
            frm.TopMost = true;
        }











        /* Threads de Sockets  */
        #region servidor

        public ServerSocket servidor;
        public ClientSocket cliente;
        public bool servidor_ativo = false;
        public string IpServidor;
        public int ServerPort;
        public string TipoTerminal;
        public class Acao { public string acao; public string MesaID; public string tipo; }
        delegate void SetTextCallback(string text);

        public void RunThread()
        {

            try
            {

                bool primeiro_acesso = Properties.Clienteconfig.Default.primeiro_acesso;
                string ipserver = Properties.Clienteconfig.Default.ServidorIP;
                string portaserver = Properties.Clienteconfig.Default.ServidorPorta.ToString();

                this.TipoTerminal = Properties.Clienteconfig.Default.tipo;
                this.IpServidor = ipserver;
                this.ServerPort = portaserver == "" ? 0 : Convert.ToInt32(portaserver);


                //run
                backgroundWorker1.RunWorkerAsync();

                if (primeiro_acesso == true)
                {
                    //se for o primeiro acesso ao sistema abre janela de configuração
                    //para configurar o ip do servidor e a porta

                    //frmConfiguracoesIniciais frm = new frmConfiguracoesIniciais();
                    //frm.MdiParent = this;
                    //frm.Show();
                    //frm.TopMost = true;
                    //return;

                }


                if (this.TipoTerminal != "servidor")
                {
                    toolStripStatusLabel1.Visible = false;
                    toolStripStatusLabel2.Visible = false;
                    toolStripDropDownButton1.Visible = false;
                    statusCliente.Visible = true;

                }

                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " " + error.InnerException.Message);
            }


        }





        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                if (this.TipoTerminal == "servidor")
                {
                    timerConectaServidor.Enabled = false;
                    conectaServidor(this.ServerPort);

                    if (this.InvokeRequired)
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            panel1.Visible = false;
                        });

                }
                else if (this.TipoTerminal == "cliente")
                {

                    conectaCliente(this.IpServidor, this.ServerPort);

                    if (this.InvokeRequired)
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            panel1.Visible = false;
                        });

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int porcentagem = e.ProgressPercentage;

        }



        #region eventos do servidor

        public void conectaServidor(int porta)
        {
            try
            {

                if (this.InvokeRequired)
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        if (servidor_ativo == false)
                        {

                            this.ServerPort = porta;
                            this.servidor = new ServerSocket(this.ServerPort);

                            this.servidor.OnConnect += new ServerSocket.ConnectionDelegate(servidor_OnConnect);
                            this.servidor.OnDisconnect += new ServerSocket.ConnectionDelegate(servidor_OnDisconnect);
                            this.servidor.OnError += new ServerSocket.ErrorDelegate(servidor_OnError);
                            this.servidor.OnListen += new ServerSocket.ListenDelegate(servidor_OnListen);
                            this.servidor.OnRead += new ServerSocket.ConnectionDelegate(servidor_OnRead);
                            this.servidor.OnWrite += new ServerSocket.ConnectionDelegate(servidor_OnWrite);

                            servidor_ativo = this.servidor.Active();
                        }
                        else
                        {
                            ShowTextME_SS("Servidor já está conectado...\r");
                        }

                    });
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\n\n" + error.InnerException.Message);
            }

        }



        void servidor_OnListen()
        {
            ShowTextME_SS("Servidor ouvindo porta " + this.ServerPort.ToString() + "...\r");
        }


        void servidor_OnError(string ErroMessage, System.Net.Sockets.Socket soc, int ErroCode)
        {
            try
            {

                if (soc != null && servidor.GetSocketIndex(soc) >= 0)
                    ShowTextME_SS("(" + servidor.GetSocketIndex(soc).ToString() + " - " + servidor.RemoteHost(servidor.GetSocketIndex(soc)) + ") " + " ErrorSocket: " + ErroMessage + " ::: " + ErroCode.ToString() + "\r");
                else
                    ShowTextME_SS("Error: " + ErroMessage + "\r");

                toolStripStatusLabel2.Text = (servidor.ActiveConnections - 1).ToString();
            }
            catch (Exception error)
            {

            }
        }


        ClientesConectados Clients;

        public class ClientesConectados
        {
            private int indice;
            private string host;
            public ClientesConectados(int indice, string host) { this.indice = indice; this.host = host; }
            public string nomeHost { get { return host; } }
            public int codigoIndice { get { return indice; } }
            public override string ToString() { return this.host + " – " + this.indice; }
        }


        ArrayList conectados = new ArrayList();
        void servidor_OnConnect(System.Net.Sockets.Socket soc)
        {

            try
            {

                if (soc != null && soc.Connected == true)
                {

                    int indice = servidor.IndexOf(soc);
                    string host = servidor.RemoteHost(indice);

                    ShowTextME_SS("(" + indice + " : " + host + ") -  " + "Conectou ao servidor..." + "\r");


                    //conectados.Add(new ClientesConectados(indice, host));
                    //dataGridViewClientesConectados.DataSource = conectados;

                    if (this.InvokeRequired)
                    {
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            toolStripStatusLabel2.Text = servidor.ActiveConnections.ToString();
                        });
                    }
                }
                else
                {
                    ShowTextME_SS("Desconectado..." + "\r");
                }




            }
            catch (Exception error)
            {

            }




        }

        void servidor_OnDisconnect(System.Net.Sockets.Socket soc)
        {
            try
            {
                if (soc != null)
                {
                    int indice = servidor.IndexOf(soc);
                    RemoveLast(indice);

                    toolStripStatusLabel2.Text = (servidor.ActiveConnections - 1).ToString();
                    ShowTextME_SS("(" + indice + ") -  " + "Desconectou do servidor..." + "\r");

                }
                else
                    ShowTextME_SS("Desconectado..." + "\r");
            }
            catch (Exception error)
            {

            }
        }


        private void servidor_OnWrite(System.Net.Sockets.Socket soc)
        {
            try
            {

                if (soc != null)
                {
                    string indice = (servidor.GetSocketIndex(soc)).ToString();
                    ShowTextME_SS("Servidor enviou a: (" + indice + " : " + servidor.RemoteHost(Convert.ToInt32(indice)) + ") o comando:  " + servidor.WriteText + "\r");
                }
                else
                    ShowTextME_SS("Desconectado..." + "\r");
            }
            catch (Exception error)
            {

            }
        }

        void servidor_OnRead(System.Net.Sockets.Socket soc)
        {
            try
            {
                frmAtendimento.BeginInvoke((MethodInvoker)delegate
                {
                    if (ME_ServSocket.Lines.Count() > 100)
                    {
                        ME_ServSocket.Clear();
                    }
                });

                string txt = servidor.ReceivedText.Replace("\0", "").ToString();
                string indice = (servidor.GetSocketIndex(soc)).ToString();

                ShowTextME_SS("Servidor recebeu de: (" + indice + " : " + servidor.RemoteHost(Convert.ToInt32(indice)) + ") o comando:  " + txt + "\r");


                if (soc != null && servidor.GetSocketIndex(soc) >= 0)
                {


                    System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
                    Acao des = js.Deserialize<Acao>(txt);



                    switch (des.acao.ToString())
                    {
                        case "ServidorInserirMesa":

                            string nr = Convert.ToInt32(des.MesaID).ToString("D2");

                            if (frmAtendimento != null)
                            {

                                if (frmAtendimento.VendaMesa != null)
                                {

                                    if (frmAtendimento.VendaMesa.groupBox1 != null)
                                    {

                                        if (frmAtendimento.InvokeRequired)
                                            frmAtendimento.BeginInvoke((MethodInvoker)delegate
                                            {
                                                switch (des.tipo)
                                                {
                                                    case "ocupa":
                                                        frmAtendimento.VendaMesa.groupBox1.Controls["mesa" + nr].BackColor = Color.OrangeRed;
                                                        break;
                                                    case "fechando":
                                                        frmAtendimento.VendaMesa.groupBox1.Controls["mesa" + nr].BackColor = Color.Yellow;
                                                        break;
                                                    case "liberada":
                                                        frmAtendimento.VendaMesa.groupBox1.Controls["mesa" + nr].BackColor = Color.FromName("#cccccc");
                                                        break;
                                                }
                                            });
                                    }

                                }

                            }


                            string jsoncliente = "{'acao':'ServidorInserirMesa',";
                            jsoncliente += "'MesaID' : '" + nr + "',";
                            jsoncliente += "'tipo' : '" + des.tipo + "'";
                            jsoncliente += "}";
                            this.strigComando = jsoncliente;
                            this.Atualiza();
                            break;
                    }





                }

            }
            catch (Exception error)
            {

            }
        }


        private void AddCB(int indice, string host)
        {
            try
            {

                if (this.InvokeRequired)
                    this.BeginInvoke((MethodInvoker)delegate
                    {

                    });
            }
            catch (Exception error)
            {

            }
        }

        private void RemoveLast(int indice)
        {
            try
            {
                if (this.InvokeRequired)
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        //conectados.Clear();
                        //conectados.RemoveAt(indice);
                        //dataGridViewClientesConectados.DataSource = conectados;

                        //this.CB_IndexClients.Items.RemoveAt(CB_IndexClients.SelectedIndex);
                    });
            }
            catch (Exception error)
            {

            }

        }


        private void ShowTextME_SS(string text)
        {
            try
            {
                text = DateTime.Now.ToString("dd/MM/yyyy hh:mm") + " - " + text;

                if (this.ME_ServSocket.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(ShowTextME_SS);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.ME_ServSocket.AppendText(text);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ShowTextME_Cliente(string text)
        {
            try
            {
                text = DateTime.Now.ToString("dd/MM/yyyy hh:mm") + " - " + text;

                if (this.richTextBoxCliente.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(ShowTextME_Cliente);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.richTextBoxCliente.AppendText(text);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        #endregion




        #region eventos do cliente




        public void conectaCliente(string IpServidor, int ServerPort)
        {

            if (this.cliente == null || (this.cliente != null && this.cliente.Connected == false))
            {

                try
                {
                    this.cliente = new ClientSocket(IpServidor, ServerPort);
                    this.cliente.OnConnect += new ClientSocket.ConnectionDelegate(cliente_OnConnect);
                    this.cliente.OnDisconnect += new ClientSocket.ConnectionDelegate(cliente_OnDisconnect);
                    this.cliente.OnError += new ClientSocket.ErrorDelegate(cliente_OnError);
                    this.cliente.OnRead += new ClientSocket.ConnectionDelegate(cliente_OnRead);
                    this.cliente.OnWrite += new ClientSocket.ConnectionDelegate(cliente_OnWrite);


                    this.cliente.Connect();


                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error.Message);
                }

            }


        }



        void cliente_OnError(string ErroMessage, System.Net.Sockets.Socket soc, int ErroCode)
        {
            try
            {

                if (soc != null && servidor.GetSocketIndex(soc) >= 0)
                {
                    ShowTextME_Cliente("(" + servidor.GetSocketIndex(soc).ToString() + " - " + servidor.RemoteHost(servidor.GetSocketIndex(soc)) + ") " + " ErrorSocket: " + ErroMessage + " ::: " + ErroCode.ToString() + "\r");
                }
                else
                {
                    ShowTextME_Cliente("Error: " + ErroMessage + "\r");
                }

                timerConectaServidor.Start();
                timerConectaServidor.Enabled = true;
                timerConectaServidor_Tick(null, null);
            }
            catch (Exception error)
            {

                ShowTextME_Cliente(error.Message + "\r");
            }
        }

        void cliente_OnWrite(System.Net.Sockets.Socket soc)
        {

            ShowTextME_Cliente("Enviado a mensagem ao servidor: " + cliente.WriteText + "\r");
        }


        void cliente_OnConnect(System.Net.Sockets.Socket soc)
        {
            ShowTextME_Cliente("Conectei ao servidor...\r");
            statusCliente.Text = "Conectado ao servidor " + Properties.Clienteconfig.Default.ServidorIP;
            statusCliente.ForeColor = Color.Green;
            timerConectaServidor.Stop();
            timerConectaServidor.Enabled = false;

        }

        void cliente_OnDisconnect(System.Net.Sockets.Socket soc)
        {
            try
            {

                ShowTextME_Cliente("Este terminal foi desconectado pelo servidor!\r");
                statusCliente.Text = "Desconectado do servidor";
                statusCliente.ForeColor = Color.Red;
                timerConectaServidor.Start();
                timerConectaServidor.Enabled = true;
                timerConectaServidor_Tick(null, null);

            }
            catch (Exception error)
            {

            }



        }


        void cliente_OnRead(System.Net.Sockets.Socket soc)
        {



            try
            {

                if (richTextBoxCliente.Lines.Count() > 100)
                {
                    richTextBoxCliente.Clear();
                }


                string txt = cliente.ReceivedText.Replace("\0", "").ToString();

                ShowTextME_Cliente("Recebido do servidor:" + cliente.RemoteHost + ")  o comando:  " + txt + "\r");


                if (soc != null)
                {
                    System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
                    Acao des = js.Deserialize<Acao>(txt);



                    switch (des.acao.ToString())
                    {
                        case "ServidorInserirMesa":

                            string nr = Convert.ToInt32(des.MesaID).ToString("D2");

                            if (frmAtendimento != null)
                            {

                                if (frmAtendimento.VendaMesa != null)
                                {

                                    if (frmAtendimento.VendaMesa.groupBox1 != null)
                                    {
                                        ShowTextME_Cliente(des.tipo);


                                        if (frmAtendimento.InvokeRequired)
                                            frmAtendimento.BeginInvoke((MethodInvoker)delegate
                                            {

                                                switch (des.tipo)
                                                {
                                                    case "ocupa":
                                                        frmAtendimento.VendaMesa.groupBox1.Controls["mesa" + nr].BackColor = Color.OrangeRed;
                                                        break;
                                                    case "fechando":
                                                        frmAtendimento.VendaMesa.groupBox1.Controls["mesa" + nr].BackColor = Color.Yellow;
                                                        break;
                                                    case "liberada":
                                                        frmAtendimento.VendaMesa.groupBox1.Controls["mesa" + nr].BackColor = Color.FromName("#cccccc");
                                                        break;
                                                }

                                            });
                                    }

                                }

                            }

                            break;
                    }





                }

            }
            catch (Exception error)
            {
                ShowTextME_Cliente(error.Message);
            }
        }



        #endregion

        Thread trd;
        public void Atualiza()
        {
            trd = new Thread(new ThreadStart(this.EnviaAcaoAosTerminais));
            trd.IsBackground = true;
            trd.Start();

        }

        public string strigComando = "";
        public void EnviaAcaoAosTerminais()
        {
            try
            {

                List<Thread> listaTarefas = new List<Thread>();

                if (this.TipoTerminal == "servidor")
                {
                    conectaServidor(this.ServerPort);

                    int ativas = servidor.ActiveConnections;
                    for (int i = 0; i < ativas; i++)
                    {
                        if (servidor.Connected(i))
                        {
                            Thread.Sleep(200);

                            /* servidor.SendText(this.strigComando, i);*/

                            servidorDisapra a = new servidorDisapra();
                            a.strigComando = this.strigComando;
                            a.i = i;
                            a.server = servidor;

                            Thread tarefa = new Thread(new ThreadStart(a.envia));
                            listaTarefas.Add(tarefa);
                            foreach (Thread works in listaTarefas)
                            {

                                works.Start();

                            }


                            while (listaTarefas.Count > 0)
                            {

                                Thread.Sleep(1000);
                                // REMOVE AS TAREFAS JÁ FINALIZADAS.
                                for (int ii = listaTarefas.Count - 1; ii >= 0; ii--)
                                {

                                    if (listaTarefas[ii].ThreadState == ThreadState.Stopped)
                                    {

                                        listaTarefas.RemoveAt(ii);

                                    }

                                }

                            }
                        }

                    }
                }
                else
                {
                    conectaCliente(this.IpServidor, this.ServerPort);
                    if (this.cliente.Connected == true)
                    {
                        ShowTextME_SS("Cliente enviou comando ao servidor.\r");
                        cliente.SendText(this.strigComando);
                    }
                }


            }
            catch (Exception error)
            {

            }
        }

        class servidorDisapra { public string strigComando; public int i; public ServerSocket server; public void envia() { this.server.SendText(this.strigComando, this.i); } }

        #endregion





        private void button1_Click(object sender, EventArgs e)
        {
            RunThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientesConectados.Rows.Count > 0)
            {
                int indice = Convert.ToInt32(dataGridViewClientesConectados.Rows[dataGridViewClientesConectados.CurrentRow.Index].Cells[1].Value);
                servidor.CloseConnection(indice);
            }
        }

        private void logDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TipoTerminal == "servidor")
            {
                panel1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasReceberList frm = new frmContasReceberList();
            frm.frmMain = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteList _frmCliente = new frmClienteList();
            _frmCliente.MdiParent = this;
            _frmCliente.frmMain = this;
            _frmCliente.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedorList frm = new frmFornecedorList();
            frm.MdiParent = this;
            frm.Show();
        }


        public void TentaConectar()
        {
            ClienteConectPersist.RunWorkerAsync();
        }

        private void ClienteConectPersist_DoWork(object sender, DoWorkEventArgs e)
        {
            RunThread();
        }

        private void timerConectaServidor_Tick(object sender, EventArgs e)
        {

            if (this.TipoTerminal == "cliente")
            {
                statusCliente.Text = "Tentando conectar ao servidor " + Properties.Clienteconfig.Default.ServidorIP + " ...";
                statusCliente.ForeColor = Color.Black;
                TentaConectar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (servidor != null)
            {

                int ativas = servidor.ActiveConnections;


                if (ativas <= 0)
                {
                    MessageBox.Show("Nenhum cliente conectado no momento.");
                    return;
                }

                for (int i = 0; i < ativas; i++)
                {
                    if (servidor.Connected(i))
                    {
                        //Thread.Sleep(300);
                        servidor.CloseConnection(i);
                    }
                }





            }
            else
            {
                ShowTextME_SS("Servidor está desconectado...\r");
            }
        }

        private void estoqueDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControleEstoque frm = new frmControleEstoque();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbControle_Click(null, null);

            frmPendentesMesa form = new frmPendentesMesa();
            form.pai = this.frmAtendimento;
            form.ShowDialog();
        }

        private void balcãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbControle_Click(null, null);

            frmPendentesBalcao form = new frmPendentesBalcao();
            form.pai = this.frmAtendimento;
            form.ShowDialog();

        }

        private void tsbEstoque_Click(object sender, EventArgs e)
        {
            frmControleEstoque frm = new frmControleEstoque();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbControle_Click(null, null);

            frmPendentesPedido form = new frmPendentesPedido();
            form.pai = this.frmAtendimento;
            form.ShowDialog();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre frm = new Sobre();
            frm.ShowDialog();
        }

        private void tsbLogoff_Click(object sender, EventArgs e)
        {
            estaLogado = false;
            frmMain_Load(null, null);
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comissãoDoGarçonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamentoComissaoGarcon frm = new frmPagamentoComissaoGarcon();
            frm.MdiParent = this;
            frm.frmMain = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmImprimePedido frm = new frmImprimePedido();
            frm.Show();
        }

        private void checarPorAtualizaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChecarAtualizacao frm = new ChecarAtualizacao();
            frm.ShowDialog();
        }

        private void relatórioDeVendasPorPeríodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioVendas frm = new RelatorioVendas();
            frm.ShowDialog();
        }

        private void clientesQueMaisCompraramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioClientesMaisCompram frm = new RelatorioClientesMaisCompram();
            frm.ShowDialog();
            //RelatorioVendas frm = new RelatorioVendas();
            //frm.ShowDialog();
        }

        private void comandasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbControle_Click(null, null);

            frmPendentesComanda form = new frmPendentesComanda();
            form.pai = this.frmAtendimento;
            form.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




    }


}