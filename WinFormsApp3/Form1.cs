namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(textBox1.Text);
            int value2 = int.Parse(textBox2.Text);
            int value3 = int.Parse(textBox3.Text);

            int result1 = value1 * 15;
            int result2 = value2 * 12;
            int result3 = value3 * 9;
            int result4 = result1 + result2 + result3;

            textBox4.Text = result1.ToString() + "$";
            textBox5.Text = result2.ToString() + "$";
            textBox6.Text = result3.ToString() + "$";
            textBox7.Text = result4.ToString() + "$";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = null;
            textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
