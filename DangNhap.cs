using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        
        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //linkLabel_QuenMatKhau
        {
            this.Hide();
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
            //this.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        Modify modify = new Modify();

        private void button_DangNhap_Click(object sender, EventArgs e)
        {

            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;

            if (tentk.Trim() == "") { MessageBox.Show("Không được để trống! Vui lòng nhập tên tài khoản!");  }
            else if (matkhau.Trim() == "") { MessageBox.Show("Không được để trống! Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '"+tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!"/*, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information*/);

                    //Ẩn form Đăng nhập và chuyển sang FormMain
                    this.Hide();
                    FormMain toMain = new FormMain();
                    toMain.ShowDialog();
                    this.Close();  
                }

                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!"/*, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information*/);
                }
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
