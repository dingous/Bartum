using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace BarTum.Windows.Modulos.Atendimento  
{

    public class GridBalcaoNovoClass : EntityObject
    {

        public decimal LanctoID { get; set; }
        public string BalcaoID { get; set; }
        public decimal? TotalPagar { get; set; }
        public decimal? totalItens { get; set; }
        public string StatusID { get; set; }
        public DateTime? dtLancto { get; set; }
        public DateTime? dtFechamento { get; set; }
        public string dsNomeClienteBalcao { get; set; }

    }

    public class GridBalcaoClass : EntityObject 
    {

        public string LanctoID { get; set; }
        public string BalcaoID { get; set; }
        public decimal? TotalPagar { get; set; }
        public decimal? totalItens { get; set; }
        public string StatusID { get; set; }
        public DateTime? dtLancto { get; set; }
        public DateTime? dtFechamento { get; set; }
        public string dsNomeClienteBalcao { get; set; }


        public decimal? vlTaxaEntrega { get; set; }


        public string MesaID { get; set; }
        public string ComandaID { get; set; }
        public string nrOcupantes { get; set; }
        public string NomeGarcon { get; set; }
        public string endereco { get; set; }
        public string nomeCLiente { get; set; }
        public string entregador { get; set; }
    }


    public class GridcomandaClass : EntityObject
    {

        public decimal LanctoID { get; set; }
        public string BalcaoID { get; set; }
        public decimal? TotalPagar { get; set; }
        public decimal? totalItens { get; set; }
        public string StatusID { get; set; }
        public DateTime? dtLancto { get; set; }
        public DateTime? dtFechamento { get; set; }
        public string dsNomeClienteBalcao { get; set; }


        public decimal? vlTaxaEntrega { get; set; }


        public string MesaID { get; set; }
        public decimal? ComandaID { get; set; }
        public string nrOcupantes { get; set; }
        public string NomeGarcon { get; set; }
        public string endereco { get; set; }
        public string nomeCLiente { get; set; }
        public string entregador { get; set; }
    }


    public class GridMesaClass : EntityObject
    {

        public decimal LanctoID { get; set; }
        public decimal? MesaID { get; set; }
        public decimal? TotalPagar { get; set; }
        public decimal? totalItens { get; set; }
        public string StatusID { get; set; }
        public DateTime? dtLancto { get; set; }
        public DateTime? dtFechamento { get; set; }
        public string dsNomeClienteBalcao { get; set; }
        public decimal? nrOcupantes { get; set; }
        public string NomeGarcon { get; set; }
    }

    public class GridEntregaClass : EntityObject
    {

        public decimal LanctoID { get; set; }
        public decimal? MesaID { get; set; }
        public decimal? TotalPagar { get; set; }
        public decimal? totalItens { get; set; }
        public string StatusID { get; set; }
        public DateTime? dtLancto { get; set; }
        public DateTime? dtFechamento { get; set; }
        public string dsNomeClienteBalcao { get; set; }
        public decimal? nrOcupantes { get; set; }
        public string NomeGarcon { get; set; }
        public string endereco { get; set; }
        public string nomeCLiente { get; set; }
        public string entregador { get; set; }
        public decimal vlTaxaEntrega { get; set; }
        
    }
}
