using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.FacebookuserModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using FBRxweb.Models.ViewModels;
namespace FBRxweb.Api.Controllers.FacebookuserModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class FacebookUsersController : BaseDomainController<FacebookUserModel, FacebookUserModel>

    {
        public FacebookUsersController(IFacebookUserDomain domain):base(domain) {}

    }
}
