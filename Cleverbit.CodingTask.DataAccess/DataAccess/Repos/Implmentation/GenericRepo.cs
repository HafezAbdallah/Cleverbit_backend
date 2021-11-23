using Cleverbit.CodingTask.Data;
using Cleverbit.CodingTask.DataAccess.DataAccess.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.CodingTask.DataAccess.DataAccess.Repos.Implmentation
{
  public abstract class GenericRepo<T>: IGenericRepo<T> where T:class
    {
        private readonly CodingTaskContext _context;
        protected readonly DbSet<T> _dbset;
       public GenericRepo(CodingTaskContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }


        public Task<List<T>> GetAllAsync()
        {
          return  _dbset.AsNoTracking().ToListAsync();
        }

        public Task<List<T>> GetAllAsync(List<Expression<Func<T,object>>> navigationProprties)
        {
            IQueryable<T> query = _dbset;
            foreach(var np in navigationProprties)
            {
                query = query.Include<T,object>(np);
            }
            return query.AsNoTracking().ToListAsync();
        }

        public abstract List<Expression<Func<T, object>>> GetNavigationProprties();
       
    }
}
