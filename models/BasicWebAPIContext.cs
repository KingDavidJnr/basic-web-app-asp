using Microsoft.EntityFrameworkCore;

namespace BasicWebAPI.Models
{
  public class BasicWebAPIContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public BasicWebAPIContext(DbContextOptions<BasicWebAPIContext> options) : base(options)
    {
    }
  }
}