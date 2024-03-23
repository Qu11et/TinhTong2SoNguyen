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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(128, 65);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Bai 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(249, 151);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 1;
            button5.Text = "Bai 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.Location = new Point(249, 233);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 2;
            button8.Text = "Bai 8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(128, 233);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 3;
            button7.Text = "Bai 7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Location = new Point(378, 233);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 4;
            button9.Text = "Bai 9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button1);
            Name = "main";
            Text = "main";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button5;
        private Button button8;
        private Button button7;
        private Button button9;
    }
}