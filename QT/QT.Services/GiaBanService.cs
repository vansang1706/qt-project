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

        public List<GiaBanViewModel> GetAllGiaBanToDataGridView()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var listGiaBan =
                Queryable()
                    .Join(_unitOfWork.Repository<SanPham>().Queryable(), gb => gb.SanPhamId, sp => sp.Id,
                        (gb, sp) => new
                        {
                            gb.Id,
                            sp.TenSanPham,
                            gb.KhachHangId,
                            gb.Gia,
                            gb.NgayThayDoi
                        })
                    .Join(_unitOfWork.Repository<KhachHang>().Queryable(), gb => gb.KhachHangId, kh => kh.Id,
                        (gb, kh) => new GiaBanViewModel
                        {
                            Stt = gb.Id,
                            SanPham = gb.TenSanPham,
                            KhachHang = kh.HoTen,
                            Gia = gb.Gia,
                            NgayThayDoi = gb.NgayThayDoi
                        })
                    .ToList();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            return listGiaBan;
        }

        public List<GiaBan> GetAllGiaBan()
        {
            return Queryable().ToList();
        }

        public void InsertGiaBan(GiaBan giaBan)
        {
            Insert(giaBan);
            _unitOfWork.SaveChanges();
        }

        public GiaBan GetGiaBanById(int id)
        {
            return Queryable().FirstOrDefault(g => g.Id == id);
        }

        public void UpdateGiaBan(GiaBan giaBan)
        {
            Update(giaBan);
            _unitOfWork.SaveChanges();
        }
    }
}
