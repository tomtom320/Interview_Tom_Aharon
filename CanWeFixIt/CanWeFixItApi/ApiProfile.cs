using AutoMapper;
using CanWeFixItApi.Model;
using CanWeFixItData.Model;
using CanWeFixItService;

namespace CanWeFixItApi
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<Instrument, InstrumentDto>();
            //CreateMap<Market, MarketDto>();
        }
    }
}
