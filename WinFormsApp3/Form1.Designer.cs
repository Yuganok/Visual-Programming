namespace WinFormsApp3
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets sold";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 187);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "Class C:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 140);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 6;
            label3.Text = "Class B:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 5;
            label2.Text = "Class A:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(232, 49);
            label1.TabIndex = 5;
            label1.Text = "Enter the numbers of tickets sold for each class of seats\r\n";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(82, 385);
            button1.Name = "button1";
            button1.Size = new Size(104, 52);
            button1.TabIndex = 1;
            button1.Text = "Calculate revenue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(322, 385);
            button2.Name = "button2";
            button2.Size = new Size(102, 52);
            button2.TabIndex = 2;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(546, 386);
            button3.Name = "button3";
            button3.Size = new Size(94, 52);
            button3.TabIndex = 3;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(403, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 240);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue generated";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(164, 201);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 7;
            textBox7.Text = "0";
            // 
            // label8
            // 
            label8.Location = new Point(46, 203);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 6;
            label8.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 160);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 5;
            label7.Text = "Class C:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 113);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 4;
            label6.Text = "Class B:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 59);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 3;
            label5.Text = "Class A:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(164, 153);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 2;
            textBox6.Text = "0";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(164, 106);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 1;
            textBox5.Text = "0";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 52);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 0;
            textBox4.Text = "0";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Stadium seating";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox textBox7;
    }
}
