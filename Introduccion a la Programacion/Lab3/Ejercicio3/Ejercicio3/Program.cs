using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Double Valor_casa, Interes_anual, Años, Meses, Interes_mensual, Monto_Mensual;

            Console.WriteLine("Ingrese el valor de la casa:");
            Valor_casa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de interés anual:");
            Interes_anual = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el número de años que durará el crédito:");
            Años = Convert.ToDouble(Console.ReadLine());

            Interes_anual = Interes_anual / 100;
            Interes_mensual = Interes_anual / 12;
            Meses = Años * 12;

            Double paw = Math.Pow((1 + Interes_mensual), (-Meses));
            Monto_Mensual = ((Valor_casa * Interes_mensual) / (1 - paw));

            Console.WriteLine("El monto a pagar por mes es de: " + Monto_Mensual);
            Console.ReadKey();
        }
    }
}
