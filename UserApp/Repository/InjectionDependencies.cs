using Microsoft.Extensions.DependencyInjection;
using Repository.Db;
using Repository.Implementation;
using Repository.Interfaces;

namespace Repository
{
    public static class InjectionDependencies
    {
        public static void RepositoryDependencies(this IServiceCollection services)
        {
            services.AddSingleton<ConnectionBD>();
            services.AddTransient<UsuariosRepository, ImUsuariosRepository>();
        }
    }
}
