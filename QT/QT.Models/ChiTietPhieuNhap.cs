using System.ComponentModel.DataAnnotations;
using QT.Repository.Pattern.Ef6;

namespace QT.Models
{
    public class ChiTietPhieuNhap:Entity
    {
        [Key]
        public int Id { get; set; }
        public int PhieuNhapId { get; set; }
        public int SanPhamId { get; set; }
        public double SoLuong { get; set; }
        public double Gia { get; set; }
        public double ThanhTien { get; set; }
    }
}
