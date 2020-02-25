using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.Module
{
    public class vPostDomain : IvPostDomain
    {
        public vPostDomain(IUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync( parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy( parameters)
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

        public HashSet<string> DeleteValidation( parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync( parameters)
        {
            throw new NotImplementedException();
        }

        public IUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvPostDomain : ICoreDomain<vPost,> { }
}
