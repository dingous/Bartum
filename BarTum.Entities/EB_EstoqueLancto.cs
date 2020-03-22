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

    [MetadataType(typeof(EB_EstoqueLanctoMetadata))]
    public partial class EB_EstoqueLancto
    {

        List<ValidationResult> res = new List<ValidationResult>();

        public bool Valida(EB_EstoqueLancto model)
        {


            try
            {


                TypeDescriptor.AddProviderTransparent(
                    new AssociatedMetadataTypeTypeDescriptionProvider(typeof(EB_EstoqueLancto), typeof(EB_EstoqueLanctoMetadata)),
                    typeof(EB_EstoqueLancto)
                 );


                bool valid = Validator.TryValidateObject(this, new ValidationContext(this, null, null), res, true);


                if (valid)
                {

                    return true;

                }
                else
                {

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
    }



    public class EB_EstoqueLanctoMetadata
    {
        [Required(ErrorMessage = "Selecione um fornecedor.")]
        public object FornecedorID { get; set; }

        [Required(ErrorMessage = "Informe o número da nota.")]
        public object nrNota { get; set; }
        
    }

 
}

