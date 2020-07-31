using QL_TRASUA_MTPARADISE.Data_Access_Obj;
using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CrystalDecisions.CrystalReports.ViewerObjectModel;

namespace QL_TRASUA_MTPARADISE
{
    public partial class fTrangChu : Form
    {
        private TaiKhoan taiKhoanuser;
        public TaiKhoan TaiKhoanuser
        {
            get { return taiKhoanuser;}
            set
            {
                taiKhoanuser = value;
                ChuyenTrangThai(taiKhoanuser.Typeuser);
            }
        }

        public fTrangChu(TaiKhoan TK)
        {
            InitializeComponent();
            this.TaiKhoanuser = TK; //Tài khoản hiện hành đang đăng nhập vào
            loadTable(); //load danh sách bàn
            LoadcbDanhMuc(); //load cb danh mục thức uống
            LoadcbChuyenBan(cbChuyenBan); //load cb chuyển bàn

        }

        void ChuyenTrangThai(int trangthai)
        {
            //Phân quyền truy cập đối với các loại tài khoản, nếu typeuser = 1 thì cho phép truy cập
            tmsTaiKhoan.Enabled = trangthai == 1;
            aDMINISTRATORToolStripMenuItem.Enabled = trangthai == 1;
            tmsQL_Thuc_Don.Enabled = trangthai == 1;
            tsmBanUong.Enabled = trangthai == 1;
            tsmQL_Kho.Enabled = trangthai == 1;
            lbNhanvien.Text = taiKhoanuser.DisplayName; //hiển thị tên nhân viên đang truy cập trên lbnhanvien
        }


        private void aDMINISTRATORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiThongKe f = new frmQuanLiThongKe();
            f.ShowDialog();
        }

        //Load danh sách button tương ứng với các bàn 
        void loadTable()
        {
            flpTable.Controls.Clear(); //làm mới lại flp table

            //Khởi tạo một list table và load các button bàn 
            List<Table> tableList = TableDAO.Instance.loadTableList();
            foreach(Table item in tableList)
            {
                Button btn = new Button() {Width = 150, Height = 150}; //Khởi tạo button với chiều cao = 150 và chiều rộng = 150
                flpTable.Controls.Add(btn); //Thêm các btn vào flp
                btn.Text = item.Tablename; //Gán tên bàn làm tên hiển thị trên button
                btn.Click += Btn_Click; //Tạo sự kiện click cho các button +=tab
                btn.Tag = item; //Lưu trữ thông tin của table
                int newSize = 15; //cỡ chữ 15
                btn.Font = new Font(btn.Font.FontFamily, newSize);

                switch (item.Tablestatus)
                {
                    case "Chưa Đặt":
                        //btn.BackColor = Color.LawnGreen;
                        btn.BackgroundImage = QL_TRASUA_MTPARADISE.Properties.Resources.themmoiCHOT; //Hình ảnh nền button
                        btn.BackgroundImageLayout = ImageLayout.Stretch; //Định dạnh hình ảnh dàn đầy button
                        btn.ForeColor = Color.White; //Màu chữ trên button 
                        break;

                    default:
                        //btn.BackColor = Color.LightPink;
                        btn.BackgroundImage = QL_TRASUA_MTPARADISE.Properties.Resources.chuadatCHOT;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.ForeColor = Color.White;
                        break;
                }
            }

        }

        //Load thông tin từng hóa đơn
        void showBill(int id)
        {
            lsvBill.Items.Clear(); //Làm mới lại listview
            txtTimeCheckin.Clear(); //Làm mới thời gian checkin
            //Lấy ra danh sách thức uống theo id bàn đang xảy ra sự kiện click
            List<QL_TRASUA_MTPARADISE.Data_Transfer_Obj.DanhSachThucUong> listBillInfo = DanhSachThucUongDAO.Instance.GetDanhSachThucUong(id);
            float TotalPrice = 0; //giá tổng tiền bằng 0
            foreach (QL_TRASUA_MTPARADISE.Data_Transfer_Obj.DanhSachThucUong item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Drinkname.ToString()); //Giá trị truyền vào sẽ là Tên thức uống
                //Các giá trị còn lại sẽ là subitems của item và add vào lsvItem
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Tongtien.ToString());
                //Tổng tiền sẽ tự động cộng dồn vào sau mỗi lần thêm món mới
                TotalPrice += item.Tongtien;

