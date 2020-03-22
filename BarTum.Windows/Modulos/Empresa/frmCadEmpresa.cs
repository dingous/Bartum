using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Empresa
{
    public partial class frmCadEmpresa : Form
    {

        BarTumEntities _context = new BarTumEntities();

        public frmCadEmpresa()
        {
            InitializeComponent();
        }


        public void fill(ref EB_Empresa ent)
        {
            ent.dsNomeFantasia = dsNomeFantasiaTextBox.Text;
            ent.dsRazaoSocial = dsRazaoSocialTextBox.Text;
            ent.inscEstadual = inscEstadualTextBox.Text;
            ent.nrCnpj = nrCnpjTextBox.Text;
            ent.dsEndereco = dsEnderecoTextBox.Text;
            ent.dsBairro = dsBairroTextBox.Text;
            ent.DsCidade = dsCidadeTextBox.Text;
            ent.siglaUF = textBoxUF.Text;
            ent.tel1 = tel1TextBox.Text != "(34)     -" ? tel1TextBox.Text : "";
            ent.tel2 = tel2TextBox.Text != "(34)     -" ? tel2TextBox.Text : "";
            ent.cel = celTextBox.Text != "(34)     -" ? celTextBox.Text : "";
            ent.dsEmail = dsEmailTextBox.Text;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                EB_Empresa ent = _context.EB_Empresa.Single();

                fill(ref ent);

                _context.SaveChanges();


                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, "Dados da empresa atualizado com sucesso!", "BarTum", buttons,
                MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);

            }catch(Exception error)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(this, "Houve um erro na tentativa de atualização dos dados da empresa : " + error.Message, "BarTum", buttons,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void populaFormualariosEdit()
        {
            var ent = _context.EB_Empresa.Single();

            dsNomeFantasiaTextBox.Text = ent.dsNomeFantasia;
            dsRazaoSocialTextBox.Text = ent.dsRazaoSocial;
            inscEstadualTextBox.Text = ent.inscEstadual;
            nrCnpjTextBox.Text = ent.nrCnpj;
            dsEnderecoTextBox.Text = ent.dsEndereco;
            dsBairroTextBox.Text = ent.dsBairro;
            dsCidadeTextBox.Text = ent.DsCidade;
            textBoxUF.Text = ent.siglaUF;
            tel1TextBox.Text = ent.tel1;
            tel2TextBox.Text = ent.tel2;
            celTextBox.Text = ent.cel;
            dsEmailTextBox.Text = ent.dsEmail;
        }

        private void frmCadEmpresa_Load(object sender, EventArgs e)
        {
            populaFormualariosEdit();
        }

        private void frmCadEmpresa_KeyDown(object sender, KeyEventArgs e)
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
