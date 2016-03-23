using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QT.Models;
using QT.Repository.Pattern.UnitOfWork;
using QT.Service.Pattern;

namespace QT.Services
{
    
    public class GiaBanService:Service<GiaBan>,IGiaBanService
    {
        private readonly IUnitOfWorkAsync _unitOfWork;

        public GiaBanService(IUnitOfWorkAsync unitOfWork) : base(unitOfWork.RepositoryAsync<GiaBan>())
        {
            _unitOfWork = unitOfWork;
        }
    }
}
