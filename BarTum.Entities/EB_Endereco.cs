using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BarTum.Entities
{

    [MetadataType(typeof(EB_EnderecoMetadata))]
    public partial class EB_Endereco
    {

    }

    public class EB_EnderecoMetadata
    {

        [Required(ErrorMessage = "Selecione uma cidade.")]
        public object CidadeID { get; set; }

        [Required(ErrorMessage = "Selecione um bairro.")]
        public object BairroID { get; set; }

        [Required(ErrorMessage = "Informe o endereço.")]
        public object dsLogradouro { get; set; }





      
    }







    







}

