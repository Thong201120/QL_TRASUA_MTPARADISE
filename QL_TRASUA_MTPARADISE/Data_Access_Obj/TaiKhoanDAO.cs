using DevExpress.XtraPrinting.Native;
using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Access_Obj
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        public bool Dangnhap(string username, string userpassword)
        {
            string query = "dbo.DANGNHAP @username , @userpassword";
            DataTable thongtin = DataProvider.Instance.ExecuteQuery(query, new object[] { username, userpassword });

            return thongtin.Rows.Count > 0;
        }

        public TaiKhoan LayTaiKhoangBangUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT WHERE username = '" + username +"'");

            foreach(DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }
            return null;
        }

        public bool CheckCapNhatTaiKhoan(string username, string displayName, string userpassword, string passwordmoi, string cmnd, string sodienthoai, string diachi)
        {
            int dem = DataProvider.Instance.ExecuteNonQuery("exec CAPNHATTAIKHOAN @username , @displayName , @userpassword , @passwordmoi , @cmnd , @sodienthoai , @diachi ", new object[] { username, displayName, userpassword, passwordmoi, cmnd, sodienthoai, diachi });
            return dem > 0;
        }

        public DataTable LayDanhSachTaiKhoan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT username, displayName, cmnd, sodienthoai, diachi, typeuser FROM ACCOUNT");
        }

        public bool ThemTKfrTaiKhoan(string username, string displayName, int type, string cmnd, string sodienthoai, string diachi)
        {
            string query = string.Format("INSERT dbo.ACCOUNT ( username, displayName, typeuser, cmnd, sodienthoai, diachi)VALUES ( N'{0}', N'{1}', {2}, N'{3}', N'{4}', N'{5}')", username, displayName, type, cmnd, sodienthoai, diachi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool CapNhatfrTaiKhoan(string username, string displayName, int type, string cmnd, string sodienthoai, string diachi)
        {
            string query = string.Format("UPDATE DBO.ACCOUNT SET displayName = N'{0}' , typeuser = {1} , cmnd = N'{2}' , sodienthoai = N'{3}' , diachi = N'{4}'  WHERE username = N'{5}'", displayName, type, cmnd, sodienthoai, diachi, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoafrTaiKhoan(string username)
        {
            string query = string.Format("DELETE DBO.ACCOUNT WHERE username = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DatLaiMatKhau(string username)
        {
            string query = string.Format("UPDATE DBO.ACCOUNT SET userpassword = N'0' WHERE username = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }


}
