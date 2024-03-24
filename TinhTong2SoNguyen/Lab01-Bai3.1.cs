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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            if (inTxt.Text.Length > 12)
            {
                MessageBox.Show("Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string number = inTxt.Text;

            string result = NumberToTextVN(decimal.Parse(number));

            outTxt.Text = result;
        }

        private String NumberToTextVN(decimal total)
        {
            try
            {
                string rs = "";
                total = Math.Round(total, 0);
                string[] ch = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string[] rch = { "lẻ", "mốt", "", "", "", "lăm" };
                string[] u = { "", "mươi", "trăm", "ngàn", "", "", "triệu", "", "", "tỷ", "", "", "ngàn", "", "", "triệu" };
                string nstr = total.ToString();

                int[] n = new int[nstr.Length];
                int len = n.Length;
                for (int i = 0; i < len; i++)
                {
                    n[len - 1 - i] = Convert.ToInt32(nstr.Substring(i, 1));
                }

                for (int i = len - 1; i >= 0; i--)
                {
                    // số 0 ở hàng trăm
                    if (i % 3 == 2)
                    {
                        //nếu cả 3 số là 0 thì bỏ qua không đọc
                        if (n[i] == 0 && n[i - 1] == 0 && n[i - 2] == 0) continue;
                    }
                    // số ở hàng chục
                    else if (i % 3 == 1)
                    {
                        if (n[i] == 0)
                        {
                            // nếu hàng chục và hàng đơn vị đều là 0 thì bỏ qua.
                            if (n[i - 1] == 0) { continue; }
                            else
                            {
                                // hàng chục là 0 thì bỏ qua, đọc số hàng đơn vị
                                rs += " " + rch[n[i]]; continue;
                            }
                        }
                        //nếu số hàng chục là 1 thì đọc là mười
                        if (n[i] == 1)
                        {
                            rs += " mười"; continue;
                        }
                    }
                    // số ở hàng đơn vị (không phải là số đầu tiên)
                    else if (i != len - 1)
                    {
                        // số hàng đơn vị là 0 thì chỉ đọc đơn vị
                        if (n[i] == 0)
                        {
                            if (i + 2 <= len - 1 && n[i + 2] == 0 && n[i + 1] == 0) continue;
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        // nếu là 1 thì tùy vào số hàng chục mà đọc: 0,1: một / còn lại: mốt
                        if (n[i] == 1)
                        {
                            rs += " " + ((n[i + 1] == 1 || n[i + 1] == 0) ? ch[n[i]] : rch[n[i]]);
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        // cách đọc số 5
                        if (n[i] == 5)
                        {
                            //nếu số hàng chục khác 0 thì đọc số 5 là lăm
                            if (n[i + 1] != 0)
                            {
                                // đọc số
                                rs += " " + rch[n[i]];
                                // đọc đơn vị
                                rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                                continue;
                            }
                        }
                    }
                    // đọc số
                    rs += (rs == "" ? " " : ", ") + ch[n[i]];
                    // đọc đơn vị
                    rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                }


                if (rs.Length > 2)
                {
                    string rs1 = rs.Substring(0, 2);
                    rs1 = rs1.ToUpper();
                    rs = rs.Substring(2);
                    rs = rs1 + rs;
                }
                return rs.Trim().Replace("lẻ,", "lẻ").Replace("mươi,", "mươi").Replace("trăm,", "trăm").Replace("mười,", "mười");
            }
            catch
            {
                return "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
