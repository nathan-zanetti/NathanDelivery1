using Domain.Interfaces;

namespace Domain.Entities
{
    public class PedidoItem : IPedidoItem
    {
        public int Id { get; set; }
        public string Item { get; set; }
    }
}
