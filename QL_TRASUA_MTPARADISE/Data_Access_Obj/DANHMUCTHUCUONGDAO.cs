using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TRASUA_MTPARADISE.Data_Access_Obj
{
    public class DANHMUCTHUCUONGDAO
    {
        private static DANHMUCTHUCUONGDAO instance;

        public static DANHMUCTHUCUONGDAO Instance
        {
            get { if (instance == null) instance = new DANHMUCTHUCUONGDAO(); return DANHMUCTHUCUONGDAO.instance; }
            private set { DANHMUCTHUCUONGDAO.instance = value; }
        }

        private DANHMUCTHUCUONGDAO() { }

        public List<DANHMUCTHUCUONG> LayCBDanhMucThucUong()
        {
            List<DANHMUCTHUCUONG> listdm = new List<DANHMUCTHUCUONG>();

            string query = "select * from DRINKLIST";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                DANHMUCTHUCUONG danhmuc = new DANHMUCTHUCUONG(item);
                listdm.Add(danhmuc);
            }
            return listdm;
        }

        public DANHMUCTHUCUONG LAYTENDANHMUCBANGID(int id)
        {
            DANHMUCTHUCUONG dmtu = null;
            
            string query = "select * from DRINKLIST WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                dmtu = new DANHMUCTHUCUONG(item);
                return dmtu;
            }
            return dmtu;
        }

        public bool ThemDMfrmDanhMuc(string drinklistname)
        {
            string query = string.Format("INSERT DBO.DRINKLIST (drinklistname) VALUES (N'{0}')", drinklistname);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool CapNhatDMfrmDanhMuc(int id, string drinklistname)
        {
            string query = string.Format("UPDATE DBO.DRINKLIST SET drinklistname = N'{0}' WHERE id = {1}", drinklistname, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaDMfrmDanhMuc(int id)
        {
            string query = string.Format("DELETE DBO.DRINKLIST WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
