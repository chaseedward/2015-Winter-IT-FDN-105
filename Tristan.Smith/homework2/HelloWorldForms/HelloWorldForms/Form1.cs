using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForms
{
    public partial class Form1 : Form
    {
        bool Button1Click = true;
        int Number;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button1Click = !Button1Click;
            textBox1.Text = "Hello World!";

            if (!Button1Click)
            {
                button1.Text = "You said it!";
            }
            else
            {
                button1.Text = "Say it!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Greeting = "Hello, " + textBox2.Text + "!";

            if (textBox2.Text == "")
            {
                Greeting = "Hello, nobody!";
            }
            if (textBox2.Text == "instructor")
            {
                Greeting = "Hello, teacher!";
            }
            label2.Text = Greeting;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number++;
            if (Number > 10) Number = 0;
            button3.Text = Number.ToString();
        }
    }
}
