using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using QT.IoC.Unity;
using QT.Models;
using QT.Services;

namespace QT.App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btThemKhachHang_Click(object sender, EventArgs e)
        {
            var a = UnityConfig.GetContainer();
            var b = a.Resolve<IKhachHangService>();
            var khachHang = new KhachHang
            {
                HoTen = tbHoTen.Text,
                DiaChi = tbDiaChi.Text,
                SoDienThoai = tbSoDienThoai.Text
            };
            b.InsertKhachHang(khachHang);
            MessageBox.Show("Them thanh cong");
        }
    }
}
