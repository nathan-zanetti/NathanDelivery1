using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;
namespace DataAccess.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }


    }
}
