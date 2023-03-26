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
            draw.FillRectangle(aBrushers, xc + x, yc + y, 2,2);
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
            draw.FillRectangle(aBrushers, round(x), round(y), 4, 4);

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
                draw.FillRectangle(aBrushers, round(x), round(y),4, 4);
            }
        }
        //DDA Algorithm   
        int round(float a) { return Convert.ToInt32(a + 0.5); }
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

        draw.FillRectangle(aBrushers,round(x), round(y),2,2);
        for (k = 0; k < steps; k++)
        {
            x += xIncrement;
            y += yIncrement;
                draw.FillRectangle(aBrushers, round(x), round(y), 2, 2);
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
            var x0 = Convert.ToInt32(X0.Text) ;
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

            lineBres(x0, y0, xEnd, yEnd);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var xc = Convert.ToInt32(Xc.Text);
            var yc = Convert.ToInt32(Yc.Text);
            var rad = Convert.ToInt32(radius.Text);
            circleBres(xc, yc, rad);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}