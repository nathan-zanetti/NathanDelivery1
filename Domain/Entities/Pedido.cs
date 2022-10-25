using Domain.Interfaces;

namespace Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get;}
        public List<PedidoItem> PedidoItens { get; set; }
    }
}
