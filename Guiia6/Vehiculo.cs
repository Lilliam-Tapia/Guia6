using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiia6
{
    public abstract class Vehiculo
    {
        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando matenimiento general del vehiculo.");
        }
        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.0;
        }
        public void Lavar()
        {
            Console.WriteLine("Lavando el vehículo.");
        }
        public abstract double tiempoServicio();
    }
}
