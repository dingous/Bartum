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
using BarTum.Windows.Modulos.Fornecedor;
using System.Data.Objects;

namespace BarTum.Windows.Modulos.Produto
{
    public partial class frmProdutoCadastro : Form
    {
        BarTumEntities _context = new BarTumEntities();
        public int _id = 0;
        public frmProdutoList frmProdutoList;
        public bool consulta = false;

        public frmProdutoCadastro()
        {
            InitializeComponent();

        }

        public void preencheFormularioEdit()
        {
            var res = _context.EB_Produto.FirstOrDefault(a => a.ProdutoID == this._id);

            ProdutoID.Text = res.ProdutoID.ToString();
            ProdutoIDHidden.Text = res.ProdutoID.ToString();
            nrCodigoBarras.Text = res.nrCodigoBarras.ToString();
            dsProduto.Text = res.dsProduto;
            dtCadastro.Text = res.dtCadastro.ToString();
            GrupoID.Text = res.GrupoID.ToString();
            dsGrupo.Text = res.EB_GrupoProduto.dsGrupo;
            comboUnidades.SelectedIndex = res.nrUnidade;

            estoqueAtual.Text = res.nrEstoqueAtual.ToString();

            string campo1 = Convert.ToDecimal(res.nrPrecoCusto).ToString("C");
            nrPrecoCusto.Text = campo1;

            string campo2 = Convert.ToDecimal(res.nrPrecoVenda).ToString("C");
            nrPrecoVenda.Text = campo2;


            nrEstoqueMin.Text = res.nrEstoqueMin.ToString();
            nrEstoqueMax.Text = res.nrEstoqueMax.ToString();
            OrigemID.SelectedValue = res.OrigemID;
            TipoProdutoID.SelectedValue = res.TipoProdutoID;
            FornecedorID.Text = res.FornecedorID.ToString();
            dsNomeFantasia.Text = res.EB_Fornecedor.dsNomeFantasia;


            ativaDesativaControlesTipoProduto(Convert.ToDecimal(res.TipoProdutoID));



        }


        private void frmProdutoCadastro_Load(object sender, EventArgs e)
        {

            if (consulta == true)
            {
                botaoSalvar.Visible = false;
                botaoSalvar.Enabled = false;
            }

            populaOrigem();
            populaTipoProduto();



            if (this._id != 0)
            {
                preencheFormularioEdit();
                botaoSalvar.Text = "Salvar alterações";
                //ProdutoID.ReadOnly = true;
                populaProdutosCompostos();

            }
            else
            {
                getUltimoIDProduto();
                comboUnidades.SelectedIndex = 0;
            }



        }


        public void getUltimoIDProduto()
        {
            var result = (from item in _context.EB_Produto orderby item.ProdutoID descending select new { item.ProdutoID }).ToList().Take(1).FirstOrDefault();
            if (result == null) { ProdutoID.Text = "1"; } else { ProdutoID.Text = (result.ProdutoID + 1).ToString(); }
            ProdutoIDHidden.Text = "0";
        }


