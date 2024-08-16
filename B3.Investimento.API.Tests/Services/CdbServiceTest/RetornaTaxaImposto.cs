using B3.Investimento.API.Interfaces;
using B3.Investimento.API.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B3.Investimento.API.Tests.Services.CdbServiceTest
{
    [TestClass]
    public class RetornaTaxaImposto
    {
        private readonly ICdbService _cdbService = new CdbService();

        [TestMethod]
        [DataRow(6, 0.225)]
        [DataRow(7, 0.20)]
        [DataRow(13, 0.175)]
        [DataRow(25, 0.15)]
        public void RetornaTaxaImpostoQuandoPrazoMesesInformado(int prazoEmMeses, double taxaImpostoEsperada)
        {
            //Act
            var result = _cdbService.RetornaTaxaImposto(prazoEmMeses);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(taxaImpostoEsperada, result);
        }
    }
}
