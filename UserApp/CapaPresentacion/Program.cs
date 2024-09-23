using CapaPresentacion.Vistas;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Service;

namespace CapaPresentacion
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var loginForm = host.Services.GetRequiredService<HomePage>();
            Application.Run(loginForm);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("config.json", optional: false, reloadOnChange: true);
            }).ConfigureServices((context, services) =>
            {
                services.RepositoryDependencies();
                services.ServiceDependencies();
                services.AddTransient<HomePage>();


            });


    }
}