using System.Threading.Tasks;

namespace Projeto.Api.Domain.Interfaces.Services.CalculaJurosUseCases.Flow
{
    public interface ICalcularJurosFlow
    {
        Task<decimal> Execute(decimal valorInicial, int tempo);
    }
}
