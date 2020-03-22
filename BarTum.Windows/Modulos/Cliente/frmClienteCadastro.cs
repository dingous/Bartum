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
using  BarTum.Windows.Modulos.Atendimento;
using BarTum.Windows.Modulos.Bairro;


namespace BarTum.Windows.Modulos.Cliente
{
    public partial class frmClienteCadastro : Form
    {


        BarTumEntities _context = new BarTumEntities();
        
        public int idCliente;
        public frmClienteList frmClienteList;
        public frmAtendimento _frmAtendimento;
        public frmAtendimento frmAtendimento { get { return _frmAtendimento; } set{ _frmAtendimento = value; } }
        public bool consulta = false;
        

        public frmClienteCadastro()
        {
            InitializeComponent();

        }



        #region Eventos do usuário

        private void botaoCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        public void fill(ref EB_Cliente ClienteEnt, ref EB_Endereco EnderecoEnt, ref EB_Contato ContatoEnt)
        {
            
            
            frmMain frmMain = this.frmClienteList.frmMain;
          

            EnderecoEnt.dsLogradouro = dsLogradouro.Text;
            EnderecoEnt.nrNumero = nrNumero.Text;
            EnderecoEnt.dsComplemento = dsComplemento.Text;
            EnderecoEnt.nrCEP = nrCEP.Text;
            EnderecoEnt.dsRegiao = dsRegiao.Text;
            EnderecoEnt.dsReferencias = dsReferencias.Text;
            EnderecoEnt.flEnderecoPrincipal = true;
            if (!(CidadeID.SelectedValue == null)) { EnderecoEnt.CidadeID = Convert.ToDecimal(CidadeID.SelectedValue); }
            if (!(BairroID.SelectedValue == null)) { EnderecoEnt.BairroID = Convert.ToDecimal(BairroID.SelectedValue); }



            ContatoEnt.nrTelefone1 = nrTelefone1.Text != "(34)     -" ?  nrTelefone1.Text : "";
            ContatoEnt.nrTelefone2 = nrTelefone2.Text != "(34)     -" ? nrTelefone2.Text : "";
            ContatoEnt.nrTelefone3 = nrTelefone3.Text != "(34)     -" ? nrTelefone3.Text : "";
            ContatoEnt.nrTelefone4 = nrTelefone4.Text != "(34)     -" ? nrTelefone4.Text : "";
            ContatoEnt.nrCelular =  nrTelefoneCel.Text != "(34)     -" ? nrTelefoneCel.Text : "";
            ContatoEnt.dsNomeContato = dsNomeContato.Text;


            ClienteEnt.dsEmail = dsEmail.Text;
            ClienteEnt.UsuarioID = 2;
            ClienteEnt.dsNome = dsNome.Text;
            ClienteEnt.dtNascimento = Convert.ToDateTime(dtNascimento.Text);
            ClienteEnt.nrCpfCpnj = nrCpfCnpj.Text;
            ClienteEnt.flExcluido = false;
            ClienteEnt.UsuarioID = frmMain.UsuarioLogado;
            if (nrStatus.Checked == true)
            {
                ClienteEnt.nrStatus = 1;
            }
            else
            {
                ClienteEnt.nrStatus = 0;
            }
            

        }


        public void tab(Object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.KeyPreview = true;
            }else if(tabControl1.SelectedIndex == 1)
            {
                this.KeyPreview = false;
            }
         
