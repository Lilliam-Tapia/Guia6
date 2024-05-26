using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiia6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miCoche = new Coche();
            miCoche.RealizarMantenimiento();
            Console.WriteLine("Costo del matenimiento: $" + miCoche.ObtenerCostoMantenimiento());

            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimiento();
            Console.WriteLine("Costo del mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());

            miCoche.Lavar();

            Coche miCocheReal = new Coche();
            miCoche.Lavar();

            Servicio servicioAceite = new CambioAceite();
            servicioAceite.RealizarServicio();
            Console.WriteLine("Costo del cambio de aceite: $" + servicioAceite.CalcularCosto());

            Servicio servicioFrenos = new ReparacionFrenos();
            servicioFrenos.RealizarServicio();
            Console.WriteLine("Costo de la reparación de frenos: $" + servicioFrenos.CalcularCosto());

            double tiempoTotal = CalcularTiempoTotal(miCoche, servicioAceite, servicioFrenos);

            Console.WriteLine($"Tiempo total de los servicios del coche: {tiempoTotal} minutos");

            double tiempototal = CalcularTiempomoto(miMoto, servicioAceite, servicioFrenos);
            Console.WriteLine($"Tiempo total de los servicios de la moto: {tiempototal} minutos");

        }
        static double CalcularTiempoTotal(Vehiculo coche, Servicio Aceite, Servicio frenos)
        {
            double tiempoTotal = coche.tiempoServicio() + Aceite.tiempoServicio() + frenos.tiempoServicio();
            return tiempoTotal;
        }
        static double CalcularTiempomoto(Vehiculo moto, Servicio Aceite, Servicio frenos)
        {
            double tiempototal = moto.tiempoServicio() + Aceite.tiempoServicio() + frenos.tiempoServicio();
            return tiempototal;

        }
    }
}
