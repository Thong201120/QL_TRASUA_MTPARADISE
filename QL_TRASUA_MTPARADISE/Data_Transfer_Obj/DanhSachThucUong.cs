using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Transfer_Obj
{
    public class DanhSachThucUong
    {
        public DanhSachThucUong(string drinkname, int count, float price, float tongtien = 0)
        {
            this.Drinkname = drinkname;
            this.Count = count;
            this.Price = price;
            this.Tongtien = tongtien;
        }

        public DanhSachThucUong(DataRow row)
        {
            this.Drinkname = row["drinkname"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Tongtien = (float)Convert.ToDouble(row["tongtien"].ToString());
        }

        private float tongtien;
        public float Tongtien { get => tongtien; set => tongtien = value; }
        
        private string drinkname;
        public string Drinkname { get => drinkname; set => drinkname = value; }
        
        private int count;
        public int Count { get => count; set => count = value; }
        
        private float price;
        public float Price { get => price; set => price = value; }
        
    }
}
