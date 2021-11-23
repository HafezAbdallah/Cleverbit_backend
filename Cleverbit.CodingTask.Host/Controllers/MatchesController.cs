using Cleverbit.CodingTask.Business.Interfaces;
using Cleverbit.CodingTask.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cleverbit.CodingTask.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : Controller
    {
        private readonly IMatchBusiness _matchesBusiness;
        public MatchesController(IMatchBusiness matchesBusiness)
        {
            _matchesBusiness = matchesBusiness;
        }

        [HttpGet]
        public async Task<ActionResult<List<Match>>> Get()
        {
           var result=await _matchesBusiness.GetAllMatches();
            return Ok(result);
        }

    }
}
