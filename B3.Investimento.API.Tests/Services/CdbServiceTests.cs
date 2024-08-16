using B3.Investimento.API.Interfaces;
using B3.Investimento.API.Models.Requests;
using B3.Investimento.API.Models.Responses;
using B3.Investimento.API.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace B3.Investimento.API.Tests.Services
{
    [TestClass]
    public class CdbServiceTests
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

        [TestMethod]
        [DataRow(100.00, 6, 105.98, 1.35)]
        [DataRow(100.00, 7, 107.01, 1.4)]
        [DataRow(100.00, 13, 113.4, 2.35)]
        [DataRow(100.00, 25, 127.36, 4.10)]
        public void RetornaValorImpostoQuandoImpostoCalculadoRealizado(double valorMonetario, int prazoEmMeses, double valorBrutoTotal, double impostoEsperado)
        {
            //Arrange
            var investimentoRequest = new InvestimentoRequest(valorMonetario, prazoEmMeses);

            //Act
            var result = _cdbService.CalcularImposto(investimentoRequest, valorBrutoTotal);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(impostoEsperado, Math.Round(result, 2));
        }

        [TestMethod]
        [DataRow(100.00, 6, 105.98)]
        [DataRow(100.00, 7, 107.01)]
        [DataRow(100.00, 13, 113.4)]
        [DataRow(100.00, 25, 127.36)]
        public void RetornaValorTotalBrutoQuandoCalculoRealizado(double valorMonetario, int prazoEmMeses, double valorTotalBrutoEsperado)
        {
            //Arrange
            var investimentoRequest = new InvestimentoRequest(valorMonetario, prazoEmMeses);

            //Act
            var result = _cdbService.CalcularValorTotalBruto(investimentoRequest);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(valorTotalBrutoEsperado, Math.Round(result, 2));
        }

        [TestMethod]
        [DataRow(100.00, 6, 105.98, 104.63)]
        [DataRow(100.00, 7, 107.01, 105.61)]
        [DataRow(100.00, 13, 113.4, 111.06)]
        [DataRow(100.00, 25, 127.36, 123.26)]
        public void RetornaValorTotalLiquidoQuandoCalculoRealizado(double valorMonetario, int prazoEmMeses, double valorBrutoTotal, double valorLiquidoEsperado)
        {
            //Arrange
            var investimentoRequest = new InvestimentoRequest(valorMonetario, prazoEmMeses);

            //Act
            var result = _cdbService.CalcularValorTotalLiquido(investimentoRequest, valorBrutoTotal);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(valorLiquidoEsperado, Math.Round(result, 2));
        }

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
