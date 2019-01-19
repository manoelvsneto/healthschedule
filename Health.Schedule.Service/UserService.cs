using Health.Schedule.Repository;
using Health.Schedule.Shared;
using System;
using System.Threading.Tasks;

namespace Health.Schedule.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;

        public UserService(IUnitOfWork unit)
        {
            _uow = unit;
        }

        public async Task<DataReturn> Add(User classe)
        {
            DataReturn dataReturn = new DataReturn();
            dataReturn.Code = 0;
            dataReturn.Message = "Success";
            try
            {
                await _uow.GetRepositoryAsync<User>().AddAsync(classe);
                _uow.SaveChanges();
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

        public async Task<DataReturn> Validate(string query)
        {

            DataReturn dataReturn = new DataReturn();
            dataReturn.Code = 0;
            dataReturn.Message = "Success";
            try
            {
                string email = query.Split('|')[0];
                string password = query.Split('|')[0];

                User dados = await _uow.GetRepositoryAsync<User>().SingleAsync(x => x.Email == email && x.Password == password);
                dataReturn.Data = dados.UserGuid;
            }
            catch (Exception ex)
            {
                dataReturn.ExceptionError = ex;
            }
            return dataReturn;
        }
    }
}
