using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGame
{
    public partial class Form1 : Form
    {
        Color Lit = Color.ForestGreen;
        Color Unlit = Color.OrangeRed;
        int xs = 4, ys = 4;
        public bool[,] Lights;
        public Button[,] Buttons;
        public int[,,] Neighbors;
        public MenuStrip mnu = new MenuStrip();

        public Form1()
        {
            InitializeComponent();
        }
        private Button makeBtn(int x, int y)
        {
            Button btn = new Button();
            btn.Size = new Size(40, 40);
            btn.BackColor = Lit;
            btn.TabIndex = y * xs + x;
            btn.Location = new Point(x * 45 + 5, y * 45 + 5 + mnu.Height);
            btn.Click += new EventHandler(this.btnClick);
            this.Controls.Add(btn);
            return btn;
        }
        private bool checkWin()
        {
            bool Won = true;
            foreach (bool x in Lights)
            {
                if (x)
                {
                    Won = false;
                    break;
                }
            }
            return Won;
        }
        private void btnClick(object sender, EventArgs e)
        {
            int a, b;

            Button btn = (Button)sender;
            int x = btn.TabIndex % xs;
            int y = (btn.TabIndex - x) / xs;
            Lights[x, y] = !Lights[x, y];
            btn.BackColor = (Lights[x, y]) ? Lit : Unlit;
            for (int i = 0; i<8; i+=2)
            {
                a = Neighbors[x, y, i];
                b = Neighbors[x, y, i + 1];
                Lights[a, b] = !Lights[a, b];
                Buttons[a,b].BackColor = (Lights[a, b]) ? Lit : Unlit;
            }
            this.Text = checkWin() ? "YEP" : "NOPE";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameInit();
        }
        private void MenuThing(object sender, EventArgs e, int c)
        {
            xs = ys = c;
            GameInit();
        }

        private MenuStrip CreateMenu()
        {
            ToolStripMenuItem newthing;
            ToolStripMenuItem topthing = new ToolStripMenuItem(xs.ToString() + "x" + ys.ToString());
            mnu.Items.Clear();
            mnu.Items.Add(topthing);
            for (int c = 4; c < 7; c++)
            {
                if (c == xs)
                {
                    newthing = new ToolStripMenuItem("RESET");
                }
                else
                {
                    newthing = new ToolStripMenuItem(c.ToString() + "x" + c.ToString());
                }
                switch (c)
                {
                    case 4:
                        newthing.Click += (sender, e) => MenuThing(sender, e, 4);
                        break;
                    case 5:
                        newthing.Click += (sender, e) => MenuThing(sender, e, 5);
                        break;
                    case 6:
                        newthing.Click += (sender, e) => MenuThing(sender, e, 6);
                        break;
                    default:
                        newthing.Click += (sender, e) => MenuThing(sender, e, 4);
                        break;
                }
                topthing.DropDownItems.Add(newthing);
            }
            this.Controls.Add(mnu);
            return mnu;

        }
        private void GameInit()
        {
            this.Controls.Clear();
            this.Text = "NOPE";
            
            Lights = new bool[xs, ys];
            Buttons = new Button[xs, ys];
            Neighbors = new int[xs, ys, 8];
            mnu = CreateMenu();

            this.ClientSize = new Size(xs * 45 + 5, ys * 45 + 5 + mnu.Height);

            // initialize the arrays
            for (int i = 0; i < ys; i++)
            {
                for (int j = 0; j < xs; j++)
                {
                    Lights[j, i] = true;
                    Buttons[j, i] = makeBtn(j, i);

                    // Neighbors keeps track of which buttons are also changed when you click one.
                    // 8 ints keep track of four x,y coordinates.  Coordinates are initialized:
                    // top, left, right, bottom.

                    Neighbors[j, i, 0] = j;
                    Neighbors[j, i, 1] = (i - 1 < 0) ? ys - 1 : i - 1;
                    Neighbors[j, i, 2] = (j - 1 < 0) ? xs - 1 : j - 1;
                    Neighbors[j, i, 3] = i;
                    Neighbors[j, i, 4] = (j + 1 > xs - 1) ? 0 : j + 1;
                    Neighbors[j, i, 5] = i;
                    Neighbors[j, i, 6] = j;
                    Neighbors[j, i, 7] = (i + 1 > ys - 1) ? 0 : i + 1;
                }
            }
        }
    }
}
