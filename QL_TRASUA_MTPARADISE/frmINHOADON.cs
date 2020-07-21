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
    public partial class frmINHOADON : Form
    {
        public frmINHOADON()
        {
            InitializeComponent();
        }
        public string cnn = "Data Source=LAPTOP-DJ9J9KHA\\SQLEXPRESS;Initial Catalog=QL_TRASUA;Integrated Security=True";
        public string id;

        private void frmINHOADON_Load(object sender, EventArgs e)
        {
            var query = "SELECT DRINKTABLE.tablename, BILLINFO.id, DRINK.drinkname, DRINK.price, BILLINFO.count, BILLDRINKS.timecheckin, BILLDRINKS.timecheckout, BILLDRINKS.giamgia, BILLDRINKS.TongTien" +
                    " FROM BILLDRINKS INNER JOIN " +
                  " BILLINFO ON BILLDRINKS.id = BILLINFO.idbill INNER JOIN " +
                  " DRINK ON BILLINFO.iddrink = DRINK.id INNER JOIN " +
                  "DRINKTABLE ON BILLDRINKS.idtable = DRINKTABLE.id where BILLDRINKS.billstatus = 0 AND DRINKTABLE.tablename = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            try
            {
                DataTable tblInHoaDon = new DataTable();
                da.Fill(tblInHoaDon);
                rptInHoaDon rpt = new rptInHoaDon();
                rpt.SetDataSource(tblInHoaDon);
                crvInHoaDon.ReportSource = rpt;
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        

    }
}
