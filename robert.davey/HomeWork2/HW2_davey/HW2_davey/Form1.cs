﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_davey
{
    internal enum Turn
    {
        x,
        o,
    };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void OnButtonClick(object sender, EventArgs e)
        {
            
            MessageBox.Show("hello world");
        }
       
    }
}
