using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTong2SoNguyen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1Txt.Text);
            int num2 = int.Parse(num2Txt.Text);
            int num3 = int.Parse(num3Txt.Text);

            if (num1 == num2 && num2 == num3)
            {
                MessageBox.Show("Vui lòng không nhập trùng tất cả số", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }

            if (num1 != num2 && num1 != num3)
            {
                if (num1 > num2)
                {
                    if (num1 < num3)
                    {
                        maxTxt.Text = num3.ToString();
                        minTxt.Text = num2.ToString();
                    }
                    else if (num3 < num2)
                    {
                        maxTxt.Text = num1.ToString();
                        minTxt.Text = num3.ToString();
                    }
                }
                else if (num2 > num1)
                {
                    if (num2 < num3)
                    {
                        maxTxt.Text = num3.ToString();
                        minTxt.Text = num1.ToString();
                    }
                    else if (num3 < num1)
                    {
                        minTxt.Text = num3.ToString();
                        maxTxt.Text = num2.ToString();
                    }
                }
                else
                {
                    if (num1 > num2)                //iSoHai=iSoBa || iSoMot=iSoBa
                    {
                        minTxt.Text = num2.ToString();
                        maxTxt.Text = num1.ToString();
                    }
                    else if (num1 > num3)          //iSoHai=iSoBa || iSoMot=iSoHai
                    {
                        minTxt.Text = minTxt.ToString();
                        maxTxt.Text = maxTxt.ToString();
                    }
                    else if (num3 > num1)        //iSoBa=iSoHai ||iSoHai=iSoMot
                    {
                        minTxt.Text = num1.ToString();
                        maxTxt.Text = num3.ToString();
                    }
                    else
                    {
                        minTxt.Text = num2.ToString();
                        maxTxt.Text = num3.ToString();
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