        public void fill(ref EB_Produto ProdutoEnt)
        {
            if (this._id == 0)
            {
                ProdutoEnt.ProdutoID = Convert.ToDecimal(ProdutoID.Text);
            }
            ProdutoEnt.ProdutoIDHidden = Convert.ToDecimal(ProdutoIDHidden.Text);
            ProdutoEnt.dsProduto = dsProduto.Text;
            //ProdutoEnt.nrUnidade = nrUnidade.Text == "" ? 0 : Convert.ToInt32(nrUnidade.Text);
            ProdutoEnt.nrUnidade = Convert.ToInt32(comboUnidades.SelectedIndex);


            ProdutoEnt.nrPrecoCusto = Convert.ToDecimal(nrPrecoCusto.Text.Replace("R$ ", "").Replace(".", ""));
            ProdutoEnt.nrPrecoVenda = Convert.ToDecimal(nrPrecoVenda.Text.Replace("R$ ", "").Replace(".", ""));


            ProdutoEnt.nrEstoqueMin = nrEstoqueMin.Text == "" ? 0 : Convert.ToDecimal(nrEstoqueMin.Text);
            ProdutoEnt.nrEstoqueMax = nrEstoqueMax.Text == "" ? 0 : Convert.ToDecimal(nrEstoqueMax.Text);
            ProdutoEnt.OrigemID = Convert.ToDecimal(OrigemID.SelectedValue);
            ProdutoEnt.TipoProdutoID = Convert.ToDecimal(TipoProdutoID.SelectedValue);
            if (!(FornecedorID.Text == "")) { ProdutoEnt.FornecedorID = Convert.ToDecimal(FornecedorID.Text); } else { ProdutoEnt.FornecedorID = null; }
            if (!(GrupoID.Text == "")) { ProdutoEnt.GrupoID = Convert.ToDecimal(GrupoID.Text); } else { ProdutoEnt.GrupoID = null; }


        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dsProduto.Text == "")
                {
                    MessageBox.Show("Informe uma descrição para o produto", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dsProduto.Focus();
                    return;
                }
                else if (GrupoID.Value == 0 || dsGrupo.Text == "")
                {
                    MessageBox.Show("Selecione um grupo", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GrupoID.Focus();
                    return;
                }
                else if (FornecedorID.Value == 0 || dsNomeFantasia.Text == "")
                {
                    MessageBox.Show("Selecione um fornecedor", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FornecedorID.Focus();
                    return;
                }


                EB_Produto ProdutoEnt = new EB_Produto();




                if (this._id == 0)
                {

                    ProdutoEnt.dtCadastro = Convert.ToDateTime(dtCadastro.Text);
                    ProdutoEnt.flExcluido = false;
                    fill(ref ProdutoEnt);


                    if (ProdutoEnt.Valida(ProdutoEnt))
                    {
                        _context.AddToEB_Produto(ProdutoEnt);
                        _context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Produto inserido com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);

                        frmProdutoList.populaGridview(null);
                        this.Close();


                    }

                }
                else
                {
                    int id = Convert.ToInt32(ProdutoIDHidden.Text);
                    int produto_novo = Convert.ToInt32(ProdutoID.Text);
                    ProdutoEnt = _context.EB_Produto.Single(cl => cl.ProdutoID == id);


                  


                    fill(ref ProdutoEnt);

                    if (ProdutoEnt.Valida(ProdutoEnt))
                    {
                        _context.SaveChanges();


                        if (id != produto_novo)
                        {
                            using (BarTumEntities contextProc = new BarTumEntities())
                            {
                                ObjectResult<ALTERA_CHAVE_PRODUTO_Result> proc_produto = contextProc.ALTERA_CHAVE_PRODUTO(produto_novo, id);
                                _context.SaveChanges();
                            }
                        }

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Produto atualizado com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);

                        frmProdutoList.populaGridview(null);
                        this.Close();


                    }

                }
            }
            catch (Exception error)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(error.InnerException.Message, "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }
        }


        public void populaOrigem()
        {
            var result = (from item in _context.EB_OrigemProduto where item.flMostrar == true orderby item.dsOrigem descending select new { item.OrigemID, item.dsOrigem }).ToList();
            OrigemID.DataSource = result;


        }

