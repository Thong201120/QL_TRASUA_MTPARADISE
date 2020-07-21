using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Transfer_Obj
{
    public class THUCUONG
    {
        public THUCUONG(int id, string drinkname, int iddrinklist, float price)
        {
            this.Id = id;
            this.Drinkname = drinkname;
            this.Iddrinklist = iddrinklist;
            this.Price = price;
        }

        public THUCUONG(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Drinkname = row["drinkname"].ToString();
            this.Iddrinklist = (int)row["iddrinklist"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private string drinkname;
        public string Drinkname { get => drinkname; set => drinkname = value; }

        private int id;
        public int Id { get => id; set => id = value; }

        private int iddrinklist;
        public int Iddrinklist { get => iddrinklist; set => iddrinklist = value; }

        private float price;
        public float Price { get => price; set => price = value; }


    }
}
