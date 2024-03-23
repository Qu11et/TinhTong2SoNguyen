using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form9 : Form
    {
        string[] array;
        ulong size = 0;
        string input = "";
        int counter = 0;

        public Form9()
        {
            InitializeComponent();
            array = new string[50];
            //List<string> array = new List<string>();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            counter++;
            input = inputTxt.Text;
            array[counter] = input;
            outputTxt.Text = outputTxt.Text + array[counter] + Environment.NewLine;
            inputTxt.Clear();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            int value = generator.Next(1, counter + 1);

            resultTxt.Text = array[value];
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            Array.Clear(array, 0, array.Length);
            outputTxt.Clear();
        }
    }
}
