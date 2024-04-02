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
    public partial class fBanan : Form
    {
        public fBanan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void fBanan_Load(object sender, EventArgs e)
        {
            getdata();
        }

        Ketnoi kn = new Ketnoi();
        void getdata()
        {
            String query = "Select * from Banan";
            DataSet ds = kn.Laydulieu(query);
            dgvBanan.DataSource = ds.Tables[0];

        }
        private void Banan_Load(object sender, EventArgs e)
        {
            getdata();
        }
        private void them_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into Banan values(N'{0}',N'{1}',N'{2}')",
              txtmaban.Text, txttenban.Text, txttrangthai.Text);
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

        private void sua_Click(object sender, EventArgs e)
        {
            string query = string.Format("Update Banan set Tenban=N'{1}',Trangthai=N'{2}' where Maban=N'{0}' ",
           txtmaban.Text, txttenban.Text, txttrangthai.Text);
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

        private void xoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(" delete  from Banan where Maban='{0}'", txtmaban.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fBanan_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvBanan_Click(object sender, EventArgs e)
        {

        }

        private void dgvBanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvBanan.CurrentRow.Index;
            txtmaban.Text = dgvBanan.Rows[i].Cells[0].Value.ToString();
            txttenban.Text = dgvBanan.Rows[i].Cells[1].Value.ToString();
            txttrangthai.Text = dgvBanan.Rows[i].Cells[2].Value.ToString();
        }
    }
}