                //Hiển thị lsvItem lên lsvBill
                lsvBill.Items.Add(lsvItem);

                //Lấy thời gian bắt đầu thêm thức uống đầu tiên vào
                txtTimeCheckin.Text = BillDrinksDAO.Instance.LAYGIOVAO(id).ToString("yyyy-MM-dd HH:mm:ss.fff");

            }
            //Hiển thị tổng tiền lên textbox
            txtTotalPrice.Text = TotalPrice.ToString();
            
        }

        //Sự kiện click vào button sẽ hiện ra thông tin của button đó
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id; //Lấy id của bàn ra từ thẻ Tag đã được gán dữ liệu về bàn trước đó
            lsvBill.Tag = (sender as Button).Tag; //Lấy dữ liệu của từng bàn ra
            lbtenban.Text = "Bàn " + tableID.ToString();
            showBill(tableID); //hiển thị lên lsvBill
        }

        //load combobox danh mục:
        void LoadcbDanhMuc()
        {
            List<DANHMUCTHUCUONG> DanhMucThucUong = DANHMUCTHUCUONGDAO.Instance.LayCBDanhMucThucUong(); //Lấy dữ liệu danh sách danh mục ra
            cbDanhMuc.DataSource = DanhMucThucUong; //Đổ dữ liễu vào cb
            cbDanhMuc.DisplayMember = "drinklistname";//Giá trị hiển thị sẽ là tên danh mục thức uống
        }

        //load combobox danh sách thức uống, tương tự như trên những sẽ chỉ hiển thị những thức uống cùng loại theo id
        void LoadcbDanhSachThucUong(int id)
        {
            List<THUCUONG> ThucUong = THUCUONGDAO.Instance.LayCBDanhSachThucUong(id);
            cbDanhSachMon.DataSource = ThucUong;
            cbDanhSachMon.DisplayMember = "drinkname";

        }

        //Load combobox chuyển bàn
        void LoadcbChuyenBan(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.loadTableList();
            cb.DisplayMember = "tablename";
        }


        private void fTrangChu_Load(object sender, EventArgs e)
        {

        }

        //Hiển thị danh sách thức uống danh mục thức uống
        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0; //tạo id danh mục bằng 0
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null) return;
            DANHMUCTHUCUONG selected = cb.SelectedItem as DANHMUCTHUCUONG; //lấy ra giá trị của id hiện tại, tương ứng với danh mục đang chọn
            id = selected.Id; //gán trị của id vừa lấy ra

            LoadcbDanhSachThucUong(id); //load lại cb thức uống theo id
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món!", "Thông báo", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                return;
            }

            int idbill = BillDrinksDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            int iddrink = (cbDanhSachMon.SelectedItem as THUCUONG).Id;
            int count = (int)nuSoLuong.Value;
            if (idbill == -1)
            {
                BillDrinksDAO.Instance.ThemBill(table.Id);
                txtTimeCheckin.Text = BillDrinksDAO.Instance.LAYGIOVAO(table.Id).ToString();
                int idbilllonnhat = BillDrinksDAO.Instance.LayBillLonNhat();
                BillInfoDAO.Instance.THEMTHONGTINBILL(idbilllonnhat, iddrink, count);

            }
            else
            {
                BillInfoDAO.Instance.THEMTHONGTINBILL(idbill, iddrink, count);
            }
            showBill(table.Id);
            loadTable();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Bàn còn trống\n\nkhông có thức uống nào để thanh toán!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idbill = BillDrinksDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            int giamgia = (int)nuGiamGia.Value;
            double thanhtoan = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
            double tongtiendagiamgia = thanhtoan - (thanhtoan / 100) * giamgia;
            if (idbill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn thanh toán cho {0} không?\n\nGiảm Giá: {1}%\n\nTổng Tiền: {2}",table.Tablename, giamgia, tongtiendagiamgia), "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDrinksDAO.Instance.CHECKOUT(idbill, giamgia, (float)tongtiendagiamgia);
                    showBill(table.Id);
                    loadTable();
                    MessageBox.Show("Thanh toán thành công!!!", "Thông báo", MessageBoxButtons.OK);
                }
            }

        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {

            int temp1 = (lsvBill.Tag as Table).Id;
            int temp2 = (cbChuyenBan.SelectedItem as Table).Id;
            if (MessageBox.Show(string.Format("Bạn có muốn muốn chuyển bàn {0} sang bàn {1} không??", (lsvBill.Tag as Table).Tablename, (cbChuyenBan.SelectedItem as Table).Tablename), "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.HOANVIBAN(temp1, temp2);
                loadTable();
                MessageBox.Show("Chuyển bàn thành công!!!", "Thông báo", MessageBoxButtons.OK);
            }
        }



        private void tsmThongTinTK_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan f = new frmThongTinCaNhan(TaiKhoanuser);
            f.Capnhatlaitentk += F_Capnhatlaitentk;
            f.ShowDialog();
        }

        private void tmsTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTAIKHOAN f = new frmTAIKHOAN();
            f.dangnhapTK = TaiKhoanuser;
            f.ShowDialog(); 
        }

        private void F_Capnhatlaitentk(object sender, frmThongTinCaNhan.TaiKhoanEvent e)
        {
            tsmThongTinTK.Text = "THÔNG TIN TÀI KHOẢN (" + e.TK1.DisplayName + ")";
        }

        private void tsmiThucUong_Click(object sender, EventArgs e)
        {
            frmTHUCUONG f = new frmTHUCUONG();
            f.Themthucuong += F_Themthucuong;
            f.Xoathucuong += F_Xoathucuong;
            f.Capnhatthucuong += F_Capnhatthucuong;
            f.ShowDialog();
        }

        private void F_Capnhatthucuong(object sender, EventArgs e)
        {
            LoadcbDanhSachThucUong((cbDanhMuc.SelectedItem as DANHMUCTHUCUONG).Id);
            if (lsvBill.Tag != null)
                showBill((lsvBill.Tag as Table).Id);
        }

        private void F_Xoathucuong(object sender, EventArgs e)
        {
            LoadcbDanhSachThucUong((cbDanhMuc.SelectedItem as DANHMUCTHUCUONG).Id);
            if (lsvBill.Tag != null)
                showBill((lsvBill.Tag as Table).Id);
            loadTable();
        }

        private void F_Themthucuong(object sender, EventArgs e)
        {
            LoadcbDanhSachThucUong((cbDanhMuc.SelectedItem as DANHMUCTHUCUONG).Id);
            if (lsvBill.Tag != null)
                showBill((lsvBill.Tag as Table).Id);
        }

        private void tmsiDanhMuc_Click(object sender, EventArgs e)
        {
            frmDANHMUCTHUCUONG f = new frmDANHMUCTHUCUONG();
            f.ShowDialog();
        }

        private void tsmBanUong_Click(object sender, EventArgs e)
        {
            frmBANUONG f = new frmBANUONG();
            f.ShowDialog();
        }

        private void tsmQL_Kho_Click(object sender, EventArgs e)
        {
            frmKHO f = new frmKHO();
            f.ShowDialog();
        }

        private void tmsGioiThieu_Click(object sender, EventArgs e)
        {
            frmGIOITHIEU f = new frmGIOITHIEU();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idbill = BillDrinksDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            int giamgia = (int)nuGiamGia.Value;
            double thanhtoan = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
            double tongtiendagiamgia = thanhtoan - (thanhtoan / 100) * giamgia;
            if (idbill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn thanh toán cho {0} không?\nGiảm Giá: {1}%\n Tổng Tiền: {2}", table.Tablename, giamgia, tongtiendagiamgia), "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                {
                    
                    frmINHOADON f = new frmINHOADON();
                    f.id = table.Tablename.ToString();
                    BillDrinksDAO.Instance.PRINTBEFORECHECKOUT(idbill, giamgia, (float)tongtiendagiamgia);
                    f.ShowDialog();
                    BillDrinksDAO.Instance.CHECKOUT(idbill, giamgia, (float)tongtiendagiamgia);       
                    showBill(table.Id);
                    loadTable();
                    MessageBox.Show("Thanh toán thành công!!!","Thông báo", MessageBoxButtons.OK);
                }
            }
        }


    }
}
