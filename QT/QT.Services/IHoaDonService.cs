using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Models;
using QT.Models.ViewModel;
using QT.Service.Pattern;

namespace QT.Services
{
    public interface IHoaDonService:IService<HoaDon>
    {
        List<HoaDonViewModel> GetAllHoaDonToDataGridView();
    }
}
