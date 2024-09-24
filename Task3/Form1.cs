namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var value1 = Math.Round(703 * int.Parse(textBox1.Text) / Math.Pow(int.Parse(textBox2.Text), 2), 2);
            if
                (value1 < 18.5)
            {
                textBox4.Text = "underweight";
            }
            else if
                (value1 > 25)
            {
                textBox4.Text = "overweight";
            }
            else { textBox4.Text = "optimal"; }

            textBox3.Text = value1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
