using CAToDo.Application.Interface.Data;
using CAToDo.Infra.EF.ToDoItems;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

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
