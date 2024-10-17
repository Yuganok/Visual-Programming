namespace Task_4
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
            lblInput = new Label();
            txtInput = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(10, 19);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(205, 20);
            lblInput.TabIndex = 0;
            lblInput.Text = "Enter a non-negative number:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(221, 12);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(80, 27);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(61, 67);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(194, 35);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate Factorial";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 128);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private Button btnCalculate;
    }
}
