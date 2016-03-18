namespace QT.App
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tmKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tmGiaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tmHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tmNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuanLySanPham = new System.Windows.Forms.TabPage();
            this.tabThemSuaSanPham = new System.Windows.Forms.TabPage();
            this.pnSanPham = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDonViTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.nudSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.btThemSanPham = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabQuanLySanPham.SuspendLayout();
            this.tabThemSuaSanPham.SuspendLayout();
            this.pnSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "San Pham";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Khach Hang";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Gia Ban";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Hoa Don";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmSanPham,
            this.tmKhachHang,
            this.tmGiaBan,
            this.tmHoaDon,
            this.tmNhapHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmSanPham
            // 
            this.tmSanPham.Name = "tmSanPham";
            this.tmSanPham.Size = new System.Drawing.Size(72, 20);
            this.tmSanPham.Text = "Sản Phẩm";
            this.tmSanPham.Click += new System.EventHandler(this.tmSanPham_Click);
            // 
            // tmKhachHang
            // 
            this.tmKhachHang.Name = "tmKhachHang";
            this.tmKhachHang.Size = new System.Drawing.Size(84, 20);
            this.tmKhachHang.Text = "Khách Hàng";
            // 
            // tmGiaBan
            // 
            this.tmGiaBan.Name = "tmGiaBan";
            this.tmGiaBan.Size = new System.Drawing.Size(59, 20);
            this.tmGiaBan.Text = "Giá Bán";
            // 
            // tmHoaDon
            // 
            this.tmHoaDon.Name = "tmHoaDon";
            this.tmHoaDon.Size = new System.Drawing.Size(66, 20);
            this.tmHoaDon.Text = "Hóa Đơn";
            // 
            // tmNhapHang
            // 
            this.tmNhapHang.Name = "tmNhapHang";
            this.tmNhapHang.Size = new System.Drawing.Size(80, 20);
            this.tmNhapHang.Text = "Nhập Hàng";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuanLySanPham);
            this.tabControl1.Controls.Add(this.tabThemSuaSanPham);
            this.tabControl1.Location = new System.Drawing.Point(3, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 192);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuanLySanPham
            // 
            this.tabQuanLySanPham.Controls.Add(this.btThemSanPham);
            this.tabQuanLySanPham.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLySanPham.Name = "tabQuanLySanPham";
            this.tabQuanLySanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLySanPham.Size = new System.Drawing.Size(342, 166);
            this.tabQuanLySanPham.TabIndex = 0;
            this.tabQuanLySanPham.Text = "Quản Lý Sản Phẩm";
            this.tabQuanLySanPham.UseVisualStyleBackColor = true;
            // 
            // tabThemSuaSanPham
            // 
            this.tabThemSuaSanPham.Controls.Add(this.label1);
            this.tabThemSuaSanPham.Controls.Add(this.tbTenSanPham);
            this.tabThemSuaSanPham.Controls.Add(this.label2);
            this.tabThemSuaSanPham.Controls.Add(this.tbDonViTinh);
            this.tabThemSuaSanPham.Controls.Add(this.label3);
            this.tabThemSuaSanPham.Controls.Add(this.btThem);
            this.tabThemSuaSanPham.Controls.Add(this.nudSoLuongTon);
            this.tabThemSuaSanPham.Location = new System.Drawing.Point(4, 22);
            this.tabThemSuaSanPham.Name = "tabThemSuaSanPham";
            this.tabThemSuaSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabThemSuaSanPham.Size = new System.Drawing.Size(342, 166);
            this.tabThemSuaSanPham.TabIndex = 1;
            this.tabThemSuaSanPham.Text = "Thêm Sản Phẩm";
            this.tabThemSuaSanPham.UseVisualStyleBackColor = true;
            // 
            // pnSanPham
            // 
            this.pnSanPham.Controls.Add(this.tabControl1);
            this.pnSanPham.Location = new System.Drawing.Point(0, 30);
            this.pnSanPham.Name = "pnSanPham";
            this.pnSanPham.Size = new System.Drawing.Size(422, 255);
            this.pnSanPham.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ten San Pham";
            // 
            // tbTenSanPham
            // 
            this.tbTenSanPham.Location = new System.Drawing.Point(135, 18);
            this.tbTenSanPham.Name = "tbTenSanPham";
            this.tbTenSanPham.Size = new System.Drawing.Size(100, 20);
            this.tbTenSanPham.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Don Vi Tinh";
            // 
            // tbDonViTinh
            // 
            this.tbDonViTinh.Location = new System.Drawing.Point(135, 53);
            this.tbDonViTinh.Name = "tbDonViTinh";
            this.tbDonViTinh.Size = new System.Drawing.Size(100, 20);
            this.tbDonViTinh.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "So Luong Ton";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(135, 131);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // nudSoLuongTon
            // 
            this.nudSoLuongTon.Location = new System.Drawing.Point(135, 91);
            this.nudSoLuongTon.Name = "nudSoLuongTon";
            this.nudSoLuongTon.Size = new System.Drawing.Size(100, 20);
            this.nudSoLuongTon.TabIndex = 12;
            // 
            // btThemSanPham
            // 
            this.btThemSanPham.Location = new System.Drawing.Point(146, 112);
            this.btThemSanPham.Name = "btThemSanPham";
            this.btThemSanPham.Size = new System.Drawing.Size(109, 23);
            this.btThemSanPham.TabIndex = 0;
            this.btThemSanPham.Text = "Thêm Sản Phẩm";
            this.btThemSanPham.UseVisualStyleBackColor = true;
            this.btThemSanPham.Click += new System.EventHandler(this.btThemSanPham_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 371);
            this.Controls.Add(this.pnSanPham);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Them San Pham";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabQuanLySanPham.ResumeLayout(false);
            this.tabThemSuaSanPham.ResumeLayout(false);
            this.tabThemSuaSanPham.PerformLayout();
            this.pnSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmSanPham;
        private System.Windows.Forms.ToolStripMenuItem tmKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tmGiaBan;
        private System.Windows.Forms.ToolStripMenuItem tmHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tmNhapHang;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuanLySanPham;
        private System.Windows.Forms.TabPage tabThemSuaSanPham;
        private System.Windows.Forms.Panel pnSanPham;
        private System.Windows.Forms.Button btThemSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDonViTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.NumericUpDown nudSoLuongTon;
    }
}

