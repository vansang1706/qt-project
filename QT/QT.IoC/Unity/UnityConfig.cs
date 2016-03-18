using Microsoft.Practices.Unity;
using QT.DataAccess.Context;
using QT.Repository.Pattern.DataContext;
using QT.Repository.Pattern.Ef6;
using QT.Repository.Pattern.UnitOfWork;
using QT.Services;

namespace QT.IoC.Unity
{
    public class UnityConfig
    {
        public static IUnityContainer GetContainer()
        {
            // register all your components with the container here
            var container = new UnityContainer();

            container
                .RegisterType<IDataContextAsync, QTContext>()
                .RegisterType<IUnitOfWorkAsync, UnitOfWork>()
                .RegisterType<ISanPhamService, SanPhamService>()
                .RegisterType<IKhachHangService, KhachHangService>();
            return container;
        }
    }
}
