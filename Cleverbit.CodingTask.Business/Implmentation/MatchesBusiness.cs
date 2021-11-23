using Cleverbit.CodingTask.Business.Interfaces;
using Cleverbit.CodingTask.Data.Models;
using Cleverbit.CodingTask.DataAccess.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.CodingTask.Business.Implmentation
{
  public  class MatchesBusiness:IMatchBusiness
    {
        private readonly IUnitOfWork _uow;
        public MatchesBusiness(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public Task<List<Match>> GetAllMatches()
        {
           return _uow.Matches.GetAllMatches();
        }
    }
}
