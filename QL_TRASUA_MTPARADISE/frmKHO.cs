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
    public partial class frmKHO : Form
    {
        BindingSource danhsachnguyenlieu = new BindingSource();
        public frmKHO()
        {
            InitializeComponent();
            dgvKHO.DataSource = danhsachnguyenlieu;
            BinDingKHO();
            Loaddanhsachnguyenlieu();
        }

        void BinDingKHO()
        {
            txtIDNguyenLieu.DataBindings.Add(new Binding("Text", dgvKHO.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtTenNL.DataBindings.Add(new Binding("Text", dgvKHO.DataSource, "stuffname", true, DataSourceUpdateMode.Never));
            txtSLuong.DataBindings.Add(new Binding("Text", dgvKHO.DataSource, "stuffamount", true, DataSourceUpdateMode.Never));
            txtGiaNL.DataBindings.Add(new Binding("Text", dgvKHO.DataSource, "stuffprice", true, DataSourceUpdateMode.Never));
        }

        void Loaddanhsachnguyenlieu()
        {
            danhsachnguyenlieu.DataSource = KHODAO.Instance.loadSTOCKlist();
        }

        void THEMSTOCK(string stuffname, int stuffamount, int stuffprice)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm nguyên liệu này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (KHODAO.Instance.ThemNLfrmKHO(stuffname, stuffamount, stuffprice))
                {
                    MessageBox.Show("Thêm nguyên liệu thành công!!!!");
                }
                else
                {
                    MessageBox.Show("Thêm nguyên liệu thất bại!!!");
                }
                Loaddanhsachnguyenlieu();
            }
        }

        void CAPNHATSTOCK(int id, string stuffname, int stuffamount, int stuffprice)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật nguyên liệu này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (KHODAO.Instance.CapNhatNLfrmKHO(id, stuffname, stuffamount, stuffprice))
                {
                    MessageBox.Show("Cập nhật nguyên liệu thành công!!!!");
                }
                else
                {
                    MessageBox.Show("Cập nhật nguyên liệu thất bại!!!");
                }
                Loaddanhsachnguyenlieu();
            }
        }

        void XOASTOCK(string stuffname)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (KHODAO.Instance.XoaNLfrmKHO(stuffname))
                {
                    MessageBox.Show("Xóa nguyên liệu thành công!!!!");
                }
                else
                {
                    MessageBox.Show("Xóa nguyên liệu thất bại!!!");
                }
                Loaddanhsachnguyenlieu();
            }
        }

   

        private void btnThemNL_Click(object sender, EventArgs e)
        {
            string stuffname = txtTenNL.Text;
            int stuffamount = Convert.ToInt32(txtSLuong.Text);
            int stuffprice = Convert.ToInt32(txtGiaNL.Text);

            THEMSTOCK(stuffname, stuffamount, stuffprice);
        }

        private void btnSuaNL_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDNguyenLieu.Text);
            string stuffname = txtTenNL.Text;
            int stuffamount = Convert.ToInt32(txtSLuong.Text);
            int stuffprice = Convert.ToInt32(txtGiaNL.Text);

            CAPNHATSTOCK(id, stuffname, stuffamount, stuffprice);
        }

        private void btnXoaNL_Click(object sender, EventArgs e)
        {
            string stuffname = txtTenNL.Text;
            XOASTOCK(stuffname);
        }

        private void btnXemNL_Click(object sender, EventArgs e)
        {
            Loaddanhsachnguyenlieu();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
