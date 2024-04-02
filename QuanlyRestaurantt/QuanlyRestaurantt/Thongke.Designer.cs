namespace QuanlyRestaurantt
{
    partial class Thongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongke));
            dtpcheckin = new DateTimePicker();
            dtpcheckout = new DateTimePicker();
            btnThongke = new Button();
            dgvBill = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // dtpcheckin
            // 
            dtpcheckin.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dtpcheckin.Format = DateTimePickerFormat.Short;
            dtpcheckin.Location = new Point(106, 21);
            dtpcheckin.Name = "dtpcheckin";
            dtpcheckin.Size = new Size(250, 27);
            dtpcheckin.TabIndex = 0;
            // 
            // dtpcheckout
            // 
            dtpcheckout.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dtpcheckout.Format = DateTimePickerFormat.Short;
            dtpcheckout.Location = new Point(106, 54);
            dtpcheckout.Name = "dtpcheckout";
            dtpcheckout.Size = new Size(250, 27);
            dtpcheckout.TabIndex = 1;
            // 
            // btnThongke
            // 
            btnThongke.Location = new Point(380, 21);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(182, 60);
            btnThongke.TabIndex = 2;
            btnThongke.Text = "Thống kê doanh thu";
            btnThongke.UseVisualStyleBackColor = true;
            btnThongke.Click += btnThongke_Click;
            // 
            // dgvBill
            // 
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(37, 104);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.Size = new Size(840, 364);
            dgvBill.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(782, 478);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 22;
            button1.Text = "      Trở lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 530);
            Controls.Add(button1);
            Controls.Add(dgvBill);
            Controls.Add(btnThongke);
            Controls.Add(dtpcheckout);
            Controls.Add(dtpcheckin);
            Name = "Thongke";
            Text = "Thongke";
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpcheckin;
        private DateTimePicker dtpcheckout;
        private Button btnThongke;
        private DataGridView dgvBill;
        private Button button1;
    }
}