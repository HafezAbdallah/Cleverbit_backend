using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.CodingTask.DataAccess.DataAccess.Repos.Interfaces
{
  public  interface IGenericRepo <T> where T:class
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(List<Expression<Func<T, object>>> navigationProprties);
    }
}
