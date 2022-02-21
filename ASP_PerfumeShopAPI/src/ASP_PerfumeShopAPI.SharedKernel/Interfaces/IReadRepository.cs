using Ardalis.Specification;

namespace ASP_PerfumeShopAPI.SharedKernel.Interfaces
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
    {
    }
}