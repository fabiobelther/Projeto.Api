using Moq;
using Projeto.Api.Domain.Interfaces.Services.CalculaJurosUseCases.Flow;
using Projeto.Api.Domain.Interfaces.Services.TaxaJurosUseCases.Flow;
using Projeto.Api.Service.Services.CalculaJurosUseCases.Flow;
using System.Collections.Generic;
using Xunit;

namespace Projeto.Api.Service.Test.CalculaJurosTestCases.Flow
{
    public class CalcularJurosFlowMockTest
    {
        private Mock<IBuscarTaxaJurosFlow> _buscarTaxaJurosFlow { get; set; }
        private ICalcularJurosFlow _calcularJurosFlow;

        public CalcularJurosFlowMockTest()
        {
            _buscarTaxaJurosFlow = new Mock<IBuscarTaxaJurosFlow>();
            _calcularJurosFlow = new CalcularJurosFlow(_buscarTaxaJurosFlow.Object);
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
            new object[] { 100M, 5, 105.1M },
            new object[] { 10M, 1, 10.1M },
            new object[] { 1000M, 10, 1104.62M },
            new object[] { 0M, 10, 0M },
            new object[] { -10M, 3, -10.3M },
            new object[] { 100M, -5, 95.14M }
        };


        [Theory]
        [MemberData(nameof(Data))]
        public void CalculoJurosSucesso(decimal value1, int value2, decimal expected)
        {
            // Mock
            this._buscarTaxaJurosFlow
                .Setup(b => b.Execute())
                .ReturnsAsync(0.01M);

            // Act
            var result = _calcularJurosFlow.Execute(value1, value2).Result;

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
