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
        void ChuyenTrangThai(TaiKhoan TK)
        {
            txtTenDangNhap.Text = taiKhoanuser.Username;
            txtTenHienThi.Text = taiKhoanuser.DisplayName;
            txtSodienthoai.Text = taiKhoanuser.Sodienthoai;
            txtCmnd.Text = taiKhoanuser.Cmnd;
            txtDiachi.Text = taiKhoanuser.Diachi;
        }

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

            if (!passwordmoi.Equals(reeternewpass))
            {
                MessageBox.Show("Mật khẩu mới nhập lại không trùng khớp!! Hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TaiKhoanDAO.Instance.CheckCapNhatTaiKhoan(username, displayName, userpassword, passwordmoi, cmnd, sodienthoai, diachi))
                {
                    MessageBox.Show("Cập nhật thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (capnhatlaitentk != null)
                        capnhatlaitentk(this, new TaiKhoanEvent(TaiKhoanDAO.Instance.LayTaiKhoangBangUserName(username)));
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu. Hãy kiểm tra lại!!!!");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatTaiKhoan();
        }

        private event EventHandler<TaiKhoanEvent> capnhatlaitentk;
        public event EventHandler<TaiKhoanEvent> Capnhatlaitentk
        {
            add { capnhatlaitentk += value; }
            remove { capnhatlaitentk -= value; }
        }

        public class TaiKhoanEvent:EventArgs
        {
            private TaiKhoan TK;

            public TaiKhoan TK1 { get => TK; set => TK = value; }

            public TaiKhoanEvent(TaiKhoan TK)
            {
                this.TK1 = TK;
            }
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }
    }
}
