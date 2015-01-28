using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        int numb = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void greetMeButton_Click(object sender, EventArgs e)
        {
            if (inputNameBox.Text == "instructor")
            {
                greetingOutput.Text = "Hello, teacher!";
            }

            else
            {
                greetingOutput.Text = "Hello, " + inputNameBox.Text;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            numb++;
            if (numb > 10)
            {
                label1.Text = "Number is too big!";
            }
            else
            {
                label1.Text = Convert.ToString(numb);
            }
        }

        // Something that just go tacked on
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
