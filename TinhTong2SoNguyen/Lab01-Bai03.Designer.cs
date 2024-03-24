namespace lab1
{
    partial class Form3
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
            inTxt = new TextBox();
            outTxt = new TextBox();
            readBtn = new Button();
            delBtn = new Button();
            exitTxt = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 142);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập số nguyên từ 0 đến 9:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 221);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 1;
            label2.Text = "Số bạn đã nhập là:";
            // 
            // inTxt
            // 
            inTxt.Location = new Point(437, 142);
            inTxt.Name = "inTxt";
            inTxt.Size = new Size(125, 31);
            inTxt.TabIndex = 2;
            // 
            // outTxt
            // 
            outTxt.Location = new Point(437, 221);
            outTxt.Name = "outTxt";
            outTxt.Size = new Size(125, 31);
            outTxt.TabIndex = 3;
            // 
            // readBtn
            // 
            readBtn.Location = new Point(127, 317);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(94, 29);
            readBtn.TabIndex = 4;
            readBtn.Text = "Đọc";
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += readBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(326, 317);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 5;
            delBtn.Text = "Xóa";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // exitTxt
            // 
            exitTxt.Location = new Point(545, 317);
            exitTxt.Name = "exitTxt";
            exitTxt.Size = new Size(94, 29);
            exitTxt.TabIndex = 6;
            exitTxt.Text = "Thoát";
            exitTxt.UseVisualStyleBackColor = true;
            exitTxt.Click += exitTxt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(326, 37);
            label3.Name = "label3";
            label3.Size = new Size(123, 46);
            label3.TabIndex = 7;
            label3.Text = "Đọc số";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(exitTxt);
            Controls.Add(delBtn);
            Controls.Add(readBtn);
            Controls.Add(outTxt);
            Controls.Add(inTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox inTxt;
        private TextBox outTxt;
        private Button readBtn;
        private Button delBtn;
        private Button exitTxt;
        private Label label3;
    }
}