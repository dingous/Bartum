using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarTum.Utilities.Impressoes
{
    public  class ImpressoesPedido : Impressoes
    {


        public  string geraPedido(int codigo, string decricao_produto, int quantidade, double preco_produto, int indice)
        {

            string formataQuantidade = quantidade.ToString("D2");
            string formataPreco = preco_produto.ToString("C2").Replace("R$ ", "");

            int inicio = 4;
            int fim = (formataQuantidade.Length); //fim é a soma de todas as string após a descrição do produto ou seja a quantidade e preco_produto
            int meio = 0;
            string nova_string = "";
            meio = totalcolunas - (inicio + fim);
            meio = meio - 12; //a constante 12 é a quantidade de espaçamentos entre as colunas
            string separa = "";
            separa = separa.PadRight(4, ' ');


           if(indice == 0)
           {
                nova_string += ("Cód." + separa + ("Produto").PadRight(meio, '.') + separa + "Qtd.\n").Replace(" ", ".");
                nova_string += geraSeparador("-");
                nova_string += "\n";
           }

            for (int i = 0; i < decricao_produto.Length; i++)
            {
                if (i % meio == 0)
                {

                    if (i == 0)
                    {
                        int calcula = meio > decricao_produto.Length ? decricao_produto.Length : meio;
                        if (calcula == decricao_produto.Length)
                        {
                            nova_string += codigo.ToString("D4") + separa + decricao_produto.Substring(i, calcula).PadRight(meio, ' ') + separa + formataQuantidade + "";
                        }
                        else
                        {
                            nova_string += codigo.ToString("D4") + separa + decricao_produto.Substring(i, calcula).PadRight(meio, ' ') + separa + formataQuantidade + "\n" + separa;
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
                            nova_string += separa + decricao_produto.Substring(i, calcula).PadRight(meio, ' ') + separa;
                        }
                    }

                }

            }


            return nova_string;
        }


    }
}
