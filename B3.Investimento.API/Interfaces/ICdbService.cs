using B3.Investimento.API.Models.Requests;

namespace B3.Investimento.API.Interfaces
{
    public interface ICdbService : IInvestimentoService
    {
        double CalcularValorTotalBruto(InvestimentoRequest investimentoRequest);
        double CalcularValorTotalLiquido(InvestimentoRequest investimentoRequest, double valorBruto);
        double RetornaTaxaImposto(int prazoEmMeses);
        double CalcularImposto(InvestimentoRequest investimentoRequest, double valorBruto);
    }
}