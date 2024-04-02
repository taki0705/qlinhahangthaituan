namespace QuanlyRestaurantt
{
    partial class Hethong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hethong));
            menuStrip1 = new MenuStrip();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            danhMucToolStripMenuItem = new ToolStripMenuItem();
            mónĂnToolStripMenuItem = new ToolStripMenuItem();
            fBanan = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            btnadd = new Button();
            CbCate = new ComboBox();
            cbFood = new ComboBox();
            nmFoodCount = new NumericUpDown();
            button18 = new Button();
            flpTable = new FlowLayoutPanel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            txbTotalPrice = new TextBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem, danhMucToolStripMenuItem, mónĂnToolStripMenuItem, fBanan, báoCáoToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1464, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nhânViênToolStripMenuItem.ForeColor = Color.Black;
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(165, 45);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // danhMucToolStripMenuItem
            // 
            danhMucToolStripMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            danhMucToolStripMenuItem.ForeColor = Color.Black;
            danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            danhMucToolStripMenuItem.Size = new Size(157, 45);
            danhMucToolStripMenuItem.Text = "Thống kê";
            danhMucToolStripMenuItem.Click += danhMucToolStripMenuItem_Click;
            // 
            // mónĂnToolStripMenuItem
            // 
            mónĂnToolStripMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            mónĂnToolStripMenuItem.ForeColor = Color.Black;
            mónĂnToolStripMenuItem.Name = "mónĂnToolStripMenuItem";
            mónĂnToolStripMenuItem.Size = new Size(134, 45);
            mónĂnToolStripMenuItem.Text = "Món ăn";
            mónĂnToolStripMenuItem.Click += mónĂnToolStripMenuItem_Click;
            // 
            // fBanan
            // 
            fBanan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            fBanan.Name = "fBanan";
            fBanan.Size = new Size(121, 45);
            fBanan.Text = "Bàn ăn";
            fBanan.Click += fBanan_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(159, 45);
            báoCáoToolStripMenuItem.Text = "Tài Khoản";
            báoCáoToolStripMenuItem.Click += báoCáoToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(171, 45);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // btnadd
            // 
            btnadd.BackgroundImage = (Image)resources.GetObject("btnadd.BackgroundImage");
            btnadd.BackgroundImageLayout = ImageLayout.Stretch;
            btnadd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnadd.ForeColor = SystemColors.Desktop;
            btnadd.Location = new Point(1265, 257);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(108, 101);
            btnadd.TabIndex = 17;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // CbCate
            // 
            CbCate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CbCate.FormattingEnabled = true;
            CbCate.Location = new Point(775, 261);
            CbCate.Name = "CbCate";
            CbCate.Size = new Size(272, 36);
            CbCate.TabIndex = 20;
            CbCate.SelectedIndexChanged += cbCategory;
            // 
            // cbFood
            // 
            cbFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(775, 322);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(272, 36);
            cbFood.TabIndex = 21;
            cbFood.SelectedIndexChanged += cbFood_SelectedIndexChanged;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            nmFoodCount.Location = new Point(1087, 257);
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(87, 57);
            nmFoodCount.TabIndex = 22;
            nmFoodCount.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button18
            // 
            button18.BackgroundImage = (Image)resources.GetObject("button18.BackgroundImage");
            button18.BackgroundImageLayout = ImageLayout.Stretch;
            button18.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button18.ForeColor = Color.Black;
            button18.Location = new Point(1180, 426);
            button18.Name = "button18";
            button18.Size = new Size(193, 92);
            button18.TabIndex = 24;
            button18.Text = "Thanh Toán";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(24, 52);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(718, 466);
            flpTable.TabIndex = 25;
            flpTable.Paint += flpTable_Paint;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(775, 52);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(598, 186);
            lsvBill.TabIndex = 26;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            lsvBill.SelectedIndexChanged += lsvBill_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành Tiền";
            columnHeader4.Width = 150;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            txbTotalPrice.Location = new Point(973, 448);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(186, 70);
            txbTotalPrice.TabIndex = 27;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            txbTotalPrice.TextChanged += txbTotalPrice_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(674, 524);
            button1.Name = "button1";
            button1.Size = new Size(68, 43);
            button1.TabIndex = 28;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Hethong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1464, 575);
            Controls.Add(button1);
            Controls.Add(lsvBill);
            Controls.Add(txbTotalPrice);
            Controls.Add(flpTable);
            Controls.Add(button18);
            Controls.Add(nmFoodCount);
            Controls.Add(cbFood);
            Controls.Add(CbCate);
            Controls.Add(btnadd);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            MainMenuStrip = menuStrip1;
            Name = "Hethong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hethong";
            Load += Hethong_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhMucToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private Button btnadd;
        private ToolStripMenuItem mónĂnToolStripMenuItem;
        private ComboBox CbCate;
        private ComboBox cbFood;
        private NumericUpDown nmFoodCount;
        private Button button18;
        private FlowLayoutPanel flpTable;
        private ListView lsvBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private ToolStripMenuItem fBanan;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Button button1;
    }
}