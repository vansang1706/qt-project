using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Models;
using QT.Service.Pattern;

namespace QT.Services
{
    public interface IKhachHangService:IService<KhachHang>
    {
        void InsertKhachHang(KhachHang khachHang);
    }
}
