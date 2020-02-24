using FacebookProjectRxWeb.BoundedContext.Main;
using RxWeb.Core.Data;
namespace FacebookProjectRxWeb.UnitOfWork.Main
{
    public class MasterUow : BaseUow, ILoginUow
    {
        public MasterUow(ILoginContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }
    public interface IMasterUow : ICoreUnitOfWork { }
}
