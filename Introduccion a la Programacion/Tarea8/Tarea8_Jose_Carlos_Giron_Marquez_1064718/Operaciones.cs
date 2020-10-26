using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8_Jose_Carlos_Giron_Marquez_1064718
{
    class Operaciones
    {

        //Serie 1

        public Double Serie1(int N)
        {
            Double res = 0.00;

            for (int i = 1; i <= N; i++)
            {
                res += (1 / Convert.ToDouble(i));
            }

            return res;

        }

        //Serie 2

        public Double Serie2(int N)
        {
            double res = 0;

            for (int i = 1; i <= N; i++)
            {
                res += (1 / (Math.Pow(2, i)) );
            }

            return res;

        }

        //Binario

        public String Binario(int N)
        {
            String res = "";
            double operacion;
            bool fin = false;

            while (fin == false)
            {
                if (N > 1)
                {
                    res += Convert.ToString(N % 2);
                    operacion = N / 2;
                    N = Convert.ToInt16(Math.Truncate(operacion));

                    if (N == 1 )
                    {
                        res += "1";
                        fin = true;
                    }
                }
                else
                {
                    res = "1";
                        fin = true;
                }
            }

            return res;
        }


        //Hexadecimal 

        public String Hexadecimal(int N)
        {
            String res = "";
            int numero;
            double operacion;
            bool fin = false;

            if (N >= 16)
            {
                while (fin == false)
                {
                    numero = N % 16;


                    if (numero > 0 && numero < 10)
                    {

                        res = Convert.ToString(N) + res;

                    }
                    if (numero == 10)
                    {
                        res = "A" + res;
                    }
                    if (numero == 11)
                    {
                        res = "B" + res;
                    }
                    if (numero == 12)
                    {
                        res = "C" + res;
                    }
                    if (numero == 13)
                    {
                        res = "D" + res;
                    }
                    if (numero == 14)
                    {
                        res = "E" + res;
                    }
                    if (numero == 15)
                    {
                        res = "F"+ res;
                    }


                    operacion = N / 16;
                    N = Convert.ToInt16(Math.Truncate(operacion));

                    if (N < 16)
                    {
                        if (N >= 0 && N < 10)
                        {

                            res = Convert.ToString(N) + res;

                        }
                        if (N == 10)
                        {
                            res += "A";
                        }
                        if (N == 11)
                        {
                            res += "B";
                        }
                        if (N == 12)
                        {
                            res += "C";
                        }
                        if (N == 13)
                        {
                            res += "D";
                        }
                        if (N == 14)
                        {
                            res += "E";
                        }
                        if (N == 15)
                        {
                            res += "F";
                        }


                        fin = true;
                    }
                }
            }
            else
            {
                    if (N > 0 && N < 10) {

                        res = Convert.ToString(N);

                    }
                    if(N == 10)
                    {
                        res = "A";
                    }
                    if (N == 11)
                    {
                        res = "B";
                    }
                    if (N == 12)
                    {
                        res = "C";
                    }
                    if (N == 13)
                    {
                        res = "D";
                    }
                    if (N == 14)
                    {
                        res = "E";
                    }
                    if (N == 15)
                    {
                        res = "F";
                    }

                fin = true;
            }
            return res;
        }
    }
}
