using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Lab5_José_Carlos_Girón
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ejercicio 2");
            Console.Write("Ingrese día: ");

            try
            {
                numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Día: Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Día: Martes");
                        break;
                    case 3:
                        Console.WriteLine("Día: Miércoles");
                        break;
                    case 4:
                        Console.WriteLine("Día: Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Día: Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Día: Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Día: Domingo");
                        break;
                    default:
                        Console.WriteLine("Error: el número a ingresar debe estar contenido entre 1 y 7 ");
                        break;
                }

                /*
                if (numero <= 0 || numero > 7)
                {
                       Console.WriteLine("Error: el número a ingresar debe estar contenido entre 1 y 7 ");
                }

                if (numero == 1)
                {
                    Console.Write("Día: Lunes");
                }

                if (numero == 2)
                {
                    Console.Write("Día: Martes");
                }

                if (numero == 3)
                {
                    Console.Write("Día: Miércoles");
                }

                if (numero == 4)
                {
                    Console.Write("Día: Jueves");
                }

                if (numero == 5)
                {
                    Console.Write("Día: Viernes");
                }

                if (numero == 6)
                {
                    Console.Write("Día: Sábado");
                }

                if (numero == 7)
                {
                    Console.Write("Día: Domingo");
                }

                 */

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
