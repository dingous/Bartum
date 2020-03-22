using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BarTum.Utilities.Impressoes
{
    public class  Impressoes
    {

        public int totalcolunas; 
        public bool aceitaAcentuacao = false;


        
        public string quebraLinha(string str, string alinhamento = "left")
        {
            int tamanhoString = str.Length;
            string novaString = "";
            for (int i = 0; i < (tamanhoString); i++ )
            {
               
                if (i % (totalcolunas-1) == 0 && i != 0)
                {
                    novaString += str[i] + "\n";
                }
                else
                {
                    novaString += str[i];
                }
            }

            int dif = totalcolunas - str.Length;
            int div = dif / 2;
            //função passar para positivo Math.Abs()
            switch (alinhamento)
            {
                case "left":
                    novaString = novaString.PadRight(totalcolunas, ' ');
                    break;
                case "right":
                    novaString = novaString.PadLeft(totalcolunas, ' ');
                    break;
                case "center":
                    novaString = novaString.PadLeft((div + str.Length), ' ');
                    break;
            }

            return novaString;
        }


        public string geraLinha(string str, string alinhamento = "left")
        {
            return quebraLinha(str, alinhamento);
        }

        public string geraSeparador(string separador)
        {
            string nova_string = "";
            for (int i = 0; i < (totalcolunas); i++)
            {
                nova_string += separador;
            }
            return nova_string;
        }


        public string TirarAcentos(string texto)
        {
            string textor = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i].ToString() == "ã") textor += "a";
                else if (texto[i].ToString() == "á") textor += "a";
                else if (texto[i].ToString() == "à") textor += "a";
                else if (texto[i].ToString() == "â") textor += "a";
                else if (texto[i].ToString() == "ä") textor += "a";
                else if (texto[i].ToString() == "é") textor += "e";
                else if (texto[i].ToString() == "è") textor += "e";
                else if (texto[i].ToString() == "ê") textor += "e";
                else if (texto[i].ToString() == "ë") textor += "e";
                else if (texto[i].ToString() == "í") textor += "i";
                else if (texto[i].ToString() == "ì") textor += "i";
                else if (texto[i].ToString() == "ï") textor += "i";
                else if (texto[i].ToString() == "õ") textor += "o";
                else if (texto[i].ToString() == "ó") textor += "o";
                else if (texto[i].ToString() == "ò") textor += "o";
                else if (texto[i].ToString() == "ö") textor += "o";
                else if (texto[i].ToString() == "ú") textor += "u";
                else if (texto[i].ToString() == "ù") textor += "u";
                else if (texto[i].ToString() == "ü") textor += "u";
                else if (texto[i].ToString() == "ç") textor += "c";
                else if (texto[i].ToString() == "Ã") textor += "A";
                else if (texto[i].ToString() == "Á") textor += "A";
                else if (texto[i].ToString() == "À") textor += "A";
                else if (texto[i].ToString() == "Â") textor += "A";
                else if (texto[i].ToString() == "Ä") textor += "A";
                else if (texto[i].ToString() == "É") textor += "E";
                else if (texto[i].ToString() == "È") textor += "E";
                else if (texto[i].ToString() == "Ê") textor += "E";
                else if (texto[i].ToString() == "Ë") textor += "E";
                else if (texto[i].ToString() == "Í") textor += "I";
                else if (texto[i].ToString() == "Ì") textor += "I";
                else if (texto[i].ToString() == "Ï") textor += "I";
                else if (texto[i].ToString() == "Õ") textor += "O";
                else if (texto[i].ToString() == "Ó") textor += "O";
                else if (texto[i].ToString() == "Ò") textor += "O";
                else if (texto[i].ToString() == "Ö") textor += "O";
                else if (texto[i].ToString() == "Ú") textor += "U";
                else if (texto[i].ToString() == "Ù") textor += "U";
                else if (texto[i].ToString() == "Ü") textor += "U";
                else if (texto[i].ToString() == "Ç") textor += "C";
                else textor += texto[i];
            }
            return textor;
        }





        public String OpenCashDrawer()
        {

            StringBuilder sequence = new StringBuilder();

            sequence.Append((char)27);

            sequence.Append((char)112);

            sequence.Append((char)0);

            sequence.Append((char)25);

            sequence.Append((char)250);



            return sequence.ToString();

        }



        public String InitializePrinter()
        {

            StringBuilder sequence = new StringBuilder();

            sequence.Append((char)27);

            sequence.Append((char)64);



            return sequence.ToString();

        }

        public String PrintCenterText()
        {

            //The printer will continue printing at center

            StringBuilder sequence = new StringBuilder();

            sequence.Append((char)27);

            sequence.Append((char)97);

            sequence.Append((char)1);



            return sequence.ToString();

        }

        public String PrintLeftText()
        {

            //The printer will continue printing at left

            StringBuilder sequence = new StringBuilder();

            sequence.Append((char)27);

            sequence.Append((char)97);

            sequence.Append((char)0);



            return sequence.ToString();

        }

        public String CutPaper()
        {

            StringBuilder sequence = new StringBuilder();

           

            sequence.Append((char)27);

            sequence.Append((char)105);

            sequence.Append((char)0);

            sequence.Append((char)25);



            return sequence.ToString();

        }



        public String FeedPaper(int pNumLines)
        {

            StringBuilder sequence = new StringBuilder();

            sequence.Append((char)27);

            sequence.Append((char)100);

            sequence.Append((char)pNumLines);



            return sequence.ToString();

        }


    }
}
