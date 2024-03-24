using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTong2SoNguyen
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lab1.Form3 form3 = new lab1.Form3();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lab1.Form4 form4 = new lab1.Form4();
            form4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lab1.Form6 form6 = new lab1.Form6();
            form6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lab1.Form7 form7 = new lab1.Form7();
            form7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lab1.Form8 form8 = new lab1.Form8();
            form8.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lab1.Form9 form9 = new lab1.Form9();
            form9.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
