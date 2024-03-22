namespace Lab01
{
    partial class cBai03
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
            this.label_So = new System.Windows.Forms.Label();
            this.So = new System.Windows.Forms.TextBox();
            this.Doc = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.label_KetQua = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_So
            // 
            this.label_So.AutoSize = true;
            this.label_So.Location = new System.Drawing.Point(145, 106);
            this.label_So.Name = "label_So";
            this.label_So.Size = new System.Drawing.Size(137, 13);
            this.label_So.TabIndex = 0;
            this.label_So.Text = "Nhập số nguyên từ 0 đến 9";
            // 
            // So
            // 
            this.So.Location = new System.Drawing.Point(344, 99);
            this.So.Name = "So";
            this.So.Size = new System.Drawing.Size(100, 20);
            this.So.TabIndex = 1;
            // 
            // Doc
            // 
            this.Doc.Location = new System.Drawing.Point(528, 105);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(75, 23);
            this.Doc.TabIndex = 3;
            this.Doc.Text = "Đọc";
            this.Doc.UseVisualStyleBackColor = true;
            this.Doc.TextChanged += new System.EventHandler(this.click_Doc);
            this.Doc.Click += new System.EventHandler(this.click_Doc);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(528, 144);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "Xoá ";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.click_Xoa);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(528, 186);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 23);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.click_Thoat);
            // 
            // label_KetQua
            // 
            this.label_KetQua.AutoSize = true;
            this.label_KetQua.Location = new System.Drawing.Point(145, 191);
            this.label_KetQua.Name = "label_KetQua";
            this.label_KetQua.Size = new System.Drawing.Size(44, 13);
            this.label_KetQua.TabIndex = 0;
            this.label_KetQua.Text = "Kết quả";
            // 
            // KetQua
            // 
            this.KetQua.Location = new System.Drawing.Point(344, 188);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(100, 20);
            this.KetQua.TabIndex = 1;
            // 
            // cBai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.So);
            this.Controls.Add(this.label_KetQua);
            this.Controls.Add(this.label_So);
            this.Name = "cBai03";
            this.Text = "Bài tập 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_So;
        private System.Windows.Forms.TextBox So;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Label label_KetQua;
        private System.Windows.Forms.TextBox KetQua;
    }
}