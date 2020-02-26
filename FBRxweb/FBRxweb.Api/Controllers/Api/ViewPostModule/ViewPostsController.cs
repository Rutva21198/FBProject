using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.ViewPostModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.ViewPostModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class ViewPostsController : BaseDomainController<vPost,vPost>

    {
        public ViewPostsController(IViewPostDomain domain):base(domain) {}

    }
}
