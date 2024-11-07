namespace Task_6
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
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblComputerChoice = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(56, 185);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(102, 37);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(251, 185);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(104, 37);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click_1;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(454, 185);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(102, 37);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click_1;
            // 
            // lblComputerChoice
            // 
            lblComputerChoice.AutoSize = true;
            lblComputerChoice.Location = new Point(95, 68);
            lblComputerChoice.Name = "lblComputerChoice";
            lblComputerChoice.Size = new Size(0, 20);
            lblComputerChoice.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(336, 68);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 245);
            Controls.Add(lblResult);
            Controls.Add(lblComputerChoice);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblComputerChoice;
        private Label lblResult;
    }
}
