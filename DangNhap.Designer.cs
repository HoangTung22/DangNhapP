namespace dangnhap
{
    partial class DangNhap
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
            this.button_DangNhap1 = new System.Windows.Forms.Button();
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.textBox_MatKhau1 = new System.Windows.Forms.TextBox();
            this.textBox_TaiKhoan1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_DangNhap1
            // 
            this.button_DangNhap1.AutoSize = true;
            this.button_DangNhap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_DangNhap1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_DangNhap1.Location = new System.Drawing.Point(381, 377);
            this.button_DangNhap1.Name = "button_DangNhap1";
            this.button_DangNhap1.Size = new System.Drawing.Size(109, 28);
            this.button_DangNhap1.TabIndex = 17;
            this.button_DangNhap1.Text = "Đăng Nhập";
            this.button_DangNhap1.UseVisualStyleBackColor = false;
            this.button_DangNhap1.Click += new System.EventHandler(this.button_DangNhap1_Click);
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.AutoSize = true;
            this.linkLabel_DangKy.Location = new System.Drawing.Point(338, 347);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Size = new System.Drawing.Size(57, 16);
            this.linkLabel_DangKy.TabIndex = 16;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Đăng Ký";
            this.linkLabel_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DangKy_LinkClicked);
            // 
            // linkLabel_QuenMatKhau
            // 
            this.linkLabel_QuenMatKhau.AutoSize = true;
            this.linkLabel_QuenMatKhau.Location = new System.Drawing.Point(463, 347);
            this.linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            this.linkLabel_QuenMatKhau.Size = new System.Drawing.Size(97, 16);
            this.linkLabel_QuenMatKhau.TabIndex = 15;
            this.linkLabel_QuenMatKhau.TabStop = true;
            this.linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu";
            this.linkLabel_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_QuenMatKhau_LinkClicked);
            // 
            // textBox_MatKhau1
            // 
            this.textBox_MatKhau1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_MatKhau1.Location = new System.Drawing.Point(226, 322);
            this.textBox_MatKhau1.Name = "textBox_MatKhau1";
            this.textBox_MatKhau1.Size = new System.Drawing.Size(78, 22);
            this.textBox_MatKhau1.TabIndex = 14;
            this.textBox_MatKhau1.Text = "Mật Khẩu";
            // 
            // textBox_TaiKhoan1
            // 
            this.textBox_TaiKhoan1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_TaiKhoan1.Location = new System.Drawing.Point(226, 277);
            this.textBox_TaiKhoan1.Name = "textBox_TaiKhoan1";
            this.textBox_TaiKhoan1.Size = new System.Drawing.Size(78, 22);
            this.textBox_TaiKhoan1.TabIndex = 13;
            this.textBox_TaiKhoan1.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(319, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Khách Sạn 3TUB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(324, 322);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(250, 22);
            this.textBox_MatKhau.TabIndex = 11;
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(324, 277);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(250, 22);
            this.textBox_TenTaiKhoan.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dangnhap.Properties.Resources.z6006738828850_ba3f3bcc401d12de59086004d29508fb;
            this.pictureBox1.Location = new System.Drawing.Point(256, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DangNhap1);
            this.Controls.Add(this.linkLabel_DangKy);
            this.Controls.Add(this.linkLabel_QuenMatKhau);
            this.Controls.Add(this.textBox_MatKhau1);
            this.Controls.Add(this.textBox_TaiKhoan1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_DangNhap1;
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
        private System.Windows.Forms.LinkLabel linkLabel_QuenMatKhau;
        private System.Windows.Forms.TextBox textBox_MatKhau1;
        private System.Windows.Forms.TextBox textBox_TaiKhoan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

