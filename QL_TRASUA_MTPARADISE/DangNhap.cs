using QL_TRASUA_MTPARADISE.Data_Access_Obj;
using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TRASUA_MTPARADISE
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
           if (login(username, password))
            {
                TaiKhoan taikhoan = TaiKhoanDAO.Instance.LayTaiKhoangBangUserName(username);
                fTrangChu f = new fTrangChu(taikhoan);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
           else
            {
                MessageBox.Show("Sai Tên Tài Khoản Hoặc Mật Khẩu!!!", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        bool login(string username, string password)
        {   
            return  AccountDAO.Instance.login(username, password);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
