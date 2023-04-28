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
        int POneX { set; get; }
        int POneY { set; get; }
        int PTwoX { set; get; }
        int PTwoY { set; get; }
        int PThreeX { set; get; }
        int PThreeY { set; get; }
        int Dx = 0, Dy = 0;
        int[,] translationMatrix = {{ 1, 0, 2 }, //2 Will be overridden with Dx and Dy
                                    {0,1, 2},
                                     {0,0,1} };



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

        public void button1_Click_1(object sender, EventArgs e)
        {
            DrawAxisFunction();

            var aBrushers = Brushes.Black;


            //First Point
            POneX = Convert.ToInt32(P1X.Text) + (drawPanel.Width / 2);
            POneY = (drawPanel.Height / 2) - Convert.ToInt32(P1Y.Text);

            //Secound Point 
            PTwoX = Convert.ToInt32(P2X.Text) + (drawPanel.Width / 2);
            PTwoY = (drawPanel.Height / 2) - Convert.ToInt32(P2Y.Text);

            //Third Point 
            PThreeX = Convert.ToInt32(P3X.Text) + (drawPanel.Width / 2);
            PThreeY = (drawPanel.Height / 2) - Convert.ToInt32(P3Y.Text);

            //Draw Lines

            //T = new Transformation(POneX, POneY, PTwoX, PTwoY, PThreeX, PThreeY, drawPanel);

            lineDDA(POneX, POneY, PTwoX, PTwoY, aBrushers);
            lineDDA(PTwoX, PTwoY, PThreeX, PThreeY, aBrushers);
            lineDDA(PThreeX, PThreeY, POneX, POneY, aBrushers);


        }

        void lineDDA(int x0, int y0, int xEnd, int yEnd, Brush brush)
        {
            Console.WriteLine("dda");
            var draw = drawPanel.CreateGraphics();
            var aBrushers = brush;


            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)(dx) / (float)(steps);
            yIncrement = (float)(dy) / (float)(steps);

            draw.FillRectangle(aBrushers, Form1.round(x), Form1.round(y), 2, 2);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                draw.FillRectangle(aBrushers, Form1.round(x), Form1.round(y), 2, 2);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            drawPanel.Refresh();
            DrawAxisFunction();

        }

        private void Translation_Click(object sender, EventArgs e)
        {
            var aBrushers = Brushes.BlueViolet;


            Dx = Convert.ToInt32(dx.Text);
            Dy = Convert.ToInt32(dy.Text);

            //  int[] point1 = Transaltion(P1X, P1Y); 




            lineDDA(POneX + Dx, POneY - Dy, PTwoX + Dx, PTwoY - Dy, aBrushers);
            lineDDA(PTwoX + Dx, PTwoY - Dy, PThreeX + Dx, PThreeY - Dy, aBrushers);
            lineDDA(PThreeX + Dx, PThreeY - Dy, POneX + Dx, POneY - Dy, aBrushers);

        }

        public int[] Transaltion(int x, int y)
        {
            translationMatrix[0, 2] = Dx;
            translationMatrix[1, 2] = Dy;

            int[] result = new int[6];
            int[] points = { x, y, 1 };

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 0; k++)
                {
                    result[i] = translationMatrix[i, k] * points[k];
                }
            }
            return result;
        }

        private void XMirror_Click(object sender, EventArgs e)
        {
            var aBrushers = Brushes.Pink;

            int p1x = POneX / (-1);
            int p1y = POneY / (-1);


            int p2x = PTwoX / (-1);
            int p2y = PTwoY / (-1);

            int p3x = PThreeX / (-1);
            int p3y = PThreeY / (-1);

            lineDDA(p1x, p1y, p2x, p2y, aBrushers);
            lineDDA(p2x, p2y, p3x, p3y, aBrushers);
            lineDDA(p3x, p3y, p1x, p1y, aBrushers);

            Console.WriteLine("lololo");
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            var aBrushers = Brushes.Pink;

            int RotationAngle = Convert.ToInt32(angle.Text);

            int p1x = (int)(POneX * Math.Cos(RotationAngle) - POneY * Math.Sin(RotationAngle));
            int p1y =(int)( POneX * Math.Sin(RotationAngle) + POneY * Math.Cos(RotationAngle));


            int p2x = (int)(PTwoX * Math.Cos(RotationAngle) - PTwoY * Math.Sin(RotationAngle));
            int p2y = (int)(PTwoX * Math.Sin(RotationAngle) + PTwoX * Math.Cos(RotationAngle));

            int p3x = (int)(PThreeX * Math.Cos(RotationAngle) - PThreeY * Math.Sin(RotationAngle));
            int p3y = (int)(PThreeX * Math.Sin(RotationAngle) + PThreeX * Math.Cos(RotationAngle));

            lineDDA(p1x, p1y, p2x, p2y, aBrushers);
            lineDDA(p2x, p2y, p3x, p3y, aBrushers);
            lineDDA(p3x, p3y, p1x, p1y, aBrushers);



        }

        private void angle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
