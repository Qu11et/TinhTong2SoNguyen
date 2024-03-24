using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exTxt_Click(object sender, EventArgs e)
        {
            subjectList.Items.Clear();
            avgTxt.Clear();
            maxTxt.Clear();
            minTxt.Clear();
            passTxt.Clear();
            npassTxt.Clear();
            rankTxt.Clear();
            nameTxt.Clear();

            String[] arrPoints = inTxt.Text.Trim().Split(',');
            List<double[]> arrResult = new List<double[]>();

            double sumPoints, averagePoint;
            double maxPoint, minPoint, passCount;
            string name;

            // Lấy tên sinh viên từ chuỗi đầu tiên trong mảng arrPoints
            name = arrPoints[0];
            // Gán tên sinh viên vào txt_hoten
            nameTxt.Text = name;

            // Bắt đầu từ index 1 để bỏ qua phần tử tên
            for (int i = 1; i < arrPoints.Length; i++)
            {
                double point;
                bool isNumber = double.TryParse(arrPoints[i], out point);

                if (!isNumber || point < 0 || point > 10)
                {
                    subjectList.Items.Clear();
                    inTxt.Clear();
                    inTxt.Focus();
                    MessageBox.Show("Điểm " + arrPoints[i] + " không hợp lệ\nĐiểm phải có giá trị từ 0 đến 10");
                    return;
                }

                string[] cols = new string[2];
                cols[0] = "Môn " + (i);
                cols[1] = point.ToString();

                arrResult.Add(new double[] { i, point });
                subjectList.Items.Add(new ListViewItem(cols));
            }

            sumPoints = arrResult.Select(item => item[1]).Sum();
            averagePoint = sumPoints / arrResult.Count();

            maxPoint = arrResult.Select(item => item[1]).Max();
            minPoint = arrResult.Select(item => item[1]).Min();
            passCount = arrResult.FindAll(item => item[1] >= 5).Count();

            avgTxt.Text = averagePoint.ToString();
            passTxt.Text = passCount.ToString();
            npassTxt.Text = (arrResult.Count() - passCount).ToString();

            maxTxt.Text = string.Join(", ",
                arrResult
                    .FindAll(item => item[1] == maxPoint)
                    .Select(item => "Môn " + item[0])
            );

            minTxt.Text = string.Join(", ",
                arrResult
                    .FindAll(item => item[1] == minPoint)
                    .Select(item => "Môn " + item[0])
            );

            if (averagePoint >= 8 && arrResult.Find(item => item[1] < 6.5) == null)
                rankTxt.Text = "Giỏi";
            else if (averagePoint >= 6.5 && arrResult.Find(item => item[1] < 5) == null)
                rankTxt.Text = "Khá";
            else if (averagePoint >= 5 && arrResult.Find(item => item[1] < 3.5) == null)
                rankTxt.Text = "Trung bình";
            else if (averagePoint >= 3.5 && arrResult.Find(item => item[1] < 2) == null)
                rankTxt.Text = "Yếu";
            else
                rankTxt.Text = "Kém";
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
