namespace QuanlyRestaurantt
{
    partial class fTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTaiKhoan));
            txttk = new TextBox();
            txtmk = new TextBox();
            lb = new Label();
            label2 = new Label();
            dtgtaikhoan = new DataGridView();
            btnthem = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            button1 = new Button();
            label1 = new Label();
            txtid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgtaikhoan).BeginInit();
            SuspendLayout();
            // 
            // txttk
            // 
            txttk.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txttk.Location = new Point(758, 97);
            txttk.Name = "txttk";
            txttk.Size = new Size(161, 43);
            txttk.TabIndex = 0;
            txttk.TextChanged += txttk_TextChanged;
            // 
            // txtmk
            // 
            txtmk.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtmk.Location = new Point(758, 153);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(161, 43);
            txtmk.TabIndex = 1;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb.Location = new Point(587, 97);
            lb.Name = "lb";
            lb.Size = new Size(145, 41);
            lb.TabIndex = 2;
            lb.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(587, 159);
            label2.Name = "label2";
            label2.Size = new Size(144, 41);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            // 
            // dtgtaikhoan
            // 
            dtgtaikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgtaikhoan.Location = new Point(69, 41);
            dtgtaikhoan.Name = "dtgtaikhoan";
            dtgtaikhoan.RowHeadersWidth = 51;
            dtgtaikhoan.RowTemplate.Height = 29;
            dtgtaikhoan.Size = new Size(438, 339);
            dtgtaikhoan.TabIndex = 4;
            dtgtaikhoan.CellContentClick += dtgtaikhoan_CellContentClick;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(598, 245);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(112, 47);
            btnthem.TabIndex = 5;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(717, 245);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(112, 47);
            btnsua.TabIndex = 6;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(836, 245);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(112, 47);
            btnxoa.TabIndex = 7;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(831, 397);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 22;
            button1.Text = "      Trở lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(587, 41);
            label1.Name = "label1";
            label1.Size = new Size(47, 41);
            label1.TabIndex = 23;
            label1.Text = "ID";
            // 
            // txtid
            // 
            txtid.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtid.Location = new Point(758, 41);
            txtid.Name = "txtid";
            txtid.Size = new Size(161, 43);
            txtid.TabIndex = 24;
            // 
            // fTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1024, 451);
            Controls.Add(txtid);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(dtgtaikhoan);
            Controls.Add(label2);
            Controls.Add(lb);
            Controls.Add(txtmk);
            Controls.Add(txttk);
            Name = "fTaiKhoan";
            Text = "fTaiKhoan";
            Load += fTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)dtgtaikhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttk;
        private TextBox txtmk;
        private Label lb;
        private Label label2;
        private DataGridView dtgtaikhoan;
        private Button btnthem;
        private Button btnsua;
        private Button btnxoa;
        private Button button1;
        private Label label1;
        private TextBox txtid;
    }
}