using Cleverbit.CodingTask.DataAccess.DataAccess.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cleverbit.CodingTask.DataAccess.DataAccess.UnitOfWork
{
 public  interface IUnitOfWork
    {
        IMatchesRepo Matches { get; }
    }
}
