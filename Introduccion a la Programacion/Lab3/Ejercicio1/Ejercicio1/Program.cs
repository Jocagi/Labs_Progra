using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre, código, fecha;
            Double salario, bonificacion, horas_extra, descuentos, total_ingresos, total_egresos, salario_final, monto_horas_extra, salario_hora, igss;

            Console.WriteLine("Ingrese el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el código del empleado:");
            código = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de ingreso del empleado:");
            fecha = Console.ReadLine();
            Console.WriteLine("Ingrese el salario base del empleado:");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la bonificación de ley:");
            bonificacion = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el número de horas extra trabajadas:");
            horas_extra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese los descuentos del mes:");
            descuentos = Convert.ToDouble(Console.ReadLine());

            salario_hora = salario / 22 / 8;
            monto_horas_extra = salario_hora * (1.5) * horas_extra;

            total_ingresos = salario + bonificacion + monto_horas_extra;

            const Double impuesto = 0.0483;
            igss = salario * impuesto;

            total_egresos = descuentos + igss;
            salario_final = total_ingresos - total_egresos;

            total_ingresos = Math.Round(total_ingresos, 2, MidpointRounding.AwayFromZero);
            total_egresos = Math.Round(total_egresos, 2, MidpointRounding.AwayFromZero);
            salario_final = Math.Round(salario_final, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine("El total de ingresos del empleado " + nombre + " es: " + total_ingresos + "\nEl total de egresos del empleado es: " + total_egresos + "\nY el salario final del empleado es: " + salario_final);
            Console.ReadKey();

        }
    }
}
