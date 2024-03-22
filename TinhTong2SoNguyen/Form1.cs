namespace TinhTong2SoNguyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soThuNhat = int.Parse(textBox1.Text);
            int soThuHai = int.Parse(textBox2.Text);

            textBox3.Text = (soThuNhat + soThuHai).ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
