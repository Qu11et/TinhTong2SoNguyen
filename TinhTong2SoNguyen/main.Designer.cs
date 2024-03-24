namespace TinhTong2SoNguyen
{
    partial class main
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
            button1 = new Button();
            button5 = new Button();
            button8 = new Button();
            button7 = new Button();
            button9 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button4 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 179);
            button1.Name = "button1";
            button1.Size = new Size(394, 69);
            button1.TabIndex = 0;
            button1.Text = "1.  Tính tổng 2 số nguyên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(192, 0, 0);
            button5.Location = new Point(257, 562);
            button5.Name = "button5";
            button5.Size = new Size(394, 69);
            button5.TabIndex = 1;
            button5.Text = "5. Quản lỷ phòng vé";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.Location = new Point(470, 372);
            button8.Name = "button8";
            button8.Size = new Size(394, 69);
            button8.TabIndex = 2;
            button8.Text = "8. Xử lý mảng";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(470, 275);
            button7.Name = "button7";
            button7.Size = new Size(394, 69);
            button7.TabIndex = 3;
            button7.Text = "7. Ngày tháng sinh và cung hoàng đạo";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Location = new Point(470, 467);
            button9.Name = "button9";
            button9.Size = new Size(394, 69);
            button9.TabIndex = 4;
            button9.Text = "9. Hôm nay ăn gì";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button2
            // 
            button2.Location = new Point(31, 275);
            button2.Name = "button2";
            button2.Size = new Size(394, 69);
            button2.TabIndex = 5;
            button2.Text = "2. Số lớn nhất, nhỏ nhất";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(31, 372);
            button3.Name = "button3";
            button3.Size = new Size(394, 69);
            button3.TabIndex = 6;
            button3.Text = "3. Đọc số";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(470, 179);
            button6.Name = "button6";
            button6.Size = new Size(394, 69);
            button6.TabIndex = 7;
            button6.Text = "6. Tính và xuất kết quả 2 số A, B";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(31, 467);
            button4.Name = "button4";
            button4.Size = new Size(394, 69);
            button4.TabIndex = 8;
            button4.Text = "4. Đọc số nâng cao";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 25);
            label1.Name = "label1";
            label1.Size = new Size(515, 124);
            label1.TabIndex = 9;
            label1.Text = "LÀM QUEN VỚI \r\nC# WINDOWS FORMS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = lab1.Properties.Resources.BG;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(907, 656);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 656);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "main";
            Text = "main";
            Load += main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button5;
        private Button button8;
        private Button button7;
        private Button button9;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox1;
    }
}