namespace Supertramp_Cafe
{
    public partial class Form1 : Form
    {
        int money = 1000;
        int cheese = 150;
        int cupcake = 50;
        int hamburger = 120;
        int pizza = 150;
        int hotdog = 80;
        int pancake = 60;
        int totalPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HamburgerpictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += hamburger;
            listBox1.Items.Add("Hamburger");
        }

        private void CupcakepictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += cupcake;
            listBox1.Items.Add("Cupcake");
        }

        private void PizzapictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += pizza;
            listBox1.Items.Add("Pizza");
        }

        private void HotdogpictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += hotdog;
            listBox1.Items.Add("Hptdog");
        }

        private void PancakepictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += pancake;
            listBox1.Items.Add("Pancake");
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = money.ToString() + "Tl";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalPrice <= 1000)
            {
                money = money - totalPrice;
                label2.Text = money.ToString();
                MessageBox.Show("Alisveris yaptiginiz icin tesekkur ederiz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Paraniz yetmemektedir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            totalPrice += cheese;
            listBox1.Items.Add("Cheese");
        }
    }
}
