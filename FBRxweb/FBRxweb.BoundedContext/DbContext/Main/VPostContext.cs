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
    public class VPostContext : BaseBoundedContext, IVPostContext
    {
        public VPostContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            #endregion DbSets

    }


    public interface IVPostContext : IDbContext
    {
    }
}

