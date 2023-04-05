using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakPoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";


            //for (int i = 0; i <= 10; i++)
            //{

            //    for (int j = 0; j <= i; j++)
            //    {
            //        label1.Text += ;
            //    }
            //    label1.Text += "* \n";
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    label1.Text += "\n";
            //    for (int j = 1; j <=i; j++)
            //    {
            //        label1.Text += j;

            //    }
            //}

            /*
             Çarpım Taplosu yapımı

            1 * 1 = 1
            gibi 9*9=81 'e kadar yapınız
             */

            for (int i = 1; i <= 9; i++)
            {
                label1.Text += "\n";
                for (int j = 1; j <= 9; j++)
                {
                    label1.Text += i + " * " + j + "=" + i * j;
                    label1.Text += "\n";
                }
            }

        }
    }
}
