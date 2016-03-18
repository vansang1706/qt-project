using QT.Models;
using QT.Service.Pattern;

namespace QT.Services
{
    public interface IKhachHangService:IService<KhachHang>
    {
        void InsertKhachHang(KhachHang khachHang);
    }
}
