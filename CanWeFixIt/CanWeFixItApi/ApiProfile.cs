using AutoMapper;
using CanWeFixItService;

namespace CanWeFixItApi
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<MarketData, MarketDataDto>();
        }
    }
}
