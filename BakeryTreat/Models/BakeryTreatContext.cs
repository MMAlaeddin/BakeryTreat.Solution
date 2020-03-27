using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakeryTreat.Models
{
  public class BakeryTreatContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Treat> Categories { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }

    public BakeryTreatContext(DbContextOptions options) : base(options) { }
  }
}