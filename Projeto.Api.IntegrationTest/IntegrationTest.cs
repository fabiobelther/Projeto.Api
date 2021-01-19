using System.Threading.Tasks;
using Projeto.Api.Host;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Projeto.Api.IntegrationTest
{
    public class GeneralPageTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public GeneralPageTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        public static IEnumerable<object[]> ValidUrls => new List<object[]>
        {
            new object[] {"/v1/taxaJuros", "0.01", "application/json"},
            new object[] {"/v1/calculaJuros?valorinicial=100&tempo=5", "105.1", "application/json"},
            new object[] {"/v1/showmethecode", "https://github.com/fabiobelther/Projeto.Api", "text/plain" }
        };

        [Theory]
        [MemberData(nameof(ValidUrls))]
        public async Task ValidUrls_ReturnSuccessAndExpectedContentType(string path, string responseExpected, string mediaType)
        {
            var expected = new MediaTypeHeaderValue(mediaType);

            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(path);
            var responseString = await response.Content.ReadAsStringAsync();

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(responseExpected, responseString);
            Assert.Equal(expected.MediaType, response.Content.Headers.ContentType.MediaType);            
        }

    }
}
