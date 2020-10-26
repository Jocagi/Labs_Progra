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
    public partial class Form4 : Form
    {

        int[] desplazamiento = new int[10] { 751, 552, 680, 965, 81, 994, 754, 981, 383, 427 };
        int[] tiempo = new int[] { 59, 40, 14, 6, 30, 45, 16, 50, 41, 12 };
        int[] velocidad = new int[10];
        int[] aceleracion = new int[10];

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(desplazamiento[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(tiempo[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox3.Items.Clear();

            for (int i = 0; i < 10; i++)
            {

                velocidad[i] = desplazamiento[i] / tiempo[i];
                listBox3.Items.Add(velocidad[i]);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                suma += velocidad[i];
            }

            MessageBox.Show("El promedio de las velocidades es: " + (suma / 10).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                tiempo[i] = r.Next(0, 100);
                listBox2.Items.Add(tiempo[i]);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                aceleracion[i] =  velocidad[i] / tiempo[i];
                listBox5.Items.Add(aceleracion[i]);
            }
        }
    }
}
