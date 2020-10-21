using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CAToDo.Application
{
    public static class DependencyInversion
    {

        public static IServiceCollection AddApp(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }

    }
}
