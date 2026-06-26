using Ambev.Store.Domain.Entities;

namespace Ambev.Store.API.Features.Vendas.CriarVenda
{
    public class CriarVendaRequest
    {
        public Guid Id { get; set; }
        public Guid NumeroVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public string Cliente { get; set; }
        public string FilialVendaRealizada { get; set; }
        public IList<ItemVendaRequest> ItensVendas { get; set; }
    }

    public class ItemVendaRequest
    {
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public double Desconto { get; set; }
        public bool Cancelado { get; set; }
    }
}
