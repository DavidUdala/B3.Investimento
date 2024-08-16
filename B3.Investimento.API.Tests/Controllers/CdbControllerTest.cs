using System.Web.Http.Results;
using B3.Investimento.API.Controllers;
using B3.Investimento.API.Interfaces;
using B3.Investimento.API.Models.Requests;
using B3.Investimento.API.Models.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace B3.Investimento.API.Tests.Controllers
{
    [TestClass]
    public class CdbControllerTest
    {
        private Mock<ICdbService> _mockCdbService;
        private CdbController _controller;
        [TestInitialize]
        public void Setup()
        {
            _mockCdbService = new Mock<ICdbService>();
            _controller = new CdbController(_mockCdbService.Object);
        }

        [TestMethod]
        public void QuandoSucessoRetonaHttpStatusSuccess()
        {
            //Arrange
            Setup();
            var investimentoRequest = new InvestimentoRequest(100, 7);
            var resultadoEsperado = new InvestimentoResponse(100, 100);
            _mockCdbService.Setup(service => service.Calcular(investimentoRequest)).Returns(resultadoEsperado);

            //Act
            var resultado = _controller.SimulacaoResgateAplicacao(investimentoRequest) as OkNegotiatedContentResult<InvestimentoResponse>;

            //Assert
            Assert.IsNotNull(resultado);
            Assert.AreEqual(resultadoEsperado, resultado.Content);
        }
        [TestMethod]
        public void QuandoRequestInvalidoRetornaHttpStatusBadRequest()
        {
            Setup();
            //Arrange
            var investimentoRequest = new InvestimentoRequest(-10, -1);
            string resultadoEsperado = "Informe um valor monetário e um mês que seja válido.";

            //Act
            var resultado = _controller.SimulacaoResgateAplicacao(investimentoRequest) as BadRequestErrorMessageResult;

            //Assert
            Assert.IsNotNull(resultado);
            Assert.AreEqual(resultadoEsperado, resultado.Message);
        }
    }
}