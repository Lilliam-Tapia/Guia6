using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiia6
{
    public class CambioAceite : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite.");
        }
        public override double CalcularCosto()
        {
            return 50.0;
        }
        public override double tiempoServicio()
        {
            return 15.0;
        }
    }
}
