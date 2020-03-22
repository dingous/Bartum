using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarTum.Windows.Modulos.Impressao
{
    public partial class frmImprimePedido : Form
    {
        public frmImprimePedido()
        {
            InitializeComponent();



            //tableLayoutPanel1.QueryContinueDrag

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCPrint print = new PCPrint();
            print.TextToPrint = "asdasdasdasdasdasd";
            print.Print();
        }


    }
}
