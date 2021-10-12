using MascotasWeb.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotasWeb.App.Persistencia
{
    public class AppContext : DbContext
    {
        //Al producir subrayado de error en <Persona>
        //se debe crear referencia en dominio:
        //dotnet add reference ..\MascotasWeb.App.Dominio\
        public DbSet<Persona> Personas {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog =MascotasWebData");
            }
        }
    }
}