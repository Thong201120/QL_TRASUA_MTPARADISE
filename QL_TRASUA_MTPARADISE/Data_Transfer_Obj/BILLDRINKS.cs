using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TRASUA_MTPARADISE.Data_Transfer_Obj
{
    public class BILLDRINKS
    {
        //Dấu chấm hỏi cho phép lữu trữ với giá trị NULL
        public BILLDRINKS(int id, DateTime? timecheckin, DateTime? timecheckout, int billstatus, int idtable, int giamgia = 0)
        {
            this.Idtable = idtable;
            this.Id = id;
            this.Timecheckin = timecheckin;
            this.Timecheckout = timecheckout;
            this.Billstatus = billstatus;
            this.Giamgia = giamgia;
        }

        public BILLDRINKS(DataRow row)
        {
            this.Idtable = (int)row["idtable"];
            this.Id = (int)row["id"];
            this.Timecheckin = (DateTime?)row["timecheckin"];
            var timeCheckOutTemp = row["timecheckin"];
            if (timeCheckOutTemp.ToString() != "")
                this.Timecheckout = (DateTime?)timeCheckOutTemp;
            //this.Timecheckout = (DateTime?)row["timecheckout"];
            this.Billstatus = (int)row["billstatus"];

            if (row["giamgia"].ToString() !="")
                this.Giamgia = (int)row["giamgia"];
        }

        private int giamgia;
        public int Giamgia { get => giamgia; set => giamgia = value; }

        private int billstatus;
        public int Billstatus
        {
            get { return billstatus; }
            set { billstatus = value; }
        }

        private DateTime? timecheckin; //Có thể null
        public DateTime? Timecheckin
        {
            get { return timecheckin; }
            set { timecheckin = value; }
        }

        private DateTime? timecheckout; //Có thể null
        public DateTime? Timecheckout
        {
            get { return timecheckout; }
            set { timecheckout = value; }

        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idtable;
        public int Idtable { get => idtable; set => idtable = value; }

    }
}
