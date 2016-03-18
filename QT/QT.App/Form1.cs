using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using QT.IoC.Unity;
using QT.Models;
using QT.Services;

namespace QT.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = UnityConfig.GetContainer();
            var b = a.Resolve<ISanPhamService>();
            var sanPham = new SanPham
            {
                TenSanPham = tbTenSanPham.Text,
                DonViTinh = tbDonViTinh.Text,
                SoLuongTon = float.Parse(nudSoLuongTon.Text)

            };
            b.InsertSanPham(sanPham);
            MessageBox.Show("Them thanh cong");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Show();
        }
    }
}
