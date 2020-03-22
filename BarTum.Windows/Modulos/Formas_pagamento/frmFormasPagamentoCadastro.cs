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

namespace BarTum.Windows.Modulos.Formas_pagamento
{
    public partial class frmFormasPagamentoCadastro : Form
    {

        private decimal? id_;
        public decimal? id { get { return id_; } set { id_ = value; } }

        public frmFormasPagamentoList frmFormasPagamentoList;


        private bool consulta_ = false;
        public bool consulta { get { return consulta_; } set { consulta_ = value; } }

        public frmFormasPagamentoCadastro()
        {
            InitializeComponent();
        }

        
        


        public void preencheFormularioEdit()
        {
            BarTumEntities _context = new BarTumEntities();
            var item = (from a in _context.EB_FormaPagamento select a).Single(a => a.FormaPagamentoID == this.id);

            txtFormaPagamentoID.Text = item.FormaPagamentoID.ToString();
            txtdsForma.Text = item.dsForma;
            txtDtCadastro.Text = Convert.ToDateTime(item.dtCadastro).ToString("dd/MM/yyyy");
            TxtCondicaoID.SelectedValue = item.CondicaoID;
            txtOrdem.Value = Convert.ToInt32(item.ordem);
            if (item.flMostrarnoContas == true)
            {
                radioFlMostrarnoContas1.Checked = true;
                radioFlMostrarnoContas2.Checked = false;
            }
            else
            {
                radioFlMostrarnoContas2.Checked = true;
                radioFlMostrarnoContas1.Checked = false;
            }
           
        }


        public void populaCondicao()
        {
            var query = this.frmFormasPagamentoList.context.EB_FormaPagamentoCondicao.ToList();
            eBFormaPagamentoCondicaoBindingSource.DataSource = query;
        }

        private void frmBairroCadastro_Load(object sender, EventArgs e)
        {
            populaCondicao();

            txtDtCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
           
            if (this.id != null)
            {
                preencheFormularioEdit();
                botaoSalvar.Text = "Salvar alterações";
            }


            if (this.consulta == true)
            {
                botaoSalvar.Visible = false;
            }

          

        }

        public void fill(ref EB_FormaPagamento FormasEnt)
        {
            FormasEnt.dsForma = txtdsForma.Text;
            FormasEnt.CondicaoID = Convert.ToDecimal(TxtCondicaoID.SelectedValue);
            FormasEnt.flMostrarnoContas = (radioFlMostrarnoContas1.Checked == true) ? true : false;
            FormasEnt.ordem = Convert.ToInt32(txtOrdem.Value);
            
                        
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                EB_FormaPagamento FormasEnt = new EB_FormaPagamento();



                if (txtFormaPagamentoID.Text == "")
                {


                    fill(ref FormasEnt);


                    FormasEnt.dtCadastro = DateTime.Now;
                    FormasEnt.Flexcluido = false;

                    if (FormasEnt.Valida(FormasEnt))
                    {

                        this.frmFormasPagamentoList.context.AddToEB_FormaPagamento(FormasEnt);
                        this.frmFormasPagamentoList.context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Forma de pagamento inserida com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmFormasPagamentoList.populaGridview();
                        this.Close();

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(txtFormaPagamentoID.Text);

                    FormasEnt = this.frmFormasPagamentoList.context.EB_FormaPagamento.Single(cl => cl.FormaPagamentoID == id);

                    fill(ref FormasEnt);

                    if (FormasEnt.Valida(FormasEnt))
                    {
                        this.frmFormasPagamentoList.context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Forma de pagamento atualizada com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmFormasPagamentoList.populaGridview();
                        this.Close();


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

      
        private void frmBancoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    botaoCancelar_Click(null, null);
                    break;
                case Keys.Enter:
                    botaoSalvar_Click(null, null);
                    break;
            }
        }
    }
}
