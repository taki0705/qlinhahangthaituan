using QuanlyRestaurantt.DAO;
using QuanlyRestaurantt.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanlyRestaurantt
{
    public partial class Hethong : Form
    {
        public Hethong()
        {
            InitializeComponent();
            LoadBanan();
            LoadCategory();
        }
        void LoadBanan()
        {
            flpTable.Controls.Clear();
            List<Banan> tablelist = BanAnDAO.Instance.LoadTableList();
            foreach (Banan item in tablelist)
            {
                Button btn = new Button() { Width = BanAnDAO.TableWidth, Height = BanAnDAO.TableHeight };
                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.AntiqueWhite;
                        break;
                    default:
                        btn.BackColor = Color.BlueViolet;
                        break;
                }
                flpTable.Controls.Add(btn);

            }
        }        void LoadCategory()       {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            CbCate.DataSource = listCategory;
            CbCate.DisplayMember = "Tenmon";
        }
        void LoadFoodListByCategoyID(int id)
        {
            List<DTO.Monan> listMonan = MonanDAO.Instance.GetListMonan(id);
            cbFood.DataSource = listMonan;
            cbFood.DisplayMember = "Tenmon";
        }
        private void cbCategory(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            Category selected = cb.SelectedItem as Category;
            if (cb.SelectedItem == null)
                return;

            id = selected.ID;

            LoadFoodListByCategoyID(id);
        }
        private void Btn_Click(object? sender, EventArgs e)
        {

            int Maban = ((sender as Button).Tag as Banan).MaBan;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(Maban);
        }



        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien frmnhanvien = new Nhanvien();
            frmnhanvien.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frFood frfood = new frFood();
            frfood.ShowDialog();
        }

        private void Hethong_Load(object sender, EventArgs e)
        {

        }



        void ShowBill(int id)
        {

            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float TotalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenMon.ToString());
                lsvItem.SubItems.Add(item.Amount.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                TotalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            //  CultureInfo culture = new CultureInfo("vi-vn");
            // txbTotalPrice.Text = TotalPrice.ToString("c", culture);
            txbTotalPrice.Text = TotalPrice.ToString("");
            LoadBanan();
        }
        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Banan banan = lsvBill.Tag as Banan;
            if (banan == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }
            int MaBill = BillDAO.Instance.GetUnCheckBillIDByTableID(banan.MaBan);
            int Mamon = (cbFood.SelectedItem as DTO.Monan).MaMon;
            int amount = (int)nmFoodCount.Value;

            if (MaBill == -1)
            {
                BillDAO.Instance.InsertBill(banan.MaBan);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), Mamon, amount);

            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(MaBill, Mamon, amount);
            }
            ShowBill(banan.MaBan);
            LoadBanan();
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Banan banan = lsvBill.Tag as Banan;
            int MaBill = BillDAO.Instance.GetUnCheckBillIDByTableID(banan.MaBan);
            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            if (MaBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc chăn muốn thanh toán {0}\n Tổng Tiền= {1} ₫", banan.TenBan, totalPrice), "Thống báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.Checkout(MaBill, (float)totalPrice);
                    ShowBill(banan.MaBan);
                }

            }
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void monAnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke fr = new Thongke();
            fr.ShowDialog();
        }

        private void fBanan_Click(object sender, EventArgs e)
        {
            fBanan banan = new fBanan();
            banan.ShowDialog();
        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaiKhoan frTaikhoan = new fTaiKhoan();
            frTaikhoan.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login flogin = new Login();
            flogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBanan();
        }
    }

}
