using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using BarTum.Entities;
using BarTum.Utilities;
using System.ComponentModel.DataAnnotations;

namespace BarTum.Windows.Modulos.Bairro
{
    public partial class frmBairroCadastro : Form
    {

        private decimal? id_;
        public decimal? id { get { return id_; } set { id_ = value; } }

        frmBairroList frmBairroList;
        private object pai_;
        public object pai { get { return pai_; } set { pai_ = value; } }

        private bool consulta_ = false;
        public bool consulta { get { return consulta_; } set { consulta_ = value; } }
        
        public frmBairroCadastro()
        {
            InitializeComponent();
        }

        
        public void populaCidade()
        {
            BarTumEntities _context = new BarTumEntities();
            var result = (from item in _context.EB_Cidade orderby item.dsNome ascending select new { item.CidadeID, item.dsNome }).ToList();
            eBCidadeBindingSource.DataSource = result;
        }


        public void preencheFormularioEdit()
        {
            BarTumEntities _context = new BarTumEntities();
            var item = (from a in _context.EB_Bairro select a).Single(a => a.BairroID == this.id);
            BairroID.Text = item.BairroID.ToString();
            dsNome.Text = item.dsNome;
            CidadeID.SelectedValue = item.CidadeID;
            nrTaxaEntrega.Text = item.nrTaxaEntrega.ToString("C");
        }


        private void frmBairroCadastro_Load(object sender, EventArgs e)
        {
            populaCidade();

            if (this.id != null)
            {
                preencheFormularioEdit();
                botaoSalvar.Text = "Salvar alterações";
            }


            if (this.consulta == true)
            {
                botaoSalvar.Visible = false;
            }

            if (this.pai != null)
            {
                var tipo = this.pai.GetType();

                switch (tipo.Name)
                {
                    case "frmBairroList":

                        this.frmBairroList = (frmBairroList)this.pai;

                        break;
                }

            }

        }

        public void fill(ref EB_Bairro BairroEnt)
        {
            BairroEnt.dsNome = dsNome.Text;
            BairroEnt.CidadeID = Convert.ToDecimal(CidadeID.SelectedValue);
            BairroEnt.nrTaxaEntrega = Convert.ToDecimal(nrTaxaEntrega.Text.Replace("R$", "").Replace(".", ""));

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                EB_Bairro BairroEnt = new EB_Bairro();



                if (BairroID.Text == "")
                {


                    fill(ref BairroEnt);


                    if (BairroEnt.Valida(BairroEnt))
                    {

                        this.frmBairroList.context.AddToEB_Bairro(BairroEnt);
                        this.frmBairroList.context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Bairro inserido com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmBairroList.populaGridview();
                        this.Close();

                    }
                }
                else
                {
                    decimal id = Convert.ToDecimal(BairroID.Text);

                    BairroEnt = this.frmBairroList.context.EB_Bairro.Single(cl => cl.BairroID == id);

                    fill(ref BairroEnt);

                    if (BairroEnt.Valida(BairroEnt))
                    {
                        this.frmBairroList.context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(this, "Bairro atualizado com sucesso!", "BarTum", buttons,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                        this.frmBairroList.populaGridview();
                        this.Close();


                    }
                }


            }
            catch (Exception error)
            {

            }
        }



        #region mascaras
        //máscaras
        string str = "";
        private void Mask_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {



            TextBox txtBox = (TextBox)sender;
            Control controle = txtBox;


            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                //char teste = Convert.ToChar(Keys);

                string chave = e.KeyCode.ToString();

                switch (chave)
                {
                    case "NumPad0":
                        str = str + Convert.ToChar(Keys.D0);
                        break;
                    case "NumPad1":
                        str = str + Convert.ToChar(Keys.D1);
                        break;
                    case "NumPad2":
                        str = str + Convert.ToChar(Keys.D2);
                        break;
                    case "NumPad3":
                        str = str + Convert.ToChar(Keys.D3);
                        break;
                    case "NumPad4":
                        str = str + Convert.ToChar(Keys.D4);
                        break;
                    case "NumPad5":
                        str = str + Convert.ToChar(Keys.D5);
                        break;
                    case "NumPad6":
                        str = str + Convert.ToChar(Keys.D6);
                        break;
                    case "NumPad7":
                        str = str + Convert.ToChar(Keys.D7);
                        break;
                    case "NumPad8":
                        str = str + Convert.ToChar(Keys.D8);
                        break;
                    case "NumPad9":
                        str = str + Convert.ToChar(Keys.D9);
                        break;
                    default: str = str + Convert.ToChar(KeyCode); break;
                }


            }
            if (str.Length == 0)
            {
                controle.Text = "";
            }
            if (str.Length == 1)
            {



                controle.Text = Convert.ToDecimal("0,0" + str).ToString("C");
            }
            else if (str.Length == 2)
            {
                controle.Text = Convert.ToDecimal("0," + str).ToString("C");
            }
            else if (str.Length > 2)
            {
                controle.Text = Convert.ToDecimal(str.Substring(0, str.Length - 2) + "," + str.Substring(str.Length - 2)).ToString("C");
            }
        }
        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val >= 96 && Val <= 105) || (Val == 8) || (Val == 46));
        }
        private void Mask_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion mascaras

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
