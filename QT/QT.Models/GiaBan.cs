using System;
using System.ComponentModel.DataAnnotations;
using QT.Repository.Pattern.Ef6;

namespace QT.Models
{
    public class GiaBan:Entity
    {
        [Key]
        public int Id { get; set; }
        public int SanPhamId { get; set; }
        public int KhachHangId { get; set; }
        public double Gia { get; set; }
        public DateTime NgayThayDoi { get; set; }
    }
}
