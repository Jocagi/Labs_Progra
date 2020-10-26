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
    public partial class Form5 : Form
    {
        int generar = 0;
        int aleatorio;

        int[] sumafilas;
        int[] sumacolumnas;

        int[,] matriz = new int[4, 4];

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();


            if (generar == 0)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows.Add();
                generar++;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    aleatorio = r.Next(0, 10);
                    this.dataGridView1.Rows[i].Cells[j].Value = aleatorio.ToString();
                    matriz[i, j] = aleatorio;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sumafilas = new int[4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumafilas[i] += matriz[i, j];
                }
            }

            MessageBox.Show("La suma de la fila 1 es: " + sumafilas[0] + "\nLa suma de la fila 2 es: " + sumafilas[1] + "\nLa suma de la fila 3 es: " + sumafilas[2] + "\nLa suma de la fila 4 es: " + sumafilas[3]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mayor = 0;

            if (sumafilas[0] != 0 || sumafilas[1] != 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (sumafilas[i] > mayor)
                    {
                        mayor = sumafilas[i];
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    if (mayor == sumafilas[i])
                    {
                        MessageBox.Show("La fila " + (i + 1).ToString() + " posee la suma mayor");
                    }

                }

            }
            else
            {
                MessageBox.Show("Oprima el boton suma de cada fila");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sumacolumnas = new int[4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumacolumnas[i] += matriz[j, i];
                }
            }
            
            MessageBox.Show("La suma de la columna 1 es: " + sumacolumnas[0] + "\nLa suma de la columna 2 es: " + sumacolumnas[1] + "\nLa suma de la columna 3 es: " + sumacolumnas[2] + "\nLa suma de la columna 4 es: " + sumacolumnas[3]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int mayor = 0;

            if (sumacolumnas[0] != 0 || sumacolumnas[1] != 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (sumacolumnas[i] > mayor)
                    {
                        mayor = sumacolumnas[i];
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    if (mayor == sumacolumnas[i])
                    {
                        MessageBox.Show("La columna " + (i + 1).ToString() + " posee la suma mayor");
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Oprima el boton suma de cada columna");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int SumaD1 = 0;
            int SumaD2 = 0;

            for (int i = 0; i < 4; i++)
            {
                SumaD1 += matriz[i, i];
            }

            SumaD2 += matriz[0, 3];
            SumaD2 += matriz[1, 2];
            SumaD2 += matriz[2, 1];
            SumaD2 += matriz[3, 0];

            MessageBox.Show("La diagonal 1 suma: " + SumaD1.ToString() + "\nLa diagonal 2 suma: " + SumaD2.ToString() + "\nAmbas diagonales suman: " + (SumaD1+SumaD2).ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int suma = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    suma += matriz[i, j];
                }
            }

            MessageBox.Show("La suma de la matriz es : " + suma.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int promedio;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    suma += matriz[i, j];
                }
            }

            promedio = suma / 16;

            MessageBox.Show("El promedio de la matriz es: " + promedio.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int mayor = -1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] > mayor)
                    {
                        mayor = matriz[i, j];
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] ==mayor)
                    {
                        
                        MessageBox.Show("El numero mayor se ubica en la columna " + (j + 1).ToString() + " y en la fila " + (i + 1).ToString());
                        i = 10;
                        j = 10;
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int menor = 10000000;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] == menor)
                    {
                        MessageBox.Show("El numero mayor se ubica en la columna " + (j + 1).ToString() + " y en la fila " + (i + 1).ToString());
                        i = 10;
                        j = 10;
                    }
                }
            }
        }
    }
}
