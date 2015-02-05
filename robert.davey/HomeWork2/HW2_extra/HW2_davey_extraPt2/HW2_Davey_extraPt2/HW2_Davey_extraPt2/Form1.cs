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
            //part 3 requirement
            if (Counter > 10)
            { 
                textBox1.Text = "0";
                //dont know why this displays twice???
                MessageBox.Show("Number is to big!");
               
            }

            else
            {


                Counter = Int32.Parse(textBox1.Text);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Counter++;
            textBox1.Text = Convert.ToString(Counter);
        }
    }
}
