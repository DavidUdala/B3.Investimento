using B3.Investimento.API.Models.Requests;
using System.Web.Http;
using B3.Investimento.API.Interfaces;

namespace B3.Investimento.API.Controllers
{
    public class CdbController : ApiController
    {
        private readonly ICdbService _cdbService;

        public CdbController(ICdbService cdbService)
        {
            _cdbService = cdbService;
        }
        [HttpPost]
        public IHttpActionResult SimulacaoResgateAplicacao([FromBody]InvestimentoRequest request)
        {
            if (!request.Validar())
                return BadRequest("Informe um valor monetário e um mês que seja válido.");

            var result = _cdbService.Calcular(request);

            return Ok(result);
        }

    }
}
