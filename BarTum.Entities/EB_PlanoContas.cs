﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BarTum.Entities
{

    [MetadataType(typeof(EB_PlanoContasMetadata))]
    public partial class EB_PlanoContas
    {

        BarTumEntities context = new BarTumEntities();
        public string errors = "";
        List<ValidationResult> res = new List<ValidationResult>();


        public bool Valida(EB_PlanoContas model)
        {


            try
            {
               

                TypeDescriptor.AddProviderTransparent(
                    new AssociatedMetadataTypeTypeDescriptionProvider(typeof(EB_PlanoContas), typeof(EB_PlanoContasMetadata)),
                    typeof(EB_PlanoContas)
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


    public class EB_PlanoContasMetadata
    {


        [Required(ErrorMessage = "Informe a descrição do plano de contas.")]
        public string dsPlanoConta { get; set; }
    }



















}

