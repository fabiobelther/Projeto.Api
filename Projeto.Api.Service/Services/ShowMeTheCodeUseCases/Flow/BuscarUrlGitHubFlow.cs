using Microsoft.Extensions.Logging;
using Projeto.Api.Domain.Constantes;
using Projeto.Api.Domain.Interfaces.Services.ShowMeTheCodeUseCases.Flow;
using System;
using System.Threading.Tasks;

namespace Projeto.Api.Service.Services.ShowMeTheCodeUseCases.Flow
{
    public class BuscarUrlGitHubFlow : IBuscarUrlGitHubFlow
    {
        public async Task<string> Execute()
        {
            try
            {
                return UrlGitHubConstantes.UrlGitHub;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
