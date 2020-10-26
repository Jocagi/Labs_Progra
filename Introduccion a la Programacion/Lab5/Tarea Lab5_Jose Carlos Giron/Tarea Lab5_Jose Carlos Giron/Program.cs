using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Lab5_Jose_Carlos_Giron
{
    class Program
    {
        static void Main(string[] args)
        {
            String Problema;
            bool verificacion = false;

            Console.WriteLine("TAREA");
            Console.WriteLine("Seleeccion de problema:");
            Console.WriteLine("1. Problema 1");
            Console.WriteLine("2. Problema 2");
            Console.Write("Marque un numero: ");

            while (verificacion == false)
            {
                verificacion = true;

                Problema = Console.ReadLine();

                switch (Problema)
                {
                    case "1":
                        //Inicia problema 1
                        String orden;
                        int a, b, c;
                        bool error = true;

                        Console.WriteLine("\nPROBLEMA 1 \n");

                        while (error == true)
                        {
                   
                            try
                            {
                                while (error == true)
                                {
                                    error = false;
                                    Console.Write("Ingrese Numero 1: ");
                                    a = Convert.ToInt16(Console.ReadLine());
                                    Console.Write("Ingrese Numero 2: ");
                                    b = Convert.ToInt16(Console.ReadLine());
                                    Console.Write("Ingrese Numero 3: ");
                                    c = Convert.ToInt16(Console.ReadLine());

                                    if (a == b)
                                    {
                                        Console.WriteLine("Ingrese numeros diferentes");
                                        error = true;
                                    }
                                    if (a == c)
                                    {
                                        Console.WriteLine("Ingrese numeros diferentes");
                                        error = true;
                                    }
                                    if (c == b)
                                    {
                                        Console.WriteLine("Ingrese numeros diferentes");
                                        error = true;
                                    }

                                    if (error == false)
                                    {
                                        //Inicia orden de numeros

                                        if (a > b)
                                        {
                                            if(a > c)
                                            {
                                                if(c > b)
                                                {
                                                    orden = Convert.ToString(a) + " " + Convert.ToString(c) + " " + Convert.ToString(b);
                                                    Console.WriteLine("El orden es: " + orden);
                                                }
                                                else
                                                {
                                                    orden = Convert.ToString(a) + " " + Convert.ToString(b) + " " + Convert.ToString(c);
                                                    Console.WriteLine("El orden es: " + orden);
                                                }
                                            }
                                            else
                                            {
                                                orden = Convert.ToString(c) + " " + Convert.ToString(a) + " " + Convert.ToString(b);
                                                Console.WriteLine("El orden es: " + orden);
                                            }
                                        }
                                        else
                                        {
                                            if (b > c)
                                            {
                                                if(a > c)
                                                {
                                                    orden = Convert.ToString(b) + " " + Convert.ToString(a) + " " + Convert.ToString(c);
                                                    Console.WriteLine("El orden es: " + orden);
                                                }
                                                else
                                                {
                                                    orden = Convert.ToString(b) + " " + Convert.ToString(c) + " " + Convert.ToString(a);
                                                    Console.WriteLine("El orden es: " + orden);
                                                }
                                            }
                                            else
                                            {
                                                orden = Convert.ToString(c) + " " + Convert.ToString(b) + " " + Convert.ToString(a);
                                                Console.WriteLine("El orden es: " + orden);
                                            }
                                        }
                                        //Termina orden de numeros
                                    }
                                }

                            }
                            catch
                            {
                                Console.WriteLine("Ingrese correctamente los numeros");
                                error = true;
                            }

                        }
                        //Termina problema 1
                        break;

                    case "2":
                        //Inicia problema 2
                        Console.WriteLine("\nPROBLEMA 2 \n");
                        bool Nan = true;
                        Double monto;

                        while (Nan == true) {
                            Nan = false;
                            try
                            {
                                Console.Write("Ingrese el monto de la compra: ");
                                monto = Convert.ToDouble(Console.ReadLine());

                                if (monto >= 400)
                                {
                                    if(monto < 15000)
                                    {
                                        if(monto < 5000)
                                        {
                                            if (monto < 1000)
                                            {
                                                monto = monto - (monto * 0.07);
                                                Console.WriteLine("Monto a pagar: Q" + monto);
                                            }
                                            else
                                            {
                                                monto = monto - (monto * 0.10);
                                                Console.WriteLine("Monto a pagar: Q" + monto);
                                            }
                                        }
                                        else
                                        {
                                            monto = monto - (monto * 0.15);
                                            Console.WriteLine("Monto a pagar: Q" + monto);
                                        }
                                    }
                                    else
                                    {
                                        monto = monto - (monto * 0.25);
                                        Console.WriteLine("Monto a pagar: Q" + monto);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Monto a pagar: Q" + monto);
                                }

                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Nan = true;
                            }
                        }
                        //Termina problema 2
                        break;
                    default:
                        Console.Write("Marque 1 para ir al problema 1 o 2 para ir al problema 2: ");
                        verificacion = false;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
