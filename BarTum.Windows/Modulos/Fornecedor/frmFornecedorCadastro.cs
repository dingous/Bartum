using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using System.Data.Objects;

namespace BarTum.Windows.Modulos.Fornecedor
{
    public partial class frmFornecedorCadastro : Form
    {
        public frmFornecedorList frmFornecedorList;
        public decimal id = 0;
        //EasyBarEntities _context = new EasyBarEntities();

        public frmFornecedorCadastro()
        {
            InitializeComponent();
        }



        public void fill(ref EB_Fornecedor FornecedorEnt)
        {
            
            FornecedorEnt.dsNomeFantasia = dsNomeFantasiaTextBox.Text;
            FornecedorEnt.dsRazaoSocial = dsRazaoSocialTextBox.Text;
            FornecedorEnt.nrCNPJ = Convert.ToDecimal(nrCNPJTextBox.Text == "" ? null : nrCNPJTextBox.Text);
            FornecedorEnt.nrInsEstadual = Convert.ToDecimal(nrInsEstadualTextBox.Text == "" ? null : nrInsEstadualTextBox.Text);
            FornecedorEnt.dsLogradouro = dsLogradouroTextBox.Text;
            FornecedorEnt.nrCEP = nrCEPTextBox.Text;
            FornecedorEnt.dsCidade = dsCidadeTextBox.Text;
            FornecedorEnt.dsUfEstado = dsUfEstadoTextBox.Text;
            FornecedorEnt.nrTelefone = nrTelefoneTextBox.Text;
            FornecedorEnt.nrFax = nrFaxTextBox.Text;
            FornecedorEnt.nrNomeContato = nrNomeContatoTextBox.Text;
            FornecedorEnt.dsSite = txtdsSite.Text;
            FornecedorEnt.dsObservacao = txtdsObservacao.Text;
            FornecedorEnt.nrCEP = nrCEPTextBox.Text;
           

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {


            try
            {

                EB_Fornecedor FornecedorEnt = new EB_Fornecedor();



                if (fornecedorIDTextBox.Text == "")
                {



                    fill(ref FornecedorEnt);


                    FornecedorEnt.dtCadastro = DateTime.Now;



                    if (FornecedorEnt.Valida(FornecedorEnt))
                    {
                        this.frmFornecedorList._context.AddToEB_Fornecedor(FornecedorEnt);
                     

                      

                        this.frmFornecedorList._context.SaveChanges();







                        var l = this.frmFornecedorList._context;

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Fornecedor inserido com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);

                        this.frmFornecedorList.populaGridview("");                     
                        this.Close();




                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(fornecedorIDTextBox.Text);

                    FornecedorEnt = this.frmFornecedorList._context.EB_Fornecedor.Single(cl => cl.FornecedorID == id);


                    fill(ref FornecedorEnt);

                    if (FornecedorEnt.Valida(FornecedorEnt))
                    {



                        this.frmFornecedorList._context.SaveChanges();


                        this.frmFornecedorList._context.Refresh(System.Data.Objects.RefreshMode.ClientWins, this.frmFornecedorList._context.EB_Fornecedor);
                       

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Fornecedor atualizado com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);


                        this.frmFornecedorList.populaGridview("");

                        this.Close();


                    }
                }


            }
            catch (Exception error)
            {

            }
        }

        public void preencheCamposEdit()
        {
            var query = (from cliente in this.frmFornecedorList._context.EB_Fornecedor select cliente).Single(a => a.FornecedorID == this.id);


           fornecedorIDTextBox.Text = query.FornecedorID.ToString();
           dsNomeFantasiaTextBox.Text = query.dsNomeFantasia;
           dsRazaoSocialTextBox.Text = query.dsRazaoSocial;  
           nrCNPJTextBox.Text = query.nrCNPJ.ToString();  
           nrInsEstadualTextBox.Text = query.nrInsEstadual.ToString();  
           dsLogradouroTextBox.Text = query.dsLogradouro;  
           nrCEPTextBox.Text = query.nrCEP;  
           dsCidadeTextBox.Text = query.dsCidade;  
           dsUfEstadoTextBox.Text = query.dsUfEstado;  
           nrTelefoneTextBox.Text = query.nrTelefone; 
           nrFaxTextBox.Text  = query.nrFax; 
           nrNomeContatoTextBox.Text = query.nrNomeContato;  
           txtdsSite.Text = query.dsSite;  
           txtdsObservacao.Text = query.dsObservacao;
           nrCEPTextBox.Text = query.nrCEP;



           dtCadastroTextBox.Text = Convert.ToDateTime(query.dtCadastro).ToString("dd/MM/yyyy");
        }

        private void frmFornecedorCadastro_Load(object sender, EventArgs e)
        {
            if(this.id != 0)
            {
                var query = (from cliente in this.frmFornecedorList._context.EB_Fornecedor select cliente).Single(a => a.FornecedorID == this.id);
                eB_FornecedorBindingSource.DataSource = query;
                botaoSalvar.Text = "Salvar alterações";
                preencheCamposEdit();

                dtCadastroTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
                
            }
        }
    }
}
