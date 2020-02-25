using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class VPostUow : BaseUow, IVPostUow
    {
        public VPostUow(IVPostContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IVPostUow : ICoreUnitOfWork { }
}


