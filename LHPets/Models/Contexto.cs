using Microsoft.EntityFrameworkCore;

namespace LHPets.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Cliente { get; set;}
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Pet> Pet { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options){ }
    }
}