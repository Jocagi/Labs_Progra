using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_JoséCarlosGirónMárquez_1064718
{
    class Factorial
    {
        public int factorial(int num)
        {
            int fact = num;

            for (int i = (num-1); i > 0 ; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
