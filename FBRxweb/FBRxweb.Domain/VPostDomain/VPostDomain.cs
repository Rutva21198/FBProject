using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.VPostModule
{
    public class VPostDomain : IVPostDomain
    {
        public VPostDomain(IVPostsUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(Post parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(VPost parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(VPost entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(VPost entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(VPost entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(VPost entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(VPost parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(VPost parameters)
        {
            throw new NotImplementedException();
        }

        public IVPostsUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IVPostDomain : ICoreDomain<VPost, VPost> { }
}
