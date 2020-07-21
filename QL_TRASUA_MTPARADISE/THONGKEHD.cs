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

        void LoadNgay()
        {
            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, homnay.Month, 1);
            dtPDenNgay.Value = dtPDenNgay.Value.AddMonths(1).AddDays(-1);
        }

        void LoadThongkeDanhSachHD(DateTime timecheckin, DateTime timeckeckout)
        {
            dgvBill.DataSource = BillDrinksDAO.Instance.THONGKEHOADON(timecheckin, timeckeckout);
        }



        private void btnXemTK_Click(object sender, EventArgs e)
        {
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 1, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 12, 31);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 1, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 3, 31);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 4, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 6, 30);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 7, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 9, 30);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime homnay = DateTime.Now;
            dtPTuNgay.Value = new DateTime(homnay.Year, 10, 1);
            dtPDenNgay.Value = new DateTime(homnay.Year, 12, 31);
            LoadThongkeDanhSachHD(dtPTuNgay.Value, dtPDenNgay.Value);
        }
    }
}
