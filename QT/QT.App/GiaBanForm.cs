using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using QT.Globalization;
using QT.IoC.Unity;
using QT.Models;
using QT.Services;

namespace QT.App
{
    public partial class GiaBanForm : Form
    {
        private readonly IGiaBanService _giaBanService;
        private readonly ISanPhamService _sanPhamService;
        private readonly IKhachHangService _khachHangService;
        private GiaBan _giaBanToUpdate;
        private static GiaBanForm _instance;

        public static GiaBanForm Instance()
        {
            if (_instance == null)
            {
                _instance = new GiaBanForm();
            }

            return _instance;
        }
        private GiaBanForm()
        {
            InitializeComponent();
            _giaBanService = UnityConfig.GetContainer().Resolve<IGiaBanService>();
            _sanPhamService = UnityConfig.GetContainer().Resolve<ISanPhamService>();
            _khachHangService = UnityConfig.GetContainer().Resolve<IKhachHangService>();
        }

        private void GiaBanForm_Load(object sender, System.EventArgs e)
        {
            dgvGiaBan.AutoGenerateColumns = false;
            FillGiaBanToDataGridView();
            tabControl1.TabPages.Remove(tabThemSuaGiaBan);

            var sanPhams = _sanPhamService.GetAllSanPham();
            cbSanPham.DataSource = sanPhams;
            cbSanPham.DisplayMember = "TenSanPham";
            cbSanPham.ValueMember = "Id";

            var khachHangs = _khachHangService.GetAllKhachHang();
            cbKhachHang.DataSource = khachHangs;
            cbKhachHang.DisplayMember = "HoTen";
            cbKhachHang.ValueMember = "Id";
        }

        private void FillGiaBanToDataGridView()
        {
            var giaBans = _giaBanService.GetAllGiaBanToDataGridView();
            dgvGiaBan.DataSource = giaBans;
        }

        private void btThemGiaBan_Click(object sender, System.EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabThemSuaGiaBan))
            {
                tabControl1.TabPages.Add(tabThemSuaGiaBan);
                tabThemSuaGiaBan.Text = QT_Messages.ThemGiaBanText;
                tabControl1.SelectedTab = tabThemSuaGiaBan;

                cbKhachHang.Text = string.Empty;
                cbSanPham.Text = string.Empty;

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (tabControl1.TabCount > 1)
                {
                    tabControl1.TabPages.RemoveAt(1);
                }
                FillGiaBanToDataGridView();
            }
        }

        private void btCapNhatGiaBan_Click(object sender, System.EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabThemSuaGiaBan))
            {
                tabControl1.TabPages.Add(tabThemSuaGiaBan);
                tabThemSuaGiaBan.Text = QT_Messages.CapNhatGiaBanText;
                tabControl1.SelectedTab = tabThemSuaGiaBan;
                btThem.Text = "Cập Nhật";

                int rowIndex = dgvGiaBan.SelectedCells[0].RowIndex;
                var sPham = _sanPhamService.GetSanPhamByTenSanPham(dgvGiaBan.Rows[rowIndex].Cells[1].Value.ToString());
                cbSanPham.SelectedItem = sPham;

                var kHang =
                    _khachHangService.GetKhachHangByTenKhachHang(dgvGiaBan.Rows[rowIndex].Cells[2].Value.ToString());
                cbKhachHang.SelectedItem = kHang;

                nudGiaBan.Text = dgvGiaBan.Rows[rowIndex].Cells[3].Value.ToString();

                _giaBanToUpdate = _giaBanService.GetGiaBanById((int)dgvGiaBan.Rows[rowIndex].Cells[0].Value);

                cbSanPham.Enabled = false;
                cbKhachHang.Enabled = false;
            }

        }

        private void btThem_Click(object sender, System.EventArgs e)
        {
            if (tabThemSuaGiaBan.Text == QT_Messages.ThemGiaBanText)
            {
                var giaBans = _giaBanService.GetAllGiaBan();
                foreach (var gBan in giaBans)
                {
                    if ((int)cbSanPham.SelectedValue==gBan.SanPhamId && (int)cbKhachHang.SelectedValue==gBan.KhachHangId)
                    {
                        MessageBox.Show("Giá bán của sản phẩm cho khách hàng này đã có");
                        return;
                    }
                }
                var giaBan = new GiaBan
                {
                    SanPhamId = (int)cbSanPham.SelectedValue,
                    KhachHangId = (int)cbKhachHang.SelectedValue,
                    Gia = double.Parse(nudGiaBan.Text),
                    NgayThayDoi = DateTime.Now
                };
                _giaBanService.InsertGiaBan(giaBan);
                MessageBox.Show("Thêm giá bán thành công");
            }
            else
            {
                var gBan = _giaBanToUpdate;
                gBan.Gia = double.Parse(nudGiaBan.Text);
                gBan.NgayThayDoi = DateTime.Now;
                _giaBanService.UpdateGiaBan(gBan);
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
