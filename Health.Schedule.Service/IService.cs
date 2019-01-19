using Health.Schedule.Shared;
using System.Threading.Tasks;

namespace Health.Schedule.Service
{
    public interface IUserService : IService<User>
    {
        Task<DataReturn> Validate(string query);
    }
    public interface IService<T>
    {
        Task<DataReturn> Add(T classe);
        Task<DataReturn> Delete(T classe);
        Task<DataReturn> Update(T classe);
    }
}

