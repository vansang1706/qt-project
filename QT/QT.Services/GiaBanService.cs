using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QT.Models;
using QT.Models.ViewModel;
using QT.Repository.Pattern.UnitOfWork;
using QT.Service.Pattern;

namespace QT.Services
{
    
    public class GiaBanService:Service<GiaBan>,IGiaBanService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;
        private readonly ISanPhamService _sanPhamService;
        private readonly IKhachHangService _khachHangService;

        public GiaBanService(IUnitOfWorkAsync unitOfWork, ISanPhamService sanPhamService, IKhachHangService khachHangService) : base(unitOfWork.RepositoryAsync<GiaBan>())
        {
            _unitOfWork = unitOfWork;
            _sanPhamService = sanPhamService;
            _khachHangService = khachHangService;
        }

        public List<GiaBanViewModel> GetAllGiaBan()
        {
            var listGiaBan = new List<GiaBanViewModel>();
            var giaBans = Queryable().ToList();
            foreach (var giaBan in giaBans)
            {
                var tenSanPham = _sanPhamService.GetTenSanPhamById(giaBan.Id);
                var tenKhachHang = _khachHangService.GetTenKhachHangById(giaBan.Id);
                var giaBanViewModel = new GiaBanViewModel
                {
                    Stt = giaBan.Id,
                    SanPham = tenSanPham,
                    KhachHang = tenKhachHang,
                    Gia = giaBan.Gia,
                    NgayThayDoi = giaBan.NgayThayDoi
                };
                listGiaBan.Add(giaBanViewModel);
            }
            return listGiaBan;
        }
    }
}
