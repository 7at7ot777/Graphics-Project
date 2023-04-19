using System.Diagnostics;
using System.Drawing;

namespace Graphics_1st_try
{
    public partial class Form1 : Form
    {

        //Bresenham Circle Algorithm
        void drawCircle(int xc, int yc, int x, int y)
        {
            var draw = panel1.CreateGraphics();
            var aBrushers = Brushes.Green;
            //xc yc is the origin
            draw.FillRectangle(aBrushers, xc + x, yc + y, 2, 2);
            draw.FillRectangle(aBrushers, xc - x, yc + y, 2, 2);
            draw.FillRectangle(aBrushers, xc + x, yc - y, 2, 2);
            draw.FillRectangle(aBrushers, xc - x, yc - y, 2, 2);
            draw.FillRectangle(aBrushers, xc + y, yc + x, 2, 2);
            draw.FillRectangle(aBrushers, xc - y, yc + x, 2, 2);
            draw.FillRectangle(aBrushers, xc + y, yc - x, 2, 2);
            draw.FillRectangle(aBrushers, xc - y, yc - x, 2, 2);
        }
        void circleBres(int xc, int yc, int r)
        {
            int x = 0, y = r;
            int d = 3 - 2 * r;
            // drawCircle(xc + (panel1.Width / 2), (panel1.Height / 2) - yc, x + (panel1.Width / 2), (panel1.Height / 2) - y);
            drawCircle(xc, yc, x, y);

            while (y >= x)
            {
                // for each pixel we will
                // draw all eight pixels

                x++;

                // check for decision parameter
                // and correspondingly
                // update d, x, y
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                    d = d + 4 * x + 6;
                   drawCircle(xc, yc, x, y);
            //    drawCircle(xc + (panel1.Width / 2), (panel1.Height / 2) - yc, x + (panel1.Width / 2), (panel1.Height / 2) - y);


            }
        }







