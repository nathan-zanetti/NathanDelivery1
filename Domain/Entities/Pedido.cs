using Domain.Interfaces;

namespace Domain.Entities
{
    public class Pedido : IPedido
    {
        public int Id { get; set; }
        public int ClienteId { get;}
        public List<PedidoItem> PedidoItens { get; set; }
    }
}
