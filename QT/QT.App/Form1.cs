using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using QT.IoC.Unity;
using QT.Models;
using QT.Services;

namespace QT.App
{
    public partial class Form1 : Form
    {
        private readonly ISanPhamService _sanPhamService;
        public Form1()
        {
            InitializeComponent();
            _sanPhamService = UnityConfig.GetContainer().Resolve<ISanPhamService>();
            pnSanPham.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Show();
        }

        private void tmSanPham_Click(object sender, EventArgs e)
        {
            pnSanPham.Show();
            tabControl1.TabPages.Remove(tabThemSuaSanPham);
        }

        private void btThemSanPham_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabThemSuaSanPham))
            {
                tabControl1.TabPages.Add(tabThemSuaSanPham);
                tabThemSuaSanPham.Text = "Thêm Sản Phẩm";
                tabControl1.SelectedTab = tabThemSuaSanPham;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (tabControl1.TabCount > 1)
                {
                    tabControl1.TabPages.RemoveAt(1);
                }
                
            }

        }
    }
}
