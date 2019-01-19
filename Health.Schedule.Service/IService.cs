using Health.Schedule.Shared;
using System.Threading.Tasks;

namespace Health.Schedule.Service
{
    public interface IUserService : IService<User>
    {

    }
    public interface IService<T>
    {
        Task<DataReturn> Add(T classe);
        Task<DataReturn> Delete(T classe);
        Task<DataReturn> Update(T classe);
    }
}

