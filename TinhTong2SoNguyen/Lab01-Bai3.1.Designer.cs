namespace lab1
{
    partial class Form4
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
            readBtn = new Button();
            delBtn = new Button();
            exitBtn = new Button();
            inTxt = new TextBox();
            outTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // readBtn
            // 
            readBtn.Location = new Point(157, 371);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(94, 29);
            readBtn.TabIndex = 0;
            readBtn.Text = "Đọc";
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += readBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(360, 371);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 1;
            delBtn.Text = "Xóa";
            delBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(555, 371);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // inTxt
            // 
            inTxt.Location = new Point(271, 119);
            inTxt.Name = "inTxt";
            inTxt.Size = new Size(125, 31);
            inTxt.TabIndex = 3;
            // 
            // outTxt
            // 
            outTxt.Location = new Point(271, 182);
            outTxt.Multiline = true;
            outTxt.Name = "outTxt";
            outTxt.ScrollBars = ScrollBars.Both;
            outTxt.Size = new Size(325, 139);
            outTxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 122);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 5;
            label1.Text = "Nhập số:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 185);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 6;
            label2.Text = "Kết quả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(271, 35);
            label3.Name = "label3";
            label3.Size = new Size(269, 46);
            label3.TabIndex = 7;
            label3.Text = "Đọc số nâng cao";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outTxt);
            Controls.Add(inTxt);
            Controls.Add(exitBtn);
            Controls.Add(delBtn);
            Controls.Add(readBtn);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button readBtn;
        private Button delBtn;
        private Button exitBtn;
        private TextBox inTxt;
        private TextBox outTxt;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}