using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Windows.Modulos.Configuracoes;

namespace BarTum.Windows.Modulos.Login
{
    public partial class frmLogin : Form
    {
        public frmMain frmMain;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {

                case Keys.Escape:
                    break;

                case Keys.Enter:
                    button1_Click(null, null);
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtBoxUsuario.Text == "")
                {
                    MessageBox.Show("Informe o seu usuário", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBoxUsuario.Focus();
                    return;
                }
                else if (txtBoxSenha.Text == "")
                {
                    MessageBox.Show("Informe a sua senha", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBoxSenha.Focus();
                    return;
                }

                BarTumEntities contexto = new BarTumEntities();


                var query = contexto.EB_Usuario.Where(a => a.dsLogin == txtBoxUsuario.Text && a.dsSenha == txtBoxSenha.Text).ToList();
                if (query.Count == 0)
                {
                    MessageBox.Show("Usuário não cadastrado.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    EB_Usuario usuario = query[0];
                    frmMain.UsuarioLogado = usuario.UsuarioID;
                    frmMain.UsuarioLogadoNome = usuario.dsNome;
                    frmMain.estaLogado = true;

                    this.frmMain.Visible = true;
                    this.Close();

                    frmMain.toolStripStatusLabel3.Text = "Usuário logado: " + usuario.dsLogin;
                }

            }catch(Exception error)
            {
                MessageBox.Show(error.Message + " " + error.InnerException.Message , "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

                frmConfiguracoesIniciais frm = new frmConfiguracoesIniciais();
                frm.frmMain = frmMain;
                //frm.Visible = true;
                //frmMain.Enabled = false;
                //frm.ShowDialog();
                frm.TopMost = true;
                frm.Show();
                return;
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if( frmMain.estaLogado == false)
            {
                frmMain.confirmaSaida = false;
                Application.Exit();
            }
            

        }
    }
}
