using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICliente
    {
        string Name { get; }
        int Id { get; set; }
        List<Pedido> Pedidos { get; set; }

    }
}
