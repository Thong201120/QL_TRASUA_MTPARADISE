using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Access_Obj
{
    class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        { 
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }    
        }
        public static int TableWidth = 150;
        public static int TableHeight = 150;

        private TableDAO() {}

        public void HOANVIBAN(int temp1, int temp2)
        {
            DataProvider.Instance.ExecuteQuery("LAYBANG_ID @IDBANGOC , @IDBANDITHEO ", new object[] { temp1, temp2 });
        }

        public List<Table> loadTableList()
        {
            List<Table> tablelist = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.GetTableList");
           
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }

        public List<Table> loadDANHSACHBANUONG()
        {
            List<Table> DSBAN = new List<Table>();
            string query = "SELECT * FROM DBO.DRINKTABLE";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                DSBAN.Add(table);
            }
            return DSBAN;
        }

        public bool ThemBanfrmBANUONG(string tablename)
        {
            string query = string.Format("INSERT DBO.DRINKTABLE (tablename) VALUES (N'{0}')", tablename);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool CapNhatfrmBanuong(string tablename, int id)
        {
            string query = string.Format("UPDATE DBO.DRINKTABLE SET tablename = N'{0}' WHERE id = {1}", tablename, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoafrmBanuong(string tablename)
        {
            string query = string.Format("DELETE DBO.DRINKTABLE WHERE tablename = N'{0}'", tablename);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
