using System.ComponentModel.DataAnnotations;
using QT.Repository.Pattern.Ef6;

namespace QT.Models
{
    public class ChiTietHoaDon:Entity
    {
        [Key]
        public int Id { get; set; }
        public int HoaDonId { get; set; }
        public int SanPhamId { get; set; }
        public float SoLuong { get; set; }
        public float Gia { get; set; }
        public float ThanhTien { get; set; }
    }
}
