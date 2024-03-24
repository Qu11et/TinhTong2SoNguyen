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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(inTxt.Text);

            switch (num)
            {
                case 0: outTxt.Text = "Không"; break;
                case 1: outTxt.Text = "Một"; break;
                case 2: outTxt.Text = "Hai"; break;
                case 3: outTxt.Text = "ba"; break;
                case 4: outTxt.Text = "bốn"; break;
                case 5: outTxt.Text = "Năm"; break;
                case 6: outTxt.Text = "Sáu"; break;
                case 7: outTxt.Text = "Bảy"; break;
                case 8: outTxt.Text = "Tám"; break;
                case 9: outTxt.Text = "Chín"; break;
                default: break;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            outTxt.Text = null;
            inTxt.Text = null;
        }

        private void exitTxt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
