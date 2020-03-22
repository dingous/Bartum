using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace BarTum.Windows.Modulos.Cliente  
{

    public class GridClass : EntityObject 
    {

        public string ClienteID { get; set; }
        public string dsNome { get; set; }
        public string dsLogradouro { get; set; }
        public string dtNascimento { get; set; }
        public string nrCpfCpnj { get; set; }
        public string dsEmail { get; set; }
        public string dtCadastro { get; set; }
        public string nrTelefone1 { get; set; }
        public string nrTelefone2 { get; set; }
        public string nrTelefone3 { get; set; }
        public string nrTelefone4 { get; set; }
        public string nrCelular { get; set; }
    }
}
