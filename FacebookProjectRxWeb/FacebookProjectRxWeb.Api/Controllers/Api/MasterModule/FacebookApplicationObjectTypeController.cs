using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FacebookProjectRxWeb.UnitOfWork.Main;
using FacebookProjectRxWeb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FacebookProjectRxWeb.Api.Controllers.MasterModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class FacebookApplicationObjectTypeController : BaseController<FacebookApplicationObjectType,FacebookApplicationObjectType,FacebookApplicationObjectType>

    {
        public FacebookApplicationObjectTypeController(MasterUow uow):base(uow) {}

    }
}
