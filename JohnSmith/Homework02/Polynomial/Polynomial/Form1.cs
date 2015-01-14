using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polynomial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {
            double dbl_input = 0;

            // get value from data entry textbox
            // convert entered text to floating point, pop message if data is NaN
            bool bln_entryError = false;
            try
            {
                dbl_input = double.Parse(this.txtbox_dataentry.Text);
            }
            catch (System.FormatException)
            {
                dbl_input = 0;
                MessageBox.Show("Please enter a number.\nYou entered:\n\"" + this.txtbox_dataentry.Text + "\"");
                bln_entryError = true;
            }

            // process polynomial
            // 3x^3 - 5x^2 + 6
            double dbl_result = 3 * Math.Pow(dbl_input, 3) - 5 * Math.Pow(dbl_input, 2) + 6;

            // put result into result textbox
            if (!bln_entryError)
            {
                this.txtbox_result.Text = dbl_result.ToString();
            }
            else
            {
                this.txtbox_result.Text = "";
            }
        }
    }
}
