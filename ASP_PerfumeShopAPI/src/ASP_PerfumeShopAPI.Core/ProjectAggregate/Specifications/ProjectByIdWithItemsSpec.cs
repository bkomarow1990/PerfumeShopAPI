using Ardalis.Specification;
using ASP_PerfumeShopAPI.Core.ProjectAggregate;

namespace ASP_PerfumeShopAPI.Core.ProjectAggregate.Specifications
{
    public class ProjectByIdWithItemsSpec : Specification<Project>, ISingleResultSpecification
    {
        public ProjectByIdWithItemsSpec(int projectId)
        {
            Query
                .Where(project => project.Id == projectId)
                .Include(project => project.Items);
        }
    }
}