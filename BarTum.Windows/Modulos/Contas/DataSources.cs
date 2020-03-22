using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace BarTum.Windows.Modulos.Contas
{

    public class GridClass : EntityObject 
    {

        public string contasID { get; set; }
        public string dsPlanoConta { get; set; }
        public string descricao { get; set; }
        public string dtlancto { get; set; }
        public string vlConta { get; set; }
        public string dtVencimento { get; set; }
        public string flBaixada { get; set; }
        public string dtPagamentoOuRecebimento { get; set; }
        public string dsPlanoContas { get; set; }
        public string situacao { get; set; }
        public string dsNomeFornecedor { get; set; }
        public string dsNomeCliente { get; set; }
        public string vlPago { get; set; }


        public DateTime dtlancto2 { get; set; }
        public DateTime dtVencimento2 { get; set; }
        public DateTime? dtPagamentoOuRecebimento2 { get; set; }

    }
}
