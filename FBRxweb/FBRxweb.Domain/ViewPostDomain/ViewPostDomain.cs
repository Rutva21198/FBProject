using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.ViewPostModule
{
    public class ViewPostDomain : IViewPostDomain
    {
        public ViewPostDomain(IViewPostUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vPost parameters)
        {
            return await Uow.Repository<vPost>().AllAsync();
        }

        public Task<object> GetBy(vPost parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vPost entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vPost entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vPost entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vPost entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vPost parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vPost parameters)
        {
            throw new NotImplementedException();
        }

        public IViewPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IViewPostDomain : ICoreDomain<vPost,vPost> { }
}
