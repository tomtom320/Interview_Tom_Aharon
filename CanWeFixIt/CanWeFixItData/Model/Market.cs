namespace CanWeFixItData.Model
{
    public class Market : BaseInstrument
    {
        public int Id { get; set; }
        public long? DataValue { get; set; }
        public string Sedol { get; set; }
        public int InstrumentId { get; set; }
        public bool Active { get; set; }
    }

}