using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CanWeFixItService;
using Microsoft.AspNetCore.Mvc;

namespace CanWeFixItApi.Controllers
{
    [ApiController]
    [Route("v1/marketdata")]
    public class MarketDataController : ControllerBase
    {
        private readonly IDatabaseService _database;
        private readonly IMapper _mapper;


        public MarketDataController(IDatabaseService database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarketDataDto>>> Get()
        {
            return Ok(_mapper.Map<IEnumerable<MarketDataDto>>(await _database.MarketData()));
        }

    }
}