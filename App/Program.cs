using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var container = ConfigureDICommonServices();
            var appHost = CreateAppHost(args, container);
            var webApiHost = CreateWebApiHost(args, container);


            await Task.WhenAll(webApiHost.RunAsync());
        }


        static IContainer ConfigureDICommonServices()
        {
            var builder = new ContainerBuilder();

            builder.C

            return builder.Build();
        }

        static IHost CreateAppHost(string[] args, IContainer container)
        {
            return Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacChildLifetimeScopeServiceProviderFactory(container.BeginLifetimeScope()))
                .ConfigureServices(services =>
                {
                    //services.AddHostedService<HostedService>();
                })
                .Build();
        }

        static IHost CreateWebApiHost(string[] args, IContainer container)
        {
            return Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacChildLifetimeScopeServiceProviderFactory(container.BeginLifetimeScope()))
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<WebApi.Startup>();
                })
                .Build();
        }
    }
}
