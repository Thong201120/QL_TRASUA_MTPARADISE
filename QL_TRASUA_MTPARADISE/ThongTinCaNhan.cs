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
    public partial class frmThongTinCaNhan : Form
    {
        public frmThongTinCaNhan(TaiKhoan TK)
        {
            InitializeComponent();
            TaiKhoanuser = TK;
        }

        private TaiKhoan taiKhoanuser;
        public TaiKhoan TaiKhoanuser
        {
            get { return taiKhoanuser; }
            set
            {
                taiKhoanuser = value;
                ChuyenTrangThai(taiKhoanuser);
            }
        }

        //Lấy và hiển thị thông tin tài khoản đang truy cập hiện thời
        void ChuyenTrangThai(TaiKhoan TK)
        {
            txtTenDangNhap.Text = taiKhoanuser.Username;
            txtTenHienThi.Text = taiKhoanuser.DisplayName;
            txtSodienthoai.Text = taiKhoanuser.Sodienthoai;
            txtCmnd.Text = taiKhoanuser.Cmnd;
            txtDiachi.Text = taiKhoanuser.Diachi;
        }

        //Cập nhật lại tài khoản
        void CapNhatTaiKhoan()
        {
            string displayName = txtTenHienThi.Text;
            string userpassword = txtMatKhau.Text;
            string passwordmoi = txtMatKhauMoi.Text;
            string cmnd = txtCmnd.Text;
            string sodienthoai = txtSodienthoai.Text;
            string diachi = txtDiachi.Text;
            string reeternewpass = txtMatKhauMoi.Text;
            string username = txtTenDangNhap.Text;

            //Kiểm tra xem mật khẩu cũ và mật khẩu mới có trùng với nhau không
            if (txtMatKhauMoi.Text != txtNhapLaiPass.Text)
            {
                MessageBox.Show("Mật khẩu mới nhập lại không trùng khớp!! Hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Nếu đã trùng thì tiếp tục kiểm tra
            else
            {
                //Nếu mật khẩu đúng
                if (TaiKhoanDAO.Instance.CheckCapNhatTaiKhoan(username, displayName, userpassword, passwordmoi, cmnd, sodienthoai, diachi))
                {
                    MessageBox.Show("Cập nhật thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                //Nếu mật khẩu không đúng
                else
                {
                    //Nếu chưa mật mật khẩu hay mật khẩu rỗng
                    if (txtMatKhau.Text == "")
                    {
                        MessageBox.Show("Nhập vào mật khẩu!!!!");
                    }
                    //Còn lại thì chỉ có thể là sai mật khẩu thôi:))
                    else
                    {
                        MessageBox.Show("Sai mật khẩu. Hãy kiểm tra lại!!!!");
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật lại thông tin không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                CapNhatTaiKhoan();
            }
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }
    }
}
