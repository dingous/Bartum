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

namespace BarTum.Windows.Modulos.Entregador
{
    public partial class frmEntregadorCadastro : Form
    {
        BarTumEntities _context = new BarTumEntities();

       

        private decimal? id_;
        public decimal? id { get { return id_; } set { id_ = value; } }

        frmEntregadorList frmEntregadorList;
        private object pai_;
        public object pai { get { return pai_; } set { pai_ = value; } }

        private bool consulta_ = false;
        public bool consulta { get { return consulta_; } set { consulta_ = value; } }

        public frmEntregadorCadastro()
        {
           InitializeComponent();
           

        }

        public void fill(ref EB_Entregador EntregadorEnt)
        {
            EntregadorEnt.dsNome = dsNome.Text;
            EntregadorEnt.dsEndereco = dsEndereco.Text;
            EntregadorEnt.nrTelefoneFixo = nrTelefone.Text;
            EntregadorEnt.nrTelefoneCelular = nrCelular.Text;
 
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                EB_Entregador EntregadorEnt = new EB_Entregador();



                if (EntregadorID.Text == "")
                {


                    fill(ref EntregadorEnt);


                    if (EntregadorEnt.Valida(EntregadorEnt))
                    {
                        EntregadorEnt.dtCadastro = DateTime.Now;
                        _context.AddToEB_Entregador(EntregadorEnt);
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Entregador inserido com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmEntregadorList.populaGridview();
                        this.Close();

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(EntregadorID.Text);

                    EntregadorEnt = _context.EB_Entregador.Single(cl => cl.EntregadorID == id);

                    fill(ref EntregadorEnt);

                    if (EntregadorEnt.Valida(EntregadorEnt))
                    {
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Entregador atualizado com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmEntregadorList.populaGridview();
                        this.Close();


                    }
                }


            }
            catch (Exception error)
            {

            }
        }

        public void preencheFormularioEdit()
        {
            var item = (from a in _context.EB_Entregador select a).Single(a => a.EntregadorID == this.id);
            EntregadorID.Text = item.EntregadorID.ToString();
            dsNome.Text = item.dsNome;
            dsEndereco.Text = item.dsEndereco;
            nrTelefone.Text = item.nrTelefoneFixo;
            nrCelular.Text = item.nrTelefoneCelular;
            dtCadastro.Text  = item.dtCadastro.ToString();
        }
        
        
        private void frmEntregadorCadastro_Load(object sender, EventArgs e)
        {

            if(this.id != null)
            {
                preencheFormularioEdit();
                botaoSalvar.Text = "Salvar alterações";
            }


            if (this.consulta == true)
            {
                botaoSalvar.Visible = false;
            }

            if (this.pai != null)
            {
                var tipo = this.pai.GetType();

                switch (tipo.Name)
                {
                    case "frmEntregadorList":
                        
                        this.frmEntregadorList = (frmEntregadorList)this.pai;
                            
                        break;
                }
                 
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
