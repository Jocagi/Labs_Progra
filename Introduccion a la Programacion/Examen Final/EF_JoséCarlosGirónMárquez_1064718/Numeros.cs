using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_JoséCarlosGirónMárquez_1064718
{
    class Numeros
    {
        public int Mayor(int A, int B, int C)
        {
            int May = -1;

            if (A >= B && A >= C)
            {
                May = A;   
            }
            else if (B >= A && B >= C)
            {
                May = B;
            }
            else if (C >= A && C >= B)
            {
                May = C;
            }

            return May;
        }
    }
}
