using ASP_PerfumeShopAPI.Core.Interfaces;
using ASP_PerfumeShopAPI.Core.Services;
using Autofac;

namespace ASP_PerfumeShopAPI.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}