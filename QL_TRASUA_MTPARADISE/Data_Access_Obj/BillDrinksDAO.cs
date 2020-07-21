using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TRASUA_MTPARADISE.Data_Access_Obj
{
    public class BillDrinksDAO
    {
        private static BillDrinksDAO instance;

        public static BillDrinksDAO Instance
        {
            get { if (instance == null) instance = new BillDrinksDAO(); return BillDrinksDAO.instance; }
            private set { BillDrinksDAO.instance = value; }
        }

        private BillDrinksDAO() { }

        public int GetUnCheckBillIDByTableID(int id) //Lấy ra bill chưa thanh toán!!!
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BILLDRINKS WHERE idtable = " + id + "AND billstatus = 0");
            if (data.Rows.Count > 0)
            {
                BILLDRINKS bill = new BILLDRINKS(data.Rows[0]);
                return bill.Id;// Có bill chưa thanh toán
            }
            return -1; //Không có bill nào chưa thanh toán cả!!!
        }

        public void ThemBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec dbo.THEMBILL @idtable", new object[] { id });
        }

        public int LayBillLonNhat()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM DBO.BILLDRINKS");
            }
            catch
            {
                return 1;
            }
        }

        public DataTable THONGKEHOADON(DateTime timecheckin, DateTime timecheckout)
        {
            return DataProvider.Instance.ExecuteQuery("exec THONGKEHOADON @timecheckin , @timecheckout", new object[] { timecheckin, timecheckout});
        }

        public DateTime LAYGIOVAO(int idtable)
        {
            try
            {
                return (DateTime)DataProvider.Instance.ExecuteScalar("select timecheckin from BILLDRINKS where billstatus = 0 and idtable = " + idtable);
            }
            catch
            {
                return DateTime.MinValue;
            }
            
         }


        public void PRINTBEFORECHECKOUT(int id, int giamgia, float TongTien)
        {
            string query = "UPDATE dbo.BILLDRINKS SET billstatus = 0, timecheckout = getdate(), " + " giamgia =" + giamgia + " ,TongTien=" + TongTien + " where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);

        }

        public void CHECKOUT(int id, int giamgia, float TongTien)
        {
            string query = "UPDATE dbo.BILLDRINKS SET billstatus = 1, timecheckout = getdate(), " + " giamgia ="+ giamgia + " ,TongTien=" + TongTien + " where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);

        }
    }
}
