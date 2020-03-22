using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Entities;
using BarTum.Utilities;
using BarTum.Windows.Modulos.Cliente;
using BarTum.Windows.Modulos.Impressao;
using System.Drawing.Printing;
using System.Xml;
using System.Drawing;



namespace BarTum.Windows.Modulos.Configuracoes
{
    public partial class frmConfiguracoesSistema : Form
    {

        public BarTumEntities _context = new BarTumEntities();

        public frmConfiguracoesSistema()
        {
            InitializeComponent();        
        }



        public List<string> populaImpressoras()
        {
            PrinterSettings.StringCollection lista;
            List<string> printers = new List<string>();

            try
            {

                foreach (string printerName in PrinterSettings.InstalledPrinters)
                {
                    PrinterSettings printer = new PrinterSettings();
                    printer.PrinterName = printerName;
                    if (!(printer.IsDefaultPrinter))
                    {
                        printers.Add(printerName);
                    }
                    else
                    {
                        //printers.Add(printerName + (" (Impressora padrão do windows)"));
                        printers.Add(printerName);
                    }
                    
                }

            }catch(Exception error)
            {

            }

            return printers;
        }

        public void PopulaOrigens()
        {

            BarTumEntities context = new BarTumEntities();



            int x = 6;
            int y = 6;

            int x_ = 6;
            int y_ = 34;



            int x_groupBox = 330;
            int y_groupBox = 20;

            int cont = 0;

            var item = (from a in context.EB_OrigemProduto orderby a.dsOrigem ascending select a).ToList();

  

            foreach (var formas in item)
            {

                Label label;
                ComboBox DynButton;
                GroupBox GroupBox;
                Control ControlObject;
                Control ControlObject2;
                Control ControlObject3_GroupBox;


                string ControlType = "System.Windows.Forms.ComboBox";
                string ControlType2 = "System.Windows.Forms.Label";
                string ControlType3_GroupBox = "System.Windows.Forms.GroupBox";
                string ControlName = "combobox" + formas.OrigemID;
                string ControlName2 = "label" + formas.OrigemID;
                string ControlName3_GroupBox = "groupbox" + formas.OrigemID;


                System.Reflection.Assembly asm;
                asm = typeof(Form).Assembly;
                ControlObject = (System.Windows.Forms.Control)asm.CreateInstance(ControlType);
                ControlObject.Name = ControlName;
                ControlObject.Location = new System.Drawing.Point(x, y);

                System.Reflection.Assembly asm2;
                asm2 = typeof(Form).Assembly;
                ControlObject2 = (System.Windows.Forms.Control)asm2.CreateInstance(ControlType2);
                ControlObject2.Name = ControlName2;
                ControlObject2.Location = new System.Drawing.Point(x_, y_);


                System.Reflection.Assembly asm3;
                asm3 = typeof(Form).Assembly;
                ControlObject3_GroupBox = (System.Windows.Forms.Control)asm3.CreateInstance(ControlType3_GroupBox);
                ControlObject3_GroupBox.Name = ControlName3_GroupBox;
                ControlObject3_GroupBox.Location = new System.Drawing.Point(x_groupBox, y_groupBox);
                

                
                
                panelImpressoras.Controls.Add(ControlObject2);
                panelImpressoras.Controls.Add(ControlObject);
                panelImpressoras.Controls.Add(ControlObject3_GroupBox);
               


                label = (System.Windows.Forms.Label)ControlObject2;
                label.Text = "IMPRESSORA " + formas.dsOrigem;
                label.Font = new Font(("Microsoft Sans Serif"), 8, FontStyle.Bold);
                label.Width = 300;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Location = new Point(x, y);




                DynButton = (System.Windows.Forms.ComboBox)ControlObject;
                DynButton.Width = 300;
                DynButton.Text = "";
                DynButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                DynButton.Location = new Point(x_, y_);
                DynButton.DataSource = populaImpressoras();
                DynButton.Text = "";
                if (formas.dsImpressora != null)
                {
                    //DynButton.SelectedText = formas.dsImpressora;
                    DynButton.Text = formas.dsImpressora;
                }



                GroupBox = (System.Windows.Forms.GroupBox)ControlObject3_GroupBox;
                GroupBox.Text = "Colunas por linha";
                GroupBox.Font = new Font(("Microsoft Sans Serif"), 8, FontStyle.Regular);
                GroupBox.Width = 250;
                GroupBox.Height = 41;
                GroupBox.Location = new Point(x_groupBox, y_groupBox);
                GroupBox.FlatStyle = FlatStyle.Flat;


             
                Control ControlObject4_TextBox;
                Control ControlObject5_Label;
                Control ControlObject5_LabelAcentuacao;
                Control ControlObject5_CheckBoxAcentuacao;
                TextBox TextBoxmm;
                CheckBox cheboxAcentuacao;
                Label LabelTextBoxmm;
                Label LabelTextBoxAcentuacao;

                string ControlType4_textBoxmm = "System.Windows.Forms.TextBox";
                string ControlType4_CheckBox = "System.Windows.Forms.CheckBox";
                string ControlType5_LabeltextBoxmm = "System.Windows.Forms.Label";
                string ControlType5_LabeltextBoxAcentuacao = "System.Windows.Forms.Label";
                string ControlName4_textBoxmm = "textBoxmm" + formas.OrigemID;
                string ControlName5_textBoxmm = "LabeltextBoxmm" + formas.OrigemID;
                string ControlName5_textBoxAcentuacao = "LabeltextBoxAcentuacao" + formas.OrigemID;
                string ControlName5_CheckBoxAcentuacao = "CheckBoxAcentuacao" + formas.OrigemID;


                System.Reflection.Assembly asm4;
                asm4 = typeof(Form).Assembly;
                ControlObject4_TextBox = (System.Windows.Forms.Control)asm4.CreateInstance(ControlType4_textBoxmm);
                ControlObject4_TextBox.Name = ControlName4_textBoxmm;
                ControlObject4_TextBox.Location = new System.Drawing.Point(10, 14);
                TextBoxmm = (System.Windows.Forms.TextBox)ControlObject4_TextBox;
                TextBoxmm.Text = formas.tamanhoPapelImpressoraMilimetros.ToString();
                TextBoxmm.Width = 30;
                TextBoxmm.TextAlign = HorizontalAlignment.Center;
                TextBoxmm.TextChanged += new EventHandler(TextBoxmm_TextChanged);

                System.Reflection.Assembly asm5;
                asm5 = typeof(Form).Assembly;
                ControlObject5_Label = (System.Windows.Forms.Control)asm5.CreateInstance(ControlType5_LabeltextBoxmm);
                ControlObject5_Label.Name = ControlName5_textBoxmm;
                ControlObject5_Label.Location = new System.Drawing.Point(40, 18);
                LabelTextBoxmm = (System.Windows.Forms.Label)ControlObject5_Label;
                LabelTextBoxmm.Text = "colunas";
                LabelTextBoxmm.Size = new System.Drawing.Size(40, 14);


                System.Reflection.Assembly asm6;
                asm6 = typeof(Form).Assembly;
                ControlObject5_LabelAcentuacao = (System.Windows.Forms.Control)asm6.CreateInstance(ControlType5_LabeltextBoxAcentuacao);
                ControlObject5_LabelAcentuacao.Name = ControlName5_textBoxAcentuacao;
                ControlObject5_LabelAcentuacao.Location = new System.Drawing.Point(125, 18);
                LabelTextBoxAcentuacao = (System.Windows.Forms.Label)ControlObject5_LabelAcentuacao;
                LabelTextBoxAcentuacao.Text = "";
                LabelTextBoxAcentuacao.Size = new System.Drawing.Size(120, 14);


                System.Reflection.Assembly asm7;
                asm7 = typeof(Form).Assembly;
                ControlObject5_CheckBoxAcentuacao = (System.Windows.Forms.Control)asm7.CreateInstance(ControlType4_CheckBox);
                ControlObject5_CheckBoxAcentuacao.Name = ControlName5_CheckBoxAcentuacao;
                ControlObject5_CheckBoxAcentuacao.Location = new System.Drawing.Point(110, 15);
                cheboxAcentuacao = (System.Windows.Forms.CheckBox)ControlObject5_CheckBoxAcentuacao;
                cheboxAcentuacao.Text = "possui acentuação?";
                cheboxAcentuacao.Size = new System.Drawing.Size(130, 18);


                if (formas.flPossuiAcentuacao != null && formas.flPossuiAcentuacao == true)
                {
                    cheboxAcentuacao.Checked = true;
                }

                                
                GroupBox.Controls.Add(ControlObject4_TextBox);
                GroupBox.Controls.Add(ControlObject5_Label);
                GroupBox.Controls.Add(ControlObject5_CheckBoxAcentuacao);
                //GroupBox.Controls.Add(ControlObject5_LabelAcentuacao);



                if (cont % 1 == 0)
                {
                    y = y + 60;
                    y_ = y_ + 60;
                    y_groupBox = y_groupBox + 60;
                }

                cont = cont + 1;

            }


        }

