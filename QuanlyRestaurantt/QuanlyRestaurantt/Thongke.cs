using QuanlyRestaurantt.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyRestaurantt
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        void LoadListBillByDate(DateTime CheckIn, DateTime CheckOut)
        {
            dgvBill.DataSource = BillDAO.Instance.GetListBillByDate(CheckIn, CheckOut);
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpcheckin.Value, dtpcheckout.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();        
        }
    }
}
