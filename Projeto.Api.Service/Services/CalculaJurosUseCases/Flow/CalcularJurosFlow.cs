using Projeto.Api.Domain.Interfaces.Services.CalculaJurosUseCases.Flow;
using Projeto.Api.Domain.Interfaces.Services.TaxaJurosUseCases.Flow;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Projeto.Api.Service.Services.CalculaJurosUseCases.Flow
{
    public class CalcularJurosFlow : ICalcularJurosFlow
    {
        private readonly IBuscarTaxaJurosFlow _buscarTaxaJurosFlow;


        public CalcularJurosFlow(IBuscarTaxaJurosFlow buscarTaxaJurosFlow)
        {
            _buscarTaxaJurosFlow = buscarTaxaJurosFlow;
        }

        public async Task<decimal> Execute(decimal valorInicial, int tempo)
        {
            try
            {
                var juros = _buscarTaxaJurosFlow.Execute().Result;
                var valorFinal = valorInicial * (decimal)Math.Pow((double)(1 + juros), tempo);
                var retorno = Math.Truncate(valorFinal * 100) / 100;
                //var retorno = valorFinal.ToString("N2", new CultureInfo("pt-BR"));
                return retorno;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
