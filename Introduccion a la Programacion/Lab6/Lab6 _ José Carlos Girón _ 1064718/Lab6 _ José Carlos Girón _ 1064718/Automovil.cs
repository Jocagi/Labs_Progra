using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6___José_Carlos_Girón___1064718
{
    class Automovil
    {
        //Atributos
        public int modelo;
        public double precio;
        public string marca;
        public bool disponible;
        public double tipoCambioDolar;
        public double descuento;

        //Constructor
        public Automovil()
        {
        modelo = 2018;
        precio = 10000;
        marca = "";
        disponible = false;
        tipoCambioDolar = 7.5;
        descuento = 0.00;

        }

        //Metodos
        public void DefinirModelo(int unModelo)
        {
            modelo = unModelo;
        }
        public void DefinirPrecio(double unPrecio)
        {
            precio = unPrecio;
        }
        public void DefinirMarca(string unaMarca)
        {
            marca = unaMarca;
        }
        public void DefinirTipoCambio(double cambio)
        {
            tipoCambioDolar = cambio;
        }
        public void CambiarDisponibilidad()
        {
            if (disponible == true)
            {
                disponible = false;
            }
            else
            {
                disponible = true;
            }
        }

        public string MostrarDisponiblidad()
        {
            if (disponible == true)
            {
                return "Disponible";
            }
            else
            {
                return "No se encuentra disponible actualmente";
            }
        }

        public string MostrarInformacion()
        {
            return "Marca: " + marca + "\nModelo: " + Convert.ToString(modelo) + "\nPrecio de venta: Q" + Convert.ToString(precio) + "\nDisponibilidad: " + MostrarDisponiblidad() + "\nPrecio en dólares: $" + (precio * tipoCambioDolar).ToString();
        }
        public double AplicarDescuento(double unDescuento)
        {
            double NuevoPrecio;
            descuento = unDescuento;
            NuevoPrecio = precio - descuento;

            return NuevoPrecio;
        }

    }
}
