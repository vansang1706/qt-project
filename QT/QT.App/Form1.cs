using System;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using QT.IoC.Unity;
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
            //IUnityContainer container = null;
            //container = new UnityContainer();
            //container.RegisterType<ISanPhamService, SanPhamService>(new PerResolveLifetimeManager());
            //container.Resolve<ISanPhamService>().InsertSanPham();
            var a = UnityConfig.GetContainer();
            var b = a.Resolve<ISanPhamService>();
            b.InsertSanPham();
            MessageBox.Show("Hello", "lvs");
        }
    }
}
