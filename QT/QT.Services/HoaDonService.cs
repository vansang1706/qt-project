using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Models;
using QT.Models.ViewModel;
using QT.Repository.Pattern.UnitOfWork;
using QT.Service.Pattern;

namespace QT.Services
{
    public class HoaDonService:Service<HoaDon>,IHoaDonService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly IKhachHangService _khachHangService;
        public HoaDonService(IUnitOfWorkAsync unitOfWork, IKhachHangService khachHangService):base(unitOfWork.RepositoryAsync<HoaDon>())
        {
            _unitOfWork = unitOfWork;
            _khachHangService = khachHangService;
        }

        public List<HoaDonViewModel> GetAllHoaDonToDataGridView()
        {
            var listHoaDon =
                Queryable()
                    .Join(_unitOfWork.Repository<KhachHang>().Queryable(), hd => hd.KhachHangId, kh => kh.Id,
                        (hd, kh) => new HoaDonViewModel
                        {
                            Id = hd.Id,
                            KhachHang = kh.HoTen,
                            TongTien = hd.TongTien,
                            NgayLap = hd.NgayLap
                        })
                    .ToList();
            return listHoaDon;
        }

    }
}
