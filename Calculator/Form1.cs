using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calcolatrice : Form
    {

        private char[,] buttons =
        {
            { '%', '\u0152', 'C', '\u232B' },
            { '\u215F', '\u00B2', '\u221A', '\u00F7' },
            { '7', '8', '9', 'x' },
            { '4', '5', '6', '-' },
            { '1', '2', '3', '+' },
            { '\u00B1', '=', ',', '=' }
        };
        public Calcolatrice()
        {
            InitializeComponent();
        }

        private void Calcolatrice_Load(object sender, EventArgs e)
        {
            makebuttons();
        }

        private void makebuttons()
        {
            int btnWidth = 80;
            int btnHeight = 60;
            int posY = 135;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                int posX = 0;
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Width = btnWidth;
                    btn.Height = btnHeight;
                    btn.Top = posY;
                    btn.Left = posX;
                    btn.Font = new Font("Seogoe UI", 16);
                    btn.Text = buttons[i, j].ToString();
                    btn.BackColor = Color.White;
                    Controls.Add(btn);
                    posX += btnWidth;
                }
                posY += btnHeight;
            }
        }
    }
}
