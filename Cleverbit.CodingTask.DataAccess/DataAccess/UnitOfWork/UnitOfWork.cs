using Cleverbit.CodingTask.Data;
using Cleverbit.CodingTask.DataAccess.DataAccess.Repos.Implmentation;
using Cleverbit.CodingTask.DataAccess.DataAccess.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cleverbit.CodingTask.DataAccess.DataAccess.UnitOfWork
{
 public  class UnitOfWork:IUnitOfWork
    {
        private readonly CodingTaskContext _context;

        public UnitOfWork(CodingTaskContext context)
        {
            _context = context;
        }
       public IMatchesRepo Matches { get { return new MatchesRepo(_context); } }
    }
}
