using Ardalis.Result;
using ASP_PerfumeShopAPI.Core.ProjectAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_PerfumeShopAPI.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
    }
}