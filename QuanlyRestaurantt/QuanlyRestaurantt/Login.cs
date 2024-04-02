using System.Data;

namespace QuanlyRestaurantt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Ketnoi kn = new Ketnoi();
        private void danhnhap_Click(object sender, EventArgs e)
        {
            Hethong frmhethong = new Hethong();
            String query = String.Format("select * from nguoidung where Taikhoan=N'{0}' and Matkhau=N'{1}' ", txttaikhoan.Text, txtmatkhau.Text);
            DataSet ds = new DataSet();
            ds = kn.Laydulieu(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show(" Dang nhap thanh cong");
                this.Hide();
                frmhethong.ShowDialog();

            }
            else
            {
                MessageBox.Show(" Sai mật khẩu hoặc tài khoản Vui lòng nhập lại");
            }
        }
    }
}