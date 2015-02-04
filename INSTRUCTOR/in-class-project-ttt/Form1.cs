﻿using System;
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

            grid = new Button[3,3];
            grid[0, 0] = button1;
            grid[0, 1] = button2;
            grid[0, 2] = button3;
            grid[1, 0] = button4;
            grid[1, 1] = button5;
            grid[1, 2] = button6;
            grid[2, 0] = button7;
            grid[2, 1] = button8;
            grid[2, 2] = button9;
        }

        private Button[,] grid;

        private Turn turn = Turn.X;

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

            //if (button1.Text == button2.Text && button2.Text == button3.Text)
            //{
            //    MessageBox.Show(button1.Text + " won");
            //}
            //else if (button4.Text == button5.Text && button5.Text == button6.Text)
            //{
            //    MessageBox.Show(button4.Text + " won");
            //}
            //else if (button7.Text == button8.Text && button8.Text == button9.Text)
            //{
            //    MessageBox.Show(button7.Text + " won");
            //}

            // Horizontals
            var won = true;
            var player = "";

            for (var row = 0; row < grid.GetLength(0); row++)
            {
                player = grid[row, 0].Text;

                for (var col = 1; col < grid.GetLength(1); col++)
                {
                    if (player != grid[row, col].Text)
                    {
                        won = false;
                        break;
                    }
                }
            }

            if (won)
            {
                MessageBox.Show(player + " won");
            }

            // Verticals
            //for (cols)
            //{
            //    for (rows)
            //}
        }
    }
}
