using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.PostLikeModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.PostLikeModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class PostLikesController : BaseDomainController<PostLike, PostLike>

    {
        public PostLikesController(IPostLikeDomain domain):base(domain) {}

    }
}
