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
    }
}
