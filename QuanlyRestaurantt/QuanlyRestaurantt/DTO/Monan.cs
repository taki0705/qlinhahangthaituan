using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DTO
{
    public class Monan
    {
        public Monan(int Mamon,int Categoryid, String Tenmon,float gia)
        {
            this.MaMon = Mamon;
            this.TenMon = Tenmon;
            this.CategoryID = Categoryid;
            this.Gia = gia;
        }

        public Monan(DataRow row)
        {
            this.MaMon = (int)row["Mamon"];
            this.CategoryID = (int)row["CategoryID"];
            this.TenMon = row["Tenmon"].ToString();
            this.Gia = (float)Convert.ToDouble(row["Gia"].ToString());

        }
        private int Mamon;
        public int MaMon
        {
            get { return Mamon; }
            set { Mamon = value; }
        }
        private int Categoryid;
        public int CategoryID
        {
            get { return Categoryid; }
            set { Categoryid = value; }
        }
        private String Tenmon;
        public String TenMon
        {
            get { return Tenmon; }
            set { Tenmon = value; }
        }
        private float gia;
        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }



    }
}
