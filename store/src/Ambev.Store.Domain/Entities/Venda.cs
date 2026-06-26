using Ambev.Store.Domain.Exceptions;

namespace Ambev.Store.Domain.Entities
{
    public class Venda
    {
        public Guid Id { get; set; }
        public Guid NumeroVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public string Cliente { get; set; }
        public string FilialVendaRealizada { get; set; }

        public IList<ItemVenda> ItensVendas { get; set; }
        public double Desconto { get; set; } = 0;

        public Venda()
        {
            AplicarDesconto();
        }

        public void AplicarDesconto()
        {
            if(ItensVendas != null)
            {
                foreach(var item in ItensVendas)
                {
                    // Lógica para aplicar desconto em cada item
                    if(item.Quantidade > 4) 
                    {
                        Desconto = 0.1;
                    }

                    if(item.Quantidade >= 10 && item.Quantidade <= 20)
                    {
                        Desconto = 0.20;
                    }

                    if (item.Quantidade > 20)
                    {
                        throw new DomainException("Limite máximo: 20 itens por produto");
                    }

                    if (item.Quantidade < 4)
                    {
                        throw new DomainException("Não são permitidos descontos para quantidades abaixo de 4 itens");
                    }
                }
            }
        }
    }
}
