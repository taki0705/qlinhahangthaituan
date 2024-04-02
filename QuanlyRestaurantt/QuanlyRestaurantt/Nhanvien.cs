using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyRestaurantt
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Ketnoi kn = new Ketnoi();
        void getdata()
        {
            String query = "Select * from Nhanvien";
            DataSet ds = kn.Laydulieu(query);
            dtg.DataSource = ds.Tables[0];

        }

        private void dtg_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtg.CurrentRow.Index;
            txtmanv.Text = dtg.Rows[i].Cells[0].Value.ToString();
            txttennv.Text = dtg.Rows[i].Cells[1].Value.ToString();
            txtngaysinh.Text = dtg.Rows[i].Cells[2].Value.ToString();
            txtgioitinh.Text = dtg.Rows[i].Cells[3].Value.ToString();
            txtdiachi.Text = dtg.Rows[i].Cells[4].Value.ToString();
            txtsdt.Text = dtg.Rows[i].Cells[5].Value.ToString();
            txtnvl.Text = dtg.Rows[i].Cells[6].Value.ToString();
            txtluong.Text = dtg.Rows[i].Cells[7].Value.ToString();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            getdata();

        }

        private void them_Click(object sender, EventArgs e)
        {

            string query = string.Format("insert into Nhanvien values(N'{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}',N'{6}','{7}' )",
               txtmanv.Text, txttennv.Text, txtngaysinh.Text, txtgioitinh.Text, txtdiachi.Text, txtsdt.Text, txtnvl.Text, txtluong.Text);
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

        private void xoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(" delete  from NhanVien where Mav='{0}'", txtmanv.Text);
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

        private void sua_Click(object sender, EventArgs e)
        {
            string query = string.Format("Update Nhanvien set Tennv=N'{1}',Ngaysinh='{2}',Gioitinh=N'{3}',Diachi=N'{4}',Dienthoai=N'{5}',NgayVaolam='{6}',Luong=N'{7}' where Mav=N'{0}' ",
               txtmanv.Text, txttennv.Text, txtngaysinh.Text, txtgioitinh.Text, txtdiachi.Text, txtsdt.Text, txtnvl.Text, txtluong.Text);
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

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {
        }

        private void txttennv_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtgioitinh_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtluong_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtngaysinh_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtnvl_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM Nhanvien WHERE Tennv LIKE '%{0}%'", txttimkiem.Text);
            DataSet ds = kn.Laydulieu(query);
            dtg.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void Nhanvien_Click(object sender, EventArgs e)
        {

        }
    }
}
