using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Animal
    {
        public string nombre;
        private string valor;
        private int id;

        public string getName() { return nombre; }
        public void setName(string nombre) { this.nombre = nombre; }
        public string getValor() { return valor; }
        public void setValor(string valor) { this.valor = valor; }
    }
}
