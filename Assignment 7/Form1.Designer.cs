namespace Assignment_7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnLoadFile = new Button();
            btnCheck = new Button();
            txtResults = new TextBox();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(20, 20);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(120, 30);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "Load File";
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(160, 20);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(120, 30);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check Answers";
            btnCheck.Click += btnCheck_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(20, 70);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(400, 300);
            txtResults.TabIndex = 2;
            // 
            // Form1
            // 
            ClientSize = new Size(432, 353);
            Controls.Add(btnLoadFile);
            Controls.Add(btnCheck);
            Controls.Add(txtResults);
            Name = "Form1";
            Text = "Driver's License Exam Grader";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnLoadFile;
        private Button btnCheck;
        private TextBox txtResults;
    }
}
