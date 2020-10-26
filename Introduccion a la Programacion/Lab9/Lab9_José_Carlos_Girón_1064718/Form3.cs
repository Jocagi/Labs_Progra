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
    public partial class Form3 : Form
    {
        int i=-1, j;
        int[,] celdas = new int[1000,8];

        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add();
            i++;

            if((i)%2 == 0)
            {
                for (j = 0; j < 8; j++)
                {
                    try
                    {
                        if ((j) % 2 != 0)
                        {
                            this.dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }

            if ((i) % 2 != 0)
            {
                for (j = 0; j < 8; j++)
                {
                    try
                    {
                        if ((j) % 2 == 0)
                        {
                            this.dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }

        }
    }
}
