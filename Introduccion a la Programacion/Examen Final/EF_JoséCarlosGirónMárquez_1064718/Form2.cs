using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_JoséCarlosGirónMárquez_1064718
{
    public partial class Form2 : Form
    {
        int N;
        int res;
        Factorial f = new Factorial();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToInt16(textBox1.Text);
                res = f.factorial(N);

                if (N > 0 && N < 32)
                {
                    MessageBox.Show("El factorial del número " + N.ToString() + " es: " + res.ToString());
                }
                else if(N <= 0)
                {
                    MessageBox.Show("Ingresa un número mayor a cero");
                }
                else if (N >= 32)
                {
                    MessageBox.Show("Porfavor, para evitar una sobrecarga ingresa un número menor");
                }

                textBox1.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = "";
            }
        }
    }
}
