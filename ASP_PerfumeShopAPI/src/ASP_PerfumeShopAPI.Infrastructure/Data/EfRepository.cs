using Ardalis.Specification.EntityFrameworkCore;
using ASP_PerfumeShopAPI.SharedKernel.Interfaces;

namespace ASP_PerfumeShopAPI.Infrastructure.Data
{
    // inherit from Ardalis.Specification type
    public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
    {
        public EfRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}