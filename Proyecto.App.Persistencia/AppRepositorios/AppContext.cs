using Microsoft.EntityFrameworkCore;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia

{
    public class AppContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<EntradaVehiculo> EntradasVehiculo { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<SalidaVehiculo> SalidasVehiculo { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Proyecto.App.Data");

            }
        }

    }
}