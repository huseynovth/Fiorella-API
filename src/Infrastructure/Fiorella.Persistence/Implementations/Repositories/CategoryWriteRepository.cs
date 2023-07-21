using Fiorella.Aplication.Abstraction.Repository;
using Fiorella.Domain.Entites;
using Fiorella.Persistence.Contexts;

namespace Fiorella.Persistence.Implementations.Repositories;

public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
{
    public CategoryWriteRepository(AppDbContext context) : base(context)
    {
    }
}