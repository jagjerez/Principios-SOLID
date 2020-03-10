using Microsoft.Extensions.Logging;
using Principios_SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Principios_SOLID.Business
{
    class Astra : IAstra
    {
        public bool abierto { get; set; }
        public bool encendido { get; set; }

        public bool vidriosbajados { get; set; }

        //private readonly ILogger<Astra> _logger;
        public Astra()
        {
            //_logger = loggerFactory.CreateLogger<Astra>();
            abierto = false;
        }
        public void abrir()
        {
            if (abierto)
            {
                abierto = false;
                Console.WriteLine("Coche astra cerrado");
            }
            else
            {
                abierto = true;
                Console.WriteLine("Coche astra abierto");
            }
        }

        public void arrancar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("Coche astra apagado");
            }
            else
            {
                encendido = true;
                Console.WriteLine("Coche astra encendido");
            }
        }

        public void bajarVidrios()
        {
            vidriosbajados = true;
        }

        public async void Moverse(double distancia)
        {
            await Task.Run(()=> {
                for (double i = 0; i < distancia; i += 0.1)
                {
                    Console.WriteLine($"Coche Astra con distancia recorrida de {i}");
                    Thread.Sleep(1000);
                }
            });
        }

        public void subirVidrios()
        {
            vidriosbajados = false;
        }
    }
}
