using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BarTum.Entities;


namespace BarTum.Utilities
{
    public static class Valida
    {

        public static bool validanow(params object[] list)
        {

           // System.Type a_ = typeof(list[0]);
            /*System.Type b_ = list[1].base;*/

            
            
            

            /*TypeDescriptor.AddProviderTransparent(
                       new AssociatedMetadataTypeTypeDescriptionProvider(a_, b_), a_);

            List<ValidationResult> res = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(a_, new ValidationContext(a_, null, null), res, true);*/


            return true;
        }

    }


      /*TypeDescriptor.AddProviderTransparent(
                    new AssociatedMetadataTypeTypeDescriptionProvider(typeof(EB_Cliente), typeof(EB_Cliente.EB_ClienteMetadata)),
                    typeof(EB_Cliente));



                List<ValidationResult> res = new List<ValidationResult>();
                bool valid = Validator.TryValidateObject(ClienteEnt, new ValidationContext(ClienteEnt, null, null), res, true);*/
}
