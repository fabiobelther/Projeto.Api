using Microsoft.Extensions.Logging;
using Projeto.Api.Domain.Constantes;
using Projeto.Api.Domain.Interfaces.Services.TaxaJurosUseCases.Flow;
using System;
using System.Threading.Tasks;

namespace Projeto.Api.Service.Services.TaxaJurosUseCases.Flow
{
    public class BuscarTaxaJurosFlow : IBuscarTaxaJurosFlow
    {
        //private readonly ILogger _logger;

        //public BuscarTaxaJurosFlow(ILogger logger)
        //{
        //    _logger = logger;
        //}

        public async Task<decimal> Execute()
        {
            try
            {
                return TaxaJurosConstantes.TaxaJuros;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{0}.Execute Failed", this.GetType().Name);
                throw;
            }
        }
    }
}
