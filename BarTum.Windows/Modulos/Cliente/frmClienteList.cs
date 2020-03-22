using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarTum.Utilities;
using System.Data.Entity;
using BarTum.Entities;
using System.Linq.Expressions;
using System.Linq;
using BarTum.Windows.Modulos.Atendimento;
using BarTum.Windows.Modulos.Contas;
using System.Data.Objects.SqlClient;



namespace BarTum.Windows.Modulos.Cliente
{
    public partial class frmClienteList : frmDefault
    {

        public BarTumEntities context = new BarTumEntities();



        public frmFecharConta frmFecharConta;
        public frmAdiantamento frmAdiantamento;
        public frmAtendimento frmAtendimento;
        public frmContasReceberCadastro frmContasReceberCadastro;
        public frmMain frmMain;


        public frmClienteList()
        {
            //var a = context.Connection;
            InitializeComponent();
            eB_ClienteDataGridView.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(eB_ClienteDataGridView_CellMouseDoubleClick);
        }

        public void Atualizar(EB_Cliente clientes)
        {
            try
            {
                context.EB_Cliente.Attach(clientes);
                context.ObjectStateManager.ChangeObjectState(clientes, System.Data.EntityState.Modified);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message.ToString());
                context.Dispose();
            }


        }



        void eB_ClienteDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal idCliente = Convert.ToDecimal(eB_ClienteDataGridView.Rows[eB_ClienteDataGridView.CurrentRow.Index].Cells[0].Value);

