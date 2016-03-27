using System;
using System.Windows.Forms;

namespace QT.App
{
    public partial class Landing : Form
    {
        private readonly SanPhamForm _sanPhamForm = SanPhamForm.Instance();
        private readonly KhachHangForm _khachHangForm = KhachHangForm.Instance();
        private readonly GiaBanForm _giaBanForm = GiaBanForm.Instance();
        private readonly HoaDonForm _hoaDonForm = HoaDonForm.Instance();
        public Landing()
        {
            InitializeComponent();
            _sanPhamForm.MdiParent = this;
            _khachHangForm.MdiParent = this;
            _giaBanForm.MdiParent = this;
            _hoaDonForm.MdiParent = this;
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _giaBanForm.Hide();
            _khachHangForm.Hide();
            _hoaDonForm.Hide();
            _sanPhamForm.Show();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sanPhamForm.Hide();
            _giaBanForm.Hide();
            _hoaDonForm.Hide();
            _khachHangForm.Show();
            
        }

        private void giaBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _khachHangForm.Hide();
            _sanPhamForm.Hide();
            _hoaDonForm.Hide();
            _giaBanForm.Show();
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _khachHangForm.Hide();
            _sanPhamForm.Hide();
            _giaBanForm.Hide();
            _hoaDonForm.Show();
        }
    }
}
