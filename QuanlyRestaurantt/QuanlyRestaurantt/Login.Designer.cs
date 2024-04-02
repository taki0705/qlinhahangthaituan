namespace QuanlyRestaurantt
{
    partial class Login

    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txttaikhoan = new TextBox();
            txtmatkhau = new TextBox();
            danhnhap = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-23, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 341);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(377, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 70);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(309, 101);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 2;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(309, 163);
            label3.Name = "label3";
            label3.Size = new Size(142, 41);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // txttaikhoan
            // 
            txttaikhoan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txttaikhoan.Location = new Point(489, 95);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(298, 47);
            txttaikhoan.TabIndex = 4;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.Location = new Point(489, 157);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(298, 47);
            txtmatkhau.TabIndex = 5;
            txtmatkhau.UseSystemPasswordChar = true;
            // 
            // danhnhap
            // 
            danhnhap.Location = new Point(489, 221);
            danhnhap.Name = "danhnhap";
            danhnhap.Size = new Size(118, 45);
            danhnhap.TabIndex = 6;
            danhnhap.Text = "Đăng nhập";
            danhnhap.UseVisualStyleBackColor = true;
            danhnhap.Click += danhnhap_Click;
            // 
            // button2
            // 
            button2.Location = new Point(669, 221);
            button2.Name = "button2";
            button2.Size = new Size(118, 45);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 295);
            Controls.Add(button2);
            Controls.Add(danhnhap);
            Controls.Add(txtmatkhau);
            Controls.Add(txttaikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txttaikhoan;
        private TextBox txtmatkhau;
        private Button danhnhap;
        private Button button2;
    }
}