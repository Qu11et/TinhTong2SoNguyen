namespace lab1
{
    partial class Form8
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
            exTxt = new Button();
            button2 = new Button();
            inTxt = new TextBox();
            nameTxt = new TextBox();
            subjectList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            maxTxt = new TextBox();
            avgTxt = new TextBox();
            minTxt = new TextBox();
            passTxt = new TextBox();
            npassTxt = new TextBox();
            rankTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // exTxt
            // 
            exTxt.Location = new Point(217, 49);
            exTxt.Name = "exTxt";
            exTxt.Size = new Size(94, 29);
            exTxt.TabIndex = 0;
            exTxt.Text = "Tính";
            exTxt.UseVisualStyleBackColor = true;
            exTxt.Click += exTxt_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 49);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // inTxt
            // 
            inTxt.Location = new Point(77, 12);
            inTxt.Name = "inTxt";
            inTxt.Size = new Size(625, 31);
            inTxt.TabIndex = 2;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(219, 26);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(325, 31);
            nameTxt.TabIndex = 3;
            nameTxt.TextChanged += nameTxt_TextChanged;
            // 
            // subjectList
            // 
            subjectList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            subjectList.FullRowSelect = true;
            subjectList.GridLines = true;
            subjectList.Location = new Point(20, 69);
            subjectList.Margin = new Padding(4, 4, 4, 4);
            subjectList.Name = "subjectList";
            subjectList.Size = new Size(245, 464);
            subjectList.TabIndex = 0;
            subjectList.UseCompatibleStateImageBehavior = false;
            subjectList.View = View.Details;
            subjectList.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Môn";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Điểm";
            columnHeader2.Width = 120;
            // 
            // maxTxt
            // 
            maxTxt.Location = new Point(480, 156);
            maxTxt.Name = "maxTxt";
            maxTxt.Size = new Size(210, 31);
            maxTxt.TabIndex = 5;
            // 
            // avgTxt
            // 
            avgTxt.Location = new Point(480, 86);
            avgTxt.Name = "avgTxt";
            avgTxt.Size = new Size(210, 31);
            avgTxt.TabIndex = 6;
            // 
            // minTxt
            // 
            minTxt.Location = new Point(480, 230);
            minTxt.Name = "minTxt";
            minTxt.Size = new Size(210, 31);
            minTxt.TabIndex = 7;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(480, 306);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(210, 31);
            passTxt.TabIndex = 8;
            // 
            // npassTxt
            // 
            npassTxt.Location = new Point(480, 382);
            npassTxt.Name = "npassTxt";
            npassTxt.Size = new Size(210, 31);
            npassTxt.TabIndex = 9;
            npassTxt.TextChanged += textBox7_TextChanged;
            // 
            // rankTxt
            // 
            rankTxt.Location = new Point(480, 471);
            rankTxt.Name = "rankTxt";
            rankTxt.Size = new Size(210, 31);
            rankTxt.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 11;
            label1.Text = "Nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 29);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 12;
            label2.Text = "Họ Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 92);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 13;
            label3.Text = "Trung bình";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 162);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 14;
            label4.Text = "Cao nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 240);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 15;
            label5.Text = "Thấp nhất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 312);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 16;
            label6.Text = "Số môn đạt";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(298, 388);
            label7.Name = "label7";
            label7.Size = new Size(162, 25);
            label7.TabIndex = 17;
            label7.Text = "Số môn không đạt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(298, 471);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 18;
            label8.Text = "Xep loai";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(subjectList);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(avgTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(rankTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(npassTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(passTxt);
            groupBox1.Controls.Add(maxTxt);
            groupBox1.Controls.Add(minTxt);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 539);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "-*-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(720, 94);
            label9.Name = "label9";
            label9.Size = new Size(183, 138);
            label9.TabIndex = 20;
            label9.Text = "Danh sách \r\nđiểm của \r\nsinh viên";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 586);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(inTxt);
            Controls.Add(button2);
            Controls.Add(exTxt);
            Name = "Form8";
            Text = "Form8";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exTxt;
        private Button button2;
        private TextBox inTxt;
        private TextBox nameTxt;
        private ListView subjectList;
        private TextBox maxTxt;
        private TextBox avgTxt;
        private TextBox minTxt;
        private TextBox passTxt;
        private TextBox npassTxt;
        private TextBox rankTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label9;
    }
}