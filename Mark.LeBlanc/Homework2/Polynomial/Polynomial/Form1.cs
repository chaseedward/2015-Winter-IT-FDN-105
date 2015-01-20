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
    public partial class Polynomial : Form
    {
        //New list for polynomial
        List<string> _items = new List<string>();
        private double xValue = 0;

        public Polynomial()
        {
            InitializeComponent();

            _items.Add("x^2 + 2x + 5"); 
            _items.Add("3x^3 - 5x^2 + 6");
            _items.Add("6x^4 + 8x^3 - 11");

            Polynomial_list.DataSource = _items;
        }

        private void Polynomial_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void x_value_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Evaluate_Click(object sender, EventArgs e)
        {
            bool result = double.TryParse(x_value_input.Text, out xValue);

            if (!result)
            {
                MessageBox.Show("Proper values only please!");
            }
            else
            {
                switch (Polynomial_list.SelectedIndex)
                {
                    case 0:
                        {
                            //x^2 + 2x + 5
                            ResultLabel.Text = Convert.ToString((Math.Pow(xValue, 2) + (2 * xValue) + 5));
                            break;
                        }
                    case 1:
                        {
                            //3x^3 - 5x^2 + 6
                            ResultLabel.Text = Convert.ToString(((3 * Math.Pow(xValue, 3)) - (5 * Math.Pow(xValue, 2)) + 6));
                            break;
                        }
                    case 2:
                        {
                            //6x^4 + 8x^3 - 11
                            ResultLabel.Text = Convert.ToString(((6 * (Math.Pow(xValue, 4)) + (8 * Math.Pow(xValue, 3)) - 11)));
                            break;
                        }
                }        
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
