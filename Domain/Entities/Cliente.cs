using Domain.Interfaces;

namespace Domain.Entities
{
    public class Cliente : ICliente
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
