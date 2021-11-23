using Cleverbit.CodingTask.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.CodingTask.DataAccess.DataAccess.Repos.Interfaces
{
    public interface IMatchesRepo:IGenericRepo<Match>
    {
        Task<List<Match>> GetAllMatches();
    }
}
