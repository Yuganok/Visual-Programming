using System.Text;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        private char[] correctAnswers = new char[] 
        { 
            'B', 'D', 'A', 'A', 'C',
            'A', 'B', 'A', 'C', 'D',
            'B', 'C', 'D', 'A', 'D',
            'C', 'C', 'B', 'D', 'A'
        };
        
        private char[] studentAnswers;
        private string filePath;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    txtResults.Text = "File loaded: " + filePath;
                }
            }
        }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please load a file first!");
                return;
            }
            
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                studentAnswers = new char[20];
                
                for (int i = 0; i < lines.Length && i < 20; i++)
                {
                    if (!string.IsNullOrWhiteSpace(lines[i]))
                    {
                        studentAnswers[i] = lines[i].Trim().ToUpper()[0];
                    }
                }
                
                CheckAnswers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
        
        private void CheckAnswers()
        {
            int correctCount = 0;
            List<int> incorrectQuestions = new List<int>();
            
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                if (studentAnswers[i] == correctAnswers[i])
                {
                    correctCount++;
                }
                else
                {
                    incorrectQuestions.Add(i + 1);
                }
            }
            
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Results:");
            result.AppendLine($"Correct answers: {correctCount}");
            result.AppendLine($"Incorrect answers: {20 - correctCount}");
            
            if (incorrectQuestions.Count > 0)
            {
                result.AppendLine("\nIncorrectly answered questions:");
                result.AppendLine(string.Join(", ", incorrectQuestions));
            }
            
            result.AppendLine($"\nFinal result: {(correctCount >= 15 ? "PASSED" : "FAILED")}");
            
            txtResults.Text = result.ToString();
        }
    }
}
