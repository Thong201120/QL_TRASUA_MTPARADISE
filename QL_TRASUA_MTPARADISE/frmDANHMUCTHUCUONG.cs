using QL_TRASUA_MTPARADISE.Data_Access_Obj;
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
    public partial class frmDANHMUCTHUCUONG : Form
    {
        BindingSource danhmucthucuong = new BindingSource();
        public frmDANHMUCTHUCUONG()
        {
            InitializeComponent();
            dgvDanhMuc.DataSource = danhmucthucuong;
            BindingHienDanhMuc();
            LoadDanhMucThucUong();
        }

        void LoadDanhMucThucUong()
        {
            danhmucthucuong.DataSource = DANHMUCTHUCUONGDAO.Instance.LayCBDanhMucThucUong();
        }

        void BindingHienDanhMuc()
        {
            txtIDDanhMuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource,"id", true, DataSourceUpdateMode.Never));
            txtTenDanhMuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "drinklistname", true, DataSourceUpdateMode.Never));
        }

        void ThemDM(string drinklistname)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm danh mục thức uống này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (DANHMUCTHUCUONGDAO.Instance.ThemDMfrmDanhMuc(drinklistname))
                {
                    MessageBox.Show("Thêm danh mục mới thành công!!!");
                }
                else
                {
                    MessageBox.Show("Thêm danh mục mới thất bại!!!");
                }
                LoadDanhMucThucUong();
            }
        }


        private void btnThemDM_Click(object sender, EventArgs e)
        {
            string drinklistname = txtTenDanhMuc.Text;
            ThemDM(drinklistname);
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDanhMuc.Text);
            if (MessageBox.Show("Bạn có chắc muốn xóa danh mục thức uống này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (DANHMUCTHUCUONGDAO.Instance.XoaDMfrmDanhMuc(id))
                {
                    MessageBox.Show("Xóa danh mục thành công!!!");
                }
                else
                {
                    MessageBox.Show("Xóa danh mục thất bại!!!");
                }
                LoadDanhMucThucUong();
            }
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            string drinklistname = txtTenDanhMuc.Text;
            int id = Convert.ToInt32(txtIDDanhMuc.Text);
            if (MessageBox.Show("Bạn có chắc muốn cập nhật danh mục thức uống này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (DANHMUCTHUCUONGDAO.Instance.CapNhatDMfrmDanhMuc(id, drinklistname))
                {
                    MessageBox.Show("Cập nhật danh mục thành công!!!");
                }
                else
                {
                    MessageBox.Show("Cập nhật danh mục thất bại!!!");
                }
                LoadDanhMucThucUong();
            }
        }

        private void btnXemDM_Click(object sender, EventArgs e)
        {
            LoadDanhMucThucUong();
        }

        private void txtTenDanhMuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
