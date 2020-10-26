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
    public partial class Form4 : Form
    {
        Random r = new Random();
        int[,] matriz = new int[10,10];
        int contMat = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            int aleatorio = 0;

            //Crear filas
            if (contMat == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    this.dataGridView1.Rows.Add();
                }

                contMat++;
            }

            //Llenar con números aleatorios

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    aleatorio = r.Next(1, 99);
                    this.dataGridView1.Rows[i].Cells[j].Value = aleatorio.ToString();
                    matriz[i, j] = aleatorio;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int Suma = 0;
                int ArribaAbajo = 0;
                int Medio = 0;

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (i == 0 || i == 9)
                        {
                            ArribaAbajo += matriz[i, j];
                            this.dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Aqua;
                        }
                        else
                        {
                            if (j == 0 || j == 9)
                            {
                                Medio += matriz[i, j];
                                this.dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Aqua;
                            }
                        }

                    }
                }

                Suma = ArribaAbajo + Medio;

                MessageBox.Show("La suma del marco es: " + Suma.ToString());

            }
           
             catch (Exception)
            {
                
                throw;
            }
        }
    }
}
