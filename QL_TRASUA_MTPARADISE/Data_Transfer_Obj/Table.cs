using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Transfer_Obj
{
    public class Table
    {
        public Table(int id, string tablename, string tablestatus)
        {
            this.Id = id;
            this.Tablename = tablename;
            this.Tablestatus = tablestatus;
        }
        public Table(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tablename = row["tablename"].ToString();
            this.Tablestatus = row["tablestatus"].ToString();
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string tablename;
        public string Tablename
        {
            get { return tablename; }
            set { tablename = value; }
        }

        private string tablestatus;
        public string Tablestatus 
        {
            get { return tablestatus; }
            set { tablestatus = value; }
        }

    }
}
