using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

//using EasyBar.Windows.Modulos.Relatorios;

namespace BarTum.Windows.Modulos.Contas
{
    public partial class frmContasReceberList : Form
    {

        public BarTumEntities _context = new BarTumEntities();

        public frmMain frmMain;

        FlowLayoutPanel painel;
        public void controlesBusca()
        {
            painel = new FlowLayoutPanel();
            painel.BringToFront();
            painel.Width = 300;
            painel.BackColor = Color.Transparent;

            Label LabelDtInicial = new Label();
            LabelDtInicial.Name = "LabelDtInicial";
            LabelDtInicial.Text = "De: ";
            LabelDtInicial.AutoSize = true;
            LabelDtInicial.TextAlign = ContentAlignment.MiddleRight;
            LabelDtInicial.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            

            DateTimePicker BuscaDtInicial = new DateTimePicker();
            BuscaDtInicial.Name = "BuscaDtInicial";
            BuscaDtInicial.CustomFormat = "dd/MM/yyyy";
            BuscaDtInicial.Format = DateTimePickerFormat.Short;
            BuscaDtInicial.Width = 100;
            BuscaDtInicial.AutoSize = true;
            BuscaDtInicial.Margin = new System.Windows.Forms.Padding(0,8,0,0);


            Label labelDtFinal = new Label();
            labelDtFinal.Name = "labelDtFinal";
            labelDtFinal.Text = " Até: ";
            labelDtFinal.AutoSize = true;
            labelDtFinal.TextAlign = ContentAlignment.MiddleRight;
            labelDtFinal.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);

            DateTimePicker BuscaDtFinal = new DateTimePicker();
            BuscaDtFinal.Name = "BuscaDtInicial";
            BuscaDtFinal.CustomFormat = "dd/MM/yyyy";
            BuscaDtFinal.Format = DateTimePickerFormat.Short;
            BuscaDtFinal.Width = 100;
            BuscaDtFinal.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);


            Button botao = new Button();
            botao.Image = global::BarTum.Windows.Properties.Resources.search;
            botao.Location = new System.Drawing.Point(200, 71);
            botao.Name = "botaoBuscar";
            botao.Size = new System.Drawing.Size(32, 30);
            botao.UseVisualStyleBackColor = true;
            botao.Click += new System.EventHandler(this.botaoBuscar_Click);

            TextBox txtCriterio = new TextBox();
            txtCriterio.Name = "botaoBuscar";
            txtCriterio.Width = 250;
            txtCriterio.Visible = false;
            txtCriterio.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            txtCriterio.CharacterCasing = CharacterCasing.Upper;
            txtCriterio.KeyDown += new KeyEventHandler(txtCriterio_KeyDown);
 
