namespace Task_5
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
            lblMessage = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            lblAttempts = new Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMessage.Location = new Point(56, 38);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(417, 34);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Random Number Guessing Game\r\n";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(56, 102);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(160, 27);
            txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(203, 188);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(94, 29);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Check";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click_1;
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAttempts.Location = new Point(312, 103);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(95, 26);
            lblAttempts.TabIndex = 3;
            lblAttempts.Text = "Attempts";
            lblAttempts.Click += lblAttempts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 228);
            Controls.Add(lblAttempts);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private TextBox txtGuess;
        private Button btnGuess;
        private Label lblAttempts;
    }
}
