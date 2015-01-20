using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld_FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String UserName;
            UserName = textBox1.Text;
            if (UserName != "")
                MessageBox.Show("Hello, " + UserName + "!");
            else
                MessageBox.Show("Please Enter your Name First");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label5.Text=="0")
                int newvalue = 1;
                label5.Text = newvalue;

            
        }


    }
}
