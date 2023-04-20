using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_1st_try
{
    public partial class _2DTransformation : Form
    {
        int POneX, POneY, PTwoX, PTwoY, PThreeX, PThreeY;


        public _2DTransformation()
        {
            InitializeComponent();
        }

        private void _2DTransformation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();
        }

        private void DrawAxis_Click(object sender, EventArgs e)
        {
            DrawAxisFunction();
        }

        private void DrawAxisFunction()
        {
            var aBrush = Brushes.Black;
            var g = drawPanel.CreateGraphics();
            //X axis
            for (int i = 0; i < drawPanel.Width; i++)
            {
                g.FillRectangle(aBrush, i, drawPanel.Height / 2, 1, 1);

            }
            for (int i = 0; i < drawPanel.Height; i++)
            {
                g.FillRectangle(aBrush, drawPanel.Width / 2, i, 1, 1);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //First Point
            POneX = Convert.ToInt32(P1X.Text);
            POneY = Convert.ToInt32(P1Y.Text);

            //Secound Point 
            PTwoX = Convert.ToInt32(P2X.Text);
            PTwoY = Convert.ToInt32(P2Y.Text);

            //Third Point 
            PThreeX = Convert.ToInt32(P3X.Text);
            PThreeY = Convert.ToInt32(P3Y.Text);

            //Draw Lines
            lineDDA(POneX, POneY, PTwoX, PTwoY);
            lineDDA(PTwoX, PTwoY, PThreeX, PThreeY);
            lineDDA(PThreeX, PThreeY, POneX, POneY);


        }

        void lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            var draw = drawPanel.CreateGraphics();
            var aBrushers = Brushes.Black;


            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)(dx) / (float)(steps);
            yIncrement = (float)(dy) / (float)(steps);

            draw.FillRectangle(aBrushers, Form1.round(x) + (drawPanel.Width / 2), (drawPanel.Height / 2) - Form1.round(y), 2, 2);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                draw.FillRectangle(aBrushers, Form1.round(x) + (drawPanel.Width / 2), (drawPanel.Height / 2) - Form1.round(y), 2, 2);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            drawPanel.Refresh();
            DrawAxisFunction();

        }

        private void Translation_Click(object sender, EventArgs e)
        {
            int Dx = Convert.ToInt32(dx.Text);
            int Dy = Convert.ToInt32(dy.Text);

            lineDDA(POneX + Dx, POneY+Dy, PTwoX + Dx, PTwoY+Dy);
            lineDDA(PTwoX + Dx, PTwoY + Dy, PThreeX + Dx, PThreeY + Dy);
            lineDDA(PThreeX + Dx, PThreeY + Dy, POneX + Dx, POneY + Dy);

        }
    }
}