            if (frmFecharConta != null)
            {
                this.frmFecharConta.txtCodCliente.Text = idCliente.ToString();
                this.Close();
            }
            else if (frmContasReceberCadastro != null)
            {

                this.frmContasReceberCadastro.txtClienteID.SelectedValue = idCliente;
                this.frmContasReceberCadastro.populaClientes(idCliente);
                this.Close();
            }
            else if (frmAdiantamento != null)
            {
                this.frmAdiantamento.txtCodCliente.Text = idCliente.ToString();
                this.Close();
            }
            else if (frmAtendimento != null)
            {
                this.frmAtendimento.VendaPedido.populaCamposCliente(idCliente);
                this.Close();
            }
            else
            {
                toolStripButton3_Click(null, null);
            }
        }




        private void frmCliente_Load(object sender, EventArgs e)
        {
            //atualizaClientes();
            //efetuaBusca("");

            backgroundWorkerBusca.RunWorkerAsync();
        }

        public void atualizaClientes()
        {
            backgroundWorkerCliente.WorkerReportsProgress = true;
            backgroundWorkerCliente.RunWorkerAsync();
        }



        public IEnumerable<GridClass> query;
        public void populaGridview(string criterio)
        {

            try
            {





                query =
                   (from cliente in context.EB_Cliente.AsEnumerable().DefaultIfEmpty()
                    where cliente.flExcluido == false
                    orderby cliente.dsNome ascending
                    select new GridClass
                    {

                        ClienteID = cliente.ClienteID.ToString(),
                        dsNome = cliente.dsNome.ToString(),
                        dsLogradouro = cliente.EB_Endereco.dsLogradouro != "" ? String.Format("{0}, {1} - {2} - {3}-{4}", cliente.EB_Endereco.dsLogradouro, cliente.EB_Endereco.nrNumero, cliente.EB_Endereco.EB_Bairro.dsNome, cliente.EB_Endereco.EB_Bairro.EB_Cidade.dsNome, cliente.EB_Endereco.EB_Bairro.EB_Cidade.EB_Estado.dsSigla) : String.Empty,
                        dtNascimento = Convert.ToDateTime(cliente.dtNascimento).ToString("dd/MM/yyyy"),
                        nrCpfCpnj = cliente.nrCpfCpnj,
                        dsEmail = cliente.dsEmail == null ? "" : cliente.dsEmail,
                        dtCadastro = cliente.dtCadastro.ToString("dd/MM/yyyy"),
                        nrTelefone1 = cliente.EB_Contato.nrTelefone1,
                        nrTelefone2 = cliente.EB_Contato.nrTelefone2,
                        nrTelefone3 = cliente.EB_Contato.nrTelefone3,
                        nrTelefone4 = cliente.EB_Contato.nrTelefone4,
                        nrCelular = cliente.EB_Contato.nrCelular
                    });

                /*query = context.EB_Cliente.AsEnumerable().DefaultIfEmpty().Where(a => a.flExcluido == false)
                    .Select(cliente => new GridClass
                    {
                        ClienteID = cliente.ClienteID.ToString(),
                        dsNome = cliente.dsNome.ToString(),
                        dsLogradouro = cliente.EB_Endereco.dsLogradouro != "" ? String.Format("{0}, {1} - {2} - {3}-{4}",  cliente.EB_Endereco.dsLogradouro, cliente.EB_Endereco.nrNumero, cliente.EB_Endereco.EB_Bairro.dsNome, cliente.EB_Endereco.EB_Bairro.EB_Cidade.dsNome, cliente.EB_Endereco.EB_Bairro.EB_Cidade.EB_Estado.dsSigla) : String.Empty,
                        dtNascimento = Convert.ToDateTime(cliente.dtNascimento).ToString("dd/MM/yyyy"),
                        nrCpfCpnj = cliente.nrCpfCpnj,
                        dsEmail = cliente.dsEmail == null ? "" : cliente.dsEmail,
                        dtCadastro = cliente.dtCadastro.ToString("dd/MM/yyyy"),
                        nrTelefone1 = cliente.EB_Contato.nrTelefone1,
                        nrTelefone2 = cliente.EB_Contato.nrTelefone2,
                        nrTelefone3 = cliente.EB_Contato.nrTelefone3,
                        nrTelefone4 = cliente.EB_Contato.nrTelefone4,
                        nrCelular = cliente.EB_Contato.nrCelular
                    }).Skip(1).Take(100).OrderBy(a => a.dsNome);
                 */

                query = query.ToList();

                if (this.InvokeRequired)
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        eB_ClienteBindingSource.DataSource = null;
                        eB_ClienteBindingSource.DataSource = query;
                    });



                txtBuscar.Focus();

            }
            catch (Exception erro)
            {
                var excecao = erro;
                var x = 1;
            }


        }


        #region Ações do Usuário




        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmClienteCadastro ClienteCadastro = new frmClienteCadastro();
            ClienteCadastro.frmClienteList = this;
            ClienteCadastro.ShowDialog();
        }

        private void eB_ClienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCliente = Convert.ToInt32(eB_ClienteDataGridView.Rows[e.RowIndex].Cells[0].Value);

            frmClienteCadastro ClienteCadastro = new frmClienteCadastro();
            ClienteCadastro.MdiParent = this.Parent.Parent.FindForm();
            ClienteCadastro.frmClienteList = this;
            ClienteCadastro.idCliente = idCliente;
            ClienteCadastro.ShowDialog();


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (eB_ClienteDataGridView.Rows.Count > 0)
                {

                    int idCliente = Convert.ToInt32(eB_ClienteDataGridView.Rows[eB_ClienteDataGridView.CurrentRow.Index].Cells[0].Value);
                    frmClienteCadastro ClienteCadastro = new frmClienteCadastro();
                    ClienteCadastro.frmClienteList = this;
                    ClienteCadastro.idCliente = idCliente;
                    ClienteCadastro.ShowDialog();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " \n\n\n" + error.InnerException.Message);
            }

        }


        private void toolStripExcluir_Click(object sender, EventArgs e)
        {


            if (eB_ClienteDataGridView.Rows.Count > 0)
            {
                int idCliente = Convert.ToInt32(eB_ClienteDataGridView.Rows[eB_ClienteDataGridView.CurrentRow.Index].Cells[0].Value);


                string message = "Você tem certeza que deseja excluir este registro?";
                string caption = "EasyBar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {

                    var item = context.EB_Cliente.Single(a => a.ClienteID == idCliente);

                    item.flExcluido = true;
                    context.SaveChanges();


                    this.populaGridview("");
                }
            }
        }

        #endregion

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            if (eB_ClienteDataGridView.Rows.Count > 0)
            {

                int idCliente = Convert.ToInt32(eB_ClienteDataGridView.Rows[eB_ClienteDataGridView.CurrentRow.Index].Cells[0].Value);
                frmClienteCadastro ClienteCadastro = new frmClienteCadastro();
                ClienteCadastro.frmClienteList = this;
                ClienteCadastro.idCliente = idCliente;
                ClienteCadastro.consulta = true;
                ClienteCadastro.Show();
            }

        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {

            string criterio = txtBuscar.Text;
            decimal nr = 0;
            try { nr = Convert.ToDecimal(criterio); }
            catch { nr = 0; };

            var result = context.EB_Cliente.Where(i => i.dsNome.Contains(criterio) || i.ClienteID == nr);
            eB_ClienteDataGridView.DataSource = result;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClienteList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Down:
                    if (eB_ClienteDataGridView.RowCount > 0)
                    {
                        eB_ClienteDataGridView.Rows[0].Selected = true;
                    }
                    break;
            }
        }


        public void efetuaBusca(string criterio)
        {



            var busca = context.PR_CONSULTA_CLIENTE("%" + criterio.ToUpper() + "%").ToList();

            if (criterio == "")
            {
                busca = busca.Take(100).ToList();
            }



            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    eB_ClienteBindingSource.DataSource = busca;
                });
            }
            else
            {
                eB_ClienteBindingSource.DataSource = busca;
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Enter)
            {
                string criterio = txtBuscar.Text;
                if (criterio == "")
                {
                    MessageBox.Show("Informe um critério para a busca.");
                    return;
                }
                else if (criterio.Length < 3)
                {
                    MessageBox.Show("Informe um critério com pelo menos 3 letras.");
                    return;
                }

                //backgroundWorkerBusca.RunWorkerAsync();

                toolStripButton1_Click_1(null, null);

            }
            else if (e.KeyCode == Keys.Down)
            {
                eB_ClienteDataGridView.Focus();
            }

        }

        private void backgroundWorkerCliente_DoWork(object sender, DoWorkEventArgs e)
        {
            string criterio = txtBuscar.Text;
            efetuaBusca(criterio);
        }

        private void backgroundWorkerCliente_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int porcentagem = e.ProgressPercentage;
        }

        private void backgroundWorkerCliente_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Visible = false;

        }

        private void backgroundWorkerBusca_DoWork(object sender, DoWorkEventArgs e)
        {
            string criterio = txtBuscar.Text;
            /*if (criterio == "")
            {
                MessageBox.Show("Informe um critério para a busca.");
                return;
            }
            else if (criterio.Length < 3)
            {
                MessageBox.Show("Informe um critério com pelo menos 3 letras.");
                return;
            }*/

            efetuaBusca(criterio);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

            if (!backgroundWorkerBusca.IsBusy)
            {
                backgroundWorkerBusca.RunWorkerAsync();
            }
        }










    }
}
