namespace Ambev.Store.API.Features.Vendas.CriarVenda
{
    public record CriarVendaResponse(
                    Guid NumeroVenda,
            DateTime DataVenda,
            Guid ClienteId,
            decimal ValorTotalVenda,
            Guid FilialRVenda,
            List<Guid> Produtos,
            List<int> Quantidades,
            List<decimal> PrecosUnitarios,
            List<decimal> Descontos,
            List<decimal> ValorTotalItens,
            bool Cancelado);
}
