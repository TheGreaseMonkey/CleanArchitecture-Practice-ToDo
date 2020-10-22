using CAToDo.Application.Interface.Data;
using CAToDo.Infra.EF.ToDoItems;
using Microsoft.Extensions.DependencyInjection;

namespace CAToDo.Infra.EF.DI
{
    public static class CreateInfrastructureIM
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddSingleton<IToDoItemRepository, ToDoItemRepository>();

            return services;
        }
    }
}
