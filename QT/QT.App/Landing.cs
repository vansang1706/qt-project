using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.App
{
    public partial class Landing : Form
    {
        private SanPhamForm _sanPhamForm = SanPhamForm.Instance();
        private KhachHangForm _khachHangForm = KhachHangForm.Instance();
        public Landing()
        {
            InitializeComponent();
            _sanPhamForm.MdiParent = this;
            _khachHangForm.MdiParent = this;
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _khachHangForm.Hide();
            _sanPhamForm.Show();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sanPhamForm.Hide();
            _khachHangForm.Show();
        }
    }
}
