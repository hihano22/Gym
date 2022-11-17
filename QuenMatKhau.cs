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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label_KetQua.Text = ""; //khoi tao ket qua trong
        }
        public void ReturnDN() //quay lai FormDangNhap
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
        Modify modify = new Modify();   

        private void button_LayMK_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text;
            if(email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đã được đăng ký!"); 
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    label_KetQua.ForeColor = Color.Green;
                    label_KetQua.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau;

                    //Tuy chon dang nhap
                    if (MessageBox.Show("Bạn có muốn đăng nhập ngay không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes) //Hien thi hop thong bao tuy chon
                    {
                        //quay lai FormDangNhap
                        ReturnDN();
                    }
                }
                else
                {
                    label_KetQua.ForeColor = Color.Red;
                    label_KetQua.Text = "Email chưa được đăng ký! ";
                }
            }
        }

        private void label_KetQua_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_TroLaiDN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReturnDN();
        }
    }
}