            painel.Controls.AddRange(new System.Windows.Forms.Control[] {
                LabelDtInicial,
                BuscaDtInicial,
                labelDtFinal,
                BuscaDtFinal,
                txtCriterio,
                botao
            });

            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                   new ToolStripControlHost(painel)    
            });

        }

        void txtCriterio_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    this.botaoBuscar_Click(null, null);

                    break;
                    
            }
        }

        public frmContasReceberList()
        {
            InitializeComponent();
            controlesBusca();
        }


        private void toolStripIncluir_Click(object sender, EventArgs e)
        {
            frmContasReceberCadastro frm = new frmContasReceberCadastro();
            frm.frmContasReceberList = this;
            frm.frmMain = this.frmMain;
            frm.ShowDialog();
        }


        public void somaTotalPago()
        {
            var query = (from eb_contas in
                             (from eb_contas in _context.EB_Contas
                              where
                                eb_contas.flBaixada == true && eb_contas.TipoLanctoID == 1
                              select new
                              {
                                  eb_contas.fechaValorPago,
                                  Dummy = "x"
                              })
                         group eb_contas by new { eb_contas.Dummy } into g
                         select new
                         {
                             pagas = (Decimal?)g.Sum(p => p.fechaValorPago)
                         }).ToList();
            
            if (query.Count > 0)
            {
                TotalPagos.Text = Convert.ToDecimal(query[0].pagas).ToString("C");
            }
            else
            {
                TotalPagos.Text = "R$ 0,00";
            }
        }

        public void somaTotalAPagar()
        {
            var query = (from eb_contas in
                             (from eb_contas in _context.EB_Contas
                              where
                                eb_contas.flBaixada == false && eb_contas.TipoLanctoID == 1
                              select new
                              {
                                  eb_contas.vlConta,
                                  Dummy = "x"
                              })
                         group eb_contas by new { eb_contas.Dummy } into g
                         select new
                         {
                             apagar = (Decimal?)g.Sum(p => p.vlConta)
                         }).ToList();
            if (query.Count > 0)
            {
                totalAPagar.Text = Convert.ToDecimal(query[0].apagar).ToString("C");
            }
            else
            {
                totalAPagar.Text = "R$ 0,00";
            }
        }



       

       

        private void frmContasPagarList_Load(object sender, EventArgs e)
        {
            try
            {

                populaGridview();
                query = query.Where(a => a.flBaixada.Equals("False")).OrderBy(a => a.dtVencimento);
                paginacao();
                ComboExibir.SelectedIndex = 0;
                ComboTipoBusca.SelectedIndex = 0;

                ComboExibir.SelectedIndexChanged += new EventHandler(ComboExibir_SelectedIndexChanged);
                              

            }catch(Exception error)
            {

            }
        }



       

        public IEnumerable<GridClass> query;
        public void populaGridview()
        {
             try
            {

            query = (from item in _context.EB_Contas.AsEnumerable().DefaultIfEmpty()
                     where item.TipoLanctoID == 1
                     orderby item.dtVencimento ascending
                     select new GridClass
                     {
                         contasID = item.contasID.ToString(),
                         descricao = item.descricao,
                         dsPlanoConta = item.EB_PlanoContas.dsPlanoConta,
                         dtlancto = Convert.ToDateTime(item.dtlancto).ToString("dd/MM/yyyy"),
                         vlConta = Convert.ToDecimal(item.vlConta).ToString("C"),
                         dtVencimento = Convert.ToDateTime(item.dtVencimento).ToString("dd/MM/yyyy"),
                         flBaixada = item.flBaixada.ToString(),
                         dtPagamentoOuRecebimento = item.dtPagamentoOuRecebimento == null ? "-" : Convert.ToDateTime(item.dtPagamentoOuRecebimento).ToString("dd/MM/yyyy"),
                         dsPlanoContas = item.PlanoContaID != null ? item.EB_PlanoContas.dsPlanoConta : null,
                         situacao = item.flBaixada == true ? "RECEBIDO" : "A RECEBER",
                         dsNomeCliente = item.EB_Cliente.dsNome,
                         vlPago = Convert.ToDecimal(item.fechaValorPago).ToString("C"),

                         //busca de datas
                         dtlancto2 = Convert.ToDateTime(item.dtlancto),
                         dtVencimento2 = Convert.ToDateTime(item.dtVencimento),
                         dtPagamentoOuRecebimento2 = item.dtPagamentoOuRecebimento == null ? null : item.dtPagamentoOuRecebimento

                     });


                    eB_ContasBindingSource.DataSource = null;
                    eB_ContasBindingSource.DataSource = query;


             }
             catch (Exception error)
             {

             }
            
        }


        public void paginacao()
        {
            try
            {

                somaTotalPago(); somaTotalAPagar(); 

                int pagina = Convert.ToInt32(ComboBoxPaginacao.Items.Count > 0 && ComboBoxPaginacao.Text != "" ? Convert.ToInt32(ComboBoxPaginacao.Text) : 1);
                int inicio;
                double TAMANHO_PAGINA = 500;


                if (pagina != 1)
                {
                    inicio = (pagina - 1) * Convert.ToInt32(TAMANHO_PAGINA);
                }
                else
                {
                    pagina = 1;
                    inicio = 0;
                }

                double count = query.Count();
                double total_paginas = Math.Ceiling(count / TAMANHO_PAGINA);


                var paged = query.Skip(inicio).Take(Convert.ToInt32(TAMANHO_PAGINA)).ToList();


               
                ComboBoxPaginacao.Items.Clear();
                if (paged.Count() > 0)
                {
                    //Monta Paginação
                    for (int i = 1; i <= total_paginas; i++)
                    {
                        string pg = i.ToString("D2");
                        ComboBoxPaginacao.Items.Add(pg);
                    }

                    eB_ContasDataGridView.Enabled = true;
                    eB_ContasBindingSource.DataSource = null;
                    eB_ContasBindingSource.DataSource = paged;

                    if (total_paginas > 1)
                    {
                        toolStripLabel3.Visible = true;
                        ComboBoxPaginacao.Visible = true;
                        eB_ContasBindingNavigator.Visible = true;
                    }
                    else
                    {
                        toolStripLabel3.Visible = false;
                        ComboBoxPaginacao.Visible = false;
                        eB_ContasBindingNavigator.Visible = false;
                    }
                }
                else
                {
                    eB_ContasDataGridView.Enabled = false;
                    eB_ContasBindingSource.DataSource = null;
                }



                var c = pagina.ToString("D2");
                ComboBoxPaginacao.SelectedText = c;

                MudaCorVencidos();

            }catch(Exception error)
            {

            }

  
        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            if (eB_ContasDataGridView.Rows.Count > 0)
            {

                int id = Convert.ToInt32(eB_ContasDataGridView.Rows[eB_ContasDataGridView.CurrentRow.Index].Cells[0].Value);

                frmContasReceberCadastro frm = new frmContasReceberCadastro();
                frm.frmContasReceberList = this;
                frm.id = id;
                frm.frmMain = this.frmMain;
                frm.ShowDialog();
            }
        }

        private void frmContasPagarList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.botaoBuscar_Click(null, null);
                    break;

            }
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            if (eB_ContasDataGridView.Rows.Count > 0)
            {
                BarTumEntities _context = new BarTumEntities();
                int id = Convert.ToInt32(eB_ContasDataGridView.Rows[eB_ContasDataGridView.CurrentRow.Index].Cells[0].Value);

                string message = "Você tem certeza que deseja excluir este registro?";
                string caption = "EasyBar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        var item = _context.EB_Contas.Single(a => a.contasID == id);

                        _context.DeleteObject(item);
                        _context.SaveChanges();
                        populaGridview();
                        this.ComboExibir_SelectedIndexChanged(null, null);

                        

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(this, "Não foi possível excluir este registro, pois existem registros dependentes a ele.", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void botaoBuscar_Click(object sender, EventArgs e)
        {

            string criterio = painel.Controls[4].Text;
            string tipoBusca = ComboTipoBusca.Text;
            try
            {

                ComboExibir_SelectedIndexChanged(null, null);


              
                DateTime control1 =  Convert.ToDateTime(painel.Controls[1].Text);
                DateTime control2 = Convert.ToDateTime(painel.Controls[3].Text);

                DateTime inicio = new DateTime(control1.Year, control1.Month, control1.Day, 0, 0, 0);
                DateTime fim = new DateTime(control2.Year, control2.Month, control2.Day, 23, 59, 59);

                switch(tipoBusca)
                {

                    case "TODOS OS CAMPOS":
                     query = query
                    .Where(a =>
                               a.contasID.Equals(criterio) ||
                               a.descricao.Contains(criterio) ||
                               a.dsPlanoConta.Contains(criterio) ||
                               a.dtlancto.Contains(criterio) ||
                               a.vlConta.Contains(criterio) ||
                               a.dtVencimento.Contains(criterio) ||
                               a.dtPagamentoOuRecebimento.Contains(criterio) ||
                               a.dsPlanoContas.Contains(criterio) ||
                               a.situacao.Contains(criterio) ||
                               a.dsNomeCliente.Contains(criterio)
                            );
                    break;

                    case "DT. VENCIMENTO":
                    query = query.Where(a => a.dtVencimento2 >= inicio && a.dtVencimento2 <= fim);

                    break;
                    case "DT. LANÇAMENTO":
                    query = query.Where(a => a.dtlancto2 >= inicio && a.dtlancto2 <= fim);
                    break;
                    case "DT. RECEBIMENTO":
                        query = query.Where(a => a.dtPagamentoOuRecebimento2 != null ? (a.dtPagamentoOuRecebimento2 >= (DateTime?)inicio && a.dtPagamentoOuRecebimento2 <= (DateTime?)fim) : false);
                    break;
              }
                
                
                paginacao();


            }
            catch (Exception error)
            {
            }
           
        }

        public void ComboExibir_SelectedIndexChanged(object sender, EventArgs e)
        {
            populaGridview();


            string criterio = ComboExibir.Text;
            switch(criterio)
            {
                case "EM ABERTO":
                    query = query.Where(a => a.flBaixada.Equals("False")).OrderBy(a => a.dtVencimento);
                    break;
                case "RECEBIDO":
                    query = query.Where(a => a.flBaixada.Equals("True")).OrderByDescending(a => a.dtPagamentoOuRecebimento);
                    break;
                default:
                   
                break;
            }

            paginacao();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void ComboTipoBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = ComboTipoBusca.Text;

            switch (criterio)
            {
                case "DT. LANÇAMENTO":
                    painel.Controls[0].Visible = true;
                    painel.Controls[1].Visible = true;
                    painel.Controls[2].Visible = true;
                    painel.Controls[3].Visible = true;
                    painel.Controls[4].Visible = false;
                    painel.Controls[5].Visible = true;
                    painel.Controls[1].Focus();
                    break;
                case "DT. VENCIMENTO":
                    painel.Controls[0].Visible = true;
                    painel.Controls[1].Visible = true;
                    painel.Controls[2].Visible = true;
                    painel.Controls[3].Visible = true;
                    painel.Controls[4].Visible = false;
                    painel.Controls[5].Visible = true;
                    painel.Controls[1].Focus();
                    break;
                case "DT. RECEBIMENTO":
                    painel.Controls[0].Visible = true;
                    painel.Controls[1].Visible = true;
                    painel.Controls[2].Visible = true;
                    painel.Controls[3].Visible = true;
                    painel.Controls[4].Visible = false;
                    painel.Controls[5].Visible = true;
                    painel.Controls[1].Focus();
                    break;
                case "TODOS OS CAMPOS":
                    painel.Controls[0].Visible = false;
                    painel.Controls[1].Visible = false;
                    painel.Controls[2].Visible = false;
                    painel.Controls[3].Visible = false;
                    painel.Controls[4].Visible = true;
                    painel.Controls[5].Visible = true;
                    painel.Controls[4].Focus();
                    break;
            }
        }

        private void ComboBoxPaginacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            paginacao();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (eB_ContasDataGridView.Rows.Count > 0)
            {
                int id = Convert.ToInt32(eB_ContasDataGridView.Rows[eB_ContasDataGridView.CurrentRow.Index].Cells[0].Value);

                frmContasReceberCadastro frm = new frmContasReceberCadastro();
                frm.frmContasReceberList = this;
                frm.id = id;
                frm.baixar = true;
                frm.ShowDialog();
            }
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            if (eB_ContasDataGridView.Rows.Count > 0)
            {

                int id = Convert.ToInt32(eB_ContasDataGridView.Rows[eB_ContasDataGridView.CurrentRow.Index].Cells[0].Value);

                frmContasReceberCadastro frm = new frmContasReceberCadastro();
                frm.frmContasReceberList = this;
                frm.consulta = true;
                frm.id = id;
                frm.ShowDialog();
            }
        }



        public void MudaCorVencidos()
        {

            try
            {

                DateTime dtVencimento;
                DateTime dataAtual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                DataGridViewCell coluna;
                DataGridViewCell colunaSituacao;

                

                 for (int i = 0; i < eB_ContasDataGridView.Rows.Count; i++)
                 {

                     coluna = eB_ContasDataGridView.Rows[i].Cells["dtVencimento"];
                     colunaSituacao = eB_ContasDataGridView.Rows[i].Cells["Situacao"];
                     dtVencimento = Convert.ToDateTime(coluna.Value);


                     if (dataAtual > dtVencimento && colunaSituacao.Value.Equals("A RECEBER"))
                     {
                         eB_ContasDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                     }
                 }

            }catch(Exception error)
            {

            }
        }

       

     
    }




     
}
