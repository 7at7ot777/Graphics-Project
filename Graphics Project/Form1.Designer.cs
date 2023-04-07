namespace Graphics_1st_try
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DDA = new Button();
            X0 = new TextBox();
            label1 = new Label();
            Y0 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            XEnd = new TextBox();
            YEnd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Bersenham = new Button();
            label5 = new Label();
            Draw = new Button();
            label6 = new Label();
            label7 = new Label();
            Xc = new TextBox();
            Yc = new TextBox();
            radius = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ElipseXc = new TextBox();
            ElipseYc = new TextBox();
            RadiusX = new TextBox();
            RadiusY = new TextBox();
            DrawElipse = new Button();
            SuspendLayout();
            // 
            // DDA
            // 
            DDA.AccessibleName = "Draw DDA";
            DDA.Location = new Point(12, 105);
            DDA.Name = "DDA";
            DDA.Size = new Size(117, 22);
            DDA.TabIndex = 0;
            DDA.Text = "Draw DDA";
            DDA.UseVisualStyleBackColor = true;
            DDA.Click += button1_Click;
            // 
            // X0
            // 
            X0.AccessibleName = "y0";
            X0.Location = new Point(62, 29);
            X0.Name = "X0";
            X0.Size = new Size(29, 23);
            X0.TabIndex = 1;
            X0.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 11);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = " X";
            label1.Click += label1_Click;
            // 
            // Y0
            // 
            Y0.AccessibleName = "y0";
            Y0.Location = new Point(97, 29);
            Y0.Name = "Y0";
            Y0.Size = new Size(32, 23);
            Y0.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 11);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "Y";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(155, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 508);
            panel1.TabIndex = 5;
            // 
            // XEnd
            // 
            XEnd.AccessibleName = "xEnd";
            XEnd.Location = new Point(62, 67);
            XEnd.Name = "XEnd";
            XEnd.Size = new Size(29, 23);
            XEnd.TabIndex = 6;
            // 
            // YEnd
            // 
            YEnd.AccessibleName = "yEnd";
            YEnd.Location = new Point(97, 67);
            YEnd.Name = "YEnd";
            YEnd.Size = new Size(32, 23);
            YEnd.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 37);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "Point 1";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 75);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 9;
            label4.Text = "Point 2";
            // 
            // Bersenham
            // 
            Bersenham.Location = new Point(12, 133);
            Bersenham.Name = "Bersenham";
            Bersenham.Size = new Size(117, 23);
            Bersenham.TabIndex = 10;
            Bersenham.Text = "Draw Bersenham ";
            Bersenham.UseVisualStyleBackColor = true;
            Bersenham.Click += Bersenham_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 156);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 11;
            label5.Text = "__________________________";
            label5.Click += label5_Click;
            // 
            // Draw
            // 
            Draw.Location = new Point(12, 291);
            Draw.Name = "Draw";
            Draw.Size = new Size(117, 23);
            Draw.TabIndex = 12;
            Draw.Text = "Draw Circle";
            Draw.UseVisualStyleBackColor = true;
            Draw.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 189);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 13;
            label6.Text = "Point X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 223);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 14;
            label7.Text = "Point Y";
            // 
            // Xc
            // 
            Xc.AccessibleName = "Circle Point X";
            Xc.Location = new Point(63, 186);
            Xc.Name = "Xc";
            Xc.Size = new Size(66, 23);
            Xc.TabIndex = 15;
            // 
            // Yc
            // 
            Yc.AccessibleName = "Yc";
            Yc.Location = new Point(62, 220);
            Yc.Name = "Yc";
            Yc.Size = new Size(66, 23);
            Yc.TabIndex = 16;
            // 
            // radius
            // 
            radius.AccessibleName = "radius";
            radius.Location = new Point(63, 252);
            radius.Name = "radius";
            radius.Size = new Size(66, 23);
            radius.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 256);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 18;
            label8.Text = "Radius";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 349);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 19;
            label9.Text = "Center X";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 313);
            label10.Name = "label10";
            label10.Size = new Size(137, 15);
            label10.TabIndex = 20;
            label10.Text = "__________________________";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 376);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 21;
            label11.Text = "Center Y";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 408);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 22;
            label12.Text = "Rx";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 435);
            label13.Name = "label13";
            label13.Size = new Size(20, 15);
            label13.TabIndex = 23;
            label13.Text = "Ry";
            // 
            // ElipseXc
            // 
            ElipseXc.AccessibleName = "Elipse Xc";
            ElipseXc.Location = new Point(62, 346);
            ElipseXc.Name = "ElipseXc";
            ElipseXc.Size = new Size(66, 23);
            ElipseXc.TabIndex = 24;
            // 
            // ElipseYc
            // 
            ElipseYc.AccessibleName = "Elipse Yc";
            ElipseYc.Location = new Point(62, 373);
            ElipseYc.Name = "ElipseYc";
            ElipseYc.Size = new Size(66, 23);
            ElipseYc.TabIndex = 25;
            // 
            // RadiusX
            // 
            RadiusX.AccessibleName = "RadiusX";
            RadiusX.Location = new Point(62, 402);
            RadiusX.Name = "RadiusX";
            RadiusX.Size = new Size(66, 23);
            RadiusX.TabIndex = 26;
            // 
            // RadiusY
            // 
            RadiusY.AccessibleName = "RadiusY";
            RadiusY.Location = new Point(62, 431);
            RadiusY.Name = "RadiusY";
            RadiusY.Size = new Size(66, 23);
            RadiusY.TabIndex = 27;
            // 
            // DrawElipse
            // 
            DrawElipse.Location = new Point(12, 460);
            DrawElipse.Name = "DrawElipse";
            DrawElipse.Size = new Size(117, 23);
            DrawElipse.TabIndex = 28;
            DrawElipse.Text = "Draw Elipse";
            DrawElipse.UseVisualStyleBackColor = true;
            DrawElipse.Click += DrawElipse_Click;
            // 
            // Form1
            // 
            AccessibleName = "Draw DDA";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 532);
            Controls.Add(DrawElipse);
            Controls.Add(RadiusY);
            Controls.Add(RadiusX);
            Controls.Add(ElipseYc);
            Controls.Add(ElipseXc);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(radius);
            Controls.Add(Yc);
            Controls.Add(Xc);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Draw);
            Controls.Add(label5);
            Controls.Add(Bersenham);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(YEnd);
            Controls.Add(XEnd);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(Y0);
            Controls.Add(label1);
            Controls.Add(X0);
            Controls.Add(DDA);
            Name = "Form1";
            Text = "Draw";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DDA;
        private TextBox X0;
        private Label label1;
        private TextBox Y0;
        private Label label2;
        private System.Windows.Forms.Panel panel1;
        private TextBox XEnd;
        private TextBox YEnd;
        private Label label3;
        private Label label4;
        private Button Bersenham;
        private Label label5;
        private Button Draw;
        private Label label6;
        private Label label7;
        private TextBox Xc;
        private TextBox Yc;
        private TextBox radius;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox ElipseXc;
        private TextBox ElipseYc;
        private TextBox RadiusX;
        private TextBox RadiusY;
        private Button DrawElipse;
    }
}