using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace José_carlos_Girón_1064718_Tarea4
{
    class Cambio
    {
       internal String Calcular (Double Valor)
        {

            Double Billete100, Billete50, Billete20, Billete10, Billete5, Moneda1Q, Moneda25, Moneda1C;
            Double Residuo;
            String Resultado;

            //Deterima cantidad de dinero entero

            Billete100 = Math.Truncate(Valor / 100);
            Residuo = Valor % 100;

            Billete50 = Math.Truncate(Residuo / 50);
            Residuo = Residuo % 50;

            Billete20 = Math.Truncate(Residuo / 20);
            Residuo = Residuo % 20;

            Billete10 = Math.Truncate(Residuo / 10);
            Residuo = Residuo % 10;

            Billete5 = Math.Truncate(Residuo / 5);
            Residuo = Residuo % 5;

            Moneda1Q = Math.Truncate(Residuo / 1);
            Residuo = Residuo % 1;

            //Comienza determinar cantidad de centavos

            Residuo = Residuo * 100;

            Moneda25 = Math.Truncate(Residuo / 25);
            Residuo = Residuo % 25;

            Moneda1C = Residuo;

            Resultado = $"\n{Billete100} de Q100 \n{Billete50} de Q50 \n{Billete20} de Q20 \n{Billete10} de Q10 \n{Billete5} de Q5 \n{Moneda1Q} de Q1 \n{Moneda25} de 25 centavos \n{Moneda1C} de 1 centavo";

            return Resultado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cambio c = new Cambio();
            Double v;
            String r;

            Console.WriteLine("Jose Carlos Giron Marquez - 1064718");
            Console.WriteLine("Ingrese un Valor:");
            v = Convert.ToDouble(Console.ReadLine());

            r = c.Calcular(v);
            Console.WriteLine(r);

            Console.ReadKey();

        }
    }
}
