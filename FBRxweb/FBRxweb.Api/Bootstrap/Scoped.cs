#region Namespace
using Microsoft.Extensions.DependencyInjection;
using FBRxweb.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using FBRxweb.UnitOfWork.DbEntityAudit;
using FBRxweb.BoundedContext.Main;
using FBRxweb.UnitOfWork.Main;
//using FBRxweb.Domain.Module;
            using FBRxweb.Domain.PostModule;
            using FBRxweb.Domain.VPostModule;
            #endregion Namespace






namespace FBRxweb.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
             
            serviceCollection.AddScoped<IFacebookContext, FacebookContext>();
            serviceCollection.AddScoped<IFacebookUow, FacebookUow>();
                        serviceCollection.AddScoped<IPostContext, PostContext>();
            serviceCollection.AddScoped<IPostUow, PostUow>();
                        serviceCollection.AddScoped<IVPostContext, VPostContext>();
            serviceCollection.AddScoped<IVPostUow, VPostUow>();
            #endregion ContextService







            #region DomainService

            
            serviceCollection.AddScoped<IPostDomain, PostDomain>();
            
            serviceCollection.AddScoped<IPostDomain, PostDomain>();
            
            serviceCollection.AddScoped<IvPostDomain, vPostDomain>();
            
            serviceCollection.AddScoped<IVPostDomain, VPostDomain>();
            #endregion DomainService




        }
    }
}



