using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.VPostModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class VPostsController : BaseController<VPost,VPost,VPost>

    {
        public VPostsController(IVPostsUow uow):base(uow) {}

    }
}
