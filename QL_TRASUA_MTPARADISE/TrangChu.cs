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
            this.TaiKhoanuser = TK;
            loadTable();
            LoadcbDanhMuc();
            LoadcbChuyenBan(cbChuyenBan);

        }

        void ChuyenTrangThai(int trangthai)
        {
            tmsTaiKhoan.Enabled = trangthai == 1;
            tsmThongTinTK.Text += "  ->" + TaiKhoanuser.DisplayName + "<-  ";
            lbNhanvien.Text = taiKhoanuser.DisplayName;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void aDMINISTRATORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiThongKe f = new frmQuanLiThongKe();
            f.ShowDialog();
        }

        void loadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.loadTableList();
            foreach(Table item in tableList)
            {
                Button btn = new Button() {Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                flpTable.Controls.Add(btn);
                btn.Text = item.Tablename; // + Environment.NewLine + item.Tablestatus;
                btn.Click += Btn_Click;
                btn.Tag = item;
                int newSize = 15;
                btn.Font = new Font(btn.Font.FontFamily, newSize);

                switch (item.Tablestatus)
                {
                    case "Chưa Đặt":
                        //btn.BackColor = Color.LawnGreen;
                        btn.BackgroundImage = QL_TRASUA_MTPARADISE.Properties.Resources.themmoiCHOT;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.ForeColor = Color.White;

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
        void showBill(int id)
        {
            lsvBill.Items.Clear();
            txtTimeCheckin.Clear();
            List<QL_TRASUA_MTPARADISE.Data_Transfer_Obj.DanhSachThucUong> listBillInfo = DanhSachThucUongDAO.Instance.GetDanhSachThucUong(id);
            float TotalPrice = 0;
            foreach (QL_TRASUA_MTPARADISE.Data_Transfer_Obj.DanhSachThucUong item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Drinkname.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Tongtien.ToString());
                TotalPrice += item.Tongtien;

                lsvBill.Items.Add(lsvItem);
                txtTimeCheckin.Text = BillDrinksDAO.Instance.LAYGIOVAO(id).ToString("yyyy-MM-dd HH:mm:ss.fff");

            }
            txtTotalPrice.Text = TotalPrice.ToString();
            
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBill.Tag = (sender as Button).Tag;
            lbtenban.Text = "Bàn " + tableID.ToString();
            showBill(tableID);
        }

        void LoadcbDanhMuc()
        {
            List<DANHMUCTHUCUONG> DanhMucThucUong = DANHMUCTHUCUONGDAO.Instance.LayCBDanhMucThucUong();
            cbDanhMuc.DataSource = DanhMucThucUong;
            cbDanhMuc.DisplayMember = "drinklistname";
        }

        void LoadcbDanhSachThucUong(int id)
        {
            List<THUCUONG> ThucUong = THUCUONGDAO.Instance.LayCBDanhSachThucUong(id);
            cbDanhSachMon.DataSource = ThucUong;
            cbDanhSachMon.DisplayMember = "drinkname";

        }

        void LoadcbChuyenBan(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.loadTableList();
            cb.DisplayMember = "tablename";
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null) return;
            DANHMUCTHUCUONG selected = cb.SelectedItem as DANHMUCTHUCUONG;
            id = selected.Id;

            LoadcbDanhSachThucUong(id);
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



        private void cbDanhSachMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nuSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                    
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimeCheckin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
