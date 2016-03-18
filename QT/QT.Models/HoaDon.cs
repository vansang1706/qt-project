using System;
using System.ComponentModel.DataAnnotations;
using QT.Repository.Pattern.Ef6;

namespace QT.Models
{
    public class HoaDon:Entity
    {
        [Key]
        public int Id { get; set; }
        public int KhachHangId { get; set; }
        public float TongTien { get; set; }
        public DateTime NgayLap { get; set; }
    }
}
