namespace dbs
{
    partial class aarti_dbms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aarti_dbms));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.name = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.passcode = new System.Windows.Forms.TextBox();
            this.customer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.signinpage = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.signinpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(25, 86);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(110, 27);
            this.name.TabIndex = 1;
            this.name.Text = "username:";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(25, 136);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(108, 27);
            this.pass.TabIndex = 2;
            this.pass.Text = "password:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(137, 82);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(185, 35);
            this.username.TabIndex = 3;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // passcode
            // 
            this.passcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passcode.Location = new System.Drawing.Point(137, 136);
            this.passcode.Margin = new System.Windows.Forms.Padding(2);
            this.passcode.Name = "passcode";
            this.passcode.Size = new System.Drawing.Size(185, 35);
            this.passcode.TabIndex = 4;
            this.passcode.TextChanged += new System.EventHandler(this.passcode_TextChanged);
            // 
            // customer
            // 
            this.customer.ForeColor = System.Drawing.Color.Black;
            this.customer.Location = new System.Drawing.Point(30, 247);
            this.customer.Margin = new System.Windows.Forms.Padding(2);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(184, 38);
            this.customer.TabIndex = 5;
            this.customer.Text = "CUSTOMER LOGIN";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(30, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADMIN LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(30, 292);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "SELLER LOGIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(29, 338);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "SHIPPER LOGIN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // signinpage
            // 
            this.signinpage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signinpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signinpage.Controls.Add(this.button4);
            this.signinpage.Controls.Add(this.button1);
            this.signinpage.Controls.Add(this.button3);
            this.signinpage.Controls.Add(this.name);
            this.signinpage.Controls.Add(this.button2);
            this.signinpage.Controls.Add(this.pass);
            this.signinpage.Controls.Add(this.username);
            this.signinpage.Controls.Add(this.customer);
            this.signinpage.Controls.Add(this.passcode);
            this.signinpage.ForeColor = System.Drawing.Color.White;
            this.signinpage.Location = new System.Drawing.Point(269, 118);
            this.signinpage.Margin = new System.Windows.Forms.Padding(2);
            this.signinpage.Name = "signinpage";
            this.signinpage.Padding = new System.Windows.Forms.Padding(2);
            this.signinpage.Size = new System.Drawing.Size(368, 440);
            this.signinpage.TabIndex = 8;
            this.signinpage.TabStop = false;
            this.signinpage.Text = "SIGN-IN";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(202, 190);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 46);
            this.button4.TabIndex = 9;
            this.button4.Text = "forgot password?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(399, 586);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 29);
            this.button5.TabIndex = 10;
            this.button5.Text = "SIGNUP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // aarti_dbms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 678);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.signinpage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "aarti_dbms";
            this.Text = "aarti dbms";
            this.Load += new System.EventHandler(this.aarti_dbms_Load);
            this.signinpage.ResumeLayout(false);
            this.signinpage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox passcode;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox signinpage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

    }
}

