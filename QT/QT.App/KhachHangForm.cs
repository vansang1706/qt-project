using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using QT.Globalization;
using QT.IoC.Unity;
using QT.Models;
using QT.Services;

namespace QT.App
{
    public partial class KhachHangForm : Form
    {
        private readonly IKhachHangService _khachHangService;
        private KhachHang _khachHangToUpdate;
        private static KhachHangForm _instance;

        public static KhachHangForm Instance()
        {
            if (_instance == null)
            {
                _instance =  new KhachHangForm();
            }
            return _instance;
        }
        private KhachHangForm()
        {
            InitializeComponent();
            _khachHangService = UnityConfig.GetContainer().Resolve<IKhachHangService>();
        }

        private void btThemKhachHang_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabThemSuaKhachHang))
            {
                tabControl1.TabPages.Add(tabThemSuaKhachHang);
                tabThemSuaKhachHang.Text = QT_Messages.ThemKhachHangText;
                tabControl1.SelectedTab = tabThemSuaKhachHang;
                tbHoTen.Text = "";
                tbDiaChi.Text = "";
                tbSoDienThoai.Text = "";
            }
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;
            FillKhachHangToDataGridView();
            tabControl1.TabPages.Remove(tabThemSuaKhachHang);
        }

        private void FillKhachHangToDataGridView()
        {
            var khachHangs = _khachHangService.GetAllKhachHang();
            dgvKhachHang.DataSource = khachHangs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tabThemSuaKhachHang.Text == QT_Messages.ThemKhachHangText)
            {
                var khachHangs = _khachHangService.GetAllKhachHang();
                foreach (var kHang in khachHangs)
                {
                    if (tbHoTen.Text == kHang.HoTen)
                    {
                        MessageBox.Show("Khách hàng này đã có");
                        return;
                    }
                }
                var khachHang = new KhachHang
                {
                    HoTen = tbHoTen.Text,
                    DiaChi = tbDiaChi.Text,
                    SoDienThoai = tbSoDienThoai.Text

                };
                _khachHangService.InsertKhachHang(khachHang);
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
            {
                var khachHang = _khachHangToUpdate;
                khachHang.HoTen = tbHoTen.Text;
                khachHang.DiaChi = tbDiaChi.Text;
                khachHang.SoDienThoai = tbSoDienThoai.Text;
                _khachHangService.UpdateKhachHang(khachHang);
                MessageBox.Show("Cập nhật khách hàng thành công");
            }
        }

        private void btCapNhatKhachHang_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabThemSuaKhachHang))
            {
                tabControl1.TabPages.Add(tabThemSuaKhachHang);
                tabThemSuaKhachHang.Text = QT_Messages.CapNhatKhachHangText;
                tabControl1.SelectedTab = tabThemSuaKhachHang;
                int rowIndex = dgvKhachHang.SelectedCells[0].RowIndex;
                tbHoTen.Text = dgvKhachHang.Rows[rowIndex].Cells[1].Value.ToString();
                tbDiaChi.Text = dgvKhachHang.Rows[rowIndex].Cells[2].Value.ToString();
                tbSoDienThoai.Text = dgvKhachHang.Rows[rowIndex].Cells[3].Value.ToString();
                _khachHangToUpdate =
                    _khachHangService.GetKhachHangByTenKhachHang(dgvKhachHang.Rows[rowIndex].Cells[1].Value.ToString());
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (tabControl1.TabCount > 1)
                {
                    tabControl1.TabPages.RemoveAt(1);
                }
                FillKhachHangToDataGridView();
            }
        }
    }
}
