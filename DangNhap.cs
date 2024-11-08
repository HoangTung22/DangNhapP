using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangnhap
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();   
            dangKy.ShowDialog();
        }
        Modify modify = new Modify();

        private void button_DangNhap1_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show(" Vui Lòng Nhập Tên Tài Khoản! ");return; }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui Lòng Nhập Mật Khẩu! ");return; }
            else
            {
                string query = "Selct * from TaiKhoan where TenTaiKhoan ='"+tentk+"' and MatKhau = '"+matkhau+"'";
                if (modify.taiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng Nhập Thành Công! ","Thông Báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên Tài Khoản Hoặc Mật Khẩu Không Chính Xác! ", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
