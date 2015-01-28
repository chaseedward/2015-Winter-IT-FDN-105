using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace in_class_project_ttt
{
    enum Turn
    {
        X,
        O,
    };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Turn turn = Turn.X;

        private void OnButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;

            button.Text = turn.ToString();

            if (turn == Turn.X)
            {
                turn = Turn.O;
            }
            else
            {
                turn = Turn.X;
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                MessageBox.Show(button1.Text + " won");
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                MessageBox.Show(button4.Text + " won");
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                MessageBox.Show(button7.Text + " won");
            }
        }
    }
}
