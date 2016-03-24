using System.Collections.Generic;
using QT.Models;
using QT.Service.Pattern;

namespace QT.Services
{
    public interface ISanPhamService : IService<SanPham>
    {
        void InsertSanPham(SanPham sanPham);
        List<SanPham> GetAllSanPham();
        void UpdateSanPham(SanPham sanPham);
        SanPham GetSanPhamByTenSanPham(string tenSanPham);
        string GetTenSanPhamById(int id);

    }
}
