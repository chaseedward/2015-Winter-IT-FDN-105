using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5_Davey
{

    public partial class Form1 : Form
    {
        
       decimal withdrawl;
       decimal deposit;

        public Form1()
        {
            InitializeComponent();
        }

        //enter deposit value into textbox, convert to decimal
        private void DepositBox_TextChanged(object sender, EventArgs e)
        {
            
            deposit = decimal.Parse(DepositBox.Text);

        }

        
        //enter withdrawl value into textbox, convert to decimal
        private void WithdrawlBox_TextChanged(object sender, EventArgs e)
        {
            withdrawl = decimal.Parse(WithdrawlBox.Text);
        }
        private decimal balance ;
        //calculate blance
        private void Balance_Click(object sender, EventArgs e)
        {
            balance = deposit - withdrawl;
            BalanceBox.Text = Convert.ToString("$" + balance);
        }



    }
}
