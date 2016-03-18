using System.ComponentModel.DataAnnotations;
using QT.Repository.Pattern.Ef6;

namespace QT.Models
{
    public class KhachHang:Entity
    {
        [Key]
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
    }
}
