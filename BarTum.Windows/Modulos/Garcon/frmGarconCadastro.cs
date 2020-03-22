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

namespace BarTum.Windows.Modulos.Garcon
{
    public partial class frmGarconCadastro : Form
    {
        BarTumEntities _context = new BarTumEntities();
        public decimal id;
        public bool consulta = false;

        public frmGarconCadastro()
        {
            InitializeComponent();

                     
        }


        public void fill(ref EB_Garcon GarconEnt)
        {
            GarconEnt.dsNome = dsNome.Text;
            GarconEnt.dsEndereco = dsEndereco.Text;
            GarconEnt.nrTelefone = nrTelefone.Text != "(34)     -" ? nrTelefone.Text : "";
            GarconEnt.nrCelular = nrCelular.Text != "(34)     -" ? nrCelular.Text : "";
            GarconEnt.nrComissao = Convert.ToDouble(nrComissao.Text);

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                EB_Garcon GarconEnt = new EB_Garcon();



                if (GarconID.Text == "")
                {


                    fill(ref GarconEnt);

                    GarconEnt.dtCadastro = dtCadastro.Value;

                    if (GarconEnt.Valida(GarconEnt))
                    {
                        _context.AddToEB_Garcon(GarconEnt);
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Garçon inserido com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.Close();

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(GarconID.Text);

                    GarconEnt = _context.EB_Garcon.Single(cl => cl.GarconID == id);

                    fill(ref GarconEnt);

                    if (GarconEnt.Valida(GarconEnt))
                    {
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Garçon atualizado com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);

                        this.Close();


                    }
                }


            }
            catch (Exception error)
            {
                MessageBox.Show("Erro na tentativa de cadastro, erro: " + error.Message + "\n" + error.InnerException.Message, "EasyBar",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void preencheFormularioEdit()
        {


            var item = (from a in _context.EB_Garcon select a).Single(a => a.GarconID == this.id);
            GarconID.Text = item.GarconID.ToString();
            dsNome.Text = item.dsNome;
            dsEndereco.Text = item.dsEndereco;
            nrTelefone.Text = item.nrTelefone;
            nrCelular.Text = item.nrCelular;
            nrComissao.Text = item.nrComissao.ToString();
            //dtCadastro.Text  = item.dtCadastro.ToString();



        }

        private void frmGarconCadastro_Load(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                preencheFormularioEdit();
                botaoSalvar.Text = "Salvar alterações";
            }

            if (this.consulta == true)
            {
                botaoSalvar.Visible = false;
            }
        }

        private void frmGarconCadastro_KeyDown(object sender, KeyEventArgs e)
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
