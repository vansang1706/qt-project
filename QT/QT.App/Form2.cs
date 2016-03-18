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
        private readonly IKhachHangService _khachHangService;
        public Form2()
        {
            InitializeComponent();
            _khachHangService = UnityConfig.GetContainer().Resolve<IKhachHangService>();
        }

        private void btThemKhachHang_Click(object sender, EventArgs e)
        {
            var khachHangs = _khachHangService.GetAllKhachHang();
            foreach (var kHang in khachHangs)
            {
                if (kHang.HoTen == tbHoTen.Text)
                {
                    MessageBox.Show("Khach hang da co");
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
            MessageBox.Show("Them thanh cong");
        }
    }
}
