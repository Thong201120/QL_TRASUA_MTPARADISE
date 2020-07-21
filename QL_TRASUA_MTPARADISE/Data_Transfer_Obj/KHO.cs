using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Transfer_Obj
{
    public class KHO
    {   public KHO(int id, string stuffname, int stuffamount, int stuffprice)
        {
            this.Id = id;
            this.Stuffname = stuffname;
            this.Stuffamount = stuffamount;
            this.Stuffprice = stuffamount;
        }
        public KHO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Stuffname = row["stuffname"].ToString();
            this.Stuffamount = (int)row["stuffamount"];
            this.Stuffprice = (int)row["stuffprice"];
        }

        private int id;
        public int Id { get => id; set => id = value; }
        private string stuffname;
        public string Stuffname { get => stuffname; set => stuffname = value; }
        private int stuffamount;
        public int Stuffamount { get => stuffamount; set => stuffamount = value; }
        private int stuffprice;
        public int Stuffprice { get => stuffprice; set => stuffprice = value; }
    }
}
