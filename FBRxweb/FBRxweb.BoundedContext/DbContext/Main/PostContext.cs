using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FBRxweb.BoundedContext.SqlContext;
using FBRxweb.Models.Main;
using FBRxweb.Models;
using FBRxweb.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace FBRxweb.BoundedContext.Main
{
    public class PostContext : BaseBoundedContext, IPostContext
    {
        public PostContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets 
        public DbSet<Post> Posts { get; set; }
        public DbSet<vPost> vPosts { get; set; }
        public DbSet<PostLike> PostLike { get; set; }
		public DbSet<PostCaption> PostCaption { get; set; }
		public DbSet<PostComment> PostComment { get; set; }
		public DbSet<PostShare> PostShare { get; set; }
		public DbSet<FacebookUser> FacebookUser { get; set; }
            		public DbSet<PostMessage> PostMessage { get; set; } 
		
            #endregion DbSets



    }


    public interface IPostContext : IDbContext
    {
    }
}

