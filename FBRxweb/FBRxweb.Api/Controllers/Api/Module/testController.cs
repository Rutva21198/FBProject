using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.Module
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class testController : BaseController<test,test,test>

    {
        public testController(IUow uow):base(uow) {}

    }
}
