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
    public partial class Form3 : Form
    {
        int A, B, C;
        int res;
        Numeros n = new Numeros();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                A = Convert.ToInt16(textBox1.Text);
                B = Convert.ToInt16(textBox2.Text);
                C = Convert.ToInt16(textBox3.Text);

                if (A<=0 || B<=0 || C<= 0)
                {
                    MessageBox.Show("Porfavor ingrese números mayores a cero.");
                }
                else
                {
                    res = n.Mayor(A, B, C);
                    MessageBox.Show("El número mayor es: " + res.ToString());
                }

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
