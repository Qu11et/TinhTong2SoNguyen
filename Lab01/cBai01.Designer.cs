using System.Runtime.CompilerServices;

namespace Lab01
{
    partial class cBai01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clink_Tinh = new System.Windows.Forms.Button();
            this.tMot = new System.Windows.Forms.TextBox();
            this.tHai = new System.Windows.Forms.TextBox();
            this.tTong = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clink_Tinh
            // 
            this.clink_Tinh.Location = new System.Drawing.Point(97, 190);
            this.clink_Tinh.Name = "clink_Tinh";
            this.clink_Tinh.Size = new System.Drawing.Size(75, 23);
            this.clink_Tinh.TabIndex = 0;
            this.clink_Tinh.Text = "Tính ";
            this.clink_Tinh.UseVisualStyleBackColor = true;
            this.clink_Tinh.Click += new System.EventHandler(this.button_Tinh);
            // 
            // tMot
            // 
            this.tMot.Location = new System.Drawing.Point(292, 93);
            this.tMot.Name = "tMot";
            this.tMot.Size = new System.Drawing.Size(100, 20);
            this.tMot.TabIndex = 1;
            this.tMot.TextChanged += new System.EventHandler(this.text_SoThuNhat);
            // 
            // tHai
            // 
            this.tHai.Location = new System.Drawing.Point(292, 139);
            this.tHai.Name = "tHai";
            this.tHai.Size = new System.Drawing.Size(100, 20);
            this.tHai.TabIndex = 1;
            this.tHai.TextChanged += new System.EventHandler(this.text_SoThuHai);
            // 
            // tTong
            // 
            this.tTong.Location = new System.Drawing.Point(292, 190);
            this.tTong.Name = "tTong";
            this.tTong.Size = new System.Drawing.Size(100, 20);
            this.tTong.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Số thứ nhất";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 139);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "Số thứ hai";
            // 
            // TieuDe
            // 
            this.TieuDe.AutoSize = true;
            this.TieuDe.Location = new System.Drawing.Point(176, 29);
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Size = new System.Drawing.Size(143, 13);
            this.TieuDe.TabIndex = 3;
            this.TieuDe.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // cBai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TieuDe);
            this.Controls.Add(this.tTong);
            this.Controls.Add(this.tHai);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tMot);
            this.Controls.Add(this.clink_Tinh);
            this.Name = "cBai01";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clink_Tinh;
        private System.Windows.Forms.TextBox tMot;
        private System.Windows.Forms.TextBox tHai;
        private System.Windows.Forms.TextBox tTong;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label TieuDe;

       
    }
}