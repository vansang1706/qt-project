using System.ComponentModel.DataAnnotations;
using QT.Repository.Pattern.Ef6;

namespace QT.Models
{
    public class SanPham:Entity
    {
        [Key]
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public double SoLuongTon { get; set; }
    }
}
