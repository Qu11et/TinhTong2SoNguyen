﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTong2SoNguyen
{
    public partial class Form5 : Form
    {
        class Phim
        {
            public required string Ten { get; set; }
            public int GiaVe { get; set; }
            public int[]? PhongChieu { get; set; }
        }

        public Form5()
        {
            InitializeComponent();
            List<Phim> phims = new List<Phim>();
            phims.Add(new Phim() { Ten = "Đào, phở và piano", GiaVe = 45000, PhongChieu = [1, 2] });
            phims.Add(new Phim() { Ten = "Mai", GiaVe = 100000, PhongChieu = [1, 2, 3] });
            phims.Add(new Phim() { Ten = "Gặp lại chị bầu", GiaVe = 70000, PhongChieu = [2] });
            phims.Add(new Phim() { Ten = "Tarot", GiaVe = 90000, PhongChieu = [1] });

            comboBox1.DataSource = phims;
            comboBox1.DisplayMember = "Ten";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phim selectedPhim = comboBox1.SelectedItem as Phim;
            infoLabel.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phim selectedPhim = comboBox1.SelectedItem as Phim;
            List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    MessageBox.Show(checkBox.Name);
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Phim selectedPhim = comboBox1.SelectedItem as Phim;
            infoLabel.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