        //Bersenham Line Algorithm
        void lineBres(int x0, int y0, int xEnd, int yEnd)
        {
            var draw = panel1.CreateGraphics();
            var aBrushers = Brushes.LightBlue;

            int dx = Math.Abs(xEnd - x0), dy = Math.Abs(yEnd - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);

            /* Determine which endpoint to use as start position.  */
            if (x0 > xEnd)
            {
                x = xEnd; y = yEnd; xEnd = x0;
            }
            else
            {
                x = x0; y = y0;
            }
            draw.FillRectangle(aBrushers, round(x) + (panel1.Width / 2), (panel1.Height / 2) - round(y), 4, 4);

            while (x < xEnd)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                draw.FillRectangle(aBrushers, round(x) + (panel1.Width / 2), (panel1.Height / 2) - round(y), 4, 4);
            }
        }
        //DDA Algorithm   
        int round(float a) { return Convert.ToInt32(a + 0.5); }
        //int round(double a) { return Convert.ToInt32(a + 0.5); }
        void lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            var draw = panel1.CreateGraphics();
            var aBrushers = Brushes.Black;


            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)(dx) / (float)(steps);
            yIncrement = (float)(dy) / (float)(steps);

            draw.FillRectangle(aBrushers, round(x) + (panel1.Width / 2), (panel1.Height / 2) - round(y), 2, 2);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                draw.FillRectangle(aBrushers, round(x) + (panel1.Width / 2), (panel1.Height / 2) - round(y), 2, 2);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x0 = Convert.ToInt32(X0.Text);
            var xEnd = Convert.ToInt32(XEnd.Text);
            var y0 = Convert.ToInt32(Y0.Text);
            var yEnd = Convert.ToInt32(YEnd.Text);

            lineDDA(x0, y0, xEnd, yEnd);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Bersenham_Click(object sender, EventArgs e)
        {
            var x0 = Convert.ToInt32(X0.Text);
            var xEnd = Convert.ToInt32(XEnd.Text);
            var y0 = Convert.ToInt32(Y0.Text);
            var yEnd = Convert.ToInt32(YEnd.Text);

            lineBres(x0, y0, xEnd,  yEnd);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var xc = Convert.ToInt32(Xc.Text);
            var yc = Convert.ToInt32(Yc.Text);
            var rad = Convert.ToInt32(radius.Text);
            circleBres(xc + (panel1.Width / 2), (panel1.Height / 2) - yc, rad);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void DrawElipse_Click(object sender, EventArgs e)
        {
            var xc = Convert.ToInt32(ElipseXc.Text);
            var yc = Convert.ToInt32(ElipseYc.Text);
            var rx = Convert.ToInt32(RadiusX.Text);
            var ry = Convert.ToInt32(RadiusX.Text);

            BersenhamElipse(xc, yc, rx, ry);

        }
        private void EllipsPoint(int xc, int yc, int x, int y)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            g.FillRectangle(aBrush, (xc + x), (yc + y), 1, 1);
            g.FillRectangle(aBrush, (xc - x), (yc + y), 1, 1);
            g.FillRectangle(aBrush, (xc + x), (yc - y), 1, 1);
            g.FillRectangle(aBrush, (xc - x), (yc - y), 1, 1);
        }

        private void BersenhamElipse(int xc, int yc, int rx, int ry)
        {
            double x = 0;
            double y = ry;
            double pk = (ry * ry) - (rx * rx * ry) + (0.25 * rx * rx);
            EllipsPoint(xc, yc, (int)x, (int)y);
            Debug.WriteLine("first one");
            Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk=" + pk);

            while ((ry * ry * x) < (rx * rx * y))
            {
                x++;
                if (pk < 0)
                {
                    pk += (2 * ry * ry * x) + (ry * ry);
                }
                else
                {
                    y--;
                    pk += (2 * ry * ry * x) + (ry * ry) - (2 * rx * rx * y);
                }
                EllipsPoint(xc, yc, (int)x, (int)y);
                Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk=" + pk);
            }
            Debug.WriteLine("second one");
            pk = (((ry * ry) * ((x + 0.5) * (x + 0.5))) + ((rx * rx) * ((y - 1) * (y - 1))) - (rx * rx * ry * ry));
            Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk=" + pk);
            while (y > 0)
            {
                y--;
                if (pk > 0)
                {
                    pk += (rx * rx) - (2 * rx * rx * y);
                }
                else
                {
                    x++;
                    pk += (rx * rx) - (2 * rx * rx * y) + (2 * ry * ry * x);
                }
                EllipsPoint(xc, yc, (int)x, (int)y);
                Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk=" + pk);
            }
        }

        private void drawAxis()
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            //X axis
            for (int i = 0; i < panel1.Width; i++)
            {
                g.FillRectangle(aBrush, i , panel1.Height/2 , 1, 1);

            }
            for (int i = 0; i < panel1.Height; i++)
            {
                g.FillRectangle(aBrush, panel1.Width / 2, i, 1, 1);

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel1.Refresh();
            drawAxis();
        }


        /*void BersenhamElipse(int xc , int yc, int rx, int ry)
        {
            var draw = panel1.CreateGraphics();
           
            var aBrushers = Brushes.Black;

            double dx, dy, d1, d2, x, y;
                x = 0;
                y = ry;

                // Initial decision parameter of region 1
                d1 = (ry * ry) - (rx * rx * ry) +
                                 (0.25 * rx * rx);
                dx = 2 * ry * ry * x;
                dy = 2 * rx * rx * y;

                // For region 1
                while (dx < dy)
                {

                // Print points based on 4-way symmetry

                draw.FillRectangle(aBrushers, (int)(x + xc), (int)(y + yc), 2, 2);
                draw.FillRectangle(aBrushers, (int)(-x + xc), (int)(y + yc), 2, 2);
                draw.FillRectangle(aBrushers, (int)(x + xc), (int)(-y + yc), 2, 2);
                draw.FillRectangle(aBrushers, (int)(-x + xc), (int)(-y + yc), 2, 2);



                // Checking and updating value of
                // decision parameter based on algorithm
                if (d1 < 0)
                    {
                        x++;
                        dx = dx + (2 * ry * ry);
                        d1 = d1 + dx + (ry * ry);
                    }
                    else
                    {
                        x++;
                        y--;
                        dx = dx + (2 * ry * ry);
                        dy = dy - (2 * rx * rx);
                        d1 = d1 + dx - dy + (ry * ry);
                    }
                }

                // Decision parameter of region 2
                d2 = ((ry * ry) * ((x + 0.5) * (x + 0.5))) +
                     ((rx * rx) * ((y - 1) * (y - 1))) -
                      (rx * rx * ry * ry);

                // Plotting points of region 2
                while (y >= 0)
                {

                // Print points based on 4-way symmetry
                draw.FillRectangle(aBrushers, round(x + xc), round(y + yc), 2, 2);
                draw.FillRectangle(aBrushers, round (- x + xc), round(y + yc), 2, 2);
                draw.FillRectangle(aBrushers, round ( x + xc), round(-y + yc), 2, 2);
                draw.FillRectangle(aBrushers, round ( -x + xc), round(-y + yc), 2, 2);

                    // Checking and updating parameter
                    // value based on algorithm
                    if (d2 > 0)
                    {
                        y--;
                        dy = dy - (2 * rx * rx);
                        d2 = d2 + (rx * rx) - dy;
                    }
                    else
                    {
                        y--;
                        x++;
                        dx = dx + (2 * ry * ry);
                        dy = dy - (2 * rx * rx);
                        d2 = d2 + dx - dy + (rx * rx);
                    }
                
            }
        }*/
    }
}