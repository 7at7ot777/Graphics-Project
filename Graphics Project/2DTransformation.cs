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
            //DRAW TRIANGLE     

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

            //First Point
            POneX = Convert.ToInt32(P1X.Text);
            POneY = Convert.ToInt32(P1Y.Text);

            //Secound Point 
            PTwoX = Convert.ToInt32(P2X.Text);
            PTwoY = Convert.ToInt32(P2Y.Text);

            //Third Point 
            PThreeX = Convert.ToInt32(P3X.Text);
            PThreeY = Convert.ToInt32(P3Y.Text);


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




            lineDDA(POneX + Dx + (drawPanel.Width) / 2, (drawPanel.Height / 2) - POneY - Dy, PTwoX + Dx + (drawPanel.Width) / 2, (drawPanel.Height / 2) - PTwoY - Dy, aBrushers);
            lineDDA(PTwoX + Dx + (drawPanel.Width) / 2, (drawPanel.Height / 2) - PTwoY - Dy, PThreeX + Dx + (drawPanel.Width) / 2, (drawPanel.Height / 2) - PThreeY - Dy, aBrushers);
            lineDDA(PThreeX + Dx + (drawPanel.Width) / 2, (drawPanel.Height / 2) - PThreeY - Dy, POneX + Dx + (drawPanel.Width) / 2, (drawPanel.Height / 2) - POneY - Dy, aBrushers);

        }



        private void XMirror_Click(object sender, EventArgs e)
        {
            var aBrushers = Brushes.Purple;

            int p1x = POneX * (-1) + (drawPanel.Width) / 2;
            int p1y = (drawPanel.Height / 2) - POneY * (-1);


            int p2x = PTwoX * (-1) + (drawPanel.Width) / 2;
            int p2y = (drawPanel.Height / 2) - PTwoY * (-1);

            int p3x = PThreeX * (-1) + (drawPanel.Width) / 2;
            int p3y = (drawPanel.Height / 2) - PThreeY * (-1);



            lineDDA(p1x, p1y, p2x, p2y, aBrushers);
            lineDDA(p2x, p2y, p3x, p3y, aBrushers);
            lineDDA(p3x, p3y, p1x, p1y, aBrushers);

            Console.WriteLine("lololo");
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            //deg/180 = rad/pi
            var aBrushers = Brushes.Pink;

            double RotationAngle = Convert.ToInt32(angle.Text) * Math.PI / 180;

            int p1x = (int)(POneX * Math.Cos(RotationAngle) - POneY * Math.Sin(RotationAngle)) + (drawPanel.Width) / 2;
            int p1y = (drawPanel.Height / 2) - (int)(POneX * Math.Sin(RotationAngle) + POneY * Math.Cos(RotationAngle));


            int p2x = (int)(PTwoX * Math.Cos(RotationAngle) - PTwoY * Math.Sin(RotationAngle)) + (drawPanel.Width) / 2;
            int p2y = (drawPanel.Height / 2) - (int)(PTwoX * Math.Sin(RotationAngle) + PTwoY * Math.Cos(RotationAngle));

            int p3x = (int)(PThreeX * Math.Cos(RotationAngle) - PThreeY * Math.Sin(RotationAngle)) + (drawPanel.Width) / 2; ;
            int p3y = (drawPanel.Height / 2) - (int)(PThreeX * Math.Sin(RotationAngle) + PThreeY * Math.Cos(RotationAngle));

            lineDDA(p1x, p1y, p2x, p2y, aBrushers);
            lineDDA(p2x, p2y, p3x, p3y, aBrushers);
            lineDDA(p3x, p3y, p1x, p1y, aBrushers);



        }

        private void angle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var aBrushers = Brushes.Purple;

            int p1x = POneX + (drawPanel.Width) / 2;
            int p1y = (drawPanel.Height / 2) - POneY * (-1);


            int p2x = PTwoX + (drawPanel.Width) / 2;
            int p2y = (drawPanel.Height / 2) - PTwoY * (-1);

            int p3x = PThreeX + (drawPanel.Width) / 2;
            int p3y = (drawPanel.Height / 2) - PThreeY * (-1);



            lineDDA(p1x, p1y, p2x, p2y, aBrushers);
            lineDDA(p2x, p2y, p3x, p3y, aBrushers);
            lineDDA(p3x, p3y, p1x, p1y, aBrushers);
        }

        private void YMirror_Click(object sender, EventArgs e)
        {
            var aBrushers = Brushes.Purple;

            int p1x = POneX * (-1) + (drawPanel.Width) / 2;
            int p1y = (drawPanel.Height / 2) - POneY;


            int p2x = PTwoX * (-1) + (drawPanel.Width) / 2;
            int p2y = (drawPanel.Height / 2) - PTwoY;

            int p3x = PThreeX * (-1) + (drawPanel.Width) / 2;
            int p3y = (drawPanel.Height / 2) - PThreeY;



            lineDDA(p1x, p1y, p2x, p2y, aBrushers);
            lineDDA(p2x, p2y, p3x, p3y, aBrushers);
            lineDDA(p3x, p3y, p1x, p1y, aBrushers);
        }

        private void Scale_Click(object sender, EventArgs e)
        {

            var aBrushers = Brushes.RoyalBlue;

            int multX = Convert.ToInt32(multiplyX.Text);
            int multY = Convert.ToInt32(multiplyY.Text);

            int p1x = POneX * multX + (drawPanel.Width) / 2;
            int p1y = (drawPanel.Height / 2) - POneY * multY;


            int p2x = PTwoX * multX + (drawPanel.Width) / 2;
            int p2y = (drawPanel.Height / 2) - PTwoY * multY;

            int p3x = PThreeX * multX + (drawPanel.Width) / 2;
            int p3y = (drawPanel.Height / 2) - PThreeY * multY;



            lineDDA(p1x, p1y, p2x, p2y, aBrushers);
            lineDDA(p2x, p2y, p3x, p3y, aBrushers);
            lineDDA(p3x, p3y, p1x, p1y, aBrushers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var aBrushers = Brushes.Brown;

            int sx = Convert.ToInt32(Sx.Text);
            int p1x = POneX + sx * POneY;
            int p2x = PTwoX + sx * PTwoY;
            int p3x = PThreeX + sx * PThreeY;

            p1x = p1x + (drawPanel.Width) / 2;
            int p1y = (drawPanel.Height / 2) - POneY;


            p2x = p2x + (drawPanel.Width) / 2;
            int p2y = (drawPanel.Height / 2) - PTwoY;

            p3x = p3x + (drawPanel.Width) / 2;
            int p3y = (drawPanel.Height / 2) - PThreeY;





            lineDDA(p1x, p1y, p2x, p2y, aBrushers);
            lineDDA(p2x, p2y, p3x, p3y, aBrushers);
            lineDDA(p3x, p3y, p1x, p1y, aBrushers);
        }

        private void ShearY_Click(object sender, EventArgs e)
        {
            var aBrushers = Brushes.Brown;

            int sy = Convert.ToInt32(Sy.Text);

            int p1x = POneX + (drawPanel.Width) / 2;
            int p2x = PTwoX + (drawPanel.Width) / 2;
            int p3x = PThreeX + (drawPanel.Width) / 2;

            int p1y = (drawPanel.Height / 2) - POneX * sy + POneY;
            int p2y = (drawPanel.Height / 2) - PTwoX * sy + PTwoY;
            int p3y = (drawPanel.Height / 2) - PThreeX * sy + PThreeY;




            lineDDA(p1x, p1y, p2x, p2y, aBrushers);
            lineDDA(p2x, p2y, p3x, p3y, aBrushers);
            lineDDA(p3x, p3y, p1x, p1y, aBrushers);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