        void TextBoxmm_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string texto = textBox.Text;
            int valor = 0;

            try
            {
                valor = Convert.ToInt32(texto);
            }catch
            {
                textBox.Text = "";
            }
            
        }



        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                BarTumEntities context = new BarTumEntities();

                //context.Refresh(System.Data.Objects.RefreshMode.ClientWins, this);

                Control.ControlCollection controles = panelImpressoras.Controls;
                foreach (Control item in controles)
                {

                    string tipoControle = item.GetType().Name;

                    if (tipoControle == "ComboBox")
                    {
                        Control con = (ComboBox)item;

                        decimal idOrigem = Convert.ToDecimal(con.Name.Replace("combobox", ""));
                        var origem = context.EB_OrigemProduto.Single(cl => cl.OrigemID == idOrigem);
                        origem.dsImpressora = con.Text;
                        

                    }
                    else if (tipoControle == "GroupBox")
                    {

                        Control GroupBox = (GroupBox)item;
                        Control.ControlCollection txts = GroupBox.Controls;
                        Control txtBox = (TextBox)txts[0];
                        CheckBox check_box = (CheckBox)txts[2];

                        decimal idOrigem = Convert.ToDecimal(txtBox.Name.Replace("textBoxmm", ""));
                        var origem = context.EB_OrigemProduto.Single(cl => cl.OrigemID == idOrigem);
                        origem.tamanhoPapelImpressoraMilimetros = Convert.ToDecimal(txtBox.Text);
                        origem.flPossuiAcentuacao = check_box.Checked == true ? true : false;

                    }

                }

