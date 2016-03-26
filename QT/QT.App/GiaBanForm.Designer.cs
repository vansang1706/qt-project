namespace QT.App
{
    partial class GiaBanForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuanLyGiaBan = new System.Windows.Forms.TabPage();
            this.tabThemSuaGiaBan = new System.Windows.Forms.TabPage();
            this.dgvGiaBan = new System.Windows.Forms.DataGridView();
            this.btCapNhatGiaBan = new System.Windows.Forms.Button();
            this.btThemGiaBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.nudGiaBan = new System.Windows.Forms.NumericUpDown();
            this.btThem = new System.Windows.Forms.Button();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabQuanLyGiaBan.SuspendLayout();
            this.tabThemSuaGiaBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuanLyGiaBan);
            this.tabControl1.Controls.Add(this.tabThemSuaGiaBan);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 276);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuanLyGiaBan
            // 
            this.tabQuanLyGiaBan.Controls.Add(this.btThemGiaBan);
            this.tabQuanLyGiaBan.Controls.Add(this.btCapNhatGiaBan);
            this.tabQuanLyGiaBan.Controls.Add(this.dgvGiaBan);
            this.tabQuanLyGiaBan.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyGiaBan.Name = "tabQuanLyGiaBan";
            this.tabQuanLyGiaBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyGiaBan.Size = new System.Drawing.Size(668, 250);
            this.tabQuanLyGiaBan.TabIndex = 0;
            this.tabQuanLyGiaBan.Text = "Quản Lý Giá Bán";
            this.tabQuanLyGiaBan.UseVisualStyleBackColor = true;
            // 
            // tabThemSuaGiaBan
            // 
            this.tabThemSuaGiaBan.Controls.Add(this.btThem);
            this.tabThemSuaGiaBan.Controls.Add(this.nudGiaBan);
            this.tabThemSuaGiaBan.Controls.Add(this.cbKhachHang);
            this.tabThemSuaGiaBan.Controls.Add(this.cbSanPham);
            this.tabThemSuaGiaBan.Controls.Add(this.label3);
            this.tabThemSuaGiaBan.Controls.Add(this.label2);
            this.tabThemSuaGiaBan.Controls.Add(this.label1);
            this.tabThemSuaGiaBan.Location = new System.Drawing.Point(4, 22);
            this.tabThemSuaGiaBan.Name = "tabThemSuaGiaBan";
            this.tabThemSuaGiaBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabThemSuaGiaBan.Size = new System.Drawing.Size(668, 250);
            this.tabThemSuaGiaBan.TabIndex = 1;
            this.tabThemSuaGiaBan.Text = "Thêm Giá Bán";
            this.tabThemSuaGiaBan.UseVisualStyleBackColor = true;
            // 
            // dgvGiaBan
            // 
            this.dgvGiaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.sanPham,
            this.khachHang,
            this.giaBan,
            this.ngayCapNhat});
            this.dgvGiaBan.Location = new System.Drawing.Point(6, 6);
            this.dgvGiaBan.Name = "dgvGiaBan";
            this.dgvGiaBan.Size = new System.Drawing.Size(656, 150);
            this.dgvGiaBan.TabIndex = 0;
            // 
            // btCapNhatGiaBan
            // 
            this.btCapNhatGiaBan.Location = new System.Drawing.Point(305, 185);
            this.btCapNhatGiaBan.Name = "btCapNhatGiaBan";
            this.btCapNhatGiaBan.Size = new System.Drawing.Size(145, 23);
            this.btCapNhatGiaBan.TabIndex = 1;
            this.btCapNhatGiaBan.Text = "Cập Nhật Giá Bán";
            this.btCapNhatGiaBan.UseVisualStyleBackColor = true;
            this.btCapNhatGiaBan.Click += new System.EventHandler(this.btCapNhatGiaBan_Click);
            // 
            // btThemGiaBan
            // 
            this.btThemGiaBan.Location = new System.Drawing.Point(135, 185);
            this.btThemGiaBan.Name = "btThemGiaBan";
            this.btThemGiaBan.Size = new System.Drawing.Size(95, 23);
            this.btThemGiaBan.TabIndex = 1;
            this.btThemGiaBan.Text = "Thêm Giá Bán";
            this.btThemGiaBan.UseVisualStyleBackColor = true;
            this.btThemGiaBan.Click += new System.EventHandler(this.btThemGiaBan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá Bán";
            // 
            // cbSanPham
            // 
            this.cbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(106, 15);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(121, 21);
            this.cbSanPham.TabIndex = 1;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(106, 42);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(121, 21);
            this.cbKhachHang.TabIndex = 1;
            // 
            // nudGiaBan
            // 
            this.nudGiaBan.Location = new System.Drawing.Point(106, 73);
            this.nudGiaBan.Name = "nudGiaBan";
            this.nudGiaBan.Size = new System.Drawing.Size(120, 20);
            this.nudGiaBan.TabIndex = 2;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(126, 121);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "Stt";
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stt.Width = 50;
            // 
            // sanPham
            // 
            this.sanPham.DataPropertyName = "SanPham";
            this.sanPham.HeaderText = "Sản Phẩm";
            this.sanPham.Name = "sanPham";
            this.sanPham.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sanPham.Width = 150;
            // 
            // khachHang
            // 
            this.khachHang.DataPropertyName = "KhachHang";
            this.khachHang.HeaderText = "Khách Hàng";
            this.khachHang.Name = "khachHang";
            this.khachHang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.khachHang.Width = 150;
            // 
            // giaBan
            // 
            this.giaBan.DataPropertyName = "Gia";
            this.giaBan.HeaderText = "Giá Bán";
            this.giaBan.Name = "giaBan";
            this.giaBan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ngayCapNhat
            // 
            this.ngayCapNhat.DataPropertyName = "NgayThayDoi";
            this.ngayCapNhat.HeaderText = "Ngày Cập Nhật";
            this.ngayCapNhat.Name = "ngayCapNhat";
            this.ngayCapNhat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ngayCapNhat.Width = 150;
            // 
            // GiaBanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 464);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaBanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaBanForm";
            this.Load += new System.EventHandler(this.GiaBanForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabQuanLyGiaBan.ResumeLayout(false);
            this.tabThemSuaGiaBan.ResumeLayout(false);
            this.tabThemSuaGiaBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuanLyGiaBan;
        private System.Windows.Forms.TabPage tabThemSuaGiaBan;
        private System.Windows.Forms.DataGridView dgvGiaBan;
        private System.Windows.Forms.Button btThemGiaBan;
        private System.Windows.Forms.Button btCapNhatGiaBan;
        private System.Windows.Forms.NumericUpDown nudGiaBan;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapNhat;
    }
}