using Microsoft.Extensions.DependencyInjection;
using Projeto.Api.Domain.Interfaces.Services.CalculaJurosUseCases.Flow;
using Projeto.Api.Domain.Interfaces.Services.ShowMeTheCodeUseCases.Flow;
using Projeto.Api.Domain.Interfaces.Services.TaxaJurosUseCases.Flow;
using Projeto.Api.Service.Services.CalculaJurosUseCases.Flow;
using Projeto.Api.Service.Services.ShowMeTheCodeUseCases.Flow;
using Projeto.Api.Service.Services.TaxaJurosUseCases.Flow;

namespace Projeto.Api.Host.DependencyInjection
{

    public static class ServiceDependency
    {
        public static void AddServiceDependecies(this IServiceCollection services)
        {
            services.AddTransient<IBuscarTaxaJurosFlow, BuscarTaxaJurosFlow>();
            services.AddTransient<IBuscarUrlGitHubFlow, BuscarUrlGitHubFlow>();
            services.AddTransient<ICalcularJurosFlow, CalcularJurosFlow>();
        }
    }
}
