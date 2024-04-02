using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyRestaurantt
{
    internal class Ketnoi
    {
        private string Constr = @"Data Source=LAPTOP-Q7SEQCPU\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=SSPI";
        private SqlConnection conn;

        public Ketnoi()
        {
            conn = new SqlConnection(Constr);
        }
        public DataSet Laydulieu(string truyvan)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
            da.Fill(ds);
            return ds;
        }
        public bool Thucthi(string truyvan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r > 0;
        }
    }
}
