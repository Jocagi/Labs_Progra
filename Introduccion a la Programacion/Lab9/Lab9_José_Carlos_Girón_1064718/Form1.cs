using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_José_Carlos_Girón_1064718
{
    public partial class Form1 : Form
    {
        int[] arreglo;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contador < arreglo.Length)
            {
                int numero = int.Parse(textBox2.Text);
                arreglo[contador] = numero;
                contador++;
                MessageBox.Show("Dato ingresado");
                textBox2.Text = "";
                
            }
            else
            {
                MessageBox.Show("Arreglo lleno");
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int N = int.Parse(textBox1.Text);
                arreglo = new int[N];
                MessageBox.Show("Arreglo creado con éxito.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                listBox1.Items.Add(arreglo[i].ToString());
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                suma = suma + arreglo[i];
                
            }
            MessageBox.Show("La suma de las posiciones es: " + suma.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El tamaño es de : " + arreglo.Length.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    suma = suma + arreglo[i];
                    
                }
                

            }
            MessageBox.Show("La suma de las posiciones pares es: " + suma.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int suma = 0;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        suma = suma + arreglo[i];

                    }


                }
                MessageBox.Show("La suma de las posiciones impares es: " + suma.ToString());
            }
            catch(Exception ex)
            {

            }
        }
    }
}
