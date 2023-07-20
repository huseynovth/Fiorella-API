using Fiorella.Aplication.Abstraction.Repository;
using Fiorella.Domain.Entites;
using Fiorella.Persistence.Contexts;

namespace Fiorella.Persistence.Implementations.Repositories;

public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
{
    public CategoryReadRepository(AppDbContext context) : base(context)
    {
    }
}
