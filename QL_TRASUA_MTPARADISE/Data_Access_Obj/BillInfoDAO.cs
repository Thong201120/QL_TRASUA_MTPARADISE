using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Access_Obj
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public List<BILLINFO> GetListBillInfo(int id)
        {
            List<BILLINFO> listBillInfo = new List<BILLINFO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BILLINFO WHERE iddrink = "+ id);
            foreach (DataRow item in data.Rows)
            {
                BILLINFO info = new BILLINFO(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        public void THEMTHONGTINBILL(int idbill, int iddrink, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.THEMTHONGTINBILL @idbill , @iddrink , @count", new object[] { idbill, iddrink, count });
        }

        public void XoaBillInfo(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BILLINFO WHERE iddrink = " + id);
        }

    }
}
