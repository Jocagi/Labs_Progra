using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6___José_Carlos_Girón___1064718
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil objAuto = new Automovil();

            Console.WriteLine("Ingrese información del automovil: ");
            Console.Write("Ingrese el modelo: ");
            objAuto.DefinirModelo(int.Parse(Console.ReadLine()));
            Console.Write("Ingrese el precio: ");
            objAuto.DefinirPrecio(double.Parse(Console.ReadLine()));
            Console.Write("Ingrese marca: ");
            objAuto.DefinirMarca(Console.ReadLine());
            Console.Write("Ingrese el tipo de cambio: ");
            objAuto.DefinirTipoCambio(double.Parse(Console.ReadLine()));

            Console.WriteLine("\n" + objAuto.MostrarInformacion());

            objAuto.CambiarDisponibilidad();

            Console.WriteLine("\n" + objAuto.MostrarInformacion());

            Console.Write("\nDesea Aplicar descuento? (s) ");
            string resp = Console.ReadLine();

            if (resp == "s")
            {
                Console.Write("Ingrese el descuento: ");
                objAuto.DefinirPrecio(objAuto.AplicarDescuento(double.Parse(Console.ReadLine())));

                Console.WriteLine("\n" + objAuto.MostrarInformacion());
            }

            Console.ReadKey();
        }
    }
}
