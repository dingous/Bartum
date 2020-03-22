using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarTum.Entities;
using System.Windows.Forms;
using System.Data.Objects.SqlClient;

namespace BarTum.Windows.Modulos.Caixa
{
   public class Caixa
    {
        
        public DateTime data = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        public DateTime dataHora = DateTime.Now;

        private EB_Caixa caixaObjContexto_;
        public EB_Caixa caixaObjContexto { get { return caixaObjContexto_; } set { caixaObjContexto_ = value; } }
       
        private decimal caixaContexto_;
        public decimal caixaContexto { get { return caixaContexto_; } set { caixaContexto_ = value; } }

        private DateTime caixaDataAberturaContexto_;
        public DateTime caixaDataAberturaContexto { get { return caixaDataAberturaContexto_; } set { caixaDataAberturaContexto_ = value; } }
       
        public bool primeiroAcessoAoCaixa = false;
        public frmMain frmMain;


        public bool CaixaAtivo = false;


        public  void verificaAbertos(bool exibe_alerta = true)
        {
            try
            {

                BarTumEntities _context = new BarTumEntities();
                DateTime inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                DateTime fim = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

                var queryFirst = _context.EB_Caixa.ToList().Count;

                if (queryFirst == 0)
                {
                    primeiroAcessoAoCaixa = true;
                    return;
                }


                /*var query = (from item in _context.EB_Caixa
                             orderby item.dtCaixa ascending
                             where item.dtCaixa < inicio
                             select new
                             {
                                 item
                             }
                             ).ToList();*/

                var query = (
                          from item in _context.EB_CaixaHistoricoFechamento
                          orderby item.dtCaixaAbertura descending
                          where item.dsStatus == "aberto" && item.EB_Caixa.dtCaixa < inicio
                          select new
                          {
                              item
                          }
                          )
                          .ToList();


                if (query.Count > 0)
                {
                    string dataspendentes = "";
                    foreach (var datas_pendentes in query)
                    {
                        dataspendentes += Convert.ToDateTime(datas_pendentes.item.EB_Caixa.dtCaixa).ToString("dd/MM/yyyy") + " ";
                    }

                    if (exibe_alerta == true)
                    {
                        string msg = "O caixa da data " + dataspendentes + "não foi fechado, deseja fechá-lo?";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult res = MessageBox.Show(msg, "BarTum", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                        if (res == DialogResult.Yes)
                        {
                            fecharCaixa(Convert.ToDecimal(query[0].item.CaixaID));
                        }
                    }
             

                    this.caixaContexto_ = Convert.ToDecimal(query[0].item.CaixaID);
                    this.caixaDataAberturaContexto = Convert.ToDateTime(query[0].item.dtCaixaAbertura);
                    this.caixaObjContexto = query[0].item.EB_Caixa;
                    this.CaixaAtivo = true;

                }
                else 
                {
                
                    /*var query2 = (from item in _context.EB_Caixa
                              orderby item.dtCaixa ascending
                              where item.dsStatus == "aberto"
                              && item.dtCaixa >= inicio && item.dtCaixa <= fim
                              select new
                              {
                                  item
                              }
                      ).ToList();*/

                    var query2 = (
                           from item in _context.EB_CaixaHistoricoFechamento
                           orderby item.dtCaixaAbertura descending
                           where item.dsStatus == "aberto"
                           select new
                           {
                               item
                           }
                           )
                           .ToList();



                if (query2.Count == 0)
                {
                    string msg = "Deseja abrir o caixa na data de hoje?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult res = MessageBox.Show(msg, "BarTum", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                    if (res == DialogResult.Yes)
                    {
                        abreCaixa();
                    }
                }
                else
                {
                    this.caixaContexto_ = Convert.ToDecimal(query2[0].item.CaixaID);
                    this.caixaDataAberturaContexto = Convert.ToDateTime(query2[0].item.dtCaixaAbertura);
                    this.caixaObjContexto = query2[0].item.EB_Caixa;
                    this.CaixaAtivo = true;
                }
                return;
                }

            }catch(Exception error)
            {


            }
        }


        public void abreCaixa()
        {
            BarTumEntities _context = new BarTumEntities();
            //var ultimoCaixa = _context.EB_Caixa.OrderByDescending(a => a.dtCaixa).ToList()[0];
            frmMain.CaixaConfirmacao();
        }


        public void fecharCaixa(decimal CaixaID)
        {
            BarTumEntities _context = new BarTumEntities();

            var Caixa = _context.EB_Caixa.Single(cl => cl.CaixaID == CaixaID);
            this.caixaContexto_ = Caixa.CaixaID;
            this.caixaDataAberturaContexto_ = Caixa.dtCaixa;
            frmMain.fecharCaixa();
        }

    }
}
