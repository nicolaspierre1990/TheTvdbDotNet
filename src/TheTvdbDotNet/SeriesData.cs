using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class SeriesData
    {
        [JsonPropertyName("data")]
        public Series Data { get; set; }

        [JsonPropertyName("errors")]
        public JsonErrors Errors { get; set; }

    }
}
