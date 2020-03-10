using System;
using System.Collections.Generic;
using System.Text;

namespace Principios_SOLID.Interfaces
{
    interface IVolkswagen92:ICoche
    {
        bool subirVidrioManual(double? porcentaje = 0);
        bool bajarVidrioManual(double? porcentaje = 0);
    }
}
