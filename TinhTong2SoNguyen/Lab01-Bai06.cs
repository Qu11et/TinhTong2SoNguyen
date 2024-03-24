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
    public partial class Form7 : Form
    {
        int day;
        int month;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterBut_Click(object sender, EventArgs e)
        {
            day = int.Parse(dayTxt.Text);
            month = int.Parse(monthTxt.Text);

            if ((month == 1 && day > 20) || (month == 2 && day < 20))
                outTxt.Text = "Bao Binh";
            else if ((month == 2 && day > 19) || (month == 3 && day < 21))
                outTxt.Text = "Song Ngu";
            else if ((month == 3 && day > 20) || (month == 4 && day < 21))
                outTxt.Text = "Bach Duong";
            else if ((month == 4 && day > 20) || (month == 5 && day < 22))
                outTxt.Text = "Kim Nguu";
            else if ((month == 5 && day > 21) || (month == 6 && day < 22))
                outTxt.Text = "Song Tu";
            else if ((month == 6 && day > 21) || (month == 7 && day < 23))
                outTxt.Text = "Cu Giai";
            else if ((month == 7 && day > 22) || (month == 8 && day < 23))
                outTxt.Text = "Su Tu";
            else if ((month == 8 && day > 22) || (month == 9 && day < 24))
                outTxt.Text = "Xu Nu";
            else if ((month == 9 && day > 23) || (month == 10 && day < 24))
                outTxt.Text = "Thien Binh";
            else if ((month == 10 && day > 23) || (month == 11 && day < 23))
                outTxt.Text = "Than Nong";
            else if ((month == 11 && day > 22) || (month == 12 && day < 22))
                outTxt.Text = "Nhan Ma";
            else if ((month == 12 && day > 21) || (month == 1 && day < 21))
                outTxt.Text = "Ma Ket";

        }
    }
}
