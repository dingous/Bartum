using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using System.Threading;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmTransferenciaMesa : Form
    {

       


        public frmAtendimento frmAtendimento;

        public frmTransferenciaMesa()
        {
            InitializeComponent();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();

          


            decimal mesade = Convert.ToDecimal(de.Text);
            decimal mesapara = Convert.ToDecimal(para.Value);
            decimal idLancto = Convert.ToDecimal(frmAtendimento.LanctoID.Text);
            var query = _context.EB_Lancamento.Single(a => a.LanctoID == idLancto);

            if (query.StatusID == 2)
            {
                MessageBox.Show("Não é possível transeferir a mesa " + mesade.ToString() + ", ela está sendo fechada.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return;
            }else if(query.StatusID == 3)
            {
                MessageBox.Show("Não é possível transeferir a mesa " + mesade.ToString() + ", ela já foi fechada.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return;
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;

            if (!(query.MesaDiponivel(mesapara)))
            {
                try
                {
                    if (mesapara > this.frmAtendimento.VendaMesa.totalMesas || mesapara == 0)
                    {
                        MessageBox.Show("A Mesa " + mesapara .ToString()+ " não existe!", "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                        para.Focus();
                        return;
                    }

                    DialogResult confirma = MessageBox.Show("Confirmar transferência de mesas?", "BarTum", buttons2, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                    if (confirma == DialogResult.No)
                    {
                        para.Focus();
                        return;
                    }

                 

                    query.MesaID = mesapara;
                    _context.SaveChanges();


                    this.frmAtendimento.VendaMesa.groupBox1.Controls["mesa" + Convert.ToInt32(mesade).ToString("d2")].BackColor = Color.Aquamarine;
                    //notifica ao servidor
                    frmMain frmMain = (frmMain)this.frmAtendimento.MdiParent;
                    string jsoncliente = "{'acao':'ServidorInserirMesa',";
                    jsoncliente += "'MesaID' : '" + Convert.ToInt32(mesade).ToString("d2") + "',";
                    jsoncliente += "'tipo' : 'liberada'";
                    jsoncliente += "}";
                    frmMain.strigComando = jsoncliente;
                    frmMain.Atualiza();


                    Thread.Sleep(2000);


                    this.frmAtendimento.VendaMesa.groupBox1.Controls["mesa" + Convert.ToInt32(mesapara).ToString("d2")].BackColor = Color.OrangeRed;
                    //notifica ao servidor
                    jsoncliente = "";            
                    jsoncliente += "{'acao':'ServidorInserirMesa',";
                    jsoncliente += "'MesaID' : '" + Convert.ToInt32(mesapara).ToString("d2") + "',";
                    jsoncliente += "'tipo' : 'ocupa'";
                    jsoncliente += "}";
                    frmMain.strigComando = jsoncliente;
                    frmMain.Atualiza();


                    frmAtendimento.carregaInformacoes(mesapara);

                    MessageBox.Show("Mesa transferida com sucesso!", "BarTum", buttons, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);


                    this.Close();


                }catch(Exception error)
                {
                   
                    MessageBox.Show(error.Message + "\n\n" + error.InnerException.Message, "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                }
            }
        }

        private void frmTransferenciaMesa_Load(object sender, EventArgs e)
        {

            if (frmAtendimento.LanctoID.Text == "")
            {
                MessageBox.Show("Não existe ocupantes nesta mesa.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
                
            }

            de.Text = this.frmAtendimento.VendaMesa.textBoxMesa.Text;
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransferenciaMesa_KeyDown(object sender, KeyEventArgs e)
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
