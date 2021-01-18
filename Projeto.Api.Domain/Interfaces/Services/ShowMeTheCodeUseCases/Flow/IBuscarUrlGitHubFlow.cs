using System.Threading.Tasks;

namespace Projeto.Api.Domain.Interfaces.Services.ShowMeTheCodeUseCases.Flow
{
    public interface IBuscarUrlGitHubFlow
    {
        Task<string> Execute();
    }
}
