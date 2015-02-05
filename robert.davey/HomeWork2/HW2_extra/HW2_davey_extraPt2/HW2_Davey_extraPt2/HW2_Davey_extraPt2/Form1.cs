using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_Davey_extraPt2
{ 
    public partial class Form1 : Form
    {

        private int Counter;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //convert int Counter to string
            Counter = Int32.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Counter++;
            //convert int Counter to string
            textBox1.Text = Convert.ToString(Counter);
        }
    }
}