                var conf = context.EB_ConfiguracoesSistema.Single(a => a.ConfID == 1);

                if (Radiotaxa.Checked == true)
                {
                    conf.flTaxaServicoAtiva = true;
                }
                else
                {
                    conf.flTaxaServicoAtiva = false;
                }

                conf.impressaoCabecalho = txtCab.Text;
                conf.impressaoRodape = txtRod.Text;


                context.SaveChanges();

                MessageBox.Show("Configurações salvar com sucesso!", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );

            }catch(Exception error)
            {

            }
        }







        public void populaPlanoContas()
        {
            var query = (from a in _context.EB_PlanoContas orderby a.dsPlanoConta ascending select new {a.dsPlanoConta, a.PlanoContaID }).ToList();
            eBPlanoContasBindingSource.DataSource = query;
        }


        private void frmConfiguracoesSistema_Load(object sender, EventArgs e)
        {
            PopulaOrigens(); populaPlanoContas();
            
            this.Closed += delegate { /*MessageBox.Show("Fechada", "BarTum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); */};

            var conf = _context.EB_ConfiguracoesSistema.Single(a => a.ConfID == 1);
            if (conf.flTaxaServicoAtiva == true)
            {
                Radiotaxa.Checked = true;
                Radiotaxa1.Checked = false;
            }
            else
            {
                Radiotaxa.Checked = false;
                Radiotaxa1.Checked = true;
            }


            txtCab.Text = conf.impressaoCabecalho;
            if (conf.impressaoRodape == "" || conf.impressaoRodape == null)
            {
                txtRod.Text = "Obrigado pela preferência, volte sempre!";
            }
            else
            {
                txtRod.Text = conf.impressaoRodape;
            }

           //comboPlanoContas.SelectedValue =  _context.EB_PlanoContas.Single(a => a.flPadraoSaida == true).PlanoContaID;
        }
        
        
        StringReader leitor;
       

        private void button1_Click(object sender, EventArgs e)
        {


              //302 pixels de Width = 8 ProcessCmdKey = 80 mm


            

            try
            {

                

                string texto = "Teste de impressão!";
                leitor = new StringReader(texto);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = this.printDocument2;
                printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                printPreviewDialog1.ShowDialog();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Erro : " + exp.Message.ToString());
            }

        }

         float gridAltura = 0;
        PaperSize custom;

        void PrintDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Single margemEsq = e.MarginBounds.Left;
            Single margemSup = e.MarginBounds.Top;
            Single margemDir = e.MarginBounds.Right;
            Single margemInf = e.MarginBounds.Bottom;

            Font fonteTitulo;
            Font fonteRodape;
            Font fonteNormal;
            Font fonteColuna;

            fonteTitulo = new Font("Verdana", 8);
            fonteRodape = new Font("Verdana", 8);
            fonteNormal = new Font("Verdana", 8);
            fonteColuna = new Font("Verdana", 8);

            Pen caneta = new Pen(Color.Black);

            float gridAltura = 80;


            /*LINHA 1*/
            string tipoPedido = "COZINHA";
            string CodVenda = (2).ToString("D6");
            e.Graphics.DrawLine(caneta, margemEsq, gridAltura, margemDir, gridAltura); gridAltura = gridAltura + 5;
            e.Graphics.DrawString("PEDIDO" + tipoPedido, fonteTitulo, Brushes.Black, margemEsq, gridAltura, new StringFormat());
            e.Graphics.DrawString(CodVenda, fonteTitulo, Brushes.Black, new PointF(243, gridAltura)); gridAltura = gridAltura + 20;
            e.Graphics.DrawLine(caneta, margemEsq, gridAltura, margemDir, gridAltura); gridAltura = gridAltura + 5;

            /*LINHA 2*/
            string garcon = (2).ToString("D2") + "SILVANA";
            string timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); 
            e.Graphics.DrawString(garcon, fonteTitulo, Brushes.Black, margemEsq, gridAltura, new StringFormat());
            e.Graphics.DrawString(timestamp, fonteTitulo, Brushes.Black, new PointF(180, gridAltura)); gridAltura = gridAltura + 20;
            e.Graphics.DrawLine(caneta, margemEsq, gridAltura, margemDir, gridAltura); gridAltura = gridAltura + 5;


            /*LINHA 3*/
            string CodLanctoItem = (028342).ToString("D6");
            string DadosTipo = "MESA: 01";
            e.Graphics.DrawString(CodLanctoItem, fonteTitulo, Brushes.Black, margemEsq, gridAltura, new StringFormat());
            e.Graphics.DrawString(DadosTipo, fonteTitulo, Brushes.Black, new PointF(230, gridAltura)); gridAltura = gridAltura + 20;


            /*LINHA 4*/
            e.Graphics.DrawLine(caneta, margemEsq, gridAltura, margemDir, gridAltura); gridAltura = gridAltura + 5;
            e.Graphics.DrawString("Item.................................................", fonteColuna, Brushes.Black, new PointF(10, gridAltura));
            e.Graphics.DrawString("Qtde", fonteColuna, Brushes.Black, new PointF(250, gridAltura));

            gridAltura = gridAltura + 20;

            e.Graphics.DrawLine(caneta, margemEsq, gridAltura, margemDir, gridAltura);



            //início do grid

            gridAltura = gridAltura + 5;

            string descricao = "MACARRÃO A MODA";
            string quantidade = "1";
            e.Graphics.DrawString(descricao, fonteColuna, Brushes.Black, new PointF(10, gridAltura));
            e.Graphics.DrawString(quantidade, fonteColuna, Brushes.Black, new PointF(250, gridAltura));

  

            gridAltura = gridAltura + 20;

            //fim do grid

           

            e.Graphics.DrawLine(caneta, margemEsq, gridAltura, margemDir, gridAltura);

            gridAltura = gridAltura + 5;

            e.Graphics.DrawString("Observação...................................................", fonteColuna, Brushes.Black, new PointF(10, gridAltura));

            gridAltura = gridAltura + 20;

            
            e.Graphics.DrawLine(caneta, margemEsq, gridAltura, margemDir, gridAltura);

            gridAltura = gridAltura + 5;

            
            /*LINHA 5*/

            int charactersOnPage = 0;
            int linesPerPage = 0;
            var observ = e.Graphics.MeasureString("", this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
            string observacao = "";
            Rectangle observRec = e.MarginBounds;
            observRec.Y = Convert.ToInt32(gridAltura);
            e.Graphics.DrawString(observacao, fonteColuna, Brushes.Black, observRec, StringFormat.GenericTypographic);

            gridAltura = gridAltura +  observ.Height + 5;

            e.Graphics.DrawLine(caneta, margemEsq, gridAltura, margemDir, gridAltura);

            /**/

            custom.Height = Convert.ToInt32(gridAltura + 30);
            e.PageSettings.PaperSize = custom;

        }




        private void printDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {


            /*PaperSize custom = new PaperSize("Custom Easy Bar", 302, 302);
            custom.RawKind = (int)PaperKind.Custom;

            Margins margens = new Margins(0, 0, 0, 0);

            PaperSource source = new PaperSource();
            source.RawKind = (int)PaperKind.Custom;
            source.SourceName = "Custom Easy Bar";



            printDocument1.DefaultPageSettings.PaperSize = custom;
            printDocument1.DefaultPageSettings.Margins = margens;
            printDocument1.DefaultPageSettings.PaperSource = source*/


            

            //int altura = Convert.ToInt32(this.gridAltura);

            int altura = 900;

            custom = new PaperSize("Custom", 302, altura);

            Margins margens = new Margins(10, 10, 10, 10);


            e.PageSettings.Margins = margens;
            e.PageSettings.PaperSize = custom;
        }



        internal string TextToBePrinted;
        PrintDocument prn;
        public void prt(string text)
        {
            TextToBePrinted = text;
            // Dim a As New StreamWriter("C:\Temp\MyFile.txt")
            // a.Write(text)
            // a.Close()
            // streamToPrint = New StreamReader("C:\Temp\MyFile.txt")
            prn = new PrintDocument();
            using(prn);
            prn.PrinterSettings.PrinterName = prn.PrinterSettings.PrinterName;
            prn.PrintPage += new PrintPageEventHandler(this.PrintPageHandler);
            prn.Print();
            
            
        }

     
        private void PrintPageHandler(object sender, PrintPageEventArgs args)
        {
            Font myFont = new Font(System.Drawing.FontFamily.GenericMonospace.Name, 7, FontStyle.Regular, GraphicsUnit.Point);
 
            int charactersOnPage = 50;
            int linesPerPage = 50;


            args.Graphics.MeasureString(TextToBePrinted, myFont, args.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
            args.Graphics.DrawString(TextToBePrinted, myFont, Brushes.Black, 0, 0, new StringFormat());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string text = "PEDIDO BAR     N PED.: 58587\n";
            text += "==================================\n";
            text += "__________________________________\n";
            text += "02 MANUEL         26/03/2010 15:34\n";

            prt(text);
            
            
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = this.prn;
            printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
            printPreviewDialog1.ShowDialog();*/


            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = this.printDocument1;
            printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
            printPreviewDialog1.ShowDialog();
        }








        string tipoVenda = "mesa";
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            BarTumEntities context = new BarTumEntities();
            decimal idVenda = Convert.ToDecimal(49);
            var itensImpressao = _context.EB_Lancamento.Single(cl => cl.LanctoID == idVenda);
            Single margemEsq = e.MarginBounds.Left;
            Single margemSup = e.MarginBounds.Top;
            Single margemDir = e.MarginBounds.Right;
            Single margemInf = e.MarginBounds.Bottom;
            Font fonteTitulo;
            Font fonteTituloB;
            Font fonteTituloTopo;
            fonteTituloB = new Font("OCR-B 10 BT", 7, FontStyle.Bold);
            fonteTitulo = new Font("OCR-B 10 BT", 7);
            fonteTituloTopo = new Font("OCR-B 10 BT", 8, FontStyle.Bold);
            StringFormat stringFormat = new StringFormat();
            stringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            Pen caneta = new Pen(Color.Black);
            string titulo = "PONTO DO MACARRÃOOOO";
            string data = DateTime.Now.ToString("dd/MM/yyyy");
            string hora = DateTime.Now.ToString("HH:mm");
            string linha = "====================================================";
            this.gridAltura = 80;
            string CodLanctoItem = "nº venda: " + Convert.ToInt32(itensImpressao.LanctoID).ToString("D6");
            string qtd = "Qtde..Total";
            string todos = "";

            /*LINHA 1*/

            todos += linha;
            todos += titulo;
            todos += data;
            todos += data;

                      

            /*LINHA 2*/
           
            string DadosTipo = "";
            switch (tipoVenda)
            {
                case "mesa":
                    todos += "Mesa : " + Convert.ToInt32(itensImpressao.MesaID).ToString("D2");
                    break;
                case "balcao":
                    todos += "Balcão : " + itensImpressao.BalcaoID.ToString();
                    break;
                case "tipoPedido":
                    todos += "Pedido : " + itensImpressao.LanctoID;
                    break;
            }

            
            todos += CodLanctoItem + " - " + DadosTipo;

            todos += hora;
            todos += linha;
            
            todos += "Item...................................................";
            todos += qtd;
            todos += linha;

         
            //início do grid

            gridAltura = gridAltura + 5;
            decimal total = 0;
            string codigo = "";
            string descricao = "";
            decimal tProduto = 0;
            string quantidade = "";

            foreach (var produto in itensImpressao.EB_LancamentoItens.OrderByDescending(a => a.dtDataHora))
            {

                codigo = Convert.ToInt32(produto.EB_Produto.ProdutoID).ToString("D3");
                descricao = codigo + " " + produto.EB_Produto.dsProduto;
                tProduto = produto.Total;
                quantidade = tProduto.ToString() + "   " + Convert.ToInt32(produto.Quantidade).ToString("D2");


                todos += descricao;
                todos += quantidade;
              
                total += produto.Total;

                gridAltura = gridAltura + 20;
            }



            descricao = "Taxa Servico";
            decimal taxaServico = Convert.ToDecimal(500);
            quantidade = taxaServico.ToString();


            todos += descricao;
            todos += quantidade;

            total += taxaServico;




            todos += linha;

            todos += "Total....................  ";



            Font myFont = new Font(System.Drawing.FontFamily.GenericMonospace.Name, 7, FontStyle.Regular, GraphicsUnit.Point);

            int charactersOnPage = 50;
            int linesPerPage = 50;


            e.Graphics.MeasureString(todos, myFont, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
            e.Graphics.DrawString(todos, myFont, Brushes.Black, 0, 0, new StringFormat());

           
        }

        private void frmConfiguracoesSistema_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
 
            }
        }

        private void panelImpressoras_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
