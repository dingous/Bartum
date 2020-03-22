using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;

namespace BarTum.Windows.Modulos.Atendimento
{
    public partial class frmHistoricoCliente : Form
    {
        public decimal? idCliente;
        public int anoContexto;
        public frmAtendimento frmAtendimento;

        public frmHistoricoCliente()
        {
            InitializeComponent();
          
        }

        public string retornaNomeMes(int mes)
        {
            string m = "";
            switch(mes)
            {
                case 1:
                    m = "Janeiro";
                    break;
                case 2:
                    m = "Fevereiro";
                    break;
                case 3:
                    m = "Março";
                    break;
                case 4:
                    m = "Abril";
                    break;
                case 5:
                    m = "Maio";
                    break;
                case 6:
                    m = "Junho";
                    break;
                case 7:
                    m = "Julho";
                    break;
                case 8:
                    m = "Agosto";
                    break;
                case 9:
                    m = "Setembro";
                    break;
                case 10:
                    m = "Outubro";
                    break;
                case 11:
                    m = "Novembro";
                    break;
                case 12:
                    m = "Dezembro";
                    break;       
            }

            return m;
        }

        public List<int> retornaAnosVenda()
        {
            this.idCliente = Convert.ToDecimal(frmAtendimento.VendaPedido.ClienteID.Text);
            BarTumEntities contexto = new BarTumEntities();

            var anos = (from lancto in contexto.EB_Lancamento
                         where
                             lancto.ClienteID == this.idCliente
                             && lancto.TipoVendaID == 3 && lancto.flVendaCancelada == false
                         group new { lancto } by new
                         {
                             ((DateTime)lancto.dtLancto).Year

                         } into g
                         orderby g.Key.Year descending
                         select new
                         {
                             ano = g.Key.Year
                         }
                          );

            List<int> lista = new List<int>();
            foreach (var ano in anos.ToList())
            {
                lista.Add(ano.ano);
            }


            return lista;
        }

        public List<int> retornaMesesVenda()
        {
            BarTumEntities contexto = new BarTumEntities();

            this.idCliente = Convert.ToDecimal(frmAtendimento.VendaPedido.ClienteID.Text);

            var meses = (from lancto in contexto.EB_Lancamento
                          where
                              lancto.ClienteID == this.idCliente && ((DateTime)lancto.dtLancto).Year == this.anoContexto
                              && lancto.TipoVendaID == 3 && lancto.flVendaCancelada == false
                          group new { lancto } by new
                          {
                              ((DateTime)lancto.dtLancto).Month

                          } into g
                         orderby g.Key.Month descending
                          select new
                          {
                              mes = g.Key.Month
                          }
                          );

            List<int> lista = new List<int>();
            foreach (var mes in meses.ToList())
            {
                lista.Add(mes.mes);
            }


            return lista;
        }
        
        public List<string> retornaDiasVenda(int m)
        {
            BarTumEntities contexto = new BarTumEntities();

            this.idCliente = Convert.ToDecimal(frmAtendimento.VendaPedido.ClienteID.Text);

            var dias = (from lancto in contexto.EB_Lancamento
                        where lancto.ClienteID == this.idCliente && ((DateTime)lancto.dtLancto).Month == m && ((DateTime)lancto.dtLancto).Year == this.anoContexto
                        && lancto.TipoVendaID == 3 && lancto.flVendaCancelada == false
                             group new { lancto } by new
                             {
                                  ((DateTime)lancto.dtLancto).Day
                             } into g
                            orderby g.Key.Day ascending
                             select new
                             {
                                 dia = g.Max(p => p.lancto.dtLancto),
                                 total = g.Sum(a => a.lancto.LanctoID)
                             }
                          );

            List<string> lista = new List<string>();
            foreach (var dia in dias.ToList())
            {
                lista.Add(dia.dia.ToString());
            }


            return lista;
        }

