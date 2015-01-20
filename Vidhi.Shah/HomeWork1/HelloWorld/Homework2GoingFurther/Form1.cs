using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2GoingFurther
{
    public partial class Form1 : Form
    {
        private int var1 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tbl = textBox1.Text.ToUpper();

            if (tbl == "INSTRUCTOR")
                label2.Text = "Hello Teacher!";
            else
            {
                label2.Text = "Hello " + textBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (var1 > 10)
            {
                label3.Text = "Too big a number!";
                var1 = 0;
            }
            else
            {
                label3.Text = Convert.ToString(var1);
            }
            var1++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
