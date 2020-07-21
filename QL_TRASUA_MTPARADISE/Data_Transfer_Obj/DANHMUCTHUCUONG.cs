using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Transfer_Obj
{
    public class DANHMUCTHUCUONG
    {
        public DANHMUCTHUCUONG(int id, string drinklistname)
        {
            this.Id = id;
            this.Drinklistname = drinklistname;
        }

        public DANHMUCTHUCUONG(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Drinklistname = row["drinklistname"].ToString();
        }

        private string drinklistname;
        public string Drinklistname { get => drinklistname; set => drinklistname = value; }

        private int id;
        public int Id { get => id; set => id = value; }
    }
}