using Cleverbit.CodingTask.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.CodingTask.Business.Interfaces
{
    public interface IMatchBusiness
    {
        Task<List<Match>> GetAllMatches();
    }
}
