namespace WindowsFormsApplication1
{
    partial class BASIC_CALCULATOR
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
            this.cmd_1 = new System.Windows.Forms.Button();
            this.cmd_2 = new System.Windows.Forms.Button();
            this.cmd_3 = new System.Windows.Forms.Button();
            this.cmd_4 = new System.Windows.Forms.Button();
            this.cmd_5 = new System.Windows.Forms.Button();
            this.cmd_6 = new System.Windows.Forms.Button();
            this.cmd_7 = new System.Windows.Forms.Button();
            this.cmd_8 = new System.Windows.Forms.Button();
            this.cmd_9 = new System.Windows.Forms.Button();
            this.cmd_0 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.expo = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.sq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_1
            // 
            this.cmd_1.Location = new System.Drawing.Point(12, 230);
            this.cmd_1.Name = "cmd_1";
            this.cmd_1.Size = new System.Drawing.Size(74, 50);
            this.cmd_1.TabIndex = 0;
            this.cmd_1.Text = "1";
            this.cmd_1.UseVisualStyleBackColor = true;
            this.cmd_1.Click += new System.EventHandler(this.cmd_1_Click);
            // 
            // cmd_2
            // 
            this.cmd_2.Location = new System.Drawing.Point(92, 230);
            this.cmd_2.Name = "cmd_2";
            this.cmd_2.Size = new System.Drawing.Size(74, 50);
            this.cmd_2.TabIndex = 1;
            this.cmd_2.Text = "2";
            this.cmd_2.UseVisualStyleBackColor = true;
            this.cmd_2.Click += new System.EventHandler(this.cmd_2_Click);
            // 
            // cmd_3
            // 
            this.cmd_3.Location = new System.Drawing.Point(172, 230);
            this.cmd_3.Name = "cmd_3";
            this.cmd_3.Size = new System.Drawing.Size(74, 50);
            this.cmd_3.TabIndex = 2;
            this.cmd_3.Text = "3";
            this.cmd_3.UseVisualStyleBackColor = true;
            this.cmd_3.Click += new System.EventHandler(this.cmd_3_Click);
            // 
            // cmd_4
            // 
            this.cmd_4.Location = new System.Drawing.Point(12, 286);
            this.cmd_4.Name = "cmd_4";
            this.cmd_4.Size = new System.Drawing.Size(74, 50);
            this.cmd_4.TabIndex = 3;
            this.cmd_4.Text = "4";
            this.cmd_4.UseVisualStyleBackColor = true;
            this.cmd_4.Click += new System.EventHandler(this.cmd_4_Click);
            // 
            // cmd_5
            // 
            this.cmd_5.Location = new System.Drawing.Point(92, 286);
            this.cmd_5.Name = "cmd_5";
            this.cmd_5.Size = new System.Drawing.Size(74, 50);
            this.cmd_5.TabIndex = 4;
            this.cmd_5.Text = "5";
            this.cmd_5.UseVisualStyleBackColor = true;
            this.cmd_5.Click += new System.EventHandler(this.cmd_5_Click);
            // 
            // cmd_6
            // 
            this.cmd_6.Location = new System.Drawing.Point(172, 286);
            this.cmd_6.Name = "cmd_6";
            this.cmd_6.Size = new System.Drawing.Size(74, 50);
            this.cmd_6.TabIndex = 5;
            this.cmd_6.Text = "6";
            this.cmd_6.UseVisualStyleBackColor = true;
            this.cmd_6.Click += new System.EventHandler(this.cmd_6_Click);
            // 
            // cmd_7
            // 
            this.cmd_7.Location = new System.Drawing.Point(12, 342);
            this.cmd_7.Name = "cmd_7";
            this.cmd_7.Size = new System.Drawing.Size(74, 50);
            this.cmd_7.TabIndex = 6;
            this.cmd_7.Text = "7";
            this.cmd_7.UseVisualStyleBackColor = true;
            this.cmd_7.Click += new System.EventHandler(this.cmd_7_Click);
            // 
            // cmd_8
            // 
            this.cmd_8.Location = new System.Drawing.Point(92, 342);
            this.cmd_8.Name = "cmd_8";
            this.cmd_8.Size = new System.Drawing.Size(74, 50);
            this.cmd_8.TabIndex = 7;
            this.cmd_8.Text = "8";
            this.cmd_8.UseVisualStyleBackColor = true;
            this.cmd_8.Click += new System.EventHandler(this.cmd_8_Click);
            // 
            // cmd_9
            // 
            this.cmd_9.Location = new System.Drawing.Point(172, 342);
            this.cmd_9.Name = "cmd_9";
            this.cmd_9.Size = new System.Drawing.Size(74, 50);
            this.cmd_9.TabIndex = 8;
            this.cmd_9.Text = "9";
            this.cmd_9.UseVisualStyleBackColor = true;
            this.cmd_9.Click += new System.EventHandler(this.cmd_9_Click);
            // 
            // cmd_0
            // 
            this.cmd_0.Location = new System.Drawing.Point(12, 398);
            this.cmd_0.Name = "cmd_0";
            this.cmd_0.Size = new System.Drawing.Size(74, 50);
            this.cmd_0.TabIndex = 9;
            this.cmd_0.Text = "0";
            this.cmd_0.UseVisualStyleBackColor = true;
            this.cmd_0.Click += new System.EventHandler(this.cmd_0_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(250, 174);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(74, 50);
            this.divide.TabIndex = 10;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(252, 230);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(74, 50);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(252, 286);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(74, 50);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(252, 342);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(74, 50);
            this.add.TabIndex = 13;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(172, 398);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(152, 50);
            this.ans.TabIndex = 14;
            this.ans.Text = "=";
            this.ans.UseVisualStyleBackColor = true;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 15;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(92, 398);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(74, 50);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // expo
            // 
            this.expo.Location = new System.Drawing.Point(92, 174);
            this.expo.Name = "expo";
            this.expo.Size = new System.Drawing.Size(74, 50);
            this.expo.TabIndex = 24;
            this.expo.Text = "^";
            this.expo.UseVisualStyleBackColor = true;
            this.expo.Click += new System.EventHandler(this.expo_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(12, 174);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(74, 50);
            this.mod.TabIndex = 22;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // sq
            // 
            this.sq.Location = new System.Drawing.Point(172, 174);
            this.sq.Name = "sq";
            this.sq.Size = new System.Drawing.Size(74, 50);
            this.sq.TabIndex = 26;
            this.sq.Text = "x√y";
            this.sq.UseVisualStyleBackColor = true;
            this.sq.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BASIC_CALCULATOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 462);
            this.Controls.Add(this.sq);
            this.Controls.Add(this.expo);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.add);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.cmd_0);
            this.Controls.Add(this.cmd_9);
            this.Controls.Add(this.cmd_8);
            this.Controls.Add(this.cmd_7);
            this.Controls.Add(this.cmd_6);
            this.Controls.Add(this.cmd_5);
            this.Controls.Add(this.cmd_4);
            this.Controls.Add(this.cmd_3);
            this.Controls.Add(this.cmd_2);
            this.Controls.Add(this.cmd_1);
            this.Name = "BASIC_CALCULATOR";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.BASIC_CALCULATOR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_1;
        private System.Windows.Forms.Button cmd_2;
        private System.Windows.Forms.Button cmd_3;
        private System.Windows.Forms.Button cmd_4;
        private System.Windows.Forms.Button cmd_5;
        private System.Windows.Forms.Button cmd_6;
        private System.Windows.Forms.Button cmd_7;
        private System.Windows.Forms.Button cmd_8;
        private System.Windows.Forms.Button cmd_9;
        private System.Windows.Forms.Button cmd_0;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button ans;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button expo;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button sq;
    }
}

