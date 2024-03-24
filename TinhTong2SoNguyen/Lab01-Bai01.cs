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
            int soThuNhat;
            bool test1 = int.TryParse(textBox1.Text, out soThuNhat);

            if (test1 == false)
            {
                MessageBox.Show("Số nhập vào phải là số nguyên", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            int soThuHai;
            bool test2 = int.TryParse(textBox2.Text, out soThuHai);

            if (test2 == false)
            {
                MessageBox.Show("Số nhập vào phải là số nguyên", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            textBox3.Text = (soThuNhat + soThuHai).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
