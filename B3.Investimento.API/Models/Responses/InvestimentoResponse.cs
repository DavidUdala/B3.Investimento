namespace B3.Investimento.API.Models.Responses
{
    public class InvestimentoResponse
    {
        public InvestimentoResponse(double valorTotalBruto, double valorTotalLiquido)
        {
            ValorTotalBruto = valorTotalBruto;
            ValorTotalLiquido = valorTotalLiquido;
        }

        public double ValorTotalBruto { get; private set; }
        public double ValorTotalLiquido { get; private set; }
    }
}