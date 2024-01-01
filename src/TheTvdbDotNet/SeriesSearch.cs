using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class SeriesSearch
    {
        [JsonPropertyName("data")]
        public SeriesSearchData[] Data { get; set; }
    }
}
