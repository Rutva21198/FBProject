using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.EducationDetailModule
{
    public class EducationDetailDomain : IEducationDetailDomain
    {
        public EducationDetailDomain(IEducationDetailUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(EducationDetail parameters)
        {
            return await Uow.Repository<EducationDetail>().AllAsync();
            //throw new NotImplementedException();
        }

        public async Task<object> GetBy(EducationDetail parameters)
        {
            return await Uow.Repository<EducationDetail>().FindByAsync(t=>t.UserId==parameters.UserId);
           
            //throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(EducationDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(EducationDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(EducationDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(EducationDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(EducationDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(EducationDetail parameters)
        {
            throw new NotImplementedException();
        }

        public IEducationDetailUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IEducationDetailDomain : ICoreDomain<EducationDetail, EducationDetail> { }
}
