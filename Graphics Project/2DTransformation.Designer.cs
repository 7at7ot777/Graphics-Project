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
            XMirror = new Button();
            label6 = new Label();
            label7 = new Label();
            angle = new TextBox();
            Rotate = new Button();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(12, 455);
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
            DrawAxis.Location = new Point(12, 426);
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
            button2.Location = new Point(12, 397);
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
            label4.Location = new Point(9, 224);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 16;
            label4.Text = "Translation";
            // 
            // dy
            // 
            dy.Location = new Point(129, 220);
            dy.Name = "dy";
            dy.Size = new Size(33, 23);
            dy.TabIndex = 15;
            // 
            // dx
            // 
            dx.Location = new Point(90, 220);
            dx.Name = "dx";
            dx.Size = new Size(33, 23);
            dx.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 201);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 17;
            label5.Text = "_________________________";
            // 
            // Translation
            // 
            Translation.Location = new Point(14, 249);
            Translation.Name = "Translation";
            Translation.Size = new Size(136, 23);
            Translation.TabIndex = 18;
            Translation.Text = "Translate Triangle";
            Translation.UseVisualStyleBackColor = true;
            Translation.Click += Translation_Click;
            // 
            // XMirror
            // 
            XMirror.AccessibleName = "XMirror";
            XMirror.Location = new Point(12, 169);
            XMirror.Name = "XMirror";
            XMirror.Size = new Size(136, 23);
            XMirror.TabIndex = 19;
            XMirror.Text = "X Axis Mirror";
            XMirror.UseVisualStyleBackColor = true;
            XMirror.Click += XMirror_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 272);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 20;
            label6.Text = "_________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 299);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 21;
            label7.Text = "Rotation Angle";
            // 
            // angle
            // 
            angle.AccessibleName = "angle";
            angle.Location = new Point(104, 295);
            angle.Name = "angle";
            angle.Size = new Size(33, 23);
            angle.TabIndex = 22;
            angle.TextChanged += angle_TextChanged;
            // 
            // Rotate
            // 
            Rotate.Location = new Point(14, 324);
            Rotate.Name = "Rotate";
            Rotate.Size = new Size(136, 23);
            Rotate.TabIndex = 23;
            Rotate.Text = "Rotate";
            Rotate.UseVisualStyleBackColor = true;
            Rotate.Click += Rotate_Click;
            // 
            // _2DTransformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 531);
            Controls.Add(Rotate);
            Controls.Add(angle);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(XMirror);
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
        private Button XMirror;
        private Label label6;
        private Label label7;
        private TextBox angle;
        private Button Rotate;
    }
}