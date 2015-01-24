using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld_Form_Session2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
         if (comboBox1.Text == "Choose One")
         {
             MessageBox.Show("Please choose from the dropdown list");
             lblHello.Visible = false;
         }
         else
         {
             lblHello.Visible = true;
             lblHello.Text = comboBox1.Text;
         }
         }
            
        }

    }

