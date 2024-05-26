using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiia6
{
    public class ReparacionFrenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparación de frenos");
        }
        public override double CalcularCosto()
        {
            return 100.0;
        }
        public override double tiempoServicio()
        {
            return 30.0;
        }
    }
}
