using Fiorella.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Fiorella.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{

    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Name).IsRequired(true).HasMaxLength(30);
        builder.Property(x=>x.Description).IsRequired(false).HasMaxLength(500);

        //data seed
        builder.HasData(
                        new Category() { Id = Guid.NewGuid(), Name = "Flowers" },
                        new Category() { Id = Guid.NewGuid(), Name = "Cactus" },
                        new Category() { Id = Guid.NewGuid(), Name = "Plants"} );
 
    }

}
