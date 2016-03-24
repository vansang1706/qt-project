using System.Collections.Generic;
using System.Linq;
using QT.Models;
using QT.Repository.Pattern.UnitOfWork;
using QT.Service.Pattern;

namespace QT.Services
{
    public class KhachHangService:Service<KhachHang>, IKhachHangService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;

        public KhachHangService(IUnitOfWorkAsync unitOfWork)
            : base(unitOfWork.RepositoryAsync<KhachHang>())
        {
            _unitOfWork = unitOfWork;
        }
        public void InsertKhachHang(KhachHang khachHang)
        {
            Insert(khachHang);
            _unitOfWork.SaveChanges();
        }

        public List<KhachHang> GetAllKhachHang()
        {
            return Queryable().ToList();
        }

        public KhachHang GetKhachHangByTenKhachHang(string tenKhachHang)
        {
            return Queryable().FirstOrDefault(k => k.HoTen == tenKhachHang);
        }

        public void UpdateKhachHang(KhachHang khachHang)
        {
            Update(khachHang);
            _unitOfWork.SaveChanges();
        }

        public string GetTenKhachHangById(int id)
        {
            var firstOrDefault = Queryable().FirstOrDefault(x => x.Id == id);
            if (firstOrDefault != null) 
                return firstOrDefault.HoTen;
            return string.Empty;
        }
    }
}
