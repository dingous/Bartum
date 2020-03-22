using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarTum.Entities;


namespace BarTum.Utilities.Impressoes
{
    public class ImpressoesConta : Impressoes
    {



        public class retorno { public decimal? ProdutoID; public decimal Quantidade; public decimal nrPrecoVenda; public string dsProduto; public int nrUnidade; };
        public string geraConta(List<EB_LancamentoItens> itens)
        {

            decimal tipoVenda = itens[0].EB_Lancamento.TipoVendaID;

            

            IEnumerable<retorno> agrupamento;

            if (tipoVenda == 5)
            {


                agrupamento = (from item in itens.AsEnumerable()
                                   
                                   //orderby g.Key.dtDataHora ascending
                                    select new retorno
                                   { 
                                       
                                       ProdutoID = item.ProdutoID,
                                       Quantidade = item.Quantidade,
                                       nrPrecoVenda = item.nrPrecoVenda,
                                       dsProduto = item.EB_Produto.dsProduto,
                                       nrUnidade = item.EB_Produto.nrUnidade
                                   });
            }
            else
            {
                agrupamento = (from item in itens.AsEnumerable()
                                   group new { item } by new
                                   {
                                       item.ProdutoID,
                                       item.Quantidade,
                                       item.nrPrecoVenda,
                                       item.EB_Produto.dsProduto,
                                       item.EB_Produto.nrUnidade
                                   } into g
                                   //orderby g.Key.dtDataHora ascending
                                 select new retorno
                                   {
                                       ProdutoID = g.Key.ProdutoID,
                                       Quantidade = g.Sum(a => a.item.Quantidade),
                                       nrPrecoVenda = g.Key.nrPrecoVenda,
                                       dsProduto = g.Key.dsProduto,
                                       nrUnidade = g.Key.nrUnidade
                                   });
            }


            using (BarTumEntities context = new BarTumEntities())
            {
                string nova_string = "";
                int cont = 0;
                decimal total = 0;
                decimal totalItensPrSoma = 0;




                foreach (var item in agrupamento)
                {

                    string formataQuantidade = Convert.ToInt32(item.Quantidade).ToString("D2");
                    string formataPreco = Convert.ToDecimal(item.nrPrecoVenda).ToString("C2").Replace("R$ ", "").PadLeft(6);
                    if (item.nrUnidade == 0)
                    {
                        totalItensPrSoma = (Convert.ToInt32(item.Quantidade) * Convert.ToDecimal(item.nrPrecoVenda));
                    }
                    else if (item.nrUnidade == 1)
                    {
                        totalItensPrSoma = (Convert.ToDecimal(item.nrPrecoVenda));
                    }

                    string totalItensPr = totalItensPrSoma.ToString("C2").Replace("R$ ", "").PadLeft(6);

                    int inicio = 4;
                    int fim = (formataQuantidade.Length + formataPreco.Length + totalItensPr.Length); //fim é a soma de todas as string após a descrição do produto ou seja a quantidade e preco_produto
                    int meio = 0;

                    meio = totalcolunas - (inicio + fim);
                    meio = meio - 16; //a constante 12 é a quantidade de espaçamentos em branco entre as colunas
                    string separa = "";
                    separa = separa.PadRight(4, ' ');


                    string decricao_produto = item.dsProduto;


                    for (int i = 0; i < decricao_produto.Length; i++)
                    {

                        if (cont == 0)
                        {
                            nova_string += ("Cód." + separa + ("Produto").PadRight(meio, '.') + separa + "Qtd.." + "." + "Preço" +  separa + "Total" + "\n").Replace(" ", ".");
                            nova_string += geraSeparador("-");
                            nova_string += "\n";
                        }

                        if (i % meio == 0 )
                        {

                            if (i == 0)
                            {
                                int calcula = meio > decricao_produto.Length ? decricao_produto.Length : meio;
                                if (calcula == decricao_produto.Length)
                                {
                                    nova_string += Convert.ToInt32(item.ProdutoID).ToString("D4") + separa + decricao_produto.Substring(i, calcula).PadRight(meio, ' ') + separa + formataQuantidade + separa + formataPreco + separa + totalItensPr;
                                }
                                else
                                {
                                    nova_string += Convert.ToInt32(item.ProdutoID).ToString("D4") + separa + decricao_produto.Substring(i, calcula).PadRight(meio, ' ') + separa + formataQuantidade + separa + formataPreco + separa + totalItensPr + "\n" + separa;
                                }
                            }
                            else
                            {
                                int calcula = (decricao_produto.Length - i) < meio ? decricao_produto.Length - i : meio;

                                if (calcula == meio)
                                {
                                    nova_string += separa + decricao_produto.Substring(i, calcula).PadRight(meio, ' ') + separa + "\n" + separa;
                                }
                                else
                                {
                                    string str = separa + decricao_produto.Substring(i, calcula).PadRight(meio, ' ') + separa;
                                    nova_string += str;
                                }
                            }

                        }


                        cont++;

                    }

                    

                    total += totalItensPrSoma;

                    nova_string += "\n";

                }

               

                decimal idLancto = Convert.ToDecimal(itens[0].LanctoID);
                var parciais = context.EB_LancamentoAdiantamentos.Where(a => a.LanctoID == idLancto).OrderBy(a => a.dtDataHora);
                decimal taxaAdicional = 0;


                if (itens[0].EB_Lancamento.TipoVendaID == 1)
                {
                    if (context.EB_ConfiguracoesSistema.SingleOrDefault().flTaxaServicoAtiva == true)
                    {
                        taxaAdicional = ((total / 100) * Convert.ToDecimal(itens[0].EB_Lancamento.EB_Garcon.nrComissao));
                        nova_string += this.geraLinha("Taxa de serviço: + " + taxaAdicional.ToString("C2").Replace("R$ ", "").PadLeft(5), "right");
                    }
                    
                }
                else if (itens[0].EB_Lancamento.TipoVendaID == 3)
                {
                    taxaAdicional = Convert.ToDecimal(itens[0].EB_Lancamento.EB_Cliente.EB_Endereco.EB_Bairro.nrTaxaEntrega);
                    nova_string += this.geraLinha("Taxa de entrega: + " + itens[0].EB_Lancamento.EB_Cliente.EB_Endereco.EB_Bairro.nrTaxaEntrega.ToString("C2").Replace("R$ ", "").PadLeft(5), "right");
                    
                }

                nova_string += this.geraSeparador("-");
                nova_string += "\n";

                nova_string += this.geraLinha("Vl. total da conta: " + (total + taxaAdicional).ToString("C2").Replace("R$ ", "").PadLeft(5), "right");
                nova_string += "\n";

                decimal totalParciais = 0;
                foreach (var parc in parciais)
                {
                    nova_string += this.geraLinha("Pgto. parcial às " + parc.dtDataHora.ToString("H:mm") + ": - " + parc.vlRecebidoCliente.ToString("C2").Replace("R$ ", "").PadLeft(5), "right");
                    nova_string += "\n";
                    totalParciais += parc.vlRecebidoCliente;
                }


                decimal totalPagar = (total - totalParciais) + taxaAdicional;

              
                nova_string += this.geraSeparador("-");
                nova_string += "\n";
                nova_string += this.geraLinha("Total a pagar => " + totalPagar.ToString("C2").Replace("R$ ", "").PadLeft(5), "right");

                return nova_string;
            }
            
        }





    }
}
