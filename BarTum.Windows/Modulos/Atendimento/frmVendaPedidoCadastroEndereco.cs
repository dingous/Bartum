using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmVendaPedidoCadastroEndereco : Form
    {
        public frmAtendimento frmAtendimento;
        public frmVendaPedidoEnderecos frmVendaPedidoEnderecos;
        public decimal idEndereco = 0;


        BarTumEntities _context = new BarTumEntities();

        public frmVendaPedidoCadastroEndereco()
        {
            InitializeComponent();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            decimal ClienteID = Convert.ToDecimal(frmAtendimento.VendaPedido.ClienteID.Text);
            decimal LanctoID = Convert.ToDecimal(frmAtendimento.LanctoID.Text);
            decimal EnderecoID;

            string _dsLogradouro = dsLogradouro.Text;
            string _nrNumero = nrNumero.Text;
            decimal _BairroID = Convert.ToDecimal(BairroID.SelectedValue);


            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string erro = "";

            if (_dsLogradouro == "")
            {
                erro = "Informe o nome da rua.";
                MessageBox.Show(erro, "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return;
            }
            else if (_nrNumero == "")
            {
                erro = "Informe o número da residência.";
                MessageBox.Show(erro, "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return;
            }
            else if (_BairroID == 0)
            {
                erro = "Selecione um bairro";
                MessageBox.Show(erro, "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return;
            }


            string _dsComplemento = dsComplemento.Text;
            string _dsRegiao = dsRegiao.Text;
            string _nrCEP = nrCEP.Text;
            decimal _EstadoID = Convert.ToDecimal(EstadoID.SelectedValue);
            decimal _CidadeID = Convert.ToDecimal(CidadeID.SelectedValue);
            string _dsReferencias = dsReferencias.Text;


            EB_Endereco endereco = null;

            if (idEndereco == 0)
            {
                endereco = new EB_Endereco();
            }
            else
            {
                endereco = this.frmVendaPedidoEnderecos.context.EB_Endereco.Single(a => a.EnderecoID == idEndereco);
            }

            endereco.dsLogradouro = _dsLogradouro;
            endereco.nrNumero = _nrNumero;
            endereco.dsComplemento = _dsComplemento;
            endereco.BairroID = _BairroID;
            endereco.ClienteID = ClienteID;
            endereco.dsRegiao = _dsRegiao;
            endereco.nrCEP = _nrCEP;
            endereco.CidadeID = _CidadeID;
            endereco.dsReferencias = _dsReferencias;

            //se for inserção
            if (idEndereco == 0)
            {

                this.frmVendaPedidoEnderecos.context.AddToEB_Endereco(endereco);

                EnderecoID = endereco.EnderecoID;

                EB_LanctoPedidos pedido = new EB_LanctoPedidos();
                pedido.ClienteID = ClienteID;
                pedido.EnderecoID = EnderecoID;
                pedido.LanctoID = LanctoID;
                this.frmVendaPedidoEnderecos.context.AddToEB_LanctoPedidos(pedido);

            }


            if (checkBoxPrincipal.Checked == true)
            {
                var enderecos = this.frmVendaPedidoEnderecos.context.EB_Endereco.Where(a => a.ClienteID == ClienteID).ToList();
                foreach (var item in enderecos)
                {
                    item.flEnderecoPrincipal = false;
                }

                endereco.flEnderecoPrincipal = true;

                //endereco.EB_Cliente.EnderecoID = endereco.EnderecoID;
            }

                
            this.frmVendaPedidoEnderecos.context.SaveChanges();


            this.frmVendaPedidoEnderecos.populaGridView();

            this.Close();

        }


        public void populaBairros()
        {
            var result = (from item in _context.EB_Bairro orderby item.dsNome descending select new { item.BairroID, item.dsNome }).ToList();
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

        public void populaCamposEdit(ref EB_Endereco endereco)
        {
            dsLogradouro.Text = endereco.dsLogradouro;
            nrNumero.Text = endereco.nrNumero.ToString();
            dsComplemento.Text = endereco.dsComplemento;
            BairroID.SelectedValue = endereco.BairroID;
            dsRegiao.Text = endereco.dsRegiao;
            nrCEP.Text = endereco.nrCEP;
            EstadoID.SelectedValue = endereco.EB_Cidade.EstadoID;
            CidadeID.SelectedValue = endereco.CidadeID;
            dsReferencias.Text = endereco.dsReferencias;

            if (endereco.flEnderecoPrincipal == true)
            {
                checkBoxPrincipal.Checked = true;
                checkBoxPrincipal.Enabled = false;
                checkBoxPrincipal.Text = "Este endereço é o principal do cliente";
            }

        }

        private void frmVendaPedidoCadastroEndereco_Load(object sender, EventArgs e)
        {
            populaCidades(); populaEstados(); populaBairros();


            if (this.idEndereco != 0)
            {
                var endereco = _context.EB_Endereco.Single(cl => cl.EnderecoID == this.idEndereco);
                populaCamposEdit(ref endereco);
                botaoSalvar.Text = "Salvar alterações";
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
