
using Microsoft.EntityFrameworkCore;

namespace Claires_Salon.Models
{
  public class Claires_SalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clientes { get; set; }

    public Claires_SalonContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}