using CrystalDecisions.Shared;
using DevExpress.Utils.Extensions;
using DevExpress.Xpo.DB.Helpers;
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
    public partial class INTHONGKE : Form
    {
        public INTHONGKE()
        {
            InitializeComponent();
        }

        //Tạo một chuổi connection string để kết nối xuống cơ sở dữ liệu
        public string cnn = "Data Source=LAPTOP-DJ9J9KHA\\SQLEXPRESS;Initial Catalog=QL_TRASUA;Integrated Security=True";

        //Khai báo hai biến để nhận tham số đầu vào
        public string Timecheckin;
        public string Timecheckout;

        private void frmINTHONGKE_Load(object sender, EventArgs e)
        {
            var query = "SELECT  BILLDRINKS.id, BILLDRINKS.timecheckin, BILLDRINKS.timecheckout, " +
                " BILLDRINKS.idtable," +
                " BILLDRINKS.billstatus, BILLDRINKS.giamgia, BILLDRINKS.TongTien " +
                " FROM BILLDRINKS INNER JOIN " +
                " BILLINFO ON BILLDRINKS.id = BILLINFO.idbill" +
                " WHERE timecheckin >= '" + Timecheckin + "' and timecheckout <= '" + Timecheckout + 
                "' and billstatus = 1";
            //Thực thi câu truy vấn
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);

            try
            {
                //Khởi tạo một bảng mới để đổ dữ liệu từ da va
                DataTable tblInThongKe = new DataTable();
                da.Fill(tblInThongKe);

                //Khởi tạo cửa sổ
                rptInThongKe rpt = new rptInThongKe();
              
                //Lấy dữ liệu từ bảng vào trong report in
                rpt.SetDataSource(tblInThongKe);
                crvINTHONGKE.ReportSource = rpt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
