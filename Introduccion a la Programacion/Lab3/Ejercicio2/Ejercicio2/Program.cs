using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sedan, SUV, Pickup, Moto, Camion, Bus, Dia, Galones;

            Console.WriteLine("Ingrese la cantidad de vehículos sedán:");
            Sedan = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de vehículos SUV:");
            SUV = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de Motos:");
            Moto = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de Pickup:");
            Pickup = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de Camiones:");
            Camion = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de Buses:");
            Bus = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de días del mes:");
            Dia = Convert.ToInt16(Console.ReadLine());

            Sedan = Sedan * 6;
            SUV = SUV * 12;
            Moto = Moto * 4;
            Pickup = Pickup * 12;
            Camion = Camion * 20;
            Bus = Bus * 20;

            Galones = (Sedan + SUV + Moto + Pickup + Camion + Bus) * Dia;

            Console.WriteLine("La cantidad de combustible en galones que se necesita para el mes es de:\n " + Galones + " galones");
            Console.ReadKey();
        }
    }
}
