using QL_TRASUA_MTPARADISE.Data_Transfer_Obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Access_Obj
{
    public class DanhSachThucUongDAO
    {
        private static DanhSachThucUongDAO instance;

        public static DanhSachThucUongDAO Instance
        {
            get { if (instance == null) instance = new DanhSachThucUongDAO(); return DanhSachThucUongDAO.instance; }
            private set { DanhSachThucUongDAO.instance = value; }
        }

        private DanhSachThucUongDAO() { }

        public List<DanhSachThucUong> GetDanhSachThucUong(int id)
        {
            List<DanhSachThucUong> listdanhsach = new List<DanhSachThucUong>();
            string query = "SELECT dbo.DRINK.drinkname, dbo.BILLINFO.count , dbo.DRINK.price, dbo.DRINK.price*dbo.BILLINFO.count as tongtien FROM dbo.BILLINFO, dbo.BILLDRINKS, dbo.DRINK WHERE dbo.BILLINFO.idbill = dbo.BILLDRINKS.id AND dbo.BILLINFO.iddrink = dbo.DRINK.id AND dbo.BILLDRINKS.billstatus = 0 AND dbo.BILLDRINKS.idtable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DanhSachThucUong danhsach = new DanhSachThucUong(item);
                listdanhsach.Add(danhsach);
            }

            return listdanhsach;
        }
    }
}
