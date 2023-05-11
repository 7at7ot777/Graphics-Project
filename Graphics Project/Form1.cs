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
            dataGridView1.Rows.Add(xc + x- panel1.Width/2,panel1.Height/2- yc + y, "Cirlce");
            dataGridView1.Rows.Add(xc - x- panel1.Width/2, panel1.Height / 2 - yc + y, "Cirlce");
            dataGridView1.Rows.Add(xc + x- panel1.Width/2, panel1.Height / 2 - yc - y, "Cirlce");
            dataGridView1.Rows.Add(xc - x- panel1.Width/2,panel1.Height/2- yc - y, "Cirlce");
            dataGridView1.Rows.Add(xc + x- panel1.Width/2, panel1.Height / 2 - yc + y, "Cirlce");
            dataGridView1.Rows.Add(xc - x- panel1.Width/2, panel1.Height / 2 - yc + y, "Cirlce");
            dataGridView1.Rows.Add(xc + x- panel1.Width/2, panel1.Height / 2 - yc - y, "Cirlce");
            dataGridView1.Rows.Add(xc - x- panel1.Width/2, panel1.Height / 2 - yc - y, "Cirlce");

            draw.FillRectangle(aBrushers, xc + x, yc + y, 2, 2);//1
            draw.FillRectangle(aBrushers, xc - x, yc + y, 2, 2);
            draw.FillRectangle(aBrushers, xc + x, yc - y, 2, 2);
            draw.FillRectangle(aBrushers, xc - x, yc - y, 2, 2);
            draw.FillRectangle(aBrushers, xc + y, yc + x, 2, 2);
            draw.FillRectangle(aBrushers, xc - y, yc + x, 2, 2);
            draw.FillRectangle(aBrushers, xc + y, yc - x, 2, 2);
            draw.FillRectangle(aBrushers, xc - y, yc - x, 2, 2);
        }
        public void circleBres(int xc, int yc, int r)
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
            dataGridView1.Rows.Add(round(x), round(y), "Bersenham");

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
                dataGridView1.Rows.Add(round(x), round(y), "Bersenham");

                draw.FillRectangle(aBrushers, round(x) + (panel1.Width / 2), (panel1.Height / 2) - round(y), 4, 4);
            }
        }
        //DDA Algorithm   
        public static int round(float a) { return Convert.ToInt32(a + 0.5); }
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

            dataGridView1.Rows.Add(round(x), round(y), "DDA");
            draw.FillRectangle(aBrushers, round(x) + (panel1.Width / 2), (panel1.Height / 2) - round(y), 2, 2);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                dataGridView1.Rows.Add(round(x) , round(y), "DDA");

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
            drawAxis();
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
            drawAxis();
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
            drawAxis();
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

            EllipseMidPoint(rx, ry, xc, yc);

        }

        private void EllipseMidPoint(int xCenter, int yCenter, int rX, int rY)
        {
            drawAxis();
            int dx, dy, p1, p2, x, y;
            x = 0;
            y = rY;
            p1 = Convert.ToInt32(rY * rY) - (rX * rX * rY) +
                    (1 / 4 * rX * rX);

            dx = 2 * rY * rY * x;
            dy = 2 * rX * rX * y;
            EllipsePlotPoints(xCenter, yCenter, x, y);
            //region 1
            while (dx < dy)
            {
                x++;
                dx = dx + (2 * rY * rY);
                if (p1 < 0)
                {

                    p1 = p1 + dx + (rY * rY);
                }

                else
                {
                    y--;
                    dy = dy - (2 * rX * rX);
                    p1 = p1 + dx - dy + (rY * rY);
                }
                EllipsePlotPoints(xCenter, yCenter, x, y);
            }



            //region 2
            p2 = Convert.ToInt32((rY * rY) * ((x + 1 / 2) * (x + 1 / 2)))
                + ((rX * rX) * ((y - 1) * (y - 1)))
                - (rX * rX * rY * rY);

            while (y >= 0)
            {
                y--;
                dy = dy - (2 * rX * rX);
                if (p2 > 0)
                {

                    p2 = p2 + (rX * rX) - dy;
                }
                else
                {
                    x++;
                    dx = dx + (2 * rY * rY);
                    p2 = p2 + dx - dy + (rX * rX);
                }
                EllipsePlotPoints(xCenter, yCenter, x, y);
            }

        }

        private void EllipsePlotPoints(int xc, int yc, int x, int y)
        {

            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            dataGridView1.Rows.Add((xc + x), (yc + y), "Elipse");
            dataGridView1.Rows.Add((xc - x), (yc + y), "Elipse");
            dataGridView1.Rows.Add((xc + x), (yc - y), "Elipse");
            dataGridView1.Rows.Add((xc - x), (yc - y), "Elipse");

            g.FillRectangle(aBrush, (xc + x) + (panel1.Width / 2), (panel1.Height / 2) - (yc + y), 1, 1);
            g.FillRectangle(aBrush, (xc - x) + (panel1.Width / 2), (panel1.Height / 2) - (yc + y), 1, 1);
            g.FillRectangle(aBrush, (xc + x) + (panel1.Width / 2), (panel1.Height / 2) - (yc - y), 1, 1);
            g.FillRectangle(aBrush, (xc - x) + (panel1.Width / 2), (panel1.Height / 2) - (yc - y), 1, 1);
        }



        private void drawAxis()
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            //X axis
            for (int i = 0; i < panel1.Width; i++)
            {
                g.FillRectangle(aBrush, i, panel1.Height / 2, 1, 1);

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

        private void button2_Click(object sender, EventArgs e)
        {
            _2DTransformation secound_form = new _2DTransformation();

            secound_form.Show();
            this.Hide();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}