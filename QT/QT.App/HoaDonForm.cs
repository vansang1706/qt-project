using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using QT.IoC.Unity;
using QT.Services;

namespace QT.App
{
    public partial class HoaDonForm : Form
    {
        private readonly IHoaDonService _hoaDonService;
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
    }
}
