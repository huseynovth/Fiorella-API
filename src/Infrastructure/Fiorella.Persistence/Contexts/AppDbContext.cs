using Fiorella.Domain.Entites;
using Fiorella.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Persistence.Contexts;

public class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
	{
	}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Category> Categories { get; set; } = null!;
}
