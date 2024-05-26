using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiia6
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando matenimiento del coche: Cambio de aceite y revisión de frenos.");
        }
        public override double ObtenerCostoMantenimiento()
        {
            return 150.0;
        }
        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial");
        }
        public override double tiempoServicio()
        {
            return 20.0;
        }
    }
}
