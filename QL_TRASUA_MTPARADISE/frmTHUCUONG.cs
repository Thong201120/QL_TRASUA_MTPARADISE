using QL_TRASUA_MTPARADISE.Data_Access_Obj;
using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TRASUA_MTPARADISE
{
    public partial class frmTHUCUONG : Form
    {   
        BindingSource drinklist = new BindingSource();
        DataTable tblTHUCUONG;
        SqlDataAdapter daTHUCUONG;
        public frmTHUCUONG()
        {
           
            InitializeComponent(); 
            dgvDrink.DataSource = drinklist;
            LoadDSThucUong();
            BINGDINGthemmon();
            LoadCbDanhMucMon(cbDanhMuc);
            tblTHUCUONG = new DataTable();
            daTHUCUONG = new SqlDataAdapter("select * from drink", "Data Source=LAPTOP-DJ9J9KHA\\SQLEXPRESS;Initial Catalog=QL_TRASUA;Integrated Security=True");
            try
            {
                daTHUCUONG.Fill(tblTHUCUONG);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        //Hiển thị các thông tin của thức uống từ Datagridview sang các textbox, cbbox
        void BINGDINGthemmon()
        {
            txtTenThucUong.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "drinkname",true, DataSourceUpdateMode.Never));
            //Chỉ hiện thị chứ không bị thay đổi giá trị, tránh tình trạng khi thêm món mới sẽ làm thay đổi cả món cũ
            txtDThucUong.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "id" , true, DataSourceUpdateMode.Never));
            nuDonGia.DataBindings.Add(new Binding("Value", dgvDrink.DataSource, "price", true, DataSourceUpdateMode.Never));
        }

        void LoadCbDanhMucMon(ComboBox cb)
        {
            cb.DataSource = DANHMUCTHUCUONGDAO.Instance.LayCBDanhMucThucUong();
            cb.DisplayMember = "drinklistname";

        }

        void LoadDSThucUong()
        {
            drinklist.DataSource = THUCUONGDAO.Instance.THONGKETHUCUONG();
        }

        private void btnXemDSTU_Click(object sender, EventArgs e)
        {
            LoadDSThucUong();
        }

        List<THUCUONG> TimKiemThucUong(string drinkname)
        {
            List<THUCUONG> listdrink = THUCUONGDAO.Instance.TimKiemThucUong(drinkname);
            return listdrink;
        }

        private void btnTimThucUong_Click(object sender, EventArgs e)
        {
            if (txtTim.Text != "")
                drinklist.DataSource = TimKiemThucUong(txtTim.Text);
            else
                MessageBox.Show("Hãy Nhập Vào Gì Đó!!!", "Thông báo");
        }

        //Hàm thay đổi tên danh mục thức uống theo thức uống được chọn
        private void txtDThucUong_TextChanged(object sender, EventArgs e)
        {
            try // nếu như không có kết quả nào được trả về thì sẽ hiển thị gridview rỗng
            {
                //Nếu cột đang chọn lớn hơn 0 và dữ liệu tại cột đầu tiên của hàng đang chọn id danh mục khác null
                if (dgvDrink.SelectedCells.Count > 0 && dgvDrink.SelectedCells[0].OwningRow.Cells["iddrinklist"].Value != null)
                {
                    int id = (int)dgvDrink.SelectedCells[0].OwningRow.Cells["iddrinklist"].Value; //Lấy ra id danh mục của hàng này
                    //Lấy ra tên danh mục bằng id 
                    DANHMUCTHUCUONG DMTU = DANHMUCTHUCUONGDAO.Instance.LAYTENDANHMUCBANGID(id);
                    cbDanhMuc.SelectedItem = DMTU; 

                    int index = -1;
                    int i = 0;
                    foreach (DANHMUCTHUCUONG item in cbDanhMuc.Items) //gán id  cho từng danh mục để hiển loại danh mục cho thức uống
                    {
                        if (item.Id == DMTU.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbDanhMuc.SelectedIndex = index;
                }
            }
            catch {  return; }           
        }

        private void btnThemDSTU_Click(object sender, EventArgs e)
        {
            string drinkname = txtTenThucUong.Text;
            int iddrinklist = (cbDanhMuc.SelectedItem as DANHMUCTHUCUONG).Id;
            float price = (float)nuDonGia.Value;
            if (MessageBox.Show("Bạn có chắc muốn thêm thức uống này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (THUCUONGDAO.Instance.ThemMonfrTHUCUONG(drinkname, iddrinklist, price))
                {
                    MessageBox.Show("Thêm món thành công!!!", "Thông báo");
                    LoadDSThucUong();
                }
                else
                {
                    MessageBox.Show("Lỗi Khi Thêm! Kiểm Tra Lại!!", "Thông báo");
                }
            }
        }

        private void btnCapNhatDSTU_Click(object sender, EventArgs e)
        {
            string drinkname = txtTenThucUong.Text;
            int iddrinklist = (cbDanhMuc.SelectedItem as DANHMUCTHUCUONG).Id;
            float price = (float)nuDonGia.Value;
            int id = Convert.ToInt32(txtDThucUong.Text);
            if (MessageBox.Show("Bạn có chắc muốn cập nhật thức uống này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (THUCUONGDAO.Instance.CapNhatfrTHUCUONG(id, drinkname, iddrinklist, price))
                {
                    MessageBox.Show("Cập nhật món thành công!!!", "Thông báo");
                    LoadDSThucUong();
                }
                else
                {
                    MessageBox.Show("Lỗi Cập Nhật! Kiểm Tra Lại!!", "Thông báo");
                }
            }
        }

        private void btnXoaDSTU_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDThucUong.Text);
            if (MessageBox.Show("Bạn có chắc muốn xóa thức uống này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (THUCUONGDAO.Instance.XoafrTHUCUONG(id))
                {
                    MessageBox.Show("Xóa món thành công!!!", "Thông báo");
                    LoadDSThucUong();
                }
                else
                {
                    MessageBox.Show("Lỗi Khi Xóa! Kiểm Tra Lại!!", "Thông báo");
                }
            }
        }
        private void frmTHUCUONG_Load(object sender, EventArgs e)
        {

        }
    }
}
