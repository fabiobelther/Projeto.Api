using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Swashbuckle.Swagger.Annotations;
using Microsoft.AspNetCore.Http;
using System;
using Projeto.Api.Domain.Interfaces.Services.ShowMeTheCodeUseCases.Flow;
using Projeto.Api.Domain.Interfaces.Services.CalculaJurosUseCases.Flow;

namespace Projeto.Api.Host.Controllers.Api2.v1
{
    [ApiController]
    public class Api2Controller : ControllerBase
    {
        private readonly ILogger<Api2Controller> _logger;
        private readonly IBuscarUrlGitHubFlow _buscarUrlGitHubFlow;
        private readonly ICalcularJurosFlow _calcularJurosFlow;

        public Api2Controller(ILogger<Api2Controller> logger,
                              IBuscarUrlGitHubFlow buscarUrlGitHubFlow,
                              ICalcularJurosFlow calcularJurosFlow)
        {
            _logger = logger;
            _buscarUrlGitHubFlow = buscarUrlGitHubFlow;
            _calcularJurosFlow = calcularJurosFlow;
        }

        /// <summary>
        /// Calcula os juros de um valor
        /// </summary>
        [HttpGet("v1/api2/calculaJuros")]
        [Consumes("application/json")]
        [SwaggerResponse(200, Description = "Os juros foram calculados.")]
        [SwaggerResponse(400, Description = "Bad Request")]
        [SwaggerResponse(500, Description = "Internal server error")]
        [SwaggerResponse(404, Description = "Não foi possivel calcular os juros")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [SwaggerOperation(operationId: "Calcula_Juros_Get")]
        public async Task<ActionResult> GetCalculaJuros(decimal valorInicial, int tempo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _calcularJurosFlow.Execute(valorInicial, tempo);
            return Ok(response);
        }

        /// <summary>
        /// Retorna o caminho aonde o codigo se encontra no GitHub
        /// </summary>
        [HttpGet("v1/api2/showmethecode")]
        [Consumes("application/json")]
        [SwaggerResponse(200, Description = "O caminho foi encontrado")]
        [SwaggerResponse(400, Description = "Bad Request")]
        [SwaggerResponse(500, Description = "Internal server error")]
        [SwaggerResponse(404, Description = "Não foi possivel encontrar o caminho")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [SwaggerOperation(operationId: "Show_Me_The_Code_Get")]
        public async Task<ActionResult> GetShowMeTheCode()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _buscarUrlGitHubFlow.Execute();
            return Ok(response);
        }
    }
}
