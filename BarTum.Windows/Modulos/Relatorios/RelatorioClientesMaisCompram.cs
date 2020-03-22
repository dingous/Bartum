using BarTum.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BarTum.Windows.Modulos.Relatorios
{
    public partial class RelatorioClientesMaisCompram : Form
    {
        public RelatorioClientesMaisCompram()
        {
            InitializeComponent();
        }



        public List<EB_TipoVenda> populaCombo()
        {
            EB_TipoVenda geral = new EB_TipoVenda();
            geral.dsTipoVenda = "GERAL";
            geral.TipoVendaID = 0;


            BarTumEntities contexto = new BarTumEntities();
            var lista = contexto.EB_TipoVenda.OrderBy(a => a.dsTipoVenda).ToList();
            lista.Add(geral);
            return lista;
        }

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
            BuscaDtInicial.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);


            Label labelDtFinal = new Label();
            labelDtFinal.Name = "labelDtFinal";
            labelDtFinal.Text = " Até: ";
            labelDtFinal.AutoSize = true;
            labelDtFinal.TextAlign = ContentAlignment.MiddleRight;
            labelDtFinal.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);

            DateTimePicker BuscaDtFinal = new DateTimePicker();
            BuscaDtFinal.Name = "BuscaDtFinal";
            BuscaDtFinal.CustomFormat = "dd/MM/yyyy";
            BuscaDtFinal.Format = DateTimePickerFormat.Short;
            BuscaDtFinal.Width = 100;
            BuscaDtFinal.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);



            Label labelCombo = new Label();
            labelCombo.Name = "labelCombo";
            labelCombo.Text = " Filtrar por: ";
            labelCombo.AutoSize = true;
            labelCombo.TextAlign = ContentAlignment.MiddleRight;
            labelCombo.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            labelCombo.Visible = false;

            ComboBox cbbox = new ComboBox();
            cbbox.Name = "ComboBoxTipo";
            cbbox.AutoSize = true;
            cbbox.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            cbbox.ValueMember = "TipoVendaID";
            cbbox.DisplayMember = "dsTipoVenda";
            cbbox.DataSource = this.populaCombo();
            cbbox.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox.Visible = false;



            Button botao = new Button();
            botao.Image = global::BarTum.Windows.Properties.Resources.search;
            botao.Location = new System.Drawing.Point(200, 71);
            botao.Name = "botaoBuscar";
            botao.Size = new System.Drawing.Size(32, 30);
            botao.UseVisualStyleBackColor = true;
            botao.Click += new EventHandler(botao_Click);

            TextBox txtCriterio = new TextBox();
            txtCriterio.Name = "botaoBuscar";
            txtCriterio.Width = 250;
            txtCriterio.Visible = false;
            txtCriterio.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            txtCriterio.CharacterCasing = CharacterCasing.Upper;
            //txtCriterio.KeyDown += new KeyEventHandler(txtCriterio_KeyDown);

            painel.Controls.AddRange(new System.Windows.Forms.Control[] {
                LabelDtInicial,
                BuscaDtInicial,
                labelDtFinal,
                BuscaDtFinal,
                txtCriterio,
                labelCombo,
                cbbox,
                botao
            });

            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                   new ToolStripControlHost(painel)    
            });

        }

        void botao_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            DateTimePicker inicio = (DateTimePicker)x.Parent.Controls[1];
            //var fim = (DateTimePicker)x.Parent.Controls[3];

            var ini = inicio.Value;

            BarTumEntities contexto = new BarTumEntities();

            ComboBox cb = (ComboBox)painel.Controls[6];
            decimal tipoVenda = Convert.ToDecimal(cb.SelectedValue);

            DateTime control1 = Convert.ToDateTime(painel.Controls[1].Text);
            DateTime control2 = Convert.ToDateTime(painel.Controls[3].Text);
            //decimal tipoVenda = Convert.ToDecimal(painel.Controls[5].Text);
            DateTime? inicial = new DateTime(control1.Year, control1.Month, control1.Day, 0, 0, 0);
            DateTime? final = new DateTime(control2.Year, control2.Month, control2.Day, 23, 59, 59);

           
            DateTime iniData = Convert.ToDateTime(inicial).Date;
            DateTime fimData = Convert.ToDateTime(final).Date;
            ObjectResult<PR_VENDAS_CLIENTES_Result> vendas = contexto.PR_VENDAS_CLIENTES(iniData, fimData);


            pRVENDASCLIENTESResultBindingSource.DataSource = vendas;

            somaLinhas();

        }


        public void somaLinhas()
        {

            TotalPendentes.Text = "R$ 0,00";

            int totalLinhas = eB_ProdutoDataGridView.Rows.Count;


            if (totalLinhas > 0)
            {
                decimal soma = 0;
                for (int i = 0; i < totalLinhas; i++)
                {
                    if (eB_ProdutoDataGridView.Rows[i].Cells["Total"].Value != null)
                    {
                        soma += Convert.ToDecimal(eB_ProdutoDataGridView.Rows[i].Cells["Total"].Value);
                    }

                }

                TotalPendentes.Text = soma.ToString("C2");
            }
        }

        private void RelatorioVendas_Load(object sender, EventArgs e)
        {
            controlesBusca();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
