﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarTum.Windows
{
    public partial class frmDefault : Form
    {
        

        public frmDefault()
        {
            InitializeComponent();
        }

        private void frmDefault_Load(object sender, EventArgs e)
        {

        }

        private void frmDefault_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
