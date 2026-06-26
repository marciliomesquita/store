using Ambev.Store.Domain.Entities;

namespace Ambev.Store.Domain.Repositories
{
    public interface IVendaRepository
    {
        Task<Venda> CriarVenda(Venda venda, CancellationToken cancellationToken);
    }
}
