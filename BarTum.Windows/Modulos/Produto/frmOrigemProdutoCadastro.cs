using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Produto
{
    public partial class frmOrigemProdutoCadastro : Form
    {

        public frmOrigemProdutoList frmOrigemProdutoList;


        private decimal? id_;
        public decimal? id { get { return id_; } set { id_ = value; } }

        private bool consulta_ = false;
        public bool consulta { get { return consulta_; } set { consulta_ = value; } }


        public frmOrigemProdutoCadastro()
        {
            InitializeComponent();
        }


        public void fill(ref EB_OrigemProduto OrigemEnt)
        {

            OrigemEnt.dsOrigem = dsOrigem.Text;
            if (radioinclusao1.Checked == true)
            {
                OrigemEnt.impressaoObrigatoria = true;
            }
            else
            {
                OrigemEnt.impressaoObrigatoria = false;
            }


            if (radioimpressao1.Checked == true)
            {
                OrigemEnt.impressoraPedidos = true;
            }
            else
            {
                OrigemEnt.impressoraPedidos = false;
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                BarTumEntities _context = new BarTumEntities();
                EB_OrigemProduto OrigemEnt = new EB_OrigemProduto();


                
                if (OrigemID.Text == "")
                {


                    fill(ref OrigemEnt);


                    if (OrigemEnt.Valida(OrigemEnt))
                    {

                        _context.AddToEB_OrigemProduto(OrigemEnt);
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Origem inserida com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmOrigemProdutoList.populaGridview(null);
                        this.Close();

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(OrigemID.Text);

                    OrigemEnt = _context.EB_OrigemProduto.Single(cl => cl.OrigemID == id);

                    fill(ref OrigemEnt);

                    if (OrigemEnt.Valida(OrigemEnt))
                    {
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Origem atualizada com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmOrigemProdutoList.populaGridview(null);
                        this.Close();


                    }
                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        public void preencheFormularioEdit()
        {
            BarTumEntities _context = new BarTumEntities();
            var item = (from a in _context.EB_OrigemProduto select a).Single(a => a.OrigemID == this.id);
            OrigemID.Text = item.OrigemID.ToString();
            dsOrigem.Text = item.dsOrigem;

            if (item.impressaoObrigatoria == true)
            {
                radioinclusao1.Checked = true;
                radioinclusao2.Checked = false;
            }
            else
            {
                radioinclusao1.Checked = false;
                radioinclusao2.Checked = true;
            }


            if (item.impressoraPedidos == true)
            {
                radioimpressao1.Checked = true;
                radioimpressao2.Checked = false;
            }
            else
            {
                radioimpressao1.Checked = false;
                radioimpressao2.Checked = true;
            }

        }



        private void frmOrigemProdutoCadastro_Load(object sender, EventArgs e)
        {
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

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
