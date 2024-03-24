using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void exBtn_Click(object sender, EventArgs e)
        {
            int numA = int.Parse(AinTxt.Text);
            int numB = int.Parse(BinTxt.Text);

            if (optList.Text == "")
            {
                MessageBox.Show("Vui lòng chọn kiểu tính toán", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else if (optList.Text == "Bảng cửu chương")
            {
                if (numB < numA)
                {
                    MessageBox.Show("Vui lòng nhập số B lớn hơn số A", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    int num = numB - numA;
                    outTxt.Text = "Bảng cửu chương của " + num.ToString() + Environment.NewLine;
                    for (int i = 1; i < 11; i++)
                    {
                        outTxt.Text += num.ToString() + "*" + i.ToString() + "=" + (i * num) + Environment.NewLine;
                    }
                }
            }

            else if (optList.Text == "Tính giá trị")
            {
                if (numA < numB)
                {
                    MessageBox.Show("Vui lòng nhập số A lớn hơn số B", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    int num = numA - numB;
                    int result = 1;
                    for (int i = num; i > 0; i--)
                    {
                        result = result * i;
                    }
                    outTxt.Text = "(A-B)!" + "=" + result.ToString() + Environment.NewLine;

                    int SoCong = 0;
                    for (int j = 1; j <= numB; j++)
                    {
                        int SoNhan = 1;
                        for (int h = 1; h <= j; h++)
                        {
                            SoNhan = numA * SoNhan;
                        }
                        SoCong = SoNhan + SoCong;
                    }
                    outTxt.Text += "Tổng S = " + SoCong.ToString() + Environment.NewLine;
                }
            }
        }
    }
}
