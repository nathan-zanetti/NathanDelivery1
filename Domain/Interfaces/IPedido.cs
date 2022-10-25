using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPedido
    {
        List<PedidoItem> PedidoItens { get; set; }
    }
}
