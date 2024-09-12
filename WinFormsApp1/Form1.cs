namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label4.Text = "Ace of Hearts";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label4.Text = "Ace of Diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label4.Text = "Ace of Spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label4.Text = "Ace of Clubs";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр Form2
            Form2 form2 = new Form2();

            // Скрываем Form1
            this.Hide();

            // Открываем Form2
            form2.Show();

            // При закрытии Form2 завершаем приложение
            form2.FormClosed += (s, args) => Application.Exit();
        }
    }
}
