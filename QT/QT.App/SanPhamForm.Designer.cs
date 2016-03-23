namespace QT.App
{
    partial class SanPhamForm
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
            this.tabQuanLySanPham = new System.Windows.Forms.TabPage();
            this.btCapNhatSanPham = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btThemSanPham = new System.Windows.Forms.Button();
            this.tabThemSuaSanPham = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDonViTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.nudSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabQuanLySanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tabThemSuaSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuanLySanPham);
            this.tabControl1.Controls.Add(this.tabThemSuaSanPham);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 276);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuanLySanPham
            // 
            this.tabQuanLySanPham.Controls.Add(this.btCapNhatSanPham);
            this.tabQuanLySanPham.Controls.Add(this.dgvSanPham);
            this.tabQuanLySanPham.Controls.Add(this.btThemSanPham);
            this.tabQuanLySanPham.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLySanPham.Name = "tabQuanLySanPham";
            this.tabQuanLySanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLySanPham.Size = new System.Drawing.Size(509, 250);
            this.tabQuanLySanPham.TabIndex = 0;
            this.tabQuanLySanPham.Text = "Quản Lý Sản Phẩm";
            this.tabQuanLySanPham.UseVisualStyleBackColor = true;
            // 
            // btCapNhatSanPham
            // 
            this.btCapNhatSanPham.Location = new System.Drawing.Point(158, 207);
            this.btCapNhatSanPham.Name = "btCapNhatSanPham";
            this.btCapNhatSanPham.Size = new System.Drawing.Size(128, 23);
            this.btCapNhatSanPham.TabIndex = 2;
            this.btCapNhatSanPham.Text = "Cập Nhật Sản Phẩm";
            this.btCapNhatSanPham.UseVisualStyleBackColor = true;
            this.btCapNhatSanPham.Click += new System.EventHandler(this.btCapNhatSanPham_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenSanPham,
            this.donViTinh,
            this.soLuongTon});
            this.dgvSanPham.Location = new System.Drawing.Point(6, 6);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(497, 184);
            this.dgvSanPham.TabIndex = 1;
            // 
            // btThemSanPham
            // 
            this.btThemSanPham.Location = new System.Drawing.Point(18, 207);
            this.btThemSanPham.Name = "btThemSanPham";
            this.btThemSanPham.Size = new System.Drawing.Size(109, 23);
            this.btThemSanPham.TabIndex = 0;
            this.btThemSanPham.Text = "Thêm Sản Phẩm";
            this.btThemSanPham.UseVisualStyleBackColor = true;
            this.btThemSanPham.Click += new System.EventHandler(this.btThemSanPham_Click);
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
            this.tabThemSuaSanPham.Size = new System.Drawing.Size(509, 250);
            this.tabThemSuaSanPham.TabIndex = 1;
            this.tabThemSuaSanPham.Text = "Thêm Sản Phẩm";
            this.tabThemSuaSanPham.UseVisualStyleBackColor = true;
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
            // stt
            // 
            this.stt.DataPropertyName = "Id";
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stt.Width = 50;
            // 
            // tenSanPham
            // 
            this.tenSanPham.DataPropertyName = "TenSanPham";
            this.tenSanPham.HeaderText = "Tên Sản Phẩm";
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenSanPham.Width = 150;
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "DonViTinh";
            this.donViTinh.HeaderText = "Đơn Vị Tính";
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.donViTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // soLuongTon
            // 
            this.soLuongTon.DataPropertyName = "SoLuongTon";
            this.soLuongTon.HeaderText = "Số Lượng Tồn";
            this.soLuongTon.Name = "soLuongTon";
            this.soLuongTon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 464);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPhamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.SanPhamForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabQuanLySanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tabThemSuaSanPham.ResumeLayout(false);
            this.tabThemSuaSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongTon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQuanLySanPham;
        private System.Windows.Forms.Button btCapNhatSanPham;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btThemSanPham;
        private System.Windows.Forms.TabPage tabThemSuaSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDonViTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.NumericUpDown nudSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTon;

    }
}

