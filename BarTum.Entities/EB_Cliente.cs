using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BarTum.Entities
{

    [MetadataType(typeof(EB_ClienteMetadata))]
    public partial class EB_Cliente
    {

        BarTumEntities context = new BarTumEntities();
        public string errors = "";
        List<ValidationResult> res = new List<ValidationResult>();




        public bool Valida(EB_Cliente model)
        {


            try
            {
               

                TypeDescriptor.AddProviderTransparent(
                    new AssociatedMetadataTypeTypeDescriptionProvider(typeof(EB_Cliente), typeof(EB_ClienteMetadata)),
                    typeof(EB_Cliente)
                 );


                bool valid = Validator.TryValidateObject(this, new ValidationContext(this, null, null), res, true);


                if (valid)
                {
                   
                    return true;

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


    public class EB_ClienteMetadata
    {


        [Required(ErrorMessage = "Informe o nome do cliente.")]
        public string dsNome { get; set; }
        
     



    }



















}

