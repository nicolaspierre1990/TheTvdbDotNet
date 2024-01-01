using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class Update
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("lastUpdated")]
        public int LastUpdated { get; set; }
    }
}
