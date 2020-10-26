using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace José_Carlos_Girón_1064718_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Entradas: 
             * Numero a
             * Numero b
            Salidas:
             * Resultado suma
             * Resultado resta
             * Resultado multiplicacion
             * Resultado division
             * Resultado div
             * Resultado mod
            Procesos:
             * Leer número a y b
             * Calcular suma: a + b
             * Calcular resta: a - b
             * Calcular multiplicacion: a * b
             * Calcular division: a / b 
             * Calcular div: a / b (Trabajar sin decimales)
             * Calcular mod: a % b
            */

            int a, b;
            int c;
            int Rsuma, Rresta, Rmulti, Rdiv, Rmod;
            double Rdivision;

            Console.WriteLine("EJERCICIO 1: Operaciones Aritméticas");

            // Nota: Existen dos formas de convertir datos a enteros: Convert.ToInt() e int.Parse()

            Console.WriteLine("Ingrese número a:");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese número b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número c:");
            c = Convert.ToInt16(Console.ReadLine());


            Rsuma = a + b;
            Rresta = a - b;
            Rmulti = a * b;
            Rdivision = Convert.ToDouble(a) / Convert.ToDouble(b);
            Rdiv = a / b;
            Rmod = a % b;

            Console.WriteLine("\n" + a.ToString() + " + " + b.ToString() + " = " + Rsuma.ToString());
            Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + Rresta.ToString());
            Console.WriteLine(a.ToString() + " * " + b.ToString() + " = " + Rmulti.ToString());
            Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " + Rdivision.ToString());
            Console.WriteLine(a.ToString() + " DIV " + b.ToString() + " = " + Rdiv.ToString());
            Console.WriteLine(a.ToString() + " MOD " + b.ToString() + " = " + Rmod.ToString());

            Console.ReadKey();

            //Inicia Ejercicio 2

            Console.WriteLine("\nEJERCICIO 2: Operaciones Booleanas");

            bool rmayorque, rmenorque, rigualque;

            rmayorque = a > b;
            rmenorque = a < b;
            rigualque = a == b;

            Console.WriteLine("\n" + a.ToString() + " > " + b.ToString() + " = " + rmayorque.ToString());
            Console.WriteLine(a.ToString() + " < " + b.ToString() + " = " + rmenorque.ToString());
            Console.WriteLine(a.ToString() + " == " + b.ToString() + " = " + rigualque.ToString());

            Console.ReadKey();


            //Inicia Ejercicio 3

            Console.WriteLine("\nEJERCICIO 3: Operaciones");

            int Roperacion1, Roperacion2;
            double Roperacion3, Roperacion4;

            Roperacion1 = a * b + c;
            Roperacion2 = a * (b + c);
            Roperacion3 = Convert.ToDouble(a) / (Convert.ToDouble(b) * Convert.ToDouble(c));
            Roperacion4 = Convert.ToDouble(3 * a + 2 * b) / Convert.ToDouble(c * c);

            Console.WriteLine(a.ToString() + " * " + b.ToString() + " + " + c.ToString() + " = " + Roperacion1.ToString());
            Console.WriteLine(a.ToString() + " * " + "(" + b.ToString() + " + " + c.ToString() + ")" + " = " + Roperacion2.ToString());
            Console.WriteLine(a.ToString() + " / (" + b.ToString() + " * " + c.ToString() + ") = " + Roperacion3.ToString());
            Console.WriteLine("3(" + a.ToString() + ") + 2(" + b.ToString() + ") / " + c.ToString() + "²" + " = " + Roperacion4.ToString());

            Console.ReadKey();

            //Inicia Ejercicio 4

            Console.WriteLine("\nEJERCICIO 4: Formula Cuadratica");

            double Resultado1, Resultado2;

            Resultado1= (-(b) + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a);
            Resultado2= (-(b) - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a);


            Console.WriteLine($"El resultado de la operación es: {Resultado1.ToString()} y {Resultado2.ToString()}");

            Console.ReadKey();


        }
    }
}
