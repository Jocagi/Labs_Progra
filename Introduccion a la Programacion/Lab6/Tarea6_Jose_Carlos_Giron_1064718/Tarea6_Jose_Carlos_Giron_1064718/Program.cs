using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6_Jose_Carlos_Giron_1064718
{   
    
    //Problema1

    public class Motocicleta
    {
        private int modelo;
        private double precio;
        private string marca;
        private double iva;

        public Motocicleta()
        {
            modelo = 2018;
            precio = 1000;
            marca = "";
            iva = 0.12;
        }
        public void DefinirModelo(int Modelo)
        {
            modelo = Modelo;
        }
        public void DefinirPrecio(double Precio)
        {
            precio = Precio;
        }
        public void DefinirMarca(string Marca)
        {
            marca = Marca;
        }
        public void DefinirIVA(double IVA)
        {
            if ((IVA <= 0.99) && (IVA >= 0.01)){
                iva = IVA;
            }
            else
            {
                iva = 0.12;
            }
        }
        public string MostrarDatos()
        {
            return "Marca: " + marca + "\nModelo: " + Convert.ToString(modelo) + "\nPrecio de venta: Q" + Convert.ToString(precio);
        }
        public double PrecioSinIva()
        {
            return precio - precio * iva;
        }
        public double PrecioConIva()
        {
            return precio;
        }
        public double DevolverIva()
        {
            return precio * iva;
        }
    }

    //Problema 2

    public class TringuloRectangulo
    {
        public double catetoA;
        public double anguloOpuestoA;

        public double ObtenerCatetoA(double cateto1)
        {
            catetoA = cateto1;
            return Math.Round(catetoA, 3);
        }
        public double ObtenerCatetoB(double cateto1, double angulo)
        {
            double catetoB;
            
            catetoB = cateto1/(Math.Tan((angulo) * (180 / Math.PI)));
            return Math.Round(catetoB, 3);
        }
        public double ObtenerHipotenusa(double cateto1, double cateto2)
        {
            double hip;

            hip = Math.Sqrt((Math.Pow(cateto1, 2))+(Math.Pow(cateto2, 2)));
            return Math.Round(hip, 3);
        }
        public double ObtenerAnguloOpuestoA(double angulo)
        {
            anguloOpuestoA = angulo;
            return Math.Round(anguloOpuestoA, 3);
        }
        public double ObtenerAnguloOpuestoB(double angulo)
        {
            double anguloOpuestoB;

            anguloOpuestoB = Math.Abs(90-angulo);
            return Math.Round(anguloOpuestoB, 3);
        }
        public double ObtenerArea(double cateto1, double cateto2)
        {
            double area;

            area = (cateto1*cateto2)/2;
            return Math.Round(area, 3);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Problema1

            Console.WriteLine("Problema 1:");

            Motocicleta objMotocicleta = new Motocicleta();

            try
            {
                Console.WriteLine("Ingrese información de la Motocicleta: ");
                Console.Write("Ingrese el modelo: ");
                objMotocicleta.DefinirModelo(int.Parse(Console.ReadLine()));
                Console.Write("Ingrese el precio: ");
                objMotocicleta.DefinirPrecio(double.Parse(Console.ReadLine()));
                Console.Write("Ingrese marca: ");
                objMotocicleta.DefinirMarca(Console.ReadLine());
                Console.Write("Ingrese el porcentaje de iva (Entre 0.1 y 0.99): ");
                objMotocicleta.DefinirIVA(double.Parse(Console.ReadLine()));

                Console.WriteLine("\n" + objMotocicleta.MostrarDatos());
                Console.WriteLine("El precio sin iva es: " + objMotocicleta.PrecioSinIva());
                Console.WriteLine("El precio con iva es: " + objMotocicleta.PrecioConIva());
                Console.WriteLine("El monto del iva es: " + objMotocicleta.DevolverIva());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

            //Problema1

            Console.WriteLine("\nProblema 2:");

            TringuloRectangulo objTriangulo = new TringuloRectangulo();

            try
            {
                Console.WriteLine("Ingrese información del Triangulo: ");
                Console.Write("Ingrese el cateto A: ");
                objTriangulo.ObtenerCatetoA(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Ingrese el angulo opuesto de A: ");
                objTriangulo.ObtenerAnguloOpuestoA(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("\nCateto A: " + objTriangulo.catetoA);
                Console.WriteLine("Cateto B: " + objTriangulo.ObtenerCatetoB(objTriangulo.catetoA, objTriangulo.anguloOpuestoA));
                Console.WriteLine("Hipotenusa: " + objTriangulo.ObtenerHipotenusa((objTriangulo.catetoA),(objTriangulo.ObtenerCatetoB(objTriangulo.catetoA, objTriangulo.anguloOpuestoA))));
                Console.WriteLine("Angulo Opuesto A: " + objTriangulo.anguloOpuestoA);
                Console.WriteLine("Angulo Opuesto B: " + objTriangulo.ObtenerAnguloOpuestoB(objTriangulo.anguloOpuestoA));
                Console.WriteLine("Area: " + objTriangulo.ObtenerArea((objTriangulo.catetoA), (objTriangulo.ObtenerCatetoB(objTriangulo.catetoA, objTriangulo.anguloOpuestoA))));

                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
