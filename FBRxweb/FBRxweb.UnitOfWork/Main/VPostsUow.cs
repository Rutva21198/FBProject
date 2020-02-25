using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class VPostsUow : BaseUow, IVPostsUow
    {
        public VPostsUow(IVPostsContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IVPostsUow : ICoreUnitOfWork { }
}


