using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using QT.DataAccess.Initializer;
using QT.Repository.Pattern.Ef6;
using QT.Models;

namespace QT.DataAccess.Context
{
    public class QTContext:DataContext
    {
        public QTContext() :
            base("Name=QTContext")
        {
           Database.SetInitializer(new QTInitializer(this));
        }

        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public DbSet<GiaBan> GiaBans { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