        public void populaTipoProduto()
        {
            var result = (from item in _context.EB_TipoProduto orderby item.dsTipoProduto descending select new { item.TipoProdutoID, item.dsTipoProduto }).ToList();
            TipoProdutoID.DataSource = result;
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        public void GrupoID_TextChanged(object sender, EventArgs e)
        {
            decimal idGrupotxt = GrupoID.Value;

            var GrupoProd = _context.EB_GrupoProduto.FirstOrDefault(cl => cl.GrupoID == idGrupotxt && cl.flExcluido == false);
            if (GrupoProd != null)
            {
                dsGrupo.Text = GrupoProd.dsGrupo;
            }
            else
            {
                dsGrupo.Text = "";
                GrupoID.Text = "";
            }
        }

        private void button3_TextChanged(object sender, EventArgs e)
        {
            decimal idFornecedortxt = Convert.ToDecimal(FornecedorID.Text);
            var Forn = _context.EB_Fornecedor.FirstOrDefault(cl => cl.FornecedorID == idFornecedortxt);
            if (Forn != null)
            {
                dsNomeFantasia.Text = Forn.dsNomeFantasia;
            }
            else
            {
                dsNomeFantasia.Text = "";
                FornecedorID.Text = "";
            }
        }






        #region mascaras
        //máscaras
        string str = "";
        private void Mask_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {



            TextBox txtBox = (TextBox)sender;
            Control controle = txtBox;


            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                //char teste = Convert.ToChar(Keys);

                string chave = e.KeyCode.ToString();

                switch (chave)
                {
                    case "NumPad0":
                        str = str + Convert.ToChar(Keys.D0);
                        break;
                    case "NumPad1":
                        str = str + Convert.ToChar(Keys.D1);
                        break;
                    case "NumPad2":
                        str = str + Convert.ToChar(Keys.D2);
                        break;
                    case "NumPad3":
                        str = str + Convert.ToChar(Keys.D3);
                        break;
                    case "NumPad4":
                        str = str + Convert.ToChar(Keys.D4);
                        break;
                    case "NumPad5":
                        str = str + Convert.ToChar(Keys.D5);
                        break;
                    case "NumPad6":
                        str = str + Convert.ToChar(Keys.D6);
                        break;
                    case "NumPad7":
                        str = str + Convert.ToChar(Keys.D7);
                        break;
                    case "NumPad8":
                        str = str + Convert.ToChar(Keys.D8);
                        break;
                    case "NumPad9":
                        str = str + Convert.ToChar(Keys.D9);
                        break;
                    default: str = str + Convert.ToChar(KeyCode); break;
                }


            }
            if (str.Length == 0)
            {
                controle.Text = "";
            }
            if (str.Length == 1)
            {



                controle.Text = Convert.ToDecimal("0,0" + str).ToString("C");
            }
            else if (str.Length == 2)
            {
                controle.Text = Convert.ToDecimal("0," + str).ToString("C");
            }
            else if (str.Length > 2)
            {
                controle.Text = Convert.ToDecimal(str.Substring(0, str.Length - 2) + "," + str.Substring(str.Length - 2)).ToString("C");
            }
        }
        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val >= 96 && Val <= 105) || (Val == 8) || (Val == 46));
        }
        private void Mask_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion mascaras


        private void nrPrecoCusto_Leave(object sender, EventArgs e)
        {
            this.str = "";
        }

        private void nrPrecoVenda_Leave(object sender, EventArgs e)
        {
            this.str = "";
        }

        public void prodCompostoCod_ValueChanged(object sender, EventArgs e)
        {
            decimal id = prodCompostoCod.Value;
            var produto = _context.EB_Produto.FirstOrDefault(a => a.ProdutoID == id && a.TipoProdutoID != 2);
            if (produto != null)
            {
                prodCompostoDescricao.Text = produto.dsProduto;
            }
            else
            {
                prodCompostoDescricao.Text = "";
            }
        }

        public void populaProdutosCompostos()
        {
            var query = (from prod in _context.EB_ProdutoComp.AsEnumerable()
                         where prod.ProdutoPrincipalID == this._id
                         select new
                         {
                             ProdutoCompID = prod.ProdutoCompID,
                             ProdutoID = prod.ProdutoID,
                             Quantidade = prod.Quantidade,
                             descricao = prod.EB_Produto.dsProduto,
                             CustoUnit = prod.EB_Produto.nrPrecoCusto,
                             TotalCusto = (Convert.ToDecimal(prod.Quantidade) * Convert.ToDecimal(prod.EB_Produto.nrPrecoCusto)).ToString("C2")

                         }
                        ).ToList();

            eB_ProdutoCompBindingSource.DataSource = null;
            eB_ProdutoCompBindingSource.DataSource = query;
            eB_ProdutoCompDataGridView.DataSource = eB_ProdutoCompBindingSource;

        }

        private void prodCompostoBotao_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._id != 0 && prodCompostoDescricao.Text != "")
                {


                    EB_ProdutoComp ent = new EB_ProdutoComp();
                    ent.ProdutoPrincipalID = this._id;
                    ent.ProdutoID = prodCompostoCod.Value;
                    ent.Quantidade = prodCompostoQuantidade.Value;
                    _context.EB_ProdutoComp.AddObject(ent);
                    _context.SaveChanges();
                    populaProdutosCompostos();
                }
                else
                {
                    MessageBox.Show("É necessário selecionar um produto.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            catch (Exception error)
            {

            }

        }




        public void ativaDesativaControlesTipoProduto(decimal tipoProduto)
        {

            //comentar esta linha depois
            //this.Size = new Size(933, 318);

            /*if (tipoProduto == 1)
            {
                tabControl2.Visible = false;
                tabControl2.Enabled = false;
                tabControl2.TabPages.Clear();
                this.Size = new Size(933, 318);
            }
            else if (tipoProduto == 2)
            {
                tabControl2.Visible = true;
                tabControl2.Enabled = true;
                tabControl2.TabPages.Clear();             
                tabControl2.TabPages.Add(tabPage3);
                this.Size = new Size(933, 579);

                
            }else if(tipoProduto == 3)
            {
                tabControl2.Visible = true;
                tabControl2.Enabled = true;
                tabControl2.TabPages.Clear();
                tabControl2.TabPages.Add(tabPage4);
                this.Size = new Size(933, 579);
                
            }*/

        }


        private void TipoProdutoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            ativaDesativaControlesTipoProduto(Convert.ToDecimal(combo.SelectedValue));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdutoList frm = new frmProdutoList();
            frm.frmProdutoCadastro = this;
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGrupoProdutoList frm = new frmGrupoProdutoList();
            frm.frmProdutoCadastro = this;
            frm.ShowDialog();

        }

        private void eB_ProdutoCompDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:

                    int id = Convert.ToInt32(eB_ProdutoCompDataGridView.Rows[eB_ProdutoCompDataGridView.CurrentRow.Index].Cells[0].Value);
                    EB_ProdutoComp ent = _context.EB_ProdutoComp.Single(a => a.ProdutoCompID == id);
                    _context.DeleteObject(ent);
                    _context.SaveChanges();
                    this.populaProdutosCompostos();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFornecedorList frm = new frmFornecedorList();
            frm.frmProdutoCadastro = this;
            frm.ShowDialog();
        }

        public void FornecedorID_ValueChanged(object sender, EventArgs e)
        {
            decimal id = FornecedorID.Value;

            var forn = _context.EB_Fornecedor.FirstOrDefault(cl => cl.FornecedorID == id);
            if (forn != null)
            {
                dsNomeFantasia.Text = forn.dsNomeFantasia;
            }
            else
            {
                dsNomeFantasia.Text = "";
                FornecedorID.Text = "";
            }
        }

        private void frmProdutoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.botaoSalvar_Click(null, null);
                    break;
                case Keys.Escape:
                    this.botaoCancelar_Click(null, null);
                    break;
            }
        }

        private void eB_ProdutoCompDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (!e.Row.IsNewRow)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res;
                res = MessageBox.Show(this, "Deseja excluir o ítem selecionado?", "BarTum", buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (res == DialogResult.No)
                {
                    e.Cancel = true;

                }
                else
                {
                    try
                    {

                        decimal idItem = Convert.ToDecimal(e.Row.Cells["GridProdutoID"].Value);
                        var item = _context.EB_ProdutoComp.FirstOrDefault(a => a.ProdutoID == idItem && a.ProdutoPrincipalID == this._id );
                        _context.DeleteObject(item);
                        _context.SaveChanges();


                    }
                    catch (Exception error)
                    {

                    }
                }


            }
        }


    }
}
