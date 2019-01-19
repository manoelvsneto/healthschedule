using Health.Schedule.Data;
using System;

namespace Health.Schedule.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        DataContext Context { get; }
        void Commit();
    }
}
