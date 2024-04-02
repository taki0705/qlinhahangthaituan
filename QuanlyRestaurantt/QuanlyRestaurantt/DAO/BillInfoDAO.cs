using QuanlyRestaurantt.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }


        public List<BillInfo> GetListBillInfo(int Mabill)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE MaBill = "+ Mabill);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
        public void InsertBillInfo(int Mabill, int Mamon, int amount)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @MaBill , @Mamon , @Amount", new object[] { Mabill, Mamon,  amount });
        }
    }



    }

