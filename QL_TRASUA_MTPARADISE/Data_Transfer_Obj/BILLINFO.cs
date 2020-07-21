using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Transfer_Obj
{
    public class BILLINFO
    {
        public BILLINFO(int id, int idbill, int iddrink, int count)
        {
            this.Id = id;
            this.Count = count;
            this.Iddrink = iddrink;
            this.Idbill = idbill;
        }

        public BILLINFO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Count = (int)row["count"];
            this.Iddrink = (int)row["iddrink"];
            this.Idbill = (int)row["idbill"];
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int iddrink;
        public int Iddrink
        {
            get { return iddrink; }
            set { iddrink = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        private int idbill;
        public int Idbill
        {
            get { return idbill; }
            set { idbill = value; }
        }
        
    }
}
