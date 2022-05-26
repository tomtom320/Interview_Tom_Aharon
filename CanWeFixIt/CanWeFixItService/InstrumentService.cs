using CanWeFixItData;
using CanWeFixItData.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CanWeFixItService
{

    public interface IInstrumentService
    {
        Task<IEnumerable<Instrument>> GetActiveInstruments();
    }


    public class InstrumentService : IInstrumentService
    {
        private readonly IDatabase _database;

        public InstrumentService(IDatabase database)
        {
            _database = database;
        }

        public async Task<IEnumerable<Instrument>> GetActiveInstruments()
        {
            return await _database.Instruments();
        }




    }
}
