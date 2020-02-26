using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class ViewPostUow : BaseUow, IViewPostUow
    {
        public ViewPostUow(IViewPostContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IViewPostUow : ICoreUnitOfWork { }
}


