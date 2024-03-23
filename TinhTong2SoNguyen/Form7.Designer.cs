namespace lab1
{
    partial class Form7
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
            dayLabel = new Label();
            outLabel = new Label();
            dayTxt = new TextBox();
            outTxt = new TextBox();
            enterBut = new Button();
            monthLabel = new Label();
            monthTxt = new TextBox();
            SuspendLayout();
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dayLabel.Location = new Point(142, 139);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(181, 31);
            dayLabel.TabIndex = 0;
            dayLabel.Text = "Nhap ngay sinh";
            // 
            // outLabel
            // 
            outLabel.AutoSize = true;
            outLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outLabel.Location = new Point(142, 269);
            outLabel.Name = "outLabel";
            outLabel.Size = new Size(310, 31);
            outLabel.TabIndex = 1;
            outLabel.Text = "Cung hoang dao cua ban la:";
            // 
            // dayTxt
            // 
            dayTxt.Location = new Point(474, 141);
            dayTxt.Name = "dayTxt";
            dayTxt.Size = new Size(200, 31);
            dayTxt.TabIndex = 2;
            dayTxt.TextChanged += txtI_TextChanged;
            // 
            // outTxt
            // 
            outTxt.Location = new Point(474, 269);
            outTxt.Name = "outTxt";
            outTxt.Size = new Size(200, 31);
            outTxt.TabIndex = 3;
            // 
            // enterBut
            // 
            enterBut.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterBut.Location = new Point(694, 139);
            enterBut.Name = "enterBut";
            enterBut.Size = new Size(43, 97);
            enterBut.TabIndex = 4;
            enterBut.Text = ">";
            enterBut.UseVisualStyleBackColor = true;
            enterBut.Click += enterBut_Click;
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthLabel.Location = new Point(142, 205);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(198, 31);
            monthLabel.TabIndex = 5;
            monthLabel.Text = "Nhap thang sinh:";
            // 
            // monthTxt
            // 
            monthTxt.Location = new Point(474, 205);
            monthTxt.Name = "monthTxt";
            monthTxt.Size = new Size(200, 31);
            monthTxt.TabIndex = 6;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthTxt);
            Controls.Add(monthLabel);
            Controls.Add(enterBut);
            Controls.Add(outTxt);
            Controls.Add(dayTxt);
            Controls.Add(outLabel);
            Controls.Add(dayLabel);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dayLabel;
        private Label outLabel;
        private TextBox dayTxt;
        private TextBox outTxt;
        private Button enterBut;
        private Label monthLabel;
        private TextBox monthTxt;
    }
}