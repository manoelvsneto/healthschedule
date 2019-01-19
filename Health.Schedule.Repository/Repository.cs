using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Health.Schedule.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Add(T entity)
        {
            await _unitOfWork.Context.Set<T>().AddAsync(entity);
            return true;
        }

        public async Task<bool> Delete(T entity)
        {
            T existing = await _unitOfWork.Context.Set<T>().FindAsync(entity);
            if (existing != null) _unitOfWork.Context.Set<T>().Remove(existing);

            return true;
        }

        public async Task<IEnumerable<T>> Get()
        {
            return  _unitOfWork.Context.Set<T>().AsEnumerable<T>();
        }

        public async Task<IEnumerable<T>> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return  _unitOfWork.Context.Set<T>().Where(predicate).AsEnumerable<T>();
        }

        public async Task<bool> Update(T entity)
        {
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            _unitOfWork.Context.Set<T>().Attach(entity);
            return true;
        }
    }
}