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
        private static TableDAO instance; //Đóng gói tableDAO
        public static TableDAO Instance 
        { 
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }    
        }

        //Hàm dựng tránh sự xâm nhập từ bên ngoài
        private TableDAO() {}

        //Chuyển bàn này sang bàn khác 
        public void HOANVIBAN(int temp1, int temp2)
        {
            DataProvider.Instance.ExecuteQuery("LAYBANG_ID @IDBANGOC , @IDBANDITHEO ", new object[] { temp1, temp2 });
        }

        public void GOPBAN(int temp1, int temp2)
        {
            DataProvider.Instance.ExecuteQuery("GOPBAN @FIRSTBILL , @SECONDBILL", new object[] { temp1, temp2 });
        }

        //Lấy thông tin danh sách bàn
        public List<Table> loadTableList()
        {
            List<Table> tablelist = new List<Table>(); //Khai báo list datatable
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.GetTableList");
           
            //Với mỗi dòng data lấy được sẽ thêm vào trong list tablelist
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }

        //Lấy thông tin danh sách bàn, tương tự như trên nhưng dùng câu select bình thường
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

        //Dành cho form quản lí bàn uống
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

