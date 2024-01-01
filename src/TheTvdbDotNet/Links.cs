using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class Links
    {
        [JsonPropertyName("first")]
        public int? First { get; set; }

        [JsonPropertyName("last")]
        public int? Last { get; set; }

        [JsonPropertyName("next")]
        public int? Next { get; set; }

        [JsonPropertyName("previous")]
        public int? Previous { get; set; }
    }
}
