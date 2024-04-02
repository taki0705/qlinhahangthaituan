namespace QuanlyRestaurantt
{
    partial class fBanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBanan));
            dgvBanan = new DataGridView();
            sua = new Button();
            xoa = new Button();
            them = new Button();
            txttenban = new TextBox();
            txtmaban = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txttrangthai = new TextBox();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBanan).BeginInit();
            SuspendLayout();
            // 
            // dgvBanan
            // 
            dgvBanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanan.Location = new Point(522, 12);
            dgvBanan.Name = "dgvBanan";
            dgvBanan.RowHeadersWidth = 51;
            dgvBanan.RowTemplate.Height = 29;
            dgvBanan.Size = new Size(473, 247);
            dgvBanan.TabIndex = 74;
            dgvBanan.CellContentClick += dgvBanan_CellContentClick;
            dgvBanan.Click += dgvBanan_Click;
            // 
            // sua
            // 
            sua.BackColor = Color.White;
            sua.BackgroundImage = (Image)resources.GetObject("sua.BackgroundImage");
            sua.BackgroundImageLayout = ImageLayout.None;
            sua.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sua.Location = new Point(207, 231);
            sua.Name = "sua";
            sua.Size = new Size(119, 51);
            sua.TabIndex = 70;
            sua.Text = "      Sửa";
            sua.UseVisualStyleBackColor = false;
            sua.Click += sua_Click;
            // 
            // xoa
            // 
            xoa.BackColor = Color.White;
            xoa.BackgroundImage = (Image)resources.GetObject("xoa.BackgroundImage");
            xoa.BackgroundImageLayout = ImageLayout.None;
            xoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            xoa.Location = new Point(349, 231);
            xoa.Name = "xoa";
            xoa.Size = new Size(119, 45);
            xoa.TabIndex = 69;
            xoa.Text = "      Xóa";
            xoa.UseVisualStyleBackColor = false;
            xoa.Click += xoa_Click;
            // 
            // them
            // 
            them.BackColor = Color.White;
            them.BackgroundImage = (Image)resources.GetObject("them.BackgroundImage");
            them.BackgroundImageLayout = ImageLayout.None;
            them.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            them.Location = new Point(43, 231);
            them.Name = "them";
            them.Size = new Size(119, 51);
            them.TabIndex = 68;
            them.Text = "      Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // txttenban
            // 
            txttenban.BackColor = SystemColors.InactiveCaption;
            txttenban.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttenban.Location = new Point(173, 84);
            txttenban.Name = "txttenban";
            txttenban.Size = new Size(331, 34);
            txttenban.TabIndex = 63;
            // 
            // txtmaban
            // 
            txtmaban.BackColor = SystemColors.InactiveCaption;
            txtmaban.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmaban.Location = new Point(173, 37);
            txtmaban.Name = "txtmaban";
            txtmaban.Size = new Size(331, 34);
            txtmaban.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 95);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 55;
            label3.Text = "Tên Bàn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 41);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 54;
            label2.Text = "Mã Bàn";
            // 
            // txttrangthai
            // 
            txttrangthai.BackColor = SystemColors.InactiveCaption;
            txttrangthai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttrangthai.Location = new Point(173, 141);
            txttrangthai.Name = "txttrangthai";
            txttrangthai.Size = new Size(331, 34);
            txttrangthai.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 148);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 75;
            label5.Text = "Trạng Thái";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(844, 297);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 77;
            button1.Text = "      Trở lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // fBanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1022, 371);
            Controls.Add(button1);
            Controls.Add(txttrangthai);
            Controls.Add(label5);
            Controls.Add(dgvBanan);
            Controls.Add(sua);
            Controls.Add(xoa);
            Controls.Add(them);
            Controls.Add(txttenban);
            Controls.Add(txtmaban);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "fBanan";
            Text = "fBanan";
            Load += fBanan_Load;
            DoubleClick += fBanan_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dgvBanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btntimkiem;
        private DateTimePicker txtnvl;
        private DateTimePicker txtngaysinh;
        private DataGridView dgvBanan;
        private TextBox txttimkiem;
        private Label timkiem;
        private Button button1;
        private Button sua;
        private Button xoa;
        private Button them;
        private TextBox txtluong;
        private TextBox txtsdt;
        private TextBox txtdiachi;
        private TextBox txttenban;
        private TextBox txtmaban;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txttrangthai;
        private Label label5;
    }
}