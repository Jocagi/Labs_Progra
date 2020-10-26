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
    public partial class Form2 : Form
    {
        double[,] matriz = new double[10, 3];

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                matriz[i, 0] = r.Next(0, 100);
                listBox1.Items.Add(matriz[i, 0]);
                
            }
        }

         private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                matriz[i, 1] = matriz[i, 0] * 2;
                listBox2.Items.Add(matriz[i, 1]);
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                matriz[i, 2] = (matriz[i, 0] + matriz[i, 1]) / 2;
                listBox3.Items.Add(matriz[i, 2]);
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
