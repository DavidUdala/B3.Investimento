using B3.Investimento.API.Interfaces;
using B3.Investimento.API.Models.Requests;
using B3.Investimento.API.Models.Responses;
using B3.Investimento.API.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B3.Investimento.API.Tests.Services.CdbServiceTest
{
    [TestClass]
    public class Calcular
    {
        private readonly ICdbService _cdbService = new CdbService();

        [TestMethod]
        [DataRow(100.00, 6, 105.98, 104.63)]
        [DataRow(100.00, 7, 107.01, 105.6)]
        [DataRow(100.00, 13, 113.4, 111.05)]
        [DataRow(100.00, 25, 127.36, 123.25)]
        public void RetornaValorLiquidoEValorBrutoComtemplandoTaxasDeImposto(double valorMonetario, int prazoEmMeses, double valorTotalBrutoEsperado, double valorTotalLiquidoEsperado)
        {
            //Arrange
            InvestimentoRequest investimentoRequest = new InvestimentoRequest(valorMonetario, prazoEmMeses);
            InvestimentoResponse resultadoEsperado = new InvestimentoResponse(valorTotalBrutoEsperado, valorTotalLiquidoEsperado);

            //Act
            var resultado = _cdbService.Calcular(investimentoRequest);

            //Assert
            Assert.IsNotNull(investimentoRequest);
            Assert.AreEqual(resultado.ValorTotalLiquido, resultadoEsperado.ValorTotalLiquido);
            Assert.AreEqual(resultado.ValorTotalBruto, resultadoEsperado.ValorTotalBruto);
        }
    }
}
