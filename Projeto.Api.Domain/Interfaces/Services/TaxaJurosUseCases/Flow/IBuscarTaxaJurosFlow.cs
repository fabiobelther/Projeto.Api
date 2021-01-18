using System.Threading.Tasks;

namespace Projeto.Api.Domain.Interfaces.Services.TaxaJurosUseCases.Flow
{
    public interface IBuscarTaxaJurosFlow
    {
        Task<decimal> Execute();
    }
}
