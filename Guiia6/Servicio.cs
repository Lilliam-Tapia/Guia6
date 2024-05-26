using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiia6
{
    public abstract class Servicio
    {
        public abstract void RealizarServicio();
        public abstract double CalcularCosto();

        public abstract double tiempoServicio();
    }
}
