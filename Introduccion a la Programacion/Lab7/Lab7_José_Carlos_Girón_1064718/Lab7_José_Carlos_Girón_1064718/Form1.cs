using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_José_Carlos_Girón_1064718
{
    public partial class Form1 : Form
    {
        double perimetro, area, volumen, radio;

        private void TBradio_TextChanged(object sender, EventArgs e)
        {

        }

        Circulo circulo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                radio = Convert.ToDouble(TBradio.Text);

                circulo = new Circulo(radio);

                circulo.CalcularGeometria(ref perimetro, ref area, ref volumen);

                label6.Text = Convert.ToString(Math.Truncate(perimetro));
                label5.Text = Convert.ToString(Math.Truncate(area));
                label7.Text = Convert.ToString(Math.Truncate(volumen));
            }
            catch (Exception)
            {
            }
        }
    }
}
