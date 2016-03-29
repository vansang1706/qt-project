namespace QT.App
{
    partial class HoaDonForm
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
            this.tabQuanLyHoaDon = new System.Windows.Forms.TabPage();
            this.btXemChiTietHoaDon = new System.Windows.Forms.Button();
            this.btCapNhatHoaDon = new System.Windows.Forms.Button();
            this.btThemHoaDon = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabThemSuaHoaDon = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.dgvThemSuaHoaDon = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPham = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabQuanLyHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.tabThemSuaHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemSuaHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuanLyHoaDon);
            this.tabControl1.Controls.Add(this.tabThemSuaHoaDon);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tabQuanLyHoaDon
            // 
            this.tabQuanLyHoaDon.Controls.Add(this.btXemChiTietHoaDon);
            this.tabQuanLyHoaDon.Controls.Add(this.btCapNhatHoaDon);
            this.tabQuanLyHoaDon.Controls.Add(this.btThemHoaDon);
            this.tabQuanLyHoaDon.Controls.Add(this.dgvHoaDon);
            this.tabQuanLyHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyHoaDon.Name = "tabQuanLyHoaDon";
            this.tabQuanLyHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyHoaDon.Size = new System.Drawing.Size(668, 250);
            this.tabQuanLyHoaDon.TabIndex = 0;
            this.tabQuanLyHoaDon.Text = "Quản Lý Hóa Đơn";
            this.tabQuanLyHoaDon.UseVisualStyleBackColor = true;
            // 
            // btXemChiTietHoaDon
            // 
            this.btXemChiTietHoaDon.Location = new System.Drawing.Point(320, 191);
            this.btXemChiTietHoaDon.Name = "btXemChiTietHoaDon";
            this.btXemChiTietHoaDon.Size = new System.Drawing.Size(130, 23);
            this.btXemChiTietHoaDon.TabIndex = 1;
            this.btXemChiTietHoaDon.Text = "Xem Chi Tiết Hóa Đơn";
            this.btXemChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // btCapNhatHoaDon
            // 
            this.btCapNhatHoaDon.Location = new System.Drawing.Point(169, 191);
            this.btCapNhatHoaDon.Name = "btCapNhatHoaDon";
            this.btCapNhatHoaDon.Size = new System.Drawing.Size(110, 23);
            this.btCapNhatHoaDon.TabIndex = 1;
            this.btCapNhatHoaDon.Text = "Cập Nhật Hóa Đơn";
            this.btCapNhatHoaDon.UseVisualStyleBackColor = true;
            // 
            // btThemHoaDon
            // 
            this.btThemHoaDon.Location = new System.Drawing.Point(51, 191);
            this.btThemHoaDon.Name = "btThemHoaDon";
            this.btThemHoaDon.Size = new System.Drawing.Size(92, 23);
            this.btThemHoaDon.TabIndex = 1;
            this.btThemHoaDon.Text = "Thêm Hóa Đơn";
            this.btThemHoaDon.UseVisualStyleBackColor = true;
            this.btThemHoaDon.Click += new System.EventHandler(this.btThemHoaDon_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.khachHang,
            this.tongTien,
            this.ngayLap});
            this.dgvHoaDon.Location = new System.Drawing.Point(6, 6);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(656, 150);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 50;
            // 
            // khachHang
            // 
            this.khachHang.DataPropertyName = "KhachHang";
            this.khachHang.HeaderText = "Khách Hàng";
            this.khachHang.Name = "khachHang";
            this.khachHang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.khachHang.Width = 150;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "TongTien";
            this.tongTien.HeaderText = "Tổng Tiền";
            this.tongTien.Name = "tongTien";
            this.tongTien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ngayLap
            // 
            this.ngayLap.DataPropertyName = "NgayLap";
            this.ngayLap.HeaderText = "Ngày Lập";
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabThemSuaHoaDon
            // 
            this.tabThemSuaHoaDon.Controls.Add(this.dgvThemSuaHoaDon);
            this.tabThemSuaHoaDon.Controls.Add(this.cbKhachHang);
            this.tabThemSuaHoaDon.Controls.Add(this.label1);
            this.tabThemSuaHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tabThemSuaHoaDon.Name = "tabThemSuaHoaDon";
            this.tabThemSuaHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabThemSuaHoaDon.Size = new System.Drawing.Size(714, 250);
            this.tabThemSuaHoaDon.TabIndex = 1;
            this.tabThemSuaHoaDon.Text = "Thêm Hóa Đơn";
            this.tabThemSuaHoaDon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(117, 18);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(121, 21);
            this.cbKhachHang.TabIndex = 1;
            // 
            // dgvThemSuaHoaDon
            // 
            this.dgvThemSuaHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemSuaHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.sanPham,
            this.soLuong,
            this.giaBan,
            this.thanhTien,
            this.delete});
            this.dgvThemSuaHoaDon.Location = new System.Drawing.Point(25, 71);
            this.dgvThemSuaHoaDon.Name = "dgvThemSuaHoaDon";
            this.dgvThemSuaHoaDon.Size = new System.Drawing.Size(662, 150);
            this.dgvThemSuaHoaDon.TabIndex = 2;
            this.dgvThemSuaHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemSuaHoaDon_CellContentClick);
            this.dgvThemSuaHoaDon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvThemSuaHoaDon_RowsAdded);
            this.dgvThemSuaHoaDon.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvThemSuaHoaDon_RowsRemoved);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stt.Width = 50;
            // 
            // sanPham
            // 
            this.sanPham.HeaderText = "Sản Phẩm";
            this.sanPham.Name = "sanPham";
            this.sanPham.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sanPham.Width = 150;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // giaBan
            // 
            this.giaBan.HeaderText = "Giá Bán";
            this.giaBan.Name = "giaBan";
            this.giaBan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành Tiền";
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.Text = "Delete";
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 425);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonForm";
            this.Load += new System.EventHandler(this.HoaDonForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabQuanLyHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.tabThemSuaHoaDon.ResumeLayout(false);
            this.tabThemSuaHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemSuaHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuanLyHoaDon;
        private System.Windows.Forms.TabPage tabThemSuaHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btXemChiTietHoaDon;
        private System.Windows.Forms.Button btCapNhatHoaDon;
        private System.Windows.Forms.Button btThemHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridView dgvThemSuaHoaDon;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewComboBoxColumn sanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}