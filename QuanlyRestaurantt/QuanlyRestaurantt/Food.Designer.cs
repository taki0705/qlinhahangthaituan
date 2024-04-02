namespace QuanlyRestaurantt
{
    partial class frFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frFood));
            btntimkiem = new Button();
            foodList = new DataGridView();
            txttimkiem = new TextBox();
            timkiem = new Label();
            btnsua = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            txttenmon = new TextBox();
            txtmamon = new TextBox();
            txbgia = new Label();
            label6 = new Label();
            txtdanhmuc = new Label();
            lb = new Label();
            label1 = new Label();
            txtdm = new TextBox();
            txtgia = new TextBox();
            dgvdanmuc = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)foodList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdanmuc).BeginInit();
            SuspendLayout();
            // 
            // btntimkiem
            // 
            btntimkiem.BackColor = Color.White;
            btntimkiem.BackgroundImage = (Image)resources.GetObject("btntimkiem.BackgroundImage");
            btntimkiem.BackgroundImageLayout = ImageLayout.None;
            btntimkiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btntimkiem.Location = new Point(1013, 25);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(133, 40);
            btntimkiem.TabIndex = 77;
            btntimkiem.Text = "Search";
            btntimkiem.UseVisualStyleBackColor = false;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // foodList
            // 
            foodList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foodList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foodList.Location = new Point(555, 83);
            foodList.Name = "foodList";
            foodList.RowHeadersWidth = 51;
            foodList.RowTemplate.Height = 29;
            foodList.Size = new Size(645, 204);
            foodList.TabIndex = 74;
            foodList.CellClick += foodList_CellClick;
            // 
            // txttimkiem
            // 
            txttimkiem.BackColor = SystemColors.InactiveCaption;
            txttimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiem.Location = new Point(658, 29);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(331, 34);
            txttimkiem.TabIndex = 73;
            // 
            // timkiem
            // 
            timkiem.AutoSize = true;
            timkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timkiem.Location = new Point(411, 32);
            timkiem.Name = "timkiem";
            timkiem.Size = new Size(231, 28);
            timkiem.TabIndex = 72;
            timkiem.Text = "Tìm Kiếm theo Danh mục";
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.White;
            btnsua.BackgroundImage = (Image)resources.GetObject("btnsua.BackgroundImage");
            btnsua.BackgroundImageLayout = ImageLayout.None;
            btnsua.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnsua.Location = new Point(165, 360);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(119, 40);
            btnsua.TabIndex = 70;
            btnsua.Text = "      Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.White;
            btnxoa.BackgroundImage = (Image)resources.GetObject("btnxoa.BackgroundImage");
            btnxoa.BackgroundImageLayout = ImageLayout.None;
            btnxoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnxoa.Location = new Point(305, 360);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(119, 40);
            btnxoa.TabIndex = 69;
            btnxoa.Text = "      Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.White;
            btnthem.BackgroundImage = (Image)resources.GetObject("btnthem.BackgroundImage");
            btnthem.BackgroundImageLayout = ImageLayout.None;
            btnthem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnthem.Location = new Point(19, 360);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(119, 40);
            btnthem.TabIndex = 68;
            btnthem.Text = "      Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // txttenmon
            // 
            txttenmon.BackColor = SystemColors.InactiveCaption;
            txttenmon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttenmon.Location = new Point(200, 212);
            txttenmon.Name = "txttenmon";
            txttenmon.Size = new Size(331, 34);
            txttenmon.TabIndex = 65;
            // 
            // txtmamon
            // 
            txtmamon.BackColor = SystemColors.InactiveCaption;
            txtmamon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmamon.Location = new Point(200, 83);
            txtmamon.Name = "txtmamon";
            txtmamon.Size = new Size(331, 34);
            txtmamon.TabIndex = 62;
            // 
            // txbgia
            // 
            txbgia.AutoSize = true;
            txbgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbgia.Location = new Point(38, 279);
            txbgia.Name = "txbgia";
            txbgia.Size = new Size(41, 28);
            txbgia.TabIndex = 59;
            txbgia.Text = "Giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 212);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 58;
            label6.Text = "Tên món";
            // 
            // txtdanhmuc
            // 
            txtdanhmuc.AutoSize = true;
            txtdanhmuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdanhmuc.Location = new Point(38, 148);
            txtdanhmuc.Name = "txtdanhmuc";
            txtdanhmuc.Size = new Size(100, 28);
            txtdanhmuc.TabIndex = 57;
            txtdanhmuc.Text = "Danh mục";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb.Location = new Point(37, 85);
            lb.Name = "lb";
            lb.Size = new Size(86, 28);
            lb.TabIndex = 54;
            lb.Text = "Mã Món";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 53;
            label1.Text = "Thông tin chi tiết";
            // 
            // txtdm
            // 
            txtdm.BackColor = SystemColors.InactiveCaption;
            txtdm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdm.Location = new Point(200, 145);
            txtdm.Name = "txtdm";
            txtdm.Size = new Size(331, 34);
            txtdm.TabIndex = 81;
            // 
            // txtgia
            // 
            txtgia.BackColor = SystemColors.InactiveCaption;
            txtgia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtgia.Location = new Point(200, 273);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(331, 34);
            txtgia.TabIndex = 82;
            // 
            // dgvdanmuc
            // 
            dgvdanmuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdanmuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanmuc.Location = new Point(542, 333);
            dgvdanmuc.Name = "dgvdanmuc";
            dgvdanmuc.RowHeadersWidth = 51;
            dgvdanmuc.RowTemplate.Height = 29;
            dgvdanmuc.Size = new Size(670, 204);
            dgvdanmuc.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(537, 289);
            label2.Name = "label2";
            label2.Size = new Size(222, 41);
            label2.TabIndex = 84;
            label2.Text = "Danh mục món";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(457, 344);
            button1.Name = "button1";
            button1.Size = new Size(63, 56);
            button1.TabIndex = 85;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1095, 543);
            button2.Name = "button2";
            button2.Size = new Size(129, 40);
            button2.TabIndex = 86;
            button2.Text = "      Trở lại";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1237, 587);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dgvdanmuc);
            Controls.Add(txtgia);
            Controls.Add(txtdm);
            Controls.Add(btntimkiem);
            Controls.Add(foodList);
            Controls.Add(txttimkiem);
            Controls.Add(timkiem);
            Controls.Add(btnsua);
            Controls.Add(btnxoa);
            Controls.Add(btnthem);
            Controls.Add(txttenmon);
            Controls.Add(txtmamon);
            Controls.Add(txbgia);
            Controls.Add(label6);
            Controls.Add(txtdanhmuc);
            Controls.Add(lb);
            Controls.Add(label1);
            Name = "frFood";
            Text = "Food";
            Load += frFood_Load;
            ((System.ComponentModel.ISupportInitialize)foodList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdanmuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btntimkiem;
        private DataGridView foodList;
        private TextBox txttimkiem;
        private Label timkiem;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthem;
        private TextBox txttenmon;
        private TextBox txtmamon;
        private Label txbgia;
        private Label label6;
        private Label txtdanhmuc;
        private Label lb;
        private Label label1;
        private TextBox txtdm;
        private TextBox txtgia;
        private DataGridView dgvdanmuc;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}