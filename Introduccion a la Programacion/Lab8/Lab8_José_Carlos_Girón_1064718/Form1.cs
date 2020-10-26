using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_José_Carlos_Girón_1064718
{
    public partial class Form1 : Form
    {
        Ciclos ciclos = new Ciclos();
        public Form1()
        {
            InitializeComponent();
        }

        private void SumaWhile_Click(object sender, EventArgs e)
        {
            int num = 0;
            int suma = 0;
            try
            {
                num = int.Parse(N.Text);
                if (num > 0)
                {
                    suma = ciclos.SumaWhile(num);

                    MessageBox.Show("La suma de 1 a " + num.ToString() + " es: " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("El número es inválido");
                }
            }
            catch(Exception ex){

                MessageBox.Show(ex.Message);
            } 
        }

        private void SumaDoWhile_Click(object sender, EventArgs e)
        {
            int num = 0;
            int suma = 0;
            try
            {
                num = int.Parse(N.Text);
                if (num > 0)
                {
                    suma = ciclos.SumaDoWhile(num);

                    MessageBox.Show("La suma de 1 a " + num.ToString() + " es: " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("El número es inválido");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        private void SumaFor_Click(object sender, EventArgs e)
        {
            int num = 0;
            int suma = 0;
            try
            {
                num = int.Parse(N.Text);
                if (num > 0)
                {
                    suma = ciclos.SumaFor(num);

                    MessageBox.Show("La suma de 1 a " + num.ToString() + " es: " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("El número es inválido");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            int num = 0;
            int factorial = 0;
            try
            {
                num = int.Parse(N.Text);
                if (num > 0)
                {
                    factorial = ciclos.Factorial(num);

                    MessageBox.Show("El factorial de: " + num.ToString() + " es: " + factorial.ToString());
                }
                else
                {
                    MessageBox.Show("El número es inválido");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        private void buttonFibonacci_Click(object sender, EventArgs e)
        {
            int num = 0;
            string fibonacci = "";
            try
            {
                num = int.Parse(N.Text);
                if (num > 0)
                {
                    fibonacci = ciclos.CalcularFibonacci(num);

                    MessageBox.Show(fibonacci);
                }
                else
                {
                    MessageBox.Show("El número es inválido");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }
    }
}
