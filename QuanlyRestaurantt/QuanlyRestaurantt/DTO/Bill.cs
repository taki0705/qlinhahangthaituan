using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DTO
{
    public class Bill
    {
        public Bill(int Mabill,int Maban, DateTime Checkin, DateTime Checkout, int status)
        {
            this.MaBill = Mabill;
            this.MaBan = Maban;
            this.CheckIn = Checkin;
            this.CheckOut = Checkout;
            this.Status = status;

        }

        public Bill(DataRow row)
        {
            this.MaBill = (int)row["MaBill"];
            this.MaBan = (int)row["Maban"];
            this.CheckIn = (DateTime?)row["CheckIn"];
            var CheckOutTemp = row["CheckOut"];
            if (CheckOutTemp.ToString() != "")
                this.CheckOut = (DateTime?)CheckOutTemp;
            this.Status = (int)row["status"];


        }
        private int Mabill;
        public int MaBill
        {
            get { return Mabill; }
            set { Mabill = value; }
        }
        private int Maban;
        public int MaBan
        {
            get { return Maban; }
            set { Maban = value; }
        }
        private DateTime? Checkin;
        public DateTime? CheckIn
        {
            get { return Checkin; }
            set { Checkin = value; }
        }
        private DateTime? Checkout;
        public DateTime? CheckOut
        {
            get { return Checkout; }
            set { Checkout = value; }
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }


       
    }
}
