using System.Text.Json.Serialization;

namespace CanWeFixItApi.Model
{
    public class InstrumentDto
    {
        [JsonPropertyName("instumentId")]
        public int Id { get; set; }

        [JsonPropertyName("instumentName")]
        public string Name { get; set; }

        [JsonPropertyName("instumentSedol")]
        public string Sedol { get; set; }

        [JsonPropertyName("instumentIsActive")]
        public bool Active { get; set; }

    }
}
