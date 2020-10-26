using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_José_Carlos_Girón_1064718
{
    class Ciclos
    {

        public int SumaWhile(int n)
        {
            int suma = 0;
            int i = 1;

            while (i <= n)
            {
                suma += i;
                i++;
            }

            return suma;
        }

        public int SumaDoWhile(int n)
        {
            int suma = 0;
            int i = 1;

            do
            {
                suma += i;
                i++;
            }
            while (i <= n);

            return suma;
        }

        public int SumaFor(int n)
        {
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }

            return suma;
        }

        public int Factorial(int n)
        {
            int factorial = 1;

            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        public string CalcularFibonacci(int n)
        {
            int A = 0;
            int B = 1;
            int C = 0;
            string resultado;

            resultado = "0";

            while (C < n)
            {
                C = A + B;
                A = B;
                B = C;

                if (C <= n)
                {
                    resultado += (", " + C.ToString());
                }
            }

            return resultado;

        }
    }
}
