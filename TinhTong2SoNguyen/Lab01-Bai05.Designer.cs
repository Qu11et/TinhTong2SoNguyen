namespace lab1
{
    partial class Form6
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            exBtn = new Button();
            delBtn = new Button();
            exitBtn = new Button();
            AinTxt = new TextBox();
            BinTxt = new TextBox();
            outTxt = new TextBox();
            optList = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 108);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập số A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 108);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập số B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 258);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 2;
            label3.Text = "Kết quả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 161);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Lựa chọn:";
            // 
            // exBtn
            // 
            exBtn.Location = new Point(182, 218);
            exBtn.Name = "exBtn";
            exBtn.Size = new Size(94, 29);
            exBtn.TabIndex = 4;
            exBtn.Text = "Tính";
            exBtn.UseVisualStyleBackColor = true;
            exBtn.Click += exBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(352, 218);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 5;
            delBtn.Text = "Xóa";
            delBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(518, 218);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // AinTxt
            // 
            AinTxt.Location = new Point(204, 105);
            AinTxt.Name = "AinTxt";
            AinTxt.Size = new Size(125, 31);
            AinTxt.TabIndex = 7;
            // 
            // BinTxt
            // 
            BinTxt.Location = new Point(487, 108);
            BinTxt.Name = "BinTxt";
            BinTxt.Size = new Size(125, 31);
            BinTxt.TabIndex = 8;
            // 
            // outTxt
            // 
            outTxt.Location = new Point(89, 286);
            outTxt.Multiline = true;
            outTxt.Name = "outTxt";
            outTxt.ScrollBars = ScrollBars.Both;
            outTxt.Size = new Size(625, 139);
            outTxt.TabIndex = 10;
            // 
            // optList
            // 
            optList.FormattingEnabled = true;
            optList.Items.AddRange(new object[] { "Bảng cửu chương", "Tính giá trị" });
            optList.Location = new Point(204, 161);
            optList.Name = "optList";
            optList.Size = new Size(151, 33);
            optList.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(226, 23);
            label5.Name = "label5";
            label5.Size = new Size(332, 46);
            label5.TabIndex = 12;
            label5.Text = "Tính toán 2 số A và B";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(optList);
            Controls.Add(outTxt);
            Controls.Add(BinTxt);
            Controls.Add(AinTxt);
            Controls.Add(exitBtn);
            Controls.Add(delBtn);
            Controls.Add(exBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button exBtn;
        private Button delBtn;
        private Button exitBtn;
        private TextBox AinTxt;
        private TextBox BinTxt;
        private TextBox outTxt;
        private ComboBox optList;
        private Label label5;
    }
}