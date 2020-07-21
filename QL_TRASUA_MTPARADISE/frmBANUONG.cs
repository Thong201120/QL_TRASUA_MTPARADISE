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
    public partial class frmBANUONG : Form
    {
        BindingSource DanhSachBanUong = new BindingSource();
        public frmBANUONG()
        {
            InitializeComponent();
            dgvBAN.DataSource = DanhSachBanUong;
            BindingBanUong();
            LoadDanhSachBanUong();
        }

        void LoadDanhSachBanUong()
        {
            DanhSachBanUong.DataSource = TableDAO.Instance.loadDANHSACHBANUONG();
        }

        void BindingBanUong()
        {
            txtIDBan.DataBindings.Add(new Binding("Text", dgvBAN.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtTenBan.DataBindings.Add(new Binding("Text", dgvBAN.DataSource, "tablename", true, DataSourceUpdateMode.Never));
            txtTrangthai.DataBindings.Add(new Binding("Text", dgvBAN.DataSource, "tablestatus", true, DataSourceUpdateMode.Never));
        }

        void THEMBAN(string tablename)
        {
            if(TableDAO.Instance.ThemBanfrmBANUONG(tablename))
            {
                MessageBox.Show("Làm người đi!!!!!");
            }
            else
            {
                MessageBox.Show("Thêm Bàn Thành Công!!!!");
            }
            LoadDanhSachBanUong();
        }

        void CAPNHATBAN(string tablename, int id)
        {
            if (TableDAO.Instance.CapNhatfrmBanuong(tablename, id))
            {
                MessageBox.Show("Sửa bàn uống thành công!!!");
            }
            else
            {
                MessageBox.Show("Sửa bàn uống thất bại!!!");
            }
            LoadDanhSachBanUong();
        }

        void XOABAN(string tablename)
        {
            if(TableDAO.Instance.XoafrmBanuong(tablename))
            {
                MessageBox.Show("Xóa bàn uống thành công!!!");
            }
            else
            {
                MessageBox.Show("Xóa bàn uống thất bại!!!");
            }
            LoadDanhSachBanUong();
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            string tablename = txtTenBan.Text;
            THEMBAN(tablename);
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            string tablename = txtTenBan.Text;
            int id = Convert.ToInt32(txtIDBan.Text);
            CAPNHATBAN(tablename, id);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tablename = txtTenBan.Text;
            XOABAN(tablename);
        }

        private void btnXemBan_Click(object sender, EventArgs e)
        {
            LoadDanhSachBanUong();
        }

        private void txtTrangthai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
