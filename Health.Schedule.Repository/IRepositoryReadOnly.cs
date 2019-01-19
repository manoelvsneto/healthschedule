using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace Health.Schedule.Repository
{
    public interface IRepositoryReadOnly<T> : IReadRepository<T> where T : class
    {

    }
}
