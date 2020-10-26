using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenCorto_Jose_Carlos_Giron_1064718
{
    public partial class Form1 : Form
    {
        int[,] matriz = new int[5, 5] { { 10, 20, 30, 40, 50 }, { 100, 90 , 80, 70, 60}, { 110, 120 ,130, 140, 150}, { 200, 190, 180, 170, 160}, { 210, 220, 230, 240, 250} };
        int[,] transpuesta = new int[5, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;

            try
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows.Add();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        this.dataGridView1.Rows[i].Cells[j].Value = matriz[i, j];
                    }
                }

                button1.Visible = false;
            }
            catch(Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Visible = true;

            try
            {
                this.dataGridView2.Rows.Add();
                this.dataGridView2.Rows.Add();
                this.dataGridView2.Rows.Add();
                this.dataGridView2.Rows.Add();
                this.dataGridView2.Rows.Add();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        this.dataGridView2.Rows[i].Cells[j].Value = matriz[j, i];
                    }
                }

                button2.Visible = false;

            }
            catch (Exception ex)
            {

            }
        }
    }
}
