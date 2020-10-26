using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_José_Carlos_Girón_1064718
{
    class Circulo
    {
        private double radio;

        public Circulo(double r) //Constructor
        {
            radio = r;
        }

        private double Obtener_Perimetro()
        {
            //2 * PI * radio
            return (2 * Math.PI * radio);
        }

        private double Obtener_Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        private double Obtener_Volumen()
        {
            return (4 * Math.PI * Math.Pow(radio, 3))/3;
        }

        public void CalcularGeometria(ref double perimetro, ref double area, ref double volumen)
        {
            perimetro = Obtener_Perimetro();
            area = Obtener_Area();
            volumen = Obtener_Volumen();
        }
    }
}
