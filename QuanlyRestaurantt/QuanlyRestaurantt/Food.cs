using QuanlyRestaurantt.DAO;
using QuanlyRestaurantt.DTO;
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
    public partial class frFood : Form
    {
        public frFood()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        Ketnoi kn = new Ketnoi();
        void getdata()
        {
            String query = "Select * from Monan";
            DataSet ds = kn.Laydulieu(query);
            foodList.DataSource = ds.Tables[0];

        }
        void getdata2()
        {
            String query = "Select * from CategoryMonan";
            DataSet ds = kn.Laydulieu(query);
            dgvdanmuc.DataSource = ds.Tables[0];

        }
        private void frFood_Load(object sender, EventArgs e)
        {
            getdata();
            getdata2();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into Monan values(N'{0}',N'{1}','{2}','{3}' )",
               txtmamon.Text, txtdm.Text, txttenmon.Text, txtgia.Text);
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
            string query = string.Format("Update Monan set CategoryID=N'{1}',Tenmon='{2}',Gia=N'{3}' where Mamon='{0}' ",
              txtmamon.Text, txtdm.Text, txttenmon.Text, txtgia.Text);
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
            string query = string.Format(" delete  from Monan where Mamon='{0}'", txtmamon.Text);
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM Monan WHERE  CategoryID=N'{0}'", txttimkiem.Text);
            DataSet ds = kn.Laydulieu(query);
            foodList.DataSource = ds.Tables[0];
        }

        private void foodList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = foodList.CurrentRow.Index;
            txtmamon.Text = foodList.Rows[i].Cells[0].Value.ToString();
            txtdm.Text = foodList.Rows[i].Cells[1].Value.ToString();
            txttenmon.Text = foodList.Rows[i].Cells[2].Value.ToString();
            txtgia.Text = foodList.Rows[i].Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