        private void frmHistoricoCliente_Load(object sender, EventArgs e)
        {
            List<int> anos = retornaAnosVenda();
            comboBoxAnos.DataSource = anos;


            if(anos.Count == 0)
            {
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult res2;
                res2 = MessageBox.Show(this, "Nenhuma venda foi efetuada para este cliente", "BarTum", buttons2,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            this.anoContexto = anos[0];
            populaLista();
           
        }

        void label2_LostFocus(object sender, EventArgs e)
        {
            Label tb = (Label)sender;
            tb.Font = new Font(tb.Font, FontStyle.Regular);
            tb.BackColor = Color.White;
        }

        void label2_GotFocus(object sender, EventArgs e)
        {
            Label tb = (Label)sender;
            tb.Font = new Font(tb.Font, FontStyle.Bold);
            tb.BackColor = Color.Wheat;
        }

        void label2_Click(object sender, EventArgs e)
        {
            BarTumEntities contexto = new BarTumEntities();
            Label lbl = (Label)sender;
            DateTime data = Convert.ToDateTime(lbl.Text);
            lblshowdata.Text = lbl.Text;
            DateTime? inicial = new DateTime(data.Year, data.Month, data.Day, 0, 0, 0);
            DateTime? final = new DateTime(data.Year, data.Month, data.Day, 23, 59, 59);
            var vendas = (from itens in contexto.EB_LancamentoItens
                            join lancto in contexto.EB_Lancamento on new { LanctoID = (Decimal)itens.LanctoID } equals new { LanctoID = lancto.LanctoID }
                            join produto in contexto.EB_Produto on new { ProdutoID = (Decimal)itens.ProdutoID } equals new { ProdutoID = produto.ProdutoID }
                            where
                                lancto.flVendaCancelada == false
                                && lancto.StatusID == 3
                                && lancto.dtLancto >= inicial && lancto.dtLancto <= final
                                && lancto.ClienteID == this.idCliente
                            group new { itens, produto } by new
                            {
                                itens.ProdutoID
                            } into g
                            orderby g.Key.ProdutoID ascending
                            select new
                            {
                                ProdutoID = (Decimal?)g.Key.ProdutoID,
                                dsObservacao = g.Max(p => p.produto.dsProduto),
                                nrPrecoVenda = (Decimal?)g.Max(p => p.itens.nrPrecoVenda),
                                Quantidade = (Decimal?)g.Sum(p => p.itens.Quantidade),
                                Total = (Decimal?)g.Sum(p => p.itens.Total),
                                TipoVenda = (Decimal?)g.Max(p => p.itens.EB_Lancamento.TipoVendaID)
                            });

            eB_LancamentoItensBindingSource.DataSource = vendas;
            gdvItensVendidos.DataSource = eB_LancamentoItensBindingSource;

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void populaLista()
        {
            flowLayoutPanelDatas.Controls.Clear();

            List<int> meses = this.retornaMesesVenda();
            foreach (int mes in meses)
            {
                Label label = new Label();
                label.Name = "LabelDtInicial";
                label.Text = retornaNomeMes(mes);
                label.Width = 265;
                label.BackColor = Color.Gray;
                label.ForeColor = Color.White;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);

                flowLayoutPanelDatas.Controls.AddRange(new System.Windows.Forms.Control[] {
                    label
                });

                foreach (var dia in retornaDiasVenda(mes))
                {
                    Label label2 = new Label();
                    label2.Name = "LabelDtInicial";
                    label2.Text = Convert.ToDateTime(dia).ToString("dd/MM/yyyy");
                    label2.Width = 265;
                    label2.BackColor = Color.White;
                    label2.ForeColor = Color.Black;
                    label2.TextAlign = ContentAlignment.MiddleLeft;
                    label2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
                    label2.Click += new EventHandler(label2_Click);
                    label2.MouseHover += new EventHandler(label2_GotFocus);
                    label2.MouseLeave += new EventHandler(label2_LostFocus);

                    flowLayoutPanelDatas.Controls.AddRange(new System.Windows.Forms.Control[] {
                    label2
                });
                }

               
            }
        }

        private void comboBoxAnos_SelectedValueChanged(object sender, EventArgs e)
        {
            this.anoContexto = Convert.ToInt32(comboBoxAnos.SelectedValue);
            populaLista();
        }
    }
}
