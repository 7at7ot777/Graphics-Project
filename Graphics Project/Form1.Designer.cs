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
            this.DDA = new System.Windows.Forms.Button();
            this.X0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Y0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.XEnd = new System.Windows.Forms.TextBox();
            this.YEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bersenham = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Xc = new System.Windows.Forms.TextBox();
            this.Yc = new System.Windows.Forms.TextBox();
            this.radius = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DDA
            // 
            this.DDA.AccessibleName = "Draw DDA";
            this.DDA.Location = new System.Drawing.Point(12, 116);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(117, 22);
            this.DDA.TabIndex = 0;
            this.DDA.Text = "Draw DDA";
            this.DDA.UseVisualStyleBackColor = true;
            this.DDA.Click += new System.EventHandler(this.button1_Click);
            // 
            // X0
            // 
            this.X0.AccessibleName = "y0";
            this.X0.Location = new System.Drawing.Point(62, 40);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(29, 23);
            this.X0.TabIndex = 1;
            this.X0.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = " X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Y0
            // 
            this.Y0.AccessibleName = "y0";
            this.Y0.Location = new System.Drawing.Point(97, 40);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(32, 23);
            this.Y0.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(251, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 406);
            this.panel1.TabIndex = 5;
            // 
            // XEnd
            // 
            this.XEnd.AccessibleName = "xEnd";
            this.XEnd.Location = new System.Drawing.Point(62, 78);
            this.XEnd.Name = "XEnd";
            this.XEnd.Size = new System.Drawing.Size(29, 23);
            this.XEnd.TabIndex = 6;
            // 
            // YEnd
            // 
            this.YEnd.AccessibleName = "yEnd";
            this.YEnd.Location = new System.Drawing.Point(97, 78);
            this.YEnd.Name = "YEnd";
            this.YEnd.Size = new System.Drawing.Size(32, 23);
            this.YEnd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Point 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Point 2";
            // 
            // Bersenham
            // 
            this.Bersenham.Location = new System.Drawing.Point(12, 144);
            this.Bersenham.Name = "Bersenham";
            this.Bersenham.Size = new System.Drawing.Size(117, 23);
            this.Bersenham.TabIndex = 10;
            this.Bersenham.Text = "Draw Bersenham ";
            this.Bersenham.UseVisualStyleBackColor = true;
            this.Bersenham.Click += new System.EventHandler(this.Bersenham_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "__________________________";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(54, 318);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 12;
            this.Draw.Text = "Draw Circle";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Point X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Point Y";
            // 
            // Xc
            // 
            this.Xc.AccessibleName = "Circle Point X";
            this.Xc.Location = new System.Drawing.Point(63, 213);
            this.Xc.Name = "Xc";
            this.Xc.Size = new System.Drawing.Size(66, 23);
            this.Xc.TabIndex = 15;
            // 
            // Yc
            // 
            this.Yc.AccessibleName = "Yc";
            this.Yc.Location = new System.Drawing.Point(62, 247);
            this.Yc.Name = "Yc";
            this.Yc.Size = new System.Drawing.Size(66, 23);
            this.Yc.TabIndex = 16;
            // 
            // radius
            // 
            this.radius.AccessibleName = "radius";
            this.radius.Location = new System.Drawing.Point(63, 279);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(66, 23);
            this.radius.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Radius";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "Draw DDA";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.Yc);
            this.Controls.Add(this.Xc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Bersenham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YEnd);
            this.Controls.Add(this.XEnd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.DDA);
            this.Name = "Form1";
            this.Text = "Draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}