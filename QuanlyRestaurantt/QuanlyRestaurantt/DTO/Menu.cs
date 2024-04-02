using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DTO
{
    public class Menu
    {
        public Menu(string Tenmon, int amount, float gia, float totalPrice = 0)
        {
            this.TenMon = Tenmon;
            this.Amount = amount;
            this.Gia = gia;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.TenMon = row["Tenmon"].ToString();
            this.Amount = (int)row["amount"];
            this.Gia = (float)Convert.ToDouble(row["Gia"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
        }

        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private float gia;

        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string Tenmon;

        public string TenMon
        {
            get { return Tenmon; }
            set { Tenmon = value; }
        }
    }
}
