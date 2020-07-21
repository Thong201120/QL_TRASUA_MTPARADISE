using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Transfer_Obj
{
    public class TaiKhoan
    {
        public TaiKhoan(string displayName, string username, int typeuser, string cmnd, string sodienthoai, string diachi, string userpassword = null)
        {
            this.Userpassword = userpassword;
            this.DisplayName = displayName;
            this.Username = username;
            this.Typeuser = typeuser;
            this.Diachi = diachi;
            this.Cmnd = cmnd;
            this.Sodienthoai = sodienthoai;
        }
        public TaiKhoan(DataRow row)
        {
            this.Userpassword = row["userpassword"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Username = row["username"].ToString();
            this.Typeuser = (int)row["typeuser"];
            this.Cmnd = row["cmnd"].ToString();
            this.Sodienthoai = row["sodienthoai"].ToString();
            this.Diachi = row["diachi"].ToString();
        }

        private string userpassword;
        public string Userpassword { get => userpassword; set => userpassword = value; }
        
        private string displayName;
        public string DisplayName { get => displayName; set => displayName = value; }
        
        private string username;
        public string Username { get => username; set => username = value; }
        
        private int typeuser;
        public int Typeuser { get => typeuser; set => typeuser = value; }
        
        private string cmnd;
        public string Cmnd { get => cmnd; set => cmnd = value; }

        private string sodienthoai;
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }

        private string diachi;        
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
