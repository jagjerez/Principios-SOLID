using System;
using System.Collections.Generic;
using System.Text;

namespace Principios_SOLID.Interfaces
{
    interface ICoche
    {
        
        public void Moverse(double distancia);

        public void arrancar();

        public void abrir();
    }
}
