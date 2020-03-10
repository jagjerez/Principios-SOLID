using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Principios_SOLID.Business;
using Principios_SOLID.Interfaces;
using System;
using System.IO;

namespace Principios_SOLID
{
    class Program
    {
        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            RegisterServices();
            var service = _serviceProvider.GetService<IAstra>();
            var service2 = _serviceProvider.GetService<IVolkswagen92>();

            service.arrancar();
            service.Moverse(5);

            service2.arrancar();
            service2.Moverse(5);

            DisposeServices();

            Console.ReadKey();
        }

        private static void RegisterServices()
        {
            var collection = new ServiceCollection();

            collection.AddScoped<IAstra, Astra>();
            collection.AddScoped<IVolkswagen92, Volkswagen92>();

            // ...

            // Add other services

            // ...

            _serviceProvider = collection.BuildServiceProvider();
        }

        private static void DisposeServices()

        {

            if (_serviceProvider == null)

            {

                return;

            }

            if (_serviceProvider is IDisposable)

            {

                ((IDisposable)_serviceProvider).Dispose();

            }

        }
    }
}
