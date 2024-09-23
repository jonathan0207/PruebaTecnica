
using Microsoft.Extensions.DependencyInjection;
using Service.Implementation;
using Service.Interfaces;

namespace Service
{
    public static class InjectionDependencies
    {
        public static void ServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IUsuarios, ImUsuarios>();

        }
    }
}
