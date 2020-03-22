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

    [MetadataType(typeof(EB_EstoqueLancItensMetadata))]
    public partial class EB_EstoqueLancItens
    {
        //grid propriedades
        public string dsProduto { get; set; }
        public string dsGrupo { get; set; }
        public int? nrUnidade { get; set; }
        public decimal? Total { get; set; }
    }

    public class EB_EstoqueLancItensMetadata
    {
       
    }

 
}

