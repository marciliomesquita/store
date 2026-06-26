namespace Ambev.Store.Domain.Entities
{
    public class ItemVenda
    {
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public double Desconto { get; set; }
        public bool Cancelado { get; set; }

        public ItemVenda()
        {
            
        }

        public ItemVenda(int quantidade, string nome, decimal precoUnitario, double desconto, bool cancelado)
        {
            Quantidade = quantidade;
            Nome = nome;
            PrecoUnitario = precoUnitario;
            Desconto = desconto;
            Cancelado = cancelado;
        }
    }
}
