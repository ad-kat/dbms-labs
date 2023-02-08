namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.heading = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rank = new System.Windows.Forms.Label();
            this.rankbox = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blgp = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.Label();
            this.branches = new System.Windows.Forms.CheckedListBox();
            this.gender = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.Black;
            this.heading.Location = new System.Drawing.Point(80, 18);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(521, 36);
            this.heading.TabIndex = 0;
            this.heading.Text = "STUDENT REGISTRATION FORM";
            this.heading.Click += new System.EventHandler(this.heading_Click);
            // 
            // namebox
            // 
            this.namebox.AutoSize = true;
            this.namebox.Location = new System.Drawing.Point(32, 84);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(41, 13);
            this.namebox.TabIndex = 1;
            this.namebox.Text = "NAME:";
            this.namebox.Click += new System.EventHandler(this.namebox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rank
            // 
            this.rank.AutoSize = true;
            this.rank.Location = new System.Drawing.Point(434, 84);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(43, 13);
            this.rank.TabIndex = 3;
            this.rank.Text = "RANK :";
            this.rank.Click += new System.EventHandler(this.dobbox_Click);
            // 
            // rankbox
            // 
            this.rankbox.Location = new System.Drawing.Point(473, 81);
            this.rankbox.Name = "rankbox";
            this.rankbox.Size = new System.Drawing.Size(162, 20);
            this.rankbox.TabIndex = 4;
            this.rankbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(32, 128);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(59, 13);
            this.mail.TabIndex = 5;
            this.mail.Text = "E-MAIL ID:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "HOME ADDRESS:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // blgp
            // 
            this.blgp.AutoSize = true;
            this.blgp.Location = new System.Drawing.Point(387, 128);
            this.blgp.Name = "blgp";
            this.blgp.Size = new System.Drawing.Size(89, 13);
            this.blgp.TabIndex = 8;
            this.blgp.Text = "BLOOD GROUP:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(482, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 158);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(500, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(32, 212);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(94, 13);
            this.subject.TabIndex = 11;
            this.subject.Text = "BTECH COURSE:";
            // 
            // branches
            // 
            this.branches.FormattingEnabled = true;
            this.branches.Items.AddRange(new object[] {
            "AERONAUTICAL ENGINEERING (CORE)",
            "AEROSPACE ENGINEERING",
            "AUTOMOBILE ENGINEERING (CORE)",
            "BIOMEDICAL ENGINEERING (CORE)",
            "BIOTECHNOLOGY",
            "CHEMICAL ENGINEERING (CORE)",
            "CIVIL ENGINEERING (CORE)",
            "COMPUTER SCIENCE AND ENGINEERING (CORE)",
            "COMPUTER SCIENCE WITH SPECIALIZATION IN ARTIFICIAL INTELLIGENCE AND MACHINE LEARN" +
                "ING",
            "COMPUTER SCIENCE WITH SPECIALIZATION IN CYBER SECURITY AND BLOCKCHAIN TECHNOLOGY",
            "COMPUTER AND COMMUNICATION ENGINEERING",
            "DATA SCIENCE AND ENGINEERING",
            "ELECTRONICS AND COMMUNICATION ENGINEERING (CORE)",
            "ELECTRONICS AND ELECTRICAL ENGINEERING",
            "ELECTRONICS AND INSTRUMENTATION ENGINEERING",
            "INFORMATION TECHNOLOGY",
            "MECHANICAL ENGINEERING (CORE)",
            "MECHATRONICS ENGINEERING (CORE)"});
            this.branches.Location = new System.Drawing.Point(35, 239);
            this.branches.Name = "branches";
            this.branches.Size = new System.Drawing.Size(600, 289);
            this.branches.TabIndex = 30;
            this.branches.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // gender
            // 
            this.gender.Controls.Add(this.radioButton5);
            this.gender.Controls.Add(this.radioButton4);
            this.gender.Controls.Add(this.radioButton3);
            this.gender.Controls.Add(this.radioButton2);
            this.gender.Controls.Add(this.radioButton1);
            this.gender.Location = new System.Drawing.Point(35, 553);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(144, 184);
            this.gender.TabIndex = 31;
            this.gender.TabStop = false;
            this.gender.Text = "YOUR GENDER:";
            this.gender.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 80);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "transgender";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(27, 103);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "others";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(27, 126);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(101, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "prefer not to say";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "DATE OF BIRTH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "SUBMIT FORM?:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(224, 679);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(56, 23);
            this.submit.TabIndex = 36;
            this.submit.Text = "OK";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 585);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Form, once submitted, cannot be reverted.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 847);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.branches);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.blgp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.rankbox);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.heading);
            this.Name = "Form1";
            this.Text = "student registration";
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label namebox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label rank;
        private System.Windows.Forms.TextBox rankbox;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blgp;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.CheckedListBox branches;
        private System.Windows.Forms.GroupBox gender;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}

