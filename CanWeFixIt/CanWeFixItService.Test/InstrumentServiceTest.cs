using CanWeFixItData;
using CanWeFixItData.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanWeFixItService.Test
{

    [TestClass]
    public class InstrumentServiceTest
    {

        private readonly Mock<IDatabase> _database;
        private readonly IInstrumentService _instrumentService;



        public InstrumentServiceTest()
        {
            IEnumerable<Instrument> list = new List<Instrument>()   {
                    new  Instrument{Id=1,Sedol="s", Active=true, Name="MyName 1"},
                    new  Instrument{Id=2,Sedol="ss", Active=true, Name="MyName 2"}
            };

            _database = new Mock<IDatabase>();
            _database.Setup(p => p.Instruments()).Returns(Task.FromResult(list));

            _instrumentService = new InstrumentService(_database.Object);
        }

        [TestMethod]
        public async Task GetActiveInstruments_WhenGetActiveInstruments_ShouldReturn2Results()
        {
            // arrange

            // act
            var inst =  await _instrumentService.GetActiveInstruments();


            // assert
            Assert.IsTrue(inst.ToList().Count == 2);
        }


    }
}
