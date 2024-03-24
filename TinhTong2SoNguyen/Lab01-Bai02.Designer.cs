namespace TinhTong2SoNguyen
{
    partial class Form2
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
            num1Txt = new TextBox();
            num2Txt = new TextBox();
            num3Txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            findBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            maxTxt = new TextBox();
            minTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // num1Txt
            // 
            num1Txt.Location = new Point(391, 139);
            num1Txt.Name = "num1Txt";
            num1Txt.Size = new Size(125, 31);
            num1Txt.TabIndex = 0;
            // 
            // num2Txt
            // 
            num2Txt.Location = new Point(391, 200);
            num2Txt.Name = "num2Txt";
            num2Txt.Size = new Size(125, 31);
            num2Txt.TabIndex = 1;
            // 
            // num3Txt
            // 
            num3Txt.Location = new Point(391, 273);
            num3Txt.Name = "num3Txt";
            num3Txt.Size = new Size(125, 31);
            num3Txt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 139);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 3;
            label1.Text = "Số thứ nhất:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 206);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 4;
            label2.Text = "Số thứ hai:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 276);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 5;
            label3.Text = "Số thứ ba:";
            // 
            // findBtn
            // 
            findBtn.Location = new Point(652, 153);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(94, 29);
            findBtn.TabIndex = 6;
            findBtn.Text = "Tìm";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(652, 207);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(652, 262);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // maxTxt
            // 
            maxTxt.Location = new Point(222, 363);
            maxTxt.Name = "maxTxt";
            maxTxt.Size = new Size(125, 31);
            maxTxt.TabIndex = 9;
            // 
            // minTxt
            // 
            minTxt.Location = new Point(518, 363);
            minTxt.Name = "minTxt";
            minTxt.Size = new Size(125, 31);
            minTxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 369);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 11;
            label4.Text = "Số lớn nhất:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 369);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 12;
            label5.Text = "Số bé nhất:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(193, 37);
            label6.Name = "label6";
            label6.Size = new Size(400, 46);
            label6.TabIndex = 13;
            label6.Text = "Tìm số lớn nhất, nhỏ nhất";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(minTxt);
            Controls.Add(maxTxt);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(findBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(num3Txt);
            Controls.Add(num2Txt);
            Controls.Add(num1Txt);
            Name = "Form2";
            Text = "Form2";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1Txt;
        private TextBox num2Txt;
        private TextBox num3Txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button findBtn;
        private Button button2;
        private Button button3;
        private TextBox maxTxt;
        private TextBox minTxt;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}