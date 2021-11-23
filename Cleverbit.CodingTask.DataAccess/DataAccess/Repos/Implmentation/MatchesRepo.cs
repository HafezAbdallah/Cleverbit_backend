using Cleverbit.CodingTask.Data;
using Cleverbit.CodingTask.Data.Models;
using Cleverbit.CodingTask.DataAccess.DataAccess.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.CodingTask.DataAccess.DataAccess.Repos.Implmentation
{
    public class MatchesRepo : GenericRepo<Match>,IMatchesRepo
    {
        public MatchesRepo(CodingTaskContext context) : base(context)
        {
        }

        public async Task<List<Match>> GetAllMatches()
        {
            var result= await GetAllAsync(GetNavigationProprties());
            return result;
        }

        public override List<Expression<Func<Match, object>>> GetNavigationProprties()
        {
            List<Expression<Func<Match, object>>> nps = new List<Expression<Func<Match, object>>>();
            nps.Add(x => x.Players);
            nps.Add(x => x.Winner);
            return nps;
        }
    }
}
