using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Entity;
using BarTum.Entities;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace BarTum.Entities
{

    [MetadataType(typeof(EB_ProdutoMetadata))]
    public partial class EB_Produto
    {

        BarTumEntities context = new BarTumEntities();
        public string errors = "";
        List<ValidationResult> res = new List<ValidationResult>();

        public decimal ProdutoIDHidden;


        public bool Valida(EB_Produto model)
        {


            try
            {
               

                TypeDescriptor.AddProviderTransparent(
                    new AssociatedMetadataTypeTypeDescriptionProvider(typeof(EB_Produto), typeof(EB_ProdutoMetadata)),
                    typeof(EB_Produto)
                 );


                bool valid = Validator.TryValidateObject(this, new ValidationContext(this, null, null), res, true);


                if (valid)
                {

                    if (!(ExisteProduto(model.ProdutoID, model.ProdutoIDHidden)))
                    {
                        return true;
                    }

                    return false;

                }
                else
                {

                    ShowError();
                    return false;

                }



            }
            catch (Exception error)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;              
                MessageBox.Show(error.Message + "\n\n" + error.InnerException.Message, "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }

            return true;
        }



        public bool ExisteProduto(decimal ProdutoID, decimal ProdutoIDHidden)
        {
            var res = context.EB_Produto.FirstOrDefault(cl =>cl.ProdutoID == ProdutoID);

            if (ProdutoID != ProdutoIDHidden)
            {   
                if(res != null)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Já existe um produto com este código.", "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                    return true;
                }
            }
            return false;
        }



        public void ShowError()
        {
            errors = "";

            foreach (ValidationResult vr in res)
            {
                errors += vr.ErrorMessage + Environment.NewLine;
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;  
            MessageBox.Show(errors, "BarTum", buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
        }

    }


    public class EB_ProdutoMetadata
    {



        [Required(ErrorMessage = "Informe o código do produto.")]
        public object ProdutoID { get; set; }

        [Required(ErrorMessage = "Informe uma descrição para produto.")]
        public object dsProduto { get; set; }


        [Required(ErrorMessage = "Informe o grupo do produto")]
        public decimal GrupoID { get; set; }

        [Required(ErrorMessage = "Informe o fornecedor do produto")]
        public decimal FornecedorID { get; set; }


    }



















}

