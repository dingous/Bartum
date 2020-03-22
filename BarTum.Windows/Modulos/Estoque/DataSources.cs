using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace BarTum.Windows.Modulos.Estoque  
{

    public class GridClass : EntityObject 
    {

        public decimal EstoqueLanctoItemID { get; set; }
        public decimal? EstoqueLanctoID { get; set; }
        public decimal ProdutoID { get; set; }
        public string dsProduto { get; set; }
        public string dsGrupo { get; set; }
        public decimal nrUnidade { get; set; }
        public decimal nrQuantidade { get; set; }
        public decimal nrPrCusto { get; set; }
        public decimal Total { get; set; }
        public DateTime dtLancto { get; set; }
    }
}
