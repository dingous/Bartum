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

    [MetadataType(typeof(EB_LancamentoMetadata))]
    public partial class EB_Lancamento
    {

        BarTumEntities context = new BarTumEntities();
        public string errors = "";
        List<ValidationResult> res = new List<ValidationResult>();

       


        public bool Valida(EB_Lancamento model)
        {


            try
            {
               

                TypeDescriptor.AddProviderTransparent(
                    new AssociatedMetadataTypeTypeDescriptionProvider(typeof(EB_Lancamento), typeof(EB_LancamentoMetadata)),
                    typeof(EB_Lancamento)
                 );


                bool valid = Validator.TryValidateObject(this, new ValidationContext(this, null, null), res, true);


                if (valid)
                {

                    if (!(MesaDiponivel(model.MesaID)))
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



        public bool MesaDiponivel(decimal? MesaID)
        {
            var res = context.EB_Lancamento.FirstOrDefault(cl => cl.MesaID == MesaID && cl.MesaID != null && cl.StatusID == 1 && cl.flVendaCancelada == false || cl.MesaID == MesaID && cl.MesaID != null && cl.StatusID == 2 && cl.flVendaCancelada == false);

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (res != null)
            {
                
                MessageBox.Show("A mesa " + MesaID.ToString() + " já está ocupada!", "BarTum", buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                return true;
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


    public class EB_LancamentoMetadata
    {



        [Required(ErrorMessage = "Selecione uma mesa.")]
        public object MesaID { get; set; }

     


    }



















}

