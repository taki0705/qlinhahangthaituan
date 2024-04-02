using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DTO
{
    public class Banan
    {
        public Banan(int Maban,string Tenban,string Trangthai)
        {
            this.MaBan = Maban;
            this.TenBan = Tenban;
            this.TrangThai = Trangthai;
        }
        public Banan(DataRow row) {
            this.MaBan = (int)row["Maban"];
            this.TenBan = row["Tenban"].ToString();
            this.TrangThai = row["Trangthai"].ToString();
        }

        private int Maban;
        public int MaBan
        {
            get { return Maban; }
            set { Maban = value; }
        }
        private string Tenban;
        public string TenBan
        {
            get { return Tenban; }
            set { Tenban = value; }
        }
        private string Trangthai;
        public string TrangThai
        {
            get { return Trangthai; }
            set { Trangthai = value; }
        }

     
    }
}
