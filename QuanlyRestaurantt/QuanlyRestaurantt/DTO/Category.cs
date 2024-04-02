using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DTO
{
    public class Category
    {
        public Category(int id,  String Tenmon)
        {
            this.ID=id;
            this.TenMon=Tenmon; 
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenMon = row["Tenmon"].ToString();
    
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private String Tenmon;
        public String TenMon
        {
            get { return Tenmon; }
            set { Tenmon = value; }
        }
   



    }
}
