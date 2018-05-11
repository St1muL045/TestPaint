using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] matr = {
             {0,0,0,0,1,1,0,0,0,0},
             {0,0,0,1,2,2,1,0,1,0},
             {0,0,1,1,2,2,2,1,2,1},
             {0,0,1,2,2,2,2,2,2,1},
             {0,0,1,2,2,2,2,2,1,0},
             {0,0,0,1,2,2,2,1,0,0},
             {0,0,0,0,1,1,1,0,0,0}
            };

        int call = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    label1.Text = label1.Text + String.Format("{0} ", matr[i, j]);
                }
                label1.Text = label1.Text + "\n";
            }

            check(4, 4);

            label2.Text = "";
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    label2.Text = label2.Text + String.Format("{0} ", matr[i, j]);
                }
                label2.Text = label2.Text + "\n";
            }

            label2.Text = label2.Text + "\nВызовов функции: " + call;
        }

        void check(int x, int y)
        {
            call++;
            if (matr[x, y] == 2)
            {
                matr[x, y] = 9;
            }

            if (matr[x + 1, y] == 2)
            {
                check(x + 1, y);
            }
            if (matr[x, y + 1] == 2)
            {
                check(x, y + 1);
            }
            if (matr[x - 1, y] == 2)
            {
                check(x - 1, y);
            }
            if (matr[x, y - 1] == 2)
            {
                check(x, y - 1);
            }
        }
    }
}
