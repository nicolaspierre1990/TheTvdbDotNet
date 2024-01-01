using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class SeriesSearchData
    {
        [JsonPropertyName("aliases")]
        public string[] Aliases { get; set; }

        [JsonPropertyName("banner")]
        public string Banner { get; set; }

        [JsonPropertyName("firstAired")]
        public string FirstAired { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("network")]
        public string Network { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("seriesName")]
        public string SeriesName { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
