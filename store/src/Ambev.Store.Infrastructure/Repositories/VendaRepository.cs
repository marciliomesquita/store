using Ambev.Store.Domain.Entities;
using Ambev.Store.Domain.Repositories;

namespace Ambev.Store.Infrastructure.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly DefaultContext _context;

        public VendaRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Venda> CriarVenda(Venda venda, CancellationToken cancellationToken)
        {
            await _context.Vendas.AddAsync(venda, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return venda;
        }
    }
}
