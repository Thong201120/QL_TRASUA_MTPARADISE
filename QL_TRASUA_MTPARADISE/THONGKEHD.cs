using CrystalDecisions.Shared;
using DevExpress.XtraEditors.Filtering.Templates;
using QL_TRASUA_MTPARADISE.Data_Access_Obj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TRASUA_MTPARADISE
{
    public partial class frmQuanLiThongKe : Form
    {
        public frmQuanLiThongKe()
        {
            InitializeComponent();
            LoadNgay();
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);

        }

        //Khi mở form lên sẽ load ngay danh sách các hóa đơn đã bán trong tháng hiện tại
        void LoadNgay()
        {
            DateTime homnay = DateTime.Now; //Khởi tạo biến lấy thời gian ngay hiện tại
            dtPTuNgay.Value = new DateTime(homnay.Year, homnay.Month, 1); //Ngày bắt đầu sẽ là ngày đầu tiên trong tháng
            dtPDenNgay.Value = dtPDenNgay.Value.AddMonths(1).AddDays(-1); //Ngày kết thúc tháng sẽ tháng kế tiếp trừ đi 1
        }

        //Load lại danh sách các hóa đơn từ hai mốc khoảng thời gian mà người dùng chọn
        void LoadThongkeDanhSachHD(DateTime timecheckin, DateTime timeckeckout)
        {
            //Load danh sách
            dgvBill.DataSource = BillDrinksDAO.Instance.THONGKEHOADON(timecheckin, timeckeckout);

            //Load tổng số bàn và doanh thu
            dgvKetQuaTK.DataSource = BillDrinksDAO.Instance.TONGTIENTHEOTHOIGIAN(timecheckin, timeckeckout);
        }


        //Xem thống kê
        private void btnXemTK_Click(object sender, EventArgs e)
        {
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        //Xem thống kê toàn bộ năm qua
        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 1, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 12, 31);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        //Xem theo quý 1
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 1, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 3, 31);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        //Xem theo quý 2
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 4, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 6, 30);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        //Xem theo quý 3
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 7, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 9, 30);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        //Xem theo quý 4
        private void button4_Click(object sender, EventArgs e)
        {
            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 10, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 12, 31);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        //In thống kê theo hai mốc dtpicker
        private void btnInThongKe_Click(object sender, EventArgs e)
        {
            INTHONGKE f = new INTHONGKE();
            //Chuyển đổi lại dữ liệu
            f.Timecheckin = Convert.ToDateTime(dtPTuNgay.Value).ToString("yyyy-MM-dd 00:00:00"); 
            f.Timecheckout = Convert.ToDateTime(dtPDenNgay.Value).ToString("yyyy-MM-dd 23:59:59");
            f.ShowDialog();
        }
    }
}
