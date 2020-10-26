using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_José_Carlos_Girón_1064718
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa :)");
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su número de carné");
            string carnet = Console.ReadLine();

            Console.WriteLine("Escribe tu carrera");
            string carrera = Console.ReadLine();

            Console.WriteLine("Soy " + nombre + " mi número de carné es " + carnet + " y estoy estudiando " + carrera);
            Console.ReadKey();
        }
    }
}
