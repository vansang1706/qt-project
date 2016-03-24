using System.Collections.Generic;
using QT.Models;
using QT.Models.ViewModel;
using QT.Service.Pattern;

namespace QT.Services
{
    public interface IGiaBanService:IService<GiaBan>
    {
        List<GiaBanViewModel> GetAllGiaBan();
    }
}
