using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CanWeFixItApi.Model;
using CanWeFixItService;
using Microsoft.AspNetCore.Mvc;

namespace CanWeFixItApi.Controllers
{
    [ApiController]
    [Route("v1/instruments")]
    public class InstrumentController : ControllerBase
    {

        private readonly IInstrumentService _instrumentService;
        private readonly IMapper _mapper;


        public InstrumentController(IInstrumentService instrumentService, IMapper mapper)
        {
            _instrumentService = instrumentService;
            _mapper = mapper;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InstrumentDto>>> Get()
        {
            return Ok(_mapper.Map <IEnumerable<InstrumentDto>>( await _instrumentService.GetActiveInstruments()));
        }
    }
}