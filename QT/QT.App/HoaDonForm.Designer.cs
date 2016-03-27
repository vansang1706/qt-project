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
            this.tabThemSuaHoaDon = new System.Windows.Forms.TabPage();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabQuanLyHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuanLyHoaDon);
            this.tabControl1.Controls.Add(this.tabThemSuaHoaDon);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 276);
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
            // tabThemSuaHoaDon
            // 
            this.tabThemSuaHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tabThemSuaHoaDon.Name = "tabThemSuaHoaDon";
            this.tabThemSuaHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabThemSuaHoaDon.Size = new System.Drawing.Size(668, 250);
            this.tabThemSuaHoaDon.TabIndex = 1;
            this.tabThemSuaHoaDon.Text = "Thêm Hóa Đơn";
            this.tabThemSuaHoaDon.UseVisualStyleBackColor = true;
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
    }
}