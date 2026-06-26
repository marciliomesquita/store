using Ambev.Store.Domain.Entities;
using MediatR;

namespace Ambev.Store.Application.CriarVenda
{
    public class CriarVendaCommand : IRequest<CriarVendaResult>
    {
        public CriarVendaCommand()
        {
            
        }

        public Guid Id { get; set; }
        public Guid NumeroVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public string Cliente { get; set; }
        public string FilialVendaRealizada { get; set; }
        public IList<ItemVendaCommand> ItensVendas { get; set; }
    }


    public class ItemVendaCommand
    {
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public double Desconto { get; set; }
        public bool Cancelado { get; set; }
    }
}
