using B3.Investimento.API.Models.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B3.Investimento.API.Tests.Models.RequestsTest
{
    [TestClass]
    public class InvestimentoRequestTests
    {
        [TestMethod]
        public void RetonaVerdadeiroQuandoValorMontarioPositivoEPrazoEmMesesMaiorQueZero()
        {
            //Arrange
            var investimentoRequest = new InvestimentoRequest(100.50, 6);
            //Act
            bool resultado = investimentoRequest.Validar();
            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [DataRow(-10.50,1)]
        [DataRow(-10.50,0)]
        [DataRow(10.50,0)]
        public void RetonaFalsoQuandoValorMontarioNegativoOuPrazoEmMesesMenorQueUm(double valorMonetario, int prazoEmMeses)
        {
            //Arrange
            var investimentoRequest = new InvestimentoRequest(valorMonetario, prazoEmMeses);
            //Act
            bool resultado = investimentoRequest.Validar();
            //Assert
            Assert.IsFalse(resultado);
        }
    }
}
