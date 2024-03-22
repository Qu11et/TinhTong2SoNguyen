namespace lab1
{
    partial class Form9
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
            inputTxt = new TextBox();
            outputTxt = new TextBox();
            addBtn = new Button();
            findBtn = new Button();
            delBtn = new Button();
            resultTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 31);
            label1.TabIndex = 0;
            label1.Text = "Nhap mon an:";
            // 
            // inputTxt
            // 
            inputTxt.Location = new Point(233, 81);
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new Size(212, 38);
            inputTxt.TabIndex = 1;
            // 
            // outputTxt
            // 
            outputTxt.Location = new Point(475, 81);
            outputTxt.Multiline = true;
            outputTxt.Name = "outputTxt";
            outputTxt.ScrollBars = ScrollBars.Both;
            outputTxt.Size = new Size(317, 138);
            outputTxt.TabIndex = 2;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(351, 141);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 48);
            addBtn.TabIndex = 3;
            addBtn.Text = "Them";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // findBtn
            // 
            findBtn.Location = new Point(61, 322);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(238, 48);
            findBtn.TabIndex = 4;
            findBtn.Text = "Tim mon an";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(573, 322);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 48);
            delBtn.TabIndex = 5;
            delBtn.Text = "Xoa";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // resultTxt
            // 
            resultTxt.Location = new Point(195, 433);
            resultTxt.Name = "resultTxt";
            resultTxt.Size = new Size(456, 38);
            resultTxt.TabIndex = 7;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 522);
            Controls.Add(resultTxt);
            Controls.Add(delBtn);
            Controls.Add(findBtn);
            Controls.Add(addBtn);
            Controls.Add(outputTxt);
            Controls.Add(inputTxt);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTxt;
        private TextBox outputTxt;
        private Button addBtn;
        private Button findBtn;
        private Button delBtn;
        private TextBox resultTxt;
    }
}