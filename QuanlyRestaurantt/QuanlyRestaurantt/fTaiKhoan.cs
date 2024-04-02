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
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        Ketnoi kn = new Ketnoi();
        void getdata()
        {
            String query = "Select * from nguoidung";
            DataSet ds = kn.Laydulieu(query);
            dtgtaikhoan.DataSource = ds.Tables[0];

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into nguoidung values('{0}','{1}','{2}')",
             txtid.Text, txttk.Text, txtmk.Text);
            bool kt = kn.Thucthi(query);
            if (kt == true)
            {
                MessageBox.Show(" them thanh cong");
                getdata();
            }
            else
            {
                MessageBox.Show(" them that bai");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = string.Format("Update nguoidung set Taikhoan='{1}', Matkhau='{2}' where id='{0}'",
            txtid.Text, txttk.Text, txtmk.Text);
            bool kt = kn.Thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("sua thanh cong");
                getdata();
            }
            else
            {
                MessageBox.Show(" sua that bai");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(" delete  nguoidung  where id='{0}'", txtid.Text);
            bool kt = kn.Thucthi(query);
            if (kt == true)
            {
                MessageBox.Show(" xoa thanh cong");
                getdata();
            }
            else
            {
                MessageBox.Show(" xoa that bai");
            }
        }

        private void dtgtaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgtaikhoan.CurrentRow.Index;
            txtid.Text = dtgtaikhoan.Rows[i].Cells[0].Value.ToString();
            txttk.Text = dtgtaikhoan.Rows[i].Cells[1].Value.ToString();
            txtmk.Text = dtgtaikhoan.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
