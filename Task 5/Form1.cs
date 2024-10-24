namespace Task_5
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int guessCount;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
            guessCount = 0;
            lblAttempts.Text = "Attempts: 0";
            txtGuess.Clear();
            txtGuess.Focus();
        }


        private void btnGuess_Click_1(object sender, EventArgs e)
        {
            {
                int userGuess;
                if (int.TryParse(txtGuess.Text, out userGuess))
                {
                    guessCount++;
                    lblAttempts.Text = $"Attempts: {guessCount}";

                    if (userGuess > randomNumber)
                    {
                        lblMessage.Text = "Too high, try again.";
                    }
                    else if (userGuess < randomNumber)
                    {
                        lblMessage.Text = "Too low, try again.";
                    }
                    else
                    {
                        lblMessage.Text = $"Congratulations! You guessed the number {randomNumber} in {guessCount} attempts.";
                        DialogResult result = MessageBox.Show("Do you want to play again?", "New Game", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            StartNewGame();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    lblMessage.Text = "Please enter a valid number.";
                }

                txtGuess.Clear();
                txtGuess.Focus();
            }
        }

        private void lblAttempts_Click(object sender, EventArgs e)
        {

        }
    }
}
