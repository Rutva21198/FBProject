using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.Module;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.Module
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class vPostsController : BaseDomainController<vPost>

    {
        public vPostsController(IvPostDomain domain):base(domain) {}

    }
}
