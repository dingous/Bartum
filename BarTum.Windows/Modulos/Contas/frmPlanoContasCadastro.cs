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

namespace BarTum.Windows.Modulos.Contas
{
    public partial class frmPlanoContasCadastro : Form
    {
        BarTumEntities _context = new BarTumEntities();

        public frmPlanoContaList frmPlanoContaList;
        public decimal idPlano;
        public bool consulta = false;

        public frmPlanoContasCadastro()
        {
            InitializeComponent();
        }


        public void fill(ref EB_PlanoContas PlanoEnt)
        {
            PlanoEnt.dsPlanoConta = dsPlanoConta.Text;
            decimal tipo = 0;
            if(RadioReceita.Checked == true)
            {
                tipo = 1;
            }else
            {
                tipo = 2;
            }
            PlanoEnt.TipoLanctoID = tipo;
            if(codigoPai.Value != 0)
            {
                PlanoEnt.Pai = codigoPai.Value;
            }
            
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                EB_PlanoContas PlanoEnt = new EB_PlanoContas();



                if (PlanoContaID.Text == "")
                {


                    fill(ref PlanoEnt);
                    PlanoEnt.flPadraoSaida = false;

                    if (PlanoEnt.Valida(PlanoEnt))
                    {
                        _context.AddToEB_PlanoContas(PlanoEnt);
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Plano de contas inserido com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.Close();
                        frmPlanoContaList.populaGrid();

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(PlanoContaID.Text);

                    PlanoEnt = _context.EB_PlanoContas.Single(cl => cl.PlanoContaID == id);

                    fill(ref PlanoEnt);

                    if (PlanoEnt.Valida(PlanoEnt))
                    {
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Plano de contas atualizado com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.Close();
                        frmPlanoContaList.populaGrid();


                    }
                }


            }
            catch (Exception error)
            {

            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codigoPai_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown controle = (NumericUpDown)sender;
            decimal id = controle.Value;
            var PlanoEnt = _context.EB_PlanoContas.Where(cl => cl.PlanoContaID == id).ToList();
            if (PlanoEnt.Count > 0)
            {
                dsdescricaoPai.Text = PlanoEnt[0].dsPlanoConta;
            }
            else
            {
                dsdescricaoPai.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPlanoContaList frm = new frmPlanoContaList();
            frm.frmPlanoContasCadastro = this;
            frm.ShowDialog();
        }


        public void preencheFormularioEdit()
        {

            var item = (from plano in _context.EB_PlanoContas select plano).Single(a => a.PlanoContaID == this.idPlano);

            PlanoContaID.Text = item.PlanoContaID.ToString();
            dsPlanoConta.Text = item.dsPlanoConta;

            if (item.EB_TipoLancto.TipoLanctoID == 1)
            {
                RadioReceita.Checked = true;
            }
            else
            {
                RadioDespesa.Checked = true;
            }

            if (item.Pai != null)
            {
                codigoPai.Value = item.EB_PlanoContas2.PlanoContaID;
                dsdescricaoPai.Text = item.EB_PlanoContas2.dsPlanoConta;
            }




        }

        private void frmPlanoContasCadastro_Load(object sender, EventArgs e)
        {
            if(this.idPlano != 0)
            {
                botaoSalvar.Text = "Salvar alterações";
                preencheFormularioEdit();
            }

            if(this.consulta == true)
            {
                botaoSalvar.Visible = false;
            }
        }
    }
}
