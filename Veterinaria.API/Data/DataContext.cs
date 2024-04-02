using Microsoft.EntityFrameworkCore;
using Veterinaria.Shared.Entidades;

namespace Veterinaria.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { 
        }
        public DbSet<Owner> Owners { get; set; }

        public DbSet<PetType> PetTypes { get; set; }
        
        public DbSet<Pet> Pets { get; set; }

        public DbSet<ServiceType> ServicesTypes { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Agenda> Agendas { get; set; }
  

    }
}
