namespace bai4
{
    partial class Form1
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
            this.lblnhap = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btndoc = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnhap
            // 
            this.lblnhap.BackColor = System.Drawing.Color.LightGray;
            this.lblnhap.ForeColor = System.Drawing.Color.IndianRed;
            this.lblnhap.Location = new System.Drawing.Point(38, 12);
            this.lblnhap.Name = "lblnhap";
            this.lblnhap.Size = new System.Drawing.Size(167, 44);
            this.lblnhap.TabIndex = 0;
            this.lblnhap.Text = "Nhập vảo một số Nguyên";
            this.lblnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnhap.Click += new System.EventHandler(this.lblnhap_Click);
            this.lblnhap.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.lblnhap_ControlAdded);
            this.lblnhap.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblnhap_DragDrop);
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.BackColor = System.Drawing.Color.LightGray;
            this.lblketqua.Location = new System.Drawing.Point(38, 83);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(54, 16);
            this.lblketqua.TabIndex = 1;
            this.lblketqua.Text = "Kết Quả";
            this.lblketqua.Click += new System.EventHandler(this.lblketqua_Click);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(286, 12);
            this.txtnhap.Multiline = true;
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(219, 44);
            this.txtnhap.TabIndex = 2;
            this.txtnhap.TextChanged += new System.EventHandler(this.txtnhap_TextChanged);
            // 
            // txtketqua
            // 
            this.txtketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketqua.Location = new System.Drawing.Point(286, 83);
            this.txtketqua.Multiline = true;
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(258, 126);
            this.txtketqua.TabIndex = 3;
            this.txtketqua.TextChanged += new System.EventHandler(this.txtketqua_TextChanged);
            // 
            // btndoc
            // 
            this.btndoc.BackColor = System.Drawing.Color.Cyan;
            this.btndoc.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoc.Location = new System.Drawing.Point(67, 216);
            this.btndoc.Name = "btndoc";
            this.btndoc.Size = new System.Drawing.Size(105, 63);
            this.btndoc.TabIndex = 4;
            this.btndoc.Text = "Đọc";
            this.btndoc.UseVisualStyleBackColor = false;
            this.btndoc.Click += new System.EventHandler(this.btndoc_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(224, 215);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(105, 63);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Yellow;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(393, 215);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(105, 63);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 377);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btndoc);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.lblnhap);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "Form1";
            this.Text = "Đọc số nâng cao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhap;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btndoc;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
    }
}

