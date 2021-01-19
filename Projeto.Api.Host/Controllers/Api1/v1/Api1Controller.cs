using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Swashbuckle.Swagger.Annotations;
using Microsoft.AspNetCore.Http;
using Projeto.Api.Domain.Interfaces.Services.TaxaJurosUseCases.Flow;

namespace Projeto.Api.Host.Controllers.Api1.v1
{
    [ApiController]
    public class Api1Controller : ControllerBase
    {
        private readonly ILogger<Api1Controller> _logger;
        private readonly IBuscarTaxaJurosFlow _buscarTaxaJurosFlow;

        public Api1Controller(ILogger<Api1Controller> logger,
                              IBuscarTaxaJurosFlow buscarTaxaJurosFlow)
        {
            _logger = logger;
            _buscarTaxaJurosFlow = buscarTaxaJurosFlow;
        }

        /// <summary>
        /// Retorna taxa de juros
        /// </summary>
        [HttpGet("v1/taxaJuros")]
        [Consumes("application/json")]
        [SwaggerResponse(200, Description = "A taxa de juros foi encontrada.")]
        [SwaggerResponse(400, Description = "Bad Request")]
        [SwaggerResponse(500, Description = "Internal server error")]
        [SwaggerResponse(404, Description = "A taxa de juros não foi encontrada.")]
        [ProducesResponseType(typeof(decimal), StatusCodes.Status200OK)]
        [SwaggerOperation(operationId: "Taxa_Juros_Get")]
        public async Task<ActionResult> GetTaxaJuros()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _buscarTaxaJurosFlow.Execute();
            return Ok(response);
        }
    }
}
