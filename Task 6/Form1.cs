using System;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame("Rock");
        }
        private void btnPaper_Click_1(object sender, EventArgs e)
        {
            PlayGame("Paper");
        }

        private void btnScissors_Click_1(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }

        
        private void PlayGame(string userChoice)
        {
            
            string computerChoice = GetComputerChoice();
            lblComputerChoice.Text = $"Computer choice: {computerChoice}";

            
            string result = DetermineWinner(userChoice, computerChoice);
            lblResult.Text = result;
        }

        
        private string GetComputerChoice()
        {
            int choice = random.Next(1, 4);
            switch (choice)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                default:
                    return "Rock";
            }
        }

        
        private string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "Tie! Try again.";
            }
            else if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                     (userChoice == "Scissors" && computerChoice == "Paper") ||
                     (userChoice == "Paper" && computerChoice == "Rock"))
            {
                return "You win!";
            }
            else
            {
                return "You lost. The computer won!";
            }
        }

        
    }
}

