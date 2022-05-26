using System.Collections.Generic;
using System.Threading.Tasks;
using CanWeFixItService;
using Microsoft.AspNetCore.Mvc;

namespace CanWeFixItApi.Controllers
{
    [ApiController]
    [Route("v1/valuations")]
    public class MarketValuationController : ControllerBase
    {
        //private readonly IDatabaseService _database;

        //public MarketValuationController(IDatabaseService database)
        //{
        //    _database = database;
        //}

        //// GET
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<MarketValuation>>> Get()
        //{
        //    return Ok(await _database.MarketValidations());
        //}

    }
}