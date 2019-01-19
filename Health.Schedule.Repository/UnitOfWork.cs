using Health.Schedule.Data;

namespace Health.Schedule.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DataContext Context { get; }

        public UnitOfWork(DataContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();

        }
    }
}
