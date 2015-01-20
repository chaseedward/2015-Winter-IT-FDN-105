using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2___WFA_Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Hello World!");
            }
            
            else
            {
                MessageBox.Show("Check the box first pls");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Something")
            {
                MessageBox.Show("Good job World! You typed in Something!");
            }

            else
            {
                MessageBox.Show("Type in 'Something'");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, " + textBox1.Text);
        }
    }
}
