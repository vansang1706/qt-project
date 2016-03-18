using System;
using System.ComponentModel.DataAnnotations;
using QT.Repository.Pattern.Ef6;

namespace QT.Models
{
    public class PhieuNhap:Entity
    {
        [Key]
        public int Id { get; set; }
        public string NhaPhanPhoi { get; set; }
        public double TongTien { get; set; }
        public DateTime NgayLap { get; set; }
    }
}
