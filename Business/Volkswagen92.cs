using Microsoft.Extensions.Logging;
using Principios_SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Principios_SOLID.Business
{
    class Volkswagen92 : IVolkswagen92
    {
        public bool abierto { get; set; }
        public bool encendido { get; set; }

        public bool vidriosbajados { get; set; }
        //private readonly ILogger<Volkswagen92> _logger;
        public Volkswagen92()
        {
           // _logger = loggerFactory.CreateLogger<Volkswagen92>();
            abierto = false;
        }

        public void abrir()
        {
            if (abierto)
            {
                abierto = false;
                Console.WriteLine("Coche Volkswagen cerrado");
            }
            else
            {
                abierto = true;
                Console.WriteLine("Coche Volkswagen abierto");
            }
        }

        public void arrancar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("Coche Volkswagen apagado");
            }
            else
            {
                encendido = true;
                Console.WriteLine("Coche Volkswagen encendido");
            }
        }

        public bool bajarVidrioManual(double? porcentaje = 0)
        {
            if (porcentaje < 100)
            {
                porcentaje += 0.1;
                bajarVidrioManual(porcentaje);
            }
            vidriosbajados = false;
            return true;
        }

        public async void Moverse(double distancia)
        {
            await Task.Run(()=> {
                for (double i = 0; i < distancia; i += 0.1)
                {
                    Console.WriteLine($"Coche Volkswagen con distancia recorrida de {i}");
                    Thread.Sleep(1000);
                }
            });
        }

        public bool subirVidrioManual(double? porcentaje = 0)
        {
            if(porcentaje < 100)
            {
                porcentaje += 0.1;
                subirVidrioManual(porcentaje);
            }
            vidriosbajados = false;
            return true;
        }
    }
}
