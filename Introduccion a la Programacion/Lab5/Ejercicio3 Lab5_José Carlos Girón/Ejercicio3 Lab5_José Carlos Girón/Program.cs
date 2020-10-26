using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Lab5_José_Carlos_Girón
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool correcto = false;
            bool Fin = false;

            Console.WriteLine("Ejercicio 3");

            //Inicia ingreso y verificacion de datos

            while (Fin == false) {

                try
                {

                    Console.WriteLine("Ingrese tres números mayores a cero:");
                    Console.Write("Numero 1: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Numero 2: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Numero 3: ");
                    c = Convert.ToInt16(Console.ReadLine());

                    if (a > 0)
                    {
                        if (b > 0)
                        {
                            if (c > 0)
                            {
                                correcto = true;
                            }

                            else
                            {
                                Console.WriteLine("TODOS los datos ingresados deben ser NUMEROS ENTEROS A CERO");
                            }

                        }
                        else
                        {
                            Console.WriteLine("TODOS los datos ingresados deben ser NUMEROS ENTEROS A CERO");
                        }

                    }
                    else
                    {
                        Console.WriteLine("TODOS los datos ingresados deben ser NUMEROS MAYORES A CERO");
                    }

                    if (correcto == true)
                    {
                        //Inicia algoritmo 

                        if (a > b)
                        {
                            if(a > c)
                            {
                                Console.WriteLine("RESULTADO: El numero 1 es el mayor");
                                Fin = true;
                            }
                            else
                            {
                                if (a == c)
                                {
                                    Console.WriteLine("RESULTADO: El numero 1 y el numero 3 son los mayores");
                                    Fin = true;
                                }
                                else
                                {
                                    Console.WriteLine("RESULTADO: El numero 3 es el mayor");
                                    Fin = true;
                                }
                            }
                        }
                        else
                        {
                            if (a == b)
                            {
                                if(a > c)
                                {
                                    Console.WriteLine("RESULTADO: El numero 1 y el numero 2 son los mayores");
                                    Fin = true;
                                }
                                else
                                {
                                    if(a == c)
                                    {
                                        Console.WriteLine("RESULTADO: Los tres numeros son iguales");
                                        Fin = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("RESULTADO: El numero 3 es el mayor");
                                        Fin = true;
                                    }
                                }
                            }
                            else
                            {
                                if(b > c)
                                {
                                    Console.WriteLine("RESULTADO: El numero 2 es el mayor");
                                    Fin = true;
                                }
                                else
                                {
                                    if(b == c)
                                    {
                                        Console.WriteLine("RESULTADO: El numero 2 y el numero 3 son los mayores");
                                        Fin = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("RESULTADO: El numero 3 es el mayor");
                                        Fin = true;
                                    }
                                }
                            }
                        }

                        //Termina algoritmo
                    }
                }
                catch
                {
                    Console.WriteLine("Ingrese los numeros correctamente");
                }

            }
           
            Console.ReadKey();
        }
    }
}
