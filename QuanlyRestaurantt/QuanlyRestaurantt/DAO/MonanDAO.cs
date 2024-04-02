using QuanlyRestaurantt.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DAO
{
  
      public class MonanDAO
    {
        private static MonanDAO? instance;

        public static MonanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MonanDAO();
                return MonanDAO.instance;
            }
            private set { MonanDAO.instance = value; }
        }

        private MonanDAO() { }
        public List<DTO.Monan> GetListMonan(int id)
        {
            List<DTO.Monan> list = new List<DTO.Monan>();
            String query = "Select * from Monan where CategoryID="+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO.Monan monan = new DTO.Monan(item);
                list.Add(monan);
            }
            return list;
        }
        public List<Monan> GetListFood()
        {
            List< Monan >list = new List<Monan>();

            string query = "select * from Monan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Monan food = new Monan(item);
                list.Add(food);
            }

            return list;
        }
        public bool InsertFood(string Tenmon, int CategoryID, float Gia)
        {
            string query = string.Format("INSERT dbo.Food ( Tenmon, CategoryID, Gia )VALUES  ( N'{0}', {1}, {2})", Tenmon, CategoryID ,Gia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
