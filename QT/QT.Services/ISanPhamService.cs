using QT.Models;
using QT.Service.Pattern;

namespace QT.Services
{
    public interface ISanPhamService : IService<SanPham>
    {
        void InsertSanPham(SanPham sanPham);
    }
}
