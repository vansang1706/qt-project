using QT.Repository.Pattern.UnitOfWork;
using QT.Service.Pattern;
using  QT.Models;

namespace QT.Services
{
    public class SanPhamService : Service<SanPham>, ISanPhamService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;

        public SanPhamService(IUnitOfWorkAsync unitOfWork)
            : base(unitOfWork.RepositoryAsync<SanPham>())
        {
            _unitOfWork = unitOfWork;
        }

        public void InsertSanPham(SanPham sanPham)
        {
            Insert(sanPham);
            _unitOfWork.SaveChanges();
        }
    }
}
