using Fiorella.Persistence.Contexts;

namespace Fiorella.Persistence.Implementations.Repositories
{
    public class ReadRepository<T>
    {
        private AppDbContext context;

        public ReadRepository(AppDbContext context)
        {
            this.context = context;
        }
    }
}