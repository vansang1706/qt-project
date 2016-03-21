using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using QT.IoC.Unity;
using QT.Models;
using QT.Services;

namespace QT.App
{
    public partial class SanPhamForm : Form
    {
        private readonly ISanPhamService _sanPhamService;
        private SanPham _sanPhamToUpdate;
        private static SanPhamForm _instance;
 
        public static SanPhamForm Instance()
        {
          if (_instance == null)
          {
            _instance = new SanPhamForm();
          }
 
          return _instance;
        }

        private SanPhamForm()
        {
            InitializeComponent();
            _sanPhamService = UnityConfig.GetContainer().Resolve<ISanPhamService>();
        }

        private void btThemSanPham_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabThemSuaSanPham))
            {
                tabControl1.TabPages.Add(tabThemSuaSanPham);
                tabThemSuaSanPham.Text = "Thêm Sản Phẩm";
                tabControl1.SelectedTab = tabThemSuaSanPham;
                tbTenSanPham.Text = "";
                tbDonViTinh.Text = "";
                nudSoLuongTon.Text = "0";
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tabThemSuaSanPham.Text == "Thêm Sản Phẩm")
            {
                var sanPhams = _sanPhamService.GetAllSanPham();
                foreach (var sPham in sanPhams)
                {
                    if (tbTenSanPham.Text == sPham.TenSanPham)
                    {
                        MessageBox.Show("Ten san pham nay da co");
                        return;
                    }
                }
                var sanPham = new SanPham
                {
                    TenSanPham = tbTenSanPham.Text,
                    DonViTinh = tbDonViTinh.Text,
                    SoLuongTon = float.Parse(nudSoLuongTon.Text)

                };
                _sanPhamService.InsertSanPham(sanPham);
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                var sanPham = _sanPhamToUpdate;
                sanPham.TenSanPham = tbTenSanPham.Text;
                sanPham.DonViTinh = tbDonViTinh.Text;
                sanPham.SoLuongTon = float.Parse(nudSoLuongTon.Text);
                _sanPhamService.UpdateSanPham(sanPham);
                MessageBox.Show("Cập nhật thành công");
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
                FillSanPhamToDataGridView();
            }

        }

        private void FillSanPhamToDataGridView()
        {
            var sanPhams = _sanPhamService.GetAllSanPham();
            dgvSanPham.DataSource = sanPhams;
        }

        private void btCapNhatSanPham_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabThemSuaSanPham))
            {
                tabControl1.TabPages.Add(tabThemSuaSanPham);
                tabThemSuaSanPham.Text = "Cập Nhật Sản Phẩm";
                tabControl1.SelectedTab = tabThemSuaSanPham;
                int rowIndex = dgvSanPham.SelectedCells[0].RowIndex;
                tbTenSanPham.Text = dgvSanPham.Rows[rowIndex].Cells[1].Value.ToString();
                tbDonViTinh.Text = dgvSanPham.Rows[rowIndex].Cells[2].Value.ToString();
                nudSoLuongTon.Text = dgvSanPham.Rows[rowIndex].Cells[3].Value.ToString();
                _sanPhamToUpdate =
                    _sanPhamService.GetSanPhamByTenSanPham(dgvSanPham.Rows[rowIndex].Cells[1].Value.ToString());
            }
        }

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
            FillSanPhamToDataGridView();
            tabControl1.TabPages.Remove(tabThemSuaSanPham);
        }
    }
}
