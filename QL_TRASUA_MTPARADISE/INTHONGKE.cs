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
        public string cnn = "Data Source=LAPTOP-DJ9J9KHA\\SQLEXPRESS;Initial Catalog=QL_TRASUA;Integrated Security=True";
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
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);

            try
            {
                DataTable tblInThongKe = new DataTable();
                da.Fill(tblInThongKe);
                rptInThongKe rpt = new rptInThongKe();
              

                //rpt.SetParameterValue("Parameter_NgayBatDau", "Mệt mỏi");
                //rpt.SetParameterValue("Parameter_NgayKetThuc", "Quá mệt mỏi");
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
