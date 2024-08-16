using B3.Investimento.API.Models.Requests;
using B3.Investimento.API.Models.Responses;

namespace B3.Investimento.API.Interfaces
{
    public interface IInvestimentoService
    {
        InvestimentoResponse Calcular(InvestimentoRequest investimentoRequest);
    }
}