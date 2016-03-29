using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using QT.Globalization;
using QT.IoC.Unity;
using QT.Services;

namespace QT.App
{
    public partial class HoaDonForm : Form
    {
        private readonly IHoaDonService _hoaDonService;
        private readonly IKhachHangService _khachHangService;
        private readonly ISanPhamService _sanPhamService;
        //private SanPham _sanPhamToUpdate;
        private static HoaDonForm _instance;

        public static HoaDonForm Instance()
        {
            if (_instance == null)
            {
                _instance = new HoaDonForm();
            }

            return _instance;
        }
        private HoaDonForm()
        {
            InitializeComponent();
            _hoaDonService = UnityConfig.GetContainer().Resolve<IHoaDonService>();
            _khachHangService = UnityConfig.GetContainer().Resolve<IKhachHangService>();
            _sanPhamService = UnityConfig.GetContainer().Resolve<ISanPhamService>();
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            FillHoaDonToDataGridView();
            tabControl1.TabPages.Remove(tabThemSuaHoaDon);
        }

        private void FillHoaDonToDataGridView()
        {
            var hoaDons = _hoaDonService.GetAllHoaDonToDataGridView();
            dgvHoaDon.DataSource = hoaDons;
        }

        private void btThemHoaDon_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabThemSuaHoaDon))
            {
                tabControl1.TabPages.Add(tabThemSuaHoaDon);
                tabThemSuaHoaDon.Text = QT_Messages.ThemGiaBanText;
                tabControl1.SelectedTab = tabThemSuaHoaDon;

                var khachHangs = _khachHangService.GetAllKhachHang();
                cbKhachHang.DataSource = khachHangs;
                cbKhachHang.DisplayMember = "HoTen";
                cbKhachHang.ValueMember = "Id";

                sanPham.DataSource = _sanPhamService.GetAllSanPham();
                sanPham.DisplayMember = "TenSanPham";
                sanPham.ValueMember = "Id";

                delete.Text = "Delete";
                delete.UseColumnTextForButtonValue = true;
            }
        }

        private void dgvThemSuaHoaDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvThemSuaHoaDon.Columns.Contains("stt"))
            {
                foreach (DataGridViewRow r in dgvThemSuaHoaDon.Rows)
                {
                    r.Cells["stt"].Value = r.Index + 1;
                }
            }
        }

        private void dgvThemSuaHoaDon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dgvThemSuaHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
