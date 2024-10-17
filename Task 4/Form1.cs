namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the number from the input textbox
                int number = int.Parse(txtInput.Text);

                if (number < 0)
                {
                    MessageBox.Show("Please enter a non-negative number.", "Error");
                    return;
                }

                // Calculate the factorial
                long factorial = CalculateFactorial(number);

                // Show the result in a message box
                MessageBox.Show($"Factorial of {number}! = {factorial}", "Result");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.", "Error");
            }
        }

        // Method to calculate the factorial
        private long CalculateFactorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        
    }
    }
}
