namespace Graphics_1st_try
{
    partial class _2DTransformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Back = new Button();
            drawPanel = new Panel();
            DrawAxis = new Button();
            P1X = new TextBox();
            P1Y = new TextBox();
            label1 = new Label();
            label2 = new Label();
            P2Y = new TextBox();
            P2X = new TextBox();
            label3 = new Label();
            P3Y = new TextBox();
            P3X = new TextBox();
            DrawTriangle = new Button();
            button2 = new Button();
            label4 = new Label();
            dy = new TextBox();
            dx = new TextBox();
            label5 = new Label();
            Translation = new Button();
            OriginMirror = new Button();
            label6 = new Label();
            label7 = new Label();
            angle = new TextBox();
            Rotate = new Button();
            button1 = new Button();
            YMirror = new Button();
            label8 = new Label();
            multiplyY = new TextBox();
            multiplyX = new TextBox();
            Scale = new Button();
            Sx = new TextBox();
            button3 = new Button();
            ShearY = new Button();
            Sy = new TextBox();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(805, 391);
            Back.Name = "Back";
            Back.Size = new Size(136, 23);
            Back.TabIndex = 0;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += button1_Click;
            // 
            // drawPanel
            // 
            drawPanel.BackColor = SystemColors.GradientInactiveCaption;
            drawPanel.Location = new Point(168, 12);
            drawPanel.Name = "drawPanel";
            drawPanel.Size = new Size(611, 426);
            drawPanel.TabIndex = 1;
            // 
            // DrawAxis
            // 
            DrawAxis.Location = new Point(805, 362);
            DrawAxis.Name = "DrawAxis";
            DrawAxis.Size = new Size(136, 23);
            DrawAxis.TabIndex = 2;
            DrawAxis.Text = "Draw Axis";
            DrawAxis.UseVisualStyleBackColor = true;
            DrawAxis.Click += DrawAxis_Click;
            // 
            // P1X
            // 
            P1X.Location = new Point(64, 24);
            P1X.Name = "P1X";
            P1X.Size = new Size(33, 23);
            P1X.TabIndex = 3;
            // 
            // P1Y
            // 
            P1Y.Location = new Point(115, 24);
            P1Y.Name = "P1Y";
            P1Y.Size = new Size(33, 23);
            P1Y.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "Point 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "Point 2";
            // 
            // P2Y
            // 
            P2Y.Location = new Point(115, 62);
            P2Y.Name = "P2Y";
            P2Y.Size = new Size(33, 23);
            P2Y.TabIndex = 7;
            // 
            // P2X
            // 
            P2X.Location = new Point(64, 62);
            P2X.Name = "P2X";
            P2X.Size = new Size(33, 23);
            P2X.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 11;
            label3.Text = "Point 3";
            // 
            // P3Y
            // 
            P3Y.Location = new Point(115, 102);
            P3Y.Name = "P3Y";
            P3Y.Size = new Size(33, 23);
            P3Y.TabIndex = 10;
            // 
            // P3X
            // 
            P3X.Location = new Point(64, 102);
            P3X.Name = "P3X";
            P3X.Size = new Size(33, 23);
            P3X.TabIndex = 9;
            // 
            // DrawTriangle
            // 
            DrawTriangle.Location = new Point(12, 140);
            DrawTriangle.Name = "DrawTriangle";
            DrawTriangle.Size = new Size(136, 23);
            DrawTriangle.TabIndex = 12;
            DrawTriangle.Text = "Draw Triangle";
            DrawTriangle.UseVisualStyleBackColor = true;
            DrawTriangle.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(805, 333);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 13;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 291);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 16;
            label4.Text = "Translation";
            // 
            // dy
            // 
            dy.Location = new Point(129, 287);
            dy.Name = "dy";
            dy.Size = new Size(33, 23);
            dy.TabIndex = 15;
            // 
            // dx
            // 
            dx.Location = new Point(90, 287);
            dx.Name = "dx";
            dx.Size = new Size(33, 23);
            dx.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 268);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 17;
            label5.Text = "_________________________";
            // 
            // Translation
            // 
            Translation.Location = new Point(14, 316);
            Translation.Name = "Translation";
            Translation.Size = new Size(136, 23);
            Translation.TabIndex = 18;
            Translation.Text = "Translate Triangle";
            Translation.UseVisualStyleBackColor = true;
            Translation.Click += Translation_Click;
            // 
            // OriginMirror
            // 
            OriginMirror.AccessibleName = "OriginMirror";
            OriginMirror.Location = new Point(12, 169);
            OriginMirror.Name = "OriginMirror";
            OriginMirror.Size = new Size(136, 23);
            OriginMirror.TabIndex = 19;
            OriginMirror.Text = "Origin Mirror";
            OriginMirror.UseVisualStyleBackColor = true;
            OriginMirror.Click += XMirror_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 339);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 20;
            label6.Text = "_________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 366);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 21;
            label7.Text = "Rotation Angle";
            // 
            // angle
            // 
            angle.AccessibleName = "angle";
            angle.Location = new Point(104, 362);
            angle.Name = "angle";
            angle.Size = new Size(33, 23);
            angle.TabIndex = 22;
            angle.TextChanged += angle_TextChanged;
            // 
            // Rotate
            // 
            Rotate.Location = new Point(14, 391);
            Rotate.Name = "Rotate";
            Rotate.Size = new Size(136, 23);
            Rotate.TabIndex = 23;
            Rotate.Text = "Rotate";
            Rotate.UseVisualStyleBackColor = true;
            Rotate.Click += Rotate_Click;
            // 
            // button1
            // 
            button1.AccessibleName = "XMirror";
            button1.Location = new Point(14, 198);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 24;
            button1.Text = "X Axis Mirror";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // YMirror
            // 
            YMirror.AccessibleName = "YMirror";
            YMirror.Location = new Point(14, 227);
            YMirror.Name = "YMirror";
            YMirror.Size = new Size(136, 23);
            YMirror.TabIndex = 25;
            YMirror.Text = "Y Axis Mirror";
            YMirror.UseVisualStyleBackColor = true;
            YMirror.Click += YMirror_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(798, 34);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 28;
            label8.Text = "Scaling";
            // 
            // multiplyY
            // 
            multiplyY.AccessibleName = "multiplyY";
            multiplyY.Location = new Point(901, 29);
            multiplyY.Name = "multiplyY";
            multiplyY.Size = new Size(33, 23);
            multiplyY.TabIndex = 27;
            // 
            // multiplyX
            // 
            multiplyX.AccessibleName = "multiplyX";
            multiplyX.Location = new Point(850, 29);
            multiplyX.Name = "multiplyX";
            multiplyX.Size = new Size(33, 23);
            multiplyX.TabIndex = 26;
            // 
            // Scale
            // 
            Scale.AccessibleName = "Scale";
            Scale.Location = new Point(798, 59);
            Scale.Name = "Scale";
            Scale.Size = new Size(136, 23);
            Scale.TabIndex = 29;
            Scale.Text = "Scale";
            Scale.UseVisualStyleBackColor = true;
            Scale.Click += Scale_Click;
            // 
            // Sx
            // 
            Sx.AccessibleName = "Sx";
            Sx.Location = new Point(798, 88);
            Sx.Name = "Sx";
            Sx.Size = new Size(33, 23);
            Sx.TabIndex = 30;
            // 
            // button3
            // 
            button3.AccessibleName = "Scale";
            button3.Location = new Point(850, 88);
            button3.Name = "button3";
            button3.Size = new Size(84, 23);
            button3.TabIndex = 31;
            button3.Text = "Shear X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ShearY
            // 
            ShearY.AccessibleName = "ShearY";
            ShearY.Location = new Point(850, 117);
            ShearY.Name = "ShearY";
            ShearY.Size = new Size(84, 23);
            ShearY.TabIndex = 33;
            ShearY.Text = "Shear Y";
            ShearY.UseVisualStyleBackColor = true;
            ShearY.Click += ShearY_Click;
            // 
            // Sy
            // 
            Sy.AccessibleName = "Sy";
            Sy.Location = new Point(798, 117);
            Sy.Name = "Sy";
            Sy.Size = new Size(33, 23);
            Sy.TabIndex = 32;
            // 
            // _2DTransformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 453);
            Controls.Add(ShearY);
            Controls.Add(Sy);
            Controls.Add(button3);
            Controls.Add(Sx);
            Controls.Add(Scale);
            Controls.Add(label8);
            Controls.Add(multiplyY);
            Controls.Add(multiplyX);
            Controls.Add(YMirror);
            Controls.Add(button1);
            Controls.Add(Rotate);
            Controls.Add(angle);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(OriginMirror);
            Controls.Add(Translation);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dy);
            Controls.Add(dx);
            Controls.Add(button2);
            Controls.Add(DrawTriangle);
            Controls.Add(label3);
            Controls.Add(P3Y);
            Controls.Add(P3X);
            Controls.Add(label2);
            Controls.Add(P2Y);
            Controls.Add(P2X);
            Controls.Add(label1);
            Controls.Add(P1Y);
            Controls.Add(P1X);
            Controls.Add(DrawAxis);
            Controls.Add(drawPanel);
            Controls.Add(Back);
            Name = "_2DTransformation";
            Text = "_2DTransformation";
            Load += _2DTransformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Panel drawPanel;
        private Button DrawAxis;
        private TextBox P1X;
        private TextBox P1Y;
        private Label label1;
        private Label label2;
        private TextBox P2Y;
        private TextBox P2X;
        private Label label3;
        private TextBox P3Y;
        private TextBox P3X;
        private Button DrawTriangle;
        private Button button2;
        private Label label4;
        private TextBox dy;
        private TextBox dx;
        private Label label5;
        private Button Translation;
        private Button reflectOnXAixs;
        private Button OriginMirror;
        private Label label6;
        private Label label7;
        private TextBox angle;
        private Button Rotate;
        private Button button1;
        private Button YMirror;
        private Label label8;
        private TextBox multiplyY;
        private TextBox multiplyX;
        private Button Scale;
        private TextBox Sx;
        private Button button3;
        private Button ShearY;
        private TextBox Sy;
    }
}