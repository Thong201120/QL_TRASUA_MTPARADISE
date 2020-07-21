using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Access_Obj
{
    public class KHODAO
    {
        private static KHODAO instance;

        public static KHODAO Instance
        {
            get { if (instance == null) instance = new KHODAO(); return KHODAO.instance; }
            private set { KHODAO.instance = value; }
        }
        private KHODAO() {}

        public List<KHO> loadSTOCKlist()
        {
            List<KHO> stocklist = new List<KHO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM DBO.STOCK");

            foreach (DataRow item in data.Rows)
            {
                KHO kho = new KHO(item);
                stocklist.Add(kho);
            }
            return stocklist;
        }

        public bool ThemNLfrmKHO(string stuffname, int stuffamount, int stuffprice)
        {
            string query = string.Format("INSERT DBO.STOCK (stuffname, stuffamount, stuffprice) VALUES (N'{0}', {1}, {2})", stuffname, stuffamount, stuffprice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool CapNhatNLfrmKHO(int id, string stuffname, int stuffamount, int stuffprice)
        {
            string query = string.Format("UPDATE DBO.STOCK SET stuffname = N'{0}', stuffamount = {1}, stuffprice = {2} WHERE id = {3}", stuffname, stuffamount, stuffprice, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool XoaNLfrmKHO(string stuffname)
        {
            string query = string.Format("DELETE DBO.STOCK WHERE stuffname = N'{0}'", stuffname);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
