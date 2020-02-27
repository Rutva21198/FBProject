using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.LikeModule
{
    public class LikeDomain : ILikeDomain
    {
        public LikeDomain(ILikeUow uow) {
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
        

        public HashSet<string> AddValidation(Like entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Like entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Like entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Like entity)
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

        public ILikeUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface ILikeDomain : ICoreDomain<Like> { }
}
