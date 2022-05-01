using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_lab_prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 7;
            dataGridView1.ColumnCount = 7;
            dataGridView2.RowCount = 7;
            dataGridView2.ColumnCount = 7;
            int[,] A = new int[7, 7];
            int i,j;
            int imax=0,jmax=0;
            int temp = 0;
            Random rand = new Random();
            for (i = 0; i < 7; i++)
                for (j = 0; j < 7; j++)
                    A[i, j] = rand.Next(-10, 10);
            for (i = 0; i < 7; i++)
                for (j = 0; j < 7; j++)
                    dataGridView1.Rows[i].Cells[j].Value = A[i, j].ToString();
            int max1 = A[0, 0]; 
            for ( i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, i] > max1)
                {
                    max1 = A[i, i];
                    imax = i;
                    jmax = i;
                }   
            }
            for ( i = 0; i < A.GetLength(0); i++)
            {  
                    if ( A[i,A.GetLength(0)-1-i] > max1)
                        max1 =  A[i,  A.GetLength(0) - 1-i];
                imax = i;
                jmax = i;
            }
            temp = A[A.GetLength(0) / 2, A.GetLength(0) / 2];
            A[A.GetLength(0) / 2, A.GetLength(0) / 2] = max1;
            A[imax,jmax]=temp;
            for (i = 0; i < 7; i++)
                for (j = 0; j < 7; j++)
                    dataGridView2.Rows[i].Cells[j].Value = A[i, j].ToString();
            textBox1.Text = Convert.ToString(max1);
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
        }
    }
}
