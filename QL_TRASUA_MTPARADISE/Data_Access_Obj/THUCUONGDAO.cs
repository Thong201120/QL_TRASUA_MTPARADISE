using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Access_Obj
{
   public  class THUCUONGDAO
    {
        private static THUCUONGDAO instance;

        public static THUCUONGDAO Instance
        {
            get { if (instance == null) instance = new THUCUONGDAO(); return instance; }
            private set { THUCUONGDAO.instance = value; }
        }

        private THUCUONGDAO() { }

        public List<THUCUONG> LayCBDanhSachThucUong(int id)
        {
            List<THUCUONG> danhsachthucuong = new List<THUCUONG>();
            string query = "select * from DRINK where iddrinklist = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                THUCUONG dsthucuong = new THUCUONG(item);
                danhsachthucuong.Add(dsthucuong);
            }
            return danhsachthucuong;
        }

        public List<THUCUONG> THONGKETHUCUONG()
        {
            List<THUCUONG> danhsachthucuong = new List<THUCUONG>();
            string query = "SELECT * FROM DBO.DRINK ";
        DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                THUCUONG dsthucuong = new THUCUONG(item);
                danhsachthucuong.Add(dsthucuong);
            }
            return danhsachthucuong;
        }

        public List<THUCUONG> TimKiemThucUong(string drinkname)
        {
            List<THUCUONG> danhsachthucuong = new List<THUCUONG>();
            string query = string.Format("SELECT * FROM DBO.DRINK WHERE drinkname LIKE N'%{0}%'", drinkname);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                THUCUONG drink = new THUCUONG(item);
                danhsachthucuong.Add(drink);
            }

            return danhsachthucuong;
        } 

        public bool ThemMonfrTHUCUONG(string drinkname, int iddrinklist, float price)
        {
            string query = string.Format("INSERT DBO.DRINK (drinkname, iddrinklist, price) VALUES (N'{0}', {1}, {2})", drinkname, iddrinklist, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool CapNhatfrTHUCUONG(int id, string drinkname, int iddrinklist, float price)
        {
            string query = string.Format("UPDATE DBO.DRINK SET drinkname = N'{0}' , iddrinklist = {1} , price = {2} WHERE id = {3}", drinkname, iddrinklist, price, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoafrTHUCUONG(int id)
        {
            BillInfoDAO.Instance.XoaBillInfo(id);
            string query = string.Format("DELETE DBO.DRINK WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


    }
}
