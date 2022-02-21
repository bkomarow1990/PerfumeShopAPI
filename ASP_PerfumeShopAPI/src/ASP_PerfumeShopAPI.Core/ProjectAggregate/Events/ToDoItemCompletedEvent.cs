using ASP_PerfumeShopAPI.Core.ProjectAggregate;
using ASP_PerfumeShopAPI.SharedKernel;

namespace ASP_PerfumeShopAPI.Core.ProjectAggregate.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}