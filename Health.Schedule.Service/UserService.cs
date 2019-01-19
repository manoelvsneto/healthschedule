using Health.Schedule.Repository;
using Health.Schedule.Shared;
using System;
using System.Threading.Tasks;

namespace Health.Schedule.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        private readonly IRepository<User> _repo;

        public UserService(IUnitOfWork unit, IRepository<User> repo)
        {
            _uow = unit;
            _repo = repo;
        }

        public async Task<DataReturn> Add(User classe)
        {
            DataReturn dataReturn = new DataReturn();
            dataReturn.Code = 0;
            dataReturn.Message = "Success";
            try
            {
                await _repo.Add(classe);
                _uow.Commit();
                dataReturn.Data = true;
            }
            catch (Exception ex)
            {
                dataReturn.Code = 1;
                dataReturn.Message = "Error";
                dataReturn.ExceptionError = ex;
            }
            return dataReturn;
        }

        public async Task<DataReturn> Delete(User classe)
        {
            throw new NotImplementedException();
        }

        public async Task<DataReturn> Update(User classe)
        {
            throw new NotImplementedException();
        }
    }
}
