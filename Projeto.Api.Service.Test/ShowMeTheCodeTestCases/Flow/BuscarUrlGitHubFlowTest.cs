using Projeto.Api.Domain.Constantes;
using Projeto.Api.Domain.Interfaces.Services.ShowMeTheCodeUseCases.Flow;
using Projeto.Api.Service.Services.ShowMeTheCodeUseCases.Flow;
using Xunit;

namespace Projeto.Api.Service.Test.ShowMeTheCodeTestCases.Flow
{
    public class BuscarUrlGitHubFlowTest
    {
        IBuscarUrlGitHubFlow _buscarUrlGitHubFlow;

        public BuscarUrlGitHubFlowTest()
        {
            _buscarUrlGitHubFlow = new BuscarUrlGitHubFlow();
        }

        [Fact]
        public void BuscarUrlGitHubSucesso()
        {
            // Act
            var result = _buscarUrlGitHubFlow.Execute().Result;

            // Assert
            Assert.Equal(UrlGitHubConstantes.UrlGitHub, result);
            Assert.Equal("https://github.com/fabiobelther/Projeto.Api", result);
        }
    }
}