            if (ClienteID.Text == "")
            {
          
                groupBox7.Enabled = false;
            }
            else
            {
                groupBox7.Enabled = true;
                populaOcorrencias();
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {

            if (this.frmClienteList.context.EB_Cliente.Count() >= 3)
            {
                MessageBox.Show("Este software é uma licença para testar, para adquirir o seu completo entre em contato pelo seguinte endereço de e-mail: codigosetutoriais@gmail.com");
                return;
            }

            if(this.consulta == true)
            {
                return;
            }

            try
            {

                EB_Cliente ClienteEnt = new EB_Cliente();
                EB_Endereco EnderecoEnt = new EB_Endereco();
                EB_Contato ContatoEnt = new EB_Contato();

                

                if (ClienteID.Text == "")
                {

                  
                    fill(ref ClienteEnt, ref EnderecoEnt, ref ContatoEnt);


                    if (ClienteEnt.dsNome == "")
                    {
                        MessageBox.Show("Informe o nome do cliente.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dsNome.Focus();
                        return;
                    }

                    ClienteEnt.dtCadastro = DateTime.Now;
                    

                    ClienteEnt.EB_Endereco1.Add(EnderecoEnt);
                    this.frmClienteList.context.AddToEB_Contato(ContatoEnt);
                    this.frmClienteList.context.AddToEB_Cliente(ClienteEnt);
                  


                    this.frmClienteList.context.SaveChanges();




                    ClienteEnt.EnderecoID = EnderecoEnt.EnderecoID;
                    ClienteEnt.ContatoID = ContatoEnt.ContatoID;

                    
                    
                    


                    if (ClienteEnt.Valida(ClienteEnt))
                    {
                       
                        this.frmClienteList.context.SaveChanges();


                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Cliente inserido com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);

                        if(this.frmClienteList != null)
                        {
                            
                            //this.frmClienteList.populaGridview("");
                        }

                        if (this._frmAtendimento != null)
                        {
                            this._frmAtendimento.VendaPedido.populaCamposCliente(ClienteEnt.ClienteID);
                        }

                        this.Close();

                        
                        

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(ClienteID.Text);

                    ClienteEnt = this.frmClienteList.context.EB_Cliente.Single(cl => cl.ClienteID == id);
                    EnderecoEnt = this.frmClienteList.context.EB_Endereco.Single(ed => ed.EnderecoID == ClienteEnt.EnderecoID);
                    ContatoEnt = this.frmClienteList.context.EB_Contato.Single(ct => ct.ContatoID == ClienteEnt.ContatoID);

                    fill(ref ClienteEnt, ref EnderecoEnt, ref ContatoEnt);

                    if (ClienteEnt.Valida(ClienteEnt))
                    {

                        this.frmClienteList.context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Cliente atualizado com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);


                        //this.frmClienteList.populaGridview("");

                        this.Close();


                    }
                }


            }catch(Exception error)
            {
                MessageBox.Show("erro retornado" + error.Message + "\n" + error.InnerException.Message);
            }
           
           
        }


        #endregion

        #region Preenchimentos



        #endregion

        #region Funcoes de Eventos

        public void preencheFormularioEdit()
        {


            var item = (from cliente in this.frmClienteList.context.EB_Cliente  select cliente).Single(a => a.ClienteID == this.idCliente);      


            dsNome.Text = item.dsNome;
            dsEmail.Text = item.dsEmail;
            dtNascimento.Text = item.dtNascimento.ToString();
            ClienteID.Text = item.ClienteID.ToString();
            nrCpfCnpj.Text = item.nrCpfCpnj;
            dsLogradouro.Text = item.EB_Endereco.dsLogradouro;
            dsComplemento.Text = item.EB_Endereco.dsComplemento;
            dsRegiao.Text = item.EB_Endereco.dsRegiao;
            nrCEP.Text = item.EB_Endereco.nrCEP;
            nrNumero.Text = nrNumero.Text == "" ? "0" : item.EB_Endereco.nrNumero.ToString();
            dsReferencias.Text = item.EB_Endereco.dsReferencias;
            if (item.EB_Endereco.BairroID != null) { BairroID.SelectedValue = item.EB_Endereco.BairroID; }
            if (item.EB_Endereco.CidadeID != null) { CidadeID.SelectedValue = item.EB_Endereco.CidadeID; }
            nrTelefone1.Text = item.EB_Contato.nrTelefone1;
            nrTelefone2.Text = item.EB_Contato.nrTelefone2;
            nrTelefone3.Text = item.EB_Contato.nrTelefone3;
            nrTelefone4.Text = item.EB_Contato.nrTelefone4;
            nrTelefoneCel.Text = item.EB_Contato.nrCelular;
            dsNomeContato.Text = item.EB_Contato.dsNomeContato;
            if (item.nrStatus == 1)
            {
                nrStatus.Checked = true;
            }
            else
            { 
                nrStatus2.Checked = true; 
            }

            if (item.convenio == true)
            {
                convenio.Checked = true;
            }

            dtCadastro.Text = item.dtCadastro.ToString("dd/MM/yyyy");

            
        }
        
        
        public void populaBairros()
        {
            BarTumEntities context = new BarTumEntities();
            var result = (from item in context.EB_Bairro orderby item.dsNome ascending select new { item.BairroID, item.dsNome }).ToList();
            BairroID.DataSource = result;
        }


        public void populaEstados()
        {
           
            var result = (from item in _context.EB_Estado orderby item.dsNome descending select new { item.EstadoID, item.dsSigla }).ToList();
            EstadoID.DataSource = result;
        }

        public void populaCidades()
        {
           
            var result = (from item in _context.EB_Cidade orderby item.dsNome descending select new { item.CidadeID, item.dsNome }).ToList();
            CidadeID.DataSource = result;
        }

        #endregion



        public void populaOcorrencias()
        {
            var item = (from ocorr in this.frmClienteList.context.EB_ClienteOcorrencias select ocorr).AsEnumerable()
                .Where(a => a.ClienteID == this.idCliente)
                .OrderByDescending(ocorr => ocorr.dtOcorrencia)
                .Select(a => new { dtOcorrencia = a.dtOcorrencia.ToString("dd/M/yyyy"), a.dsOcorrencia, a.OcorrenciaID })
                .ToList();
            dataGridViewOcorrencias.DataSource = item;
        }

        private void botaoIncluiOcorrencias_Click(object sender, EventArgs e)
        {
            if (dsOcorrencia.Text == "")
            {
                MessageBox.Show("Digite a descrição da ocorrência.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ocorr = new EB_ClienteOcorrencias();
            ocorr.dsOcorrencia = dsOcorrencia.Text;
            ocorr.dtOcorrencia = Convert.ToDateTime(dtOcorrencia.Value);
            ocorr.ClienteID = this.idCliente;
            _context.AddToEB_ClienteOcorrencias(ocorr);
            _context.SaveChanges();
            populaOcorrencias();

        }

        private void frmClienteCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmClienteList ClienteList = new frmClienteList();
            ClienteList.Dispose();
            //ClienteList.populaGridview("");
        }


        public void ExcluiOcorrencias()
        {
            try
            {

                decimal id = Convert.ToInt32(dataGridViewOcorrencias.Rows[dataGridViewOcorrencias.CurrentRow.Index].Cells[2].Value);
                var item = _context.EB_ClienteOcorrencias.Single(a => a.OcorrenciaID == id);
                _context.DeleteObject(item);

                _context.SaveChanges();

                populaOcorrencias();
            }catch(Exception error)
            {

            }
        }


        void ativaKeyPreview() { this.KeyPreview = true;  }
        void desativaKeyPreview() { this.KeyPreview = false; }

        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {
            try
            {

              
              
                dtCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
                nrNumero.Text = "0";
                populaBairros(); populaEstados(); populaCidades();


                if (consulta == true)
                {
                    botaoSalvar.Visible = false;
                }


                if (this.idCliente != 0)
                {
                    preencheFormularioEdit();
                    botaoSalvar.Text = "Salvar alterações";
                }

                tabControl1.MouseClick += new MouseEventHandler(tab);

               


                if (this._frmAtendimento != null)
                {
                    nrTelefone1.Text = this._frmAtendimento.VendaPedido.nrTelefone1.Text;
                }


                dsNome.Focus();



                if (ClienteID.Text != "")
                {
                    var ultimaCompra = _context.EB_Lancamento.Where(a => a.ClienteID == idCliente && a.flVendaCancelada == false && a.StatusID == 3).OrderByDescending(a => a.dtLancto).ToList();
                    if (ultimaCompra.Count > 0)
                    {
                        txtBoxUltimaCompra.Text = Convert.ToDateTime(ultimaCompra[0].dtLancto).ToString("dd/MM/yyyy HH:mm");
                        textBoxVlUltimaCompra.Text = Convert.ToDecimal(ultimaCompra[0].FechaTotalVendaFinalizada).ToString("C");
                        vlQuantidade.Text = Convert.ToDecimal(ultimaCompra.Sum(a=>a.FechaTotalVendaFinalizada)).ToString("C");
                        
                    }
                }
                   


            }catch(Exception error)
            {
                MessageBox.Show("erro retornado" + error.Message + "\n" + error.InnerException.Message);
            }

                        
        }

        private void frmClienteCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    botaoCancelar_Click_1(sender, e);
                    break;
                case Keys.Enter:
                    botaoSalvar_Click(sender , e);
                    break;
            }
        }

        private void dataGridViewOcorrencias_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    ExcluiOcorrencias();
                    break;
            }
        }

        private void dsOcorrencia_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    botaoIncluiOcorrencias_Click(null, null);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBairroList frm = new frmBairroList();
            frm.frmClienteCadastro = this;
            frm.ShowDialog();
        }
    }

}
