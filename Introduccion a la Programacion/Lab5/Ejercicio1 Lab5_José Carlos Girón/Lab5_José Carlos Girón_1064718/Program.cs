using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_José_Carlos_Girón_1064718
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            Console.WriteLine("Ejercicio 1:");

            bool vigente = true;

            while (vigente)
            {

            Console.Write("\nIngrese un número ENTERO:");

            try
            {
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("\nRESULTADO: Es un número positivo");
                }

                else
                {
                    if (numero < 0)
                    {
                        Console.WriteLine("\nRESULTADO: Es un número negativo");
                    }
                    else
                    {
                        Console.WriteLine("\nRESULTADO: Es cero");
                    }
                }
            }

            catch
            {
                Console.WriteLine("\n¡¡¡Ingrese un número ENTERO!!!");
                
            }


            Console.WriteLine("\nDesea Salir? s");
            string salida = Console.ReadLine();
            if (salida == "s")
            {
                vigente = false;
            }

            Console.ReadKey();

            }

        }
    }
}
