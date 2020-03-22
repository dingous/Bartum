using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace BarTum.Windows.Modulos.Fornecedor  
{

    public class GridClass : EntityObject 
    {


        public string FornecedorID { get; set; }
        public string dsNomeFantasia { get; set; }
        public string dsRazaoSocial { get; set; }
        
    }
}
