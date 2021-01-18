using Projeto.Api.Domain.Constantes;
using Projeto.Api.Domain.Interfaces.Services.TaxaJurosUseCases.Flow;
using Projeto.Api.Service.Services.TaxaJurosUseCases.Flow;
using Xunit;

namespace Projeto.Api.Service.Test.TaxaJurosTestCases.Flow
{
    public class BuscarTaxaJurosFlowTest
    {
        IBuscarTaxaJurosFlow _buscarTaxaJurosFlow;

        public BuscarTaxaJurosFlowTest()
        {
            _buscarTaxaJurosFlow = new BuscarTaxaJurosFlow();
        }

        [Fact]
        public void BuscarUrlGitHubSucesso()
        {
            // Act
            var result = _buscarTaxaJurosFlow.Execute().Result;

            // Assert
            Assert.Equal(TaxaJurosConstantes.TaxaJuros, result);
            Assert.Equal(0.01M, result);
        }
    }
}
