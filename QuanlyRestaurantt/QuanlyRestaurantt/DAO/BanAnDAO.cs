using QuanlyRestaurantt.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DAO
{
    public  class BanAnDAO
    {
       private static BanAnDAO? instance;
        public static BanAnDAO Instance {
            get { if (instance == null) instance = new BanAnDAO(); return BanAnDAO.instance;}
           private set { BanAnDAO.instance = value; }      
        
        }

        public static int TableWidth = 120;
        public static int TableHeight = 120;

        private BanAnDAO() { }
       
        public List<Banan> LoadTableList()
        {
            List<Banan> tablelist=new List<Banan>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Banan");
            foreach (DataRow row in data.Rows) {
                Banan banan = new Banan(row);
                tablelist.Add(banan);
            }
            return tablelist;
        }

        }
}
