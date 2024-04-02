using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DTO
{
    public class BillInfo
    {

        public BillInfo(int id, int Mabill, int Mamon, int amount)
        {
            this.ID = id;
            this.MaBill = Mabill;
            this.MaMon = Mamon;
            this.Amount = amount;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.MaBill = (int)row["MaBill"];
            this.MaMon = (int)row["Mamon"];
            this.Amount = (int)row["Amount"];
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int Mamon;
        public int MaMon
        {
            get { return Mamon; }
            set { Mamon = value; }
        }
        private int Mabill;
        public int MaBill
        {
            get { return Mabill; }
            set { Mabill = value; }
        }
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
