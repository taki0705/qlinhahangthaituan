using QuanlyRestaurantt.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt.DAO
{
    public class BillDAO
    {
        private static BillDAO? instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }
        public int GetUnCheckBillIDByTableID(int Mabill)
        {
          DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE Maban=" + Mabill+ "AND status=0");  

            if (data.Rows.Count > 0)    
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.MaBill;
            }
            return -1;
        }
        public void InsertBill(int Maban)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @Maban", new object[] { Maban });
        }
        public int GetMaxIDBill()
        {
            try
            {
                 return (int)DataProvider.Instance.ExecuteScalar("Select MAX(MaBill) From dbo.Bill");
            }
            catch
                {
                return 1;
            }
        }
        public DataTable GetListBillByDate(DateTime Checkin,DateTime Checkout)
        {
           return  DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @CheckIn , @CheckOut ", new object[] { Checkin, Checkout });
        }
        public void Checkout(int id,float totalPrice)
        {
            String query = "UPDATE dbo.Bill SET CheckOut=GETDATE(),status=1,"+"totalPrice="+ totalPrice + "where MaBill=" + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }


    }
}
