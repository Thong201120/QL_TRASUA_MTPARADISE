using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class frmTAIKHOAN : Form
    {
        BindingSource DanhSachTaiKhoan = new BindingSource();
        public TaiKhoan dangnhapTK;
        public frmTAIKHOAN()
        {
            InitializeComponent();
            dgvTaiKhoan.DataSource = DanhSachTaiKhoan;
            HienTaiKhoan();
            HienThiDanhSachTK();
        }



        private void btnXemTK_Click(object sender, EventArgs e)
        {
            HienThiDanhSachTK();
        }

        void HienTaiKhoan()
        {
            txtTenHienThi.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "displayName", true, DataSourceUpdateMode.Never));
            txtTenTK.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "username", true, DataSourceUpdateMode.Never));
            nuType.DataBindings.Add(new Binding("Value", dgvTaiKhoan.DataSource, "typeuser", true, DataSourceUpdateMode.Never));
            txtCmnd.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "cmnd", true, DataSourceUpdateMode.Never));
            txtSodienthoai.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "sodienthoai", true, DataSourceUpdateMode.Never));
            txtDiachi.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "diachi", true, DataSourceUpdateMode.Never));
        }

        void HienThiDanhSachTK()
        {
            DanhSachTaiKhoan.DataSource = TaiKhoanDAO.Instance.LayDanhSachTaiKhoan();
        }

        void XoaTK(string username)
        {
            if (dangnhapTK.Username.Equals(username))
            {
                MessageBox.Show("Bạn đang xóa tài khoản của chính mình đó?????");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (TaiKhoanDAO.Instance.XoafrTaiKhoan(username))
                {
                    MessageBox.Show("Xóa Tài Khoản Thành Công");
                }

                else
                {
                    MessageBox.Show("Xóa Tài Khoản Thất bại!!!");
                }
                HienThiDanhSachTK();
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            string username = txtTenTK.Text;
            XoaTK(username);
        }

        void SuaTK (string username, string displayName ,int type, string cmnd, string sodienthoai, string diachi)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật tài khoản này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (TaiKhoanDAO.Instance.CapNhatfrTaiKhoan(username, displayName, type, cmnd, sodienthoai, diachi))
                {
                    MessageBox.Show("Sửa Tài Khoản Thành Công");
                }

                else
                {
                    MessageBox.Show("Sửa Tài Khoản Thất bại!!!");
                }
                HienThiDanhSachTK();
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            string username = txtTenTK.Text;
            string displayName = txtTenHienThi.Text;
            string cmnd = txtCmnd.Text;
            string sodienthoai = txtSodienthoai.Text;
            string diachi = txtDiachi.Text;
            int type = (int)nuType.Value;

            SuaTK(username, displayName, type, cmnd, sodienthoai, diachi);

        }

        void ThemTK(string username, string displayName, int type, string cmnd, string sodienthoai, string diachi)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm tài khoản này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (TaiKhoanDAO.Instance.ThemTKfrTaiKhoan(username, displayName, type, cmnd, sodienthoai, diachi))
                {
                    MessageBox.Show("Thêm Tài Khoản Thành Công");
                }

                else
                {
                    MessageBox.Show("Thêm Tài Khoản Thất bại!!!");
                }
                HienThiDanhSachTK();
            }
        }
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            string username = txtTenTK.Text;
            string displayName = txtTenHienThi.Text;
            string cmnd = txtCmnd.Text;
            string sodienthoai = txtSodienthoai.Text;
            string diachi = txtDiachi.Text;
            int type = (int)nuType.Value;

            ThemTK(username, displayName, type, cmnd, sodienthoai, diachi);
        }

        void DatlaiMK(string username)
        {
            if (MessageBox.Show("Bạn có chắc muốn đặt lại mật khẩu của tài khoản này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (TaiKhoanDAO.Instance.DatLaiMatKhau(username))
                {
                    MessageBox.Show("Đặt Lại Mật Khẩu Thành Công");
                }

                else
                {
                    MessageBox.Show("Đặt Lại Mật Khẩu Thất bại!!!");
                }
                HienThiDanhSachTK();
            }
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            string username = txtTenTK.Text;
            DatlaiMK(username);
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
