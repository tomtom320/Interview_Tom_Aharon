using CanWeFixItData.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CanWeFixItData
{
    public interface IDatabase
    {
        Task<IEnumerable<Instrument>> Instruments();
        Task<IEnumerable<Market>> MarketData();
        Task<IEnumerable<MarketValuation>> MarketValidations();
        void SetupDatabase();
    }
}