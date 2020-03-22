using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Utilities;
using BarTum.Windows.Modulos.Fornecedor;
using BarTum.Windows.Modulos.Produto;

namespace BarTum.Windows.Modulos.Estoque
{
    public partial class frmControleEstoque : Form
    {
        public string tipo_lancamento = null;

        BarTumEntities _context = new BarTumEntities();
        EB_EstoqueLancto ent;
        public decimal id = 0;
        public frmMain frmMain { get; set; }

        public frmControleEstoque()
        {
            InitializeComponent();
        }

        public void FrmControleEstoque_Load(object sender, EventArgs e)
        {
            ent = null;

            txtBoxDtLancamento.Value = DateTime.Now;
            TxtBoxNrLancamento.Text = "";
            txtBoxNrNota.Text = "";
            FornecedorID.Value = 0;
            dsNomeFantasia.Text = "";
            prodCompostoCod.Value = 0;
            prodCompostoDescricao.Text = "";
            txtBoxUnid.Text = "";
            prodQuantidade.Value = 1;
            textBoxPrCusto.Text = "";
            Total.Text = "";
            toolStripBotaoNovaEntrada.Enabled = true;
            toolStripBotaoNovaSaida.Enabled = true;



            if (id == 0)
            {
                ent = new EB_EstoqueLancto();
                populaProdutos("INSERT");
            }
            else
            {
                ent = _context.EB_EstoqueLancto.Single(a => a.EstoqueLanctoID == this.id);
                populaInformacoes(this.id);
                populaProdutos("EDIT");
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.id = 0;
            FrmControleEstoque_Load(null, null);
            
            cancelaMudancas();

            populaProdutos("INSERT");
            
            this.tipo_lancamento = "ENTRADA";
            panel1.Enabled = true;
            groupBoxProdutos.Enabled = true;
            txtBoxNrNota.Focus();

            toolStripBotaoNovaEntrada.Enabled = false;
            toolStripBotaoNovaSaida.Enabled = false;
            toolStripBotaoSalvarAlteracoes.Enabled = true;
            toolStripButton1.Enabled = true;

            //frmMain frmMain = (frmMain)this.MdiParent;

           
            ent.UsuarioID = frmMain.UsuarioLogado;
            ent.TipoMovID = 2;
            ent.dtLancto = DateTime.Now;
            _context.AddToEB_EstoqueLancto(ent);
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.id = 0;
            FrmControleEstoque_Load(null, null);
            
            cancelaMudancas();

            populaProdutos("INSERT");

            this.tipo_lancamento = "SAIDA";
            panel1.Enabled = true;
            groupBoxProdutos.Enabled = true;
            txtBoxNrNota.Focus();


            toolStripBotaoNovaEntrada.Enabled = false;
            toolStripBotaoNovaSaida.Enabled = false;
            toolStripBotaoSalvarAlteracoes.Enabled = true;
            toolStripButton1.Enabled = true;

          


            ent.UsuarioID = frmMain.UsuarioLogado;
            ent.TipoMovID = 1;
            ent.dtLancto = DateTime.Now;
            _context.AddToEB_EstoqueLancto(ent);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ent.FornecedorID = FornecedorID.Value;
            ent.nrNota = txtBoxNrNota.Text;


            if (toolStripBotaoSalvarAlteracoes.Enabled == true)
            {

                if (ent.nrNota == "")
                {
                    MessageBox.Show("Informe o número da nota", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxNrNota.Focus();
                    return;
                }
                if (ent.FornecedorID == null || dsNomeFantasia.Text == "")
                {
                    MessageBox.Show("Selecione um fornecedor", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FornecedorID.Focus();
                    return;
                }

                int linha = eB_EstoqueLancItensDataGridView.Rows.Count;
                if (linha == 0)
                {
                    MessageBox.Show("É necessário incluir pelo menos um produto na lista", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prodCompostoCod.Focus();
                    return;
                }

                try
                {

                   

                    IEnumerable<System.Data.Objects.ObjectStateEntry> addes = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added);
                    IEnumerable<System.Data.Objects.ObjectStateEntry> edited = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified);
                    IEnumerable<System.Data.Objects.ObjectStateEntry> deleted = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted);








                    var linhas = eB_EstoqueLancItensDataGridView.Rows;

                    foreach(DataGridViewRow line in linhas)
                    {
      
                        decimal idProduto = Convert.ToDecimal(line.Cells[2].Value);
                        decimal NrestoQue = Convert.ToDecimal(line.Cells[5].Value);

                        EB_Produto itemProd = _context.EB_Produto.FirstOrDefault(a => a.ProdutoID == idProduto);
                        itemProd.nrEstoqueAtual = itemProd.nrEstoqueAtual + NrestoQue;
                    }




                    _context.SaveChanges();

                    MessageBox.Show("Alterações realizadas com sucesso!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                cancelaMudancas();
            }

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {

            ent.FornecedorID = FornecedorID.Value;
            ent.nrNota = txtBoxNrNota.Text;

            Predicate<object> p = obj => 
            {
                var tipo = obj.GetType().Name;
                EB_EstoqueLancto entidade; 
                if (tipo == "EB_EstoqueLancto")
                {
                    entidade = (EB_EstoqueLancto)obj;
                    if (entidade.Valida(entidade) == true && eB_EstoqueLancItensDataGridView.Rows.Count > 0) { return true; } else { return false; }
                }
                    
                return true;
            };
                

            IEnumerable<System.Data.Objects.ObjectStateEntry> added = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added).Where(item => p(item.Entity) == true);
            IEnumerable<System.Data.Objects.ObjectStateEntry> edited = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified);
            IEnumerable<System.Data.Objects.ObjectStateEntry> deleted = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted);
            
            int countadded = added.Count();
            int countedited = edited.Count();
            int deleteddeleted = deleted.Count();


            if (countadded > 0 || countedited > 0 || deleteddeleted > 0)
            {
                var question = MessageBox.Show("Deseja salvar alterações antes de sair?", "EasyBar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    try
                    {                     
                        _context.SaveChanges();
                        MessageBox.Show("Alterações salvas com sucesso!", "EasyBar",  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }catch(Exception error)
                    {
                        MessageBox.Show(error.Message, "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }

            this.Close();
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


        
     

        

        private void button3_Click(object sender, EventArgs e)
        {
            frmFornecedorList frm = new frmFornecedorList();
            frm.frmControleEstoque = this;
            frm.ShowDialog();
        }

        public void prodCompostoCod_ValueChanged(object sender, EventArgs e)
        {
            BarTumEntities context = new BarTumEntities();

            decimal id = prodCompostoCod.Value;
            var produto = context.EB_Produto.FirstOrDefault(a => a.ProdutoID == id);
            if (produto != null)
            {
                prodCompostoDescricao.Text = produto.dsProduto;
                txtBoxUnid.Text = produto.nrUnidade.ToString();
                textBoxPrCusto.Text = Convert.ToDecimal(produto.nrPrecoCusto).ToString("C2");
                prodQuantidade_ValueChanged(null, null);
            }
            else
            {
                prodCompostoDescricao.Text = "";
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdutoList frm = new frmProdutoList();
            frm.frmControleEstoque = this;
            frm.ShowDialog();
        }

        private void prodQuantidade_ValueChanged(object sender, EventArgs e)
        {
            decimal multp = Convert.ToDecimal(prodQuantidade.Value) * Convert.ToDecimal(textBoxPrCusto.Text.Replace("R$ ", "").Replace(".", ""));
            Total.Text = multp.ToString();
        }





        public void populaInformacoes(decimal id)
        {
            panel1.Enabled = true;
            groupBoxProdutos.Enabled = true;
            txtBoxNrNota.Focus();
            
            var query =  _context.EB_EstoqueLancto.Single(a => a.EstoqueLanctoID == id);
            TxtBoxNrLancamento.Text = query.EstoqueLanctoID.ToString();
            txtBoxDtLancamento.Value = query.dtLancto;
            txtBoxNrNota.Text = query.nrNota;
            FornecedorID.Value = query.EB_Fornecedor.FornecedorID;
            dsNomeFantasia.Text = query.EB_Fornecedor.dsNomeFantasia;

        }





        //public IEnumerable<EB_EstoqueLancItens> linqtoEntities;
        public System.Data.Objects.ObjectQuery<EB_EstoqueLancItens> linqtoEntities;
        public void populaProdutos(string tipo)
        {
            /*linqtoEntities = (from item in _context.EB_EstoqueLancItens.OrderByDescending(a=>a.dtLancto)
                              select new EB_EstoqueLancItens
                              {
                                  EstoqueLanctoItemID = item.EstoqueLanctoItemID,
                                  EstoqueLanctoID = item.EstoqueLanctoID,
                                  ProdutoID = item.EB_Produto.ProdutoID,
                                  dsProduto = item.EB_Produto.dsProduto,
                                  dsGrupo = item.EB_Produto.EB_GrupoProduto.dsGrupo,
                                  nrUnidade = item.EB_Produto.nrUnidade,
                                  nrQuantidade = item.nrQuantidade,
                                  nrPrCusto = item.nrPrCusto,
                                  Total = item.nrQuantidade * item.nrPrCusto,
                                  dtLancto = item.dtLancto

                              }
                     );*/


            //esta consulta utiliza a lingagem OQL precisa achar um conversor oql para sql
            /*string queryString = @"select x.EstoqueLanctoItemID from x in _context.EB_EstoqueLancItens";
            var linqtoEntities = new System.Data.Objects.ObjectQuery<EB_EstoqueLancItens>(queryString, _context, System.Data.Objects.MergeOption.NoTracking);
            //System.Data.Objects.ObjectQuery<System.Data.Common.DbDataRecord> productQuery2 = linqtoEntities.Select("s.count");
            linqtoEntities.Name = "it";*/
            
            
            
            
            
            if(tipo == "INSERT")
            {
                var linqtoEntities = _context.EB_EstoqueLancItens.Include("EB_Produto").OrderByDescending(a => a.dtLancto).Skip(0).Take(0);
                eB_EstoqueLancItensBindingSource.DataSource = linqtoEntities;
            }
            else if (tipo == "EDIT")
            {
                var linqtoEntities = _context.EB_EstoqueLancItens.Include("EB_Produto").Where(a => a.EstoqueLanctoID == this.id).OrderByDescending(a => a.dtLancto);
                eB_EstoqueLancItensBindingSource.DataSource = linqtoEntities;

                toolStripBotaoSalvarAlteracoes.Enabled = true;
                toolStripButton1.Enabled = true;
            
            }


           
        }




        private void prodCompostoBotao_Click(object sender, EventArgs e)
        {

           
            //var b = _context.ObjectStateManager.GetObjectStateEntry(ent);
            
            //System.Data.Objects.ObjectStateEntry stateEntry = _context.ObjectStateManager.GetObjectStateEntry(_context.EB_EstoqueLanctoItens);
          



            if (prodCompostoCod.Value == 0 || prodCompostoDescricao.Text == "")
            {
                MessageBox.Show("Selecione um produto", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prodCompostoCod.Focus();
                return;
            }

            frmMain frmMain = (frmMain)this.MdiParent;

            try
            {
                var prod = _context.EB_Produto.Single(a => a.ProdutoID == prodCompostoCod.Value);


                EB_EstoqueLancItens Ent = new EB_EstoqueLancItens();
                Ent.EstoqueLanctoID = ent.EstoqueLanctoID;
                Ent.ProdutoID = prod.ProdutoID;
                Ent.dsProduto = prod.dsProduto;
                Ent.dsGrupo = prod.EB_GrupoProduto.dsGrupo;
                Ent.nrQuantidade = prodQuantidade.Value;
                Ent.nrPrCusto = Convert.ToDecimal(textBoxPrCusto.Text.Replace("R$ ", "").Replace(".", ""));
                Ent.dtLancto = DateTime.Now;
                Ent.nrUnidade = Convert.ToInt32(txtBoxUnid.Text);
                Ent.vlTotal = Convert.ToDecimal(Total.Text.Replace("R$ ", "").Replace(".", ""));
                _context.EB_EstoqueLancItens.AddObject(Ent);

                ent.EB_EstoqueLancItens.Add(Ent);              
                eB_EstoqueLancItensBindingSource.Add(Ent);

                


                //var order = (from o in _context.EB_EstoqueLancto select o).FirstOrDefault();
                
                /*System.Data.Objects.ObjectStateEntry stateEntry = _context.ObjectStateManager.GetObjectStateEntry(ent);
                IEnumerable<System.Data.Objects.ObjectStateEntry> a = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added);
                List<System.Data.Objects.ObjectStateEntry> pendentes = a.Where(c => c.Entity.GetType().ToString() == "EasyBar.Entities.EB_EstoqueLanctoItens").ToList();
                */

                

                /*eB_EstoqueLanctoBindingSource.DataSource = null;
                eB_EstoqueLanctoBindingSource.DataSource = query;
                eB_EstoqueLanctoItensDataGridView.DataSource = eB_EstoqueLanctoBindingSource;*/

                //var teste = eB_EstoqueLancItensBindingSource.List;
               

                //populaProdutos();

            }catch(Exception error)
            {

            }


        }

        private void eB_EstoqueLancItensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
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

        private void toolStripBotaoLocalizaLanctos_Click(object sender, EventArgs e)
        {
            frmContoleEstoqueLancamentos frm = new frmContoleEstoqueLancamentos();
            frm.frmControleEstoque = this;
            frm.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.id = 0;
            cancelaMudancas();

            FrmControleEstoque_Load(null, null);
        }


        public void cancelaMudancas()
        {
            var stateEntries = _context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified | EntityState.Added | EntityState.Deleted);
            foreach (var changedEntity in stateEntries)
            {
                if (changedEntity.State == EntityState.Modified || changedEntity.State == EntityState.Deleted)
                    _context.Refresh(System.Data.Objects.RefreshMode.StoreWins, changedEntity.Entity);

                else if (changedEntity.State == EntityState.Added)
                    _context.Detach(changedEntity.Entity);

            }
        }

        private void frmControleEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    botaoCancelar_Click(null, null);
                    break;
                case Keys.Enter:
                    toolStripButton4_Click(null, null);
                    break;
            }
        }

     
    }
   
}
