using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.PostCommentModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.PostCommentModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class PostCommentsController : BaseDomainController<PostComment, PostComment>

    {
        public PostCommentsController(IPostCommentDomain domain):base(domain) {}

    }
}
