using Ambev.Store.Domain.Entities;
using Ambev.Store.Domain.Repositories;
using MediatR;

namespace Ambev.Store.Application.CriarVenda
{
    public class CriarVendaHandler : IRequestHandler<CriarVendaCommand, CriarVendaResult>
    {
        private readonly IVendaRepository _vendaRepository;

        public CriarVendaHandler(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public Task<CriarVendaResult> Handle(CriarVendaCommand request, CancellationToken cancellationToken)
        {
            var venda = new Venda
            {
                NumeroVenda = request.NumeroVenda,
                DataVenda = request.DataVenda,
                Cliente = request.Cliente,
                FilialVendaRealizada = request.FilialVendaRealizada,
                ItensVendas = request.ItensVendas.Select(item => new ItemVenda
                {
                    Quantidade = item.Quantidade,
                    Nome = item.Nome,
                    PrecoUnitario = item.PrecoUnitario,
                    Desconto = item.Desconto,
                    Cancelado = item.Cancelado
                }).ToList()
            };

            //_vendaRepository.CriarVenda(venda);

            return Task.FromResult(new CriarVendaResult
            {
                Id = venda.Id
            });
        }
    }
}
