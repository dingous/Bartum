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
    public partial class frmGrupoProdutoCadastro : Form
    {

        private decimal? id_;
        public decimal? id { get { return id_; } set { id_ = value; } }

        frmGrupoProdutoList frmGrupoProdutoList;
        private object pai_;
        public object pai { get { return pai_; } set { pai_ = value; } }

        private bool consulta_ = false;
        public bool consulta { get { return consulta_; } set { consulta_ = value; } }


        public frmGrupoProdutoCadastro()
        {
            InitializeComponent();
        }


        public void fill(ref EB_GrupoProduto GrupoEnt)
        {
            
            GrupoEnt.dsGrupo = dsGrupo.Text;

            if (codigoPai.Value != 0)
            {
                GrupoEnt.pai = codigoPai.Value;
            }

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                BarTumEntities _context = new BarTumEntities();
                EB_GrupoProduto GrupoEnt = new EB_GrupoProduto();



                if (GrupoID.Text == "")
                {


                    fill(ref GrupoEnt);

                    GrupoEnt.flExcluido = false;

                    if (GrupoEnt.Valida(GrupoEnt))
                    {

                        _context.AddToEB_GrupoProduto(GrupoEnt);
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Grupo inserido com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmGrupoProdutoList.populaGridview(null);
                        this.Close();

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(GrupoID.Text);

                    GrupoEnt = _context.EB_GrupoProduto.Single(cl => cl.GrupoID == id);

                    fill(ref GrupoEnt);

                    if (GrupoEnt.Valida(GrupoEnt))
                    {
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Grupo atualizado com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmGrupoProdutoList.populaGridview(null);
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


        public void preencheFormularioEdit()
        {
            BarTumEntities _context = new BarTumEntities();
            var item = (from a in _context.EB_GrupoProduto select a).Single(a => a.GrupoID == this.id);
            GrupoID.Text = item.GrupoID.ToString();
            dsGrupo.Text = item.dsGrupo;

            if (item.pai != null)
            {
                codigoPai.Value = item.EB_GrupoProduto2.GrupoID;
                dsdescricaoPai.Text = item.EB_GrupoProduto2.dsGrupo;
            }

        }

        private void frmGrupoProdutoCadastro_Load(object sender, EventArgs e)
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

            if (this.pai != null)
            {
                var tipo = this.pai.GetType();

                switch (tipo.Name)
                {
                    case "frmGrupoProdutoList":

                        this.frmGrupoProdutoList = (frmGrupoProdutoList)this.pai;

                        break;
                }

            }
        }


        private void codigoPai_ValueChanged(object sender, EventArgs e)
        {
            BarTumEntities _context = new BarTumEntities();
            NumericUpDown controle = (NumericUpDown)sender;
            decimal id = controle.Value;
            var GrupoEnt = _context.EB_GrupoProduto.Where(cl => cl.GrupoID == id).ToList();
            if (GrupoEnt.Count > 0)
            {
                dsdescricaoPai.Text = GrupoEnt[0].dsGrupo;
            }
            else
            {
                dsdescricaoPai.Text = "";
            }
        }
    }
}
