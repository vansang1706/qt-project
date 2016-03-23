namespace QT.App
{
    partial class KhachHangForm
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
            this.btThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuanLyKhachHang = new System.Windows.Forms.TabPage();
            this.btCapNhatKhachHang = new System.Windows.Forms.Button();
            this.btThemKhachHang = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.tabThemSuaKhachHang = new System.Windows.Forms.TabPage();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabQuanLyKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.tabThemSuaKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(94, 142);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm Khách Hàng";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Tên";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(94, 18);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(100, 20);
            this.tbHoTen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Điện Thoại";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(94, 47);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(100, 20);
            this.tbDiaChi.TabIndex = 2;
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Location = new System.Drawing.Point(94, 94);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(100, 20);
            this.tbSoDienThoai.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuanLyKhachHang);
            this.tabControl1.Controls.Add(this.tabThemSuaKhachHang);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 291);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuanLyKhachHang
            // 
            this.tabQuanLyKhachHang.Controls.Add(this.btCapNhatKhachHang);
            this.tabQuanLyKhachHang.Controls.Add(this.btThemKhachHang);
            this.tabQuanLyKhachHang.Controls.Add(this.dgvKhachHang);
            this.tabQuanLyKhachHang.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyKhachHang.Name = "tabQuanLyKhachHang";
            this.tabQuanLyKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyKhachHang.Size = new System.Drawing.Size(591, 265);
            this.tabQuanLyKhachHang.TabIndex = 0;
            this.tabQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.tabQuanLyKhachHang.UseVisualStyleBackColor = true;
            // 
            // btCapNhatKhachHang
            // 
            this.btCapNhatKhachHang.Location = new System.Drawing.Point(198, 233);
            this.btCapNhatKhachHang.Name = "btCapNhatKhachHang";
            this.btCapNhatKhachHang.Size = new System.Drawing.Size(129, 23);
            this.btCapNhatKhachHang.TabIndex = 2;
            this.btCapNhatKhachHang.Text = "Cập Nhật Khách Hàng";
            this.btCapNhatKhachHang.UseVisualStyleBackColor = true;
            this.btCapNhatKhachHang.Click += new System.EventHandler(this.btCapNhatKhachHang_Click);
            // 
            // btThemKhachHang
            // 
            this.btThemKhachHang.Location = new System.Drawing.Point(56, 233);
            this.btThemKhachHang.Name = "btThemKhachHang";
            this.btThemKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btThemKhachHang.TabIndex = 1;
            this.btThemKhachHang.Text = "Thêm Khách Hàng";
            this.btThemKhachHang.UseVisualStyleBackColor = true;
            this.btThemKhachHang.Click += new System.EventHandler(this.btThemKhachHang_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.HoTen,
            this.DiaChi,
            this.SoDienThoai});
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(553, 214);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabThemSuaKhachHang
            // 
            this.tabThemSuaKhachHang.Controls.Add(this.label1);
            this.tabThemSuaKhachHang.Controls.Add(this.btThem);
            this.tabThemSuaKhachHang.Controls.Add(this.tbSoDienThoai);
            this.tabThemSuaKhachHang.Controls.Add(this.tbHoTen);
            this.tabThemSuaKhachHang.Controls.Add(this.label3);
            this.tabThemSuaKhachHang.Controls.Add(this.tbDiaChi);
            this.tabThemSuaKhachHang.Controls.Add(this.label2);
            this.tabThemSuaKhachHang.Location = new System.Drawing.Point(4, 22);
            this.tabThemSuaKhachHang.Name = "tabThemSuaKhachHang";
            this.tabThemSuaKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabThemSuaKhachHang.Size = new System.Drawing.Size(591, 265);
            this.tabThemSuaKhachHang.TabIndex = 1;
            this.tabThemSuaKhachHang.Text = "Thêm Khách Hàng";
            this.tabThemSuaKhachHang.UseVisualStyleBackColor = true;
            // 
            // stt
            // 
            this.stt.DataPropertyName = "Id";
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stt.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HoTen.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DiaChi.Width = 200;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 464);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHangForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabQuanLyKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.tabThemSuaKhachHang.ResumeLayout(false);
            this.tabThemSuaKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuanLyKhachHang;
        private System.Windows.Forms.TabPage tabThemSuaKhachHang;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btCapNhatKhachHang;
        private System.Windows.Forms.Button btThemKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
    }
}